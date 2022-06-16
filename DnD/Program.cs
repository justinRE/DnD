namespace DnD
{
    class Program
    {

        static Random random = new Random();

        static void Main(string[] args)
        {
            Player deend = new Player { armorClass = 9, name= "deend" };
            Player maylar = new Player { armorClass = 8, name = "maylar"};

            deend.Fight(deend, maylar);
        }
    }

}
