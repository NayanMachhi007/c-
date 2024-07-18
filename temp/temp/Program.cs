Console.WriteLine("please Enter the value :");
int a = Convert.ToInt32(Console.ReadLine());    

for (int i = 1; i <= a; i++)

{
    //int b = a--;
    for (int j = a-i ; j >= 1; j--)
    {
        Console.Write(" ");
    }
    for (int k= 1; k<=i; k++)
    {
        Console.Write("* ");
    }

    Console.WriteLine("\n");
}


