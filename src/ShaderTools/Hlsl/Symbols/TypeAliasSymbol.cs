using System.Collections.Generic;
using ShaderTools.Core.Symbols;
using ShaderTools.Hlsl.Syntax;

namespace ShaderTools.Hlsl.Symbols
{
    public sealed class TypeAliasSymbol : TypeSymbol
    {
        internal TypeAliasSymbol(TypeAliasSyntax syntax, TypeSymbol valueType)
            : base(SymbolKind.TypeAlias, syntax.Identifier.Text, string.Empty, null)
        {
            ValueType = valueType;
        }

        public TypeSymbol ValueType { get; }

        public override IEnumerable<T> LookupMembers<T>(string name)
        {
            return ValueType.LookupMembers<T>(name);
        }
    }
}