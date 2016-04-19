﻿namespace ScorpioConversion
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelRollbackFiles = new System.Windows.Forms.Label();
            this.textRollbackFiles = new System.Windows.Forms.TextBox();
            this.selectRollbackFiles = new System.Windows.Forms.Button();
            this.buttonRollback = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.progressLabel = new System.Windows.Forms.Label();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.selectTransformFiles = new System.Windows.Forms.Button();
            this.textTransformFiles = new System.Windows.Forms.TextBox();
            this.labelTransformFiles = new System.Windows.Forms.Label();
            this.getManager = new System.Windows.Forms.CheckBox();
            this.Language = new System.Windows.Forms.CheckBox();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.buttonRefreshLanguage = new System.Windows.Forms.Button();
            this.buttonCode = new System.Windows.Forms.Button();
            this.programBox = new System.Windows.Forms.ComboBox();
            this.buttonData = new System.Windows.Forms.Button();
            this.checkCreate = new System.Windows.Forms.CheckBox();
            this.buttonSpwan = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.packageText = new System.Windows.Forms.TextBox();
            this.checkCompress = new System.Windows.Forms.CheckBox();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDatabase = new System.Windows.Forms.Button();
            this.textDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTableConfig = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDatabaseConfig = new System.Windows.Forms.Button();
            this.textTableFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTransformFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshNote = new System.Windows.Forms.CheckBox();
            this.clearPath = new System.Windows.Forms.Button();
            this.buttonTinyPNG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRollbackFiles
            // 
            this.labelRollbackFiles.AutoSize = true;
            this.labelRollbackFiles.Location = new System.Drawing.Point(11, 194);
            this.labelRollbackFiles.Name = "labelRollbackFiles";
            this.labelRollbackFiles.Size = new System.Drawing.Size(101, 12);
            this.labelRollbackFiles.TabIndex = 2;
            this.labelRollbackFiles.Text = "选择要反转的文件";
            // 
            // textRollbackFiles
            // 
            this.textRollbackFiles.Location = new System.Drawing.Point(140, 191);
            this.textRollbackFiles.Name = "textRollbackFiles";
            this.textRollbackFiles.ReadOnly = true;
            this.textRollbackFiles.Size = new System.Drawing.Size(232, 21);
            this.textRollbackFiles.TabIndex = 5;
            // 
            // selectRollbackFiles
            // 
            this.selectRollbackFiles.Location = new System.Drawing.Point(377, 189);
            this.selectRollbackFiles.Name = "selectRollbackFiles";
            this.selectRollbackFiles.Size = new System.Drawing.Size(75, 22);
            this.selectRollbackFiles.TabIndex = 8;
            this.selectRollbackFiles.Text = "选择";
            this.selectRollbackFiles.UseVisualStyleBackColor = true;
            this.selectRollbackFiles.Click += new System.EventHandler(this.selectRollbackFiles_Click);
            // 
            // buttonRollback
            // 
            this.buttonRollback.Location = new System.Drawing.Point(462, 189);
            this.buttonRollback.Name = "buttonRollback";
            this.buttonRollback.Size = new System.Drawing.Size(75, 22);
            this.buttonRollback.TabIndex = 10;
            this.buttonRollback.Text = "转换";
            this.buttonRollback.UseVisualStyleBackColor = true;
            this.buttonRollback.Click += new System.EventHandler(this.buttonRollback_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(76, 276);
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(461, 21);
            this.progressBar.Step = 0;
            this.progressBar.TabIndex = 11;
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Interval = 1;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(11, 280);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(47, 12);
            this.progressLabel.TabIndex = 12;
            this.progressLabel.Text = "100/100";
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(462, 160);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(75, 22);
            this.buttonTransform.TabIndex = 9;
            this.buttonTransform.Text = "转换";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // selectTransformFiles
            // 
            this.selectTransformFiles.Location = new System.Drawing.Point(377, 160);
            this.selectTransformFiles.Name = "selectTransformFiles";
            this.selectTransformFiles.Size = new System.Drawing.Size(75, 22);
            this.selectTransformFiles.TabIndex = 7;
            this.selectTransformFiles.Text = "选择";
            this.selectTransformFiles.UseVisualStyleBackColor = true;
            this.selectTransformFiles.Click += new System.EventHandler(this.selectTransformFiles_Click);
            // 
            // textTransformFiles
            // 
            this.textTransformFiles.Location = new System.Drawing.Point(140, 162);
            this.textTransformFiles.Name = "textTransformFiles";
            this.textTransformFiles.ReadOnly = true;
            this.textTransformFiles.Size = new System.Drawing.Size(232, 21);
            this.textTransformFiles.TabIndex = 4;
            // 
            // labelTransformFiles
            // 
            this.labelTransformFiles.AutoSize = true;
            this.labelTransformFiles.Location = new System.Drawing.Point(11, 165);
            this.labelTransformFiles.Name = "labelTransformFiles";
            this.labelTransformFiles.Size = new System.Drawing.Size(101, 12);
            this.labelTransformFiles.TabIndex = 1;
            this.labelTransformFiles.Text = "选择要转换的文件";
            // 
            // getManager
            // 
            this.getManager.AutoSize = true;
            this.getManager.Location = new System.Drawing.Point(13, 80);
            this.getManager.Name = "getManager";
            this.getManager.Size = new System.Drawing.Size(90, 16);
            this.getManager.TabIndex = 35;
            this.getManager.Text = "生成Manager";
            this.getManager.UseVisualStyleBackColor = true;
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(121, 80);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(96, 16);
            this.Language.TabIndex = 44;
            this.Language.Text = "生成多国语言";
            this.Language.UseVisualStyleBackColor = true;
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.Location = new System.Drawing.Point(380, 43);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Size = new System.Drawing.Size(75, 23);
            this.buttonLanguage.TabIndex = 45;
            this.buttonLanguage.Text = "多国语言";
            this.buttonLanguage.UseVisualStyleBackColor = true;
            this.buttonLanguage.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // buttonRefreshLanguage
            // 
            this.buttonRefreshLanguage.Location = new System.Drawing.Point(464, 43);
            this.buttonRefreshLanguage.Name = "buttonRefreshLanguage";
            this.buttonRefreshLanguage.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshLanguage.TabIndex = 46;
            this.buttonRefreshLanguage.Text = "刷新表";
            this.buttonRefreshLanguage.UseVisualStyleBackColor = true;
            this.buttonRefreshLanguage.Click += new System.EventHandler(this.buttonRefreshLanguage_Click);
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(142, 10);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(75, 23);
            this.buttonCode.TabIndex = 49;
            this.buttonCode.Text = "代码路径";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // programBox
            // 
            this.programBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programBox.FormattingEnabled = true;
            this.programBox.Location = new System.Drawing.Point(13, 12);
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(121, 20);
            this.programBox.TabIndex = 50;
            this.programBox.SelectedIndexChanged += new System.EventHandler(this.programBox_SelectedIndexChanged);
            // 
            // buttonData
            // 
            this.buttonData.Location = new System.Drawing.Point(223, 10);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(75, 23);
            this.buttonData.TabIndex = 51;
            this.buttonData.Text = "Data路径";
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // checkCreate
            // 
            this.checkCreate.AutoSize = true;
            this.checkCreate.Location = new System.Drawing.Point(304, 14);
            this.checkCreate.Name = "checkCreate";
            this.checkCreate.Size = new System.Drawing.Size(72, 16);
            this.checkCreate.TabIndex = 52;
            this.checkCreate.Text = "默认生成";
            this.checkCreate.UseVisualStyleBackColor = true;
            this.checkCreate.CheckedChanged += new System.EventHandler(this.checkCreate_CheckedChanged);
            // 
            // buttonSpwan
            // 
            this.buttonSpwan.Location = new System.Drawing.Point(12, 42);
            this.buttonSpwan.Name = "buttonSpwan";
            this.buttonSpwan.Size = new System.Drawing.Size(75, 23);
            this.buttonSpwan.TabIndex = 53;
            this.buttonSpwan.Text = "批量关键字";
            this.buttonSpwan.UseVisualStyleBackColor = true;
            this.buttonSpwan.Click += new System.EventHandler(this.buttonSpwan_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(463, 9);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 54;
            this.buttonLog.Text = "打开日志";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // packageText
            // 
            this.packageText.Location = new System.Drawing.Point(172, 45);
            this.packageText.Name = "packageText";
            this.packageText.Size = new System.Drawing.Size(199, 21);
            this.packageText.TabIndex = 55;
            this.packageText.Text = "PackageName";
            // 
            // checkCompress
            // 
            this.checkCompress.AutoSize = true;
            this.checkCompress.Location = new System.Drawing.Point(379, 14);
            this.checkCompress.Name = "checkCompress";
            this.checkCompress.Size = new System.Drawing.Size(72, 16);
            this.checkCompress.TabIndex = 56;
            this.checkCompress.Text = "gzip压缩";
            this.checkCompress.UseVisualStyleBackColor = true;
            this.checkCompress.CheckedChanged += new System.EventHandler(this.checkCompress_CheckedChanged);
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(377, 217);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(75, 22);
            this.buttonMessage.TabIndex = 60;
            this.buttonMessage.Text = "转换";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(139, 218);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(232, 21);
            this.textMessage.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 57;
            this.label1.Text = "选择协议路径";
            // 
            // buttonDatabase
            // 
            this.buttonDatabase.Location = new System.Drawing.Point(377, 245);
            this.buttonDatabase.Name = "buttonDatabase";
            this.buttonDatabase.Size = new System.Drawing.Size(75, 22);
            this.buttonDatabase.TabIndex = 63;
            this.buttonDatabase.Text = "转换";
            this.buttonDatabase.UseVisualStyleBackColor = true;
            this.buttonDatabase.Click += new System.EventHandler(this.buttonDatabase_Click);
            // 
            // textDatabase
            // 
            this.textDatabase.Location = new System.Drawing.Point(139, 246);
            this.textDatabase.Name = "textDatabase";
            this.textDatabase.Size = new System.Drawing.Size(232, 21);
            this.textDatabase.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 61;
            this.label2.Text = "选择数据库配置路径";
            // 
            // textTableConfig
            // 
            this.textTableConfig.Location = new System.Drawing.Point(140, 105);
            this.textTableConfig.Name = "textTableConfig";
            this.textTableConfig.Size = new System.Drawing.Size(232, 21);
            this.textTableConfig.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "选择配置目录";
            // 
            // buttonDatabaseConfig
            // 
            this.buttonDatabaseConfig.Location = new System.Drawing.Point(462, 244);
            this.buttonDatabaseConfig.Name = "buttonDatabaseConfig";
            this.buttonDatabaseConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonDatabaseConfig.TabIndex = 66;
            this.buttonDatabaseConfig.Text = "拷贝配置";
            this.buttonDatabaseConfig.UseVisualStyleBackColor = true;
            this.buttonDatabaseConfig.Click += new System.EventHandler(this.buttonDatabaseConfig_Click);
            // 
            // textTableFolder
            // 
            this.textTableFolder.Location = new System.Drawing.Point(139, 132);
            this.textTableFolder.Name = "textTableFolder";
            this.textTableFolder.Size = new System.Drawing.Size(232, 21);
            this.textTableFolder.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 67;
            this.label4.Text = "选择要转换的文件夹";
            // 
            // buttonTransformFolder
            // 
            this.buttonTransformFolder.Location = new System.Drawing.Point(377, 132);
            this.buttonTransformFolder.Name = "buttonTransformFolder";
            this.buttonTransformFolder.Size = new System.Drawing.Size(75, 22);
            this.buttonTransformFolder.TabIndex = 69;
            this.buttonTransformFolder.Text = "转换";
            this.buttonTransformFolder.UseVisualStyleBackColor = true;
            this.buttonTransformFolder.Click += new System.EventHandler(this.buttonTransformFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 70;
            this.label5.Text = "PackageName";
            // 
            // refreshNote
            // 
            this.refreshNote.AutoSize = true;
            this.refreshNote.Location = new System.Drawing.Point(235, 80);
            this.refreshNote.Name = "refreshNote";
            this.refreshNote.Size = new System.Drawing.Size(174, 16);
            this.refreshNote.TabIndex = 71;
            this.refreshNote.Text = "刷新表注释(必须关闭Excel)";
            this.refreshNote.UseVisualStyleBackColor = true;
            // 
            // clearPath
            // 
            this.clearPath.Location = new System.Drawing.Point(464, 76);
            this.clearPath.Name = "clearPath";
            this.clearPath.Size = new System.Drawing.Size(75, 23);
            this.clearPath.TabIndex = 72;
            this.clearPath.Text = "清除目录";
            this.clearPath.UseVisualStyleBackColor = true;
            this.clearPath.Click += new System.EventHandler(this.clearPath_Click);
            // 
            // buttonTinyPNG
            // 
            this.buttonTinyPNG.Location = new System.Drawing.Point(464, 108);
            this.buttonTinyPNG.Name = "buttonTinyPNG";
            this.buttonTinyPNG.Size = new System.Drawing.Size(75, 23);
            this.buttonTinyPNG.TabIndex = 73;
            this.buttonTinyPNG.Text = "TinyPNG";
            this.buttonTinyPNG.UseVisualStyleBackColor = true;
            this.buttonTinyPNG.Click += new System.EventHandler(this.buttonTinyPNG_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 306);
            this.Controls.Add(this.buttonTinyPNG);
            this.Controls.Add(this.clearPath);
            this.Controls.Add(this.refreshNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonTransformFolder);
            this.Controls.Add(this.textTableFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDatabaseConfig);
            this.Controls.Add(this.textTableConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDatabase);
            this.Controls.Add(this.textDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkCompress);
            this.Controls.Add(this.packageText);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonSpwan);
            this.Controls.Add(this.checkCreate);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.programBox);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.buttonRefreshLanguage);
            this.Controls.Add(this.buttonLanguage);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.getManager);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonRollback);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.selectRollbackFiles);
            this.Controls.Add(this.selectTransformFiles);
            this.Controls.Add(this.textRollbackFiles);
            this.Controls.Add(this.textTransformFiles);
            this.Controls.Add(this.labelRollbackFiles);
            this.Controls.Add(this.labelTransformFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML_Conversion";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRollbackFiles;

        private System.Windows.Forms.TextBox textRollbackFiles;
        private System.Windows.Forms.Button selectRollbackFiles;
        private System.Windows.Forms.Button buttonRollback;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Button selectTransformFiles;
        private System.Windows.Forms.TextBox textTransformFiles;
        private System.Windows.Forms.Label labelTransformFiles;
        private System.Windows.Forms.CheckBox getManager;
        private System.Windows.Forms.CheckBox Language;
        private System.Windows.Forms.Button buttonLanguage;
        private System.Windows.Forms.Button buttonRefreshLanguage;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.ComboBox programBox;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.CheckBox checkCreate;
        private System.Windows.Forms.Button buttonSpwan;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.TextBox packageText;
        private System.Windows.Forms.CheckBox checkCompress;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDatabase;
        private System.Windows.Forms.TextBox textDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTableConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDatabaseConfig;
        private System.Windows.Forms.TextBox textTableFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTransformFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox refreshNote;
        private System.Windows.Forms.Button clearPath;
        private System.Windows.Forms.Button buttonTinyPNG;
    }
}

