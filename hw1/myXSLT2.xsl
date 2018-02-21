<?xml version="1.0" encoding="utf-8" ?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output method="html"/>
  <xsl:template match="/">

    <html>
        <p>Home > HW1 > myXML2.xml</p>
      
        <h2>Playlist</h2>
      
        <table border="1">
            <tr>
                <th>Title</th>
                <th>Artist</th>
                <th>Genre</th>
                <th>BPM</th>
            </tr>
            <xsl:for-each select="Playlist/Song">
            <tr>
                <td> <xsl:value-of select="Title"/> </td>
                <td> <xsl:value-of select="Artist"/> </td>
                <td> <xsl:value-of select="Genre"/> </td>
                <td> <xsl:value-of select="BPM"/> </td>
            </tr>
            </xsl:for-each>
        </table>
      </html>
  </xsl:template>
</xsl:stylesheet>
    