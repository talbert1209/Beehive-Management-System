namespace Beehive_Management_System
{
    partial class Form1
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
            this.nextShift = new System.Windows.Forms.Button();
            this.reportBox = new System.Windows.Forms.TextBox();
            this.workerBeeAssignments = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.assign = new System.Windows.Forms.Button();
            this.workerBeeAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextShift.Location = new System.Drawing.Point(430, 12);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(147, 116);
            this.nextShift.TabIndex = 0;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(13, 134);
            this.reportBox.Multiline = true;
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(564, 185);
            this.reportBox.TabIndex = 1;
            // 
            // workerBeeAssignments
            // 
            this.workerBeeAssignments.Controls.Add(this.label2);
            this.workerBeeAssignments.Controls.Add(this.label1);
            this.workerBeeAssignments.Controls.Add(this.shifts);
            this.workerBeeAssignments.Controls.Add(this.workerBeeJob);
            this.workerBeeAssignments.Controls.Add(this.assign);
            this.workerBeeAssignments.Location = new System.Drawing.Point(13, 12);
            this.workerBeeAssignments.Name = "workerBeeAssignments";
            this.workerBeeAssignments.Size = new System.Drawing.Size(411, 116);
            this.workerBeeAssignments.TabIndex = 2;
            this.workerBeeAssignments.TabStop = false;
            this.workerBeeAssignments.Text = "Worker Bee Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jobs";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(276, 55);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 22);
            this.shifts.TabIndex = 2;
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(17, 53);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(253, 24);
            this.workerBeeJob.TabIndex = 1;
            // 
            // assign
            // 
            this.assign.Location = new System.Drawing.Point(17, 83);
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(379, 28);
            this.assign.TabIndex = 0;
            this.assign.Text = "Assign this job to a bee";
            this.assign.UseVisualStyleBackColor = true;
            this.assign.Click += new System.EventHandler(this.assign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 331);
            this.Controls.Add(this.workerBeeAssignments);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.nextShift);
            this.Name = "Form1";
            this.Text = "Form1";
            this.workerBeeAssignments.ResumeLayout(false);
            this.workerBeeAssignments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.TextBox reportBox;
        private System.Windows.Forms.GroupBox workerBeeAssignments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button assign;
    }
}

