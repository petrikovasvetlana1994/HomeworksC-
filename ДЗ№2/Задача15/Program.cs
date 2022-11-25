Console.Write("Введите цифру, обозначающую день недели(от 1 до 7 включительно): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("это выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("в неделе нет столько дней");
  }
  else Console.WriteLine("это не выходной день");
