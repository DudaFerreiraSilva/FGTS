decimal salario, fgts;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Salário (R$): ");
salario = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

fgts = (salario / 100) * 8;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nFGTS: {fgts:C2}");
Console.ResetColor();