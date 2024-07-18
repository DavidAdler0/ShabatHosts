namespace ShabatGuests
{
    partial class HostForm
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
            HostNamelabel = new Label();
            CategoryTextBox = new TextBox();
            ExecuteButton = new Button();
            CategorylistView = new ListView();
            SuspendLayout();
            // 
            // HostNamelabel
            // 
            HostNamelabel.AutoSize = true;
            HostNamelabel.Location = new Point(237, 73);
            HostNamelabel.Name = "HostNamelabel";
            HostNamelabel.Size = new Size(100, 25);
            HostNamelabel.TabIndex = 0;
            HostNamelabel.Text = "שם המארח";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(208, 142);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(150, 31);
            CategoryTextBox.TabIndex = 1;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(225, 234);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(112, 34);
            ExecuteButton.TabIndex = 2;
            ExecuteButton.Text = "בצע";
            ExecuteButton.UseVisualStyleBackColor = true;
            // 
            // CategorylistView
            // 
            CategorylistView.Location = new Point(196, 305);
            CategorylistView.Name = "CategorylistView";
            CategorylistView.Size = new Size(182, 146);
            CategorylistView.TabIndex = 3;
            CategorylistView.UseCompatibleStateImageBehavior = false;
            // 
            // HostForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 593);
            Controls.Add(CategorylistView);
            Controls.Add(ExecuteButton);
            Controls.Add(CategoryTextBox);
            Controls.Add(HostNamelabel);
            Name = "HostForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HostNamelabel;
        private TextBox CategoryTextBox;
        private Button ExecuteButton;
        private ListView CategorylistView;
    }
}
