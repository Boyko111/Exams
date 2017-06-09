namespace _03.LadyBuds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int sizeField = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            var positions = input.Split(' ')
               .Select(int.Parse)
               .ToArray();

            var field = new int[sizeField];

            foreach (var pos in positions)
            {
                if (pos < 0 || pos >= sizeField)
                {
                    continue;
                }
                field[pos] = 1;
            }

            ///////////////////////////////////
            while (true)
            {
                var comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }

                var comandPart = comand.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                int currentIndex = int.Parse(comandPart[0]);
                string direction = comandPart[1];
                var pointIndex = int.Parse(comandPart[2]);

                if (currentIndex < 0 || currentIndex >= sizeField)
                {
                    continue;
                }
                if (field[currentIndex] == 0)
                {
                    continue;
                }

                var position = currentIndex;
                field[position] = 0;
                while (true)
                {

                    if (direction == "right")
                    {
                        position += pointIndex;
                    }
                    else
                    {
                        position -= pointIndex;
                    }
                    if (position < 0 || position >= sizeField)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }


            }
            Console.WriteLine(string.Join(" ", field));


        }
    }
}
