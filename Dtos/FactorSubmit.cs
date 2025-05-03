using CityInfoApi.Dtos;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public partial class FactorSubmit
{
    [JsonPropertyName("F_Markz")]
    public long FMarkz { get; set; }

    [JsonPropertyName("LoginId")]
    public long LoginId { get; set; }

    [JsonPropertyName("Anbar")]
    public long Anbar { get; set; }

    [JsonPropertyName("MoshtaryId")]
    public long MoshtaryId { get; set; }

    [JsonPropertyName("Sharh")]
    public string Sharh { get; set; }

    [JsonPropertyName("factorDetails")]
    public IEnumerable<FactorDetail> FactorDetails { get; set; }
}
