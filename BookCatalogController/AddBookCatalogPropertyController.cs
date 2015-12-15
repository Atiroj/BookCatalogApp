using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class AddBookCatalogPropertyController : Controller
  {
    public Presenter ControlPresenter { get; set; }

    public void Execute(string name, string value)
    {
      var request = AddBookCatalogPropertyRequestModelFactory.Create(name, value);
      var response = (AddBookCatalogProperyResponseModel)RequestExecutor.Execute(request);

      if (response != null)
      {
        ControlPresenter = new MessagePresenter();
        ControlPresenter.PresentedData = "Property has been added";
      }
      
    }
  }
}