using System;

namespace VectorComparison 
{
    public static class Settings 
    {
        public static double CurveInterpolation = 1; 
        // Based on the the length of control lines on a curve
        // how many pixels of arc length to wait between comparing cursor positions on a curve.
        // this / sum of control dist = interval
        // Lower = more accurate matching of curves, but slower.
    }

    public static class Utils 
    {
        public static double AbsCursorDist(Cursor C1, Cursor C2)
        {
            Coordinate Distance = C1.Position - C2.Position;
            return Math.Sqrt(Math.Pow(Distance.X, 2) + Math.Pow(Distance.Y, 2));
        }
    }
}