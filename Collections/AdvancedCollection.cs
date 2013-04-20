using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
using Subgurim.Maps.Core.Helpers;

namespace Subgurim.Maps.Core.Collections
{
    public class AdvancedCollection
    {
        private readonly string startOfCollection;

        private readonly string endOfCollection;

        private readonly string nameValuesSeparator;

        private readonly string nameValueSeparator;

        private readonly string startOfNameValue = string.Empty;

        private readonly string endOfNameValue = string.Empty;

        ///// <summary>
        ///// Creates a new AdvancedCollection with default options
        ///// </summary>
        public AdvancedCollection()
            : this(string.Empty, string.Empty, string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Creates a new instance of AdvancedCollection with the specified options
        /// </summary>
        /// <param name="nameValuesSeparator">String that delimits each element of the collection</param>
        /// <param name="nameValueSeparator">String that divides each key from its value</param>
        public AdvancedCollection(string nameValuesSeparator, string nameValueSeparator) 
            : this(string.Empty, string.Empty, nameValuesSeparator, nameValueSeparator)
        {
        }

        /// <summary>
        /// Creates a new instance of AdvancedCollection with the specified options
        /// </summary>
        /// <param name="startOfCollection">String to be prepended at the begining of the collection</param>
        /// <param name="endOfCollection">String to be appended at the end of the collection</param>
        /// <param name="nameValuesSeparator">String that delimits each element of the collection</param>
        /// <param name="nameValueSeparator">String that divides each key from its value</param>
        public AdvancedCollection(string startOfCollection, string endOfCollection, string nameValuesSeparator, string nameValueSeparator)
        {
            this.startOfCollection = startOfCollection;
            this.endOfCollection = endOfCollection;
            this.nameValuesSeparator = nameValuesSeparator;
            this.nameValueSeparator = nameValueSeparator;
        }

        #region Properties

        private NameValueCollection nameValueCollection = new NameValueCollection();
        public NameValueCollection NameValueCollection
        {
            get { return nameValueCollection; }
            set { nameValueCollection = value; }
        }

        private StringCollection stringCollection = new StringCollection();
        public StringCollection StringCollection
        {
            get { return stringCollection; }
            set { stringCollection = value; }
        }


        public bool HasElements
        {
            get
            {
                return (NameValueCollection.Count > 0) || (StringCollection.Count > 0);
            }
        }

        #endregion

        #region Methods

        #region Add
        #region NameValueCollection
        public void Add(object key, object value, Type type)
        {
            if ((value == null) || (key == null)) return;

            ManageValue(ref value, type);

            if (!string.IsNullOrEmpty(value.ToString()) && !string.IsNullOrEmpty(key.ToString()))
                NameValueCollection.Add(key.ToString(), value.ToString());
        }

        public void Add(object key, object value, bool condition, Type type)
        {
            if (condition) Add(key, value, type);
        }

        public void Add<T>(object key, object value)
        {
            Add(key, value, typeof(T));
        }

        public void Add<T>(object key, object value, bool condition)
        {
            if (condition) Add(key, value, typeof(T));
        }

        public void Add(object key, object value)
        {
            Add(key, value, null);
        }

        public void Add(object key, object value, bool condition)
        {
            if (condition) Add(key, value);
        }

        public void AddIfValue(object key, object value)
        {
            if (value != null)
            {
                Add(key, value);
            }
        }

        public void AddIfValue(object key, object value, Type type)
        {
            if (value != null)
            {
                Add(key, value, type);
            }
        }

        #endregion

        #region StringCollection
        public void Add(object value, Type type)
        {
            if (value==null) return;

            ManageValue(ref value, type);

            if (!string.IsNullOrEmpty(value.ToString()))
                StringCollection.Add(value.ToString());
        }

        public void Add(object value, bool condition, Type type)
        {
            if (condition) Add(value, type);
        }

        public void Add(object value)
        {
            Add(value, typeof(object));
        }

        public void Add(object value, bool condition)
        {
            if (condition) Add(value);
        } 
        #endregion

        #region Helpers
        private static void ManageValue(ref object value, Type type)
        {
            if (type == typeof(string))
                value = string.Format("'{0}'", value);
            if (type == typeof(bool))
                value = value.ToString().ToLower();
            if (type == typeof(double))
                value = ((double)value).ToString(MapHelper.UsCulture);
        }
        #endregion
        #endregion

        #region Fill
        public void Fill(IEnumerable items)
        {
            foreach (object item in items)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Gets an string and converts it to an AdvancedCollection
        /// </summary>
        /// <param name="source"></param>
        public void FillFromString(string source)
        {
            if (!string.IsNullOrEmpty(startOfCollection) && source.IndexOf(startOfCollection) == 0)
            {
                source = source.Substring(startOfCollection.Length);
            }

            string[] keyValueArray = source.Split(new string[] { nameValuesSeparator }, StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < keyValueArray.Length; i++)
            {
                string[] keyValue = keyValueArray[i].Split(new string[] { nameValueSeparator }, StringSplitOptions.RemoveEmptyEntries);

                if (keyValue.Length == 2)
                    Add(keyValue[0], keyValue[1]);
                else
                    Add(keyValue[0]);
            }
        } 
        #endregion

        #region ToString
        public override string ToString()
        {
            if (!HasElements) return string.Empty;

            StringBuilder sb = new StringBuilder();

            sb.Append(startOfCollection);
            
            for (int i = 0; i < NameValueCollection.Count; i++)
            {
                sb.AppendFormat("{0}{1}{2}{3}{4}", startOfNameValue, NameValueCollection.GetKey(i), nameValueSeparator, NameValueCollection[i], endOfNameValue);

                if (i < NameValueCollection.Count - 1)
                {
                    sb.Append(nameValuesSeparator);
                }
            }

            for (int i = 0; i < StringCollection.Count; i++)
            {
                sb.AppendFormat("{0}{1}{2}{3}", startOfNameValue, nameValueSeparator, StringCollection[i], endOfNameValue);

                if (i < StringCollection.Count - 1)
                {
                    sb.Append(nameValuesSeparator);
                }
            }

            sb.Append(endOfCollection);

            return sb.ToString();
        } 
        #endregion
        #endregion
    }
}
