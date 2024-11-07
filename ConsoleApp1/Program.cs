
Console.Write("Введите ФИО: ");
var name = Console.ReadLine();

Console.Write("Введите год рождения: ");
var YearOfBirth = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите месяц рождения: ");
var MonthOfBirth = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите день рождения: ");
var DayOfBirth = Convert.ToInt32(Console.ReadLine());

Console.Write("Был ли у вас день рождения в этом году, если да, то введите 1, если нет, то введите 0:\n");
var proverca = Convert.ToUInt32(Console.ReadLine());

var YearsNow = 2024;

if (proverca == 1)
{
    YearsNow = Convert.ToInt32(YearsNow) - Convert.ToInt32(YearOfBirth);
}
else
{
    YearsNow = YearsNow - YearOfBirth - 1; 
}

Console.Write("Введите номер телефона: ");
var number = Console.ReadLine();

Console.Write("Введите почту: ");
var email = Console.ReadLine();

Console.WriteLine($"Салам, {name}\nМы знаем кто ты\nДата рождения: {DayOfBirth}.{MonthOfBirth}.{YearOfBirth}\nНомер: {number}\nПочта: {email}\nВаш возраст: {YearsNow}");