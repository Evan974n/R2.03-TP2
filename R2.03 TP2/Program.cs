
class Program
{
    static void Main()
    {
        int[] T = { 1, 2, 3, 4, 5 };

        ResetTab(T);

        foreach (int res in T)
        {
            Console.Write(res + " ");
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
