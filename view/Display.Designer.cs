using System;
using System.Windows.Forms;

namespace DogForm
{
    partial class DogForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxDog;
        private System.Windows.Forms.RichTextBox richTextBoxDog;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBoxDog = new System.Windows.Forms.PictureBox();
            this.cbRotuDropdown = new System.Windows.Forms.ComboBox();
            this.btnEtsi = new System.Windows.Forms.Button();
            this.kuva_label = new System.Windows.Forms.Label();
            this.Infobox_label = new System.Windows.Forms.Label();
            this.Koirarotu_label = new System.Windows.Forms.Label();
            this.richTextInfoBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDog
            // 
            this.pictureBoxDog.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDog.Location = new System.Drawing.Point(77, 156);
            this.pictureBoxDog.Name = "pictureBoxDog";
            this.pictureBoxDog.Size = new System.Drawing.Size(273, 258);
            this.pictureBoxDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDog.TabIndex = 1;
            this.pictureBoxDog.TabStop = false;
            // 
            // cbRotuDropdown
            // 
            this.cbRotuDropdown.Location = new System.Drawing.Point(98, 96);
            this.cbRotuDropdown.Name = "cbRotuDropdown";
            this.cbRotuDropdown.Size = new System.Drawing.Size(204, 28);
            this.cbRotuDropdown.TabIndex = 0;
            // 
            // btnEtsi
            // 
            this.btnEtsi.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtsi.Location = new System.Drawing.Point(320, 88);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(89, 42);
            this.btnEtsi.TabIndex = 5;
            this.btnEtsi.Text = "Search";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsiClick);
            // 
            // kuva_label
            // 
            this.kuva_label.AutoSize = true;
            this.kuva_label.BackColor = System.Drawing.Color.Transparent;
            this.kuva_label.Location = new System.Drawing.Point(140, 172);
            this.kuva_label.Name = "kuva_label";
            this.kuva_label.Size = new System.Drawing.Size(0, 20);
            this.kuva_label.TabIndex = 6;
            this.kuva_label.Click += new System.EventHandler(this.kuva_label_Click);
            // 
            // Infobox_label
            // 
            this.Infobox_label.AutoSize = true;
            this.Infobox_label.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infobox_label.Location = new System.Drawing.Point(151, 473);
            this.Infobox_label.Name = "Infobox_label";
            this.Infobox_label.Size = new System.Drawing.Size(52, 24);
            this.Infobox_label.TabIndex = 7;
            this.Infobox_label.Text = "Info";
            this.Infobox_label.Click += new System.EventHandler(this.Infobox_label_Click);
            // 
            // Koirarotu_label
            // 
            this.Koirarotu_label.AutoSize = true;
            this.Koirarotu_label.BackColor = System.Drawing.Color.Transparent;
            this.Koirarotu_label.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Koirarotu_label.Location = new System.Drawing.Point(125, 57);
            this.Koirarotu_label.Name = "Koirarotu_label";
            this.Koirarotu_label.Size = new System.Drawing.Size(146, 24);
            this.Koirarotu_label.TabIndex = 10;
            this.Koirarotu_label.Text = "Choose breed";
            this.Koirarotu_label.Click += new System.EventHandler(this.Koirarotu_label_Click);
            // 
            // richTextInfoBox
            // 
            this.richTextInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextInfoBox.Location = new System.Drawing.Point(77, 519);
            this.richTextInfoBox.Name = "richTextInfoBox";
            this.richTextInfoBox.Size = new System.Drawing.Size(273, 261);
            this.richTextInfoBox.TabIndex = 11;
            this.richTextInfoBox.Text = "";
            this.richTextInfoBox.TextChanged += new System.EventHandler(this.richTextInfoBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Linen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(635, 581);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(649, 28);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "You may have many best friends but your dog only has one";
            // 
            // DogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DogForm.Properties.Resources.dachshund_5978830_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 853);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextInfoBox);
            this.Controls.Add(this.Koirarotu_label);
            this.Controls.Add(this.Infobox_label);
            this.Controls.Add(this.kuva_label);
            this.Controls.Add(this.btnEtsi);
            this.Controls.Add(this.cbRotuDropdown);
            this.Controls.Add(this.pictureBoxDog);
            this.HelpButton = true;
            this.Name = "DogForm";
            this.Text = "DOG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox cbRotuDropdown;
        private Button btnEtsi;
        private Label kuva_label;
        private Label Infobox_label;
        private Label Koirarotu_label;
        private RichTextBox richTextInfoBox;
        private TextBox textBox1;
    }
}
#endregion