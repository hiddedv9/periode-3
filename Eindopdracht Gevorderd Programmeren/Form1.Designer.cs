namespace Eindopdracht_Gevorderd_Programmeren
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
            this.berekeningbox = new System.Windows.Forms.RichTextBox();
            this.stacklistbox = new System.Windows.Forms.ListBox();
            this.keyholder = new System.Windows.Forms.Panel();
            this.stacklabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // berekeningbox
            // 
            this.berekeningbox.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berekeningbox.Location = new System.Drawing.Point(56, 34);
            this.berekeningbox.Name = "berekeningbox";
            this.berekeningbox.Size = new System.Drawing.Size(235, 57);
            this.berekeningbox.TabIndex = 0;
            this.berekeningbox.Text = "";
            // 
            // stacklistbox
            // 
            this.stacklistbox.FormattingEnabled = true;
            this.stacklistbox.Location = new System.Drawing.Point(614, 49);
            this.stacklistbox.Name = "stacklistbox";
            this.stacklistbox.Size = new System.Drawing.Size(120, 342);
            this.stacklistbox.TabIndex = 1;
            // 
            // keyholder
            // 
            this.keyholder.AutoSize = true;
            this.keyholder.Cursor = System.Windows.Forms.Cursors.Default;
            this.keyholder.Location = new System.Drawing.Point(56, 97);
            this.keyholder.Name = "keyholder";
            this.keyholder.Size = new System.Drawing.Size(235, 294);
            this.keyholder.TabIndex = 2;
            // 
            // stacklabel
            // 
            this.stacklabel.AutoSize = true;
            this.stacklabel.Location = new System.Drawing.Point(662, 426);
            this.stacklabel.Name = "stacklabel";
            this.stacklabel.Size = new System.Drawing.Size(0, 13);
            this.stacklabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(746, 504);
            this.Controls.Add(this.stacklabel);
            this.Controls.Add(this.keyholder);
            this.Controls.Add(this.stacklistbox);
            this.Controls.Add(this.berekeningbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox berekeningbox;
        private System.Windows.Forms.ListBox stacklistbox;
        private System.Windows.Forms.Panel keyholder;
        private System.Windows.Forms.Label stacklabel;
    }
}

