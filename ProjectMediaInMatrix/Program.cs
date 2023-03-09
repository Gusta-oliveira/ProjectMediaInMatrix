double[,] matrix = new double[5, 3];

for(int line = 0; line < 5; line++)
{
    for(int column = 0; column < 2; column++)
    {
        Console.Write($"Matriz [{line}][{column}]: ");
        matrix[line, column] = double.Parse(Console.ReadLine());
    }
}
for(int line = 0; line < 5; line++)
{
    matrix[line, 2] = (matrix[line, 0] + matrix[line, 1]) / 2;
}

for (int line = 0; line < 5; line++)
{

    Console.WriteLine("Media dos valores " + matrix[line, 0] + " e " + matrix[line, 0+1] + " = " + matrix[line, 2]);
}