    using System;

    public class ShoppingBillCalculator
    {
        static void Main()
        {
            string custName;
            float[] itemPrice = new float[5];
            Console.WriteLine("Enter the customer name:");
            custName = Console.ReadLine();
            Console.WriteLine("Enter the price of 5 items:");
            for( int i=0; i<5; i++)
            {
                itemPrice[i] = float.Parse(Console.ReadLine());
            }
            float totalPrice = itemPrice[0]+itemPrice[1]+itemPrice[2]+itemPrice[3]+itemPrice[4];
            float averagePrice = totalPrice/5;
            float highestPrice = itemPrice[0];
            float lowestPrice = itemPrice[0];
            for(int i=1; i<5; i++)
            {
                if(itemPrice[i] > highestPrice)
                {
                    highestPrice = itemPrice[i];
                }
                else if(itemPrice[i] < lowestPrice)
                {
                    lowestPrice = itemPrice[i];
                }
            }
            float? discount = null;
            Console.WriteLine("Enter the discount percentage:");
            string discountInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(discountInput))
            {
                discount = float.Parse(discountInput);
            }
    float finalPrice = totalPrice - ((totalPrice * (discount ?? 0)) / 100);

            Console.WriteLine("Here are the details of the shopping bill:");
            Console.WriteLine($"Customer Name : {custName}");
            Console.WriteLine($"Price of all items: ");
            Console.WriteLine($"1st item : {itemPrice[0]}");
            Console.WriteLine($"2nd item : {itemPrice[1]}");
            Console.WriteLine($"3rd item : {itemPrice[2]}");
            Console.WriteLine($"4th item : {itemPrice[3]}");
            Console.WriteLine($"5th item : {itemPrice[4]}");
            Console.WriteLine($"Total Price : {totalPrice}");
            Console.WriteLine($"Average Price : {averagePrice}");
            Console.WriteLine($"Highest Price : {highestPrice}");
            Console.WriteLine($"Lowest Price : {lowestPrice}");
            Console.WriteLine($"Discount : {(discount.HasValue ? discount.ToString() : "Not Applied")}");
            Console.WriteLine($"Final Price : {finalPrice}");


        }
    }