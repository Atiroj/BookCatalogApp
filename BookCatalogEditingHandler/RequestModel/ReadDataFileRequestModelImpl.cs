namespace BookCatalogEditingHandler.RequestModel
{
  internal class ReadDataFileRequestModelImpl : ReadDataFileRequestModel
  {
    public string FileName { get; set; }

    public ReadDataFileRequestModelImpl(string fileName)
    {
      FileName = fileName;
    }

    
  }
}