namespace AllTheThings.Library42
{
    public interface IPayload
    {
        string payloadElement { get; set; }
        string payloadEvent { get; set; }
        string payloadFunction { get; set; }
        string target { get; set; }
        string tag { get; set; }
    }
}
