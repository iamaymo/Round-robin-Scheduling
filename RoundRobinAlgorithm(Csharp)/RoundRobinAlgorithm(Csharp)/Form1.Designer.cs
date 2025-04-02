namespace RoundRobinAlgorithm_Csharp_
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
            this.lblNumProcesses = new System.Windows.Forms.Label();
            this.txtNumProcesses = new System.Windows.Forms.TextBox();
            this.lblBurstTimes = new System.Windows.Forms.Label();
            this.txtBurstTimes = new System.Windows.Forms.TextBox();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dgvCycleLogs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFinalResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCycleLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumProcesses
            // 
            this.lblNumProcesses.Location = new System.Drawing.Point(197, 9);
            this.lblNumProcesses.Name = "lblNumProcesses";
            this.lblNumProcesses.Size = new System.Drawing.Size(158, 23);
            this.lblNumProcesses.TabIndex = 0;
            this.lblNumProcesses.Text = "Number of Processes:";
            // 
            // txtNumProcesses
            // 
            this.txtNumProcesses.Location = new System.Drawing.Point(377, 6);
            this.txtNumProcesses.Name = "txtNumProcesses";
            this.txtNumProcesses.Size = new System.Drawing.Size(136, 27);
            this.txtNumProcesses.TabIndex = 1;
            // 
            // lblBurstTimes
            // 
            this.lblBurstTimes.Location = new System.Drawing.Point(224, 46);
            this.lblBurstTimes.Name = "lblBurstTimes";
            this.lblBurstTimes.Size = new System.Drawing.Size(100, 23);
            this.lblBurstTimes.TabIndex = 2;
            this.lblBurstTimes.Text = "Burst Times:";
            // 
            // txtBurstTimes
            // 
            this.txtBurstTimes.Location = new System.Drawing.Point(377, 46);
            this.txtBurstTimes.Name = "txtBurstTimes";
            this.txtBurstTimes.Size = new System.Drawing.Size(136, 27);
            this.txtBurstTimes.TabIndex = 3;
            // 
            // lblQuantum
            // 
            this.lblQuantum.Location = new System.Drawing.Point(216, 83);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(155, 23);
            this.lblQuantum.TabIndex = 4;
            this.lblQuantum.Text = "Time Quantum:";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(377, 79);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(136, 27);
            this.txtQuantum.TabIndex = 5;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(322, 126);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(86, 28);
            this.btnSchedule.TabIndex = 6;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dgvCycleLogs
            // 
            this.dgvCycleLogs.AllowUserToAddRows = false;
            this.dgvCycleLogs.ColumnHeadersHeight = 29;
            this.dgvCycleLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCycleLogs.Location = new System.Drawing.Point(98, 181);
            this.dgvCycleLogs.Name = "dgvCycleLogs";
            this.dgvCycleLogs.ReadOnly = true;
            this.dgvCycleLogs.RowHeadersWidth = 51;
            this.dgvCycleLogs.Size = new System.Drawing.Size(555, 169);
            this.dgvCycleLogs.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Process";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Executed Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Remaining Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dgvFinalResults
            // 
            this.dgvFinalResults.AllowUserToAddRows = false;
            this.dgvFinalResults.ColumnHeadersHeight = 29;
            this.dgvFinalResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvFinalResults.Location = new System.Drawing.Point(178, 371);
            this.dgvFinalResults.Name = "dgvFinalResults";
            this.dgvFinalResults.ReadOnly = true;
            this.dgvFinalResults.RowHeadersWidth = 51;
            this.dgvFinalResults.Size = new System.Drawing.Size(400, 178);
            this.dgvFinalResults.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Process";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Waiting Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Turnaround Time";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(747, 561);
            this.Controls.Add(this.lblNumProcesses);
            this.Controls.Add(this.txtNumProcesses);
            this.Controls.Add(this.lblBurstTimes);
            this.Controls.Add(this.txtBurstTimes);
            this.Controls.Add(this.lblQuantum);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.dgvCycleLogs);
            this.Controls.Add(this.dgvFinalResults);
            this.Name = "Form1";
            this.Text = "Round Robin Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCycleLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumProcesses;
        private System.Windows.Forms.TextBox txtNumProcesses;
        private System.Windows.Forms.Label lblBurstTimes;
        private System.Windows.Forms.TextBox txtBurstTimes;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DataGridView dgvCycleLogs;
        private System.Windows.Forms.DataGridView dgvFinalResults;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
