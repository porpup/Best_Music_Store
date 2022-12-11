int appCost = 3;
int songCost = 7;
int amount = 0;
do{
    Console.Write("How much money do you wish to prepay?: $");
    amount = Convert.ToInt32(Console.ReadLine());
    if(amount >= 0){

        int songPurchase = amount / songCost;
        int credit1 = amount - (songPurchase * songCost);

        int appPurchase = amount / appCost;
        int credit2 = amount - (appPurchase * appCost);

        Console.WriteLine($"With this amount, you will be able to purchase:");
        Console.WriteLine($"{appPurchase} app(s). You will then have ${credit2} left as a credit on your account.");
        Console.WriteLine("or");

        int appLeft = credit1 / appCost;
        int credit3 = credit1 - (appLeft * appCost);
        Console.WriteLine($"{songPurchase} song(s) and {appLeft} app(s). You will then have ${credit3} left as a credit on your account.");
        break;    
    }else{
        Console.WriteLine("Please enter valid amount!");
    }
}while(amount < 0);
Console.WriteLine("Thanks for Shopping at Best Music Store!");