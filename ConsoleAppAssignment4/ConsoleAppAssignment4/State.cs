using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignment4
{
    class State
    {
        private readonly int _index;
        private readonly bool _isFinal;
  
        public State(int index, bool isFinal)
        {
            _index = index;
            _isFinal = isFinal;
        }

        public int GetIndex()
        {
            return _index;
        }

        public bool IsFinal()
        {
            return _isFinal;
        }
    }
}
