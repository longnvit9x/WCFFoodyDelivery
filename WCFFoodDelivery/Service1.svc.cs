using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Models;
using Controllers;

namespace WCFFoodDelivery
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "STORES")]
        public List<StoreEntity> GET_ALL_LIST_STORE()
        {
            StoreController objController = new StoreController();
            List<StoreEntity> list = objController.Get_List_Store();
            return list;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "STORES/{storeID}")]
        public StoreEntity GET_OBJECT_STORE_BY_STOREID(string storeID)
        {
            StoreController objController = new StoreController();
            StoreEntity entity = objController.Get_Object_Store_By_StoreID(storeID);
            return entity;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "STORES/{storeID}/CATEGORYS")]
        public List<CategoryEntity> GET_LIST_CATEGORY_BY_STOREID(string storeID)
        {
            CategoryContronller objController = new CategoryContronller();
            List<CategoryEntity> list = objController.Get_List_Category_by_StoreID(storeID);
            return list;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "STOREIMAGES/{ID}")]
        public List<StoreImageEntity> GET_LIST_STOREIMAGE_BY_STOREID(string ID)
        {
            StoreImageController objController = new StoreImageController();
            List<StoreImageEntity> list = objController.Get_List_StoreImage_By_StoreID(ID);
            return list;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "STORESALE/{storeID}")]
        public StoreSaleEntity GET_OBJECT_STORESALE_BY_STOREID(string storeID)
        {
            StoreSaleController objController = new StoreSaleController();
            StoreSaleEntity entity = objController.Get_Object_StoreSale_By_StoreID(storeID);
            return entity;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "CATEGORYS/{categoryID}/FOODS")]
        public List<FoodEntity> GET_LIST_FOOD_BY_CATEGORYID(string categoryID)
        {
            FoodController objController = new FoodController();
            List<FoodEntity> list = objController.Get_List_Food_By_Category(categoryID);
            return list;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "FOODS/{foodID}")]
        public FoodEntity GET_OBJECT_FOOD_BY_FOODID(string foodID)
        {
            FoodController objController = new FoodController();
            FoodEntity entity = objController.Get_Object_Food_By_FoodID(foodID);
            return entity;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "FOODS/{foodID}/FOOSSIZES")]
        public List<FoodSizeEntity> GET_LIST_FOODSIZE_BY_FOODID(string foodID)
        {
            FoodSizeController objController = new FoodSizeController();
            List<FoodSizeEntity> list = objController.Get_List_FoodSize_by_FoodID(foodID);
            return list;
        }

        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "FOODS/{foodID}/FOODTYPES")]
        public List<FoodTypeEntity> GET_LIST_FOODTYPE_BY_FOODID(string foodID)
        {
            FoodTypeController objController = new FoodTypeController();
            List<FoodTypeEntity> list = objController.Get_List_FoodType_by_FoodID(foodID);
            return list;
        }


        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "CUSTOMERS/{customerID}")]
        public CustomerEntity GET_OBJECT_CUSTOMER_BY_CUSTOMERID(string customerID)
        {

            CustomerController objController = new CustomerController();
            CustomerEntity entity = objController.Get_Object_Customer_By_CustomerID(customerID);
            return entity;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "INVOICES/{invoiceID}")]
        public InvoiceEntity GET_OBJECT_INVOICE_BY_INVOICEID(string invoiceID)
        {
            InvoiceController objController = new InvoiceController();
            InvoiceEntity entity = objController.Get_Object_Invoice_By_InvoiceID(invoiceID);
            return entity;

        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "INVOICES/{storeID}/{customerID}")]
        public InvoiceEntity GET_OBJECT_INVOICE_BY_STOREID_AND_CUSTOMERID(string storeID, string customerID)
        {
            InvoiceController objController = new InvoiceController();
            InvoiceEntity entity = objController.Get_Object_Invoice_By_StoreID_And_CustomerID(storeID, customerID);
            return entity;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "CUSTOMERS/{customerID}/INVOICES")]
        public List<InvoiceEntity> GET_LIST_INVOICE_BY_CUSTOMERID(string customerID)
        {
            InvoiceController objController = new InvoiceController();
            List<InvoiceEntity> list = objController.Get_List_Invoice_By_CustomerID(customerID);
            return list;
        }
        [WebInvoke(Method = "GET",
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "{customerID}/INVOICES")]
        public List<InvoiceHistory> GET_LIST_INVOICE_BY_CUSTOMERID_ALL(string customerID)
        {
            InvoiceController objController = new InvoiceController();
            List<InvoiceHistory> list = objController.Get_List_Invoice_By_CustomerID_All(customerID);
            return list;
        }

        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "CUSTOMERS/NEW")]
        public bool INSERT_CUSTOMER(CustomerEntity customer)
        {
            return new CustomerController().Insert_Customer(customer);
        }

        [WebInvoke(Method = "PUT",
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "CUSTOMERS/EDIT")]
        public bool UPDATE_CUSTOMER(CustomerEntity customer)
        {
            return new CustomerController().Update_Customer(customer);
        }

        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "INVOICEDETAILS/NEW")]
        public bool INSERT_LIST_INVOICEDETAIL(List<InvoiceDetailEntity> list)
        {
            return new InvoiceDetailController().Insert_List_Detail_Invoice(list);
        }

        [WebInvoke(Method = "POST",
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "INVOICES/NEW")]
        public bool INSERT_INVOICE(InvoiceEntity invoice)
        {
            return new InvoiceController().Insert_Invoice(invoice);
        }

        [WebInvoke(Method = "GET",
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "CHECKUSER/{username}/{usertype}")]
        public bool CHECK_LOGIN_FB_GG(string username, string usertype)
        {
            return new CustomerController().Check_User_FB_And_GG(username, usertype);
        }
        [WebInvoke(Method = "GET",
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "CHECKLOGIN/{username}/{password}/{usertype}")]
        public bool CHECK_LOGIN_APP(string username, string password, string usertype)
        {
            return new CustomerController().Check_User_App(username, password, usertype);
        }

        [WebInvoke(Method = "GET",
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "CUSTOMER/{username}")]
        public CustomerEntity GET_OBJECT_CUSTOMER_BY_USERNAME(string username)
        {
            CustomerController objController = new CustomerController();
            CustomerEntity entity = objController.Get_Object_Customer_By_UserName(username);
            return entity;
        }


        [WebInvoke(Method = "GET",
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "STORESALES")]
        public List<StoreSaleEntity> GET_LIST_STORESALE_OPEN()
        {
            StoreSaleController objController = new StoreSaleController();
            List<StoreSaleEntity> list = objController.Get_List_StoreSale_Open();
            return list;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "STORES/{storeID}/FOODS")]
        public List<FoodEntity> GET_LIST_FOOD_BY_STOREID(string storeID)
        {
            FoodController objController = new FoodController();
            List<FoodEntity> list = objController.Get_List_Food_By_StoreID(storeID);
            return list;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "STORES/{storeName}/{address}/{storeType}")]
        public List<StoreEntity> FIND_STORE_BY_NAME_OR_TYPE_OR_ADDRESS(string storeName, string address, string storeType)
        {
            if (address.Equals("0"))
            {
                address = null;
            }
            if (storeName.Equals("0"))
            {
                storeName = null;
            }
            if (storeType.Equals("0"))
            {
                storeType = null;
            }
            StoreController objController = new StoreController();
            List<StoreEntity> list = objController.Find_List_Store(storeName, address, storeType);
            return list;
        }

        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "INVOICES/{storeID}/{customerID}/{orderDate}")]
        public InvoiceEntity GET_OBJECT_INVOICE_BY_STOREID_AND_CUSTOMERID_AND_ORDERDATE(string storeID, string customerID, string orderDate)
        {
            InvoiceController objController = new InvoiceController();
            InvoiceEntity entity = objController.Get_Object_Invoice_By_StoreID_And_CustomerID_And_OrderDate(storeID, customerID, orderDate);
            return entity;
        }

        [WebInvoke(Method = "PUT",
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "INVOICE/EDIT/{status}/{invoiceID}")]
        public bool UPDATE_STATUS_INVOICE(string status, string invoiceID)
        {
            int sta = int.Parse(status);
            return new InvoiceController().Update_Status_Invoice(sta, invoiceID);
        }


        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "{invoiceID}/INVOICEDETAILS")]
        public List<InvoiceDetailEntity> GET_LIST_INVOICEDETAIL_BY_INVOICEID(string invoiceID)
        {
            InvoiceDetailController objController = new InvoiceDetailController();
            List<InvoiceDetailEntity> list = objController.Get_List_InvoiceDetail_By_InvoiceID(invoiceID);
            return list;
        }
    }
}
