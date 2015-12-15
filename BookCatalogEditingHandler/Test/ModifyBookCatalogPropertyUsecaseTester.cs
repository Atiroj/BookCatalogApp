using System.Linq;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.RequestModel;
using BookCatalogEditingHandler.Usecase;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.Test;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class ModifyBookCatalogPropertyUsecaseTester : GivenBookCatalogPropertyContextTester
  {
    private ModifyBookCatalogPropertyUsecase _usecase;

    [SetUp]
    public new void SetUp()
    {
      _usecase = new ModifyBookCatalogPropertyUsecase();
    }

    [Test]
    public void ModifyFirstProperty()
    {
      var newName = "newName";
      var newValue = "newValue";
      var request = new ModifyBookCatalogPropertyRequestModelImpl(0, newName, newValue);
      _usecase.Execute(request);
      var property = BookCatalogContext.CatalogProperties.First();
      Assert.AreEqual(newName, property.Name);
      Assert.AreEqual(newValue, property.Value);
    }

    [Test]
    public void ModifyMultipleProperties()
    {
      var newName1 = "newName1";
      var newValue1 = "newValue1";
      var request1 = new ModifyBookCatalogPropertyRequestModelImpl(0, newName1, newValue1);

      var newName2 = "newName2";
      var newValue2 = "newValue2";
      var request2 = new ModifyBookCatalogPropertyRequestModelImpl(3, newName2, newValue2);

      _usecase.Execute(request1);
      _usecase.Execute(request2);

      var property1 = BookCatalogContext.CatalogProperties[0];
      var property2 = BookCatalogContext.CatalogProperties[3];

      Assert.AreEqual(newName1, property1.Name);
      Assert.AreEqual(newValue1, property1.Value);
      Assert.AreEqual(newName2, property2.Name);
      Assert.AreEqual(newValue2, property2.Value);
    }
  }
}