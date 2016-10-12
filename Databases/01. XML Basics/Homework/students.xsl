<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <style>
        #table {
        font-family: Arial;
        display: table;
        border-collapse: collapse;
        text-align: center;
        }

       tr td {
       padding: 15px;
       }

      </style>
      
      <body>
        <h1>Students database</h1>
        <table bgcolor="orange" cellspacing="2" border="1px" id="table">
          <tr bgcolor="#ERERER">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>Sex</b>
            </td>
            <td>
              <b>Birth date</b>
            </td>
            <td>
              <b>Phone</b>
            </td>
            <td>
              <b>Email</b>
            </td>
            <td>
              <b>Course</b>
            </td>
            <td>
              <b>Speciality</b>
            </td>
            <td>
              <b>Faculty Number</b>
            </td>
            <td>
              <b>Exams</b>
            </td>
          </tr>
          <xsl:for-each select="/students/student">
          <tr>
            <td>
              <xsl:value-of select="name"/>
            </td>
            <td>
              <xsl:value-of select="sex"/>
            </td>
            <td>
              <xsl:value-of select="birth-date"/>
            </td>
            <td>
              <xsl:value-of select="phone"/>
            </td>
            <td>
              <xsl:value-of select="email"/>
            </td>
            <td>
              <xsl:value-of select="course"/>
            </td>
            <td>
              <xsl:value-of select="specialty"/>
            </td>
            <td>
              <xsl:value-of select="faculty-number"/>
            </td>
            <td>
              <xsl:value-of select="exams"/>
            </td>
          </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
