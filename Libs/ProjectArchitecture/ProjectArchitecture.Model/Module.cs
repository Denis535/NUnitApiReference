// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Module : INode {

        public abstract string Name { get; }
        INode[] INode.Children => Namespaces;
        public abstract Namespace[] Namespaces { get; }


        // Utils
        public override string ToString() {
            return "Module: " + Name;
        }


    }
}
