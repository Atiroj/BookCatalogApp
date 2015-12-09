namespace BookCatalogEditingHandler.RequestModel
{
  internal class ModifyBookItemRequestModelImpl : ModifyBookItemRequestModel
  {
    public ModifyBookItemRequestModelImpl(int index, string name, string publisher)
    {
      Index = index;
      Name = name;
      Publisher = publisher;
    }

    public int Index { get; set; }

    public string Name { get; set; }

    public string Publisher { get; set; }
  }
}