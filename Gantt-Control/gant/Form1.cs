using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGantt;
using Newtonsoft.Json;
namespace gant
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ganttControl1.TreeListMappings.KeyFieldName = "Id";
            ganttControl1.TreeListMappings.ParentFieldName = "ParentId";
            ganttControl1.ChartMappings.TextFieldName = "Name";
            ganttControl1.ChartMappings.StartDateFieldName = "StartDate";
            ganttControl1.ChartMappings.FinishDateFieldName = "FinishDate";
            ganttControl1.ChartMappings.DurationFieldName = "Duration";
            ganttControl1.ChartMappings.PredecessorsFieldName = "Predecessors";
            ganttControl1.ChartMappings.ProgressFieldName = "Progress";
            ganttControl1.DataSource = LoadData();
            //bu kısım taskları hareket ettirebilmek icin olusturulmustur.
            ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.True;
            ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True;
            ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.True;
            
        }

        public class StringToTimeSpanConverter : JsonConverter<TimeSpan>
        {
            public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return TimeSpan.Parse((string)reader.Value);
            }

            public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
            {
                writer.WriteValue(value.ToString());
            }
        }
        private Task[] LoadData()
        {
            if (File.Exists("tasks.json"))
            {
                try
                {
                    StreamReader file = new StreamReader("tasks.json");

                         string json = file.ReadToEnd().ToString();
                      
                        Task[] tasks = JsonConvert.DeserializeObject<Task[]>(json, new JsonSerializerSettings
                        {
                            Converters = new List<JsonConverter> { new StringToTimeSpanConverter() }
                        });
                        return tasks;
                    
                }
                catch (Exception exc)
                {
                    Console.WriteLine("An error occurred while reading the file: " + exc.Message);
                    return CreateDefaultData();
                }
            }
            else
            {
                return CreateDefaultData();
            }
        }


        private Task[] CreateDefaultData()
        {

            Task[] tasks = new Task[]
            {
                //Yazılım gelistirme plani
                new Task("Yazılım Geliştirme", 0, -1, DateTime.Now, TimeSpan.FromDays(1), 24),
                new Task("Analiz Yapma", 1, 0, DateTime.Now, TimeSpan.FromDays(2), 200),
                new Task("Yazılım Testi Yapma", 2, 0, DateTime.Now.AddDays(2), TimeSpan.FromDays(3), 250, 2),
                new Task("Yazılım Kodlama", 3, 0, DateTime.Now.AddDays(5), TimeSpan.FromDays(5), 40, 2),
                new Task("Yazımının Bakımını Yapma", 4, 0, DateTime.Now.AddDays(5), TimeSpan.FromDays(1), 90, 2),
                new Task("Stajyerleri Denetleme", 5, 0, DateTime.Now.AddDays(6), TimeSpan.FromDays(1), 5, 2),
                new Task("Geri Bildirim Gönderme", 6, 0, DateTime.Now.AddDays(7), TimeSpan.FromDays(3), 5, 2),
                new Task("Hataları Temizleme", 7, 0, DateTime.Now.AddDays(9), TimeSpan.FromDays(3), 5, 2),
                new Task("Görünümü Düzenleme", 8, 0, DateTime.Now.AddDays(11), TimeSpan.FromDays(3), 5, 2),
                new Task("Proje Bitiminde Çalışanları Ödüllendirmek", 9, 0, DateTime.Now.AddDays(14), TimeSpan.FromDays(1), 0, 2),
                //inglizce ogrenme plani
                new Task("İnglizce Öğrenme", 10, -1, DateTime.Now, TimeSpan.FromDays(1), 24),
                new Task("Pratik Yapma", 11, 10, DateTime.Now, TimeSpan.FromDays(1), 100),
                new Task("Kursa Gitme", 12, 10, DateTime.Now.AddDays(1), TimeSpan.FromDays(7), 100, 11),
                new Task("Test Çözme", 13, 10, DateTime.Now.AddDays(7), TimeSpan.FromDays(9), 89, 11),
                new Task("Sınava Çalışma", 14, 10, DateTime.Now.AddDays(9), TimeSpan.FromDays(11), 50, 11),
                new Task("İngiltere'ye Taşınma", 15, 10, DateTime.Now.AddDays(20), TimeSpan.FromDays(15), 75, 4),
            };

            Task softwareDevelopment = tasks[0];
            softwareDevelopment.FinishDate = tasks[9].FinishDate;
            tasks[10].FinishDate = tasks[15].FinishDate;

            return tasks;
        }
        public class Task
        {
            public Task(string name, int id, int parentId, DateTime start, TimeSpan duration, double progress, params int[] predecessors)
            {
                Name = name;
                Id = id;
                ParentId = parentId;
                StartDate = start;
                Duration = duration;
                FinishDate = start + Duration;
                Progress = progress;
                Predecessors = new BindingList<int>();
                foreach (int predecessor in predecessors)
                {
                    Predecessors.Add(predecessor);
                }
            }


            public int Id { get; set; }
            public int ParentId { get; set; }
            public BindingList<int> Predecessors { get; private set; }
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime FinishDate { get; set; }
            public TimeSpan Duration { get; set; }
            public double Progress { get; set; }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Task[] tasks = ganttControl1.DataSource as Task[];

            try
            {
                using (StreamWriter file = new StreamWriter("tasks.json"))
                {
                    string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                    file.WriteLine(json);
                }

                MessageBox.Show("Veriler Güncellenmistir!");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Hata Olustu: " + exc.Message);
                MessageBox.Show("Veri Güncellenirken Hata Olustu.");
            }
        }
    }
}


