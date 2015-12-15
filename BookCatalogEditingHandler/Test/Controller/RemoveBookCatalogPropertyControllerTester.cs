using System.Configuration;
using BookCatalogController;
using BookCatalogEditingHandler.Context;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class RemoveBookCatalogPropertyControllerTester : GivenBookCatalogPropertyContextTester
  {
    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new RemoveBookCatalogPropertyController());
    }

    [Test]
    public void RemoveProperty()
    {
      int previousCount = BookCatalogContext.CatalogProperties.Count;
      var controller = new RemoveBookCatalogPropertyController();
      controller.Execute(0);

      Assert.AreEqual(previousCount -1, BookCatalogContext.CatalogProperties.Count);
      Assert.AreEqual("Property has been removed", controller.ControlPresenter.PresentedData);
    }
  }
}