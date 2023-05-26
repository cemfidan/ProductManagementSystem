using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added!";
        public static string ProductNameInvalid = "Product name is invalid!";
        public static string MaintenanceTime = "Maintenance time!";
        public static string ProductsListed = "Products listed!";
        public static string MaxTenProductsInCategory = "There can be a maximum of 10 products in a category!";
        public static string ProductNameAlreadyExists = "Product name is already exists!";
        public static string CategoryLimitExceded = "Category limit exceded!";
        public static string AuthorizationDenied = "Authorization denied!";
        public static string UserRegistered = "User registered!";
        public static string UserNotFound = "User not found!";
        public static string PasswordError = "Password is wrong!";
        public static string SuccessfulLogin = "Login is successful!";
        public static string UserAlreadyExists = "User already exists!";
        public static string AccessTokenCreated = "Access token created!";
    }
}
