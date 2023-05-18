<xsl:stylesheet version="1.0"
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" omit-xml-declaration="yes"
      indent="yes" standalone="yes"   />
  <xsl:template match="/">
    <xsl:for-each select="PayablesDataSet">
      <xsl:element name="PayablesDataSet">
        <xsl:for-each select="Vendors">
          <xsl:element name="Vendors">
            <xsl:attribute name="Name">
              <xsl:value-of select="Name"/>
            </xsl:attribute>
            <xsl:attribute name="Address1">
              <xsl:value-of select="Address1"/>
            </xsl:attribute>
                <xsl:attribute name="City">
              <xsl:value-of select="City"/>
            </xsl:attribute>
            <xsl:attribute name="State">
              <xsl:value-of select="State"/>
            </xsl:attribute>
            <xsl:attribute name="ZipCode">
              <xsl:value-of select="ZipCode"/>
            </xsl:attribute>
          </xsl:element>
        </xsl:for-each>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>