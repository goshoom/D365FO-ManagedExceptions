using System;

namespace Goshoom.DynamicsAX
{
    /// <summary>
    /// Provides methods for working with managed exceptions from X++.
    /// </summary>
    public class ExceptionHelper
    {
        /// <summary>
        /// Throws an exception.
        /// </summary>
        /// <param name="ex">An exception to be thrown.</param>
        public static void ThrowException(Exception ex)
        {
            throw ex;
        }
    }
}
