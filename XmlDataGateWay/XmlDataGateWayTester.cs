using System.Collections.Generic;
using System.Xml;
using BookCatalogEditingHandler.Entity;
using NUnit.Framework;
using XmlDataGateWay;

namespace BookCatalogEditingHandler.GateWay
{
  [TestFixture]
  public class XmlDataGateWayTester
  {
    private DataGateWay _dataGateWay;
    private string _xmlContent;

    [SetUp]
    public void SetUp()
    {
      _dataGateWay = new FakeXmlDataGateWay();
      _xmlContent = @"<BookCatalog>
  <Properties>
	<Property>
	  <Name>Name1</Name>
	  <Value>Value1</Value>
	</Property>
  <Property>
	  <Name>Name2</Name>
	  <Value>Value2</Value>
	</Property>
  </Properties>
  <Books>
    <BookItem>
      <Name>Book1</Name>
      <Publisher>Publisher1</Publisher>
    </BookItem>
  </Books>
</BookCatalog>";
    }

    [Test]
    public void TestCreate()
    {
      Assert.IsNotNull(_dataGateWay.BookCatalogProperties);
      Assert.AreEqual(0, _dataGateWay.BookCatalogProperties.Count);

      Assert.IsNotNull(_dataGateWay.BookItems);
      Assert.AreEqual(0, _dataGateWay.BookItems.Count);
    }

    [Test]
    public void TestRead()
    {
      Assert.IsTrue(_dataGateWay.Read(_xmlContent));

      Assert.IsNotEmpty(_dataGateWay.BookCatalogProperties);
      AssertBookProperties(_dataGateWay.BookCatalogProperties);
     
      Assert.IsNotEmpty(_dataGateWay.BookItems);
      AssertBookItems(_dataGateWay.BookItems);
    }

    [Test]
    public void TestWrite()
    {
      XmlDocument xmlDoc = new XmlDataDocument();
      xmlDoc.LoadXml(_xmlContent);

      _dataGateWay.Read(_xmlContent);

      bool writingResule = ((FakeXmlDataGateWay)_dataGateWay).Write(_xmlContent);
      Assert.IsTrue(writingResule);
      Assert.AreEqual(xmlDoc.OuterXml, ((FakeXmlDataGateWay)_dataGateWay).XmlString);
    }

    private void AssertBookItems(List<BookItem> bookItems)
    {
      List<BookItem> items = new List<BookItem>();
      items.Add(new BookItem("Book1", "Publisher1"));

      Assert.AreEqual(items.Count, bookItems.Count);

      for (int itemIndex = 0; itemIndex < items.Count; itemIndex++)
      {
        Assert.AreEqual(items[itemIndex].Name, bookItems[itemIndex].Name);
        Assert.AreEqual(items[itemIndex].Publisher, bookItems[itemIndex].Publisher);
      }

    }

    private void AssertBookProperties(List<CatalogProperty> dataGateWayProperties)
    {
      List<CatalogProperty> properties = new List<CatalogProperty>();
      properties.Add(new CatalogProperty("Name1", "Value1"));
      properties.Add(new CatalogProperty("Name2", "Value2"));

      Assert.AreEqual(properties.Count, dataGateWayProperties.Count);

      for (int propertyIndex = 0; propertyIndex < properties.Count; propertyIndex ++)
      {
        Assert.AreEqual(properties[propertyIndex].Name, dataGateWayProperties[propertyIndex].Name);
        Assert.AreEqual(properties[propertyIndex].Value, dataGateWayProperties[propertyIndex].Value);
      }
    }
  }

  public class FakeXmlDataGateWay : XMLDataGateWayImpl
  {
    private string _xmlString;

    public string XmlString
    {
      get { return _xmlString; }
    }

    public override bool Read(string uri)
    {
      return GetPropertyToList(uri);
    }

    public override bool Write(string uri)
    {
      _xmlString = CreateXmlStringFormList();
      return true;
    }
  }
}