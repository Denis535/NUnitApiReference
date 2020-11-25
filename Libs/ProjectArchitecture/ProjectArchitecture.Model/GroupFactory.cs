namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class GroupFactory {


        public static Group AsGroup(this string name) {
            return new Group( name );
        }


    }
}
