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
            ganttControl1.DataSource = LoadDataAsArray();
            //bu kısım taskları hareket ettirebilmek icin olusturulmustur.
            ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.True; 
            ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True;
            ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.True;
            Task[] tasks = LoadDataAsArray();

            try//verileri tast.txt ye kaydetme islemi denendi.
            {
                using (StreamWriter file = new StreamWriter("tasks.txt"))
                {
                    string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);//veriler json formatina donusturuldu.
                    file.WriteLine(json);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("An error occurred while writing to the file: " + exc.Message);
            }
        }

        public static Task[] LoadDataAsArray()
        {

            Task[] tasks = new Task[] {
                //Yazılım gelistirme plani
                new Task("Yazılım Geliştirme", 0, -1, DateTime.Now, 1, 24),
                new Task("Analiz Yapma", 1, 0, DateTime.Now, 2, 200),
                new Task("Yazılım Testi Yapma", 2, 0, DateTime.Now.AddDays(2), 3, 250, 2),
                new Task("Yazılım Kodlama", 3, 0, DateTime.Now.AddDays(5), 5, 40, 2),
                new Task("Yazımının Bakımını Yapma", 4, 0, DateTime.Now.AddDays(5), 1, 90, 2),
                new Task("Stajyerleri Denetleme", 5, 0, DateTime.Now.AddDays(6), 1, 5, 2),
                new Task("Geri Bildirim Gönderme", 6, 0, DateTime.Now.AddDays(7), 2, 5, 2),
                new Task("Hataları Temizleme", 7, 0, DateTime.Now.AddDays(9), 2, 5, 2),
                new Task("Görünümü Düzenleme", 8, 0, DateTime.Now.AddDays(11), 3, 5, 2),
                new Task("Proje Bitiminde Çalışanları Ödüllendirmek", 9, 0, DateTime.Now.AddDays(14), 1, 0, 2),
                //inglizce ogrenme plani
                new Task("İnglizce Öğrenme", 10, -1, DateTime.Now, 1, 24),
                new Task("Pratik Yapma", 11, 10, DateTime.Now, 1, 100),
                new Task("Kursa Gitme", 12, 10, DateTime.Now.AddDays(1), 7, 100, 11),
                new Task("Test Çözme", 13, 10, DateTime.Now.AddDays(7), 9, 89, 11),
                new Task("Sınava Çalışma", 14, 10, DateTime.Now.AddDays(9), 11, 50, 11),
                new Task("İngiltere'ye Taşınma", 15, 10, DateTime.Now.AddDays(20), 15, 75, 4),
            };
        
            Task softwareDevelopment = tasks[0];
            softwareDevelopment.FinishDate = tasks[9].FinishDate;
            tasks[10].FinishDate = tasks[15].FinishDate;

            return tasks;
        }
        public class Task
        {
            public Task(string name, int id, int parentId, DateTime start, int duration, double progress, params int[] predecessors)
            {
                Name = name;
                Id = id;
                ParentId = parentId;
                StartDate = start;
                Duration = TimeSpan.FromDays(duration);
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
        public class converToJson
        {
            static Task[] tasks = LoadDataAsArray();

        }

    }
}


