namespace DesignPattern.Behavioral.Strategy.Simple
{
    public class MergeSortStrategy : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            MergeSort(list, 0, list.Count - 1);
        }

        public void MergeSort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(list, left, mid);
                MergeSort(list, mid + 1, right);
                Merge(list, left, mid, right);
            }
        }

        public void Merge(List<int> list, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArr[i] = list[left + i];
            }

            for(int j = 0; j < n2; j++)
            {
                rightArr[j] = list[mid + 1 + j];
            }

            int k = left;
            int p = 0;
            int q = 0;

            while (p < n1 && q < n2)
            {
                if (leftArr[p] <= rightArr[q])
                {
                    list[k] = leftArr[p];
                    p++;
                }
                else
                {
                    list[k] = rightArr[q];
                    q++;
                }
                k++;
            }

            while (p < n1)
            {
                list[k] = leftArr[p];
                p++;
                k++;
            }

            while (q < n2)
            {
                list[k] = rightArr[q];
                q++;
                k++;
            }
        }
    }
}
