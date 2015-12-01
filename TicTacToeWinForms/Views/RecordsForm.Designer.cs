namespace TicTacToeWinForms
{
    partial class RecordsForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.records_reset_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(259, 207);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // records_reset_button
            // 
            this.records_reset_button.Location = new System.Drawing.Point(13, 13);
            this.records_reset_button.Name = "records_reset_button";
            this.records_reset_button.Size = new System.Drawing.Size(75, 23);
            this.records_reset_button.TabIndex = 1;
            this.records_reset_button.Text = "Reset";
            this.records_reset_button.UseVisualStyleBackColor = true;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.records_reset_button);
            this.Controls.Add(this.listView1);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button records_reset_button;
}
}