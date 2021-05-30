using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]//convert array to names 0 to knight
    public enum RpgClass
    {
       Knight,
       Assassin, 
       Mage,
       Engineer
    }
}