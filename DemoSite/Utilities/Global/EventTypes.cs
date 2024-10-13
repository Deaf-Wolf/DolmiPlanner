namespace DemoSite.Utilities.Global
{
    public class Global
    {
        public class EventType
        {
            public string HexCode { get; set; }
            public string Type { get; set; }
        }

        public static class EventTypes
        {
            public static readonly List<EventType> Types = new List<EventType>
        {
            new EventType { HexCode = "#008000", Type = "Ohne Leistung" },
            new EventType { HexCode = "#FF0000", Type = "Arbeitsleben" },
            new EventType { HexCode = "#FFA500", Type = "Coaching" },
            new EventType { HexCode = "#FFFF00", Type = "Eltern in der Schule" },
            new EventType { HexCode = "#0000FF", Type = "Dozentieren" },
            new EventType { HexCode = "#800080", Type = "Medizin" },
            new EventType { HexCode = "#A52A2A", Type = "Schuhlleben" },
            new EventType { HexCode = "#808080", Type = "Studiumleben" },
            new EventType { HexCode = "#40E0D0", Type = "Vorstellungsgespräch" },
            new EventType { HexCode = "#FF69B4", Type = "Vorgespräch" }
        };

            public static EventType GetEventType(string type)
            {
                return Types.FirstOrDefault(t => t.Type.Equals(type, StringComparison.OrdinalIgnoreCase))
                    ?? new EventType { HexCode = "#000000", Type = "Unknown" };
            }
        }
    }

}