// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Project {

        public abstract string Name { get; }
        public abstract Module[] Modules { get; }


        // Flatten
        public IEnumerable<object> Flatten() {
            yield return this;

            foreach (var module in Modules) {
                yield return module;

                foreach (var @namespace in module.Namespaces) {
                    yield return @namespace;

                    foreach (var type in @namespace.Types) {
                        yield return type;
                    }
                }
            }
        }


        // Utils
        public override bool Equals(object other) {
            return other is Project other_ && other_.Name == Name;
        }
        public override int GetHashCode() {
            return (Name, Modules).GetHashCode();
        }
        public override string ToString() {
            return $"{nameof( Project )}: {Name}";
        }
        public string ToLongString() {
            var builder = new StringBuilder();
            builder.AppendLine( "Project: " + Name );

            foreach (var module in Modules) {
                builder.AppendLine( "Module: " + module.Name );

                foreach (var @namespace in module.Namespaces) {
                    builder.AppendLine( "Namespace: " + @namespace.Name );

                    foreach (var type in @namespace.Types) {
                        builder.AppendLine( "Type: " + type.Name );
                    }
                }
            }
            return builder.ToString();
        }


    }
}
