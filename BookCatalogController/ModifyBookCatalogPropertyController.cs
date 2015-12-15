using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class ModifyBookCatalogPropertyController : Controller
  {
    public Presenter ControlPresenter { get; set; }

    public void Execute(int index, string name, string value)
    {
      var request = ModifyBookCatalogPropertyRequestModelFactory.Create(index, name, value);
      var response = (ModifyBookCatalogPropertyResponseModel)RequestExecutor.Execute(request);

      if (null != response)
      {
        ControlPresenter = new MessagePresenter();
        ControlPresenter.PresentedData = "Property has been modified";
      }
    }

    
  }
}