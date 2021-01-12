namespace KGV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.openGLControl2 = new SharpGL.OpenGLControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarRotationZ = new System.Windows.Forms.TrackBar();
            this.trackBarRotationY = new System.Windows.Forms.TrackBar();
            this.checkBoxRotationX = new System.Windows.Forms.CheckBox();
            this.trackBarRotationX = new System.Windows.Forms.TrackBar();
            this.checkBoxRotationY = new System.Windows.Forms.CheckBox();
            this.checkBoxRotationZ = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxLight = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBarTransZ = new System.Windows.Forms.TrackBar();
            this.trackBarTransY = new System.Windows.Forms.TrackBar();
            this.trackBarTransX = new System.Windows.Forms.TrackBar();
            this.checkBoxAxis = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationX)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransX)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.DrawFPS = false;
            resources.ApplyResources(this.openGLControl1, "openGLControl1");
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            // 
            // openGLControl2
            // 
            resources.ApplyResources(this.openGLControl2, "openGLControl2");
            this.openGLControl2.DrawFPS = true;
            this.openGLControl2.FrameRate = 30;
            this.openGLControl2.Name = "openGLControl2";
            this.openGLControl2.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL4_4;
            this.openGLControl2.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl2.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl2.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl2_OpenGLDraw);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.trackBarRotationZ);
            this.panel1.Controls.Add(this.trackBarRotationY);
            this.panel1.Controls.Add(this.checkBoxRotationX);
            this.panel1.Controls.Add(this.trackBarRotationX);
            this.panel1.Controls.Add(this.checkBoxRotationY);
            this.panel1.Controls.Add(this.checkBoxRotationZ);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // trackBarRotationZ
            // 
            resources.ApplyResources(this.trackBarRotationZ, "trackBarRotationZ");
            this.trackBarRotationZ.BackColor = System.Drawing.Color.Black;
            this.trackBarRotationZ.Maximum = 1080;
            this.trackBarRotationZ.Minimum = -1080;
            this.trackBarRotationZ.Name = "trackBarRotationZ";
            this.trackBarRotationZ.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarRotationY
            // 
            resources.ApplyResources(this.trackBarRotationY, "trackBarRotationY");
            this.trackBarRotationY.BackColor = System.Drawing.Color.Black;
            this.trackBarRotationY.Maximum = 1080;
            this.trackBarRotationY.Minimum = -1080;
            this.trackBarRotationY.Name = "trackBarRotationY";
            this.trackBarRotationY.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // checkBoxRotationX
            // 
            resources.ApplyResources(this.checkBoxRotationX, "checkBoxRotationX");
            this.checkBoxRotationX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxRotationX.Name = "checkBoxRotationX";
            this.checkBoxRotationX.UseVisualStyleBackColor = true;
            // 
            // trackBarRotationX
            // 
            resources.ApplyResources(this.trackBarRotationX, "trackBarRotationX");
            this.trackBarRotationX.BackColor = System.Drawing.Color.Black;
            this.trackBarRotationX.Maximum = 1080;
            this.trackBarRotationX.Minimum = -1080;
            this.trackBarRotationX.Name = "trackBarRotationX";
            this.trackBarRotationX.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // checkBoxRotationY
            // 
            resources.ApplyResources(this.checkBoxRotationY, "checkBoxRotationY");
            this.checkBoxRotationY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxRotationY.Name = "checkBoxRotationY";
            this.checkBoxRotationY.UseVisualStyleBackColor = true;
            // 
            // checkBoxRotationZ
            // 
            resources.ApplyResources(this.checkBoxRotationZ, "checkBoxRotationZ");
            this.checkBoxRotationZ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxRotationZ.Name = "checkBoxRotationZ";
            this.checkBoxRotationZ.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.Color.Black;
            this.toolStripComboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBox1.Items"),
            resources.GetString("toolStripComboBox1.Items1"),
            resources.GetString("toolStripComboBox1.Items2"),
            resources.GetString("toolStripComboBox1.Items3"),
            resources.GetString("toolStripComboBox1.Items4"),
            resources.GetString("toolStripComboBox1.Items5"),
            resources.GetString("toolStripComboBox1.Items6"),
            resources.GetString("toolStripComboBox1.Items7"),
            resources.GetString("toolStripComboBox1.Items8"),
            resources.GetString("toolStripComboBox1.Items9"),
            resources.GetString("toolStripComboBox1.Items10"),
            resources.GetString("toolStripComboBox1.Items11"),
            resources.GetString("toolStripComboBox1.Items12"),
            resources.GetString("toolStripComboBox1.Items13"),
            resources.GetString("toolStripComboBox1.Items14")});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            resources.ApplyResources(this.toolStripComboBox1, "toolStripComboBox1");
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.checkBoxAxis);
            this.groupBox2.Controls.Add(this.checkBoxType);
            this.groupBox2.Controls.Add(this.checkBoxLight);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // checkBoxType
            // 
            resources.ApplyResources(this.checkBoxType, "checkBoxType");
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.UseVisualStyleBackColor = true;
            // 
            // checkBoxLight
            // 
            resources.ApplyResources(this.checkBoxLight, "checkBoxLight");
            this.checkBoxLight.Checked = true;
            this.checkBoxLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLight.Name = "checkBoxLight";
            this.checkBoxLight.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.trackBarTransZ);
            this.panel3.Controls.Add(this.trackBarTransY);
            this.panel3.Controls.Add(this.trackBarTransX);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // trackBarTransZ
            // 
            resources.ApplyResources(this.trackBarTransZ, "trackBarTransZ");
            this.trackBarTransZ.BackColor = System.Drawing.Color.Black;
            this.trackBarTransZ.Maximum = 0;
            this.trackBarTransZ.Minimum = -10;
            this.trackBarTransZ.Name = "trackBarTransZ";
            this.trackBarTransZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTransZ.Value = -6;
            // 
            // trackBarTransY
            // 
            resources.ApplyResources(this.trackBarTransY, "trackBarTransY");
            this.trackBarTransY.BackColor = System.Drawing.Color.Black;
            this.trackBarTransY.Minimum = -10;
            this.trackBarTransY.Name = "trackBarTransY";
            this.trackBarTransY.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarTransX
            // 
            resources.ApplyResources(this.trackBarTransX, "trackBarTransX");
            this.trackBarTransX.BackColor = System.Drawing.Color.Black;
            this.trackBarTransX.Minimum = -10;
            this.trackBarTransX.Name = "trackBarTransX";
            this.trackBarTransX.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // checkBoxAxis
            // 
            resources.ApplyResources(this.checkBoxAxis, "checkBoxAxis");
            this.checkBoxAxis.Name = "checkBoxAxis";
            this.checkBoxAxis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openGLControl2);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationX)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private SharpGL.OpenGLControl openGLControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxLight;
        private System.Windows.Forms.CheckBox checkBoxRotationZ;
        private System.Windows.Forms.CheckBox checkBoxRotationY;
        private System.Windows.Forms.CheckBox checkBoxRotationX;
        private System.Windows.Forms.TrackBar trackBarRotationX;
        private System.Windows.Forms.TrackBar trackBarRotationZ;
        private System.Windows.Forms.TrackBar trackBarRotationY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBarTransZ;
        private System.Windows.Forms.TrackBar trackBarTransY;
        private System.Windows.Forms.TrackBar trackBarTransX;
        private System.Windows.Forms.CheckBox checkBoxAxis;
    }
}