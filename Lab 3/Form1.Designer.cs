
namespace Lab_3
{
    partial class valueCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(valueCalculator));
            this.labelEnterRadius = new System.Windows.Forms.Label();
            this.RadiusTxt = new System.Windows.Forms.TextBox();
            this.labelDiameter = new System.Windows.Forms.Label();
            this.labelSurfaceArea = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelDiameterOutput = new System.Windows.Forms.Label();
            this.labelSurfaceAreaOutput = new System.Windows.Forms.Label();
            this.labelVolumeOutput = new System.Windows.Forms.Label();
            this.buttonCalcValues = new System.Windows.Forms.Button();
            this.pictureBoxSphereTopLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxSphereBottomRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSphereTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSphereBottomRight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterRadius
            // 
            this.labelEnterRadius.AutoSize = true;
            this.labelEnterRadius.Location = new System.Drawing.Point(176, 62);
            this.labelEnterRadius.Name = "labelEnterRadius";
            this.labelEnterRadius.Size = new System.Drawing.Size(90, 13);
            this.labelEnterRadius.TabIndex = 0;
            this.labelEnterRadius.Text = "Radius of sphere:";
            // 
            // RadiusTxt
            // 
            this.RadiusTxt.Location = new System.Drawing.Point(272, 59);
            this.RadiusTxt.Name = "RadiusTxt";
            this.RadiusTxt.Size = new System.Drawing.Size(100, 20);
            this.RadiusTxt.TabIndex = 1;
            // 
            // labelDiameter
            // 
            this.labelDiameter.AutoSize = true;
            this.labelDiameter.Location = new System.Drawing.Point(37, 199);
            this.labelDiameter.Name = "labelDiameter";
            this.labelDiameter.Size = new System.Drawing.Size(52, 13);
            this.labelDiameter.TabIndex = 2;
            this.labelDiameter.Text = "Diameter:";
            // 
            // labelSurfaceArea
            // 
            this.labelSurfaceArea.AutoSize = true;
            this.labelSurfaceArea.Location = new System.Drawing.Point(17, 241);
            this.labelSurfaceArea.Name = "labelSurfaceArea";
            this.labelSurfaceArea.Size = new System.Drawing.Size(72, 13);
            this.labelSurfaceArea.TabIndex = 3;
            this.labelSurfaceArea.Text = "Surface Area:";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(44, 280);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(45, 13);
            this.labelVolume.TabIndex = 4;
            this.labelVolume.Text = "Volume:";
            // 
            // labelDiameterOutput
            // 
            this.labelDiameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiameterOutput.Location = new System.Drawing.Point(97, 198);
            this.labelDiameterOutput.Name = "labelDiameterOutput";
            this.labelDiameterOutput.Size = new System.Drawing.Size(100, 25);
            this.labelDiameterOutput.TabIndex = 5;
            // 
            // labelSurfaceAreaOutput
            // 
            this.labelSurfaceAreaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSurfaceAreaOutput.Location = new System.Drawing.Point(97, 240);
            this.labelSurfaceAreaOutput.Name = "labelSurfaceAreaOutput";
            this.labelSurfaceAreaOutput.Size = new System.Drawing.Size(100, 25);
            this.labelSurfaceAreaOutput.TabIndex = 6;
            // 
            // labelVolumeOutput
            // 
            this.labelVolumeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVolumeOutput.Location = new System.Drawing.Point(97, 279);
            this.labelVolumeOutput.Name = "labelVolumeOutput";
            this.labelVolumeOutput.Size = new System.Drawing.Size(100, 25);
            this.labelVolumeOutput.TabIndex = 7;
            // 
            // buttonCalcValues
            // 
            this.buttonCalcValues.Location = new System.Drawing.Point(235, 99);
            this.buttonCalcValues.Name = "buttonCalcValues";
            this.buttonCalcValues.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcValues.TabIndex = 8;
            this.buttonCalcValues.Text = "Calculate";
            this.buttonCalcValues.UseVisualStyleBackColor = true;
            this.buttonCalcValues.Click += new System.EventHandler(this.buttonCalcValues_Click);
            // 
            // pictureBoxSphereTopLeft
            // 
            this.pictureBoxSphereTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSphereTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSphereTopLeft.Image")));
            this.pictureBoxSphereTopLeft.Location = new System.Drawing.Point(20, 12);
            this.pictureBoxSphereTopLeft.Name = "pictureBoxSphereTopLeft";
            this.pictureBoxSphereTopLeft.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxSphereTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSphereTopLeft.TabIndex = 9;
            this.pictureBoxSphereTopLeft.TabStop = false;
            // 
            // pictureBoxSphereBottomRight
            // 
            this.pictureBoxSphereBottomRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSphereBottomRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSphereBottomRight.Image")));
            this.pictureBoxSphereBottomRight.Location = new System.Drawing.Point(222, 199);
            this.pictureBoxSphereBottomRight.Name = "pictureBoxSphereBottomRight";
            this.pictureBoxSphereBottomRight.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxSphereBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSphereBottomRight.TabIndex = 10;
            this.pictureBoxSphereBottomRight.TabStop = false;
            // 
            // valueCalculator
            // 
            this.AcceptButton = this.buttonCalcValues;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBoxSphereBottomRight);
            this.Controls.Add(this.pictureBoxSphereTopLeft);
            this.Controls.Add(this.buttonCalcValues);
            this.Controls.Add(this.labelVolumeOutput);
            this.Controls.Add(this.labelSurfaceAreaOutput);
            this.Controls.Add(this.labelDiameterOutput);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelSurfaceArea);
            this.Controls.Add(this.labelDiameter);
            this.Controls.Add(this.RadiusTxt);
            this.Controls.Add(this.labelEnterRadius);
            this.Name = "valueCalculator";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSphereTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSphereBottomRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterRadius;
        private System.Windows.Forms.TextBox RadiusTxt;
        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.Label labelSurfaceArea;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelDiameterOutput;
        private System.Windows.Forms.Label labelSurfaceAreaOutput;
        private System.Windows.Forms.Label labelVolumeOutput;
        private System.Windows.Forms.Button buttonCalcValues;
        private System.Windows.Forms.PictureBox pictureBoxSphereTopLeft;
        private System.Windows.Forms.PictureBox pictureBoxSphereBottomRight;
    }
}

