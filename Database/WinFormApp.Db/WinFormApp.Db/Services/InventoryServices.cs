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

        public List<Inventory> GetAll()
        {
            return db.Inventories.ToList();
        }

        public List<Inventory> GetAllBySearchParameters(string searchText)
        {
            var data = db.Inventories;
            var filtered = data.Where(p => p.Code.Contains(searchText) || p.Name.Contains(searchText));
            return filtered.ToList();
        }

        public (bool, string) Edit(Inventory model)
        {
            try
            {
                var existing = db.Inventories.Find(model.Id);
                if (existing == null)
                {
                    return (false, "record not found");
                }
                existing.Code = model.Code;
                existing.Name = model.Name;
                existing.Price = model.Price;
                existing.Quantity = model.Quantity;
                existing.Units = model.Units;

                db.Inventories.Update(existing);
                db.SaveChanges();
                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int id)
        {
            try
            {
                var existing = db.Inventories.Find(id);
                if (existing == null)
                {
                    return (false, "record not found");
                }
                db.Inventories.Remove(existing);
                db.SaveChanges();
                return (true, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}