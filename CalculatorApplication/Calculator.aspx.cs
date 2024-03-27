using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApplication
{
    public partial class Calculator : System.Web.UI.Page
    {
        Uri baseAddress = new Uri("https://localhost:44376/api");
        private readonly HttpClient _client;
        protected void Page_Load(object sender, EventArgs e)
        {
            Uri baseAddress = new Uri("https://localhost:44376/api");
             HttpClient _client;
            if(!IsPostBack)
            {

            }
        }     

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = baseAddress;
            // Create an anonymous object to hold num1 and num2 values
            var requestData = new
            {
                num1 = int.Parse(txtNum1.Text),  
                num2 = int.Parse(txtNum2.Text)
            };

            // Serialize the object to JSON string
            string jsonData = JsonConvert.SerializeObject(requestData);

            // Create StringContent with JSON data
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Make the API call to Add method of CalculateAPIController
            HttpResponseMessage response = client.PostAsync("api/CalculateAPI/Add", content).Result;

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response                
                var resultContent = response.Content.ReadAsStringAsync().Result;
                dynamic resultObject = JObject.Parse(resultContent);
                txtResult.Text = resultObject.value;

            }
            else
            {
                // Handle unsuccessful response
                // For example, log error or show error message to user
            }
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = baseAddress;
            // Create an anonymous object to hold num1 and num2 values
            var requestData = new
            {
                num1 = int.Parse(txtNum1.Text),
                num2 = int.Parse(txtNum2.Text)
            };

            // Serialize the object to JSON string
            string jsonData = JsonConvert.SerializeObject(requestData);

            // Create StringContent with JSON data
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Make the API call to Add method of CalculateAPIController
            HttpResponseMessage response = client.PostAsync("api/CalculateAPI/Sub", content).Result;

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                // For example, read response content if needed
                var resultContent = response.Content.ReadAsStringAsync().Result;
                dynamic resultObject = JObject.Parse(resultContent);
                txtResult.Text = resultObject.value;

            }
            else
            {
                // Handle unsuccessful response
                // For example, log error or show error message to user
            }
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = baseAddress;
            // Create an anonymous object to hold num1 and num2 values
            var requestData = new
            {
                num1 = int.Parse(txtNum1.Text),
                num2 = int.Parse(txtNum2.Text)
            };

            // Serialize the object to JSON string
            string jsonData = JsonConvert.SerializeObject(requestData);

            // Create StringContent with JSON data
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Make the API call to Add method of CalculateAPIController
            HttpResponseMessage response = client.PostAsync("api/CalculateAPI/Mul", content).Result;

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                // For example, read response content if needed
                var resultContent = response.Content.ReadAsStringAsync().Result;
                dynamic resultObject = JObject.Parse(resultContent);
                txtResult.Text = resultObject.value;

            }
            else
            {
                // Handle unsuccessful response
                // For example, log error or show error message to user
            }
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = baseAddress;
            // Create an anonymous object to hold num1 and num2 values
            var requestData = new
            {
                num1 = int.Parse(txtNum1.Text),
                num2 = int.Parse(txtNum2.Text)
            };

            // Serialize the object to JSON string
            string jsonData = JsonConvert.SerializeObject(requestData);

            // Create StringContent with JSON data
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Make the API call to Add method of CalculateAPIController
            HttpResponseMessage response = client.PostAsync("api/CalculateAPI/Div", content).Result;

            if (response.IsSuccessStatusCode)
            {
                // Handle successful response
                // For example, read response content if needed
                var resultContent = response.Content.ReadAsStringAsync().Result;
                dynamic resultObject = JObject.Parse(resultContent);
                txtResult.Text = resultObject.value;

            }
            else
            {
                // Handle unsuccessful response
                // For example, log error or show error message to user
            }
        }
    }
}