using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class StoreArticle:Article, IComparable<StoreArticle>
    {
        public string Category { get; set; }
        public string ImgFile { get; set; }

        /**
         * Constructor with full variables
         */
        public StoreArticle(int shopNr, string shopName, int articleNr, string articleName, double price, int available, string img, string category)
            : base(shopNr, shopName, articleNr, articleName, price, available)
        {
            // using base 
            this.ImgFile = img;
            this.Category = category;
        }

        // Sort by category
        public int CompareTo(StoreArticle other)
        {
            return this.Category.CompareTo(other.Category);
        }
    }
}
