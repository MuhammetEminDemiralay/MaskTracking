// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


GetHello();
int result = Sum();
Console.WriteLine(result);
GetName();
int sum = Sum2(25, 58);
Console.WriteLine(sum);


static void GetHello()
{
    Console.WriteLine("Hello");
}

static void GetName(string name = "Muhammet")
{
    Console.WriteLine(name);
}

static int Sum()
{
    return 10;
}

static int Sum2(int number1, int number2)
{
    return number1 + number2;
}
