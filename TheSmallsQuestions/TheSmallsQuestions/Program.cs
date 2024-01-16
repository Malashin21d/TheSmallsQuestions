using System.Security.Authentication;

int Varible1;
int Varible2;
Double Amount;
int Task;

Console.WriteLine("Выберите задание от 1 до 5");
Task = int.Parse(Console.ReadLine());
if (Task == 1)
{
    Task1();
}
else if (Task == 2)
{
    Task2();
}
else if (Task == 3)
{
    Task3();
}
else if (Task == 4)
{
    Task4();
}
else if (Task == 5)
{
    Task5();
}
else
{
    Console.WriteLine("Нельзя так");
}
void Task1()
{
	Console.WriteLine("Введите первое число");
	Varible1 =int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    Varible2 = int.Parse(Console.ReadLine());
    if (Varible1 ==Varible2)
	{
		Console.WriteLine("Числа равны");
	}
	else
	{
		if (Varible1 > Varible2)
		{
			Console.WriteLine("Число {0} больше чем число {1} ", Varible1, Varible2);
		}
		else
		{
			Console.WriteLine("Число {0} меньше чем число {1} ", Varible1, Varible2);
		}
	} 
		
}
void Task2()
{
	Console.WriteLine("Введите число");
	Varible1 = int.Parse(Console.ReadLine());
	if (Varible1 >5 && Varible1 <10)

	{
		Console.WriteLine("Число больше 5 и меньше 10");
	}
	else
    {
        Console.WriteLine("Неизвестное число");
    }
}
void Task3()
{
    Console.WriteLine("Введите число");
    Varible1 = int.Parse(Console.ReadLine());
    if (Varible1 > 5 || Varible1 < 10)

    {
        Console.WriteLine("Число равно 5 или 10");
    }
    else
    {
        Console.WriteLine("Неизвестное число");
    }
}
void Task4()
{
    Console.WriteLine("Введите число");
	Amount = Convert.ToDouble(Console.ReadLine());

    if (Amount < 100)
	{
		Amount = Amount + (Amount * 0.07);
		Console.WriteLine(Amount);
	}
	else
	{
		if (Amount <= 200) 
		{
            Amount = Amount + (Amount * 0.09);
            Console.WriteLine(Amount);
        }
		else
		{
            Amount = Amount + (Amount * 0.12);
            Console.WriteLine(Amount);
        }
	}
    
}
void Task5()
{
    Console.WriteLine("Введите число");
    Amount = Convert.ToDouble(Console.ReadLine());

    if (Amount < 100)
    {
        Amount = Amount + (Amount * 0.07);
        Console.WriteLine(Amount+15);
    }
    else
    {
        if (Amount <= 200)
        {
            Amount = Amount + (Amount * 0.09);
            Console.WriteLine(Amount+15);
        }
        else
        {
            Amount = Amount + (Amount * 0.12);
            Console.WriteLine(Amount+15);
        }
    }
}