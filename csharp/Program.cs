namespace csharp;

public class Program
{
    private static Random rand = new Random();

    public int[] GetRandomArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 100);
        }
        return arr;
    }

    public int UniqueElements(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < array.Length; j++)
            {
                if (i != j && array[i] == array[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                count++;
            }
        }
        return count;
    }

    public int EvenElements(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public int OddElements(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        int[] randomArray = program.GetRandomArray(10);

        Console.WriteLine("Random Array: " + string.Join(", ", randomArray));
        Console.WriteLine("Unique Elements: " + program.UniqueElements(randomArray));
        Console.WriteLine("Even Elements: " + program.EvenElements(randomArray));
        Console.WriteLine("Odd Elements: " + program.OddElements(randomArray));
    }
}