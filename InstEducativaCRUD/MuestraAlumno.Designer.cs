namespace InstEducativaCRUD
{
    partial class MuestraAlumno
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet = new InstEducativaCRUD.DataSet();
            this.spObtenerEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ObtenerEstudiantesTableAdapter = new InstEducativaCRUD.DataSetTableAdapters.sp_ObtenerEstudiantesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spObtenerEstudiantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spObtenerEstudiantesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InstEducativaCRUD.ReporteAlumno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spObtenerEstudiantesBindingSource
            // 
            this.spObtenerEstudiantesBindingSource.DataMember = "sp_ObtenerEstudiantes";
            this.spObtenerEstudiantesBindingSource.DataSource = this.dataSet;
            // 
            // sp_ObtenerEstudiantesTableAdapter
            // 
            this.sp_ObtenerEstudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // MuestraAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MuestraAlumno";
            this.Text = "MuestraAlumno";
            this.Load += new System.EventHandler(this.MuestraAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spObtenerEstudiantesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource spObtenerEstudiantesBindingSource;
        private DataSetTableAdapters.sp_ObtenerEstudiantesTableAdapter sp_ObtenerEstudiantesTableAdapter;
    }
}