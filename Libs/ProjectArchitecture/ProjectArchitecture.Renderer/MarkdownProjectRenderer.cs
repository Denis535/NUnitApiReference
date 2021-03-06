// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Renderer {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ProjectArchitecture.Model;

    public static class MarkdownProjectRenderer {


        public static string Render(this Project project) {
            var builder = new StringBuilder();
            project.RenderTableOfContents( builder );
            project.RenderBody( builder );
            return builder.ToString();
        }


        // Helpers/Render
        private static void RenderTableOfContents(this Project project, StringBuilder builder) {
            builder.AppendLine( "# Table of Contents" );
            foreach (var (item, link, uri) in project.Flatten().GetHeaderLinks()) {
                var line = RenderLink( item, link, uri );
                if (line != null) builder.AppendLine( line );
            }
            builder.AppendLine();
        }
        private static void RenderBody(this Project project, StringBuilder builder) {
            foreach (var item in project.Flatten()) {
                builder.AppendLine( RenderNode( item ) );
            }
        }
        // Helpers/Render/Node
        private static string? RenderLink(INode node, string link, string uri) {
            return node switch {
                Project proj => string.Format( "  - [{0}](#{1})", link, uri ),
                Module module => string.Format( "    - [{0}](#{1})", link, uri ),
                Namespace @namespace => string.Format( "      - [{0}](#{1})", link, uri ),
                //Group group => string.Format( "        - [{0}](#{1})", link, uri ),
                Group group => null,
                { } => throw new NotImplementedException( node.ToString() ),
                null => throw new NullReferenceException( "Null" ),
            };
        }
        private static string RenderNode(INode node) {
            return node switch {
                Project proj => "# " + proj,
                Module module => "## " + module,
                Namespace @namespace => "### " + @namespace,
                Group group => "#### " + group,
                TypeItem type => "* " + type.Name,
                { } => throw new NotImplementedException( node.ToString() ),
                null => throw new NullReferenceException( "Null" ),
            };
        }
        // Helpers/Misc
        private static IEnumerable<(INode, string, string)> GetHeaderLinks(this IEnumerable<INode> items) {
            var prevs = new List<string>();
            foreach (var item in items) {
                if (item is Project || item is Module || item is Namespace || item is Group) {
                    yield return GetHeaderLink( item, prevs );
                }
            }
        }
        private static (INode, string, string) GetHeaderLink(INode item, List<string> prevs) {
            var link = item.ToString();
            var uri = item.ToString().ToLowerInvariant()
                .Replace( "  ", " " )
                .Replace( " ", "-" )
                .Replace( ".", "" )
                .Replace( ":", "" )
                .Replace( "/", "" );
            var id = prevs.Count( i => i == uri );
            prevs.Add( uri );
            if (id == 0)
                return (item, link, uri);
            else
                return (item, link, uri + "-" + id);
        }
        // Helpers/Linq
        //private static IEnumerable<(T, IEnumerable<T>)> WithPrevious<T>(this IEnumerable<T> source) {
        //    var previous = new List<T>();
        //    foreach (var item in source) {
        //        yield return (item, previous);
        //        previous.Add( item );
        //    }
        //}


    }
}
