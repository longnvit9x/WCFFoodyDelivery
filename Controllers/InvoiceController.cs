using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class InvoiceController
    {
        private FoodDeliveryEntities dbContext = null;
        public List<InvoiceEntity> Get_List_Invoice_By_CustomerID(string id)
        {
            List<InvoiceEntity> list = new List<InvoiceEntity>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_INVOICE_BY_CUSTOMERID(id).ToList();
            foreach (var obj in listvar)
            {
                InvoiceEntity entity = new InvoiceEntity
                {
                    InvoiceID = "" + obj.InvoiceID,
                    OrderDate = "" + obj.OrderDate,
                    DeliveryDate = "" + obj.DeliveryDate,
                    Sale = (decimal)obj.Sale,
                    ServiceChange = (decimal)obj.ServiceChange,
                    ShippingFee = (decimal)obj.ShippingFee,
                    TotalPrice = (decimal)obj.TotalPrice,
                    StoreID = "" + obj.StoreID,
                    CustomerID = "" + obj.CustomerID,
                    AddressDelivery = obj.AddressDelivery,
                    CustomerName = obj.CustomerName,
                    CustomerPhone = obj.CustomerPhone,
                    Status = (int)obj.Status

                };
                list.Add(entity);
            }
            return list;
        }

        public List<InvoiceHistory> Get_List_Invoice_By_CustomerID_All(string id)
        {
            List<InvoiceHistory> list = new List<InvoiceHistory>();
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var listvar = dbContext.GET_LIST_INVOICE_BY_CUSTOMERID_ALL(id).ToList();
            foreach (var obj in listvar)
            {
                InvoiceHistory entity = new InvoiceHistory
                {
                    InvoiceID = "" + obj.InvoiceID,
                    OrderDate = "" + obj.OrderDate,
                    DeliveryDate = "" + obj.DeliveryDate,
                    Sale = (decimal)obj.Sale,
                    ServiceChange = (decimal)obj.ServiceChange,
                    ShippingFee = (decimal)obj.ShippingFee,
                    TotalPrice = (decimal)obj.TotalPrice,
                    StoreID = "" + obj.StoreID,
                    StoreName=obj.StoreName,
                    StoreAddress=obj.Address,
                    CustomerID = "" + obj.CustomerID,
                    AddressDelivery = obj.AddressDelivery,
                    CustomerName = obj.CustomerName,
                    CustomerPhone = obj.CustomerPhone,
                    Status = (int)obj.Status


                };
                list.Add(entity);
            }
            return list;
        }
        public InvoiceEntity Get_Object_Invoice_By_InvoiceID(string id)
        {

            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var obj = dbContext.GET_OBJECT_INVOICE_BY_INVOICEID(id).FirstOrDefault();

            InvoiceEntity entity = new InvoiceEntity
            {
                InvoiceID = "" + obj.InvoiceID,
                OrderDate = "" + obj.OrderDate,
                DeliveryDate = "" + obj.DeliveryDate,
                Sale = (decimal)obj.Sale,
                ServiceChange = (decimal)obj.ServiceChange,
                ShippingFee = (decimal)obj.ShippingFee,
                TotalPrice = (decimal)obj.TotalPrice,
                StoreID = "" + obj.StoreID,
                CustomerID = "" + obj.CustomerID,
                AddressDelivery = obj.AddressDelivery,
                CustomerName = obj.CustomerName,
                CustomerPhone = obj.CustomerPhone,
                Status = (int)obj.Status

            };
            return entity;
        }

        public InvoiceEntity Get_Object_Invoice_By_StoreID_And_CustomerID(string stoid, string cusid)
        {

            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var obj = dbContext.GET_OBJECT_INVOICE_BY_STOREID_AND_CUSTOMERID(stoid, cusid).FirstOrDefault();

            InvoiceEntity entity = new InvoiceEntity
            {
                InvoiceID = "" + obj.InvoiceID,
                OrderDate = "" + obj.OrderDate,
                DeliveryDate = "" + obj.DeliveryDate,
                Sale = (decimal)obj.Sale,
                ServiceChange = (decimal)obj.ServiceChange,
                ShippingFee = (decimal)obj.ShippingFee,
                TotalPrice = (decimal)obj.TotalPrice,
                StoreID = "" + obj.StoreID,
                CustomerID = "" + obj.CustomerID,
                AddressDelivery = obj.AddressDelivery,
                CustomerName = obj.CustomerName,
                CustomerPhone = obj.CustomerPhone,
                Status = (int)obj.Status

            };
            return entity;
        }
        public InvoiceEntity Get_Object_Invoice_By_StoreID_And_CustomerID_And_OrderDate(string stoid, string cusid, string orderDate)
        {

            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var obj = dbContext.GET_OBJECT_INVOICE_BY_STOREID_AND_CUSTOMERID_AND_ORDERDATE(stoid, cusid, orderDate).FirstOrDefault();

            InvoiceEntity entity = new InvoiceEntity
            {
                InvoiceID = "" + obj.InvoiceID,
                OrderDate = "" + obj.OrderDate,
                DeliveryDate = "" + obj.DeliveryDate,
                Sale = (decimal)obj.Sale,
                ServiceChange = (decimal)obj.ServiceChange,
                ShippingFee = (decimal)obj.ShippingFee,
                TotalPrice = (decimal)obj.TotalPrice,
                StoreID = "" + obj.StoreID,
                CustomerID = "" + obj.CustomerID,
                AddressDelivery = obj.AddressDelivery,
                CustomerName = obj.CustomerName,
                CustomerPhone = obj.CustomerPhone,
                Status = (int)obj.Status

            };
            return entity;
        }
        public bool Insert_Invoice(InvoiceEntity invoice)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            bool isInsert = false;
            int insert = dbContext.INSERT_INVOICE_TOSQL(invoice.OrderDate, invoice.DeliveryDate, invoice.Sale, invoice.ServiceChange, invoice.ShippingFee, invoice.TotalPrice, invoice.Status, invoice.CustomerName, invoice.CustomerPhone, invoice.AddressDelivery, invoice.CustomerID, invoice.StoreID);
            if (insert > 0)
            {
                isInsert = true;
            }
            return isInsert;
        }

        public bool Update_Status_Invoice(int status,string invoiceID)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            bool isUpdate = false;
            int update = dbContext.UPDATE_STATUS_INVOICE(status,invoiceID);
            if (update > 0)
            {
                isUpdate = true;
            }
            return isUpdate;
        }
    }
}
