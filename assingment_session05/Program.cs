namespace assingment_session05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1
            //double[] hi = [25.5, 40.0, 33.75];
            //Console.WriteLine(hi[1]);



            //Q2
            //int[,] shelfCopies = new int[2, 2]
            //{

            //    {3,5 },
            //    {1,4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);

            //q3
            //PrintWelcomeMessage();

            //q4
            //Console.WriteLine("Enter Book Name");
            //string title = Console.ReadLine();
            //PrintBookTitle(title);

            //q5
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            //adding 50 inside the method does not change the original value.

            //q6
            //double[] prices = [25.5, 40.0];
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // chanhge value of the first element in the array inside the method, which will change the original value of the array.

            //q7
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);

            // when use ref passes the original variable to the method, not a copy


            ///q8
            //double[] prices = { 25.5, 40.0 };

            //ReplaceArray(ref prices);

            //Console.WriteLine(prices.Length);
        }
        //q3
        //static void  PrintWelcomeMessage()
        //{
        //    Console.WriteLine("welcome to the Library!");
        //}

        //q4
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("book title:" + title);
        //}
        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;

        //}

        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] = prices[0] - 5.0;
        //}


        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 50;
        //}

        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}
    }
}
