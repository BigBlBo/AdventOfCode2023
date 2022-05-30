using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2021
{
    class Day_02
    {
        public int Part1()
        {
            IList<InputValues> values = ReadInput();

            int down = 0;
            int forward = 0;
            foreach (InputValues inputValues in values)
            {
                if (inputValues.direction == "forward")
                {
                    forward += inputValues.value;
                    continue;
                }

                if (inputValues.direction == "down")
                {
                    down += inputValues.value;
                }
                else if (inputValues.direction == "up")
                {
                    down -= inputValues.value;
                }
            }

            return down * forward;
        }

        public int Part2()
        {
            IList<InputValues> values = ReadInput();

            int aim = 0;
            int depth = 0;
            int forward = 0;
            foreach (InputValues inputValues in values)
            {
                if (inputValues.direction == "forward")
                {
                    forward += inputValues.value;
                    depth += aim * inputValues.value;
                    continue;
                }

                if (inputValues.direction == "down")
                {
                    aim += inputValues.value;
                }
                else if (inputValues.direction == "up")
                {
                    aim -= inputValues.value;
                }
            }

            return depth * forward;
        }

        private IList<InputValues> ReadInput()
        {
            IList<InputValues> values = new List<InputValues>();
            foreach (string line in File.ReadLines(@"..\..\..\input\Day_02.txt"))
            {
                string[] parts = line.Split(" ");
                values.Add(new InputValues { direction = parts[0], value = Int32.Parse(parts[1])} );
            }

            return values;
        }
    }

    class InputValues
    {
        public string direction { get; set; }
        public int value { get; set; }
    }
}
