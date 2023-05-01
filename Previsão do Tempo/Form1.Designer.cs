namespace Previsão_do_Tempo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_detail = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_temp = new System.Windows.Forms.Label();
            this.lab_umidade = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_max = new System.Windows.Forms.Label();
            this.lab_min = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_lon = new System.Windows.Forms.Label();
            this.lab_lat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCity
            // 
            this.TbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCity.Location = new System.Drawing.Point(145, 58);
            this.TbCity.Multiline = true;
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(276, 25);
            this.TbCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Noto Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Location = new System.Drawing.Point(437, 49);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 45);
            this.btn_search.TabIndex = 3;
            this.btn_search.Tag = "";
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.BackColor = System.Drawing.Color.Transparent;
            this.lab_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_detail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_detail.Location = new System.Drawing.Point(85, 324);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(112, 25);
            this.lab_detail.TabIndex = 5;
            this.lab_detail.Text = "Detalhes:";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_sunrise.Location = new System.Drawing.Point(12, 36);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(86, 25);
            this.lab_sunrise.TabIndex = 6;
            this.lab_sunrise.Text = "ATUAL:";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_sunset.Location = new System.Drawing.Point(364, 242);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(111, 25);
            this.lab_sunset.TabIndex = 7;
            this.lab_sunset.Text = "Umidade:";
            // 
            // lab_temp
            // 
            this.lab_temp.AutoSize = true;
            this.lab_temp.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_temp.Location = new System.Drawing.Point(94, 36);
            this.lab_temp.Name = "lab_temp";
            this.lab_temp.Size = new System.Drawing.Size(50, 25);
            this.lab_temp.TabIndex = 8;
            this.lab_temp.Text = "N/A";
            // 
            // lab_umidade
            // 
            this.lab_umidade.AutoSize = true;
            this.lab_umidade.BackColor = System.Drawing.Color.Transparent;
            this.lab_umidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_umidade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_umidade.Location = new System.Drawing.Point(480, 242);
            this.lab_umidade.Name = "lab_umidade";
            this.lab_umidade.Size = new System.Drawing.Size(50, 25);
            this.lab_umidade.TabIndex = 9;
            this.lab_umidade.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(364, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ventos:";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_windspeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_windspeed.Location = new System.Drawing.Point(462, 194);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(50, 25);
            this.lab_windspeed.TabIndex = 12;
            this.lab_windspeed.Text = "N/A";
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.Location = new System.Drawing.Point(68, 352);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(213, 86);
            this.pic_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_icon.TabIndex = 14;
            this.pic_icon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "MIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "MAX:";
            // 
            // lab_max
            // 
            this.lab_max.AutoSize = true;
            this.lab_max.BackColor = System.Drawing.Color.Transparent;
            this.lab_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_max.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_max.Location = new System.Drawing.Point(73, 102);
            this.lab_max.Name = "lab_max";
            this.lab_max.Size = new System.Drawing.Size(50, 25);
            this.lab_max.TabIndex = 17;
            this.lab_max.Text = "N/A";
            // 
            // lab_min
            // 
            this.lab_min.AutoSize = true;
            this.lab_min.BackColor = System.Drawing.Color.Transparent;
            this.lab_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_min.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_min.Location = new System.Drawing.Point(67, 66);
            this.lab_min.Name = "lab_min";
            this.lab_min.Size = new System.Drawing.Size(50, 25);
            this.lab_min.TabIndex = 18;
            this.lab_min.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lab_min);
            this.groupBox1.Controls.Add(this.lab_sunrise);
            this.groupBox1.Controls.Add(this.lab_max);
            this.groupBox1.Controls.Add(this.lab_temp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(75, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 138);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatura";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lab_lon);
            this.groupBox2.Controls.Add(this.lab_lat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(357, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 115);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geolocalização";
            // 
            // lab_lon
            // 
            this.lab_lon.AutoSize = true;
            this.lab_lon.BackColor = System.Drawing.Color.Transparent;
            this.lab_lon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_lon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_lon.Location = new System.Drawing.Point(68, 37);
            this.lab_lon.Name = "lab_lon";
            this.lab_lon.Size = new System.Drawing.Size(50, 25);
            this.lab_lon.TabIndex = 18;
            this.lab_lon.Text = "N/A";
            // 
            // lab_lat
            // 
            this.lab_lat.AutoSize = true;
            this.lab_lat.BackColor = System.Drawing.Color.Transparent;
            this.lab_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_lat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_lat.Location = new System.Drawing.Point(68, 71);
            this.lab_lat.Name = "lab_lat";
            this.lab_lat.Size = new System.Drawing.Size(50, 25);
            this.lab_lat.TabIndex = 17;
            this.lab_lat.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(14, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Lat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(14, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Lon:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Previsão_do_Tempo.Properties.Resources.Meteorológia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_umidade);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_detail);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_temp;
        private System.Windows.Forms.Label lab_umidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_max;
        private System.Windows.Forms.Label lab_min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_lon;
        private System.Windows.Forms.Label lab_lat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

