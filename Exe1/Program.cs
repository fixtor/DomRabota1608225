int newPow(int number, int degree)
{
    int temp = number;
    for (int i = 1; i < degree; i++)
        number = temp * number;
    return number;
}


Console.Clear();
Console.WriteLine("Введите число:");
int newNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int newDegree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {newNumber} в степени {newDegree} = {newPow(newNumber, newDegree)}");
