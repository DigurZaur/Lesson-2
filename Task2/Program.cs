//Создать массив и заполнить его числами от 1 до N

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int i = 0; 
while(i < N)
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}