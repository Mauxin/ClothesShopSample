namespace Inventory
{
    public class PurchaseItemCell : AItemCell
    {
        protected override void OnActionButtonClick()
        {
            if (!Item.CanPurchase) return;
            
            WalletController.RemoveGold(Item.Price);
            InventoryController.AddItem(Item);
        }
    }
}