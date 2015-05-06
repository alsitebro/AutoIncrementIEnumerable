﻿namespace Helpers
{
    /// <summary>
    /// Abstract class which describes an object with
    /// a unique Id of type int
    /// </summary>
    public abstract class ObjectWithUniqueId
    {
        /// <summary>
        /// Unique Id generated by the AutoIncrement extension method
        /// as object is added to a Collection
        /// </summary>
        public int Id { get; set; }
    }
}
