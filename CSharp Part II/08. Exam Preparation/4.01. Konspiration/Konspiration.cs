namespace _01.Konspiration
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Konspiration
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }


            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    var name = lines[i].Split(new[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];

                    i += 2;

                    int openBrackets = 1;
                    var methodCalls = new List<string>();

                    while (openBrackets > 0)
                    {
                        var splitByRoundBracket = lines[i].Split('(');

                        if (splitByRoundBracket.Length > 1)
                        {
                            for (int k = 0; k < splitByRoundBracket.Length - 1; k++)
                            {
                                var methodName = ExtractMethodName(splitByRoundBracket[k]);

                                if (methodName != null)
                                {
                                    methodCalls.Add(methodName);
                                }
                            }
                        }

                        foreach (var item in lines[i])
                        {
                            if (item == '{')
                            {
                                openBrackets++;
                            }
                            else if (item == '}')
                            {
                                openBrackets--;
                            }
                        }

                        i++;
                    }

                    if (methodCalls.Count > 0)
                    {
                        Console.WriteLine(name + " -> " + methodCalls.Count + " -> " + string.Join(", ", methodCalls));
                    }
                    else
                    {
                        Console.WriteLine(name + " -> None");
                    }
                }
            }
        }

        static string ExtractMethodName(string codePiece)
        {
            var beforeBracket = codePiece.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var methodName = beforeBracket[beforeBracket.Length - 1];

            if (char.IsUpper(methodName[0]) && !beforeBracket.Contains("new"))
            {
                return methodName;
            }

            return null;
        }
    }
}
