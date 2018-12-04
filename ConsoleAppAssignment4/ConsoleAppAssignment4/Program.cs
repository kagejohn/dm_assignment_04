using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Automaton automaton = new Automaton();

            string alphabetReadLine = "";

            while (string.IsNullOrEmpty(alphabetReadLine))
            {
                Console.Write("Input action list in form of letters: ");
                alphabetReadLine = Console.ReadLine();
                automaton.SetAlphabet(alphabetReadLine.ToCharArray());
            }

            string word = automaton.GetAlphabet().ToString();
            State state = automaton.GetInitialState();
            Console.WriteLine("state" + state.GetIndex());

            foreach (char symbol in word.ToCharArray())
            {
                if (state == null)
                {
                    Console.WriteLine(word + " does not match");
                }

                state = automaton.NextState(state, symbol);
                Console.WriteLine("state" + state.GetIndex());
            }
            if (state == null)
            {
                Console.WriteLine(word + " does not match");
            }
            else if (state.IsFinal())
            {
                Console.WriteLine("You had a match");
            }
            else
            {
                Console.WriteLine("Partially match");
            }
        }
    }
}
