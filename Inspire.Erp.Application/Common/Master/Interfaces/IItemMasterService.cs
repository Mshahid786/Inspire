using Inspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public interface IItemMasterService
    {
        public IEnumerable<ItemMaster> InsertItem(ItemMaster itemMaster);
        public IEnumerable<ItemMaster> UpdateItem(ItemMaster itemMaster);
        public IEnumerable<ItemMaster> DeleteItem(ItemMaster itemMaster);
        public IEnumerable<ItemMaster> GetAllItem();
        public IEnumerable<ItemMaster> GetAllItemById(int id);
        public IEnumerable<ItemMaster> GetAllItemNotGroup();
        public IEnumerable<ItemStockType> GetAllStockType();
        public IEnumerable<ItemMaster> GetItemMastersByName(string name);
    }
}