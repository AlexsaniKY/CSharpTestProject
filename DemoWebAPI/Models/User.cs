using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Models {
    public class User {

        public string Name { get; set; }

        public User(string name) {

            Name = name;

        }

    }
}