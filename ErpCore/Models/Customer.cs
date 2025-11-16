namespace ErpCore.Models
{
    // public = "Den här klassen kan ses och användas av andra delar av programmet."
    public class Customer
    {
        // 'prop' är en "snippet". Skriv 'prop' och tryck TAB två gånger.
        // Detta är egenskaper (Properties) som definierar en kund.

        // Varje kund måste ha ett unikt ID. 
        // Detta blir "Primary Key" i databasen sen.
        public int Id { get; set; }

        // Ett unikt kundnummer, kan innehålla bokstäver (t.ex. "KU-001").
        // Vi använder 'string' istället för 'int'.
        public string CustomerNumber { get; set; }

        // Kundens namn.
        public string Name { get; set; }

        // Kundens e-post.
        public string Email { get; set; }

        // Senare kan vi lägga till 'Phone', 'Address', etc.
        // Men vi håller det enkelt nu.
    }
}