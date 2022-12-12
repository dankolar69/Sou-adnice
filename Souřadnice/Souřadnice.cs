using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souřadnice
{
    internal class Coordinates : IEquatable<Coordinates>, IComparable<Coordinates>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Coordinates other)
        {
            if (other == null) return false;
            return (X == other.X && Y == other.Y);
        }

        public int CompareTo(Coordinates other)
        {
            if (other == null)
            {
                return 1;
            }

            if (X != other.X)
            {
                return X.CompareTo(other.X);
            }
            else
            {
                return Y.CompareTo(other.Y);
            }
        }

        public static Coordinates operator +(Coordinates c1, Coordinates c2)
        {
            return new Coordinates(c1.X + c2.X, c1.Y + c2.Y);
        }


    }
}