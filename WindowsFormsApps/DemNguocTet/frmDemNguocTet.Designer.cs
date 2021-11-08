namespace DemNguocTet
{
    partial class frmDemNguocTet
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
            this.label1 = new System.Windows.Forms.Label();
            this.numTet = new System.Windows.Forms.NumericUpDown();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.lblTet = new System.Windows.Forms.Label();
            this.lblDungTet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picPhaoHoa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhaoHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Số Phút Đếm:";
            // 
            // numTet
            // 
            this.numTet.Location = new System.Drawing.Point(170, 12);
            this.numTet.Name = "numTet";
            this.numTet.Size = new System.Drawing.Size(120, 20);
            this.numTet.TabIndex = 1;
            this.numTet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(312, 9);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(75, 23);
            this.btnBatDau.TabIndex = 2;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // lblTet
            // 
            this.lblTet.AutoSize = true;
            this.lblTet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTet.Location = new System.Drawing.Point(434, 331);
            this.lblTet.Name = "lblTet";
            this.lblTet.Size = new System.Drawing.Size(121, 48);
            this.lblTet.TabIndex = 3;
            this.lblTet.Text = "00:00";
            // 
            // lblDungTet
            // 
            this.lblDungTet.AutoSize = true;
            this.lblDungTet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDungTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDungTet.Location = new System.Drawing.Point(217, 331);
            this.lblDungTet.Name = "lblDungTet";
            this.lblDungTet.Size = new System.Drawing.Size(33, 48);
            this.lblDungTet.TabIndex = 4;
            this.lblDungTet.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(436, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "CÒN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(196, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(628, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "LÀ ĐẾN TẾT NGUYÊN ĐÁN 2022";
            // 
            // picPhaoHoa
            // 
            this.picPhaoHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhaoHoa.Image = global::DemNguocTet.Properties.Resources.phaohoa;
            this.picPhaoHoa.Location = new System.Drawing.Point(0, 0);
            this.picPhaoHoa.Name = "picPhaoHoa";
            this.picPhaoHoa.Size = new System.Drawing.Size(1003, 450);
            this.picPhaoHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhaoHoa.TabIndex = 7;
            this.picPhaoHoa.TabStop = false;
            // 
            // frmDemNguocTet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DemNguocTet.Properties.Resources.anhtet;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.picPhaoHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDungTet);
            this.Controls.Add(this.lblTet);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.numTet);
            this.Controls.Add(this.label1);
            this.Name = "frmDemNguocTet";
            this.Text = "Tết Nguyên Đán";
            ((System.ComponentModel.ISupportInitialize)(this.numTet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhaoHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTet;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label lblTet;
        private System.Windows.Forms.Label lblDungTet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picPhaoHoa;
    }
}

