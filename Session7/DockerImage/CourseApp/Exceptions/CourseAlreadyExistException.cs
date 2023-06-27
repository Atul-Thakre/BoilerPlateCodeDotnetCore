using System;
namespace CourseApp.Exceptions;
public class CourseAlreadyExistsException : Exception
{
    public CourseAlreadyExistsException()
    {
    }

    public CourseAlreadyExistsException(string message): base(message)
    {

    }

    public CourseAlreadyExistsException(string message, Exception innerException): base(message, innerException)
    {

    }
}
