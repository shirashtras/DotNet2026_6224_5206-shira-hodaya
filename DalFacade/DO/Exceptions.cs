namespace DO;


[Serializable]
public class DalIdNotExists : Exception
{
    public DalIdNotExists(string? message) : base(message) { }
}
[Serializable]
public class DalIdExists : Exception
{
    public DalIdExists(string? message) : base(message) { }
}

[Serializable]
public class DalFilterNotExists : Exception
{
    public DalFilterNotExists(string? message) : base(message) { }
}