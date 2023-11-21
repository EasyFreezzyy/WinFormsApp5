using WinFormsApp5.Data;
using Newtonsoft.Json;
namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Updategarage();
        }
        public void Updategarage()
        {
            listView1.Items.Clear();
            using DataContext dc = new DataContext();
            var list = dc.garages.ToList();
            foreach (var garage in list)
            {
                listView1.Items.Add(garage.Name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();

            string namegarage = textBox1.Text;
            garages d = new garages() { Name = namegarage };
            dc.garages.Add(d);
            dc.SaveChanges();
            Updategarage();

            MessageBox.Show("Бокс добавлен");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using DataContext cd = new DataContext();
            var listgarage = cd.garages.Select(g=> new { g.Id, g.Name }).ToList();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            
            string path = sfd.FileName;
            string json = JsonConvert.SerializeObject(listgarage, Formatting.Indented);

            using StreamWriter sw = new StreamWriter(path);
            sw.Write(json);
        }
    }
}