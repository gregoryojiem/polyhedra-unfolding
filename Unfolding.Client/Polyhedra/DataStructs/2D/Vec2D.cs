﻿namespace Unfolding.Client.Polyhedra.DataStructs
{
    public class Vec2D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Magnitude
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public Vec2D(double x, double y) { X = x; Y = y; }

        public Vec2D(Point2D point) { X = point.X; Y = point.Y; }

        public static Vec2D operator +(Vec2D vec1, Vec2D vec2)
        {
            return new(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }

        public static Vec2D operator -(Vec2D vec1, Vec2D vec2)
        {
            return new(vec1.X - vec2.X, vec1.Y - vec2.Y);
        }

        public double Dot(Vec2D vec)
        {
            return (X * vec.X) + (Y * vec.Y);
        }
    }
}
