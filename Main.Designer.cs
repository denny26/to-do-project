
namespace ToDo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Add_btn = new System.Windows.Forms.Button();
            this.Check_All_btn = new System.Windows.Forms.Button();
            this.Delete_ToDo_btn = new System.Windows.Forms.Button();
            this.todoList = new System.Windows.Forms.CheckedListBox();
            this.textAddToDo = new System.Windows.Forms.TextBox();
            this.AddToDo_label = new System.Windows.Forms.Label();
            this.Displayed_ToDo_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_btn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Add_btn.Location = new System.Drawing.Point(197, 81);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(123, 41);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "Add a to-do";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Check_All_btn
            // 
            this.Check_All_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Check_All_btn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Check_All_btn.Location = new System.Drawing.Point(197, 171);
            this.Check_All_btn.Name = "Check_All_btn";
            this.Check_All_btn.Size = new System.Drawing.Size(123, 55);
            this.Check_All_btn.TabIndex = 1;
            this.Check_All_btn.Text = "Check all to-do\'s";
            this.Check_All_btn.UseVisualStyleBackColor = true;
            this.Check_All_btn.Click += new System.EventHandler(this.Check_All_btn_Click);
            // 
            // Delete_ToDo_btn
            // 
            this.Delete_ToDo_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_ToDo_btn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Delete_ToDo_btn.Location = new System.Drawing.Point(197, 258);
            this.Delete_ToDo_btn.Name = "Delete_ToDo_btn";
            this.Delete_ToDo_btn.Size = new System.Drawing.Size(123, 41);
            this.Delete_ToDo_btn.TabIndex = 2;
            this.Delete_ToDo_btn.Text = "Delete a to-do";
            this.Delete_ToDo_btn.UseVisualStyleBackColor = true;
            this.Delete_ToDo_btn.Click += new System.EventHandler(this.Delete_ToDo_btn_Click);
            // 
            // todoList
            // 
            this.todoList.BackColor = System.Drawing.SystemColors.Control;
            this.todoList.FormattingEnabled = true;
            this.todoList.Location = new System.Drawing.Point(12, 171);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(179, 292);
            this.todoList.TabIndex = 9;
            this.todoList.SelectedIndexChanged += new System.EventHandler(this.ToDoList_SelectedIndexChanged);
            // 
            // textAddToDo
            // 
            this.textAddToDo.BackColor = System.Drawing.SystemColors.Control;
            this.textAddToDo.Location = new System.Drawing.Point(12, 81);
            this.textAddToDo.Multiline = true;
            this.textAddToDo.Name = "textAddToDo";
            this.textAddToDo.Size = new System.Drawing.Size(179, 41);
            this.textAddToDo.TabIndex = 8;
            // 
            // AddToDo_label
            // 
            this.AddToDo_label.AutoSize = true;
            this.AddToDo_label.BackColor = System.Drawing.Color.Transparent;
            this.AddToDo_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.AddToDo_label.ForeColor = System.Drawing.Color.DarkMagenta;
            this.AddToDo_label.Location = new System.Drawing.Point(27, 58);
            this.AddToDo_label.Name = "AddToDo_label";
            this.AddToDo_label.Size = new System.Drawing.Size(149, 20);
            this.AddToDo_label.TabIndex = 10;
            this.AddToDo_label.Text = "Write your to-do here:";
            // 
            // Displayed_ToDo_label
            // 
            this.Displayed_ToDo_label.AutoSize = true;
            this.Displayed_ToDo_label.BackColor = System.Drawing.Color.Transparent;
            this.Displayed_ToDo_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Displayed_ToDo_label.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Displayed_ToDo_label.Location = new System.Drawing.Point(27, 148);
            this.Displayed_ToDo_label.Name = "Displayed_ToDo_label";
            this.Displayed_ToDo_label.Size = new System.Drawing.Size(146, 20);
            this.Displayed_ToDo_label.TabIndex = 11;
            this.Displayed_ToDo_label.Text = "Here are your to-do\'s:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(248, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 35);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "your ✓  To-Do";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 472);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Displayed_ToDo_label);
            this.Controls.Add(this.AddToDo_label);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.textAddToDo);
            this.Controls.Add(this.Delete_ToDo_btn);
            this.Controls.Add(this.Check_All_btn);
            this.Controls.Add(this.Add_btn);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Check_All_btn;
        private System.Windows.Forms.Button Delete_ToDo_btn;
        private System.Windows.Forms.CheckedListBox todoList;
        private System.Windows.Forms.TextBox textAddToDo;
        private System.Windows.Forms.Label AddToDo_label;
        private System.Windows.Forms.Label Displayed_ToDo_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}