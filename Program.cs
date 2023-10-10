﻿using System;
using System.Linq;

namespace ProductReviewManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management System");

            List<ProductReview> productReviewList = new List<ProductReview>() 
            {
                 new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 3, UserID = 2, Rating = 2, Review = "Not bad", IsLike = true },
                 new ProductReview() { ProductID = 4, UserID = 2, Rating = 2, Review = "Not bad", IsLike = true },
                 new ProductReview() { ProductID = 5, UserID = 3, Rating = 4, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 6, UserID = 4, Rating = 3, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 7, UserID = 3, Rating = 5, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 8, UserID = 10, Rating = 1, Review = "Bad", IsLike = false },
                 new ProductReview() { ProductID = 9, UserID = 10, Rating = 5, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 10, UserID = 10, Rating = 3, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 11, UserID = 10, Rating = 3, Review = "Nice", IsLike = true },
                 new ProductReview() { ProductID = 12, UserID = 10, Rating = 5, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 13, UserID = 10, Rating = 5, Review = "Good", IsLike = true },
                 new ProductReview() { ProductID = 14, UserID = 10, Rating = 4, Review = "Nice", IsLike = true },
                 new ProductReview() { ProductID = 15, UserID = 10, Rating = 4, Review = "Nice", IsLike = true },
                 new ProductReview() { ProductID = 16, UserID = 10, Rating = 3, Review = "Good", IsLike = true }
            };

            //foreach(var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.IsLike);
            //}

            Management management = new Management();
            management.TopRecords(productReviewList);
        }
    }
}
