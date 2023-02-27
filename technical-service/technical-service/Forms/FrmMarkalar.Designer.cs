
namespace technical_service.Forms
{
    partial class FrmMarkalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView2 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToplamUrun = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToplamMarkaSayisi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEnFazlaUrunuOlanMarka = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEnYuksekFiyatliMarka = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(580, 619);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(164)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.lblToplamUrun);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(586, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 154);
            this.panel1.TabIndex = 4;
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUrun.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblToplamUrun.Appearance.Options.UseFont = true;
            this.lblToplamUrun.Appearance.Options.UseForeColor = true;
            this.lblToplamUrun.Location = new System.Drawing.Point(24, 54);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(76, 45);
            this.lblToplamUrun.TabIndex = 1;
            this.lblToplamUrun.Text = "5656";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Toplam Ürün Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(204)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.lblToplamMarkaSayisi);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Location = new System.Drawing.Point(828, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 154);
            this.panel2.TabIndex = 5;
            // 
            // lblToplamMarkaSayisi
            // 
            this.lblToplamMarkaSayisi.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMarkaSayisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblToplamMarkaSayisi.Appearance.Options.UseFont = true;
            this.lblToplamMarkaSayisi.Appearance.Options.UseForeColor = true;
            this.lblToplamMarkaSayisi.Location = new System.Drawing.Point(24, 54);
            this.lblToplamMarkaSayisi.Name = "lblToplamMarkaSayisi";
            this.lblToplamMarkaSayisi.Size = new System.Drawing.Size(76, 45);
            this.lblToplamMarkaSayisi.TabIndex = 1;
            this.lblToplamMarkaSayisi.Text = "5656";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(155, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Toplam Marka Sayısı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.panel3.Controls.Add(this.lblEnFazlaUrunuOlanMarka);
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Location = new System.Drawing.Point(1059, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 154);
            this.panel3.TabIndex = 5;
            // 
            // lblEnFazlaUrunuOlanMarka
            // 
            this.lblEnFazlaUrunuOlanMarka.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnFazlaUrunuOlanMarka.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEnFazlaUrunuOlanMarka.Appearance.Options.UseFont = true;
            this.lblEnFazlaUrunuOlanMarka.Appearance.Options.UseForeColor = true;
            this.lblEnFazlaUrunuOlanMarka.Location = new System.Drawing.Point(24, 54);
            this.lblEnFazlaUrunuOlanMarka.Name = "lblEnFazlaUrunuOlanMarka";
            this.lblEnFazlaUrunuOlanMarka.Size = new System.Drawing.Size(107, 45);
            this.lblEnFazlaUrunuOlanMarka.TabIndex = 1;
            this.lblEnFazlaUrunuOlanMarka.Text = "Arçelik";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(24, 25);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(205, 23);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "En Fazla Ürünü olan Marka";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(211)))), ((int)(((byte)(200)))));
            this.panel4.Controls.Add(this.lblEnYuksekFiyatliMarka);
            this.panel4.Controls.Add(this.labelControl7);
            this.panel4.Location = new System.Drawing.Point(1297, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 154);
            this.panel4.TabIndex = 5;
            // 
            // lblEnYuksekFiyatliMarka
            // 
            this.lblEnYuksekFiyatliMarka.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnYuksekFiyatliMarka.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEnYuksekFiyatliMarka.Appearance.Options.UseFont = true;
            this.lblEnYuksekFiyatliMarka.Appearance.Options.UseForeColor = true;
            this.lblEnYuksekFiyatliMarka.Location = new System.Drawing.Point(24, 54);
            this.lblEnYuksekFiyatliMarka.Name = "lblEnYuksekFiyatliMarka";
            this.lblEnYuksekFiyatliMarka.Size = new System.Drawing.Size(90, 45);
            this.lblEnYuksekFiyatliMarka.TabIndex = 1;
            this.lblEnYuksekFiyatliMarka.Text = "Apple";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(24, 25);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(175, 23);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "En Yüksek Fiyatlı Marka";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.chartControl1);
            this.panelControl1.Location = new System.Drawing.Point(586, 182);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(467, 439);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(187, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Marka ve İstatistikler";
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(1, 44);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Office 2013";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(467, 405);
            this.chartControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Location = new System.Drawing.Point(1059, 182);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(467, 439);
            this.panelControl2.TabIndex = 7;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Controls.Add(this.chartControl2);
            this.panelControl4.Location = new System.Drawing.Point(5, 5);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(467, 439);
            this.panelControl4.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(196, 24);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Ürünler ve Kategoriler";
            // 
            // chartControl2
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(2, 39);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PaletteName = "Office 2013";
            series2.Name = "Kategoriler";
            series2.View = stackedBarSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.SeriesTemplate.View = stackedBarSeriesView2;
            this.chartControl2.Size = new System.Drawing.Size(376, 390);
            this.chartControl2.TabIndex = 0;
            // 
            // FrmMarkalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 643);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMarkalar";
            this.Text = "FrmMarkalar";
            this.Load += new System.EventHandler(this.FrmMarkalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblToplamUrun;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblToplamMarkaSayisi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblEnFazlaUrunuOlanMarka;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblEnYuksekFiyatliMarka;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}