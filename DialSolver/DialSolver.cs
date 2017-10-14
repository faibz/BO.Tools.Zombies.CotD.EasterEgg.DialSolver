using System;
using System.Linq;

namespace DialSolver
{
    public class DialSolver
    {
        private readonly Random _rand = new Random();
        private readonly Dial[] _dials;
        private int _tries;

        public DialSolver(Dial[] dials)
        {
            _dials = dials;
        }

        public void SetDialValues(int[] dialValues)
        {
            for (var i = 0; i < dialValues.Length; ++i)
            {
                _dials[i].Value = dialValues[i];
            }
        }

        private bool CheckAnswer() 
            => _dials.All(dial => dial.IsCorrectValue());

        private int SelectRandomDialIndex()
            => _rand.Next(0, _dials.Length);

        private void MoveDial(int index)
        {
            _dials[index].IncrementValue();
            ++_dials[index].Moves;

            if (index + 1 < _dials.Length) _dials[index + 1].IncrementValue();
            if (index - 1 >= 0) _dials[index - 1].IncrementValue();

            ++_tries;
        }

        public void Solve()
        {
            if (CheckAnswer()) return;

            do
            {
                MoveDial(SelectRandomDialIndex());
            } while (!CheckAnswer());

            PrintStats();
            PrintInstructions();
        }

        private void PrintInstructions()
        {
            foreach (var dial in _dials)
            {
                Console.WriteLine("Move the " + dial.DialColour + " dial " + dial.Moves % 10 + " times.");
            }
        }

        private void PrintStats() 
            => Console.WriteLine("Solved.\nThis solve took " + _tries + " moves to complete.");
    }
}