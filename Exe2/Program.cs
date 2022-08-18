int numberLenght(int num) // Проверка количества символов в числах
{
    int i = 0;
    for (i = 0; num > 0; i++)
        num = num / 10;
    return i;
}

int newSumm(int num, int numberLenght) //Сложение цифр
{
    int temp = 0;
    for (int i = 0; i <= numberLenght; i++)
    {
        temp = temp + num % 10;
        num = num / 10;
    }
    return temp;
}

Console.Clear();
Console.WriteLine("Введите число:");
int newNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Колличество цифр в числе {newNumber} = {numberLenght(newNumber)}");
Console.WriteLine($"Число {newNumber} сумма цифр в числе = {newSumm(newNumber, numberLenght(newNumber))}");