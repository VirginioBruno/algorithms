namespace algorithms.console.Search.Linear
{
    public class LinearSearchImplementation : BaseSearchImplementation, IAlgorithmImplementation
    {
        public LinearSearchImplementation(int[] items, int item) : base(items, item)
        {
        }

        public int Execute()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Item == Items[i])
                    return i;
            }

            return -1;
        }
    }
}
