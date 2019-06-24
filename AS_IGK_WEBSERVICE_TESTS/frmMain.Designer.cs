namespace AS_IGK_WEBSERVICE_TESTS
{
    partial class frmMain
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
            this.btnUserCheck = new System.Windows.Forms.Button();
            this.btnSaveClientCardByTCKN = new System.Windows.Forms.Button();
            this.btnGetPayPlanList = new System.Windows.Forms.Button();
            this.btnGetClientCardListByTCKN = new System.Windows.Forms.Button();
            this.btnSaveSalesOrder = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnGetInstallmentsListByTCKNForIGKProject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserCheck
            // 
            this.btnUserCheck.Location = new System.Drawing.Point(48, 69);
            this.btnUserCheck.Name = "btnUserCheck";
            this.btnUserCheck.Size = new System.Drawing.Size(75, 23);
            this.btnUserCheck.TabIndex = 0;
            this.btnUserCheck.Text = "UserCheck";
            this.btnUserCheck.UseVisualStyleBackColor = true;
            this.btnUserCheck.Click += new System.EventHandler(this.btnUserCheck_Click);
            // 
            // btnSaveClientCardByTCKN
            // 
            this.btnSaveClientCardByTCKN.Location = new System.Drawing.Point(220, 157);
            this.btnSaveClientCardByTCKN.Name = "btnSaveClientCardByTCKN";
            this.btnSaveClientCardByTCKN.Size = new System.Drawing.Size(152, 23);
            this.btnSaveClientCardByTCKN.TabIndex = 1;
            this.btnSaveClientCardByTCKN.Text = "SaveClientCardByTCKN";
            this.btnSaveClientCardByTCKN.UseVisualStyleBackColor = true;
            this.btnSaveClientCardByTCKN.Click += new System.EventHandler(this.btnSaveClientCardByTCKN_Click);
            // 
            // btnGetPayPlanList
            // 
            this.btnGetPayPlanList.Location = new System.Drawing.Point(48, 113);
            this.btnGetPayPlanList.Name = "btnGetPayPlanList";
            this.btnGetPayPlanList.Size = new System.Drawing.Size(152, 23);
            this.btnGetPayPlanList.TabIndex = 2;
            this.btnGetPayPlanList.Text = "GetPayPlanList";
            this.btnGetPayPlanList.UseVisualStyleBackColor = true;
            this.btnGetPayPlanList.Click += new System.EventHandler(this.btnGetPayPlanList_Click);
            // 
            // btnGetClientCardListByTCKN
            // 
            this.btnGetClientCardListByTCKN.Location = new System.Drawing.Point(48, 157);
            this.btnGetClientCardListByTCKN.Name = "btnGetClientCardListByTCKN";
            this.btnGetClientCardListByTCKN.Size = new System.Drawing.Size(152, 23);
            this.btnGetClientCardListByTCKN.TabIndex = 3;
            this.btnGetClientCardListByTCKN.Text = "GetClientCardListByTCKN";
            this.btnGetClientCardListByTCKN.UseVisualStyleBackColor = true;
            this.btnGetClientCardListByTCKN.Click += new System.EventHandler(this.btnGetClientCardListByTCKN_Click);
            // 
            // btnSaveSalesOrder
            // 
            this.btnSaveSalesOrder.Location = new System.Drawing.Point(48, 203);
            this.btnSaveSalesOrder.Name = "btnSaveSalesOrder";
            this.btnSaveSalesOrder.Size = new System.Drawing.Size(152, 23);
            this.btnSaveSalesOrder.TabIndex = 4;
            this.btnSaveSalesOrder.Text = "SaveSalesOrder";
            this.btnSaveSalesOrder.UseVisualStyleBackColor = true;
            this.btnSaveSalesOrder.Click += new System.EventHandler(this.btnSaveSalesOrder_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(397, 246);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(519, 305);
            this.txtStatus.TabIndex = 5;
            // 
            // btnGetInstallmentsListByTCKNForIGKProject
            // 
            this.btnGetInstallmentsListByTCKNForIGKProject.Location = new System.Drawing.Point(48, 246);
            this.btnGetInstallmentsListByTCKNForIGKProject.Name = "btnGetInstallmentsListByTCKNForIGKProject";
            this.btnGetInstallmentsListByTCKNForIGKProject.Size = new System.Drawing.Size(223, 23);
            this.btnGetInstallmentsListByTCKNForIGKProject.TabIndex = 6;
            this.btnGetInstallmentsListByTCKNForIGKProject.Text = "GetInstallmentsListByTCKNForIGKProject";
            this.btnGetInstallmentsListByTCKNForIGKProject.UseVisualStyleBackColor = true;
            this.btnGetInstallmentsListByTCKNForIGKProject.Click += new System.EventHandler(this.btnGetInstallmentsListByTCKNForIGKProject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 214);
            this.dataGridView1.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetInstallmentsListByTCKNForIGKProject);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSaveSalesOrder);
            this.Controls.Add(this.btnGetClientCardListByTCKN);
            this.Controls.Add(this.btnGetPayPlanList);
            this.Controls.Add(this.btnSaveClientCardByTCKN);
            this.Controls.Add(this.btnUserCheck);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserCheck;
        private System.Windows.Forms.Button btnSaveClientCardByTCKN;
        private System.Windows.Forms.Button btnGetPayPlanList;
        private System.Windows.Forms.Button btnGetClientCardListByTCKN;
        private System.Windows.Forms.Button btnSaveSalesOrder;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnGetInstallmentsListByTCKNForIGKProject;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

