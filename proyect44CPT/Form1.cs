using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyect44CPT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
      
        private void PeticionApi(dynamic postData)
        {
            string username = "carriertesting@proyect44.com";
            string password = "IntegrationTesting";

            var request = (HttpWebRequest)WebRequest.Create("https://cloud.p-44.com/api/carriers/v2/tl/shipments/statusUpdates");
            postData = "{\n\"carrierIdentifier\": {\n \"type\": \"SCAC\",\n \"value\": \"ABCD\"\n},\n\"shipmentIdentifiers\": [\n {\n  \"value\": \"123456\",\n   \"type\": \"ORDER\"\n }\n],\n\"latitude\": 39.650887,\n\"longitude\": -76.235971,\n\"utcTimestamp\": \"2019 - 01 - 29T22: 49:33\",\n\"shipmentStops\": [\n {\n   \"stopNumber\": 1,\n   \"appointmentWindow\": {\n\n    \"startDateTime\": \"2019 - 02 - 18T05: 47:52\",\n    \"endDateTime\": \"2019 - 02 - 18T06: 47:52\",\n    \"localTimeZoneIdentifier\": \"America \/ New_York\"\n   },\n   \"address\": {\n    \"postalCode\": \"21014\",\n    \"addressLines\": [\n      \"580 Marketplace Dr\"\n    ],\n    \"city\": \"Bel Air\",\n\"state\": \"MD\",\n\"country\": \"US\"\n   },\n   \"contact\": {\n    \"companyName\": \"Test Company\",\n    \"contactName\": \"Test Contact\",\n    \"phoneNumber\": \"555 - 555 - 5555\",\n    \"phoneNumberCountryCode\": \"\",\n    \"phoneNumber2\": \"555 - 555 - 5555\",\n    \"phoneNumber2CountryCode\": \"\",\n    \"email\": \"\",\n    \"faxNumber\": \"555 - 555 - 5555\",\n    \"faxNumberCountryCode\": \"\"\n   },\n   \"stopName\": \"Origin\",\n   \"arrivalDateTime\": \"2019 - 02 - 18T05: 55:52\",\n   \"departureDateTime\": \"2019 - 02 - 18T06: 00:52\"\n },\n {\n   \"stopNumber\": 2,\n   \"appointmentWindow\": {\n    \"startDateTime\": \"2019 - 02 - 20T17: 48:52\",\n   \"endDateTime\": \"2019 - 02 - 20T18: 48:52\",\n    \"localTimeZoneIdentifier\": \"America \/ New_York\"\n   },\n   \"address\": {\n    \"postalCode\": \"19362\",\n    \"addressLines\": [\n\n      \"100 Ponds Edge Dr\"\n    ],\n    \"city\": \"Nottingham\",\n    \"state\": \"PA\",\n    \"country\": \"US\"\n   },\n   \"stopName\": \"Origin\",\n   \"arrivalDateTime\": \"2019 - 02 - 20T18: 20:52\",\n   \"departureDateTime\": \"2019 - 02 - 20T18: 30:52\",\n   \"carrierSuppliedEta\": \"2019 - 02 - 20T23: 30:52 - 0500\"\n }\n],\n\"latestTemperature\": 23.5,\n\"latestTemperatureUnit\": \"C\",\n\"hoursOfServiceRemaining\": 49200,\n\"customerId\": \"12345\"\n}";
            var data = Encoding.ASCII.GetBytes(postData);
            request.Headers.Add("Authentication", username);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseJSON = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseJSON);
        }
        
    }
}





