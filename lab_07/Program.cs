
using lab_07;
using System;

PersonFixPay[] WorkersArray = new PersonFixPay[4];

WorkersArray[0] = new PersonFixPay("Oleg", "Shamov", 'M', 33000, 10);
WorkersArray[1] = new PersonHourPay("Victoria", "Samsonova", 'F', 27000, 30, 8);
WorkersArray[2] = new PersonFixPay("Richi", "Rich", 'M', 1000000, 40);
WorkersArray[3] = new PersonHourPay("Maison", "Margella", 'M', 40000, 25, 7);


double TotalPay(PersonFixPay[] workers)
{
    double res = 0;

    foreach (PersonFixPay worker in workers) 
    {
        res += worker.SumPay();
    }

    return res;
}

double TotalTax(PersonFixPay[] workers)
{
    double x = 0;

    foreach (PersonFixPay worker in workers)
    {
        x += worker.TaxPay();
    }

    return x;
}

PersonFixPay MaxPay(PersonFixPay[] workers)
{
    double MaxMoney = 0;
    int index = 0;
    for (int i = 0; i < workers.Length; i++)
    {
        if (workers[i].FinalPay() > MaxMoney)
        {
            index = i;
            MaxMoney = workers[i].FinalPay();
        }
    }

    return workers[index];
}

Console.WriteLine($"Total pay: {TotalPay(WorkersArray)}");
Console.WriteLine($"Total tax: {TotalTax(WorkersArray)}");
Console.WriteLine($"Max pay: {MaxPay(WorkersArray).ToString()}");




