using System;

namespace Subgurim.Maps.Google.Utilities
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    internal sealed class JavascriptResourceAttribute : Attribute
    {
        private readonly string _resourceFileName;

        public JavascriptResourceAttribute(string resourceFileName)
        {
            _resourceFileName = resourceFileName;
        }

        public string ResourceFileName
        {
            get { return _resourceFileName; }
        }
    }
}