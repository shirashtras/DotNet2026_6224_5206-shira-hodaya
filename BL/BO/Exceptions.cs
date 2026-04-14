namespace BO;

[Serializable]
public class BlIdNotExistsException : Exception
{
    public BlIdNotExistsException(string massage) : base(massage) { }
    public BlIdNotExistsException(string massage, Exception innerException) : base(massage, innerException) { }
}
[Serializable]
public class BlIdExistsException : Exception
{
    public BlIdExistsException(string massage) : base(massage) { }
    public BlIdExistsException(string massage, Exception innerException) : base(massage, innerException) { }
}