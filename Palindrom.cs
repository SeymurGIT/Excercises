using System;
//hazir funksiyasiz yaz! :<

internal class 
{
    static void Main(string[] args)
    {
        Console.Write("Ededi daxil et: ");
        int Eded = Convert.ToInt32(Console.ReadLine());

        string IntToString = Eded.ToString();
        char[] charMassiv = IntToString.ToCharArray();
        Array.Reverse(charMassiv);  //hazir funksiya :<
        string Reversed = new string(charMassiv); //

        bool Palindrom = IntToString.Equals(Reversed);   //hazir funksiya :<

        if (Palindrom)
        {
            Console.WriteLine("Bu eded polindromdur");
        }
        else
        {
            Console.WriteLine("Bu eded polindrom deyil!");
        }
    }
}







