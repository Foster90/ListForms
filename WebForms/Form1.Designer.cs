using System;

namespace WebForms
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();                  
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.MoveItem = new System.Windows.Forms.Button();
            this.MoveItem2 = new System.Windows.Forms.Button();
            this.MoveAll = new System.Windows.Forms.Button();
            this.MoveAll2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(60, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 238);
            this.listBox1.TabIndex = 0;
            listBox1.Items.Add("Geeks");
            listBox1.Items.Add("GFG");
            listBox1.Items.Add("GeeksForGeeks");
            listBox1.Items.Add("gfg");          

            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(366, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(195, 238);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            listBox2.Items.Add("Geeks");
            listBox2.Items.Add("GFG");
            listBox2.Items.Add("GeeksForGeeks");
            listBox2.Items.Add("gfg");
            // 
            // MoveItem
            // 
            this.MoveItem.Location = new System.Drawing.Point(60, 361);
            this.MoveItem.Name = "Move Item";
            this.MoveItem.Size = new System.Drawing.Size(197, 34);
            this.MoveItem.TabIndex = 2;
            this.MoveItem.Text = "Move Item";
            this.MoveItem.UseVisualStyleBackColor = true;
            MoveItem.Click += new EventHandler(Moveitem_OnClick1);
            // 
            // MoveItem2
            // 
            this.MoveItem2.Location = new System.Drawing.Point(366, 361);
            this.MoveItem2.Name = "MoveItem2";
            this.MoveItem2.Size = new System.Drawing.Size(197, 34);
            this.MoveItem2.TabIndex = 3;
            this.MoveItem2.Text = "MoveItem2";
            this.MoveItem2.UseVisualStyleBackColor = true;
            MoveItem2.Click += new EventHandler(Moveitem2_OnClick1);
            // 
            // MoveAll
            // 
            this.MoveAll.Location = new System.Drawing.Point(60, 401);
            this.MoveAll.Name = "MoveAll";
            this.MoveAll.Size = new System.Drawing.Size(197, 34);
            this.MoveAll.TabIndex = 4;
            this.MoveAll.Text = "MoveAll";
            this.MoveAll.UseVisualStyleBackColor = true;
            MoveAll.Click += new EventHandler(MoveAll_OnClick1);
            // 
            // MoveAll2
            // 
            this.MoveAll2.Location = new System.Drawing.Point(364, 401);
            this.MoveAll2.Name = "MoveAll2";
            this.MoveAll2.Size = new System.Drawing.Size(197, 34);
            this.MoveAll2.TabIndex = 5;
            this.MoveAll2.Text = "MoveAll2";
            this.MoveAll2.UseVisualStyleBackColor = true;
            MoveAll2.Click += new EventHandler(MoveAll2_OnClick1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 549);
            this.Controls.Add(this.MoveAll2);
            this.Controls.Add(this.MoveAll);
            this.Controls.Add(this.MoveItem2);
            this.Controls.Add(this.MoveItem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        

        private System.Windows.Forms.ListBox listBox2;


        private System.Windows.Forms.Button MoveItem;


        private System.Windows.Forms.Button MoveItem2;


        private System.Windows.Forms.Button MoveAll;


        private System.Windows.Forms.Button MoveAll2;
    }
}

