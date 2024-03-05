namespace algorithms.console.Search
{
    public abstract class BaseSearchImplementation
    {
        public int[] Items { get; set; }
        public int Item { get; set; }

        protected BaseSearchImplementation(int[] items, int item) 
        {
            Items = items;
            Item = item;
        }
    }
}
