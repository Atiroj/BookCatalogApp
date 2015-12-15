using System.Collections.Generic;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class QueryAllBookCatalogPropertiesController : Controller
  {
    public List<PresentableCatalogProperty> PresentableQueryList { get; set; }
    
    public Presenter ControlPresenter { get; set; }

    public void Execute()
    {
      var request = QueryAllBookCatalogPropertiesModelFactory.Create();
      var response = (QueryAllCatalogPropertiesResponseModel) RequestExecutor.Execute(request);

      if (null != response)
      {
        PresentableQueryList = new List<PresentableCatalogProperty>();
        PresentableQueryList = response.PresentableCatalogProperties;
        ControlPresenter = new MessagePresenter();
        ControlPresenter.PresentedData = ConcatinatePresentableData();
      }
    }

    private string ConcatinatePresentableData()
    {
      string concatResult = "";

      foreach (var presentableData in PresentableQueryList)
        concatResult += (presentableData.Name + ", " + presentableData.Value + "\n");

      return concatResult;
    }

    
  }
}