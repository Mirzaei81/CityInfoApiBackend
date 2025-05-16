using CityInfoApi.Models;

public class ConfigDto
{
    public ConfigDto(string databaseName, string dateFrom, string dateTo)
    {
        this.databaseName = databaseName;
        this.dateFrom = dateFrom;
        this.dateTo = dateTo;
    }

    public string databaseName { get; set; }
    public string dateFrom{ get; set; }
    public string dateTo{ get; set; }

}
