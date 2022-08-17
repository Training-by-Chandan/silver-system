using WinFormApp.Db.Models;

namespace WinFormApp.Db.Services
{
    public class InventoryServices : BaseServices
    {
        public (bool, string) CreateInventory(Inventory model)
        {
            try
            {
                var existing = db.Inventories.FirstOrDefault(p => p.Code == model.Code);
                var res = "";
                if (existing == null)
                {
                    //create a new record
                    db.Inventories.Add(model);
                    db.SaveChanges();
                    res = "Added new product";
                }
                else
                {
                    //update quantity and price
                    existing.Quantity = model.Quantity;
                    existing.Price = model.Price;
                    db.Inventories.Update(existing);
                    db.SaveChanges();
                    res = "updated the quantity and price";
                }
                return (true, res);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}