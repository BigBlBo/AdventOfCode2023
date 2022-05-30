using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2021
{
    class Day_03
    {
        public int Part1()
        {
            IList<char[]> values = ReadInput();
            int lenSeq = values[0].Length;
            int[] ones = new int[lenSeq];
            int[] zeros = new int[lenSeq];

            for(int i = 0; i < lenSeq; i++)
            {
                ones[i] = 0;
            }

            for (int i = 0; i < lenSeq; i++)
            {
                zeros[i] = 0;
            }

            foreach (char[] seqence in values)
            {
                for(int i = 0;i < lenSeq; i++)
                {
                    if(seqence[i] == '1')
                    {
                        ones[i]++;
                    }
                    else
                    {
                        zeros[i]++;
                    }
                }
            }

            int commonNumber = 0;
            int uncommonNumber = 0;

            for (int i = 0; i < lenSeq; i++)
            {
                if(ones[i] > zeros[i])
                {
                    commonNumber = commonNumber + (int)Math.Pow(2, lenSeq - 1 - i);
                }
                else
                {
                    uncommonNumber = uncommonNumber + (int)Math.Pow(2, lenSeq - 1 - i);
                }
            }

            return commonNumber * uncommonNumber;
        }

        public int Part2()
        {
            IList<char[]> values = ReadInput();
            int lenSeq = values[0].Length;
            int ones = 0;
            int zeros = 0;

            for (int i = 0; i < lenSeq; i++)
            {
                ones = 0; zeros = 0;
                for (int j = 0; j < values.Count; j++)
                {
                    if (values[j][i] == '1')
                    {
                        ones++;
                    }
                    else
                    {
                        zeros++;
                    }
                }

                IList<char[]> valuesCopy = new List<char[]>();
                for (int j = 0; j < values.Count; j++)
                {
                    if (ones >= zeros && values[j][i] == '1')
                    {
                        valuesCopy.Add(values[j]);
                    }
                    else if(ones < zeros && values[j][i] == '0')
                    {
                        valuesCopy.Add(values[j]);
                    }
                }

                values = valuesCopy;

                if (values.Count == 1)
                    break;
            }

            int OxNumber = 0;
            int CONumber = 0;
            
            for (int i = 0; i < lenSeq; i++)
            {
                if(values[0][i] == '1')
                OxNumber = OxNumber + (int)Math.Pow(2, lenSeq - 1 - i);
            }

            values = ReadInput();

            for (int i = 0; i < lenSeq; i++)
            {
                ones = 0; zeros = 0;
                for (int j = 0; j < values.Count; j++)
                {
                    if (values[j][i] == '1')
                    {
                        ones++;
                    }
                    else
                    {
                        zeros++;
                    }
                }

                IList<char[]> valuesCopy = new List<char[]>();
                for (int j = 0; j < values.Count; j++)
                {
                    if (ones >= zeros && values[j][i] == '0')
                    {
                        valuesCopy.Add(values[j]);
                    }
                    else if (ones < zeros && values[j][i] == '1')
                    {
                        valuesCopy.Add(values[j]);
                    }
                }

                values = valuesCopy;

                if (values.Count == 1)
                    break;
            }

            for (int i = 0; i < lenSeq; i++)
            {
                if (values[0][i] == '1')
                    CONumber = CONumber + (int)Math.Pow(2, lenSeq - 1 - i);
            }

            return OxNumber * CONumber;
        }

        private IList<char[]> ReadInput()
        {
            IList<char[]> values = new List<char[]>();
            foreach (string line in File.ReadLines(@"..\..\..\input\Day_03.txt"))
            {
                char[] parts = line.ToCharArray();
                values.Add(parts);
            }

            return values;
        }
    }
}
