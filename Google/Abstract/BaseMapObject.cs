using System;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google.Abstract
{
    [Serializable]
    internal abstract class BaseMapObject
    {
        private string _id;
        private string _map;

        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                {
                    _id = this.GetType().Name.ToLowerInvariant() + "_" + MapHelper.UniqueId;
                }

                return _id;
            }

            protected set { _id = value; }
        }

        protected string Map
        {
            get { return _map; }
        }

        public void SetMap(string map)
        {
            this._map = map;
        }
    }

    [Serializable]
    internal abstract class BaseMapObject<T> : BaseMapObject where T : BaseOptions
    {
        private T options;

        public T Options    
        {
            get { return options; }
            protected set { options = value; }
        }

        public void SetOptions(T options)
        {
            this.options = options;
        }
    }
}
