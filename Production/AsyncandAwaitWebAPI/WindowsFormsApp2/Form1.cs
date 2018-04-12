using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int time = 0;
        public Form1()
        {
            InitializeComponent();
            start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0)
            {
                time++;
                textBox1.Text = time + "Seconds";
            }
        }
        public void start()
        {
            time = 0;
            timer1.Start();
        }
        private async void GetStudents_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = "Error Message";
            string url = "http://localhost:53864/api/values/";
            string requestheader = "application/json";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(requestheader));
            var response = await client.GetAsync("GetStudents");
            string res = await response.Content.ReadAsStringAsync();
            List<Student> deserializedProduct = JsonConvert.DeserializeObject<List<Student>>(res);
            foreach (Student s1 in deserializedProduct)
            {
                listBox1.Items.Add(s1.StudentId + " " + s1.StudentName);
            }
        }
        private async void GetStudentsbyID_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = "";
            int id = Convert.ToInt32(textBox3.Text);
            if (id > 0)
            {
                string url = "http://localhost:53864/api/values/";
                string requestheader = "application/json";
                var client = new HttpClient();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(requestheader));
                var response = await client.GetAsync("GetStudentByid/" + id);
                string result = await response.Content.ReadAsStringAsync();
                Student res = JsonConvert.DeserializeObject<Student>(result.Trim('[', ']'));
                listBox1.Items.Add(res.StudentId + " " + res.StudentName);
            }
            else
            {
                label3.Text = "Enter correct Group id";
            }
        }
        private async void GetGroups_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = "Error Message";
            string url = "http://localhost:53864/api/values/";
            string requestheader = "application/json";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(requestheader));
            var response = await client.GetAsync("GetGroups");
            string res = await response.Content.ReadAsStringAsync();
            List<Group> deserializedProduct = JsonConvert.DeserializeObject<List<Group>>(res);
            foreach (Group s1 in deserializedProduct)
            {
                listBox1.Items.Add(s1.GroupId + " " + s1.GroupName);
            }
        }
        private async void GetGroupbyID_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = "";
            int id = Convert.ToInt32(textBox3.Text);
            if (id > 0)
            {
                string url = "http://localhost:53864/api/values/";
                string requestheader = "application/json";
                var client = new HttpClient();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(requestheader));
                var response = await client.GetAsync("GetGroupByid/" + id);
                string result = await response.Content.ReadAsStringAsync();
                Group res = JsonConvert.DeserializeObject<Group>(result.Trim('[', ']'));
                listBox1.Items.Add(res.GroupId + " " + res.GroupName);
            }
            else
            {
                label3.Text = "Enter correct Group id";
            }
        }
    }
}
