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
            this.btn_Group = new System.Windows.Forms.Button();
            this.btn_Ungroup = new System.Windows.Forms.Button();
            this.dgv_Massive = new System.Windows.Forms.DataGridView();
            this.clm_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_OK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exec = new System.Windows.Forms.Button();
            this.SB_Fi = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SB_Tetta = new System.Windows.Forms.HScrollBar();
            this.tb_Fi = new System.Windows.Forms.TextBox();
            this.tb_Tetta = new System.Windows.Forms.TextBox();
            this.tb_Z = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SB_Z = new System.Windows.Forms.HScrollBar();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Normal = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb1_X = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb1_Y = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb1_Z = new System.Windows.Forms.TextBox();
            this.tb2_Z = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb2_Y = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb2_X = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSpecialLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Median = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Height = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Bisection = new System.Windows.Forms.ToolStripMenuItem();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Morphing = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_StartPos = new System.Windows.Forms.Button();
            this.btn_SecondPos = new System.Windows.Forms.Button();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Axes = new System.Windows.Forms.CheckBox();
            this.btn_LocalEx = new System.Windows.Forms.Button();
            this.btn_ChooseLocal = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_yloc = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_xloc = new System.Windows.Forms.TextBox();
            this.tb_zloc = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_Local = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Massive)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Morphing)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Draw
            // 
            this.PB_Draw.Location = new System.Drawing.Point(2, 34);
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
            this.btn_CreateLine.Location = new System.Drawing.Point(657, 45);
            this.btn_CreateLine.Name = "btn_CreateLine";
            this.btn_CreateLine.Size = new System.Drawing.Size(132, 22);
            this.btn_CreateLine.TabIndex = 1;
            this.btn_CreateLine.Text = "Create";
            this.btn_CreateLine.UseVisualStyleBackColor = true;
            this.btn_CreateLine.Click += new System.EventHandler(this.btn_CreateLine_Click);
            // 
            // btn_DeleteLine
            // 
            this.btn_DeleteLine.Location = new System.Drawing.Point(657, 74);
            this.btn_DeleteLine.Name = "btn_DeleteLine";
            this.btn_DeleteLine.Size = new System.Drawing.Size(132, 23);
            this.btn_DeleteLine.TabIndex = 2;
            this.btn_DeleteLine.Text = "Delete";
            this.btn_DeleteLine.UseVisualStyleBackColor = true;
            this.btn_DeleteLine.Click += new System.EventHandler(this.btn_DeleteLine_Click);
            // 
            // TB_Mouse_Coordinates
            // 
            this.TB_Mouse_Coordinates.Location = new System.Drawing.Point(12, 496);
            this.TB_Mouse_Coordinates.Name = "TB_Mouse_Coordinates";
            this.TB_Mouse_Coordinates.ReadOnly = true;
            this.TB_Mouse_Coordinates.Size = new System.Drawing.Size(131, 20);
            this.TB_Mouse_Coordinates.TabIndex = 3;
            // 
            // btn_Group
            // 
            this.btn_Group.Location = new System.Drawing.Point(658, 103);
            this.btn_Group.Name = "btn_Group";
            this.btn_Group.Size = new System.Drawing.Size(131, 23);
            this.btn_Group.TabIndex = 4;
            this.btn_Group.Text = "Group";
            this.btn_Group.UseVisualStyleBackColor = true;
            this.btn_Group.Click += new System.EventHandler(this.btn_Group_Click);
            // 
            // btn_Ungroup
            // 
            this.btn_Ungroup.Location = new System.Drawing.Point(658, 132);
            this.btn_Ungroup.Name = "btn_Ungroup";
            this.btn_Ungroup.Size = new System.Drawing.Size(131, 23);
            this.btn_Ungroup.TabIndex = 5;
            this.btn_Ungroup.Text = "Ungroup";
            this.btn_Ungroup.UseVisualStyleBackColor = true;
            this.btn_Ungroup.Click += new System.EventHandler(this.btn_Ungroup_Click);
            // 
            // dgv_Massive
            // 
            this.dgv_Massive.AllowUserToAddRows = false;
            this.dgv_Massive.AllowUserToDeleteRows = false;
            this.dgv_Massive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Massive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_X,
            this.clm_Y,
            this.clm_Z,
            this.clm_OK});
            this.dgv_Massive.Location = new System.Drawing.Point(659, 162);
            this.dgv_Massive.MultiSelect = false;
            this.dgv_Massive.Name = "dgv_Massive";
            this.dgv_Massive.Size = new System.Drawing.Size(390, 150);
            this.dgv_Massive.TabIndex = 6;
            // 
            // clm_X
            // 
            this.clm_X.HeaderText = "X";
            this.clm_X.Name = "clm_X";
            // 
            // clm_Y
            // 
            this.clm_Y.HeaderText = "Y";
            this.clm_Y.Name = "clm_Y";
            // 
            // clm_Z
            // 
            this.clm_Z.HeaderText = "Z";
            this.clm_Z.Name = "clm_Z";
            // 
            // clm_OK
            // 
            this.clm_OK.HeaderText = "OK";
            this.clm_OK.Name = "clm_OK";
            // 
            // btn_Exec
            // 
            this.btn_Exec.Location = new System.Drawing.Point(914, 318);
            this.btn_Exec.Name = "btn_Exec";
            this.btn_Exec.Size = new System.Drawing.Size(132, 22);
            this.btn_Exec.TabIndex = 7;
            this.btn_Exec.Text = "Execute";
            this.btn_Exec.UseVisualStyleBackColor = true;
            this.btn_Exec.Click += new System.EventHandler(this.btn_Exec_Click);
            // 
            // SB_Fi
            // 
            this.SB_Fi.Location = new System.Drawing.Point(659, 332);
            this.SB_Fi.Maximum = 72;
            this.SB_Fi.Name = "SB_Fi";
            this.SB_Fi.Size = new System.Drawing.Size(118, 17);
            this.SB_Fi.TabIndex = 9;
            this.SB_Fi.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SB_Fi_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(764, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "2pi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Тетта";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "2pi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SB_Tetta
            // 
            this.SB_Tetta.Location = new System.Drawing.Point(659, 381);
            this.SB_Tetta.Maximum = 72;
            this.SB_Tetta.Name = "SB_Tetta";
            this.SB_Tetta.Size = new System.Drawing.Size(118, 17);
            this.SB_Tetta.TabIndex = 13;
            this.SB_Tetta.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // tb_Fi
            // 
            this.tb_Fi.Location = new System.Drawing.Point(786, 332);
            this.tb_Fi.Name = "tb_Fi";
            this.tb_Fi.ReadOnly = true;
            this.tb_Fi.Size = new System.Drawing.Size(44, 20);
            this.tb_Fi.TabIndex = 17;
            // 
            // tb_Tetta
            // 
            this.tb_Tetta.Location = new System.Drawing.Point(786, 381);
            this.tb_Tetta.Name = "tb_Tetta";
            this.tb_Tetta.ReadOnly = true;
            this.tb_Tetta.Size = new System.Drawing.Size(44, 20);
            this.tb_Tetta.TabIndex = 18;
            // 
            // tb_Z
            // 
            this.tb_Z.Location = new System.Drawing.Point(786, 430);
            this.tb_Z.Name = "tb_Z";
            this.tb_Z.ReadOnly = true;
            this.tb_Z.Size = new System.Drawing.Size(44, 20);
            this.tb_Z.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Z схода";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "400";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(661, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "50";
            // 
            // SB_Z
            // 
            this.SB_Z.Location = new System.Drawing.Point(659, 430);
            this.SB_Z.Maximum = 400;
            this.SB_Z.Minimum = 50;
            this.SB_Z.Name = "SB_Z";
            this.SB_Z.Size = new System.Drawing.Size(118, 17);
            this.SB_Z.TabIndex = 19;
            this.SB_Z.Value = 50;
            this.SB_Z.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(755, 463);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 24;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Normal
            // 
            this.btn_Normal.Location = new System.Drawing.Point(851, 379);
            this.btn_Normal.Name = "btn_Normal";
            this.btn_Normal.Size = new System.Drawing.Size(75, 23);
            this.btn_Normal.TabIndex = 25;
            this.btn_Normal.Text = "ToNormal";
            this.btn_Normal.UseVisualStyleBackColor = true;
            this.btn_Normal.Click += new System.EventHandler(this.btn_Normal_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(807, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "1 точка";
            // 
            // tb1_X
            // 
            this.tb1_X.Location = new System.Drawing.Point(810, 62);
            this.tb1_X.Name = "tb1_X";
            this.tb1_X.ReadOnly = true;
            this.tb1_X.Size = new System.Drawing.Size(41, 20);
            this.tb1_X.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(795, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(855, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Y";
            // 
            // tb1_Y
            // 
            this.tb1_Y.Location = new System.Drawing.Point(870, 62);
            this.tb1_Y.Name = "tb1_Y";
            this.tb1_Y.ReadOnly = true;
            this.tb1_Y.Size = new System.Drawing.Size(41, 20);
            this.tb1_Y.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(917, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Z";
            // 
            // tb1_Z
            // 
            this.tb1_Z.Location = new System.Drawing.Point(937, 62);
            this.tb1_Z.Name = "tb1_Z";
            this.tb1_Z.Size = new System.Drawing.Size(54, 20);
            this.tb1_Z.TabIndex = 32;
            // 
            // tb2_Z
            // 
            this.tb2_Z.Location = new System.Drawing.Point(937, 106);
            this.tb2_Z.Name = "tb2_Z";
            this.tb2_Z.Size = new System.Drawing.Size(54, 20);
            this.tb2_Z.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(917, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Z";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(855, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Y";
            // 
            // tb2_Y
            // 
            this.tb2_Y.Location = new System.Drawing.Point(870, 106);
            this.tb2_Y.Name = "tb2_Y";
            this.tb2_Y.ReadOnly = true;
            this.tb2_Y.Size = new System.Drawing.Size(41, 20);
            this.tb2_Y.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(795, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "X";
            // 
            // tb2_X
            // 
            this.tb2_X.Location = new System.Drawing.Point(810, 106);
            this.tb2_X.Name = "tb2_X";
            this.tb2_X.ReadOnly = true;
            this.tb2_X.Size = new System.Drawing.Size(41, 20);
            this.tb2_X.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(807, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "2 точка";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(998, 79);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(54, 23);
            this.btn_Change.TabIndex = 40;
            this.btn_Change.Text = "Update";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.lOADToolStripMenuItem,
            this.sAVEASToolStripMenuItem,
            this.createSpecialLineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOADToolStripMenuItem
            // 
            this.lOADToolStripMenuItem.Name = "lOADToolStripMenuItem";
            this.lOADToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.lOADToolStripMenuItem.Text = "LOAD";
            this.lOADToolStripMenuItem.Click += new System.EventHandler(this.lOADToolStripMenuItem_Click);
            // 
            // sAVEASToolStripMenuItem
            // 
            this.sAVEASToolStripMenuItem.Name = "sAVEASToolStripMenuItem";
            this.sAVEASToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sAVEASToolStripMenuItem.Text = "SAVE AS...";
            this.sAVEASToolStripMenuItem.Click += new System.EventHandler(this.sAVEASToolStripMenuItem_Click);
            // 
            // createSpecialLineToolStripMenuItem
            // 
            this.createSpecialLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Median,
            this.tsm_Height,
            this.tsm_Bisection});
            this.createSpecialLineToolStripMenuItem.Name = "createSpecialLineToolStripMenuItem";
            this.createSpecialLineToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.createSpecialLineToolStripMenuItem.Text = "Create Special Line";
            // 
            // tsm_Median
            // 
            this.tsm_Median.Name = "tsm_Median";
            this.tsm_Median.Size = new System.Drawing.Size(122, 22);
            this.tsm_Median.Text = "Median";
            this.tsm_Median.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // tsm_Height
            // 
            this.tsm_Height.Name = "tsm_Height";
            this.tsm_Height.Size = new System.Drawing.Size(122, 22);
            this.tsm_Height.Text = "Height";
            this.tsm_Height.Click += new System.EventHandler(this.tsm_Height_Click);
            // 
            // tsm_Bisection
            // 
            this.tsm_Bisection.Name = "tsm_Bisection";
            this.tsm_Bisection.Size = new System.Drawing.Size(122, 22);
            this.tsm_Bisection.Text = "Bisection";
            this.tsm_Bisection.Click += new System.EventHandler(this.tsm_Bisection_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(671, 501);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Морфинг";
            // 
            // tb_Morphing
            // 
            this.tb_Morphing.Location = new System.Drawing.Point(740, 494);
            this.tb_Morphing.Name = "tb_Morphing";
            this.tb_Morphing.Size = new System.Drawing.Size(222, 45);
            this.tb_Morphing.TabIndex = 43;
            this.tb_Morphing.Scroll += new System.EventHandler(this.tb_Morphing_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(747, 526);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(943, 526);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "1";
            // 
            // btn_StartPos
            // 
            this.btn_StartPos.Location = new System.Drawing.Point(524, 501);
            this.btn_StartPos.Name = "btn_StartPos";
            this.btn_StartPos.Size = new System.Drawing.Size(128, 23);
            this.btn_StartPos.TabIndex = 46;
            this.btn_StartPos.Text = "First Figure";
            this.btn_StartPos.UseVisualStyleBackColor = true;
            this.btn_StartPos.Click += new System.EventHandler(this.btn_StartPos_Click);
            // 
            // btn_SecondPos
            // 
            this.btn_SecondPos.Location = new System.Drawing.Point(524, 530);
            this.btn_SecondPos.Name = "btn_SecondPos";
            this.btn_SecondPos.Size = new System.Drawing.Size(128, 23);
            this.btn_SecondPos.TabIndex = 47;
            this.btn_SecondPos.Text = "Second Figure";
            this.btn_SecondPos.UseVisualStyleBackColor = true;
            this.btn_SecondPos.Click += new System.EventHandler(this.btn_SecondPos_Click);
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // CB_Axes
            // 
            this.CB_Axes.AutoSize = true;
            this.CB_Axes.Location = new System.Drawing.Point(150, 498);
            this.CB_Axes.Name = "CB_Axes";
            this.CB_Axes.Size = new System.Drawing.Size(46, 17);
            this.CB_Axes.TabIndex = 48;
            this.CB_Axes.Text = "Оси";
            this.CB_Axes.UseVisualStyleBackColor = true;
            this.CB_Axes.CheckedChanged += new System.EventHandler(this.CB_Axes_CheckedChanged);
            // 
            // btn_LocalEx
            // 
            this.btn_LocalEx.Enabled = false;
            this.btn_LocalEx.Location = new System.Drawing.Point(914, 344);
            this.btn_LocalEx.Name = "btn_LocalEx";
            this.btn_LocalEx.Size = new System.Drawing.Size(132, 23);
            this.btn_LocalEx.TabIndex = 49;
            this.btn_LocalEx.Text = "Execute Local";
            this.btn_LocalEx.UseVisualStyleBackColor = true;
            this.btn_LocalEx.Click += new System.EventHandler(this.btn_LocalEx_Click);
            // 
            // btn_ChooseLocal
            // 
            this.btn_ChooseLocal.Location = new System.Drawing.Point(207, 548);
            this.btn_ChooseLocal.Name = "btn_ChooseLocal";
            this.btn_ChooseLocal.Size = new System.Drawing.Size(132, 23);
            this.btn_ChooseLocal.TabIndex = 50;
            this.btn_ChooseLocal.Text = "Choose Local";
            this.btn_ChooseLocal.UseVisualStyleBackColor = true;
            this.btn_ChooseLocal.Click += new System.EventHandler(this.btn_ChooseLocal_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(238, 525);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 54;
            this.label22.Text = "Y";
            // 
            // tb_yloc
            // 
            this.tb_yloc.Location = new System.Drawing.Point(253, 522);
            this.tb_yloc.MaxLength = 4;
            this.tb_yloc.Name = "tb_yloc";
            this.tb_yloc.Size = new System.Drawing.Size(41, 20);
            this.tb_yloc.TabIndex = 53;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(178, 525);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 52;
            this.label23.Text = "X";
            // 
            // tb_xloc
            // 
            this.tb_xloc.Location = new System.Drawing.Point(193, 522);
            this.tb_xloc.MaxLength = 4;
            this.tb_xloc.Name = "tb_xloc";
            this.tb_xloc.Size = new System.Drawing.Size(41, 20);
            this.tb_xloc.TabIndex = 51;
            // 
            // tb_zloc
            // 
            this.tb_zloc.Location = new System.Drawing.Point(317, 522);
            this.tb_zloc.MaxLength = 5;
            this.tb_zloc.Name = "tb_zloc";
            this.tb_zloc.Size = new System.Drawing.Size(42, 20);
            this.tb_zloc.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(297, 525);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "Z";
            // 
            // lb_Local
            // 
            this.lb_Local.AutoSize = true;
            this.lb_Local.ForeColor = System.Drawing.Color.Red;
            this.lb_Local.Location = new System.Drawing.Point(346, 553);
            this.lb_Local.Name = "lb_Local";
            this.lb_Local.Size = new System.Drawing.Size(92, 13);
            this.lb_Local.TabIndex = 57;
            this.lb_Local.Text = "Local Not Chosen";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 583);
            this.Controls.Add(this.lb_Local);
            this.Controls.Add(this.tb_zloc);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tb_yloc);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tb_xloc);
            this.Controls.Add(this.btn_ChooseLocal);
            this.Controls.Add(this.btn_LocalEx);
            this.Controls.Add(this.CB_Axes);
            this.Controls.Add(this.btn_SecondPos);
            this.Controls.Add(this.btn_StartPos);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tb_Morphing);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.tb2_Z);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb2_Y);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb2_X);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb1_Z);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb1_Y);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb1_X);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Normal);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.tb_Z);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SB_Z);
            this.Controls.Add(this.tb_Tetta);
            this.Controls.Add(this.tb_Fi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SB_Tetta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SB_Fi);
            this.Controls.Add(this.btn_Exec);
            this.Controls.Add(this.dgv_Massive);
            this.Controls.Add(this.btn_Ungroup);
            this.Controls.Add(this.btn_Group);
            this.Controls.Add(this.TB_Mouse_Coordinates);
            this.Controls.Add(this.btn_DeleteLine);
            this.Controls.Add(this.btn_CreateLine);
            this.Controls.Add(this.PB_Draw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Graphics Project";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Massive)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Morphing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Draw;
        private System.Windows.Forms.Button btn_CreateLine;
        private System.Windows.Forms.Button btn_DeleteLine;
        private System.Windows.Forms.TextBox TB_Mouse_Coordinates;
        private System.Windows.Forms.Button btn_Group;
        private System.Windows.Forms.Button btn_Ungroup;
        private System.Windows.Forms.DataGridView dgv_Massive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_OK;
        private System.Windows.Forms.Button btn_Exec;
        private System.Windows.Forms.HScrollBar SB_Fi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar SB_Tetta;
        private System.Windows.Forms.TextBox tb_Fi;
        private System.Windows.Forms.TextBox tb_Tetta;
        private System.Windows.Forms.TextBox tb_Z;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HScrollBar SB_Z;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Normal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb1_X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb1_Y;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb1_Z;
        private System.Windows.Forms.TextBox tb2_Z;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb2_Y;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb2_X;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEASToolStripMenuItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar tb_Morphing;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_StartPos;
        private System.Windows.Forms.Button btn_SecondPos;
        private System.Windows.Forms.ToolStripMenuItem createSpecialLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Median;
        private System.Windows.Forms.ToolStripMenuItem tsm_Height;
        private System.Windows.Forms.ToolStripMenuItem tsm_Bisection;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.CheckBox CB_Axes;
        private System.Windows.Forms.Button btn_LocalEx;
        private System.Windows.Forms.Button btn_ChooseLocal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_yloc;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_xloc;
        private System.Windows.Forms.TextBox tb_zloc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_Local;
    }
}

