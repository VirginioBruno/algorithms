namespace algorithms.console.Insertion;

public class InsertionAtPositionImplementation(int[] items, int item, int index) : AlgorithmImplementationBase(items, item, index)
{
    public override int Execute()
    {
        var result = new int[Items.Length + 1];
        var index = 0;

        if (Index == 0) 
        {
            var insertionAtStart = new InsertionAtStartImplementation(Items, item);
            insertionAtStart.Execute();
            Items = insertionAtStart.Items;
            return 1;
        }

        if (Index == Items.Length + 1)
        {
            var insertionAtEnd = new InsertionAtEndImplementation(Items, item);
            insertionAtEnd.Execute();
            Items = insertionAtEnd.Items;
            return 1;
        }   

        for (int i = 0; i < Items.Length; i++)
        {
            if (index == Index) 
            {
                result[index] = Item;
                index++;
            }

            result[index] = Items[i];
            index++;
        }

        Items = result;

        return 1;
    }
}