using System;

namespace Subgurim.Maps.Helpers
{
    [Serializable]
    public abstract class StringEnum : Object
    {
        protected readonly string _name;
        protected readonly int _value;

        protected StringEnum(int value, string name)
        {
            _name = name;
            _value = value;
        }

        public override string ToString()
        {
            return _name;
        }

        public static implicit operator string(StringEnum x)
        {
            return x._name;
        }

        public static implicit operator int(StringEnum x)
        {
            return x._value;
        }

        public static bool operator ==(StringEnum x, StringEnum y)
        {
            if (((object)x == null) || ((object)y == null))
            {
                return false;
            }

            if (ReferenceEquals(x, y))
            {
                return true;
            }

            return (x._value == y._value);
        }

        public static bool operator !=(StringEnum x, StringEnum y)
        {
            return !(x._value == y._value);
        }

        public override bool Equals(object obj)
        {
            StringEnum p = obj as StringEnum;

            if ((object)p == null)
            {
                return false;
            }

            return (_value == p._value);
        }

        public bool Equals(StringEnum flag)
        {
            return (_value == flag._value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}