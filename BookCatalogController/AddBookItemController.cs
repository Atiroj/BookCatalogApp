using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditor.RequestModelFactory;
using BookCatelogEditingHandler;

namespace BookCatalogController
{
  public class AddBookItemController
  {
    public Presenter ControlorPresenter { get; set; }

    public void Execute(string name, string publisher)
    {
      var request = AddBookItemRequestModelFactory.Create(name, publisher);
      var response = (AddBookItemResponseModel)RequestExecutor.Execute(request);

      if (response != null)
      {
        ControlorPresenter = new MessagePresenter();
        ControlorPresenter.PresentedData = "Item has been added";
      }     
    }
  }
}