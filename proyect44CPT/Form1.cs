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
            string username = "carriertesting@project44.com";
            string password = "IntegrationTesting";

            var request = (HttpWebRequest)WebRequest.Create("https://cloud.p-44.com/api/carriers/v2/tl/shipments/statusUpdates");
            postData = "{\"shipmentIdentifiers\":[{\"type\":\"ORDER\",\"value\":\"8476916336\"}],\"latitude\":41.8885,\"longitude\":-87.6354,\"utcTimestamp\":\"2019-01-28T18:35:58\",\"eventType\":\"DELIVERED\",\"customerId\":\"12345\"}";
            
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
            MessageBox.Show(responseJSON);
        }

        private void btnPeticion_Click(object sender, EventArgs e)
        {
            PeticionApi("Data");
        }
    }
}





