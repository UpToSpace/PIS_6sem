using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        string url = "http://localhost:64000/2";
        public Form1()
        {
            InitializeComponent();
        }

        private async void result_button_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsync(url + "?x=" + a.Text + "&y=" + b.Text, null);

            var response_text = response.Content.ReadAsStringAsync();
            result.Text = response_text.Result;
        }
    }
}
