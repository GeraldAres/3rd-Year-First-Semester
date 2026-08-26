namespace Act2Search
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.radioBFS = new System.Windows.Forms.RadioButton();
            this.radioDFS = new System.Windows.Forms.RadioButton();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonShowStartGoal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 256);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1 (legacy Run BFS)
            // 
            this.button1.Location = new System.Drawing.Point(39, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run (legacy)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(304, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // radioBFS
            // 
            this.radioBFS.AutoSize = true;
            this.radioBFS.Location = new System.Drawing.Point(39, 30);
            this.radioBFS.Name = "radioBFS";
            this.radioBFS.Size = new System.Drawing.Size(53, 21);
            this.radioBFS.TabIndex = 6;
            this.radioBFS.TabStop = true;
            this.radioBFS.Text = "BFS";
            this.radioBFS.UseVisualStyleBackColor = true;
            this.radioBFS.Checked = true;
            // 
            // radioDFS
            // 
            this.radioDFS.AutoSize = true;
            this.radioDFS.Location = new System.Drawing.Point(100, 30);
            this.radioDFS.Name = "radioDFS";
            this.radioDFS.Size = new System.Drawing.Size(53, 21);
            this.radioDFS.TabIndex = 7;
            this.radioDFS.TabStop = true;
            this.radioDFS.Text = "DFS";
            this.radioDFS.UseVisualStyleBackColor = true;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(39, 70);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(114, 30);
            this.buttonRandomize.TabIndex = 8;
            this.buttonRandomize.Text = "Randomize Walls";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(165, 70);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(124, 30);
            this.buttonRun.TabIndex = 9;
            this.buttonRun.Text = "Run Selected";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonShowStartGoal
            // 
            this.buttonShowStartGoal.Location = new System.Drawing.Point(39, 110);
            this.buttonShowStartGoal.Name = "buttonShowStartGoal";
            this.buttonShowStartGoal.Size = new System.Drawing.Size(250, 30);
            this.buttonShowStartGoal.TabIndex = 10;
            this.buttonShowStartGoal.Text = "Toggle Show Start/Goal";
            this.buttonShowStartGoal.UseVisualStyleBackColor = true;
            this.buttonShowStartGoal.Click += new System.EventHandler(this.buttonShowStartGoal_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(663, 256);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(120, 411);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(789, 256);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(120, 411);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(915, 256);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(120, 411);
            this.richTextBox4.TabIndex = 5;
            this.richTextBox4.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 763);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radioBFS);
            this.Controls.Add(this.radioDFS);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonShowStartGoal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RadioButton radioBFS;
        private System.Windows.Forms.RadioButton radioDFS;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonShowStartGoal;
    }
}

