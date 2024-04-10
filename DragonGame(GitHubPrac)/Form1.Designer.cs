namespace DragonGame_GitHubPrac_
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
            lblPlayerName = new Label();
            txtPlayerName = new TextBox();
            lblDragonName = new Label();
            txtDragonName = new TextBox();
            btnSave = new Button();
            rtbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(52, 30);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(89, 20);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "PlayerName";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(52, 68);
            txtPlayerName.Multiline = true;
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(1069, 96);
            txtPlayerName.TabIndex = 1;
            // 
            // lblDragonName
            // 
            lblDragonName.AutoSize = true;
            lblDragonName.Location = new Point(52, 196);
            lblDragonName.Name = "lblDragonName";
            lblDragonName.Size = new Size(99, 20);
            lblDragonName.TabIndex = 2;
            lblDragonName.Text = "DragonName";
            // 
            // txtDragonName
            // 
            txtDragonName.Location = new Point(52, 232);
            txtDragonName.Multiline = true;
            txtDragonName.Name = "txtDragonName";
            txtDragonName.Size = new Size(1072, 93);
            txtDragonName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(33, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(1100, 58);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE!!!!";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(27, 495);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(1097, 120);
            rtbOutput.TabIndex = 6;
            rtbOutput.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 657);
            Controls.Add(rtbOutput);
            Controls.Add(btnSave);
            Controls.Add(txtDragonName);
            Controls.Add(lblDragonName);
            Controls.Add(txtPlayerName);
            Controls.Add(lblPlayerName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerName;
        private TextBox txtPlayerName;
        private Label lblDragonName;
        private TextBox txtDragonName;
        private Button btnSave;
        private RichTextBox rtbOutput;
    }
}
