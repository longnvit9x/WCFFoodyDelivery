using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
   public  class CategoryContronller
    {
        private FoodDeliveryEntities dbContext = null;
        public List<CategoryEntity> Get_List_Category_by_StoreID(string id)
        {
            List<CategoryEntity> list = new List<CategoryEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
          
                var listvar = dbContext.GET_LIST_CATEGORY_BY_STOREID(id).ToList();
                foreach (var obj in listvar)
                {
                    CategoryEntity entity = new CategoryEntity
                    {
                        CategoryID = "" + obj.CategoryID,
                        CategoryName = obj.CategoryName,
                        StoreID = "" + obj.StoreID
                    };
                    list.Add(entity);
                }
          
            return list;
        }
    }
}
