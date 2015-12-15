using BookCatalogController;
using BookCatalogEditingHandler.Context;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class ModifyBookCatalogPropertyControllerTester : GivenBookCatalogPropertyContextTester
  {
    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new ModifyBookCatalogPropertyController());
    }

    [Test]
    public void ModifyProperty()
    {
      int previousCount = BookCatalogContext.CatalogProperties.Count;

      var controller = new ModifyBookCatalogPropertyController();
      controller.Execute(0, "newName", "newValue");
      
      Assert.AreEqual(previousCount, BookCatalogContext.CatalogProperties.Count);
      Assert.AreEqual("newName", BookCatalogContext.CatalogProperties[0].Name);
      Assert.AreEqual("newValue", BookCatalogContext.CatalogProperties[0].Value);
      Assert.AreEqual("Property has been modified", controller.ControlPresenter.PresentedData);
    }
  }
}