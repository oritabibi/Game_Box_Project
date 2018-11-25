﻿namespace GameBox
{
    partial class Change_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_details));
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Tb_Existing_Password = new System.Windows.Forms.TextBox();
            this.Tb_New_Password = new System.Windows.Forms.TextBox();
            this.Tb_New_Name = new System.Windows.Forms.TextBox();
            this.Tb_Existing_Name = new System.Windows.Forms.TextBox();
            this.lb_manager_name = new System.Windows.Forms.Label();
            this.lb_password_player = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Change_details_exit = new System.Windows.Forms.Button();
            this.Bt_Change_Details_back = new System.Windows.Forms.Button();
            this.CB_Change_Details_music2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Update
            // 
            this.Bt_Update.BackColor = System.Drawing.Color.LightGray;
            this.Bt_Update.Location = new System.Drawing.Point(264, 403);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(177, 37);
            this.Bt_Update.TabIndex = 0;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = false;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // Tb_Existing_Password
            // 
            this.Tb_Existing_Password.Location = new System.Drawing.Point(264, 219);
            this.Tb_Existing_Password.Name = "Tb_Existing_Password";
            this.Tb_Existing_Password.PasswordChar = '*';
            this.Tb_Existing_Password.Size = new System.Drawing.Size(176, 22);
            this.Tb_Existing_Password.TabIndex = 2;
            // 
            // Tb_New_Password
            // 
            this.Tb_New_Password.Location = new System.Drawing.Point(264, 329);
            this.Tb_New_Password.Name = "Tb_New_Password";
            this.Tb_New_Password.PasswordChar = '*';
            this.Tb_New_Password.Size = new System.Drawing.Size(176, 22);
            this.Tb_New_Password.TabIndex = 3;
            // 
            // Tb_New_Name
            // 
            this.Tb_New_Name.Location = new System.Drawing.Point(264, 289);
            this.Tb_New_Name.Name = "Tb_New_Name";
            this.Tb_New_Name.Size = new System.Drawing.Size(176, 22);
            this.Tb_New_Name.TabIndex = 4;
            // 
            // Tb_Existing_Name
            // 
            this.Tb_Existing_Name.BackColor = System.Drawing.Color.White;
            this.Tb_Existing_Name.Location = new System.Drawing.Point(264, 178);
            this.Tb_Existing_Name.Name = "Tb_Existing_Name";
            this.Tb_Existing_Name.Size = new System.Drawing.Size(176, 22);
            this.Tb_Existing_Name.TabIndex = 5;
            // 
            // lb_manager_name
            // 
            this.lb_manager_name.AutoSize = true;
            this.lb_manager_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_manager_name.ForeColor = System.Drawing.Color.Gold;
            this.lb_manager_name.Location = new System.Drawing.Point(62, 181);
            this.lb_manager_name.Name = "lb_manager_name";
            this.lb_manager_name.Size = new System.Drawing.Size(175, 17);
            this.lb_manager_name.TabIndex = 21;
            this.lb_manager_name.Text = "Existing Name(2-10 chars)";
            // 
            // lb_password_player
            // 
            this.lb_password_player.AutoSize = true;
            this.lb_password_player.BackColor = System.Drawing.Color.Transparent;
            this.lb_password_player.ForeColor = System.Drawing.Color.Gold;
            this.lb_password_player.Location = new System.Drawing.Point(62, 224);
            this.lb_password_player.Name = "lb_password_player";
            this.lb_password_player.Size = new System.Drawing.Size(178, 17);
            this.lb_password_player.TabIndex = 31;
            this.lb_password_player.Text = "Existing Password(5 chars)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(62, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "New Name(2-10 chars)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(62, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "New Password(5 chars)";
            // 
            // Bt_Change_details_exit
            // 
            this.Bt_Change_details_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Change_details_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Change_details_exit.Location = new System.Drawing.Point(904, 3);
            this.Bt_Change_details_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_Change_details_exit.Name = "Bt_Change_details_exit";
            this.Bt_Change_details_exit.Size = new System.Drawing.Size(82, 56);
            this.Bt_Change_details_exit.TabIndex = 34;
            this.Bt_Change_details_exit.Text = "Exit";
            this.Bt_Change_details_exit.UseVisualStyleBackColor = true;
            this.Bt_Change_details_exit.Click += new System.EventHandler(this.Bt_Change_details_exit_Click);
            // 
            // Bt_Change_Details_back
            // 
            this.Bt_Change_Details_back.Location = new System.Drawing.Point(816, 3);
            this.Bt_Change_Details_back.Name = "Bt_Change_Details_back";
            this.Bt_Change_Details_back.Size = new System.Drawing.Size(82, 57);
            this.Bt_Change_Details_back.TabIndex = 35;
            this.Bt_Change_Details_back.Text = "Back";
            this.Bt_Change_Details_back.UseVisualStyleBackColor = true;
            this.Bt_Change_Details_back.Click += new System.EventHandler(this.Bt_Change_Details_back_Click);
            // 
            // CB_Change_Details_music2
            // 
            this.CB_Change_Details_music2.AutoSize = true;
            this.CB_Change_Details_music2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Change_Details_music2.Checked = true;
            this.CB_Change_Details_music2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Change_Details_music2.FlatAppearance.BorderSize = 0;
            this.CB_Change_Details_music2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Change_Details_music2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Change_Details_music2.ForeColor = System.Drawing.Color.Gold;
            this.CB_Change_Details_music2.Image = ((System.Drawing.Image)(resources.GetObject("CB_Change_Details_music2.Image")));
            this.CB_Change_Details_music2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_Change_Details_music2.Location = new System.Drawing.Point(13, 11);
            this.CB_Change_Details_music2.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Change_Details_music2.Name = "CB_Change_Details_music2";
            this.CB_Change_Details_music2.Size = new System.Drawing.Size(196, 48);
            this.CB_Change_Details_music2.TabIndex = 36;
            this.CB_Change_Details_music2.Text = "Music on";
            this.CB_Change_Details_music2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_Change_Details_music2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(300, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 41);
            this.label3.TabIndex = 37;
            this.label3.Text = "Change Details";
            // 
            // Change_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Change_Details_music2);
            this.Controls.Add(this.Bt_Change_Details_back);
            this.Controls.Add(this.Bt_Change_details_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_password_player);
            this.Controls.Add(this.lb_manager_name);
            this.Controls.Add(this.Tb_Existing_Name);
            this.Controls.Add(this.Tb_New_Name);
            this.Controls.Add(this.Tb_New_Password);
            this.Controls.Add(this.Tb_Existing_Password);
            this.Controls.Add(this.Bt_Update);
            this.Name = "Change_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.TextBox Tb_Existing_Password;
        private System.Windows.Forms.TextBox Tb_New_Password;
        private System.Windows.Forms.TextBox Tb_New_Name;
        private System.Windows.Forms.TextBox Tb_Existing_Name;
        private System.Windows.Forms.Label lb_manager_name;
        private System.Windows.Forms.Label lb_password_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bt_Change_details_exit;
        private System.Windows.Forms.Button Bt_Change_Details_back;
        private System.Windows.Forms.CheckBox CB_Change_Details_music2;
        private System.Windows.Forms.Label label3;
    }
}