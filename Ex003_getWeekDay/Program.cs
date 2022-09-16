// По заданному номеру выдаем день недели

Console.Write("Введите номер дня недели: ");
int numberWeekDay= Convert.ToInt32(Console.ReadLine()!);

if (numberWeekDay==1) Console.WriteLine ("Понедельник");
if (numberWeekDay==2) Console.WriteLine ("Вторник");
if (numberWeekDay==3) Console.WriteLine ("Среда");
if (numberWeekDay==4) Console.WriteLine ("Четверг");
if (numberWeekDay==5) Console.WriteLine ("Пятница");
if (numberWeekDay==6) Console.WriteLine ("Суббота");
if (numberWeekDay==7) Console.WriteLine ("Воскресенье");
if (numberWeekDay<1) Console.WriteLine ("Не может быть меньше 1");
if (numberWeekDay>7) Console.WriteLine ("Не может быть больше 7");