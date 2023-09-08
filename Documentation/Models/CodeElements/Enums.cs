﻿using System.Collections.Generic;

namespace Documentation.Models.CodeElements
{
    internal enum CodeElementType
    {
        Namespace,
        Property,
        Variable,
        Constructor,
        Destructor,
        Method,
        Operator,
        Delegate,
        Interface,
        Class,
        Struct,
        Record,
        Enum,
        None
    }

    internal static class ConvertCodeElementType
    {
        internal static readonly Dictionary<CodeElementType, string> ConvertToPluralForm = new Dictionary<CodeElementType, string>
        {
            { CodeElementType.Property, "Properties" },
            { CodeElementType.Variable, "Variables" },
            { CodeElementType.Delegate, "Delegates" },
            { CodeElementType.Constructor, "Constructors" },
            { CodeElementType.Destructor, "Destructors" },
            { CodeElementType.Method, "Methods" },
            { CodeElementType.Operator, "Operators" },
            { CodeElementType.Interface, "Interfaces" },
            { CodeElementType.Class, "Classes" },
            { CodeElementType.Struct, "Structs" },
            { CodeElementType.Record, "Records" },
            { CodeElementType.Enum, "Enums" },
            { CodeElementType.None, "Invalid Element Type" }
        };
    }
}
