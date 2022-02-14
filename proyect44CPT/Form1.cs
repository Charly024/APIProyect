using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        List<ShipmentIdentifiers> shipmentIdentifiersList = new List<ShipmentIdentifiers>();
        List<ShipmentStops> shipmentStopsLlist = new List<ShipmentStops>();


        public frmMain()
        {
            InitializeComponent(); 
            cboUnit.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
            cboLocalTimeZone.SelectedIndex = 0;
            cboState.SelectedIndex = 0;
        }
      
        private string PeticionApi(string postData)
        {
            string username = "carriertesting@project44.com";
            string password = "IntegrationTesting";

            var request = (HttpWebRequest)WebRequest.Create("https://cloud.p-44.com/api/carriers/v2/tl/shipments/statusUpdates");
            //postData = "{\"shipmentIdentifiers\":[{\"type\":\"ORDER\",\"value\":\"8476916336\"}],\"latitude\":41.8885,\"longitude\":-87.6354,\"utcTimestamp\":\"2019-01-28T18:35:58\",\"eventType\":\"DELIVERED\",\"customerId\":\"12345\"}";
            
            var data = Encoding.ASCII.GetBytes(postData);

            //Duda de como realiar la autenticacion con el nombre de usuario y contraseña

           var autentication = "Basic Y2FycmllcnRlc3RpbmdAcHJvamVjdDQ0LmNvbTpJbnRlZ3JhdGlvblRlc3Rpbmc=";
            request.Headers.Add("Authorization", autentication);
            //Duda de como realiar la autenticacion con el nombre de usuario y contraseña

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            
            var response = (HttpWebResponse)request.GetResponse();
            
            
            var responseJSON = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseJSON;
        }

        private void btnPeticion_Click(object sender, EventArgs e)
        {
            PeticionApi("Data");
        }

        private string GenerateJSON()
        {
            EstructuraJson principal = new EstructuraJson();
            //Carrier Object
            principal.carrierIdentifier = new CarrierIdentifier() { type = txtTypeCarrier.Text, value = txtValueCarrier.Text};

            //Shimpent Objet list
            principal.shipmentIdentifiers = new List<ShipmentIdentifiers>();
            principal.shipmentIdentifiers = shipmentIdentifiersList;

            //Latitude, longitude, timestamp attributes
            principal.latitude = double.Parse(numLatitude.Value.ToString());
            principal.longitude = double.Parse(numLongitude.Value.ToString());
            principal.utcTimestamp = String.Format("{0}-{1}-{2}T{3}",dtpTimeStamp.Value.ToString("yyyy"),dtpTimeStamp.Value.ToString("MM"),dtpTimeStamp.Value.ToString("dd"),dtpTimeStamp.Value.ToString("HH:mm:ss"));
            principal.eventType = cboType.SelectedItem.ToString();
            //-----SHIPMENTSTOPS-----
            principal.shipmentStops = new List<ShipmentStops>();
            principal.shipmentStops = shipmentStopsLlist;


            //Temperature, Unit, Hours remaing, Customer id attributes
            principal.latestTemperature = double.Parse(numTemperature.Value.ToString());
            principal.latestTemperatureUnit = cboUnit.SelectedItem.ToString();
            principal.hoursOfServiceRemaining = int.Parse(numHoursRemaining.Value.ToString());
            principal.customerId = txtCustomerId.Text;

            //Serealizacion a JSON
            string jsonString = JsonConvert.SerializeObject(principal);
            MessageBox.Show(JToken.Parse(jsonString).ToString());

            return jsonString;
        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            //Add Shipment Itedntifier
            shipmentIdentifiersList.Add(new ShipmentIdentifiers() { type = txtTypeShipment.Text,value = txtValueShipment.Text});
        }

        private void btnAddStop_Click(object sender, EventArgs e)
        {
            //Add Shipment Stop
            shipmentStopsLlist.Add(new ShipmentStops()
            {
                stopNumber = int.Parse(numStopNumber.Value.ToString()),
                //-----APPOINTMENTWINDOW-----
                appointmentWindow = new AppointmentWindow()
                {
                    startDateTime = String.Format("{0}-{1}-{2}T{3}", dtpStartDate.Value.ToString("yyyy"), dtpStartDate.Value.ToString("MM"), dtpStartDate.Value.ToString("dd"), dtpStartDate.Value.ToString("HH:mm:ss")),
                    endDateTime = String.Format("{0}-{1}-{2}T{3}", dtpEndDate.Value.ToString("yyyy"), dtpEndDate.Value.ToString("MM"), dtpEndDate.Value.ToString("dd"), dtpEndDate.Value.ToString("HH:mm:ss")),
                    localTimeZoneIdentifier = cboLocalTimeZone.SelectedItem.ToString()
                },
                //-----ADDRESS-----
                address = new Address()
                {
                    postalCode = txtPostalCode.Text,
                    addressLines = txtAddressLines.Text.Split('\n'),
                    city = txtCity.Text,
                    state = cboState.Text,
                    country = cboCountry.Text
                },
                //-----CONTACT-----
                contact = chkContact.Checked ? null : new Contact()
                {
                    companyName = txtCompanyName.Text,
                    contactName = txtContactName.Text,
                    phoneNumber = txtPhone1.Text,
                    phoneNumberCountryCode = txtExt1.Text,
                    phoneNumber2 = txtPhone2.Text,
                    phoneNumber2CountryCode = txtExt2.Text,
                    email = txtEmail.Text,
                    faxNumber = txtFaxNumber.Text,
                    faxNumberCountryCode = txtExtFax.Text
                },
                stopName = txtStopName.Text,
                arrivalDateTime = String.Format("{0}-{1}-{2}T{3}", dtpArrivalDate.Value.ToString("yyyy"), dtpArrivalDate.Value.ToString("MM"), dtpArrivalDate.Value.ToString("dd"), dtpArrivalDate.Value.ToString("HH:mm:ss")),
                departureDateTime = String.Format("{0}-{1}-{2}T{3}", dtpDepartureDate.Value.ToString("yyyy"), dtpDepartureDate.Value.ToString("MM"), dtpDepartureDate.Value.ToString("dd"), dtpDepartureDate.Value.ToString("HH:mm:ss"))
            });
        }

        private void btnGenerateJson_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GenerateJSON());
            txtJson.Text = GenerateJSON();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PeticionApi(GenerateJSON()),"Aceptado",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
        }

        private void btnCleanList_Click(object sender, EventArgs e)
        {
            shipmentIdentifiersList.Clear();
        }
    }
}





