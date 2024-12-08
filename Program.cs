namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,25,26,27,28,29,30};

        Console.WriteLine("Введите число которое хотите найти: ");
        int y = Convert.ToInt32(Console.ReadLine());

        foreach (int i in x) {
           if (y == i){
                Console.WriteLine("Поиск показал что, введённое вами числo есть в массиве!");
                break;
           } 
        }
    }
}
