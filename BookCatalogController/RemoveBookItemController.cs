using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class RemoveBookItemController : Controller
  {
    public Presenter ControlPresenter { get; set; }

    public void Execute(int index)
    {
      var request = RemoveBookItemRequestModelFactory.Create(index);
      var response = (RemoveBookItemResponseModel) RequestExecutor.Execute(request);

      if (null != response)
      {
        ControlPresenter = new MessagePresenter();
        ControlPresenter.PresentedData = "Item has been removed";
      }
    } 
  }
}