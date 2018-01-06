using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
  public  class StoreSaleController
    {
        private FoodDeliveryEntities dbContext = null;
        public StoreSaleEntity Get_Object_StoreSale_By_StoreID(string id)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            if (dbContext.GET_OBJECT_STORESALE_BY_STOREID(id).FirstOrDefault() == null)
                return null;
            var obj = dbContext.GET_OBJECT_STORESALE_BY_STOREID(id).FirstOrDefault();
            StoreSaleEntity entity = new StoreSaleEntity
            {
                StoreSaleID = obj.StoreSaleID,
                Sale = (int)obj.Sale,
                StratSale = "" + obj.StartSale,
                StoreID = "" + obj.StoreID,
                StopSale = "" + obj.StopSale

            };
           
            return entity;
        }
        public List<StoreSaleEntity> Get_List_StoreSale_Open()
        {
            List<StoreSaleEntity> list = new List<StoreSaleEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_SALE_OPEN().ToList();
            foreach (var obj in listvar)
            {
                StoreSaleEntity entity = new StoreSaleEntity
                {
                    StoreSaleID = obj.StoreSaleID,
                    Sale = (int)obj.Sale,
                    StratSale = "" + obj.StartSale,
                    StoreID = "" + obj.StoreID,
                    StopSale = "" + obj.StopSale

                };
                list.Add(entity);
            }

            return list;
        }

    }
}
