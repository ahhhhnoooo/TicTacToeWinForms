namespace TicTacToeWinForms
{
    partial class MainForm
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
            this.main_newgame_button = new System.Windows.Forms.Button();
            this.main_records_button = new System.Windows.Forms.Button();
            this.main_exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_newgame_button
            // 
            this.main_newgame_button.Location = new System.Drawing.Point(10, 10);
            this.main_newgame_button.Name = "main_newgame_button";
            this.main_newgame_button.Size = new System.Drawing.Size(75, 23);
            this.main_newgame_button.TabIndex = 0;
            this.main_newgame_button.Text = "New Game";
            this.main_newgame_button.UseVisualStyleBackColor = true;
            this.main_newgame_button.Click += new System.EventHandler(this.main_newgame_button_Click);
            // 
            // main_records_button
            // 
            this.main_records_button.Location = new System.Drawing.Point(10, 40);
            this.main_records_button.Name = "main_records_button";
            this.main_records_button.Size = new System.Drawing.Size(75, 23);
            this.main_records_button.TabIndex = 1;
            this.main_records_button.Text = "Records";
            this.main_records_button.UseVisualStyleBackColor = true;
            this.main_records_button.Click += new System.EventHandler(this.main_records_button_Click);
            // 
            // main_exit_button
            // 
            this.main_exit_button.Location = new System.Drawing.Point(10, 70);
            this.main_exit_button.Name = "main_exit_button";
            this.main_exit_button.Size = new System.Drawing.Size(75, 23);
            this.main_exit_button.TabIndex = 2;
            this.main_exit_button.Text = "Exit";
            this.main_exit_button.UseVisualStyleBackColor = true;
            this.main_exit_button.Click += new System.EventHandler(this.main_exit_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 111);
            this.Controls.Add(this.main_exit_button);
            this.Controls.Add(this.main_records_button);
            this.Controls.Add(this.main_newgame_button);
            this.Name = "MainForm";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button main_newgame_button;
        private System.Windows.Forms.Button main_records_button;
        private System.Windows.Forms.Button main_exit_button;
    }
}

