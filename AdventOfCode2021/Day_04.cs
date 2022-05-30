using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2021
{
    class Day_04
    {
        public int Part1()
        {
            Bingo bingo = ReadInput();


            return 0;
        }

        public int Part2()
        {
            /*
            IList<int> values = ReadInput();

            int prevSum = values[0] + values[1] + values[2];
            int prevValue = values[0];
            int count = 0;
            for (int i = 3; i < values.Count; i++)
            {

                if (prevSum < prevSum - prevValue + values[i])
                {
                    count++;
                }

                prevSum = prevSum - prevValue + values[i];
                prevValue = values[i - 2];
            }

            return count;*/
            return 0;
        }

        private void CheckBingo()
        {

        }

        private Bingo ReadInput()
        {
            Bingo bingo = new Bingo();

            IList<string> lines = new List<string>();
            foreach (string line in File.ReadLines(@"..\..\..\input\Day_04.txt"))
            {
                lines.Add(line);
            }

            string[] firstLine = lines[0].Split(",");
            foreach(string str in firstLine)
            {
                bingo.numbers.Add(Int32.Parse(str));
            }

            lines.RemoveAt(0); lines.RemoveAt(0);

            Tuple<int, bool>[][] card = new Tuple<int, bool>[5][];
            int index = 0;
            foreach (string line in lines)
            {
                if(line == "")
                {
                    bingo.cards.Add( card);
                    card = new Tuple<int, bool>[5][];
                    index = 0;
                    continue;
                }

                card[index] = new Tuple<int, bool>[5];
                string[] cardLine = line.Split(" ");

                int numberIndex = 0;
                for (int i = 0; i < cardLine.Length; i++)
                {
                    if(cardLine[i] == "")
                    {
                        continue;
                    }
                    card[index][numberIndex] = Tuple.Create<int, bool>(Int32.Parse(cardLine[i]), false);
                    numberIndex++;
                }
                index++;
            }
            bingo.cards.Add(card);

            return bingo;
        }
    }

    class Bingo
    {
        public IList<int> numbers { get; set; }
        public IList<Tuple<int, bool>[][]> cards { get; set; }

        public Bingo()
        {
            numbers = new List<int>();
            cards = new List<Tuple<int, bool>[][]>();
        }
    }
}
