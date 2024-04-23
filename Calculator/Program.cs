Console.WriteLine("Enter the operation (+/-)");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;

    case '-':
        Subtraction(firstNum, secondNum);
        break;
    deafault:
        Console.WriteLine("Invalid operator");
}


static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");

}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}