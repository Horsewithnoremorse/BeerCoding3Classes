using System;

namespace SomeCovidShiit
{
    class Program
    {
        //кароч тема такая, описать дома всю мебель и технику в виде классов

        static void Main(string[] args)
        {
            
            Table cookingTable = new Table();
            cookingTable.height = 90;
            cookingTable.lenght = 120;
            cookingTable.widght = 80;

            Console.WriteLine(cookingTable.widght);

        }
    }
}
