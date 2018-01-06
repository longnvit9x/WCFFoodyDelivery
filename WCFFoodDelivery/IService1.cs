using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Models;

namespace WCFFoodDelivery
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<StoreEntity> GET_ALL_LIST_STORE();
        [OperationContract]
        List<StoreEntity> FIND_STORE_BY_NAME_OR_TYPE_OR_ADDRESS(string storeName,string address,string storeType);
        [OperationContract]
        StoreEntity GET_OBJECT_STORE_BY_STOREID(string storeID);
        [OperationContract]
        List<StoreImageEntity> GET_LIST_STOREIMAGE_BY_STOREID(string ID);
        [OperationContract]
        StoreSaleEntity GET_OBJECT_STORESALE_BY_STOREID(string storeID);
        [OperationContract]
        List<StoreSaleEntity> GET_LIST_STORESALE_OPEN();
        [OperationContract]
        List<CategoryEntity> GET_LIST_CATEGORY_BY_STOREID(string storeID);
        [OperationContract]
        List<FoodEntity> GET_LIST_FOOD_BY_CATEGORYID(string categoryID);
        [OperationContract]
        List<FoodEntity> GET_LIST_FOOD_BY_STOREID(string StoreID);
        [OperationContract]
        FoodEntity GET_OBJECT_FOOD_BY_FOODID(string foodID);
        [OperationContract]
        List<FoodSizeEntity> GET_LIST_FOODSIZE_BY_FOODID(string foodID);
        [OperationContract]
        List<FoodTypeEntity> GET_LIST_FOODTYPE_BY_FOODID(string foodID);
        [OperationContract]
        CustomerEntity GET_OBJECT_CUSTOMER_BY_CUSTOMERID(string customerID);
        [OperationContract]
        CustomerEntity GET_OBJECT_CUSTOMER_BY_USERNAME(string username);
        [OperationContract]
        InvoiceEntity GET_OBJECT_INVOICE_BY_INVOICEID(string invoiceID);
        [OperationContract]
        InvoiceEntity GET_OBJECT_INVOICE_BY_STOREID_AND_CUSTOMERID(string storeID, string customerID);
        [OperationContract]
        InvoiceEntity GET_OBJECT_INVOICE_BY_STOREID_AND_CUSTOMERID_AND_ORDERDATE(string storeID, string customerID,string orderDate);
        [OperationContract]
        List<InvoiceEntity> GET_LIST_INVOICE_BY_CUSTOMERID(string customerID);
        [OperationContract]
        List<InvoiceHistory> GET_LIST_INVOICE_BY_CUSTOMERID_ALL(string customerID);
        [OperationContract]
        List<InvoiceDetailEntity> GET_LIST_INVOICEDETAIL_BY_INVOICEID(string invoiceID);
        [OperationContract]
        bool INSERT_CUSTOMER(CustomerEntity customer);
        [OperationContract]
        bool UPDATE_CUSTOMER(CustomerEntity customer);
        [OperationContract]
        bool INSERT_LIST_INVOICEDETAIL(List<InvoiceDetailEntity> list);
        [OperationContract]
        bool INSERT_INVOICE(InvoiceEntity invoice);
        [OperationContract]
        bool UPDATE_STATUS_INVOICE(string status, string invoiceID);
        [OperationContract]
        bool CHECK_LOGIN_FB_GG(string username, string usertype);
        [OperationContract]
        bool CHECK_LOGIN_APP(string username, string password, string usertype);

    }

}
