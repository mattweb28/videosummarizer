﻿namespace VideoPlayer
{
    partial class VPOptions
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sceneDurationLabel = new System.Windows.Forms.Label();
            this.shotGenerationLabel = new System.Windows.Forms.Label();
            this.keyFrameLabel = new System.Windows.Forms.Label();
            this.summaryDuration = new System.Windows.Forms.Label();
            this.colorThresholdingButton = new System.Windows.Forms.RadioButton();
            this.audioExcitationButton = new System.Windows.Forms.RadioButton();
            this.sceneMinutesBox = new System.Windows.Forms.TextBox();
            this.sceneSecondsBox = new System.Windows.Forms.TextBox();
            this.sceneMinutesLabel = new System.Windows.Forms.Label();
            this.sceneSecondsLabel = new System.Windows.Forms.Label();
            this.summarySecondsLabel = new System.Windows.Forms.Label();
            this.summaryMinutesLabel = new System.Windows.Forms.Label();
            this.summarySecondsBox = new System.Windows.Forms.TextBox();
            this.summaryMinutesBox = new System.Windows.Forms.TextBox();
            this.shotGenerationGroupBox = new System.Windows.Forms.GroupBox();
            this.keyFrameGroupBox = new System.Windows.Forms.GroupBox();
            this.shotGenerationGroupBox.SuspendLayout();
            this.keyFrameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(118, 243);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 243);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // sceneDurationLabel
            // 
            this.sceneDurationLabel.AutoSize = true;
            this.sceneDurationLabel.Location = new System.Drawing.Point(9, 144);
            this.sceneDurationLabel.Name = "sceneDurationLabel";
            this.sceneDurationLabel.Size = new System.Drawing.Size(81, 13);
            this.sceneDurationLabel.TabIndex = 2;
            this.sceneDurationLabel.Text = "Scene Duration";
            // 
            // shotGenerationLabel
            // 
            this.shotGenerationLabel.AutoSize = true;
            this.shotGenerationLabel.Location = new System.Drawing.Point(77, 9);
            this.shotGenerationLabel.Name = "shotGenerationLabel";
            this.shotGenerationLabel.Size = new System.Drawing.Size(135, 13);
            this.shotGenerationLabel.TabIndex = 3;
            this.shotGenerationLabel.Text = "Shot Generation Algorithms";
            // 
            // keyFrameLabell
            // 
            this.keyFrameLabel.AutoSize = true;
            this.keyFrameLabel.Location = new System.Drawing.Point(88, 73);
            this.keyFrameLabel.Name = "keyFrameLabell";
            this.keyFrameLabel.Size = new System.Drawing.Size(108, 13);
            this.keyFrameLabel.TabIndex = 4;
            this.keyFrameLabel.Text = "Key Frame Algorithms";
            // 
            // summaryDuration
            // 
            this.summaryDuration.AutoSize = true;
            this.summaryDuration.Location = new System.Drawing.Point(9, 193);
            this.summaryDuration.Name = "summaryDuration";
            this.summaryDuration.Size = new System.Drawing.Size(93, 13);
            this.summaryDuration.TabIndex = 5;
            this.summaryDuration.Text = "Summary Duration";
            // 
            // colorThresholdingButton
            // 
            this.colorThresholdingButton.AutoSize = true;
            this.colorThresholdingButton.Checked = true;
            this.colorThresholdingButton.Location = new System.Drawing.Point(6, 12);
            this.colorThresholdingButton.Name = "colorThresholdingButton";
            this.colorThresholdingButton.Size = new System.Drawing.Size(163, 17);
            this.colorThresholdingButton.TabIndex = 6;
            this.colorThresholdingButton.TabStop = true;
            this.colorThresholdingButton.Text = "Color Histogram Thresholding";
            this.colorThresholdingButton.UseVisualStyleBackColor = true;
            // 
            // audioExcitationButton
            // 
            this.audioExcitationButton.AutoSize = true;
            this.audioExcitationButton.Checked = true;
            this.audioExcitationButton.Location = new System.Drawing.Point(6, 11);
            this.audioExcitationButton.Name = "audioExcitationButton";
            this.audioExcitationButton.Size = new System.Drawing.Size(101, 17);
            this.audioExcitationButton.TabIndex = 7;
            this.audioExcitationButton.TabStop = true;
            this.audioExcitationButton.Text = "Audio Excitation";
            this.audioExcitationButton.UseVisualStyleBackColor = true;
            // 
            // sceneMinutesBox
            // 
            this.sceneMinutesBox.Location = new System.Drawing.Point(27, 161);
            this.sceneMinutesBox.Name = "sceneMinutesBox";
            this.sceneMinutesBox.Size = new System.Drawing.Size(54, 20);
            this.sceneMinutesBox.TabIndex = 8;
            // 
            // sceneSecondsBox
            // 
            this.sceneSecondsBox.Location = new System.Drawing.Point(124, 161);
            this.sceneSecondsBox.Name = "sceneSecondsBox";
            this.sceneSecondsBox.Size = new System.Drawing.Size(54, 20);
            this.sceneSecondsBox.TabIndex = 9;
            // 
            // sceneMinutesLabel
            // 
            this.sceneMinutesLabel.AutoSize = true;
            this.sceneMinutesLabel.Location = new System.Drawing.Point(84, 164);
            this.sceneMinutesLabel.Name = "sceneMinutesLabel";
            this.sceneMinutesLabel.Size = new System.Drawing.Size(34, 13);
            this.sceneMinutesLabel.TabIndex = 10;
            this.sceneMinutesLabel.Text = "(mins)";
            // 
            // sceneSecondsLabel
            // 
            this.sceneSecondsLabel.AutoSize = true;
            this.sceneSecondsLabel.Location = new System.Drawing.Point(180, 164);
            this.sceneSecondsLabel.Name = "sceneSecondsLabel";
            this.sceneSecondsLabel.Size = new System.Drawing.Size(35, 13);
            this.sceneSecondsLabel.TabIndex = 11;
            this.sceneSecondsLabel.Text = "(secs)";
            // 
            // summarySecondsLabel
            // 
            this.summarySecondsLabel.AutoSize = true;
            this.summarySecondsLabel.Location = new System.Drawing.Point(180, 212);
            this.summarySecondsLabel.Name = "summarySecondsLabel";
            this.summarySecondsLabel.Size = new System.Drawing.Size(35, 13);
            this.summarySecondsLabel.TabIndex = 15;
            this.summarySecondsLabel.Text = "(secs)";
            // 
            // summaryMinutesLabel
            // 
            this.summaryMinutesLabel.AutoSize = true;
            this.summaryMinutesLabel.Location = new System.Drawing.Point(84, 212);
            this.summaryMinutesLabel.Name = "summaryMinutesLabel";
            this.summaryMinutesLabel.Size = new System.Drawing.Size(34, 13);
            this.summaryMinutesLabel.TabIndex = 14;
            this.summaryMinutesLabel.Text = "(mins)";
            // 
            // summarySecondsBox
            // 
            this.summarySecondsBox.Location = new System.Drawing.Point(124, 209);
            this.summarySecondsBox.Name = "summarySecondsBox";
            this.summarySecondsBox.Size = new System.Drawing.Size(54, 20);
            this.summarySecondsBox.TabIndex = 13;
            // 
            // summaryMinutesBox
            // 
            this.summaryMinutesBox.Location = new System.Drawing.Point(27, 209);
            this.summaryMinutesBox.Name = "summaryMinutesBox";
            this.summaryMinutesBox.Size = new System.Drawing.Size(54, 20);
            this.summaryMinutesBox.TabIndex = 12;
            // 
            // shotGenerationGroupBox
            // 
            this.shotGenerationGroupBox.Controls.Add(this.colorThresholdingButton);
            this.shotGenerationGroupBox.Location = new System.Drawing.Point(12, 24);
            this.shotGenerationGroupBox.Name = "shotGenerationGroupBox";
            this.shotGenerationGroupBox.Size = new System.Drawing.Size(260, 37);
            this.shotGenerationGroupBox.TabIndex = 16;
            this.shotGenerationGroupBox.TabStop = false;
            // 
            // keyFrameGroupBox
            // 
            this.keyFrameGroupBox.Controls.Add(this.audioExcitationButton);
            this.keyFrameGroupBox.Location = new System.Drawing.Point(12, 89);
            this.keyFrameGroupBox.Name = "keyFrameGroupBox";
            this.keyFrameGroupBox.Size = new System.Drawing.Size(260, 34);
            this.keyFrameGroupBox.TabIndex = 17;
            this.keyFrameGroupBox.TabStop = false;
            // 
            // VPOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.keyFrameGroupBox);
            this.Controls.Add(this.summarySecondsLabel);
            this.Controls.Add(this.summaryMinutesLabel);
            this.Controls.Add(this.summarySecondsBox);
            this.Controls.Add(this.summaryMinutesBox);
            this.Controls.Add(this.sceneSecondsLabel);
            this.Controls.Add(this.sceneMinutesLabel);
            this.Controls.Add(this.sceneSecondsBox);
            this.Controls.Add(this.sceneMinutesBox);
            this.Controls.Add(this.summaryDuration);
            this.Controls.Add(this.keyFrameLabel);
            this.Controls.Add(this.shotGenerationLabel);
            this.Controls.Add(this.sceneDurationLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.shotGenerationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 306);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(290, 306);
            this.Name = "VPOptions";
            this.Text = "Summary Options";
            this.shotGenerationGroupBox.ResumeLayout(false);
            this.shotGenerationGroupBox.PerformLayout();
            this.keyFrameGroupBox.ResumeLayout(false);
            this.keyFrameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label sceneDurationLabel;
        private System.Windows.Forms.Label shotGenerationLabel;
        private System.Windows.Forms.Label keyFrameLabel;
        private System.Windows.Forms.Label summaryDuration;
        private System.Windows.Forms.RadioButton colorThresholdingButton;
        private System.Windows.Forms.RadioButton audioExcitationButton;
        private System.Windows.Forms.TextBox sceneMinutesBox;
        private System.Windows.Forms.TextBox sceneSecondsBox;
        private System.Windows.Forms.Label sceneMinutesLabel;
        private System.Windows.Forms.Label sceneSecondsLabel;
        private System.Windows.Forms.Label summarySecondsLabel;
        private System.Windows.Forms.Label summaryMinutesLabel;
        private System.Windows.Forms.TextBox summarySecondsBox;
        private System.Windows.Forms.TextBox summaryMinutesBox;
        public System.Windows.Forms.GroupBox shotGenerationGroupBox;
        public System.Windows.Forms.GroupBox keyFrameGroupBox;
    }
}