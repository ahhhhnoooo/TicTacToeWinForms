using System.Windows.Forms;

namespace TicTacToeWinForms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.game_turn_label = new System.Windows.Forms.Label();
            this.game_turn_image = new System.Windows.Forms.PictureBox();
            this.game_duration_label = new System.Windows.Forms.Label();
            this.game_board_group = new System.Windows.Forms.GroupBox();
            this.game_board_8 = new System.Windows.Forms.PictureBox();
            this.game_board_7 = new System.Windows.Forms.PictureBox();
            this.game_board_6 = new System.Windows.Forms.PictureBox();
            this.game_board_5 = new System.Windows.Forms.PictureBox();
            this.game_board_4 = new System.Windows.Forms.PictureBox();
            this.game_board_3 = new System.Windows.Forms.PictureBox();
            this.game_board_2 = new System.Windows.Forms.PictureBox();
            this.game_board_1 = new System.Windows.Forms.PictureBox();
            this.game_board_0 = new System.Windows.Forms.PictureBox();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.game_reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.game_turn_image)).BeginInit();
            this.game_board_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_0)).BeginInit();
            this.SuspendLayout();
            // 
            // game_turn_label
            // 
            this.game_turn_label.AutoSize = true;
            this.game_turn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_turn_label.Location = new System.Drawing.Point(66, 31);
            this.game_turn_label.Name = "game_turn_label";
            this.game_turn_label.Size = new System.Drawing.Size(57, 29);
            this.game_turn_label.TabIndex = 0;
            this.game_turn_label.Text = "turn";
            // 
            // game_turn_image
            // 
            this.game_turn_image.Image = global::TicTacToeWinForms.Properties.Resources.x;
            this.game_turn_image.InitialImage = global::TicTacToeWinForms.Properties.Resources.x;
            this.game_turn_image.Location = new System.Drawing.Point(10, 10);
            this.game_turn_image.Name = "game_turn_image";
            this.game_turn_image.Size = new System.Drawing.Size(50, 50);
            this.game_turn_image.TabIndex = 1;
            this.game_turn_image.TabStop = false;
            // 
            // game_duration_label
            // 
            this.game_duration_label.AutoSize = true;
            this.game_duration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_duration_label.Location = new System.Drawing.Point(183, 9);
            this.game_duration_label.Name = "game_duration_label";
            this.game_duration_label.Size = new System.Drawing.Size(26, 29);
            this.game_duration_label.TabIndex = 2;
            this.game_duration_label.Text = "0";
            this.game_duration_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // game_board_group
            // 
            this.game_board_group.Controls.Add(this.game_board_8);
            this.game_board_group.Controls.Add(this.game_board_7);
            this.game_board_group.Controls.Add(this.game_board_6);
            this.game_board_group.Controls.Add(this.game_board_5);
            this.game_board_group.Controls.Add(this.game_board_4);
            this.game_board_group.Controls.Add(this.game_board_3);
            this.game_board_group.Controls.Add(this.game_board_2);
            this.game_board_group.Controls.Add(this.game_board_1);
            this.game_board_group.Controls.Add(this.game_board_0);
            this.game_board_group.Location = new System.Drawing.Point(10, 67);
            this.game_board_group.Name = "game_board_group";
            this.game_board_group.Size = new System.Drawing.Size(200, 200);
            this.game_board_group.TabIndex = 3;
            this.game_board_group.TabStop = false;
            // 
            // game_board_8
            // 
            this.game_board_8.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_8.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_8.Location = new System.Drawing.Point(127, 127);
            this.game_board_8.Name = "game_board_8";
            this.game_board_8.Size = new System.Drawing.Size(50, 50);
            this.game_board_8.TabIndex = 8;
            this.game_board_8.TabStop = false;
            this.game_board_8.Tag = "8";
            this.game_board_8.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_7
            // 
            this.game_board_7.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_7.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_7.Location = new System.Drawing.Point(71, 127);
            this.game_board_7.Name = "game_board_7";
            this.game_board_7.Size = new System.Drawing.Size(50, 50);
            this.game_board_7.TabIndex = 7;
            this.game_board_7.TabStop = false;
            this.game_board_7.Tag = "7";
            this.game_board_7.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_6
            // 
            this.game_board_6.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_6.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_6.Location = new System.Drawing.Point(15, 127);
            this.game_board_6.Name = "game_board_6";
            this.game_board_6.Size = new System.Drawing.Size(50, 50);
            this.game_board_6.TabIndex = 6;
            this.game_board_6.TabStop = false;
            this.game_board_6.Tag = "6";
            this.game_board_6.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_5
            // 
            this.game_board_5.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_5.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_5.Location = new System.Drawing.Point(127, 71);
            this.game_board_5.Name = "game_board_5";
            this.game_board_5.Size = new System.Drawing.Size(50, 50);
            this.game_board_5.TabIndex = 5;
            this.game_board_5.TabStop = false;
            this.game_board_5.Tag = "5";
            this.game_board_5.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_4
            // 
            this.game_board_4.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_4.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_4.Location = new System.Drawing.Point(71, 71);
            this.game_board_4.Name = "game_board_4";
            this.game_board_4.Size = new System.Drawing.Size(50, 50);
            this.game_board_4.TabIndex = 4;
            this.game_board_4.TabStop = false;
            this.game_board_4.Tag = "4";
            this.game_board_4.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_3
            // 
            this.game_board_3.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_3.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_3.Location = new System.Drawing.Point(15, 71);
            this.game_board_3.Name = "game_board_3";
            this.game_board_3.Size = new System.Drawing.Size(50, 50);
            this.game_board_3.TabIndex = 3;
            this.game_board_3.TabStop = false;
            this.game_board_3.Tag = "3";
            this.game_board_3.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_2
            // 
            this.game_board_2.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_2.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_2.Location = new System.Drawing.Point(127, 15);
            this.game_board_2.Name = "game_board_2";
            this.game_board_2.Size = new System.Drawing.Size(50, 50);
            this.game_board_2.TabIndex = 2;
            this.game_board_2.TabStop = false;
            this.game_board_2.Tag = "2";
            this.game_board_2.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_1
            // 
            this.game_board_1.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_1.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_1.Location = new System.Drawing.Point(71, 15);
            this.game_board_1.Name = "game_board_1";
            this.game_board_1.Size = new System.Drawing.Size(50, 50);
            this.game_board_1.TabIndex = 1;
            this.game_board_1.TabStop = false;
            this.game_board_1.Tag = "1";
            this.game_board_1.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_board_0
            // 
            this.game_board_0.Image = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_0.InitialImage = global::TicTacToeWinForms.Properties.Resources.blank;
            this.game_board_0.Location = new System.Drawing.Point(15, 15);
            this.game_board_0.Name = "game_board_0";
            this.game_board_0.Size = new System.Drawing.Size(50, 50);
            this.game_board_0.TabIndex = 0;
            this.game_board_0.TabStop = false;
            this.game_board_0.Tag = "0";
            this.game_board_0.Click += new System.EventHandler(this.game_board_Click);
            // 
            // game_timer
            // 
            this.game_timer.Enabled = true;
            this.game_timer.Interval = 1000;
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // game_reset_button
            // 
            this.game_reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_reset_button.Location = new System.Drawing.Point(71, 9);
            this.game_reset_button.Name = "game_reset_button";
            this.game_reset_button.Size = new System.Drawing.Size(75, 23);
            this.game_reset_button.TabIndex = 4;
            this.game_reset_button.Text = "Reset";
            this.game_reset_button.UseVisualStyleBackColor = true;
            this.game_reset_button.Click += new System.EventHandler(this.game_reset_button_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.game_reset_button);
            this.Controls.Add(this.game_board_group);
            this.Controls.Add(this.game_duration_label);
            this.Controls.Add(this.game_turn_image);
            this.Controls.Add(this.game_turn_label);
            this.Name = "GameForm";
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.game_turn_image)).EndInit();
            this.game_board_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.game_board_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_board_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_turn_label;
        private System.Windows.Forms.PictureBox game_turn_image;
        private System.Windows.Forms.Label game_duration_label;
        private System.Windows.Forms.GroupBox game_board_group;
        private System.Windows.Forms.PictureBox game_board_0;
        private System.Windows.Forms.PictureBox game_board_8;
        private System.Windows.Forms.PictureBox game_board_7;
        private System.Windows.Forms.PictureBox game_board_6;
        private System.Windows.Forms.PictureBox game_board_5;
        private System.Windows.Forms.PictureBox game_board_4;
        private System.Windows.Forms.PictureBox game_board_3;
        private System.Windows.Forms.PictureBox game_board_2;
        private System.Windows.Forms.PictureBox game_board_1;
        private Timer game_timer;
        private Button game_reset_button;
    }
}