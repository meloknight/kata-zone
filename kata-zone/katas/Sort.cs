namespace kata_zone.katas
{
    public class Sort
    {
        public int[] bubbleSort( int[] Arr )
        {
            for ( int i = 0; i < Arr.Length - 1; i++ )
            {
                for ( int j = 0; j < Arr.Length - 1 - i; j++ )
                {
                    if ( Arr[j] > Arr[j + 1] )
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
            return Arr;
        }

        public int[] quickSort( int[] Arr )
        {
            return [1, 2];
        }
    }
}