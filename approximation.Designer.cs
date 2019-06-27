namespace approximation
{
    partial class approximation
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
            this.input_x_t = new System.Windows.Forms.TextBox();
            this.output_t = new System.Windows.Forms.TextBox();
            this.linear = new System.Windows.Forms.Button();
            this.input_y_t = new System.Windows.Forms.TextBox();
            this.x_l = new System.Windows.Forms.Label();
            this.y_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_x_t
            // 
            this.input_x_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_x_t.Location = new System.Drawing.Point(17, 1);
            this.input_x_t.Name = "input_x_t";
            this.input_x_t.Size = new System.Drawing.Size(265, 13);
            this.input_x_t.TabIndex = 0;
            // 
            // output_t
            // 
            this.output_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_t.Location = new System.Drawing.Point(2, 62);
            this.output_t.Name = "output_t";
            this.output_t.ReadOnly = true;
            this.output_t.Size = new System.Drawing.Size(280, 13);
            this.output_t.TabIndex = 3;
            // 
            // linear
            // 
            this.linear.Location = new System.Drawing.Point(2, 36);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(280, 23);
            this.linear.TabIndex = 2;
            this.linear.Text = "linear";
            this.linear.UseVisualStyleBackColor = true;
            this.linear.Click += new System.EventHandler(this.calculate_b_Click);
            // 
            // input_y_t
            // 
            this.input_y_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_y_t.Location = new System.Drawing.Point(17, 20);
            this.input_y_t.Name = "input_y_t";
            this.input_y_t.Size = new System.Drawing.Size(265, 13);
            this.input_y_t.TabIndex = 1;
            // 
            // x_l
            // 
            this.x_l.AutoSize = true;
            this.x_l.Location = new System.Drawing.Point(3, 1);
            this.x_l.Name = "x_l";
            this.x_l.Size = new System.Drawing.Size(12, 13);
            this.x_l.TabIndex = 4;
            this.x_l.Text = "x";
            // 
            // y_l
            // 
            this.y_l.AutoSize = true;
            this.y_l.Location = new System.Drawing.Point(3, 20);
            this.y_l.Name = "y_l";
            this.y_l.Size = new System.Drawing.Size(12, 13);
            this.y_l.TabIndex = 5;
            this.y_l.Text = "y";
            // 
            // approximation
            // 
            this.AcceptButton = this.linear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.y_l);
            this.Controls.Add(this.x_l);
            this.Controls.Add(this.input_y_t);
            this.Controls.Add(this.linear);
            this.Controls.Add(this.output_t);
            this.Controls.Add(this.input_x_t);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "approximation";
            this.ShowIcon = false;
            this.Text = "approximation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_x_t;
        private System.Windows.Forms.TextBox output_t;
        private System.Windows.Forms.Button linear;
        private System.Windows.Forms.TextBox input_y_t;
        private System.Windows.Forms.Label x_l;
        private System.Windows.Forms.Label y_l;
    }
}

