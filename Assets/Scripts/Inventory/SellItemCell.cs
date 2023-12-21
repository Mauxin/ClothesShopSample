namespace Inventory
{
    public class SellItemCell : AItemCell
    {
        protected override void OnActionButtonClick()
        {
            if (!Item.IsOwned) return;
            
            WalletController.AddGold(Item.Price);
            InventoryController.RemoveItem(Item);
        }
    }
}