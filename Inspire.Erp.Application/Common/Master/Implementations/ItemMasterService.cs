using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Enums;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspire.Erp.Application.Master
{
    public class ItemMasterService : IItemMasterService
    {
        private IRepository<ItemMaster> itemrepository;
        private IRepository<ItemStockType> itemStockRepository;
        public ItemMasterService(IRepository<ItemMaster> _itemrepository, IRepository<ItemStockType> _itemStockRepository)
        {
            itemrepository = _itemrepository;
            itemStockRepository = _itemStockRepository;
        }
        public IEnumerable<ItemMaster> InsertItem(ItemMaster itemMaster)
        {
            bool valid = false;
            try
            {
                valid = true;
                itemMaster.ItemMasterItemId =  Convert.ToInt32(itemrepository.GetAsQueryable()
                                             .Where(x => x.ItemMasterItemId > 0 )
                                             .DefaultIfEmpty()
                                             .Max(o => o == null ? 0 : o.ItemMasterItemId)) + 1;
                itemrepository.Insert(itemMaster);
                return this.GetAllItem();
            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            
        }
        public IEnumerable<ItemMaster> UpdateItem(ItemMaster itemMaster)
        {
            bool valid = false;
            try
            {
                itemrepository.Update(itemMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return this.GetAllItem();
        }

        public IEnumerable<ItemStockType> GetAllStockType()
        {
            return itemStockRepository.GetAll();
        }
        public IEnumerable<ItemMaster> DeleteItem(ItemMaster itemMaster)
        {
            bool valid = false;
            try
            {
                itemrepository.Delete(itemMaster);
                valid = true;

            }
            catch (Exception ex)
            {
                valid = false;
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return this.GetAllItem();
        }

        public IEnumerable<ItemMaster> GetAllItem()
        {
            IEnumerable<ItemMaster> itemMaster;
            try
            {
                itemMaster = itemrepository.GetAsQueryable().Where(k => k.ItemMasterAccountNo == 0 && k.ItemMasterItemType == ItemMasterStatus.Group).Select(k => k) ;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return itemMaster;
        }

        public IEnumerable<ItemMaster> GetAllItemNotGroup()
        {
            IEnumerable<ItemMaster> itemMaster;
            try
            {
                itemMaster = itemrepository.GetAsQueryable().Where(k => k.ItemMasterAccountNo != 0 && k.ItemMasterItemType != ItemMasterStatus.Group).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return itemMaster;
        }

        public IEnumerable<ItemMaster> GetAllItemById(int id)
        {
            IEnumerable<ItemMaster> itemMaster;
            try
            {
                itemMaster = itemrepository.GetAsQueryable().Where(k => k.ItemMasterAccountNo == id).Select(k => k);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                //cityrepository.Dispose();
            }
            return itemMaster;

        }


        public IEnumerable<ItemMaster> GetItemMastersByName(string name)
        {
            IEnumerable<ItemMaster> itemMasters = itemrepository.GetAsQueryable().Where(k => k.ItemMasterItemName.Contains(name) 
            && k.ItemMasterAccountNo != 0 && k.ItemMasterItemType != ItemMasterStatus.Group).Select(k => k);

            return itemMasters;
        }

    }
}
