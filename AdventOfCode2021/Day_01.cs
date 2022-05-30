using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2021
{
    class Day_01
    {
        public int Part1()
        {
            IList<int> values = ReadInput();

            int count = 0;
            for(int i = 1; i < values.Count; i++)
            {
                if(values[i] > values[i-1])
                {
                    count++;
                }
            }

            return count;
        }

        public int Part2()
        {
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

            return count;
        }

        private IList<int> ReadInput()
        {
            IList<int> values = new List<int>();
            foreach (string line in File.ReadLines(@"..\..\..\input\Day_01.txt"))
            {
                values.Add(Int32.Parse(line));
            }

            return values;
        }
    }
}
