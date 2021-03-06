// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.Serialization;

namespace System.Windows.Reach
{
    /// <summary>
    /// This class is the base class for all exceptions that are
    /// thrown by the Reach packaging and serialization APIs.
    /// </summary>
    [Serializable]
    public class ReachException : Exception
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public
        ReachException(
            )
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public
        ReachException(
            string              message
            )
            : base(message)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public
        ReachException(
            string              message,
            Exception           innerException
            )
            : base(message, innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected
        ReachException(
            SerializationInfo   info,
            StreamingContext    context
            )
            : base(info, context)
        {
        }

        #endregion Constructors
    }
}