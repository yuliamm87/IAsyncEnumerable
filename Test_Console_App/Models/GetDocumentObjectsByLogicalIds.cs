namespace Test_Console_App.Models;

internal class GetDocumentObjectsByLogicalIds
{

    public GetDocumentObjectsByLogicalIds(List<string> logicalIds, string statusFilter)
    {
        LogicalIds = logicalIds;
        StatusFilter = statusFilter;
    }

    public List<string> LogicalIds { get; set; }

    public string StatusFilter { get; set; }
}