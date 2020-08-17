// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ApiReference {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class MarkdownProjectRenderer {


        public static string Render(Project project) {
            var builder = new StringBuilder();
            builder.RenderTableOfContents( project.Flatten() );
            builder.RenderBody( project.Flatten() );
            return builder.ToString();
        }
        private static void RenderTableOfContents(this StringBuilder builder, IEnumerable<object> items) {
            builder.AppendLine( "# Table of Contents" );
            foreach (var (item, uri) in items.GetHeaderLinks()) {
                if (item is Project proj) {
                    var link = proj.ToString();
                    builder.AppendFormatLine( "  - [{0}](#{1})", link, uri );
                }
                if (item is Module module) {
                    var link = module.ToString();
                    builder.AppendFormatLine( "    - [{0}](#{1})", link, uri );
                }
                if (item is Namespace @namespace) {
                    var link = @namespace.ToString();
                    builder.AppendFormatLine( "      - [{0}](#{1})", link, uri );
                }
            }
            builder.AppendLine();
        }
        private static void RenderBody(this StringBuilder builder, IEnumerable<object> items) {
            foreach (var item in items) {
                if (item is Project proj) builder.AppendLine( "# " + proj );
                if (item is Module module) builder.AppendLine( "## " + module );
                if (item is Namespace @namespace) builder.AppendLine( "### " + @namespace );
                if (item is Type type) builder.AppendLine( "* " + type.Name );
            }
        }


        // Helpers
        private static IEnumerable<(object, string)> GetHeaderLinks(this IEnumerable<object> items) {
            var prevs = new List<string>();
            foreach (var item in items) {
                if (item is Project || item is Module || item is Namespace) {
                    yield return GetHeaderLink( item, prevs );
                }
            }
        }
        private static (object, string) GetHeaderLink(object item, List<string> prevs) {
            var uri = item
                .ToString()
                .ToLowerInvariant()
                .Replace( "  ", " " )
                .Replace( " ", "-" )
                .Replace( ".", "" )
                .Replace( ":", "" );
            var id = prevs.Count( i => i == uri );
            prevs.Add( uri );
            if (id == 0)
                return (item, uri);
            else
                return (item, uri + "-" + id);
        }
        // Helpers/Linq
        //private static IEnumerable<(T, IEnumerable<T>)> WithPrevious<T>(this IEnumerable<T> source) {
        //    var previous = new List<T>();
        //    foreach (var item in source) {
        //        yield return (item, previous);
        //        previous.Add( item );
        //    }
        //}
        // Helpers/Text
        private static StringBuilder AppendFormatLine(this StringBuilder builder, string format, params object[] args) {
            builder.AppendFormat( format, args ).AppendLine();
            return builder;
        }


    }
}
