namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using System.Linq;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => (Car)this.GetModel(() => this.controller.Add(null)));
        }

        [TestMethod]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            Assert.ThrowsException<ArgumentNullException>(() => (Car)this.GetModel(() => this.controller.Add(car)));
        }

        [TestMethod]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            Assert.ThrowsException<ArgumentNullException>(() => (Car)this.GetModel(() => this.controller.Add(car)));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void SearchByIdShouldReturnDetail()
        {
            var model = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void SearchByValidMakeShouldReturnDetail()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("BMW"));

            foreach (var car in cars)
            {
                Assert.AreEqual(car.Make, "BMW");
            }
        }

        [TestMethod]
        public void SearchByInvalidMakeShouldThrow()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search(""));

            foreach (var car in cars)
            {
                Assert.AreEqual(car.Make, "BMW");
            }
        }

        [TestMethod]
        public void SearchByValidModelShouldThrow()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("330d"));

            foreach (var car in cars)
            {
                Assert.AreEqual( "BMW", car.Make);
            }
        }

        [TestMethod]
        public void SortByMakeReturnSortedCollection()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            var sortedCars = cars.OrderBy(c => c.Make);

            Assert.IsTrue(sortedCars.SequenceEqual(cars));
        }

        [TestMethod]
        public void SortByYearReturnSortedCollection()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            var sortedCars = cars.OrderBy(c => c.Year);

            Assert.IsTrue(sortedCars.SequenceEqual(cars));
        }

        [TestMethod]
        public void SortByInvalidOptionShouldThrow()
        {
            Assert.ThrowsException<ArgumentException>(() => (IList<Car>)this.GetModel(() => this.controller.Sort("invalid")));
        }



        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
