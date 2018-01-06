using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
   public class FoodSizeController
    {
        private FoodDeliveryEntities dbContext = null;
        public List<FoodSizeEntity> Get_List_FoodSize_by_FoodID(string id)
        {
            List<FoodSizeEntity> list = new List<FoodSizeEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_FOODSIZE_BY_FOODID(id).ToList();
            foreach (var obj in listvar)
            {
                FoodSizeEntity entity = new FoodSizeEntity
                {
                    FoodSizeID = obj.FoodSizeID,
                    SizeName = obj.SizeName,
                    PriceSize= (decimal) obj.PriceSize,
                    FoodID=""+obj.FoodID
                    
                };
                list.Add(entity);
            }
            return list;
        }
    }
}
