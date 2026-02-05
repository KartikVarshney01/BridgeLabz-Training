public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates.Length <= 2)
            return true;

        int x0 = coordinates[0][0];
        int y0 = coordinates[0][1];
        int x1 = coordinates[1][0];
        int y1 = coordinates[1][1];

        int dx = x1 - x0;
        int dy = y1 - y0;

        for (int i = 2; i < coordinates.Length; i++)
        {
            int xi = coordinates[i][0];
            int yi = coordinates[i][1];
            
            if ((xi - x0) * dy != (yi - y0) * dx)
                return false;
        }

        return true;
    }
}