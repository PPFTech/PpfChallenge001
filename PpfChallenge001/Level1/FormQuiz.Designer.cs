namespace Level1
{ 
    partial class FormQuiz
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQ = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.radioAnswer1 = new System.Windows.Forms.RadioButton();
            this.radioAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioAnswer3 = new System.Windows.Forms.RadioButton();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQ
            // 
            this.labelQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(21, 21);
            this.labelQ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(32, 20);
            this.labelQ.TabIndex = 0;
            this.labelQ.Text = "Q. ";
            // 
            // labelA
            // 
            this.labelA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(21, 114);
            this.labelA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(31, 20);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A. ";
            // 
            // radioAnswer1
            // 
            this.radioAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAnswer1.AutoSize = true;
            this.radioAnswer1.Location = new System.Drawing.Point(57, 144);
            this.radioAnswer1.Name = "radioAnswer1";
            this.radioAnswer1.Size = new System.Drawing.Size(85, 24);
            this.radioAnswer1.TabIndex = 3;
            this.radioAnswer1.TabStop = true;
            this.radioAnswer1.Text = "選択肢1";
            this.radioAnswer1.UseVisualStyleBackColor = true;
            // 
            // radioAnswer2
            // 
            this.radioAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAnswer2.AutoSize = true;
            this.radioAnswer2.Location = new System.Drawing.Point(57, 194);
            this.radioAnswer2.Name = "radioAnswer2";
            this.radioAnswer2.Size = new System.Drawing.Size(85, 24);
            this.radioAnswer2.TabIndex = 4;
            this.radioAnswer2.TabStop = true;
            this.radioAnswer2.Text = "選択肢2";
            this.radioAnswer2.UseVisualStyleBackColor = true;
            // 
            // radioAnswer3
            // 
            this.radioAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAnswer3.AutoSize = true;
            this.radioAnswer3.Location = new System.Drawing.Point(57, 242);
            this.radioAnswer3.Name = "radioAnswer3";
            this.radioAnswer3.Size = new System.Drawing.Size(85, 24);
            this.radioAnswer3.TabIndex = 5;
            this.radioAnswer3.TabStop = true;
            this.radioAnswer3.Text = "選択肢3";
            this.radioAnswer3.UseVisualStyleBackColor = true;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswer.Location = new System.Drawing.Point(185, 298);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(112, 39);
            this.buttonAnswer.TabIndex = 6;
            this.buttonAnswer.Text = "答えへ";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(53, 21);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(87, 20);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "クイズのお題";
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.radioAnswer3);
            this.Controls.Add(this.radioAnswer2);
            this.Controls.Add(this.radioAnswer1);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelQ);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormQuiz";
            this.Text = "クイズアプリ";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.RadioButton radioAnswer1;
        private System.Windows.Forms.RadioButton radioAnswer2;
        private System.Windows.Forms.RadioButton radioAnswer3;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Label labelQuestion;
    }
}

