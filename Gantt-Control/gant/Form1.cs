using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGantt;

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

        public static List<Task> LoadData()
        {
            var tasks = new List<Task>();
            Task softwareDevelopment = new Task("Yazılım Geliştirme", 0, -1, DateTime.Now, 1, 24);
            Task analyseRequirements = new Task("Analiz Yapma", 1, softwareDevelopment.Id, softwareDevelopment.StartDate, 2, 200);
            Task developTesting = new Task("Yazılım Testi Yapma", 2, softwareDevelopment.Id, analyseRequirements.FinishDate, 3, 250, 2);
            Task developSoftware = new Task("Yazılım Kodlama", 3, softwareDevelopment.Id, developTesting.FinishDate, 5, 40, developTesting.Id);
            Task softwareMaintenance = new Task("Yazımının Bakımını Yapma", 4, softwareDevelopment.Id, developTesting.FinishDate, 1, 90, developTesting.Id);
            Task supervisingInterns = new Task("Stajyerleri Denetleme", 5, softwareDevelopment.Id, softwareMaintenance.FinishDate, 1, 0, softwareMaintenance.Id);
            Task sentFeedback = new Task("Geri Bildirim Gönderme", 6, softwareDevelopment.Id, supervisingInterns.FinishDate, 2, 0, supervisingInterns.Id);
            Task fixBugs = new Task("Hataları Temizleme", 7, softwareDevelopment.Id, sentFeedback.FinishDate, 2, 0, sentFeedback.Id);
            Task developFrontend = new Task("Görünümü Düzenleme", 8, softwareDevelopment.Id, fixBugs.FinishDate, 3, 0, fixBugs.Id);
            Task rewardTeam= new Task("Proje Bitiminde Çalışanları Ödüllendirmek", 9, softwareDevelopment.Id, developFrontend.FinishDate, 0, 0, developFrontend.Id);
            softwareDevelopment.FinishDate = rewardTeam.FinishDate;
            tasks.AddRange(new Task[] {softwareDevelopment, analyseRequirements, developTesting, developSoftware, softwareMaintenance, supervisingInterns,
            sentFeedback,fixBugs,developFrontend, rewardTeam });
            


            Task learnEnglish = new Task("İnglizce Öğrenme", 10, -1, DateTime.Now, 1, 24);
            Task makePractise = new Task("Pratik Yapma", 11, learnEnglish.Id, softwareDevelopment.StartDate, 1, 100);
            Task goCourse = new Task("Kursa Gitme", 12, learnEnglish.Id, analyseRequirements.FinishDate, 7, 100, 1);
            Task solveTest = new Task("Test Çözme", 13, learnEnglish.Id, developTesting.FinishDate, 9, 89, developTesting.Id);
            Task studyExam = new Task("Sınava Çalışma", 14, learnEnglish.Id, developTesting.FinishDate, 11, 50, developTesting.Id);
            Task movintoEngland = new Task("İngiltere'ye Taşınma", 15, learnEnglish.Id, studyExam.FinishDate, 15, 75, softwareMaintenance.Id);
            learnEnglish.FinishDate = movintoEngland.FinishDate;
            tasks.AddRange(new Task[] {learnEnglish, makePractise,goCourse,solveTest,studyExam, movintoEngland });
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

    }
}


