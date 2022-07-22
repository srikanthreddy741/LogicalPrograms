namespace LogicalPrograms
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter How many unique coupons do you want: ");
            int number = Convert.ToInt32(Console.ReadLine());
            distinctCoupon(number);
        }
        static void generateCoupon()
        {
            double coupon = (random.NextDouble() * 1000000);
            Console.WriteLine((int)coupon);
        }
        static void distinctCoupon(int number)
        {
            Console.WriteLine("Unique Coupons are: ");
            while (number > 0)
            {
                generateCoupon();
                number--;
            }
        }
    }
}