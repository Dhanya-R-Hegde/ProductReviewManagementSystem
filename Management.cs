using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProductReviewManagementSystem
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                orderby productReview.Rating descending
                                select productReview).Take(3);


            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.IsLike);
            }
        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                where (productReview.ProductID == 1 && productReview.Rating > 3) || (productReview.ProductID == 4 && productReview.Rating > 3) || (productReview.ProductID == 9 && productReview.Rating > 3)
                                select productReview);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.IsLike);
            }
        }

        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach(var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "----" + list.Count);
            }
        }

        public void RetriveProductIDAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                select new { productReview.ProductID, productReview.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + " " + list.Review);
            }

        }

        public void RetriveRecordsExceptTop5(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                select productReview).Skip(5);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.IsLike);
            }

        }

        public void RetriveRecordsWhereIsLikeisTrue(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                where productReview.IsLike == true
                                select productReview);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.IsLike);
            }

        }

        public void RetriveAverageRating(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                select productReview.Rating).Average();
            Console.WriteLine("Average Rating is : " + recordedData);

        }

        public void RetriveRecordsWhereReviewMessageIsNice(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                where productReview.Review == "Nice"
                                select productReview);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.IsLike);
            }
        }
    }
}
