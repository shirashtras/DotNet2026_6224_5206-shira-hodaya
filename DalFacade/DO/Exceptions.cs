namespace DO;


[Serializable]
public class DalIdNotExists : Exception
{
    public DalIdNotExists(string? message) : base(message) { }
    //public DalIdNotExists(string message, Exception innerException) : base(message, innerException) { }
}
[Serializable]
public class DalIdExists : Exception
{
    public DalIdExists(string? message) : base(message) { }
    //public DalIdExists(string message, Exception innerException) : base(message, innerException) { }
}

[Serializable]
public class DalFilterNotExists : Exception
{
    public DalFilterNotExists(string? message) : base(message) { }
    //public DalIdExists(string message, Exception innerException) : base(message, innerException) { }
}