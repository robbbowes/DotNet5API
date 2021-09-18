using System.Text.Json.Serialization;

namespace dotnet5_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Knight,
        Mage,
        Cleric
    }
}