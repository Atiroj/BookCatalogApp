using System.Collections.Generic;
using BookCatalogEditingHandler.Entity;
using BookCatalogEditingHandler.ResponseModel;
using BookCatalogEditingHandler.Test;
using NUnit.Framework;

namespace BookCatalogConsole
{
  [TestFixture]
  public class ConsolePresenterTester 
  {
    private ConsolePresenter _consolePresenter;

    [SetUp]
    public void SetUp()
    {
      _consolePresenter = new ConsolePresenter();
      MockBookCatalogContext.InitailList();
    }

    [Test]
    public void CheckViewByAddingBookCatalogProperty()
    {
      _consolePresenter.ResponseModel = new MockAddBookCatalogPropertyResponseModel(true);
      _consolePresenter.GenerateView();
      Assert.AreEqual("Property has been added",_consolePresenter.View.Data);
    }

    [Test]
    public void CheckViewByAddingBookItem()
    {
      _consolePresenter.ResponseModel = new MockAddBookItemResponseModel(true);
      _consolePresenter.GenerateView();
      Assert.AreEqual("Item has been added", _consolePresenter.View.Data);
    }

    [Test]
    public void CheckViewByModifyingBookCatalogProperty()
    {
      _consolePresenter.ResponseModel = new MockModifyBookCatalogPropertyResponseModel(true);
      _consolePresenter.GenerateView();
      Assert.AreEqual("Property has been modified", _consolePresenter.View.Data);
    }

    [Test]
    public void CheckViewByModifyingBookItem()
    {
      _consolePresenter.ResponseModel = new MockModifyBookItemResponseModel(true);
      _consolePresenter.GenerateView();
      Assert.AreEqual("Item has been modified", _consolePresenter.View.Data);
    }

    [Test]
    public void CheckViewByQueryAllProperties()
    {
      _consolePresenter.ResponseModel = new MockQueryAllBookCatalogPropertiesResponseModel(true);
      _consolePresenter.GenerateView();
      Assert.AreEqual(GetQueryAllData(), _consolePresenter.View.Data);
    }

    [Test]
    public void CheckViewByRemoveProperty()
    {
      _consolePresenter.ResponseModel = new MockRemoveBookCatalogPropertyResponseModel(true);
      _consolePresenter.GenerateView();
      Assert.AreEqual("Property has been removed", _consolePresenter.View.Data);
    }

    [Test]
    public void CheckViewByRemoveItem()
    {
      _consolePresenter.ResponseModel = new MockRemoveBookItemResponseModel(true);
      _consolePresenter.GenerateView();
      Assert.AreEqual("Item has been removed", _consolePresenter.View.Data);
    }

    private string GetQueryAllData()
    {
      string resultData = "";
      foreach (var catalogProperty in MockBookCatalogContext.CatalogProperties)
        resultData += catalogProperty.Name + ", " + catalogProperty.Value + "\n";

      return resultData;
    }

    internal class MockAddBookCatalogPropertyResponseModel : AddBookCatalogProperyResponseModel
    {
      public MockAddBookCatalogPropertyResponseModel(bool result)
      {
        ExecuteResult = result;
      }
      public bool ExecuteResult { get; set; }
    }

  }

  public class MockRemoveBookItemResponseModel : RemoveBookItemResponseModel
  {
    public MockRemoveBookItemResponseModel(bool result)
    {
      ExecuteResult = result;
    }

    public bool ExecuteResult { get; private set; }
  }

  public class MockRemoveBookCatalogPropertyResponseModel : RemoveBookCatalogPropertyResponseModel
  {
    public MockRemoveBookCatalogPropertyResponseModel(bool result)
    {
      ExecuteResult = result;
    }

    public bool ExecuteResult { get; private set; }
  }

  public class MockQueryAllBookCatalogPropertiesResponseModel : QueryAllCatalogPropertiesResponseModel
  {
    public MockQueryAllBookCatalogPropertiesResponseModel(bool result)
    {
      ExecuteResult = result;
      PresentableCatalogProperties = new List<PresentableCatalogProperty>();
      foreach (var catalogProperty in MockBookCatalogContext.CatalogProperties)
        PresentableCatalogProperties.Add(new PresentableCatalogProperty(catalogProperty.Name,catalogProperty.Value));
    }

    public List<PresentableCatalogProperty> PresentableCatalogProperties { get; private set; }
    public bool ExecuteResult { get; set; }
  }

  internal static class MockBookCatalogContext
  {
    public static List<CatalogProperty> CatalogProperties = new List<CatalogProperty>();

    public static void InitailList()
    {
      CatalogProperties.Add(new CatalogProperty("name1", "value1"));
      CatalogProperties.Add(new CatalogProperty("name2", "value2"));
      CatalogProperties.Add(new CatalogProperty("name3", "value3"));
      CatalogProperties.Add(new CatalogProperty("name4", "value4"));
      CatalogProperties.Add(new CatalogProperty("name5", "value5"));
    }
     
  }

  public class MockModifyBookItemResponseModel : ModifyBookItemResponseModel
  {
    public MockModifyBookItemResponseModel(bool result)
    {
      ExecuteResult = result;
    }

    public bool ExecuteResult { get; set; }
  }

  public class MockModifyBookCatalogPropertyResponseModel : ModifyBookCatalogPropertyResponseModel
  {
    public MockModifyBookCatalogPropertyResponseModel(bool result)
    {
      ExecuteResult = result;
    }

    public bool ExecuteResult { get; set; }
  }

  internal class MockAddBookItemResponseModel :AddBookItemResponseModel
  {
    public MockAddBookItemResponseModel(bool result)
    {
      ExecuteResult = result;
    }
    public bool ExecuteResult { get; set; }
  }
}