using System;

namespace VectorComparison 
{
    

    public class Cursor
    {
        public Coordinate Position { get; private set; } = new Coordinate(0, 0);

        public void Move(Coordinate CoordinateArgument) {
            if (CoordinateArgument.IsRelative) {
                this.Position += CoordinateArgument;
            } else {
                this.Position = CoordinateArgument;
            }
        }

        public void CurveTo(Coordinate SharedControlPoint, Coordinate EndPoint) // Quadratic curve overload, in which the control points for each end are the same 
        {
            // todo: make this work
        }

        public void CurveTo(Coordinate ControlPoint1, Coordinate ControlPoint2, Coordinate EndPoint) // Cubic overload (where there's 2 ctrl points)
        {
            
        }

        // I may also need to implement chains of smooth bezier curves, though I doubt it.
        // Look for T and S instructions
    }

    public struct Coordinate
    {
        public double X;
        public double Y;

        public bool IsRelative { get; set; }

        public Coordinate(double X, double Y, bool IsRelative=false)
        {
            this.X = X;
            this.Y = Y;
            this.IsRelative = IsRelative;
        }

        public static Coordinate operator -(Coordinate P1, Coordinate P2)
        {
            return new Coordinate(P1.X - P2.X, P1.Y - P2.Y);
        }

        public static Coordinate operator +(Coordinate P1, Coordinate P2)
        {
            return new Coordinate(P1.X + P2.X, P1.Y + P2.Y);
        }
    }

    public struct Curve
    {
        public Coordinate End;

        public Coordinate ControlPoint1;
        public Coordinate ControlPoint2;

        public double ArcLength {
            get {
                // I have no flipping clue
                return 4;
            }
        }

        public Curve(Coordinate End, Coordinate SharedControlPoint)
        {
            this.End = End;
            this.ControlPoint1 = SharedControlPoint;
            this.ControlPoint2 = SharedControlPoint;
        }
    }
}