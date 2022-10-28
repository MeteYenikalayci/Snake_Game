
namespace YılanOyunu
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            this.game = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.game)).BeginInit();
            this.SuspendLayout();
            // 
            // game
            // 
            this.game.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game.Location = new System.Drawing.Point(29, 29);
            this.game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(666, 666);
            this.game.TabIndex = 0;
            this.game.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 734);
            this.Controls.Add(this.game);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.game)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox game;
	}
}

