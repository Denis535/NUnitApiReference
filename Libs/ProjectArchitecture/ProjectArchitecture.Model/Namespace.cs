// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Namespace : INode {

        public string Name { get; }
        public Type[] Types { get; }
        public Namespace(string name, params Type[] types) => (Name, Types) = (name, types);


        // Utils
        public override string ToString() {
            return $"{nameof( Namespace )}: {Name}";
        }


    }
}
