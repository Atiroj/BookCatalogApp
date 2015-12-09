using BookCatalogEditingHandler.ResponseModel;

namespace BookCatalogEditingHandler.Usecase
{
  internal class ModifyBookItemResponseModelImpl : ModifyBookItemResponseModel
  {
    public bool ExecuteResult { get; set; }
  }
}