using System;
using System.Runtime.Serialization;

public class PMApiException : Exception
{
    public PMApiException(){}
    public PMApiException(SerializationInfo info, StreamingContext context)
    {
        if (info != null) this.message = info.GetString("message");
    }

    public PMApiStatus status { get; set; }
    public PMErrorCode errorCode { get; set; }
    public string message { get; set; }
}
