using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class ModifyBookItemController : Controller
  {
    public Presenter ControlPresenter { get; set; }

    public void Execute(int index, string name, string publisher)
    {
      var request = ModifyBookItemRequestModelFactory.Create(index, name, publisher);
      var response = (ModifyBookItemResponseModel) RequestExecutor.Execute(request);

      if (null != response)
      {
        ControlPresenter = new MessagePresenter();
        ControlPresenter.PresentedData = "Item has been modified";
      }
    }

    
  }
}