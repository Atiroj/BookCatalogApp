using BookCatalogController;
using NUnit.Framework;

namespace BookCatalogConsole
{
  [TestFixture]
  public class ConsolePresenterTester
  {
    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new ConsolePresenter());
    }

    [Test]
    public void PresentData()
    {
      var controller1 = new AddBookCatalogPropertyController();
      controller1.Execute("newName", "newValue");
      var consolePresenter1 = new ConsolePresenter();
      consolePresenter1.SetData(controller1);
      Assert.AreEqual("Property has been added", consolePresenter1.PresentedData);

      var controller2 = new ModifyBookCatalogPropertyController();
      controller2.Execute(0, "newName", "newValue");
      var consolePresenter2 = new ConsolePresenter();
      consolePresenter2.SetData(controller2);
      Assert.AreEqual("Property has been modified", consolePresenter2.PresentedData);

    }
  }
}