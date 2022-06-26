// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Поскольку числа может и не быть, наверное проще всего записать числа по очереди в массив
// и выводить число с индексом [2], если числа не существует должен появиться Error
// в общем решил не конвертировать в ввод с консоли в число 
// и поигрался с преобразованиями из строки в массив



Console.WriteLine("Enter your number, please: ");
string num = Console.ReadLine();
Console.WriteLine("Your number is " + num);
char[] numChar = num.ToCharArray();
if (numChar.Length >= 3) { Console.WriteLine($"The third number is {numChar[2]}"); }
else { Console.WriteLine("This number has no 3rd number"); }
