// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Item {

        public readonly string? Header;
        public readonly Type? Type;

        // Init
        private Item(string? header) {
            Header = header;
        }
        private Item(Type? type) {
            Type = type;
        }

        // Utils
        public static implicit operator Item(string value) => new Item( value );
        public static implicit operator Item(Type value) => new Item( value );

    }
}
