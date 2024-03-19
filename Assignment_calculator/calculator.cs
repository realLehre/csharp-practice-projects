
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");

var firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number");

var secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");



RunOperation();


var resolve = Console.ReadLine();
if(resolve == "Y" || resolve == "y")
{
    RunOperation(); 
} else
{
    Console.ReadKey();  
}

void RunOperation()
{
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply");

    var operation = Console.ReadLine();
    switch (operation)
    {
        case "a":
        case "A":
            Console.WriteLine($"{PerformOperation("+")} = {firstNumber + secondNumber}");
            break;
        case "s":
        case "S":
            Console.WriteLine($"{PerformOperation("-")} = {firstNumber - secondNumber}");
            break;
        case "m":
        case "M":
            Console.WriteLine($"{PerformOperation("*")} = {firstNumber * secondNumber}");
            break;
        default:
            //Console.WriteLine("Invalid option");
            Console.WriteLine("Retry? Y/N");
            break;

    }

}

string PerformOperation(string action)
{
    return $"{firstNumber} {action} {secondNumber}";
}

//Console.ReadLine(); 
Console.ReadKey();  

