using System;
using Subgurim.Maps.Core.Collections;

namespace Subgurim.Maps.Core.Google.Abstract
{
    [Serializable]
    public abstract class BaseOptions
    {
        public override string ToString()
        {
            return BuildParams().ToString();
        }

        public abstract JsonCollection BuildParams();
    }
}