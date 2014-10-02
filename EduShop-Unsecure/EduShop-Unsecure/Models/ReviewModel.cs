using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduShop_Unsecure.Models
{
    public class ReviewModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}