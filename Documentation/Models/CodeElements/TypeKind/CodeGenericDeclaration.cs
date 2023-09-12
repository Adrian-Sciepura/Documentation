﻿using System.Collections.Generic;

namespace Documentation.Models.CodeElements.TypeKind
{
    internal class CodeGenericDeclaration : BaseCodeDeclarationKind
    {
        public List<BaseCodeDeclarationKind> SubTypes { get; set; }
        public CodeRegularDeclaration MainType { get; set; }

        public CodeGenericDeclaration(List<BaseCodeDeclarationKind> subTypes, CodeRegularDeclaration mainType)
        {
            SubTypes = subTypes;
            MainType = mainType;
        }

        public override string GetName()
        {
            return MainType.Name;
        }

        public override string? GetFullName()
        {
            return MainType.FullName;
        }

        public override string? GetHash()
        {
            return MainType.FullNameHash;
        }

        public override void AddReference(CodeElement codeElement)
        {
            MainType.TypeReference = codeElement;
        }
    }
}
