using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class FoodTypeController
    {
        private FoodDeliveryEntities dbContext = null;
        public List<FoodTypeEntity> Get_List_FoodType_by_FoodID(string id)
        {
            List<FoodTypeEntity> list = new List<FoodTypeEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_FOODTYPE_BY_FOODID(id).ToList();
            foreach (var obj in listvar)
            {
                FoodTypeEntity entity = new FoodTypeEntity
                {
                    FoodTypeID = obj.FoodTypeID,
                    TypeName = obj.TypeName,
                    PriceType = (decimal)obj.PriceType,
                    FoodID=""+obj.FoodID
                };
                list.Add(entity);
            }
            return list;
        }
    }
}
