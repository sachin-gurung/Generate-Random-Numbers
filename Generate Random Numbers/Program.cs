/*
 * C# Program to Generate Random Numbers
 */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Some Random Numbers that are generated are : ");
        for (int i = 1; i < 10; i++)
        {
            Randfunc();
        }
    }
    static Random r = new Random();
    static void Randfunc()
    {
        int n = r.Next();
        Console.WriteLine(n);
        Console.ReadLine();
    }
}
/*
Some Random Numbers that are generated are :
423504359

1114355466

1478185975

673460588

1049725257

711372861

149717477

954732525

1918860834

Press any key to continue . . .
*/
