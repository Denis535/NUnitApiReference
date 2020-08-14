// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Module {

        public abstract string Name { get; }
        public abstract Namespace[] Namespaces { get; }


        // Utils
        public override bool Equals(object other) {
            return other is Module other_ && other_.Name == Name;
        }
        public override int GetHashCode() {
            return (Name, Namespaces).GetHashCode();
        }
        public override string ToString() {
            return $"{nameof( Module )}: {Name}";
        }


    }
}
