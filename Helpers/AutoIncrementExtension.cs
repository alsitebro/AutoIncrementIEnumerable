using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    /// <summary>
    /// This static class contains an extension method
    /// linked to the IEnumerable<T> interfaces
    /// </summary>
    public static class AutoIncrementExtension
    {
        /// <summary>
        /// Generates a database-style unique ID
        /// by incrementing the Id of the last item in the list
        /// </summary>
        /// <param name="collection">A collection of tye ObjectWithUniqueId</param>
        /// <returns>int</returns>
        public static int AutoIncrement(this IEnumerable<ObjectWithUniqueId> collection)
        {
            var objects = collection as IList<ObjectWithUniqueId> ?? collection.ToList();
            //Return 1 if there is no item in the collection. This will serve as the Id of the first item added to the collection
            if (!objects.Any()) return 1;
            return (objects.OrderBy((x) => x.Id).Last().Id + 1);
            /**
             *You can also do this:
             *return (objects.OrderByDescending((x) => x.Id).First().Id + 1);
             **/
        }
    }
}
