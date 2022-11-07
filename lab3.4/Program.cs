// 13 variant medium Bogomolov Danill

double Answer = 0;
for (double position = -Math.PI; position <= Math.PI / 2; position += 0.2)
{
    Console.WriteLine($"x= : {position:F2}");
    if (position > 2.5)
    {
        Answer = position + 1;
    }
    else if (position <= 2.5 && position <= 0)
    {
        Answer = 1 - Math.Pow(position, 5);
    }
    else if (position < 0)
    {
        Answer = position + Math.Log(Math.Abs(Math.Sin(position)));
    }
    Console.WriteLine($"y Равен: {Answer:F2}" );
}

