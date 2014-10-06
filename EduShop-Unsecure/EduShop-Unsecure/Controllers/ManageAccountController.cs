﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduShop_Unsecure.Models;

namespace EduShop_Unsecure.Controllers
{
    public class ManageAccountController : Controller
    {
        // GET: ManageAccount
        [ChildActionOnly]
        public ActionResult Login()
        {
            return PartialView("_Login",new UserModel());
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            return PartialView("_Login");
        }

        public ActionResult Register()
        {
            return View();
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult Register(UserModel model)
        {
            return View(model);
        }

        public ActionResult ShoppingCart()
        {
            return PartialView("_ShoppingCart");         
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult ShoppingCart(List<OrderRowModel> orderRows )
        {
            return PartialView("_ShoppingCart");
        }
    }
}