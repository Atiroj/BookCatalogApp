
namespace BookCatalogEditingHandler.RequestModel
{
  internal class ModifyBookCatalogPropertyRequestModelImpl : ModifyBookCatalogPropertyRequestModel
  {
    public ModifyBookCatalogPropertyRequestModelImpl(int index, string name, string value)
    {
      Index = index;
      Name = name;
      Value = value;
    }

    public string Name { get; set; }

    public string Value { get; set; }

    public int Index { get; set; }
  }
}
