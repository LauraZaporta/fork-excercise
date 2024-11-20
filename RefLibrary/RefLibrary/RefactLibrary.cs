namespace RefactLibrary
{
    public class Refact
    {
        public static bool ValidateInRange(int num, int min, int max)
        {
            return (num <= max) && (num >= min);
        }

        public static int ProductArrayContent(int[] array)
        {
            int productAllNumbers = 1;
            for (int i = 0; i < array.Length; i++)
            {
                productAllNumbers *= array[i];
            }
            return productAllNumbers;
        }
    }
}