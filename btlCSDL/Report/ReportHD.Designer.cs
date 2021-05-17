namespace btlCSDL.Report
{
     partial class ReportHD
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
               this.qltcDataSet = new btlCSDL.qltcDataSet();
               this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.hOADONTableAdapter = new btlCSDL.qltcDataSetTableAdapters.HOADONTableAdapter();
               ((System.ComponentModel.ISupportInitialize)(this.qltcDataSet)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // reportViewer1
               // 
               this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
               reportDataSource1.Name = "hoadon";
               reportDataSource1.Value = this.hOADONBindingSource;
               this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
               this.reportViewer1.LocalReport.ReportEmbeddedResource = "btlCSDL.UI.QTV.NghiepVu.ReportHD.rdlc";
               this.reportViewer1.Location = new System.Drawing.Point(0, 0);
               this.reportViewer1.Name = "reportViewer1";
               this.reportViewer1.ServerReport.BearerToken = null;
               this.reportViewer1.Size = new System.Drawing.Size(800, 450);
               this.reportViewer1.TabIndex = 0;
               // 
               // qltcDataSet
               // 
               this.qltcDataSet.DataSetName = "qltcDataSet";
               this.qltcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // hOADONBindingSource
               // 
               this.hOADONBindingSource.DataMember = "HOADON";
               this.hOADONBindingSource.DataSource = this.qltcDataSet;
               // 
               // hOADONTableAdapter
               // 
               this.hOADONTableAdapter.ClearBeforeFill = true;
               // 
               // ReportHD
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.reportViewer1);
               this.Name = "ReportHD";
               this.Text = "ReportHD";
               this.Load += new System.EventHandler(this.ReportHD_Load);
               ((System.ComponentModel.ISupportInitialize)(this.qltcDataSet)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
          private qltcDataSet qltcDataSet;
          private System.Windows.Forms.BindingSource hOADONBindingSource;
          private qltcDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
     }
}