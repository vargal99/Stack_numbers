
using System.Collections;
internal static class NumberProgram
{
    public static void Main(string[] args)
    {

        Stack stack = new Stack();
        int szam;

        Console.WriteLine("Add meg az első számot!");
        szam = Convert.ToInt32(Console.ReadLine());
        while (szam != 0)
        {
            stack.Push(szam);
            Console.WriteLine("Add meg a következő számot!");
            szam = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("\nA számok visszafelé: ");
        foreach (var szamok in stack)
        {
            
            Console.WriteLine(szamok);
        }
    }
}

