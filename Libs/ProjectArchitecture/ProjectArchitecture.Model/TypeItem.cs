// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TypeItem : INode {

        public Type Type { get; }
        public string Name => Type.Name;
        public TypeItem(Type type) => Type = type;


        // Utils
        public override string ToString() {
            return "Type: " + Name;
        }


        // Operators
        public static implicit operator TypeItem(Type type) => new TypeItem( type );


    }
}
