using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class ComparableObject : IComparable
    {
        public static bool operator ==(ComparableObject c, object o)
        {
            if ((object)c == null || (object)o == null)
                return (object)c == (object)o;
            else
                return c.Compare(o) == 0;
        }

        public static bool operator !=(ComparableObject c, object o)
        {
            if ((object)c == null || (object)o == null)
                return (object)c != (object)o;
            else
                return c.Compare(o) != 0;
        }

        public static bool operator <(ComparableObject c, object o)
        {
                return c.Compare(o) < 0;
        }

        public static bool operator >(ComparableObject c, object o)
        {
            return c.Compare(o) > 0;
        }

        public static bool operator <=(ComparableObject c, object o)
        {
            return c.Compare(o) <= 0;
        }

        public static bool operator >=(ComparableObject c, object o)
        {
            return c.Compare(o) >= 0;
        }
        
        public abstract int CompareTo(Object obj);

        private int Compare(object obj)
        {
            if (GetType() == obj.GetType())
                return CompareTo(obj);
            else
                return GetType().FullName.CompareTo(
                    obj.GetType().FullName);
        }

        public override bool Equals(object obj)
        {
            return Compare(obj) == 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
