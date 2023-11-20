namespace Models
{
    public class NumberAnaliser
    {
        public delegate void AnalizerHandler(string message);
        public event AnalizerHandler Notify;
        public NumberAnaliser(int maxPercent, int num)
        {
            MaxPercent = maxPercent;
            Number = num;
            NumberToCompare = (int)(Number + Number * MaxPercent / 100);
        }
        public int MaxPercent { get; private set; }
        public int Number { get; private set; }
        public int NumberToCompare { get; private set; }
        public void AnalizeNumber(int num)
        {
            if (num > NumberToCompare)
                Notify?.Invoke($"{num} is greater more than {MaxPercent} percent from the compaired number({Number})");
            else return;
        }
    }
}
