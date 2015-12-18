using System.Collections.Generic;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.GateWay;

namespace BookCatalogEditingHandler.Context
{
  public static class BookCatalogContext
  {
    private static DataGateWay _bookCatalogGateWay;

    public static DataGateWay BookCatalogDataGateWay
    {
      get { return _bookCatalogGateWay; }
    }

    public static void SetDataGateWay(DataGateWay dataGateWay)
    {
      _bookCatalogGateWay = dataGateWay;
    }
  }
}