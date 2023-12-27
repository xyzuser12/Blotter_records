
namespace Blotter_records
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            dateTimePickerDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            descriptionTextBox = new TextBox();
            label4 = new Label();
            personTextBox = new TextBox();
            CreateRecordButton = new Button();
            dateTimePickerTime = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 30);
            label1.Name = "label1";
            label1.Size = new Size(403, 41);
            label1.TabIndex = 0;
            label1.Text = "E-Barangay Blotter Records";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CustomFormat = "MM/dd/yyyy";
            dateTimePickerDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new Point(55, 119);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(1014, 27);
            dateTimePickerDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 96);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 2;
            label2.Text = "Date of Creation: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 239);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 3;
            label3.Text = "Record Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(55, 272);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Insert record description";
            descriptionTextBox.ScrollBars = ScrollBars.Both;
            descriptionTextBox.Size = new Size(1015, 322);
            descriptionTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 612);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 5;
            label4.Text = "Noted by: ";
            // 
            // personTextBox
            // 
            personTextBox.Location = new Point(55, 635);
            personTextBox.Name = "personTextBox";
            personTextBox.PlaceholderText = "Insert your full name";
            personTextBox.Size = new Size(1015, 27);
            personTextBox.TabIndex = 6;
            // 
            // CreateRecordButton
            // 
            CreateRecordButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateRecordButton.Location = new Point(423, 693);
            CreateRecordButton.Name = "CreateRecordButton";
            CreateRecordButton.Size = new Size(293, 67);
            CreateRecordButton.TabIndex = 7;
            CreateRecordButton.Text = "Create Blotter Record";
            CreateRecordButton.UseVisualStyleBackColor = true;
            CreateRecordButton.Click += CreateRecordButton_Click;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.CustomFormat = "hh:mm tt";
            dateTimePickerTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerTime.Location = new Point(55, 195);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Size = new Size(1014, 27);
            dateTimePickerTime.TabIndex = 8;
            dateTimePickerTime.Value = new DateTime(2023, 11, 25, 17, 38, 49, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 172);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 9;
            label5.Text = "Time of Creation: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1134, 785);
            Controls.Add(label5);
            Controls.Add(dateTimePickerTime);
            Controls.Add(label1);
            Controls.Add(CreateRecordButton);
            Controls.Add(personTextBox);
            Controls.Add(label4);
            Controls.Add(descriptionTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerDate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "e-Barangay Application";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerDate;
        private Label label2;
        private Label label3;
        private TextBox descriptionTextBox;
        private Label label4;
        private TextBox personTextBox;
        private Button CreateRecordButton;
        private DateTimePicker dateTimePickerTime;
        private Label label5;

        public EventHandler Form1_Load { get; private set; }
    }
}
