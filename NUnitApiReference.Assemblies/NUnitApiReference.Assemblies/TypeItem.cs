// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Assemblies {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TypeItem {

        public readonly string? Header;
        public readonly Type? Type;

        // Init
        private TypeItem(string? header) {
            Header = header;
        }
        private TypeItem(Type? type) {
            Type = type;
        }

        // Utils
        public static implicit operator TypeItem(string value) => new TypeItem( value );
        public static implicit operator TypeItem(Type value) => new TypeItem( value );

    }
}
