namespace Graphics_WinForm_Program
{
    partial class frm_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PB_Draw = new System.Windows.Forms.PictureBox();
            this.btn_CreateLine = new System.Windows.Forms.Button();
            this.btn_DeleteLine = new System.Windows.Forms.Button();
            this.TB_Mouse_Coordinates = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Draw
            // 
            this.PB_Draw.Location = new System.Drawing.Point(1, 1);
            this.PB_Draw.Name = "PB_Draw";
            this.PB_Draw.Size = new System.Drawing.Size(650, 450);
            this.PB_Draw.TabIndex = 0;
            this.PB_Draw.TabStop = false;
            this.PB_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Draw_Paint);
            this.PB_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Draw_MouseDown);
            this.PB_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_Draw_MouseMove);
            this.PB_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Draw_MouseUp);
            // 
            // btn_CreateLine
            // 
            this.btn_CreateLine.Location = new System.Drawing.Point(656, 12);
            this.btn_CreateLine.Name = "btn_CreateLine";
            this.btn_CreateLine.Size = new System.Drawing.Size(132, 22);
            this.btn_CreateLine.TabIndex = 1;
            this.btn_CreateLine.Text = "Create";
            this.btn_CreateLine.UseVisualStyleBackColor = true;
            this.btn_CreateLine.Click += new System.EventHandler(this.btn_CreateLine_Click);
            // 
            // btn_DeleteLine
            // 
            this.btn_DeleteLine.Location = new System.Drawing.Point(656, 41);
            this.btn_DeleteLine.Name = "btn_DeleteLine";
            this.btn_DeleteLine.Size = new System.Drawing.Size(132, 23);
            this.btn_DeleteLine.TabIndex = 2;
            this.btn_DeleteLine.Text = "Delete";
            this.btn_DeleteLine.UseVisualStyleBackColor = true;
            this.btn_DeleteLine.Click += new System.EventHandler(this.btn_DeleteLine_Click);
            // 
            // TB_Mouse_Coordinates
            // 
            this.TB_Mouse_Coordinates.Location = new System.Drawing.Point(676, 420);
            this.TB_Mouse_Coordinates.Name = "TB_Mouse_Coordinates";
            this.TB_Mouse_Coordinates.ReadOnly = true;
            this.TB_Mouse_Coordinates.Size = new System.Drawing.Size(100, 20);
            this.TB_Mouse_Coordinates.TabIndex = 3;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.TB_Mouse_Coordinates);
            this.Controls.Add(this.btn_DeleteLine);
            this.Controls.Add(this.btn_CreateLine);
            this.Controls.Add(this.PB_Draw);
            this.Name = "frm_Main";
            this.Text = "Graphics Project";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Draw;
        private System.Windows.Forms.Button btn_CreateLine;
        private System.Windows.Forms.Button btn_DeleteLine;
        private System.Windows.Forms.TextBox TB_Mouse_Coordinates;
    }
}

