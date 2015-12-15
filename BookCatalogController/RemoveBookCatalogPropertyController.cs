using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class RemoveBookCatalogPropertyController : Controller
  {
    public Presenter ControlPresenter { get; set; }

    public void Execute(int index)
    {
      var request = RemoveBookCatalogPropertyModelFactory.Create(index);
      var response = (RemoveBookCatalogPropertyResponseModel) RequestExecutor.Execute(request);

      if (null != response)
      {
        ControlPresenter = new MessagePresenter();
        ControlPresenter.PresentedData = "Property has been removed";
      }
    }   
  }
}