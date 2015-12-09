using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Usecase;

namespace BookCatalogEditor
{
  public class AddPropertyController : Controller
  {
    public string Name { get; set; }

    public string Value { get; set; }

    public AddPropertyController(string name, string value)
    {
      Name = name;
      Value = value;
    }

    public bool Execute()
    {
     // InputBoundary inputBoundary = new AddBookCatalogPropertyUsecaseImpl();

     // return inputBoundary.Execute(new AddBookCatalogPropertyRequestModelImpl(Name, Value));
     //AddBookCatalogPropertyRequestModel addBookCatalogPropertyRequestModel = AddBookCatalogPropertyRequestModelFactory.Create();
     //AddBookCatalogPropertyUsecase addBookCatalogPropertyUsecase = AddBookCatalogPropertyUseCaseFactory.Create();
      
     return true;
    }
    
  }
}