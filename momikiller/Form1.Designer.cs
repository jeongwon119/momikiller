
namespace momikiller
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Block = new System.Windows.Forms.Button();
            this.btn_Allow = new System.Windows.Forms.Button();
            this.btn_Reboot = new System.Windows.Forms.Button();
            this.lb_BlockCheck = new System.Windows.Forms.Label();
            this.lb_AllowCheck = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Block
            // 
            this.btn_Block.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Block.ForeColor = System.Drawing.Color.Black;
            this.btn_Block.Location = new System.Drawing.Point(54, 72);
            this.btn_Block.Name = "btn_Block";
            this.btn_Block.Size = new System.Drawing.Size(205, 82);
            this.btn_Block.TabIndex = 0;
            this.btn_Block.Text = "맘아이 차단";
            this.btn_Block.UseVisualStyleBackColor = true;
            this.btn_Block.Click += new System.EventHandler(this.btn_Blockclick);
            // 
            // btn_Allow
            // 
            this.btn_Allow.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Allow.Location = new System.Drawing.Point(359, 72);
            this.btn_Allow.Name = "btn_Allow";
            this.btn_Allow.Size = new System.Drawing.Size(205, 82);
            this.btn_Allow.TabIndex = 1;
            this.btn_Allow.Text = "맘아이 허용";
            this.btn_Allow.UseVisualStyleBackColor = true;
            this.btn_Allow.Click += new System.EventHandler(this.btn_Allow_Click);
            // 
            // btn_Reboot
            // 
            this.btn_Reboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Reboot.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Reboot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Reboot.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Reboot.Location = new System.Drawing.Point(197, 234);
            this.btn_Reboot.Name = "btn_Reboot";
            this.btn_Reboot.Size = new System.Drawing.Size(205, 82);
            this.btn_Reboot.TabIndex = 2;
            this.btn_Reboot.Text = "재부팅";
            this.btn_Reboot.UseVisualStyleBackColor = false;
            this.btn_Reboot.Visible = false;
            this.btn_Reboot.Click += new System.EventHandler(this.btn_Reboot_Click);
            // 
            // lb_BlockCheck
            // 
            this.lb_BlockCheck.AutoSize = true;
            this.lb_BlockCheck.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BlockCheck.Location = new System.Drawing.Point(102, 171);
            this.lb_BlockCheck.Name = "lb_BlockCheck";
            this.lb_BlockCheck.Size = new System.Drawing.Size(95, 25);
            this.lb_BlockCheck.TabIndex = 3;
            this.lb_BlockCheck.Text = "차단 결과";
            // 
            // lb_AllowCheck
            // 
            this.lb_AllowCheck.AutoSize = true;
            this.lb_AllowCheck.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_AllowCheck.Location = new System.Drawing.Point(415, 171);
            this.lb_AllowCheck.Name = "lb_AllowCheck";
            this.lb_AllowCheck.Size = new System.Drawing.Size(95, 25);
            this.lb_AllowCheck.TabIndex = 4;
            this.lb_AllowCheck.Text = "허용 결과";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(532, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "초기화";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Clear);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(42, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "초기화 버튼을 한번 누르시고 사용하시는걸 권장합니다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(168, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "한세사이버보안고등학교 류정원";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_AllowCheck);
            this.Controls.Add(this.lb_BlockCheck);
            this.Controls.Add(this.btn_Reboot);
            this.Controls.Add(this.btn_Allow);
            this.Controls.Add(this.btn_Block);
            this.Name = "Form1";
            this.Text = "맘아이 차단";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Block;
        private System.Windows.Forms.Button btn_Allow;
        private System.Windows.Forms.Button btn_Reboot;
        private System.Windows.Forms.Label lb_BlockCheck;
        private System.Windows.Forms.Label lb_AllowCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

