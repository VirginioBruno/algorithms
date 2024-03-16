namespace algorithms.console.Sort;

public static class Sort
{
    public static void DoBubbleSort() 
    {
        var items = Helper.GenerateIntArray(1, 20, 20);
    
        Console.WriteLine($"Executing {nameof(Sort)} - {nameof(DoBubbleSort)} Sorting elements ({Helper.ShowElements(items)})");
        var bubbleSort = new BubbleSortImplementation(items);

        var result = AlgorithmExecutor.Execute(bubbleSort);

        Console.WriteLine($"Executed {nameof(Sort)} - {nameof(DoBubbleSort)} - {Helper.ShowElements(items)}");
    }

    public static void DoSelectionSort() 
    {
        var items = Helper.GenerateIntArray(1, 20, 20);
    
        Console.WriteLine($"Executing {nameof(Sort)} - {nameof(DoSelectionSort)} Sorting elements ({Helper.ShowElements(items)})");
        var selectionSort = new SelectionSortImplementation(items);

        var result = AlgorithmExecutor.Execute(selectionSort);

        Console.WriteLine($"Executed {nameof(Sort)} - {nameof(DoSelectionSort)} - {Helper.ShowElements(items)}");
    }
}