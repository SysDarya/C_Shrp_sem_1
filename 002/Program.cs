// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
// 5 -> Пятница

Console.WriteLine ("Введите номер дня недели: ");
int day = Convert.ToInt32 (Console.ReadLine());

string [] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if (day < 1 || day > 7) 
{
    Console.WriteLine ("К сожалению, в неделе только 7 дней. Попробуйте ввести число от 1 до 7)))");
}
else
{
    Console.WriteLine (days[day-1]);
}