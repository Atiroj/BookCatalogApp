using System.Runtime.Remoting.Messaging;
using BookCatalogEditingHandler.RequestModel;

namespace BookCatalogEditor.RequestModelFactory
{
  public static class ReadDataFileRequestModelFactory
  {
    public static ReadDataFileRequestModel Create(string fileName)
    {
      return new ReadDataFileRequestModelImpl(fileName);
    }
  }
}