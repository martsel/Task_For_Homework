Console.Write("Введите число A:  ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B:  ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C:  ");
int numberC = Convert.ToInt32(Console.ReadLine());

int temp;

if (numberA >= numberB) 
{
    temp = numberA;
    numberA = numberB;
    numberB = temp;
}

if (numberB >= numberC)
{
    temp = numberB;
    numberB = numberC;
    numberC = temp;
}

Console.WriteLine(numberC);
