namespace LeetCode.Problems.Status_Medium.L_0380_InsertDeleteGetRandom
{
    public class L_0380_InsertDeleteGetRandom
    {
        private Dictionary<int, int> numberToPos;
        private List<int> numbers;

        private Random random;

        public L_0380_InsertDeleteGetRandom()
        {
            numberToPos = new Dictionary<int, int>();
            numbers = new List<int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (numberToPos.ContainsKey(val))
            {
                return false;
            }

            numberToPos[val] = numbers.Count;
            numbers.Add(val);

            return true;
        }

        public bool Remove(int val)
        {
            if (!numberToPos.ContainsKey(val))
            {
                return false;
            }

            var index = numberToPos[val];
            var lasVal = numbers[^1];
            numberToPos[lasVal] = index;
            numbers[index] = lasVal;

            numbers.RemoveAt(numbers.Count - 1);
            numberToPos.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            return numbers[random.Next(numbers.Count)];
        }
    }
}