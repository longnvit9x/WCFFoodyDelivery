using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class StoreController
    {
        private FoodDeliveryEntities dbContext;
        public StoreController()
        {
            dbContext = new FoodDeliveryEntities();
        }
       
        public List<StoreEntity> Get_List_Store()
        {
            List<StoreEntity> list = new List<StoreEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_STORE().ToList();
            foreach (var obj in listvar)
            {
                StoreEntity entity = new StoreEntity
                {
                    StoreID = "" + obj.StoreID,
                    StoreName = obj.StoreName,
                    Address = obj.Address,
                    OpenDoor = "" + obj.OpenDoor,
                    CloserDoor = "" + obj.CloserDoor,
                    ServiceCharge = (decimal)obj.ServiceCharge,
                    ShippingFee = (decimal)obj.ShippingFee,
                    Manner = obj.Manner,
                    Website = obj.Website,
                    StoreType = obj.StoreType,
                    StoreBanner = "http://localhost:63116/Data/Originals/t.PNG",
                    Rating = (double)obj.Rating,
                    Evaluation = (int)obj.Evaluation,
                    ConditionShip = (long)obj.ConditionShip,
                    StartDate = (int)obj.StartDate,
                    EndDate = (int)obj.EndDate,
                };
                list.Add(entity);
            }
            return list;
        }

        public StoreEntity Get_Object_Store_By_StoreID( string id)
        {
            
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var obj = dbContext.GET_OBJECT_STORE_BY_STOREID(id).FirstOrDefault();
          
                StoreEntity entity = new StoreEntity
                {
                    StoreID = "" + obj.StoreID,
                    StoreName = obj.StoreName,
                    Address = obj.Address,
                    OpenDoor = "" + obj.OpenDoor,
                    CloserDoor = "" + obj.CloserDoor,
                    ServiceCharge = (decimal)obj.ServiceCharge,
                    ShippingFee = (decimal)obj.ShippingFee,
                    Manner = obj.Manner,
                    Website = obj.Website,
                    StoreType = obj.StoreType,
                    StoreBanner=obj.StoreBanner,
                    Rating = (double)obj.Rating,
                    Evaluation = (int)obj.Evaluation,
                    ConditionShip = (long)obj.ConditionShip,
                    StartDate = (int)obj.StartDate,
                    EndDate = (int)obj.EndDate,
                };
             
            
            return entity;
        }

        public List<StoreEntity> Find_List_Store(string storeName, string address,string storeType )
        {
            List<StoreEntity> list = new List<StoreEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.FIND_STORE(storeName,address,storeType).ToList();
            foreach (var obj in listvar)
            {
                StoreEntity entity = new StoreEntity
                {
                    StoreID = "" + obj.StoreID,
                    StoreName = obj.StoreName,
                    Address = obj.Address,
                    OpenDoor = "" + obj.OpenDoor,
                    CloserDoor = "" + obj.CloserDoor,
                    ServiceCharge = (decimal)obj.ServiceCharge,
                    ShippingFee = (decimal)obj.ShippingFee,
                    Manner = obj.Manner,
                    Website = obj.Website,
                    StoreType = obj.StoreType,
                    StoreBanner = obj.StoreBanner,
                    Rating = (double)obj.Rating,
                    Evaluation = (int)obj.Evaluation,
                    ConditionShip = (long)obj.ConditionShip,
                    StartDate = (int)obj.StartDate,
                    EndDate = (int)obj.EndDate,
                };
                list.Add(entity);
            }
            return list;
        }
    }
}
