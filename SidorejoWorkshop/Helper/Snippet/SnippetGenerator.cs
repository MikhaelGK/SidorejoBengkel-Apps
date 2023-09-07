using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SidorejoWorkshop.Helper.Snippet
{
    public static class SnippetGenerator
    {
        public static string GenerateProductId()
        {
            var character = "1234567890";
            var random = new Random();
            var sb = new StringBuilder();
            var context = new db();

            while (true)
            {
                sb.Insert(0, "P");

                for (int i = 0; i < 5; i++)
                {
                    sb.Append(character[random.Next(character.Length)]);
                }

                var exa = sb.ToString();
                var product = context.Products
                    .FirstOrDefault(x => x.ProductId == exa);
                if (product is null)
                {
                    break;
                }

                sb.Clear();
            }

            return sb.ToString();
        }

        public static string GenerateCustomerId()
        {
            var character = "1234567890";
            var random = new Random();
            var context = new db();
            var sb = new StringBuilder();
            

            while (true)
            {
                sb.Insert(0, "C");

                for (int i = 0; i < 5; i++)
                {
                    sb.Append(character[random.Next(character.Length)]);
                }

                var exa = sb.ToString();
                var customer = context.Customers.
                    FirstOrDefault(x => x.CustomerId == exa);
                if (customer is null)
                {
                    break;
                }

                sb.Clear();
            }

            return sb.ToString();
        }

        public static string GenerateVehicleId()
        {
            var character = "1234567890";
            var random = new Random();
            var sb = new StringBuilder();
            var context = new db();

            while (true)
            {
                sb.Insert(0, "V");

                for (int i = 0; i < 5; i++)
                {
                    sb.Append(character[random.Next(character.Length)]);
                }

                var exa = sb.ToString();
                var vehicle = context.Vehicles
                    .FirstOrDefault(x => x.VehicleId == exa);
                if (vehicle is null)
                {
                    break;
                }

                sb.Clear();
            }


            return sb.ToString();
        }

        public static string GenerateTransactionId()
        {
            var sb = new StringBuilder();
            sb.Insert(0, "T" + DateTime.Now.Year);

            var context = new db();
            var dt = context.HeaderTrxes
                .Select(x => x.TrxId)
                .ToList();
            if (dt.Count == 0) return sb.Append("00001").ToString();

            var id = Convert.ToInt32(dt.Last().Substring(5));
            id += 1;

            if (id < 10) return sb.Append("0000" + id).ToString();
            else if (id < 100) return sb.Append("000" + id).ToString();
            else if (id < 1000) return sb.Append("00" + id).ToString();
            else if (id < 10000) return sb.Append("0" + id).ToString();
            else return sb.Append(id).ToString();
        }
    }
}
