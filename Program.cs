int a, b;
int[,] A;
Console.Write("Введите количество строк в матрице: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
b = int.Parse(Console.ReadLine());
A = new int[a, b];
Random rnd = new Random();
 
            
for (int i = 0; i < a; i++)
    for (int j = 0; j < b; j++)
        A[i, j] = rnd.Next(-0, 10 + 1);
 
            
    for (int i = 0; i < a; i++, Console.WriteLine())
        for (int j = 0; j < b; j++)
            Console.Write(A[i, j] + "\t");
            int minsummaStroki = int.MaxValue, indexMinStroki = 0;
 
        for (int i = 0; i < a; i++)
     {
        int summaStroki = 0;
         for (int j = 0; j < b; j++)
            summaStroki += A[i, j];
                
        if (summaStroki < minsummaStroki)
        {
            minsummaStroki = summaStroki;
            indexMinStroki = i;
        }
        }
 
        Console.WriteLine("Строка с минимальной суммой элементов");
            for(int j = 0;j<b;j++)
                Console.Write(A[indexMinStroki, j] + "\t");