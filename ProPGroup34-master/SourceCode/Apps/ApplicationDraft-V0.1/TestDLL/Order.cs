using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Order
    {
        /// <summary>
        /// This class holds information about an order
        /// </summary>

        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int OrderNr { get; set; }
        public DateTime OrderDate { get; set; }
        public Shop Shop { get; set; }
        public int VisitorNr { get; set; }
        public List<Article> Articles { get; set; }
        public List<int> Quantity { get; set; }

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

        /// <summary>
        /// Export order's information as a string
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Add an article by n quantity
        /// </summary>
        /// <param name="a"></param>
        /// <param name="nr"></param>
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

        /// <summary>
        /// Remove an article by n quantity
        /// </summary>
        /// <param name="a"></param>
        /// <param name="nr"></param>
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

        /// <summary>
        /// Get total sum of an order
        /// </summary>
        /// <returns></returns>
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

        public string GetDepositReceipt()
        {
            if (Articles.Count != 0)
            {
                string info = "--- WELCOME TO " + Shop.ShopName.ToUpper() + " ---\n";
                

                if (OrderDate != DateTime.MinValue)
                {
                    info += "Borrowed at: " + OrderDate.ToString() + "\n\n";
                }
                else
                {
                    info += "\nYou are loaning: \n";
                }

                for (int i = 0; i < Articles.Count; i++)
                {
                    info += Articles[i].ArticleName
                        + "\t - Deposit value:€ " + ((LoanArticle)Articles[i]).DepositValue.ToString("0.00") + "\n";
                }

                info += "\nTOTAL: €" + GetLoanDeposit().ToString("0.00") + "\n";

                if (OrderDate != DateTime.MinValue)
                {
                    info += "\nThank you for your purchase!";
                }

                return info;
            }

            return "NO ARTICLES IN ORDER";
        }

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
       
        public double GetLoanFee()
        {
            double sum = 0;
            for (int i = 0; i < Articles.Count; i++)
            {
                sum += Articles[i].Price * Quantity[i];
            }
            return sum;
        }

        public string GetReturnReceipt()
        {
            if (Articles.Count != 0)
            {
                double sum = GetLoanFee();
                double depositVal = GetLoanDeposit();

                string info = "--- WELCOME TO " + Shop.ShopName.ToUpper() + " ---\n";
                

                if (OrderDate != DateTime.MinValue)
                {
                    info += "Processed at: " + OrderDate.ToString() + "\n\n";
                }
                else
                {
                    info += "\nYou are returning: \n";
                }

                for (int i = 0; i < Articles.Count; i++)
                {
                    info += Articles[i].ArticleName
                        + "\t - Deposit value: " + ((LoanArticle)Articles[i]).DepositValue 
                        + "\n - " + Articles[i].Price + " x " + Quantity[i] + " hours"
                        + "\t - Subtotal: " + Articles[i].Price * Quantity[i]
                        + "\n";
                }

                info += "\nDeposit values: €" + depositVal.ToString("0.00") + "\n";
                info += "\nLoan fees: €" + sum.ToString("0.00") + "\n";

                if (depositVal - sum <= 0)
                {
                    info += "\nBalance deducted by €" + (sum - depositVal).ToString("0.00") + "\n";
                }
                else
                {
                    info += "\nBalance added by: €" +  (depositVal - sum).ToString("0.00") + "\n";
                }

                if (OrderDate != DateTime.MinValue)
                {
                    info += "\nThank you for your purchase!";
                }

                return info;
            }

            return "NO ARTICLES IN ORDER";
        }

    }
}
