﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduShop_Unsecure.Models;

namespace EduShop_Unsecure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View(ProductModel.ProductModelsToList());
        }

        public ActionResult ProductPartial(int id)
        {
            var productModel = ProductModel.ConvertToProductModel(ProductModel.GetProduct(id));

            return PartialView("_ProductPartial", productModel);
        }

        //[HttpPost]
        //public ActionResult ProductPartial(string product)
        //{
        //    return PartialView("_ProductPartial");
        //}

        public ActionResult ProductInfo()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Sidebar()
        {
            return PartialView("_Sidebar");
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult Sidebar(string category)
        {
            return PartialView("_Sidebar");
        }


        public ActionResult Comment()
        {
            return PartialView("_Comment");
        }
        [ChildActionOnly]
        [HttpPost]
        public ActionResult Comment(string comment)
        {
            return PartialView("_Comment");
        }

        public ActionResult Review()
        {
            return PartialView("_Review", new ReviewModel());
        }
        [ChildActionOnly]
        [HttpPost]
        public ActionResult Review(ReviewModel review)
        {
            return PartialView("_Review");
        }


    }
}