// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Namespace {

        public string Name { get; }
        public Type[] Types { get; }
        public Namespace(string name, params Type[] types) => (Name, Types) = (name, types);


        // Utils
        public override bool Equals(object other) {
            return other is Namespace other_ && other_.Name == Name;
        }
        public override int GetHashCode() {
            return (Name, Types).GetHashCode();
        }
        public override string ToString() {
            return $"{nameof( Namespace )}: {Name}";
        }


    }
}
