// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Namespace : INode {

        public string Name { get; }
        public Group[] Groups { get; }
        internal Namespace(string name, params Group[] groups) => (Name, Groups) = (name, groups);


        // Utils
        public override string ToString() {
            return "Namespace: " + Name;
        }


    }
    public static class NamespaceExtensions {

        public static Namespace AsNamespace(this string name, params Group[] groups) {
            return new Namespace( name, groups );
        }

    }
}
