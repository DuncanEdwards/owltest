namespace SystemsUnderTest.JsonSerializer
{
    public interface IJsonSerializer
    {
        string Serialize(object objectToSerialize);
    }
}
