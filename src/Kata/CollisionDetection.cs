using System;

namespace Kata
{
    public struct Point2
    {
        public float X;
        public float Y;

        public Point2(float pX, float pY)
        {
            this.X = pX;
            this.Y = pY;
        }

        public static Point2 operator -(Point2 p1, Point2 p2)
        {
            return new Point2(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point2 operator +(Point2 p1, Point2 p2)
        {
            return new Point2(p1.X + p2.X, p1.Y + p2.Y);
        }
    }

    public class Rectangle2
    {
        public float Rotation;
        public float WidthX;
        public float WidthY;
        public Point2 Position;

        public Rectangle2(float pR, float pWX, float pWY, Point2 pP)
        {
            this.Rotation = pR;
            this.WidthX = pWX;
            this.WidthY = pWY;
            this.Position = pP;
        }
    }

    public static class Rectangle2Extensions
    {
        public static bool HasCollided(this Rectangle2 rect, Point2 point)
        {
            point -= rect.Position;
            point = point.RotateAboutOrigin(rect.Rotation);
            point.X *= 2.0f;
            point.Y *= 2.0f;

            return -rect.WidthX < point.X && point.X < rect.WidthX &&
                   -rect.WidthY < point.Y && point.Y < rect.WidthY;
        }

        private static Point2 RotateAboutOrigin(this Point2 point, float angle)
        {
            (float sin, float cos) = SinCos(angle);
            return new Point2(point.X * cos - point.Y * sin, point.X * sin + point.Y * cos);
        }

        private static (float, float) SinCos(float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sqrt(1.0 - cos * cos);
            angle %= 2.0f * (float)Math.PI;
            if (angle > (float)Math.PI) sin = -sin;
            return (sin, cos);
        }
    }
}