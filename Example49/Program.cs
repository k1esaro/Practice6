Console.WriteLine("Введите количество колонок");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбиков");
int m = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[n, m];
Random rn = new Random();
for (int i = 0; i < n; i++)
	for (int j = 0; j < m; j++)
		mas[i, j] = rn.Next(-10 , 10);
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
		Console.Write(String.Format("{0,3}", mas[i, j]));
	Console.WriteLine();
}       
Console.WriteLine("Введите желаемую позицию");
int pos = Convert.ToInt32(Console.ReadLine());
int n1 , m1;
if (pos<=m*n){
    n1 = pos/n;
    m1 = pos/m;
    Console.WriteLine(mas[n1,m1]);
}
else{
    Console.WriteLine("Такого числа нет");
}