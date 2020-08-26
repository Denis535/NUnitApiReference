// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Group : INode {

        public string Name { get; }
        public TypeItem[] Types { get; }
        internal Group(string name, params TypeItem[] types) => (Name, Types) = (name, types);


        // Utils
        public override string ToString() {
            return "Group: " + Name;
        }


    }
    public static class GroupExtensions {

        public static GroupBuilder AsGroup(this string name) {
            return new GroupBuilder( name );
        }
        public static Group AsGroup(this string name, params TypeItem[] types) {
            return new Group( name, types );
        }

    }
    public class GroupBuilder {
        public string Name { get; }
        public List<TypeItem> Types { get; } = new List<TypeItem>();
        public GroupBuilder(string name) => Name = name;

        public static GroupBuilder operator *(GroupBuilder builder, Type type) {
            builder.Types.Add( type );
            return builder;
        }
        public static implicit operator Group(GroupBuilder builder) {
            return new Group( builder.Name, builder.Types.ToArray() );
        }

    }
}
