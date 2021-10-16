namespace DemNguocTetNguyenDan
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTetDungNgay = new System.Windows.Forms.Label();
            this.lblDungTet = new System.Windows.Forms.Label();
            this.picPhaoHoa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhaoHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Số Phút Đếm Ngược Tết";
            // 
            // numTet
            // 
            this.numTet.Location = new System.Drawing.Point(181, 13);
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
            this.btnBatDau.Location = new System.Drawing.Point(321, 9);
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
            this.lblTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTet.Location = new System.Drawing.Point(367, 232);
            this.lblTet.Name = "lblTet";
            this.lblTet.Size = new System.Drawing.Size(29, 31);
            this.lblTet.TabIndex = 3;
            this.lblTet.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTetDungNgay
            // 
            this.lblTetDungNgay.AutoSize = true;
            this.lblTetDungNgay.Location = new System.Drawing.Point(181, 250);
            this.lblTetDungNgay.Name = "lblTetDungNgay";
            this.lblTetDungNgay.Size = new System.Drawing.Size(0, 13);
            this.lblTetDungNgay.TabIndex = 5;
            // 
            // lblDungTet
            // 
            this.lblDungTet.AutoSize = true;
            this.lblDungTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDungTet.Location = new System.Drawing.Point(181, 249);
            this.lblDungTet.Name = "lblDungTet";
            this.lblDungTet.Size = new System.Drawing.Size(22, 31);
            this.lblDungTet.TabIndex = 6;
            this.lblDungTet.Text = ".";
            // 
            // picPhaoHoa
            // 
            this.picPhaoHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhaoHoa.Image = global::DemNguocTetNguyenDan.Properties.Resources.phaohoa;
            this.picPhaoHoa.Location = new System.Drawing.Point(0, 0);
            this.picPhaoHoa.Name = "picPhaoHoa";
            this.picPhaoHoa.Size = new System.Drawing.Size(800, 450);
            this.picPhaoHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhaoHoa.TabIndex = 7;
            this.picPhaoHoa.TabStop = false;
            // 
            // frmDemNguocTet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPhaoHoa);
            this.Controls.Add(this.lblDungTet);
            this.Controls.Add(this.lblTetDungNgay);
            this.Controls.Add(this.lblTet);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.numTet);
            this.Controls.Add(this.label1);
            this.Name = "frmDemNguocTet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDemNguocTet_Load);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTetDungNgay;
        private System.Windows.Forms.Label lblDungTet;
        private System.Windows.Forms.PictureBox picPhaoHoa;
    }
}

