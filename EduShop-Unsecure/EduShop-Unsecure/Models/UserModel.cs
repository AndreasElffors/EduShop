using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using EduShop_Database;

namespace EduShop_Unsecure.Models
{
    public class UserModel
    {

       private static readonly EduShop_Database.EduShopEntities context = new EduShopEntities();

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }

        public static User CheckForUser(UserModel userModel)
        {
            return (
                from c in context.UserSet
                where c.Email == userModel.Email && c.Password == userModel.Password
                select c).FirstOrDefault();
        }

        public static UserModel ConvertToUserModel(User user)
        {
            var userModel = new UserModel()
            {
                Id = user.Id,
                 Email= user.Email,
                Password = user.Password,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Address = user.Address,
                Zip = user.Zip,
                City = user.City,
                Phone = user.Phone,
                IsAdmin = user.IsAdmin
            };
            return userModel;
        }

        public static User ConvertToUserModel(UserModel userModel)
        {
            var user = new User()
            {
                Id = userModel.Id,
                Email = userModel.Email,
                Password = userModel.Password,
                Firstname = userModel.Firstname,
                Lastname = userModel.Lastname,
                Address = userModel.Address,
                Zip = userModel.Zip,
                City = userModel.City,
                Phone = userModel.Phone,
                IsAdmin = userModel.IsAdmin
            };
            return user;
        }

    }
}