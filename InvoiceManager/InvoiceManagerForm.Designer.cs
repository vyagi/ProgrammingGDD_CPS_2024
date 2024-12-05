namespace InvoiceManager
{
    partial class InvoiceManagerForm
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
            readButton = new Button();
            pathTextBox = new TextBox();
            pathLabel = new Label();
            resultTextBox = new TextBox();
            categoryButton = new Button();
            byMonthButton = new Button();
            openButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // readButton
            // 
            readButton.Location = new Point(12, 60);
            readButton.Name = "readButton";
            readButton.Size = new Size(80, 23);
            readButton.TabIndex = 0;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new Point(78, 20);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(361, 23);
            pathTextBox.TabIndex = 1;
            pathTextBox.Text = "C:\\Users\\mjagiela\\Desktop\\Invoices.txt";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(12, 23);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(31, 15);
            pathLabel.TabIndex = 2;
            pathLabel.Text = "Path";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 100);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(511, 338);
            resultTextBox.TabIndex = 3;
            // 
            // categoryButton
            // 
            categoryButton.Location = new Point(98, 60);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(80, 23);
            categoryButton.TabIndex = 4;
            categoryButton.Text = "By category";
            categoryButton.UseVisualStyleBackColor = true;
            categoryButton.Click += categoryButton_Click;
            // 
            // byMonthButton
            // 
            byMonthButton.Location = new Point(184, 60);
            byMonthButton.Name = "byMonthButton";
            byMonthButton.Size = new Size(80, 23);
            byMonthButton.TabIndex = 5;
            byMonthButton.Text = "By month";
            byMonthButton.UseVisualStyleBackColor = true;
            byMonthButton.Click += byMonthButton_Click;
            // 
            // openButton
            // 
            openButton.Location = new Point(445, 20);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 6;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(445, 60);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // InvoiceManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
            Controls.Add(saveButton);
            Controls.Add(openButton);
            Controls.Add(byMonthButton);
            Controls.Add(categoryButton);
            Controls.Add(resultTextBox);
            Controls.Add(pathLabel);
            Controls.Add(pathTextBox);
            Controls.Add(readButton);
            Name = "InvoiceManagerForm";
            Text = "Invoice Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button readButton;
        private TextBox pathTextBox;
        private Label pathLabel;
        private TextBox resultTextBox;
        private Button categoryButton;
        private Button byMonthButton;
        private Button openButton;
        private Button saveButton;
    }
}
