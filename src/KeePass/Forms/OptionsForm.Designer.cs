namespace KeePass.Forms
{
	partial class OptionsForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_tabMain = new System.Windows.Forms.TabControl();
			this.m_tabSecurity = new System.Windows.Forms.TabPage();
			this.m_linkSecOptAdm = new System.Windows.Forms.LinkLabel();
			this.m_linkSecOptEx = new System.Windows.Forms.LinkLabel();
			this.m_lblSecOpt = new System.Windows.Forms.Label();
			this.m_numLockAfterGlobalTime = new System.Windows.Forms.NumericUpDown();
			this.m_cbLockAfterGlobalTime = new System.Windows.Forms.CheckBox();
			this.m_lvSecurityOptions = new KeePass.UI.CustomListViewEx();
			this.m_numClipClearTime = new System.Windows.Forms.NumericUpDown();
			this.m_cbClipClearTime = new System.Windows.Forms.CheckBox();
			this.m_numDefaultExpireDays = new System.Windows.Forms.NumericUpDown();
			this.m_cbDefaultExpireDays = new System.Windows.Forms.CheckBox();
			this.m_cbLockAfterTime = new System.Windows.Forms.CheckBox();
			this.m_numLockAfterTime = new System.Windows.Forms.NumericUpDown();
			this.m_tabPolicy = new System.Windows.Forms.TabPage();
			this.m_lvPolicy = new KeePass.UI.CustomListViewEx();
			this.m_linkPolicyInfo = new System.Windows.Forms.LinkLabel();
			this.m_lblPolicyMore = new System.Windows.Forms.Label();
			this.m_lblPolicyRestart = new System.Windows.Forms.Label();
			this.m_lblPolicyIntro = new System.Windows.Forms.Label();
			this.m_tabGui = new System.Windows.Forms.TabPage();
			this.m_cmbEscAction = new System.Windows.Forms.ComboBox();
			this.m_lblEscAction = new System.Windows.Forms.Label();
			this.m_btnCustomAltColor = new System.Windows.Forms.Button();
			this.m_cbCustomAltColor = new System.Windows.Forms.CheckBox();
			this.m_cmbMenuStyle = new System.Windows.Forms.ComboBox();
			this.m_lblMenuStyle = new System.Windows.Forms.Label();
			this.m_btnSelPwFont = new System.Windows.Forms.Button();
			this.m_numMruCount = new System.Windows.Forms.NumericUpDown();
			this.m_lblMruCount = new System.Windows.Forms.Label();
			this.m_btnSelFont = new System.Windows.Forms.Button();
			this.m_lvGuiOptions = new KeePass.UI.CustomListViewEx();
			this.m_lblBannerStyle = new System.Windows.Forms.Label();
			this.m_cmbBannerStyle = new System.Windows.Forms.ComboBox();
			this.m_tabIntegration = new System.Windows.Forms.TabPage();
			this.m_btnHelpSource = new System.Windows.Forms.Button();
			this.m_btnSchemeOverrides = new System.Windows.Forms.Button();
			this.m_cbAutoRun = new System.Windows.Forms.CheckBox();
			this.m_grpFileExt = new System.Windows.Forms.GroupBox();
			this.m_btnFileExtRemove = new System.Windows.Forms.Button();
			this.m_btnFileExtCreate = new System.Windows.Forms.Button();
			this.m_lblFileExtHint = new System.Windows.Forms.Label();
			this.m_grpHotKeys = new System.Windows.Forms.GroupBox();
			this.m_lblAutoTypePassword = new System.Windows.Forms.Label();
			this.m_hkAutoTypePassword = new KeePass.UI.HotKeyControlEx();
			this.m_linkHotKeyHelp = new System.Windows.Forms.LinkLabel();
			this.m_lblAutoTypeSelected = new System.Windows.Forms.Label();
			this.m_hkAutoTypeSelected = new KeePass.UI.HotKeyControlEx();
			this.m_hkShowWindow = new KeePass.UI.HotKeyControlEx();
			this.m_lblAutoType = new System.Windows.Forms.Label();
			this.m_lblShowWindow = new System.Windows.Forms.Label();
			this.m_hkAutoType = new KeePass.UI.HotKeyControlEx();
			this.m_tabAdvanced = new System.Windows.Forms.TabPage();
			this.m_btnProxy = new System.Windows.Forms.Button();
			this.m_lvAdvanced = new KeePass.UI.CustomListViewEx();
			this.m_ttRect = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.m_tabMain.SuspendLayout();
			this.m_tabSecurity.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterGlobalTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numClipClearTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numDefaultExpireDays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterTime)).BeginInit();
			this.m_tabPolicy.SuspendLayout();
			this.m_tabGui.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numMruCount)).BeginInit();
			this.m_tabIntegration.SuspendLayout();
			this.m_grpFileExt.SuspendLayout();
			this.m_grpHotKeys.SuspendLayout();
			this.m_tabAdvanced.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(586, 60);
			this.m_bannerImage.TabIndex = 0;
			this.m_bannerImage.TabStop = false;
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(418, 436);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 0;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(499, 436);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 1;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_tabMain
			// 
			this.m_tabMain.Controls.Add(this.m_tabSecurity);
			this.m_tabMain.Controls.Add(this.m_tabPolicy);
			this.m_tabMain.Controls.Add(this.m_tabGui);
			this.m_tabMain.Controls.Add(this.m_tabIntegration);
			this.m_tabMain.Controls.Add(this.m_tabAdvanced);
			this.m_tabMain.Location = new System.Drawing.Point(12, 66);
			this.m_tabMain.Name = "m_tabMain";
			this.m_tabMain.SelectedIndex = 0;
			this.m_tabMain.Size = new System.Drawing.Size(562, 364);
			this.m_tabMain.TabIndex = 2;
			// 
			// m_tabSecurity
			// 
			this.m_tabSecurity.Controls.Add(this.m_linkSecOptAdm);
			this.m_tabSecurity.Controls.Add(this.m_linkSecOptEx);
			this.m_tabSecurity.Controls.Add(this.m_lblSecOpt);
			this.m_tabSecurity.Controls.Add(this.m_numLockAfterGlobalTime);
			this.m_tabSecurity.Controls.Add(this.m_cbLockAfterGlobalTime);
			this.m_tabSecurity.Controls.Add(this.m_lvSecurityOptions);
			this.m_tabSecurity.Controls.Add(this.m_numClipClearTime);
			this.m_tabSecurity.Controls.Add(this.m_cbClipClearTime);
			this.m_tabSecurity.Controls.Add(this.m_numDefaultExpireDays);
			this.m_tabSecurity.Controls.Add(this.m_cbDefaultExpireDays);
			this.m_tabSecurity.Controls.Add(this.m_cbLockAfterTime);
			this.m_tabSecurity.Controls.Add(this.m_numLockAfterTime);
			this.m_tabSecurity.Location = new System.Drawing.Point(4, 22);
			this.m_tabSecurity.Name = "m_tabSecurity";
			this.m_tabSecurity.Padding = new System.Windows.Forms.Padding(3);
			this.m_tabSecurity.Size = new System.Drawing.Size(554, 338);
			this.m_tabSecurity.TabIndex = 0;
			this.m_tabSecurity.Text = "Security";
			this.m_tabSecurity.UseVisualStyleBackColor = true;
			// 
			// m_linkSecOptAdm
			// 
			this.m_linkSecOptAdm.AutoSize = true;
			this.m_linkSecOptAdm.Location = new System.Drawing.Point(184, 316);
			this.m_linkSecOptAdm.Name = "m_linkSecOptAdm";
			this.m_linkSecOptAdm.Size = new System.Drawing.Size(89, 13);
			this.m_linkSecOptAdm.TabIndex = 11;
			this.m_linkSecOptAdm.TabStop = true;
			this.m_linkSecOptAdm.Text = "For administrators";
			this.m_linkSecOptAdm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSecOptAdmLinkClicked);
			// 
			// m_linkSecOptEx
			// 
			this.m_linkSecOptEx.AutoSize = true;
			this.m_linkSecOptEx.Location = new System.Drawing.Point(119, 316);
			this.m_linkSecOptEx.Name = "m_linkSecOptEx";
			this.m_linkSecOptEx.Size = new System.Drawing.Size(59, 13);
			this.m_linkSecOptEx.TabIndex = 10;
			this.m_linkSecOptEx.TabStop = true;
			this.m_linkSecOptEx.Text = "For experts";
			this.m_linkSecOptEx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSecOptExLinkClicked);
			// 
			// m_lblSecOpt
			// 
			this.m_lblSecOpt.AutoSize = true;
			this.m_lblSecOpt.Location = new System.Drawing.Point(3, 316);
			this.m_lblSecOpt.Name = "m_lblSecOpt";
			this.m_lblSecOpt.Size = new System.Drawing.Size(110, 13);
			this.m_lblSecOpt.TabIndex = 9;
			this.m_lblSecOpt.Text = "More security options:";
			// 
			// m_numLockAfterGlobalTime
			// 
			this.m_numLockAfterGlobalTime.Location = new System.Drawing.Point(327, 37);
			this.m_numLockAfterGlobalTime.Maximum = new decimal(new int[] {
            1209600,
            0,
            0,
            0});
			this.m_numLockAfterGlobalTime.Name = "m_numLockAfterGlobalTime";
			this.m_numLockAfterGlobalTime.Size = new System.Drawing.Size(66, 20);
			this.m_numLockAfterGlobalTime.TabIndex = 3;
			// 
			// m_cbLockAfterGlobalTime
			// 
			this.m_cbLockAfterGlobalTime.AutoSize = true;
			this.m_cbLockAfterGlobalTime.Location = new System.Drawing.Point(6, 38);
			this.m_cbLockAfterGlobalTime.Name = "m_cbLockAfterGlobalTime";
			this.m_cbLockAfterGlobalTime.Size = new System.Drawing.Size(279, 17);
			this.m_cbLockAfterGlobalTime.TabIndex = 2;
			this.m_cbLockAfterGlobalTime.Text = "L&ock workspace after global user inactivity (seconds):";
			this.m_cbLockAfterGlobalTime.UseVisualStyleBackColor = true;
			this.m_cbLockAfterGlobalTime.CheckedChanged += new System.EventHandler(this.OnLockAfterGlobalTimeCheckedChanged);
			// 
			// m_lvSecurityOptions
			// 
			this.m_lvSecurityOptions.CheckBoxes = true;
			this.m_lvSecurityOptions.FullRowSelect = true;
			this.m_lvSecurityOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.m_lvSecurityOptions.Location = new System.Drawing.Point(6, 115);
			this.m_lvSecurityOptions.Name = "m_lvSecurityOptions";
			this.m_lvSecurityOptions.ShowItemToolTips = true;
			this.m_lvSecurityOptions.Size = new System.Drawing.Size(540, 194);
			this.m_lvSecurityOptions.TabIndex = 8;
			this.m_lvSecurityOptions.UseCompatibleStateImageBehavior = false;
			this.m_lvSecurityOptions.View = System.Windows.Forms.View.Details;
			// 
			// m_numClipClearTime
			// 
			this.m_numClipClearTime.Location = new System.Drawing.Point(327, 63);
			this.m_numClipClearTime.Maximum = new decimal(new int[] {
            1209600,
            0,
            0,
            0});
			this.m_numClipClearTime.Name = "m_numClipClearTime";
			this.m_numClipClearTime.Size = new System.Drawing.Size(66, 20);
			this.m_numClipClearTime.TabIndex = 5;
			// 
			// m_cbClipClearTime
			// 
			this.m_cbClipClearTime.AutoSize = true;
			this.m_cbClipClearTime.Location = new System.Drawing.Point(6, 64);
			this.m_cbClipClearTime.Name = "m_cbClipClearTime";
			this.m_cbClipClearTime.Size = new System.Drawing.Size(263, 17);
			this.m_cbClipClearTime.TabIndex = 4;
			this.m_cbClipClearTime.Text = "&Clipboard auto-clear time (seconds; main entry list):";
			this.m_cbClipClearTime.UseVisualStyleBackColor = true;
			this.m_cbClipClearTime.CheckedChanged += new System.EventHandler(this.OnClipboardClearTimeCheckedChanged);
			// 
			// m_numDefaultExpireDays
			// 
			this.m_numDefaultExpireDays.Location = new System.Drawing.Point(327, 89);
			this.m_numDefaultExpireDays.Maximum = new decimal(new int[] {
            2920,
            0,
            0,
            0});
			this.m_numDefaultExpireDays.Name = "m_numDefaultExpireDays";
			this.m_numDefaultExpireDays.Size = new System.Drawing.Size(66, 20);
			this.m_numDefaultExpireDays.TabIndex = 7;
			// 
			// m_cbDefaultExpireDays
			// 
			this.m_cbDefaultExpireDays.AutoSize = true;
			this.m_cbDefaultExpireDays.Location = new System.Drawing.Point(6, 90);
			this.m_cbDefaultExpireDays.Name = "m_cbDefaultExpireDays";
			this.m_cbDefaultExpireDays.Size = new System.Drawing.Size(315, 17);
			this.m_cbDefaultExpireDays.TabIndex = 6;
			this.m_cbDefaultExpireDays.Text = "By default, &new entries expire in the following number of days:";
			this.m_cbDefaultExpireDays.UseVisualStyleBackColor = true;
			this.m_cbDefaultExpireDays.CheckedChanged += new System.EventHandler(this.OnDefaultExpireDaysCheckedChanged);
			// 
			// m_cbLockAfterTime
			// 
			this.m_cbLockAfterTime.AutoSize = true;
			this.m_cbLockAfterTime.Location = new System.Drawing.Point(6, 12);
			this.m_cbLockAfterTime.Name = "m_cbLockAfterTime";
			this.m_cbLockAfterTime.Size = new System.Drawing.Size(270, 17);
			this.m_cbLockAfterTime.TabIndex = 0;
			this.m_cbLockAfterTime.Text = "&Lock workspace after KeePass inactivity (seconds):";
			this.m_cbLockAfterTime.UseVisualStyleBackColor = true;
			this.m_cbLockAfterTime.CheckedChanged += new System.EventHandler(this.OnLockAfterTimeCheckedChanged);
			// 
			// m_numLockAfterTime
			// 
			this.m_numLockAfterTime.Location = new System.Drawing.Point(327, 11);
			this.m_numLockAfterTime.Maximum = new decimal(new int[] {
            1209600,
            0,
            0,
            0});
			this.m_numLockAfterTime.Name = "m_numLockAfterTime";
			this.m_numLockAfterTime.Size = new System.Drawing.Size(66, 20);
			this.m_numLockAfterTime.TabIndex = 1;
			// 
			// m_tabPolicy
			// 
			this.m_tabPolicy.Controls.Add(this.m_lvPolicy);
			this.m_tabPolicy.Controls.Add(this.m_linkPolicyInfo);
			this.m_tabPolicy.Controls.Add(this.m_lblPolicyMore);
			this.m_tabPolicy.Controls.Add(this.m_lblPolicyRestart);
			this.m_tabPolicy.Controls.Add(this.m_lblPolicyIntro);
			this.m_tabPolicy.Location = new System.Drawing.Point(4, 22);
			this.m_tabPolicy.Name = "m_tabPolicy";
			this.m_tabPolicy.Size = new System.Drawing.Size(554, 338);
			this.m_tabPolicy.TabIndex = 3;
			this.m_tabPolicy.Text = "Policy";
			this.m_tabPolicy.UseVisualStyleBackColor = true;
			// 
			// m_lvPolicy
			// 
			this.m_lvPolicy.CheckBoxes = true;
			this.m_lvPolicy.FullRowSelect = true;
			this.m_lvPolicy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvPolicy.Location = new System.Drawing.Point(6, 46);
			this.m_lvPolicy.Name = "m_lvPolicy";
			this.m_lvPolicy.ShowItemToolTips = true;
			this.m_lvPolicy.Size = new System.Drawing.Size(540, 263);
			this.m_lvPolicy.TabIndex = 3;
			this.m_lvPolicy.UseCompatibleStateImageBehavior = false;
			this.m_lvPolicy.View = System.Windows.Forms.View.Details;
			// 
			// m_linkPolicyInfo
			// 
			this.m_linkPolicyInfo.AutoSize = true;
			this.m_linkPolicyInfo.Location = new System.Drawing.Point(97, 26);
			this.m_linkPolicyInfo.Name = "m_linkPolicyInfo";
			this.m_linkPolicyInfo.Size = new System.Drawing.Size(115, 13);
			this.m_linkPolicyInfo.TabIndex = 2;
			this.m_linkPolicyInfo.TabStop = true;
			this.m_linkPolicyInfo.Text = "Application Policy Help";
			this.m_linkPolicyInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPolicyInfoLinkClicked);
			// 
			// m_lblPolicyMore
			// 
			this.m_lblPolicyMore.AutoSize = true;
			this.m_lblPolicyMore.Location = new System.Drawing.Point(3, 26);
			this.m_lblPolicyMore.Name = "m_lblPolicyMore";
			this.m_lblPolicyMore.Size = new System.Drawing.Size(88, 13);
			this.m_lblPolicyMore.TabIndex = 1;
			this.m_lblPolicyMore.Text = "More information:";
			// 
			// m_lblPolicyRestart
			// 
			this.m_lblPolicyRestart.AutoSize = true;
			this.m_lblPolicyRestart.Location = new System.Drawing.Point(3, 316);
			this.m_lblPolicyRestart.Name = "m_lblPolicyRestart";
			this.m_lblPolicyRestart.Size = new System.Drawing.Size(241, 13);
			this.m_lblPolicyRestart.TabIndex = 4;
			this.m_lblPolicyRestart.Text = "* Changing the policy requires restarting KeePass.";
			// 
			// m_lblPolicyIntro
			// 
			this.m_lblPolicyIntro.Location = new System.Drawing.Point(3, 9);
			this.m_lblPolicyIntro.Name = "m_lblPolicyIntro";
			this.m_lblPolicyIntro.Size = new System.Drawing.Size(548, 14);
			this.m_lblPolicyIntro.TabIndex = 0;
			this.m_lblPolicyIntro.Text = "The application policy defines which security-critical operations are allowed and" +
				" which are not.";
			// 
			// m_tabGui
			// 
			this.m_tabGui.Controls.Add(this.m_cmbEscAction);
			this.m_tabGui.Controls.Add(this.m_lblEscAction);
			this.m_tabGui.Controls.Add(this.m_btnCustomAltColor);
			this.m_tabGui.Controls.Add(this.m_cbCustomAltColor);
			this.m_tabGui.Controls.Add(this.m_cmbMenuStyle);
			this.m_tabGui.Controls.Add(this.m_lblMenuStyle);
			this.m_tabGui.Controls.Add(this.m_btnSelPwFont);
			this.m_tabGui.Controls.Add(this.m_numMruCount);
			this.m_tabGui.Controls.Add(this.m_lblMruCount);
			this.m_tabGui.Controls.Add(this.m_btnSelFont);
			this.m_tabGui.Controls.Add(this.m_lvGuiOptions);
			this.m_tabGui.Controls.Add(this.m_lblBannerStyle);
			this.m_tabGui.Controls.Add(this.m_cmbBannerStyle);
			this.m_tabGui.Location = new System.Drawing.Point(4, 22);
			this.m_tabGui.Name = "m_tabGui";
			this.m_tabGui.Size = new System.Drawing.Size(554, 338);
			this.m_tabGui.TabIndex = 2;
			this.m_tabGui.Text = "Interface";
			this.m_tabGui.UseVisualStyleBackColor = true;
			// 
			// m_cmbEscAction
			// 
			this.m_cmbEscAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cmbEscAction.FormattingEnabled = true;
			this.m_cmbEscAction.Location = new System.Drawing.Point(157, 281);
			this.m_cmbEscAction.Name = "m_cmbEscAction";
			this.m_cmbEscAction.Size = new System.Drawing.Size(162, 21);
			this.m_cmbEscAction.TabIndex = 8;
			// 
			// m_lblEscAction
			// 
			this.m_lblEscAction.AutoSize = true;
			this.m_lblEscAction.Location = new System.Drawing.Point(3, 284);
			this.m_lblEscAction.Name = "m_lblEscAction";
			this.m_lblEscAction.Size = new System.Drawing.Size(148, 13);
			this.m_lblEscAction.TabIndex = 7;
			this.m_lblEscAction.Text = "&Esc keypress in main window:";
			// 
			// m_btnCustomAltColor
			// 
			this.m_btnCustomAltColor.Location = new System.Drawing.Point(499, 307);
			this.m_btnCustomAltColor.Name = "m_btnCustomAltColor";
			this.m_btnCustomAltColor.Size = new System.Drawing.Size(48, 23);
			this.m_btnCustomAltColor.TabIndex = 12;
			this.m_btnCustomAltColor.UseVisualStyleBackColor = true;
			this.m_btnCustomAltColor.Click += new System.EventHandler(this.OnBtnCustomAltColor);
			// 
			// m_cbCustomAltColor
			// 
			this.m_cbCustomAltColor.AutoSize = true;
			this.m_cbCustomAltColor.Location = new System.Drawing.Point(366, 311);
			this.m_cbCustomAltColor.Name = "m_cbCustomAltColor";
			this.m_cbCustomAltColor.Size = new System.Drawing.Size(129, 17);
			this.m_cbCustomAltColor.TabIndex = 11;
			this.m_cbCustomAltColor.Text = "&Custom alt. item color:";
			this.m_cbCustomAltColor.UseVisualStyleBackColor = true;
			this.m_cbCustomAltColor.CheckedChanged += new System.EventHandler(this.OnCustomAltColorCheckedChanged);
			// 
			// m_cmbMenuStyle
			// 
			this.m_cmbMenuStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cmbMenuStyle.FormattingEnabled = true;
			this.m_cmbMenuStyle.Location = new System.Drawing.Point(157, 227);
			this.m_cmbMenuStyle.Name = "m_cmbMenuStyle";
			this.m_cmbMenuStyle.Size = new System.Drawing.Size(162, 21);
			this.m_cmbMenuStyle.TabIndex = 2;
			// 
			// m_lblMenuStyle
			// 
			this.m_lblMenuStyle.AutoSize = true;
			this.m_lblMenuStyle.Location = new System.Drawing.Point(3, 230);
			this.m_lblMenuStyle.Name = "m_lblMenuStyle";
			this.m_lblMenuStyle.Size = new System.Drawing.Size(117, 13);
			this.m_lblMenuStyle.TabIndex = 1;
			this.m_lblMenuStyle.Text = "&Menu and toolbar style:";
			// 
			// m_btnSelPwFont
			// 
			this.m_btnSelPwFont.Location = new System.Drawing.Point(414, 253);
			this.m_btnSelPwFont.Name = "m_btnSelPwFont";
			this.m_btnSelPwFont.Size = new System.Drawing.Size(133, 23);
			this.m_btnSelPwFont.TabIndex = 6;
			this.m_btnSelPwFont.Text = "Select &Password Font";
			this.m_btnSelPwFont.UseVisualStyleBackColor = true;
			this.m_btnSelPwFont.Click += new System.EventHandler(this.OnBtnSelPwFont);
			// 
			// m_numMruCount
			// 
			this.m_numMruCount.Location = new System.Drawing.Point(157, 308);
			this.m_numMruCount.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.m_numMruCount.Name = "m_numMruCount";
			this.m_numMruCount.Size = new System.Drawing.Size(53, 20);
			this.m_numMruCount.TabIndex = 10;
			this.m_numMruCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// m_lblMruCount
			// 
			this.m_lblMruCount.AutoSize = true;
			this.m_lblMruCount.Location = new System.Drawing.Point(3, 310);
			this.m_lblMruCount.Name = "m_lblMruCount";
			this.m_lblMruCount.Size = new System.Drawing.Size(148, 13);
			this.m_lblMruCount.TabIndex = 9;
			this.m_lblMruCount.Text = "&Remember recently used files:";
			// 
			// m_btnSelFont
			// 
			this.m_btnSelFont.Location = new System.Drawing.Point(414, 226);
			this.m_btnSelFont.Name = "m_btnSelFont";
			this.m_btnSelFont.Size = new System.Drawing.Size(133, 23);
			this.m_btnSelFont.TabIndex = 3;
			this.m_btnSelFont.Text = "Select &List Font";
			this.m_btnSelFont.UseVisualStyleBackColor = true;
			this.m_btnSelFont.Click += new System.EventHandler(this.OnBtnSelListFont);
			// 
			// m_lvGuiOptions
			// 
			this.m_lvGuiOptions.CheckBoxes = true;
			this.m_lvGuiOptions.FullRowSelect = true;
			this.m_lvGuiOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.m_lvGuiOptions.Location = new System.Drawing.Point(6, 12);
			this.m_lvGuiOptions.Name = "m_lvGuiOptions";
			this.m_lvGuiOptions.ShowItemToolTips = true;
			this.m_lvGuiOptions.Size = new System.Drawing.Size(540, 209);
			this.m_lvGuiOptions.TabIndex = 0;
			this.m_lvGuiOptions.UseCompatibleStateImageBehavior = false;
			this.m_lvGuiOptions.View = System.Windows.Forms.View.Details;
			// 
			// m_lblBannerStyle
			// 
			this.m_lblBannerStyle.AutoSize = true;
			this.m_lblBannerStyle.Location = new System.Drawing.Point(3, 257);
			this.m_lblBannerStyle.Name = "m_lblBannerStyle";
			this.m_lblBannerStyle.Size = new System.Drawing.Size(100, 13);
			this.m_lblBannerStyle.TabIndex = 4;
			this.m_lblBannerStyle.Text = "&Dialog banner style:";
			// 
			// m_cmbBannerStyle
			// 
			this.m_cmbBannerStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cmbBannerStyle.FormattingEnabled = true;
			this.m_cmbBannerStyle.Location = new System.Drawing.Point(157, 254);
			this.m_cmbBannerStyle.Name = "m_cmbBannerStyle";
			this.m_cmbBannerStyle.Size = new System.Drawing.Size(162, 21);
			this.m_cmbBannerStyle.TabIndex = 5;
			this.m_cmbBannerStyle.SelectedValueChanged += new System.EventHandler(this.OnBannerStyleSelectedChanged);
			// 
			// m_tabIntegration
			// 
			this.m_tabIntegration.Controls.Add(this.m_btnHelpSource);
			this.m_tabIntegration.Controls.Add(this.m_btnSchemeOverrides);
			this.m_tabIntegration.Controls.Add(this.m_cbAutoRun);
			this.m_tabIntegration.Controls.Add(this.m_grpFileExt);
			this.m_tabIntegration.Controls.Add(this.m_grpHotKeys);
			this.m_tabIntegration.Location = new System.Drawing.Point(4, 22);
			this.m_tabIntegration.Name = "m_tabIntegration";
			this.m_tabIntegration.Size = new System.Drawing.Size(554, 338);
			this.m_tabIntegration.TabIndex = 4;
			this.m_tabIntegration.Text = "Integration";
			this.m_tabIntegration.UseVisualStyleBackColor = true;
			// 
			// m_btnHelpSource
			// 
			this.m_btnHelpSource.Location = new System.Drawing.Point(435, 307);
			this.m_btnHelpSource.Name = "m_btnHelpSource";
			this.m_btnHelpSource.Size = new System.Drawing.Size(112, 23);
			this.m_btnHelpSource.TabIndex = 4;
			this.m_btnHelpSource.Text = "&Help Source...";
			this.m_btnHelpSource.UseVisualStyleBackColor = true;
			this.m_btnHelpSource.Click += new System.EventHandler(this.OnBtnHelpSource);
			// 
			// m_btnSchemeOverrides
			// 
			this.m_btnSchemeOverrides.Location = new System.Drawing.Point(317, 307);
			this.m_btnSchemeOverrides.Name = "m_btnSchemeOverrides";
			this.m_btnSchemeOverrides.Size = new System.Drawing.Size(112, 23);
			this.m_btnSchemeOverrides.TabIndex = 3;
			this.m_btnSchemeOverrides.Text = "URL &Overrides...";
			this.m_btnSchemeOverrides.UseVisualStyleBackColor = true;
			this.m_btnSchemeOverrides.Click += new System.EventHandler(this.OnBtnUrlOverrides);
			// 
			// m_cbAutoRun
			// 
			this.m_cbAutoRun.AutoSize = true;
			this.m_cbAutoRun.Location = new System.Drawing.Point(6, 247);
			this.m_cbAutoRun.Name = "m_cbAutoRun";
			this.m_cbAutoRun.Size = new System.Drawing.Size(250, 17);
			this.m_cbAutoRun.TabIndex = 2;
			this.m_cbAutoRun.Text = "R&un KeePass at Windows startup (current user)";
			this.m_cbAutoRun.UseVisualStyleBackColor = true;
			this.m_cbAutoRun.CheckedChanged += new System.EventHandler(this.OnCheckedChangedAutoRun);
			// 
			// m_grpFileExt
			// 
			this.m_grpFileExt.Controls.Add(this.m_btnFileExtRemove);
			this.m_grpFileExt.Controls.Add(this.m_btnFileExtCreate);
			this.m_grpFileExt.Controls.Add(this.m_lblFileExtHint);
			this.m_grpFileExt.Location = new System.Drawing.Point(6, 149);
			this.m_grpFileExt.Name = "m_grpFileExt";
			this.m_grpFileExt.Size = new System.Drawing.Size(540, 85);
			this.m_grpFileExt.TabIndex = 1;
			this.m_grpFileExt.TabStop = false;
			this.m_grpFileExt.Text = "KDBX file association";
			// 
			// m_btnFileExtRemove
			// 
			this.m_btnFileExtRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.m_btnFileExtRemove.Location = new System.Drawing.Point(146, 52);
			this.m_btnFileExtRemove.Name = "m_btnFileExtRemove";
			this.m_btnFileExtRemove.Size = new System.Drawing.Size(135, 23);
			this.m_btnFileExtRemove.TabIndex = 2;
			this.m_btnFileExtRemove.Text = "&Remove Association";
			this.m_btnFileExtRemove.UseVisualStyleBackColor = true;
			this.m_btnFileExtRemove.Click += new System.EventHandler(this.OnBtnFileExtRemove);
			// 
			// m_btnFileExtCreate
			// 
			this.m_btnFileExtCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.m_btnFileExtCreate.Location = new System.Drawing.Point(9, 52);
			this.m_btnFileExtCreate.Name = "m_btnFileExtCreate";
			this.m_btnFileExtCreate.Size = new System.Drawing.Size(131, 23);
			this.m_btnFileExtCreate.TabIndex = 1;
			this.m_btnFileExtCreate.Text = "&Create Association";
			this.m_btnFileExtCreate.UseVisualStyleBackColor = true;
			this.m_btnFileExtCreate.Click += new System.EventHandler(this.OnBtnFileExtCreate);
			// 
			// m_lblFileExtHint
			// 
			this.m_lblFileExtHint.Location = new System.Drawing.Point(6, 21);
			this.m_lblFileExtHint.Name = "m_lblFileExtHint";
			this.m_lblFileExtHint.Size = new System.Drawing.Size(525, 28);
			this.m_lblFileExtHint.TabIndex = 0;
			this.m_lblFileExtHint.Text = "KDBX files can be associated with KeePass. When you double-click a KDBX file in W" +
				"indows Explorer, they will automatically be opened by KeePass.";
			// 
			// m_grpHotKeys
			// 
			this.m_grpHotKeys.Controls.Add(this.m_lblAutoTypePassword);
			this.m_grpHotKeys.Controls.Add(this.m_hkAutoTypePassword);
			this.m_grpHotKeys.Controls.Add(this.m_linkHotKeyHelp);
			this.m_grpHotKeys.Controls.Add(this.m_lblAutoTypeSelected);
			this.m_grpHotKeys.Controls.Add(this.m_hkAutoTypeSelected);
			this.m_grpHotKeys.Controls.Add(this.m_hkShowWindow);
			this.m_grpHotKeys.Controls.Add(this.m_lblAutoType);
			this.m_grpHotKeys.Controls.Add(this.m_lblShowWindow);
			this.m_grpHotKeys.Controls.Add(this.m_hkAutoType);
			this.m_grpHotKeys.Location = new System.Drawing.Point(6, 12);
			this.m_grpHotKeys.Name = "m_grpHotKeys";
			this.m_grpHotKeys.Size = new System.Drawing.Size(540, 129);
			this.m_grpHotKeys.TabIndex = 0;
			this.m_grpHotKeys.TabStop = false;
			this.m_grpHotKeys.Text = "System-wide hot keys";
			// 
			// m_lblAutoTypePassword
			// 
			this.m_lblAutoTypePassword.AutoSize = true;
			this.m_lblAutoTypePassword.Location = new System.Drawing.Point(6, 47);
			this.m_lblAutoTypePassword.Name = "m_lblAutoTypePassword";
			this.m_lblAutoTypePassword.Size = new System.Drawing.Size(163, 13);
			this.m_lblAutoTypePassword.TabIndex = 3;
			this.m_lblAutoTypePassword.Text = "Global auto-type - password only:";
			// 
			// m_hkAutoTypePassword
			// 
			this.m_hkAutoTypePassword.Location = new System.Drawing.Point(175, 44);
			this.m_hkAutoTypePassword.Name = "m_hkAutoTypePassword";
			this.m_hkAutoTypePassword.Size = new System.Drawing.Size(166, 20);
			this.m_hkAutoTypePassword.TabIndex = 4;
			// 
			// m_linkHotKeyHelp
			// 
			this.m_linkHotKeyHelp.AutoSize = true;
			this.m_linkHotKeyHelp.Location = new System.Drawing.Point(354, 21);
			this.m_linkHotKeyHelp.Name = "m_linkHotKeyHelp";
			this.m_linkHotKeyHelp.Size = new System.Drawing.Size(177, 13);
			this.m_linkHotKeyHelp.TabIndex = 2;
			this.m_linkHotKeyHelp.TabStop = true;
			this.m_linkHotKeyHelp.Text = "Help: Creating system-wide hot keys";
			this.m_linkHotKeyHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnHotKeyHelpLinkClicked);
			// 
			// m_lblAutoTypeSelected
			// 
			this.m_lblAutoTypeSelected.AutoSize = true;
			this.m_lblAutoTypeSelected.Location = new System.Drawing.Point(6, 73);
			this.m_lblAutoTypeSelected.Name = "m_lblAutoTypeSelected";
			this.m_lblAutoTypeSelected.Size = new System.Drawing.Size(124, 13);
			this.m_lblAutoTypeSelected.TabIndex = 5;
			this.m_lblAutoTypeSelected.Text = "Auto-type selected entry:";
			// 
			// m_hkAutoTypeSelected
			// 
			this.m_hkAutoTypeSelected.Location = new System.Drawing.Point(175, 70);
			this.m_hkAutoTypeSelected.Name = "m_hkAutoTypeSelected";
			this.m_hkAutoTypeSelected.Size = new System.Drawing.Size(166, 20);
			this.m_hkAutoTypeSelected.TabIndex = 6;
			// 
			// m_hkShowWindow
			// 
			this.m_hkShowWindow.Location = new System.Drawing.Point(175, 96);
			this.m_hkShowWindow.Name = "m_hkShowWindow";
			this.m_hkShowWindow.Size = new System.Drawing.Size(166, 20);
			this.m_hkShowWindow.TabIndex = 8;
			// 
			// m_lblAutoType
			// 
			this.m_lblAutoType.AutoSize = true;
			this.m_lblAutoType.Location = new System.Drawing.Point(6, 21);
			this.m_lblAutoType.Name = "m_lblAutoType";
			this.m_lblAutoType.Size = new System.Drawing.Size(87, 13);
			this.m_lblAutoType.TabIndex = 0;
			this.m_lblAutoType.Text = "Global auto-type:";
			// 
			// m_lblShowWindow
			// 
			this.m_lblShowWindow.AutoSize = true;
			this.m_lblShowWindow.Location = new System.Drawing.Point(6, 99);
			this.m_lblShowWindow.Name = "m_lblShowWindow";
			this.m_lblShowWindow.Size = new System.Drawing.Size(121, 13);
			this.m_lblShowWindow.TabIndex = 7;
			this.m_lblShowWindow.Text = "Show KeePass window:";
			// 
			// m_hkAutoType
			// 
			this.m_hkAutoType.Location = new System.Drawing.Point(175, 18);
			this.m_hkAutoType.Name = "m_hkAutoType";
			this.m_hkAutoType.Size = new System.Drawing.Size(166, 20);
			this.m_hkAutoType.TabIndex = 1;
			// 
			// m_tabAdvanced
			// 
			this.m_tabAdvanced.Controls.Add(this.m_btnProxy);
			this.m_tabAdvanced.Controls.Add(this.m_lvAdvanced);
			this.m_tabAdvanced.Location = new System.Drawing.Point(4, 22);
			this.m_tabAdvanced.Name = "m_tabAdvanced";
			this.m_tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
			this.m_tabAdvanced.Size = new System.Drawing.Size(554, 338);
			this.m_tabAdvanced.TabIndex = 1;
			this.m_tabAdvanced.Text = "Advanced";
			this.m_tabAdvanced.UseVisualStyleBackColor = true;
			// 
			// m_btnProxy
			// 
			this.m_btnProxy.Location = new System.Drawing.Point(472, 307);
			this.m_btnProxy.Name = "m_btnProxy";
			this.m_btnProxy.Size = new System.Drawing.Size(75, 23);
			this.m_btnProxy.TabIndex = 1;
			this.m_btnProxy.Text = "&Proxy...";
			this.m_btnProxy.UseVisualStyleBackColor = true;
			this.m_btnProxy.Click += new System.EventHandler(this.OnBtnProxy);
			// 
			// m_lvAdvanced
			// 
			this.m_lvAdvanced.CheckBoxes = true;
			this.m_lvAdvanced.FullRowSelect = true;
			this.m_lvAdvanced.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.m_lvAdvanced.Location = new System.Drawing.Point(6, 12);
			this.m_lvAdvanced.Name = "m_lvAdvanced";
			this.m_lvAdvanced.ShowItemToolTips = true;
			this.m_lvAdvanced.Size = new System.Drawing.Size(540, 289);
			this.m_lvAdvanced.TabIndex = 0;
			this.m_lvAdvanced.UseCompatibleStateImageBehavior = false;
			this.m_lvAdvanced.View = System.Windows.Forms.View.Details;
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(586, 471);
			this.Controls.Add(this.m_tabMain);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.Controls.Add(this.m_bannerImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.m_tabMain.ResumeLayout(false);
			this.m_tabSecurity.ResumeLayout(false);
			this.m_tabSecurity.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterGlobalTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numClipClearTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numDefaultExpireDays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numLockAfterTime)).EndInit();
			this.m_tabPolicy.ResumeLayout(false);
			this.m_tabPolicy.PerformLayout();
			this.m_tabGui.ResumeLayout(false);
			this.m_tabGui.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numMruCount)).EndInit();
			this.m_tabIntegration.ResumeLayout(false);
			this.m_tabIntegration.PerformLayout();
			this.m_grpFileExt.ResumeLayout(false);
			this.m_grpHotKeys.ResumeLayout(false);
			this.m_grpHotKeys.PerformLayout();
			this.m_tabAdvanced.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.TabControl m_tabMain;
		private System.Windows.Forms.TabPage m_tabSecurity;
		private System.Windows.Forms.TabPage m_tabAdvanced;
		private System.Windows.Forms.TabPage m_tabGui;
		private System.Windows.Forms.ComboBox m_cmbBannerStyle;
		private System.Windows.Forms.Label m_lblBannerStyle;
		private System.Windows.Forms.CheckBox m_cbLockAfterTime;
		private System.Windows.Forms.NumericUpDown m_numLockAfterTime;
		private System.Windows.Forms.TabPage m_tabPolicy;
		private System.Windows.Forms.LinkLabel m_linkPolicyInfo;
		private System.Windows.Forms.Label m_lblPolicyMore;
		private System.Windows.Forms.Label m_lblPolicyRestart;
		private System.Windows.Forms.Label m_lblPolicyIntro;
		private KeePass.UI.CustomListViewEx m_lvPolicy;
		private KeePass.UI.CustomListViewEx m_lvGuiOptions;
		private System.Windows.Forms.Button m_btnSelFont;
		private System.Windows.Forms.TabPage m_tabIntegration;
		private KeePass.UI.HotKeyControlEx m_hkAutoType;
		private System.Windows.Forms.Label m_lblAutoType;
		private System.Windows.Forms.GroupBox m_grpHotKeys;
		private KeePass.UI.HotKeyControlEx m_hkShowWindow;
		private System.Windows.Forms.Label m_lblShowWindow;
		private System.Windows.Forms.CheckBox m_cbDefaultExpireDays;
		private System.Windows.Forms.NumericUpDown m_numDefaultExpireDays;
		private System.Windows.Forms.NumericUpDown m_numClipClearTime;
		private System.Windows.Forms.CheckBox m_cbClipClearTime;
		private System.Windows.Forms.Button m_btnFileExtRemove;
		private System.Windows.Forms.GroupBox m_grpFileExt;
		private System.Windows.Forms.Button m_btnFileExtCreate;
		private System.Windows.Forms.Label m_lblFileExtHint;
		private System.Windows.Forms.CheckBox m_cbAutoRun;
		private KeePass.UI.CustomListViewEx m_lvAdvanced;
		private KeePass.UI.CustomListViewEx m_lvSecurityOptions;
		private System.Windows.Forms.NumericUpDown m_numMruCount;
		private System.Windows.Forms.Label m_lblMruCount;
		private System.Windows.Forms.Button m_btnSchemeOverrides;
		private System.Windows.Forms.Label m_lblAutoTypeSelected;
		private KeePass.UI.HotKeyControlEx m_hkAutoTypeSelected;
		private System.Windows.Forms.Button m_btnSelPwFont;
		private System.Windows.Forms.LinkLabel m_linkHotKeyHelp;
		private System.Windows.Forms.CheckBox m_cbLockAfterGlobalTime;
		private System.Windows.Forms.NumericUpDown m_numLockAfterGlobalTime;
		private System.Windows.Forms.Button m_btnProxy;
		private System.Windows.Forms.ComboBox m_cmbMenuStyle;
		private System.Windows.Forms.Label m_lblMenuStyle;
		private System.Windows.Forms.Button m_btnCustomAltColor;
		private System.Windows.Forms.CheckBox m_cbCustomAltColor;
		private System.Windows.Forms.ComboBox m_cmbEscAction;
		private System.Windows.Forms.Label m_lblEscAction;
		private System.Windows.Forms.ToolTip m_ttRect;
		private System.Windows.Forms.Label m_lblAutoTypePassword;
		private KeePass.UI.HotKeyControlEx m_hkAutoTypePassword;
		private System.Windows.Forms.Button m_btnHelpSource;
		private System.Windows.Forms.Label m_lblSecOpt;
		private System.Windows.Forms.LinkLabel m_linkSecOptAdm;
		private System.Windows.Forms.LinkLabel m_linkSecOptEx;
	}
}