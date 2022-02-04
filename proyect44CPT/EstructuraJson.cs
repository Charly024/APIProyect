using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect44CPT
{
    public class EstructuraJson
    {
        
            public CarrierIdentifier carrierIdentifier { get; set; }
            public IList<ShipmentIdentifiers> shipmentIdentifiers { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string utcTimestamp { get; set; }
            public IList<ShipmentStops> shipmentStops { get; set; }
            public double latestTemperature { get; set; }
            public string latestTemperatureUnit { get; set; }
            public int hoursOfServiceRemaining { get; set; }
            public string customerId { get; set; }

        
        
    }
    public class CarrierIdentifier
    {
        public string type { get; set; }
        public string value { get; set; }

    }
    public class ShipmentIdentifiers
    {
        public string value { get; set; }
        public string type { get; set; }

    }
    public class AppointmentWindow
    {
        public string startDateTime { get; set; }
        public string endDateTime { get; set; }
        public string localTimeZoneIdentifier { get; set; }

    }
    public class Address
    {
        public string postalCode { get; set; }
        public IList<string> addressLines { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

    }
    public class Contact
    {
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string phoneNumber { get; set; }
        public string phoneNumberCountryCode { get; set; }
        public string phoneNumber2 { get; set; }
        public string phoneNumber2CountryCode { get; set; }
        public string email { get; set; }
        public string faxNumber { get; set; }
        public string faxNumberCountryCode { get; set; }

    }
    public class ShipmentStops
    {
        public int stopNumber { get; set; }
        public AppointmentWindow appointmentWindow { get; set; }
        public Address address { get; set; }
        public Contact contact { get; set; }
        public string stopName { get; set; }
        public string arrivalDateTime { get; set; }
        public string departureDateTime { get; set; }

    }
}
