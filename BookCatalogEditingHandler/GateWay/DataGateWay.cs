using System.Collections.Generic;
using BookCatalogEditingHandler.Entity;
using NUnit.Framework;

namespace BookCatalogEditingHandler.GateWay
{
  public interface DataGateWay
  {
    List<CatalogProperty> BookCatalogProperties { get; }
    List<BookItem> BookItems { get;}
    bool Read(string uri);
    bool Write(string uri);
  }
}