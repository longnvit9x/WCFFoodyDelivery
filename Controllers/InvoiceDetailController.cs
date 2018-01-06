using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
   public class InvoiceDetailController
    {
        private FoodDeliveryEntities dbContext = null;
        public List<InvoiceDetailEntity> Get_List_InvoiceDetail_By_InvoiceID(string id)
        {
            List<InvoiceDetailEntity> list = new List<InvoiceDetailEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }

            var listvar = dbContext.GET_LIST_INVOICEDETAIL_BY_INVOICEID(id).ToList();
            foreach (var obj in listvar)
            {
                InvoiceDetailEntity entity = new InvoiceDetailEntity
                {
                    ID= obj.ID,
                    FoodID=""+obj.FoodID,
                    NumberFood=(int)obj.NumberFood,
                    Size=obj.Size,
                    PriceSize=(decimal)obj.PriceSize,
                    Type= obj.Type,
                    PriceType= (decimal)obj.PriceType,
                    InvoiceID=""+obj.InvoiceID,
                    FoodImage=obj.FoodImage,
                    FoodName=obj.FoodName,
                    Price=(decimal)obj.Price
                  
                };
                list.Add(entity);
            }

            return list;
        }
        public bool Insert_List_Detail_Invoice(List<InvoiceDetailEntity> list)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            bool isInsert = false;
            for(int i=0; i < list.Count; i++)
            {
                int insert = dbContext.INSERT_INVOICEDETAIL_TOSQL(list[i].FoodID, list[i].NumberFood, list[i].Size,(long) list[i].PriceSize, list[i].Type, (long)list[i].PriceType, list[i].InvoiceID);
                if (insert > 0)
                {
                    isInsert = true;
                }
                else return false;
            }

            return isInsert;
        }
    }
}
