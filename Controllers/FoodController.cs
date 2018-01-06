using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
   public class FoodController
    {
        private FoodDeliveryEntities dbContext = null;
        public List<FoodEntity> Get_List_Food_By_Category(string id)
        {
            List<FoodEntity> list = new List<FoodEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_FOOD_BY_CATEGORYID(id).ToList();
            foreach (var obj in listvar)
            {
                FoodEntity entity = new FoodEntity
                {
                    FoodID = "" + obj.FoodID,
                    FoodName = obj.FoodName,
                    FoodImage = obj.FoodImage,
                    Price = (decimal)obj.Price,
                    CategoryID=""+obj.CategoryID,
                    StoreID = "" + obj.StoreID
                };
                list.Add(entity);
            }
            return list;
        }

        public List<FoodEntity> Get_List_Food_By_StoreID(string id)
        {
            List<FoodEntity> list = new List<FoodEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_FOOD_BY_STOREID(id).ToList();
            foreach (var obj in listvar)
            {
                FoodEntity entity = new FoodEntity
                {
                    FoodID = "" + obj.FoodID,
                    FoodName = obj.FoodName,
                    FoodImage = obj.FoodImage,
                    Price = (decimal)obj.Price,
                    CategoryID = "" + obj.CategoryID,
                    StoreID=""+obj.StoreID
                  
                };
                list.Add(entity);
            }
            return list;
        }

        public FoodEntity Get_Object_Food_By_FoodID(string id)
        {

            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var obj = dbContext.GET_OBJECT_FOOD_BY_FOODID(id).FirstOrDefault();

            FoodEntity entity = new FoodEntity
            {
                FoodID = "" + obj.FoodID,
                FoodName = obj.FoodName,
                FoodImage = obj.FoodImage,
                Price = (decimal)obj.Price,
                CategoryID = "" + obj.CategoryID,
                StoreID = "" + obj.StoreID
            };
         


            return entity;
        }
    }
}
