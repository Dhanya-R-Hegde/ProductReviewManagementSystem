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
    }
}
