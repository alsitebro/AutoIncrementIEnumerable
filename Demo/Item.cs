using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /// <summary>
    /// The Item class inherits the Id property from the
    /// ObjectWithUniqueId parent class
    /// </summary>
    public class Item : ObjectWithUniqueId
    {
        public string Content { get; set; }
    }
}
