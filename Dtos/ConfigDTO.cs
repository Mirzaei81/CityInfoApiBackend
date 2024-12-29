public class ConfigDto
{
    public string databaseName { get; set; }
    public string dateFrom     { get; set; }
    public string dateTo       { get; set; }
    public ConfigDto(string dbN,string DbF,string dbE)
    {
        databaseName = dbN;
        dateFrom = DbF;    
        dateTo= dbE;    

    }
}
