using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.GateWay;

namespace XmlDataGateWay
{
  public class XMLDataGateWayImpl : DataGateWay
  {
    private string _xmlFilePath;

    public XMLDataGateWayImpl()
    {
      BookCatalogProperties = new List<CatalogProperty>();
      BookItems = new List<BookItem>();
    }

    public virtual bool Read(string uri)
    {
      _xmlFilePath = uri;
      string xmlString = "";
      if (File.Exists(_xmlFilePath) == false)
        return false;

      xmlString = File.ReadAllText(_xmlFilePath);

      return GetPropertyToList(xmlString);
    }


    public virtual bool Write(string uri)
    {
      try
      {
        File.WriteAllText(uri, CreateXmlStringFormList());
        return true;
      }
      catch (Exception)
      {
        return false;
      }           
    }

    public bool  GetPropertyToList(string xmlString)
    {

      XmlDocument xmlDoc = new XmlDocument();
      xmlDoc.LoadXml(xmlString);
      XmlNodeList nameNodeList = xmlDoc.SelectNodes("//Properties/Property/Name");
      XmlNodeList valueNodeList = xmlDoc.SelectNodes("//Properties/Property/Value");

      XmlNodeList itemNameNodeList = xmlDoc.SelectNodes("//Books/BookItem/Name");
      XmlNodeList publisherNodeList = xmlDoc.SelectNodes("//Books/BookItem/Publisher");

      if ((nameNodeList.Count != valueNodeList.Count) ||
         (itemNameNodeList.Count != publisherNodeList.Count))
        return false;

      for(int nodeIndex = 0; nodeIndex < nameNodeList.Count; nodeIndex ++)
        BookCatalogProperties.Add(new CatalogProperty(nameNodeList[nodeIndex].InnerText, valueNodeList[nodeIndex].InnerText));

      for (int itemIndex = 0; itemIndex < itemNameNodeList.Count; itemIndex++)
        BookItems.Add(new BookItem(itemNameNodeList[itemIndex].InnerText, publisherNodeList[itemIndex].InnerText));

      return true;
    }

    public string CreateXmlStringFormList()
    {
      XmlDocument xmlDoc = new XmlDocument();
      XmlNode rootNode = xmlDoc.CreateElement("BookCatalog");
      xmlDoc.AppendChild(rootNode);

      XmlNode propertiesNode = xmlDoc.CreateElement("Properties");
      rootNode.AppendChild(propertiesNode);

      AppendPropertiesNode(xmlDoc, propertiesNode);

      XmlNode bookItemsNode = xmlDoc.CreateElement("Books");
      rootNode.AppendChild(bookItemsNode);

      AppendItemsNode(xmlDoc, bookItemsNode);

      return xmlDoc.OuterXml;
    }

    private void AppendItemsNode(XmlDocument xmlDoc, XmlNode bookItemsNode)
    {
      foreach (var item in BookItems)
      {
        XmlNode itemNode = xmlDoc.CreateElement("BookItem");
        bookItemsNode.AppendChild(itemNode);

        XmlNode bookNameNode = xmlDoc.CreateElement("Name");
        bookNameNode.InnerText = item.Name;
        itemNode.AppendChild(bookNameNode);

        XmlNode publisherNode = xmlDoc.CreateElement("Publisher");
        publisherNode.InnerText = item.Publisher;
        itemNode.AppendChild(publisherNode);
      }
    }

    private void AppendPropertiesNode(XmlDocument xmlDoc, XmlNode propertiesNode)
    {
      foreach (var property in BookCatalogProperties)
      {
        XmlNode propertyNode = xmlDoc.CreateElement("Property");
        propertiesNode.AppendChild(propertyNode);

        XmlNode nameNode = xmlDoc.CreateElement("Name");
        nameNode.InnerText = property.Name;
        propertyNode.AppendChild(nameNode);

        XmlNode valueNode = xmlDoc.CreateElement("Value");
        valueNode.InnerText = property.Value;
        propertyNode.AppendChild(valueNode);
      }
    }

    public List<CatalogProperty> BookCatalogProperties  { get; private set; }
    public List<BookItem> BookItems { get; private set; }
   
  }
}