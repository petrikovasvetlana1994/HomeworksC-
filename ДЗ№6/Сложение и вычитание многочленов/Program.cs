//Урок 6. Задача: Написать программу сложения и вычитания двух многочленов
// пример с семинара
// f(x) = 4*x^3 + 3*x^2 + x + 11
// g(x) = 10*x^3 + x + 10
// f(x) + g(x) = 14*x^3 + 3*x^2 + 2*x + 21
// f(x) - g(x) = -6*x^3 + 3*x^2 + 1



// Сложение многочленов
int[] Sum(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] + g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}



// Вычетание многочленов
int[] Dif(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    if (powG > powF)
    {
    result[i] = g[i] - f[i];
    }
    else result[i] = f[i] - g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}

string Print(int[] f)
{
  string[] pows = { "^0", "^1", "^2", "^3", "^4", "^5", "^6", "^7", "^8", "^9" };
  string output = String.Empty;
  for (int i = 0; i < f.Length; i++)
  {

    int t = f[i];
    if (f[i] == 0) continue;
    if (f[i] < 0) { output += " - "; }
    else if (i != 0) { output += " + "; }
    //else { output += "  "; }

    if (t < 0) t = -t;
    if (i != 0 && f[i] == 1) { output += $"x{pows[i]}"; }
    else if (i == 1) { output += $"{t}x"; }
    if (i == 0) { output += $"{t}"; }

    if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x{pows[i]}"; }

    //if (flag && f[i] != 0 && i < f.Length - 1) output += " + ";
  }

  return output;
}

//.........0..1..2..3..4..5.................
int[] f = {1, 2, 0, 4, 5, 16};
int[] g = {3, 5};
// f(x) = 1*x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4 + 16*x^5
// g(x) = 3*x^0 + 5*x^1 + 0*x^2 + 4*x^3 + 5*x^4 + 16*x^5

Console.Write("Первый многочлен ");
Console.WriteLine(Print(f));

Console.Write("Второй многочлен ");
Console.WriteLine(Print(g));

int[] s = Sum(f, g);
int[] d = Dif(f, g);

Console.Write("Сумма многочленов равна ");
Console.WriteLine(Print(s));

Console.Write("Разность многочленов равна ");
Console.WriteLine(Print(d));

//f(x) = a0*x^0 + a1*x^1 + a2*x^2 + a3*x^3 + a4*x^4 + ....+ aN*x^N

System.Console.WriteLine();