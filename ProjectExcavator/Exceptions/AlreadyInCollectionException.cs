using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.Exceptions;

/// <summary>
/// Класс, описывающий ошибку наличия такого объекта в коллекции
/// </summary>
[Serializable]
public class AlreadyInCollectionException : ApplicationException
{
    public AlreadyInCollectionException() : base("Такой объект уже есть в коллекции") { }
    public AlreadyInCollectionException(string message) : base(message) { }
    public AlreadyInCollectionException(string message, Exception exception) : base(message, exception) { }
    protected AlreadyInCollectionException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }

}
