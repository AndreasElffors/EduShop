﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using EduShop_Database;
using EduShop_Unsecure.Models;


namespace EduShop_Unsecure.Models
{
    public class ProductModel
    {
        private static readonly EduShop_Database.EduShopEntities context = new EduShopEntities();

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double AverageRating { get; set; }

        public static List<Product> GetProducts()
        {
            return
                (from c in context.ProductSet
                 select c).ToList();
        }

        public static Product GetProduct(int id)
        {
            return (
                from c in context.ProductSet
                where c.Id == id
                select c).FirstOrDefault();
        }

        public static ProductModel ConvertToProductModel(Product product)
        {
            var productModel = new ProductModel()
            {
                Id = product.Id,
                Description = product.Description,
                AverageRating = product.AverageRating,
                CategoryId = product.CategoryId,
                ImgUrl = product.ImgUrl,
                Name = product.Name,
                Price = product.Price,
                ShortDescription = product.ShortDescription
            };
            return productModel;
        }

        public static Product ConvertToProduct(ProductModel productModel)
        {

            var product = new Product()
            {
                Id = productModel.Id,
                Description = productModel.Description,
                AverageRating = productModel.AverageRating,
                CategoryId = productModel.CategoryId,
                ImgUrl = productModel.ImgUrl,
                Name = productModel.Name,
                Price = productModel.Price,
                ShortDescription = productModel.ShortDescription,
            };
            return product;
        }

        public static List<ProductModel> ProductModelsToList()
        {
            var allProductModels = new List<ProductModel>();
            var allProducts = new List<Product>();

            allProducts = GetProducts();

            foreach (var item in allProducts)
            {
                allProductModels.Add(ConvertToProductModel(item));
            }
            return allProductModels;
        }

    }
}