using System;
using System.Runtime.Serialization;

namespace OOP_ICT.Tools;

public class FirstException : Exception
{
    public FirstException()
    {
    }

    public FirstException(string message)
        : base(message)
    {
    }

    public FirstException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected FirstException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}