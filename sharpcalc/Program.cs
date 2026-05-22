Console.WriteLine("←———— Calculator With C# ————→");

do
{
    double a, b;

    Console.Write("⟭ Enter the first number: ");
    while (!double.TryParse(Console.ReadLine(), out a))
        Console.Write("✗ Invalid number. Try again: ");

    string[] validOps = { "+", "-", "*", "/" };
    string op;

    do
    {
        Console.Write("⟭ Enter the operator (+, -, *, /): ");
        op = Console.ReadLine()!.Trim();
        if (!validOps.Contains(op))
            Console.WriteLine("✗ Invalid operator. Please enter +, -, * or /");
    } while (!validOps.Contains(op));

    Console.Write("⟭ Enter the second number: ");
    while (!double.TryParse(Console.ReadLine(), out b))
        Console.Write("✗ Invalid number. Try again: ");

    double result = op switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" when b == 0 => double.NaN,
        "/" => a / b,
        _ => 0
    };

    if (double.IsNaN(result))
        Console.WriteLine("✗ Division by zero is not allowed!");
    else
        Console.WriteLine($"⟭ Result: {result}");

    Console.Write("\n⟭ New calculation? (y/n): ");

} while (Console.ReadLine()!.Trim().ToLower() == "y");