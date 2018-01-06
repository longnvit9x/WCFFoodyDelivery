using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
   public class CustomerController
    {
        private FoodDeliveryEntities dbContext = null;
        public CustomerEntity Get_Object_Customer_By_CustomerID(string id)
        {

            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var obj = dbContext.GET_OBJECT_CUSTOMER_BY_CUSTOMERID(id).FirstOrDefault();

            CustomerEntity entity = new CustomerEntity
            {
                CustomerID = "" + obj.CustomerID,
                FullName = obj.FullName,
                Address = obj.Address,
                Email = obj.Email,
                Mobile= obj.Mobile,
                Avatar= obj.Avatar,
                UserName= obj.UserName,
                Password= obj.Password,
                UserType= obj.UserType,
            };


            return entity;
        }
        public CustomerEntity Get_Object_Customer_By_UserName(string userName)
        {

            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            var obj = dbContext.GET_OBJECT_CUSTOMER_BY_USERNAME(userName).FirstOrDefault();

            CustomerEntity entity = new CustomerEntity
            {
                CustomerID = "" + obj.CustomerID,
                FullName = obj.FullName,
                Address = obj.Address,
                Email = obj.Email,
                Mobile = obj.Mobile,
                Avatar = obj.Avatar,
                UserName = obj.UserName,
                Password = obj.Password,
                UserType = obj.UserType,
            };


            return entity;
        }
        public bool Insert_Customer(CustomerEntity customer)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            bool isInsert = false;
            int insert = dbContext.INSERT_CUSTOMER_TOSQL(customer.FullName, customer.Address, customer.Mobile, customer.UserName, customer.Password, customer.Email, customer.Avatar,customer.UserType);
            if (insert > 0)
            {
                isInsert = true;
            }
            return isInsert;
        }
        public bool Update_Customer(CustomerEntity customer)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            bool isUpdate = false;
            int update = dbContext.UPDATE_CUSTOMER_TOSQL(customer.UserName,customer.FullName, customer.Address, customer.Mobile,customer.UserType,customer.Password, customer.Email, customer.Avatar);
            if (update > 0)
            {
                isUpdate = true;
            }
            return isUpdate;
        }
        public bool Check_User_FB_And_GG(string username, string usertype)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            bool ischeck = false;
            var entity = dbContext.CHECK_USER_LOGIN(username, usertype).FirstOrDefault();
            if (entity!=null)
            {
                ischeck = true;
            }
            return ischeck;
        }
        public bool Check_User_App(string username, string password,string usertype)
        {
            if (dbContext == null)
            {
                dbContext = new FoodDeliveryEntities();

            }
            bool ischeck = false;
            var entity = dbContext.CHECK_LOGIN(username, password,usertype).FirstOrDefault();
            if(entity!=null)
            {
                ischeck = true;
            }
            return ischeck;
        }

    }
}
