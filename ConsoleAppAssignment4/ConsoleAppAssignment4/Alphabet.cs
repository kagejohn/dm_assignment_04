using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppAssignment4
{
    class Alphabet
    {
        private char[] _alphabet;

        public void Set(char[] alphabet)
        {
            _alphabet = alphabet;
        }
        public int IndexOf(char symbol)
        {
            if (!_alphabet.Contains(symbol))
            {
                throw new ArgumentOutOfRangeException();
            }

            return symbol - 'a';
        }

        public char SymbolOf(int index)
        {
            if (_alphabet.Length - 1 < index)
            {
                throw new ArgumentOutOfRangeException();
            }

            return (char)('a' + index);
        }

        public int Size() { return _alphabet.Length; }
    }
}
