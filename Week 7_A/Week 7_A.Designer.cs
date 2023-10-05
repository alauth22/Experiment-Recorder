
namespace Week_7_A
{
    partial class frmScienceExperiment
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblExpNum = new System.Windows.Forms.Label();
            this.lblExpDescription = new System.Windows.Forms.Label();
            this.lblResultWeight = new System.Windows.Forms.Label();
            this.lblResultVolume = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtExpNum = new System.Windows.Forms.TextBox();
            this.txtExpDescr = new System.Windows.Forms.TextBox();
            this.txtResultWeight = new System.Windows.Forms.TextBox();
            this.txtResultVolume = new System.Windows.Forms.TextBox();
            this.lblExperimentSummary = new System.Windows.Forms.Label();
            this.lbxSummaries = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkCrimson = new System.Windows.Forms.CheckBox();
            this.lblColorChoices = new System.Windows.Forms.Label();
            this.chkAzure = new System.Windows.Forms.CheckBox();
            this.chkTaupe = new System.Windows.Forms.CheckBox();
            this.chkMauve = new System.Windows.Forms.CheckBox();
            this.chkVermillion = new System.Windows.Forms.CheckBox();
            this.chkChartreuse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(50, 313);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(70, 32);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 313);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(127, 313);
            this.btnSet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(70, 32);
            this.btnSet.TabIndex = 19;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(45, 23);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(78, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblExpNum
            // 
            this.lblExpNum.AutoSize = true;
            this.lblExpNum.Location = new System.Drawing.Point(18, 49);
            this.lblExpNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpNum.Name = "lblExpNum";
            this.lblExpNum.Size = new System.Drawing.Size(102, 13);
            this.lblExpNum.TabIndex = 3;
            this.lblExpNum.Text = "Experiment Number:";
            // 
            // lblExpDescription
            // 
            this.lblExpDescription.AutoSize = true;
            this.lblExpDescription.Location = new System.Drawing.Point(18, 74);
            this.lblExpDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpDescription.Name = "lblExpDescription";
            this.lblExpDescription.Size = new System.Drawing.Size(118, 13);
            this.lblExpDescription.TabIndex = 5;
            this.lblExpDescription.Text = "Experiment Description:";
            // 
            // lblResultWeight
            // 
            this.lblResultWeight.AutoSize = true;
            this.lblResultWeight.Location = new System.Drawing.Point(13, 277);
            this.lblResultWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultWeight.Name = "lblResultWeight";
            this.lblResultWeight.Size = new System.Drawing.Size(77, 13);
            this.lblResultWeight.TabIndex = 14;
            this.lblResultWeight.Text = "Result Weight:";
            // 
            // lblResultVolume
            // 
            this.lblResultVolume.AutoSize = true;
            this.lblResultVolume.Location = new System.Drawing.Point(165, 277);
            this.lblResultVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultVolume.Name = "lblResultVolume";
            this.lblResultVolume.Size = new System.Drawing.Size(78, 13);
            this.lblResultVolume.TabIndex = 16;
            this.lblResultVolume.Text = "Result Volume:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(125, 20);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(52, 20);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtExpNum
            // 
            this.txtExpNum.Location = new System.Drawing.Point(125, 49);
            this.txtExpNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpNum.Name = "txtExpNum";
            this.txtExpNum.Size = new System.Drawing.Size(52, 20);
            this.txtExpNum.TabIndex = 4;
            // 
            // txtExpDescr
            // 
            this.txtExpDescr.Location = new System.Drawing.Point(21, 88);
            this.txtExpDescr.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpDescr.Multiline = true;
            this.txtExpDescr.Name = "txtExpDescr";
            this.txtExpDescr.Size = new System.Drawing.Size(222, 115);
            this.txtExpDescr.TabIndex = 6;
            // 
            // txtResultWeight
            // 
            this.txtResultWeight.Location = new System.Drawing.Point(94, 274);
            this.txtResultWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultWeight.Name = "txtResultWeight";
            this.txtResultWeight.Size = new System.Drawing.Size(52, 20);
            this.txtResultWeight.TabIndex = 15;
            // 
            // txtResultVolume
            // 
            this.txtResultVolume.Location = new System.Drawing.Point(247, 274);
            this.txtResultVolume.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultVolume.Name = "txtResultVolume";
            this.txtResultVolume.Size = new System.Drawing.Size(52, 20);
            this.txtResultVolume.TabIndex = 17;
            // 
            // lblExperimentSummary
            // 
            this.lblExperimentSummary.AutoSize = true;
            this.lblExperimentSummary.Location = new System.Drawing.Point(273, 23);
            this.lblExperimentSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExperimentSummary.Name = "lblExperimentSummary";
            this.lblExperimentSummary.Size = new System.Drawing.Size(116, 13);
            this.lblExperimentSummary.TabIndex = 23;
            this.lblExperimentSummary.Text = "Experiment Summaries:";
            // 
            // lbxSummaries
            // 
            this.lbxSummaries.FormattingEnabled = true;
            this.lbxSummaries.Location = new System.Drawing.Point(276, 43);
            this.lbxSummaries.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSummaries.Name = "lbxSummaries";
            this.lbxSummaries.Size = new System.Drawing.Size(208, 160);
            this.lbxSummaries.TabIndex = 24;
            this.lbxSummaries.DoubleClick += new System.EventHandler(this.lbxSummaries_DoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 313);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 32);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(364, 313);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 32);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkCrimson
            // 
            this.chkCrimson.AutoSize = true;
            this.chkCrimson.Location = new System.Drawing.Point(21, 243);
            this.chkCrimson.Margin = new System.Windows.Forms.Padding(2);
            this.chkCrimson.Name = "chkCrimson";
            this.chkCrimson.Size = new System.Drawing.Size(63, 17);
            this.chkCrimson.TabIndex = 8;
            this.chkCrimson.Text = "Crimson";
            this.chkCrimson.UseVisualStyleBackColor = true;
            // 
            // lblColorChoices
            // 
            this.lblColorChoices.AutoSize = true;
            this.lblColorChoices.Location = new System.Drawing.Point(20, 215);
            this.lblColorChoices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorChoices.Name = "lblColorChoices";
            this.lblColorChoices.Size = new System.Drawing.Size(67, 13);
            this.lblColorChoices.TabIndex = 7;
            this.lblColorChoices.Text = "Result Color:";
            // 
            // chkAzure
            // 
            this.chkAzure.AutoSize = true;
            this.chkAzure.Location = new System.Drawing.Point(86, 243);
            this.chkAzure.Margin = new System.Windows.Forms.Padding(2);
            this.chkAzure.Name = "chkAzure";
            this.chkAzure.Size = new System.Drawing.Size(53, 17);
            this.chkAzure.TabIndex = 9;
            this.chkAzure.Text = "Azure";
            this.chkAzure.UseVisualStyleBackColor = true;
            // 
            // chkTaupe
            // 
            this.chkTaupe.AutoSize = true;
            this.chkTaupe.Location = new System.Drawing.Point(138, 243);
            this.chkTaupe.Margin = new System.Windows.Forms.Padding(2);
            this.chkTaupe.Name = "chkTaupe";
            this.chkTaupe.Size = new System.Drawing.Size(57, 17);
            this.chkTaupe.TabIndex = 10;
            this.chkTaupe.Text = "Taupe";
            this.chkTaupe.UseVisualStyleBackColor = true;
            // 
            // chkMauve
            // 
            this.chkMauve.AutoSize = true;
            this.chkMauve.Location = new System.Drawing.Point(194, 243);
            this.chkMauve.Margin = new System.Windows.Forms.Padding(2);
            this.chkMauve.Name = "chkMauve";
            this.chkMauve.Size = new System.Drawing.Size(59, 17);
            this.chkMauve.TabIndex = 11;
            this.chkMauve.Text = "Mauve";
            this.chkMauve.UseVisualStyleBackColor = true;
            // 
            // chkVermillion
            // 
            this.chkVermillion.AutoSize = true;
            this.chkVermillion.Location = new System.Drawing.Point(252, 243);
            this.chkVermillion.Margin = new System.Windows.Forms.Padding(2);
            this.chkVermillion.Name = "chkVermillion";
            this.chkVermillion.Size = new System.Drawing.Size(70, 17);
            this.chkVermillion.TabIndex = 12;
            this.chkVermillion.Text = "Vermillion";
            this.chkVermillion.UseVisualStyleBackColor = true;
            // 
            // chkChartreuse
            // 
            this.chkChartreuse.AutoSize = true;
            this.chkChartreuse.Location = new System.Drawing.Point(324, 243);
            this.chkChartreuse.Margin = new System.Windows.Forms.Padding(2);
            this.chkChartreuse.Name = "chkChartreuse";
            this.chkChartreuse.Size = new System.Drawing.Size(77, 17);
            this.chkChartreuse.TabIndex = 13;
            this.chkChartreuse.Text = "Chartreuse";
            this.chkChartreuse.UseVisualStyleBackColor = true;
            // 
            // frmScienceExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 356);
            this.Controls.Add(this.chkChartreuse);
            this.Controls.Add(this.chkVermillion);
            this.Controls.Add(this.chkMauve);
            this.Controls.Add(this.chkTaupe);
            this.Controls.Add(this.chkAzure);
            this.Controls.Add(this.lblColorChoices);
            this.Controls.Add(this.chkCrimson);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbxSummaries);
            this.Controls.Add(this.lblExperimentSummary);
            this.Controls.Add(this.txtResultVolume);
            this.Controls.Add(this.txtResultWeight);
            this.Controls.Add(this.txtExpDescr);
            this.Controls.Add(this.txtExpNum);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblResultVolume);
            this.Controls.Add(this.lblResultWeight);
            this.Controls.Add(this.lblExpDescription);
            this.Controls.Add(this.lblExpNum);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmScienceExperiment";
            this.Text = "Science Experiments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblExpNum;
        private System.Windows.Forms.Label lblExpDescription;
        private System.Windows.Forms.Label lblResultWeight;
        private System.Windows.Forms.Label lblResultVolume;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtExpNum;
        private System.Windows.Forms.TextBox txtExpDescr;
        private System.Windows.Forms.TextBox txtResultWeight;
        private System.Windows.Forms.TextBox txtResultVolume;
        private System.Windows.Forms.Label lblExperimentSummary;
        private System.Windows.Forms.ListBox lbxSummaries;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkCrimson;
        private System.Windows.Forms.Label lblColorChoices;
        private System.Windows.Forms.CheckBox chkAzure;
        private System.Windows.Forms.CheckBox chkTaupe;
        private System.Windows.Forms.CheckBox chkMauve;
        private System.Windows.Forms.CheckBox chkVermillion;
        private System.Windows.Forms.CheckBox chkChartreuse;
    }
}

