using System;


namespace Org.Webelopers.Api.Logic
{
    public class Utils
    {
        public static void ThrowIf<TException>(bool condition, String message) where TException : Exception, new()
        {
            if (condition)
            {
                throw (TException) Activator.CreateInstance(typeof(TException), message);
            }
        }

        public static T ThrowIfNullReference<T>(T value, String exceptionMessage) where T : class =>
            value ?? throw new NullReferenceException(exceptionMessage);
    }
}