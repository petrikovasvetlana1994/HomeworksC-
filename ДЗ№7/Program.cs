// Доделать ввод многочлена
// https://github.com/iksergey/multi/blob/lesson7/Program.cs
// *Сделать вывод только нечетных коэффициентов у треугольника распечатайте хотя бы 120 строк


int[,] CreateTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
  return triangle;
}

void PrintTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
  {
    for (int j = 0; j < triangle.GetLength(1); j++)
    {
      if (triangle[i, j] != 0)
     
        Console.Write($"{triangle[i, j],6}");
        
    }
    
    Console.WriteLine();
  }
}




int[] GetKoeff(int[,] tr, int pow)
{
  int[] row = new int[pow + 1];
  for (int i = 0; i <= pow; i++)
  
  {
    row[i] = tr[pow, i];
   }
  
  return row;
}


string PrintPolynom(int[] array)
{
  string[] pows = { "", "", "^2", "^3", "^4", "^5", "^6", "^7", "^8", "^9" };
  string output = String.Empty;
  for (int i = 0; i < array.Length; i++)
  {
    int t = array[i];
    if (array[i] == 0) continue;
    else if (i != 0) { output += " + "; }
    
    
    if (i == 0) { output += $"a{pows[array.Length-1]}"; }
    
    if (i == array.Length - 1) { output += $"b{pows[array.Length-1]}"; }
    else if (i != 0 && i != array.Length - 1) 
    { 
      output += $"{t}a{pows[array.Length - i - 1]}*b{pows[i]}"; 
    }

  }
  return output;
}


int[,] tr = CreateTriangle(10);                 // (число) - количество строк
int row = 2;                                    // степень (a + b)
PrintTriangle(tr);
int[] koeff = GetKoeff(tr, row);                
Console.WriteLine($"(a + b)^{row} = {PrintPolynom(koeff)}");
Console.WriteLine();
