using System;

namespace Octo.Robot
{
    [System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    internal sealed class SysAttribute : Attribute
    {
        // See the attribute guidelines at
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        private readonly string positionalString;

        // This is a positional argument
        public SysAttribute(string positionalString)
        {
            this.positionalString = positionalString;

            // TODO: Implement code here

            // throw new NotImplementedException();
        }

        public string PositionalString {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }
    }
}