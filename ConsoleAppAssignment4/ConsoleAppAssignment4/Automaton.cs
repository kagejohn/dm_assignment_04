using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignment4
{
    class Automaton
    {
        private readonly Alphabet _alphabet = new Alphabet();
        private readonly List<State> _states = new List<State>();
        private readonly State[,] _table;
        private readonly State _initialState;
  
        public Automaton()
        {
            _states.Add(_initialState = new State(0, false));
            for (int index = 1; index < 4; index++)
            {
                if (index == 3)
                {
                    _states.Add(new State(index, true));
                }
                else
                {
                    _states.Add(new State(index, false));
                }
            }
            _table = new State[_states.Count, _alphabet.Size()];
            // Actual automaton:
            _table[0, 0] = _states[1];

            _table[1, 1] = _states[1];
            _table[1, _alphabet.IndexOf('c')] = _states[2];
            _table[1, 4] = _states[3];

            _table[2, 3] = _states[1];
        }

        public void SetAlphabet(char[] charList) { _alphabet.Set(charList); }
        public Alphabet GetAlphabet() { return _alphabet; }

        public List<State> GetStates() { return _states; }

        public State GetInitialState() { return _initialState; }

        public State NextState(State state, char symbol)
        {
            return _table[state.GetIndex(), _alphabet.IndexOf(symbol)];
        }
    }
}
