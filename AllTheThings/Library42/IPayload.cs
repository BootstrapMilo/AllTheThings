using System.Collections.Generic;

namespace AllTheThings.Library42
{
    public interface IPayload
    {
        string PayloadElement { get; set; }
        string PayloadEvent { get; set; }
        string PayloadFunction { get; set; }
        List<string> Targets { get; set; }
        List<string> Tags { get; set; }
    }
}
