namespace DesignPattern.Behavioral.Strategy.Simple
{
    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            QuickSort(list, 0, list.Count - 1);
        }

        private void QuickSort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(list, left, right);

                QuickSort(list, left, pivotIndex - 1);
                QuickSort(list, pivotIndex + 1, right);
            }
        }

        private int Partition(List<int> list, int left, int right)
        {
            int pivot = list[right]; // pick last element as a pivot 
            int i = left - 1; 

            for(int j = left; j < right; j++)
            {
                if (list[j] <= pivot)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, right);

            return i + 1; 
        }

        private static void Swap(List<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }

}
