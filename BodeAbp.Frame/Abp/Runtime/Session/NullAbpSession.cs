﻿namespace Abp.Runtime.Session
{
    /// <summary>
    /// Implements null object pattern for <see cref="IAbpSession"/>.
    /// </summary>
    public class NullAbpSession : IAbpSession
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static NullAbpSession Instance { get { return SingletonInstance; } }
        private static readonly NullAbpSession SingletonInstance = new NullAbpSession();

        /// <inheritdoc/>
        public long? UserId { get { return null; } }
        
        public long? ImpersonatorUserId { get { return null; } }

        private NullAbpSession()
        {

        }
    }
}