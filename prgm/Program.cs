int n;
Console.WriteLine("Enter n value");
n=Convert.ToInt32(Console.ReadLine());


for(int i=0;i<n;i++)
{
    for(int j=0;j<n-i-1;j++)
    {
        Console.WriteLine(" ");
    }

    for(int j=0;j<2*i+1;j++)
    {
        Console.WriteLine("*");
    }

    for(int j=0;j<n-i-1;j++)
    {
        Console.WriteLine(" ");
    }

}