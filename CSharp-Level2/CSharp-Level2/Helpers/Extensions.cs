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

        https://www.youtube.com/watch?v=cHOycxTvEm0
    }
}
