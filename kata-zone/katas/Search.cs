namespace kata_zone.katas
{
    public class Search
    {
        public bool linearSearch( int[] haystack, int needle )
        {
            bool flag = false;
            foreach ( int i in haystack )
            {
                if ( i == needle )
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool binarySearch( int[] haystack, int needle )
        {


            return false;
        }
    }
}
