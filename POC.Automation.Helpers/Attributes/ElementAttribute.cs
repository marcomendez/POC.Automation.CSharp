using POC.Automation.Helpers.Enums;
using System;

namespace POC.Automation.Helpers.Attributes
{
    /// <summary>
    /// Attributes to handle properties of classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ElementAttribute : Attribute
    {
        public string Name { get; set; }

        public ElementType Type { get; set; }

        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="name">Name of Attribute.</param>
        /// <param name="type">ElementType value.</param>
        public ElementAttribute(string name, ElementType type)
        {
            Name = name;
            Type = type;
        }
    }
}