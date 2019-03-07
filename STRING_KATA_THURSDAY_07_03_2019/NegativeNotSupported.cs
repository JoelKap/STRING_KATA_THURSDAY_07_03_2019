﻿using System;
using System.Runtime.Serialization;

namespace STRING_KATA_THURSDAY_07_03_2019
{
    [Serializable]
    internal class NegativeNotSupported : Exception
    {
        public NegativeNotSupported()
        {
        }

        public NegativeNotSupported(string message) : base(message)
        {
        }

        public NegativeNotSupported(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeNotSupported(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
