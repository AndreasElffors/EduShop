using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduShop_Database;

namespace EduShop_Unsecure.Models
{
    public class ReviewModel
    {

        private static readonly EduShop_Database.EduShopEntities context = new EduShopEntities();

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Rating { get; set; }
        public DateTime DateAdded { get; set; }

        public static ReviewModel ConvertToReviewModel(Review review)
        {
            var reviewModel = new ReviewModel()
            {
                Id = review.Id,
                ProductId = review.ProductId,
                Content = review.Content,
                Title = review.Title,
                Rating = review.Rating,
                DateAdded = review.DateAdded
            };
            return reviewModel;
        }

        public static Review ConvertToReviewModel(ReviewModel review)
        {
            var reviewModel = new Review()
            {
                Id = review.Id,
                ProductId = review.ProductId,
                Content = review.Content,
                Title = review.Title,
                Rating = review.Rating,
                DateAdded = review.DateAdded
            };
            return reviewModel;
        }

        public static List<Review> GetReviews(int id)
        {
            return (
                from c in context.ReviewSet
                where c.ProductId == id
                select c).ToList();
        }

        public static List<ReviewModel> ReviewModelsToList(int id)
        {
            var allReviewModels = new List<ReviewModel>();
            var allReviews = new List<Review>();

            allReviews = GetReviews(id);

            foreach (var item in allReviews)
            {
                allReviewModels.Add(ConvertToReviewModel(item));
            }
            return allReviewModels;
        }
    }


}