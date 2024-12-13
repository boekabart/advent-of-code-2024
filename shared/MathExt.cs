namespace shared;

public static class MathExt
{
    public static int GGD(this int a, int b)
    {
        // Aannames: 
        // * a en b zijn ≥ 0 
        // * Als een van beide 0 is, geef het andere getal terug
        // * Beide 0 komt niet voor
        if (a == 0) return b;
        if (b == 0) return a;

        // Euclidisch algoritme
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
    public static long GGD(this long a, long b)
    {
        // Aannames: 
        // * a en b zijn ≥ 0 
        // * Als een van beide 0 is, geef het andere getal terug
        // * Beide 0 komt niet voor
        if (a == 0) return b;
        if (b == 0) return a;

        // Euclidisch algoritme
        while (b != 0)
        {
            long temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

}