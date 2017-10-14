namespace DialSolver
{
    public class Dial
    {
        public int Value { get; set; }
        public int Answer { get; set; }
        public DialColours DialColour { get; private set; }
        private readonly int _minValue;
        private readonly int _maxValue;
        public int Moves { get; set; }

        public Dial(int startingValue, int answer, DialColours dialColour, int minValue, int maxValue)
        {
            Value = startingValue;
            Answer = answer;
            DialColour = dialColour;
            _minValue = minValue;
            _maxValue = maxValue;
            Moves = 0;
        }

        public bool IsCorrectValue() 
            => Value == Answer;

        public void IncrementValue() 
            => Value = Value == _maxValue ? Value = _minValue : ++Value;
    }
}
