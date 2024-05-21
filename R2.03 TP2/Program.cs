
class Program
{
    static void Main()
    {
        int[] T = { 1, 2, 3, 4, 5 };

        ResetTab(T);

        foreach (int value in T)
        {
            Console.Write(value + " ");
        }
    }

    static void ResetTab(int[] T)
    {
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = 0;
        }
    }
}
