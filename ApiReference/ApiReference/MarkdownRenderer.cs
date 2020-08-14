// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ApiReference {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class MarkdownRenderer {


        public static string Render(Project project) {
            var builder = new StringBuilder();
            Render( builder, project.Flatten() );
            return builder.ToString();
        }
        public static void Render(StringBuilder builder, IEnumerable<object> items) {
            foreach (var (item, id) in items.WithId()) {
                if (item is Project project_) {
                    builder.AppendLine( string.Format( "  - [Project: {0}](#{1}-{2})", project_.Name, project_.Name.ToLowerInvariant(), id ) );
                }
                if (item is Module module) {
                    builder.AppendLine( string.Format( "    - [Module: {0}](#{1}-{2})", module.Name, module.Name.ToLowerInvariant(), id ) );
                }
                if (item is Namespace @namespace) {
                    builder.AppendLine( string.Format( "      - [Namespace: {0}](#{1}-{2})", @namespace.Name, @namespace.Name.ToLowerInvariant(), id ) );
                }
            }

            builder.AppendLine();

            foreach (var item in items) {
                if (item is Project project_) {
                    builder.AppendLine( "# Project: " + project_.Name );
                }
                if (item is Module module) {
                    builder.AppendLine( "## Module: " + module.Name );
                }
                if (item is Namespace @namespace) {
                    builder.AppendLine( "### Namespace: " + @namespace.Name );
                }
                if (item is Type type) {
                    builder.AppendLine( "#### Type: " + type.Name );
                }
            }
        }


        // Helpers/Linq
        private static IEnumerable<(T, int)> WithId<T>(this IEnumerable<T> source) {
            foreach (var (item, prevs) in source.WithPrevious()) {
                var id = prevs.Count( i => i.Equals( item ) );
                yield return (item, id);
            }
        }
        private static IEnumerable<(T, IEnumerable<T>)> WithPrevious<T>(this IEnumerable<T> source) {
            var previous = new List<T>();
            foreach (var item in source) {
                yield return (item, previous);
                previous.Add( item );
            }
        }


    }
}
