namespace Exec2_Message
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblIntro = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblIntro
			// 
			this.lblIntro.AutoSize = true;
			this.lblIntro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIntro.Location = new System.Drawing.Point(12, 29);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new System.Drawing.Size(112, 19);
			this.lblIntro.TabIndex = 0;
			this.lblIntro.Text = "What time is it?";
			// 
			// btnGo
			// 
			this.btnGo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.Location = new System.Drawing.Point(143, 29);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 1;
			this.btnGo.Text = "Go!";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(12, 99);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(112, 19);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "What time is it?";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 215);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.lblIntro);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblIntro;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Label lblResult;
	}
}

