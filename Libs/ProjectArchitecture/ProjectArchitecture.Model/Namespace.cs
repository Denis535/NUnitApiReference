// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Namespace : INode {

        public string Name { get; }
        public Group[] Groups { get; }
        public Namespace(string name, params Group[] groups) => (Name, Groups) = (name, groups);


        // Utils
        public override string ToString() {
            return "Namespace: " + Name;
        }


    }
    //public class NamespaceBuilder {
    //    public string Name { get; }
    //    public List<Group> Groups { get; } = new List<Group>();
    //    public NamespaceBuilder(string name) => Name = name;

    //    public static NamespaceBuilder operator +(NamespaceBuilder builder, Group group) {
    //        builder.Groups.Add( group );
    //        return builder;
    //    }
    //    public static implicit operator Namespace(NamespaceBuilder builder) {
    //        return new Namespace( builder.Name, builder.Groups.ToArray() );
    //    }

    //}
    //public static class NamespaceExtensions {

    //    public static NamespaceBuilder AsNamespace(this string name) {
    //        return new NamespaceBuilder( name );
    //    }

    //}
}
