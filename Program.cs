Console.WriteLine("Введите номер масти карты (1-пик, 2-крести, 3-бубен, 4-червь ");
int cardNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер достоинства карты");
int cardDignity = Convert.ToInt32(Console.ReadLine());

switch (cardDignity)
{
    case 6:
        Console.Write("Шестерка");
        break;
    case 7:
        Console.Write("Семерка");
        break;
    case 8:
        Console.Write("Восьмерка");
        break;
    case 9:
        Console.Write("Девятка");
        break;
    case 10:
        Console.Write("Десятка");
        break;
    case 11:
        Console.Write("Валет");
        break;
    case 12:
        Console.Write("Дама");
        break;
    case 13:
        Console.Write("Король");
        break;
    case 14:
        Console.Write("Туз");
        break;
}
switch (cardNumber)
{
    case 1:
        Console.Write("\n пик");
        break;
    case 2:
        Console.Write("\n крести");
        break;
    case 3:
        Console.Write("\n бубен");
        break;
    case 4:
        Console.Write("\n червей");
        break;
}
