using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
   public class StoreImageController
    {
        private FoodDeliveryEntities dbContext = null;
        public List<StoreImageEntity> Get_List_StoreImage_By_StoreID(string id)
        {
            List<StoreImageEntity> list = new List<StoreImageEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_STOREIMAGE_BY_STOREID(id).ToList();
            foreach (var obj in listvar)
            {
                StoreImageEntity entity = new StoreImageEntity
                {
                    StoreID = "" + obj.StoreID,
                    URL = obj.URL,
                    StoreImageID = obj.StoreImageID, 
                };
                list.Add(entity);
            }
            return list;
        }

    }
}
