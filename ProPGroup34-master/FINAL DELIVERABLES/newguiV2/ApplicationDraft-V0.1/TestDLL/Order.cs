using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Order
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int OrderNr { get; set; }
        public DateTime OrderDate { get; set; }
        public Shop Shop { get; set; }
        public int VisitorNr { get; set; }
        public List<Article> Articles { get; set; } // list of articles ordered
        public List<int> Quantity { get; set; } // list of quantities 
                                                // Articles[i] will have Quantity[i]

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Order(Shop originShop)
        {
            Shop = originShop;
            Articles = new List<Article>();
            Quantity = new List<int>();
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        // export receipt
        public override string ToString()
        {
            if (Articles.Count != 0)
            {
                string info = "--- WELCOME TO " + Shop.ShopName.ToUpper() + " ---\n";
                info += "\nYour order: \n";

                if (OrderDate != DateTime.MinValue)
                {
                    info += "Purchased at: " + OrderDate.ToString() + "\n\n";
                }

                for (int i = 0; i < Articles.Count; i++)
                {
                    info += Articles[i].ArticleName
                        + "\t - Quantity: " + Quantity[i]
                        + "\t - Subtotal:" + Articles[i].Price * Quantity[i] + "\n";
                }

                info += "\nTOTAL: €" + GetSum().ToString("0.00") + "\n";

                if (OrderDate != DateTime.MinValue)
                {
                    info += "\nThank you for your purchase!";
                }

                return info;
            }

            return "NO ARTICLES IN ORDER";
        }

        // add article to order by n quantity
        public void AddArticle(Article a, int nr)
        {
            if (Articles.Count != 0)
            {
                for (int i = 0; i < Articles.Count; i++)
                {
                    if (Articles[i] == a)
                    {
                        Quantity[i] += nr;
                        return;
                    }
                }
            }
            Articles.Add(a);
            Quantity.Add(nr);
        }

        // set article in order to n quantity
        public void SetQuantity(Article a, int nr)
        {
            for (int i = 0; i < Articles.Count; i++)
            {
                if (Articles[i] == a)
                {
                    if (nr <= 0)
                    {
                        Quantity.RemoveAt(i);
                        Articles.RemoveAt(i);
                    }
                    else
                    {
                        Quantity[i] = nr;
                    }
                    return;
                }
            }
        }

        // Get sum of an order
        public double GetSum()
        {
            double sum = 0;

            if (Articles.Count != 0)
            {
                for (int i = 0; i < Articles.Count; i++)
                {
                    sum += Articles[i].Price * Quantity[i];
                }
            }

            return sum;
        }

        // get total loan deposit 
        public double GetLoanDeposit()
        {
            double sum = 0;

            if (Articles.Count != 0)
            {
                for (int i = 0; i < Articles.Count; i++)
                {
                    sum += ((LoanArticle)Articles[i]).DepositValue;
                }
            }

            return sum;
        }

        // checks if an article is already in the order
        public bool ExistsArticle (Article article)
        {
            foreach (Article a in Articles)
            {
                if (a.ArticleNr == article.ArticleNr && a.ShopNr == article.ShopNr)
                {
                    return true;
                }
            }
            return false;
        }

        // get loan fee
        public double GetLoanFee()
        {
            double sum = 0;
            for (int i = 0; i < Articles.Count; i++)
            {
                sum += Articles[i].Price * Quantity[i];
            }
            return sum;
        }

    }
}
