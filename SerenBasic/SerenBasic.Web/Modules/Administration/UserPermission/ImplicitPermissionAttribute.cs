using System;

namespace SerenBasic
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class ImplicitPermissionAttribute : Attribute
    {
        public ImplicitPermissionAttribute(string value)
        {
            this.Value = value;
        }

        public string Value
        {
            get; private set;
        }
    }
}