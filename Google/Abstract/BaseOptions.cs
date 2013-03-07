using System;
using Subgurim.Maps.Collections;

namespace Subgurim.Maps.Google.Abstract
{
    [Serializable]
    internal abstract class BaseOptions
    {
        public override string ToString()
        {
            return BuildParams().ToString();
        }

        public abstract JsonCollection BuildParams();
    }
}