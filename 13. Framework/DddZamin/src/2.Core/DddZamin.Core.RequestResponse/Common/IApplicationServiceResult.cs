namespace DddZamin.Core.RequestResponse.Common;

public interface IApplicationServiceResult
{
    IEnumerable<string> Messages { get; }
    ApplicationServiceStatus Status { get; set; }
}

