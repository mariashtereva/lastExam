using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //the original list
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //inputs commands till the loop breaks
            while (true)
            {
                //the list in which commands are stored
                List<string> current = Console.ReadLine().Split(' ').ToList();

                //print: stops the program and prints the list
                if (current[0] == "print")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", input));
                    //after print the program ends
                    break;
                }
                //add<index><element>: adds an element at an index
                if (current[0] == "add")
                {
                    int index = int.Parse(current[1]);
                    int element = int.Parse(current[2]);
                    input.Insert(index, element);
                }

                //addMany<index><element1><element2>...<elementn>: adds many elements at an index
                if (current[0] == "addMany")
                {
                    int index = int.Parse(current[1]);
                    //backwards for loop
                    //adds all the elements till they end
                    for (int i = current.Count - 1; i >= 2 ; i--)
                    {
                        input.Insert(index, int.Parse(current[i]));
                    }
                    
                }

                //contains<element>: prints the index of the first searched element
                if (current[0] == "contains")
                {
                    int searchedNumber = int.Parse(current[1]);
                    //if they is such a number, it prints the index (position) of the searched number
                    if(input.Contains(searchedNumber) == true)
                    {
                        Console.WriteLine(input.IndexOf(searchedNumber));
                    }
                    //if there isn't, it prints -1
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }

                //remove<index>: removes an element at an index
                if (current[0] == "remove")
                {
                    int removedIndex = int.Parse(current[1]);
                    input.RemoveAt(removedIndex);
                }


                //shift<positions>: rotates the list by a number of positions
                if(current[0] == "shift")
                {
                    //the number of times the list should be rotated is current[1]
                    for (int p = 0; p < int.Parse(current[1]); p++)
                    {
                        //every rotation of the list:
                        var temp = input[0];
                        for (var i = 0; i < input.Count - 1; i++)
                        {
                            input[i] = input[i + 1];
                        }
                        input[input.Count - 1] = temp;
                    }
                    
                }

                //sumPairs
                if(current[0] == "sumPairs")
                {
                    //temporary list
                    List<int> sumPairsList = new List<int>();

                    for (int i = 0; i < input.Count - 1; i++)
                    {
                        int sum = 0;
                        //sums every two elements
                        if (i % 2 == 0)
                        {
                            //sums the elements
                            sum = sum + input[i] + input[i + 1];
                            //adds them to the new list
                            sumPairsList.Add(sum);
                                
                        }

                    }
                    //turns the temporary list sumPairsList into the original list 
                    input = sumPairsList;
                }
            }
            


        }
    }
}
