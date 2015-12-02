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
            this.records_reset_button = new System.Windows.Forms.Button();
            this.records_datagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.records_datagridview)).BeginInit();
            this.SuspendLayout();
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
            // records_datagridview
            // 
            this.records_datagridview.AllowUserToAddRows = false;
            this.records_datagridview.AllowUserToDeleteRows = false;
            this.records_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records_datagridview.Location = new System.Drawing.Point(13, 43);
            this.records_datagridview.Name = "records_datagridview";
            this.records_datagridview.ReadOnly = true;
            this.records_datagridview.Size = new System.Drawing.Size(559, 206);
            this.records_datagridview.TabIndex = 2;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.records_datagridview);
            this.Controls.Add(this.records_reset_button);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.records_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    private System.Windows.Forms.Button records_reset_button;
        private System.Windows.Forms.DataGridView records_datagridview;
    }
}