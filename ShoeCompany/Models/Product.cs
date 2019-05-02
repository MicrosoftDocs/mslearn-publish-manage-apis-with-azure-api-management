using System;
using System.Security.Cryptography;

namespace Models.ShoeCompanyTypes
{
    [Serializable]
    public class Product
    {
        public int ProductID { get; set; } = new Random().Next(1000);
        public string ProductName { get; set; } = getRandomString(15);
        public DateTime ProductLaunchDate { get; set; } = DateTime.Now.AddDays(new Random().Next(100) - 50);
        public int ProductLaunchPrice { get; set; } = new Random().Next(100);
        public override string ToString() => $"Product {ProductID}, Name {ProductName}, Launched {ProductLaunchDate}, Initial Price {ProductLaunchPrice}";

        private static string getRandomString(int stringLength)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var bit_count = (stringLength * 6);
                var byte_count = ((bit_count + 7) / 8); // rounded up
                var bytes = new byte[byte_count];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
