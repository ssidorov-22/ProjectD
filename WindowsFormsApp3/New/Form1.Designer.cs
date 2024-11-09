namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetTicket = new System.Windows.Forms.Button();
            this.btnServeCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.Location = new System.Drawing.Point(89, 238);
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Size = new System.Drawing.Size(103, 23);
            this.btnGetTicket.TabIndex = 0;
            this.btnGetTicket.Text = "Получить талон";
            this.btnGetTicket.UseVisualStyleBackColor = true;
            this.btnGetTicket.Click += new System.EventHandler(this.btnGetTicket_Click);
            // 
            // btnServeCustomer
            // 
            this.btnServeCustomer.Location = new System.Drawing.Point(607, 277);
            this.btnServeCustomer.Name = "btnServeCustomer";
            this.btnServeCustomer.Size = new System.Drawing.Size(117, 23);
            this.btnServeCustomer.TabIndex = 7;
            this.btnServeCustomer.Text = "Обслужить клиента";
            this.btnServeCustomer.UseVisualStyleBackColor = true;
            this.btnServeCustomer.Click += new System.EventHandler(this.btnServeCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Терминал получения талонов";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Location = new System.Drawing.Point(540, 138);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(184, 13);
            this.lblCustomerCount.TabIndex = 9;
            this.lblCustomerCount.Text = " Количество клиентов в очереди: 0";
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.Location = new System.Drawing.Point(553, 166);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(120, 95);
            this.listBoxCustomer.TabIndex = 10;
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(80, 211);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServices.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxServices);
            this.Controls.Add(this.listBoxCustomer);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServeCustomer);
            this.Controls.Add(this.btnGetTicket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTicket;
        private System.Windows.Forms.Button btnServeCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxServices;
    }
}

