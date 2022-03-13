using System.Linq;

namespace CSharp_Level2.Helpers
{
    public static class Extensions
    {
        //https://www.youtube.com/watch?v=mi4tVniBPbk
        public static int[] Bubble_Sort(int[] array)
        {
            bool isLoop = true;
            while (isLoop)
            {
                isLoop = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int first = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = first;
                        isLoop = true;
                    }
                }
            }
            return array;
        }

        //https://www.youtube.com/watch?v=cHOycxTvEm0
        public static int[] Selection_Sort(int[] array)
        {
            int item = 0;
            while (item < array.Length)
            {
                int minIndex = item;

                for (int i = item; i < array.Length; i++)
                {
                    if (array[item] > array[i])
                        if (array[i] < array[minIndex])
                            minIndex = i;
                }

                int first = array[item];
                array[item] = array[minIndex];
                array[minIndex] = first;
                item += 1;
            }
            return array;
        }

        //https://www.youtube.com/watch?v=jvroKFOdF5Y
        public static int[] Insertion_Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                while (i > 0 && array[i - 1] > array[i])
                {
                    int first = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = first;
                    i -= 1;
                }
            }
            return array;
        }




        //https://www.youtube.com/watch?v=EunSmHT1mVI
        public static int[] Marge_Sort(int[] array)
        {
            if (array.Length == 1)
                return array;

            int dev = array.Length / 2;

            int[] array1 = Marge_Sort(array[0..dev]);
            int[] array2 = Marge_Sort(array[dev..array.Length]);
            return MargeAndSort(array1, array2);
        }

        public static int[] MargeAndSort(int[] array1, int[] array2)
        {
            int[] array = new int[array1.Length + array2.Length];
            int i = 0;
            int j = 0;
            int index = 0;
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    array[index] = array1[i];
                    index++;
                    i++;
                }
                else
                {
                    array[index] = array2[j];
                    index++;
                    j++;
                }
            }

            while (i < array1.Length)
            {
                array[index] = array1[i];
                index++;
                i++;
            }

            while (j < array2.Length)
            {
                array[index] = array2[j];
                index++;
                j++;
            }

            return array;
        }
    }
}
