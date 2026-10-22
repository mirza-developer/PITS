// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmEnter
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using MPS.NET_Controls;
using MPS.NET_Controls.Enumaration;
using PITS.Admin_BussinessLayer;
using PITS.Admin_BussinessLayer.Enumaration;
using PITS.Town_PresentationLayer.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer;

[DesignerGenerated]
public class frmEnter : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("panelBackground")]
  private Panel _panelBackground;
  [AccessedThroughProperty("txtPassword")]
  private InputBox _txtPassword;
  [AccessedThroughProperty("lblVersionName")]
  private Label _lblVersionName;
  [AccessedThroughProperty("buttExit")]
  private ButtonMps _buttExit;
  [AccessedThroughProperty("buttEnter")]
  private ButtonMps _buttEnter;
  [AccessedThroughProperty("picLogo")]
  private PictureBox _picLogo;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("lblCompanyName")]
  private Label _lblCompanyName;
  [AccessedThroughProperty("lblSoftwareDescription")]
  private Label _lblSoftwareDescription;
  [AccessedThroughProperty("llblDatabase")]
  private LinkLabel _llblDatabase;
  [AccessedThroughProperty("prbEntr")]
  private ProgressBarX _prbEntr;
  [AccessedThroughProperty("lblVersion")]
  private Label _lblVersion;

  [DebuggerNonUserCode]
  static frmEnter()
  {
  }

  [DebuggerNonUserCode]
  public frmEnter()
  {
    this.Load += new EventHandler(this.LoadCompanyName);
    this.Shown += new EventHandler(this.frmShown);
    this.KeyDown += new KeyEventHandler(this.ShortcutKeys);
    frmEnter.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmEnter.__ENCList)
    {
      if (frmEnter.__ENCList.Count == frmEnter.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmEnter.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmEnter.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmEnter.__ENCList[index1] = frmEnter.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmEnter.__ENCList.RemoveRange(index1, checked (frmEnter.__ENCList.Count - index1));
        frmEnter.__ENCList.Capacity = frmEnter.__ENCList.Count;
      }
      frmEnter.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    InputButtonSettings inputButtonSettings = new InputButtonSettings();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEnter));
    this.panelBackground = new Panel();
    this.lblVersion = new Label();
    this.txtPassword = new InputBox();
    this.lblVersionName = new Label();
    this.buttExit = new ButtonMps();
    this.buttEnter = new ButtonMps();
    this.picLogo = new PictureBox();
    this.lblCompanyName = new Label();
    this.lblSoftwareDescription = new Label();
    this.llblDatabase = new LinkLabel();
    this.prbEntr = new ProgressBarX();
    this.Label3 = new Label();
    this.panelBackground.SuspendLayout();
    ((ISupportInitialize) this.picLogo).BeginInit();
    this.SuspendLayout();
    this.panelBackground.BorderStyle = BorderStyle.FixedSingle;
    this.panelBackground.Controls.Add((Control) this.lblVersion);
    this.panelBackground.Controls.Add((Control) this.txtPassword);
    this.panelBackground.Controls.Add((Control) this.lblVersionName);
    this.panelBackground.Controls.Add((Control) this.buttExit);
    this.panelBackground.Controls.Add((Control) this.buttEnter);
    this.panelBackground.Controls.Add((Control) this.picLogo);
    this.panelBackground.Controls.Add((Control) this.lblCompanyName);
    this.panelBackground.Controls.Add((Control) this.lblSoftwareDescription);
    this.panelBackground.Controls.Add((Control) this.llblDatabase);
    this.panelBackground.Controls.Add((Control) this.prbEntr);
    this.panelBackground.Controls.Add((Control) this.Label3);
    this.panelBackground.Dock = DockStyle.Fill;
    Panel panelBackground1 = this.panelBackground;
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    panelBackground1.Location = point2;
    this.panelBackground.Name = "panelBackground";
    Panel panelBackground2 = this.panelBackground;
    Size size1 = new Size(436, 222);
    Size size2 = size1;
    panelBackground2.Size = size2;
    this.panelBackground.TabIndex = 0;
    Label lblVersion1 = this.lblVersion;
    point1 = new Point(355, 62);
    Point point3 = point1;
    lblVersion1.Location = point3;
    this.lblVersion.Name = "lblVersion";
    this.lblVersion.RightToLeft = RightToLeft.Yes;
    Label lblVersion2 = this.lblVersion;
    size1 = new Size(38, 16 /*0x10*/);
    Size size3 = size1;
    lblVersion2.Size = size3;
    this.lblVersion.TabIndex = 49;
    this.lblVersion.Text = "1";
    this.txtPassword.Alighment = HorizontalAlignment.Center;
    this.txtPassword.BackColor = Color.Transparent;
    inputButtonSettings.DisplayPosition = 1;
    inputButtonSettings.Enabled = false;
    this.txtPassword.Button = inputButtonSettings;
    this.txtPassword.ButtonDropDownEnable = true;
    this.txtPassword.ControlType = Enum_ControlType.TextBox;
    this.txtPassword.DefaultLanguge = Enum_Languge.English;
    this.txtPassword.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPassword.InputValidation = Enum_InputValidation.All;
    this.txtPassword.Key = "";
    this.txtPassword.LabelForeColor = SystemColors.ControlText;
    this.txtPassword.LabelText = "كلمه عبور";
    InputBox txtPassword1 = this.txtPassword;
    point1 = new Point(266, 116);
    Point point4 = point1;
    txtPassword1.Location = point4;
    this.txtPassword.MaxLenght = 10;
    this.txtPassword.MinLenght = 1;
    this.txtPassword.Multiline = false;
    this.txtPassword.Name = "txtPassword";
    this.txtPassword.RangeDown = "";
    this.txtPassword.RangeUp = "";
    this.txtPassword.RequiredField = true;
    InputBox txtPassword2 = this.txtPassword;
    size1 = new Size(167, 24);
    Size size4 = size1;
    txtPassword2.Size = size4;
    this.txtPassword.TabIndex = 48 /*0x30*/;
    this.txtPassword.ToolTipText = "لطفا كلمه عبور را در اين قسمت وارد نمائيد";
    this.txtPassword.UseSystemPasswordChar = true;
    this.txtPassword.WatermarkText = "";
    this.txtPassword.WriteType = Enum_WriteType.Defualt;
    Label lblVersionName1 = this.lblVersionName;
    point1 = new Point(388, 62);
    Point point5 = point1;
    lblVersionName1.Location = point5;
    this.lblVersionName.Name = "lblVersionName";
    this.lblVersionName.RightToLeft = RightToLeft.Yes;
    Label lblVersionName2 = this.lblVersionName;
    size1 = new Size(38, 16 /*0x10*/);
    Size size5 = size1;
    lblVersionName2.Size = size5;
    this.lblVersionName.TabIndex = 46;
    this.lblVersionName.Text = "نگارش ";
    this.buttExit.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttExit.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttExit.Image = (Image) componentResourceManager.GetObject("buttExit.Image");
    this.buttExit.ImageAlign = ContentAlignment.MiddleRight;
    ButtonMps buttExit1 = this.buttExit;
    point1 = new Point(266, 146);
    Point point6 = point1;
    buttExit1.Location = point6;
    this.buttExit.Name = "buttExit";
    this.buttExit.RightToLeft = RightToLeft.Yes;
    this.buttExit.ShortcutKeys = "Esc";
    ButtonMps buttExit2 = this.buttExit;
    size1 = new Size(68, 25);
    Size size6 = size1;
    buttExit2.Size = size6;
    this.buttExit.TabIndex = 40;
    this.buttExit.Text = "خروج";
    this.buttExit.TextAlign = ContentAlignment.TopLeft;
    this.buttExit.TooltipText = "جهت خروج كامل از نرم افزار اين دكمه را فشار دهيد";
    this.buttExit.UseVisualStyleBackColor = false;
    this.buttEnter.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttEnter.DialogResult = DialogResult.Cancel;
    this.buttEnter.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttEnter.Image = (Image) componentResourceManager.GetObject("buttEnter.Image");
    this.buttEnter.ImageAlign = ContentAlignment.MiddleRight;
    ButtonMps buttEnter1 = this.buttEnter;
    point1 = new Point(340, 146);
    Point point7 = point1;
    buttEnter1.Location = point7;
    this.buttEnter.Name = "buttEnter";
    this.buttEnter.RightToLeft = RightToLeft.Yes;
    this.buttEnter.ShortcutKeys = "F10";
    ButtonMps buttEnter2 = this.buttEnter;
    size1 = new Size(68, 25);
    Size size7 = size1;
    buttEnter2.Size = size7;
    this.buttEnter.TabIndex = 39;
    this.buttEnter.Text = "ورود";
    this.buttEnter.TextAlign = ContentAlignment.TopLeft;
    this.buttEnter.TooltipText = "جهت ورود به نرم افزار اين دكمه را فشار دهيد";
    this.buttEnter.UseVisualStyleBackColor = false;
    this.picLogo.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.picLogo.BorderStyle = BorderStyle.FixedSingle;
    this.picLogo.Image = (Image) componentResourceManager.GetObject("picLogo.Image");
    PictureBox picLogo1 = this.picLogo;
    point1 = new Point(11, 10);
    Point point8 = point1;
    picLogo1.Location = point8;
    this.picLogo.Name = "picLogo";
    PictureBox picLogo2 = this.picLogo;
    size1 = new Size(237, 188);
    Size size8 = size1;
    picLogo2.Size = size8;
    this.picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
    this.picLogo.TabIndex = 45;
    this.picLogo.TabStop = false;
    this.lblCompanyName.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    Label lblCompanyName1 = this.lblCompanyName;
    point1 = new Point(246, 26);
    Point point9 = point1;
    lblCompanyName1.Location = point9;
    this.lblCompanyName.Name = "lblCompanyName";
    this.lblCompanyName.RightToLeft = RightToLeft.Yes;
    Label lblCompanyName2 = this.lblCompanyName;
    size1 = new Size(189, 36);
    Size size9 = size1;
    lblCompanyName2.Size = size9;
    this.lblCompanyName.TabIndex = 43;
    this.lblCompanyName.Text = "مجتمع مسكوني تكش";
    Label softwareDescription1 = this.lblSoftwareDescription;
    point1 = new Point(287, 10);
    Point point10 = point1;
    softwareDescription1.Location = point10;
    this.lblSoftwareDescription.Name = "lblSoftwareDescription";
    this.lblSoftwareDescription.RightToLeft = RightToLeft.Yes;
    Label softwareDescription2 = this.lblSoftwareDescription;
    size1 = new Size(145, 16 /*0x10*/);
    Size size10 = size1;
    softwareDescription2.Size = size10;
    this.lblSoftwareDescription.TabIndex = 42;
    this.lblSoftwareDescription.Text = "سامانه نرم افزاري";
    this.llblDatabase.AutoSize = true;
    LinkLabel llblDatabase1 = this.llblDatabase;
    point1 = new Point(266, 174);
    Point point11 = point1;
    llblDatabase1.Location = point11;
    this.llblDatabase.Name = "llblDatabase";
    LinkLabel llblDatabase2 = this.llblDatabase;
    size1 = new Size(81, 13);
    Size size11 = size1;
    llblDatabase2.Size = size11;
    this.llblDatabase.TabIndex = 41;
    this.llblDatabase.TabStop = true;
    this.llblDatabase.Text = "مسير پايگاه داده";
    this.llblDatabase.TextAlign = ContentAlignment.MiddleCenter;
    this.prbEntr.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128 /*0x80*/);
    this.prbEntr.BackgroundStyle.Class = "";
    this.prbEntr.BackgroundStyle.CornerType = eCornerType.Square;
    ProgressBarX prbEntr1 = this.prbEntr;
    point1 = new Point(2, 196);
    Point point12 = point1;
    prbEntr1.Location = point12;
    this.prbEntr.Name = "prbEntr";
    ProgressBarX prbEntr2 = this.prbEntr;
    size1 = new Size(427, 18);
    Size size12 = size1;
    prbEntr2.Size = size12;
    this.prbEntr.Style = eDotNetBarStyle.Windows7;
    this.prbEntr.TabIndex = 47;
    this.prbEntr.TextVisible = true;
    this.prbEntr.Visible = false;
    this.Label3.ForeColor = Color.Gray;
    Label label3_1 = this.Label3;
    point1 = new Point(-1, 201);
    Point point13 = point1;
    label3_1.Location = point13;
    this.Label3.Name = "Label3";
    this.Label3.RightToLeft = RightToLeft.Yes;
    Label label3_2 = this.Label3;
    size1 = new Size(433, 15);
    Size size13 = size1;
    label3_2.Size = size13;
    this.Label3.TabIndex = 44;
    this.Label3.Text = "شركت راهكارهاي فناوري اطلاعات پينك - كاوه سمائي - تلفن : 27447 همراه : 09124576680";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    size1 = new Size(436, 222);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.panelBackground);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmEnter);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "ورود به سامانه";
    this.panelBackground.ResumeLayout(false);
    this.panelBackground.PerformLayout();
    ((ISupportInitialize) this.picLogo).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual Panel panelBackground
  {
    [DebuggerNonUserCode] get => this._panelBackground;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._panelBackground = value;
    }
  }

  internal virtual InputBox txtPassword
  {
    [DebuggerNonUserCode] get => this._txtPassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.IsValidChanged);
      if (this._txtPassword != null)
        this._txtPassword.IsValidChange -= changeEventHandler;
      this._txtPassword = value;
      if (this._txtPassword == null)
        return;
      this._txtPassword.IsValidChange += changeEventHandler;
    }
  }

  internal virtual Label lblVersionName
  {
    [DebuggerNonUserCode] get => this._lblVersionName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblVersionName = value;
    }
  }

  internal virtual ButtonMps buttExit
  {
    [DebuggerNonUserCode] get => this._buttExit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ButtonsClick);
      if (this._buttExit != null)
        this._buttExit.Click -= eventHandler;
      this._buttExit = value;
      if (this._buttExit == null)
        return;
      this._buttExit.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttEnter
  {
    [DebuggerNonUserCode] get => this._buttEnter;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ButtonsClick);
      if (this._buttEnter != null)
        this._buttEnter.Click -= eventHandler;
      this._buttEnter = value;
      if (this._buttEnter == null)
        return;
      this._buttEnter.Click += eventHandler;
    }
  }

  internal virtual PictureBox picLogo
  {
    [DebuggerNonUserCode] get => this._picLogo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._picLogo = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label lblCompanyName
  {
    [DebuggerNonUserCode] get => this._lblCompanyName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCompanyName = value;
    }
  }

  internal virtual Label lblSoftwareDescription
  {
    [DebuggerNonUserCode] get => this._lblSoftwareDescription;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSoftwareDescription = value;
    }
  }

  internal virtual LinkLabel llblDatabase
  {
    [DebuggerNonUserCode] get => this._llblDatabase;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ButtonsClick);
      if (this._llblDatabase != null)
        this._llblDatabase.Click -= eventHandler;
      this._llblDatabase = value;
      if (this._llblDatabase == null)
        return;
      this._llblDatabase.Click += eventHandler;
    }
  }

  internal virtual ProgressBarX prbEntr
  {
    [DebuggerNonUserCode] get => this._prbEntr;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._prbEntr = value;
  }

  internal virtual Label lblVersion
  {
    [DebuggerNonUserCode] get => this._lblVersion;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblVersion = value;
    }
  }

  private void LoadCompanyName(object sender, EventArgs e) => new cIsolateInfo().Load();

  private void frmShown(object sender, EventArgs e) => this.txtPassword.Focus();

  private void IsValidChanged()
  {
    if (this.txtPassword.isValid)
      this.buttEnter.Enabled = true;
    else
      this.buttEnter.Enabled = false;
  }

  private void ButtonsClick(object sender, EventArgs e)
  {
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttEnter", false))
      this.LoadFrmMain();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttExit", false))
    {
      this.Unloadme();
    }
    else
    {
      if (!Operators.ConditionalCompareObjectEqual(Left, (object) "llblDatabase", false))
        return;
      this.LoadFrmCnnString();
    }
  }

  private void ShortcutKeys(object sender, KeyEventArgs e)
  {
    switch (e.KeyCode)
    {
      case Keys.Escape:
        this.Unloadme();
        break;
      case Keys.F8:
        this.LoadFrmCnnString();
        break;
      case Keys.F10:
        this.LoadFrmMain();
        break;
    }
  }

  private void LoadFrmCnnString()
  {
    int num = (int) new frmConnectionStringSetting().ShowDialog();
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void Unloadme() => ProjectData.EndApp();

  private void LoadFrmMain()
  {
    if (!this.buttEnter.Enabled)
      return;
    this.buttEnter.Enabled = false;
    this.ProgressBar();
    cEnter cEnter = new cEnter();
    this.prbEntr.Value = 1;
    try
    {
      cConnection cConnection = new cConnection();
      if (!cConnection.SetConnectionString())
      {
        int num = (int) MessageBoxMPS.show((Form) this, "اطلاعات اتصال به پايگاه داده صحيح نميباشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, Conversions.ToString(cConnection.ErrorMessage));
        this.buttEnter.Enabled = true;
        this.prbEntr.Visible = false;
      }
      else
      {
        this.ProgressBar();
        if (!cConnection.Open())
        {
          int num = (int) MessageBoxMPS.show((Form) this, "ارتباط با پايگاه داده برقرار نميباشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, Conversions.ToString(cConnection.ErrorMessage));
          this.buttEnter.Enabled = true;
          this.prbEntr.Visible = false;
        }
        else
        {
          this.ProgressBar();
          if (!cEnter.CheckDatabaseVersion())
          {
            int num = (int) MessageBoxMPS.show((Form) this, cEnter.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cEnter.ErrorDescription);
            this.prbEntr.Visible = false;
          }
          else
          {
            this.ProgressBar();
            string[] strArray = this.lblVersion.Text.Split('.');
            if (Operators.CompareString(mPublicModule.SoftwareVersion, strArray[0], false) != 0)
            {
              int num = (int) MessageBoxMPS.show((Form) this, $" نگارش نرم افزار با نگارش پايگاه داده مطابقت ندارد . لطفا از نگارش {mPublicModule.SoftwareVersion} استفاده نمائيد ", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
              this.prbEntr.Visible = false;
            }
            else
            {
              this.ProgressBar();
              if (Operators.CompareString(mPublicModule.SoftwareCompanyName, this.lblCompanyName.Text, false) != 0)
                new cIsolateInfo()
                {
                  CompanyName = this.lblCompanyName.Text
                }.Save();
              this.ProgressBar();
              if (!cEnter.CheckForUserInfo(this.txtPassword.Text))
              {
                int num = (int) MessageBoxMPS.show((Form) this, cEnter.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
                this.txtPassword.Focus();
                this.txtPassword.SetError(cEnter.ErrorMessage);
                this.prbEntr.Visible = false;
              }
              else
              {
                this.ProgressBar();
                cConnection.Close();
                MyProject.Forms.frmMain.Show();
                this.Dispose();
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBoxMPS.show((Form) this, "خطايي ناشناخته در هنگام شروع نرم افزار بوجود آمده است . لطفا با سرپرست نرم افزار تماس بگيريد", Enum_MsgboxTitle.Alarm, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, $"{cEnter.ErrorMessage}---{this.prbEntr.Value.ToString()}");
      this.prbEntr.Visible = false;
      ProjectData.ClearProjectError();
    }
  }

  private void ProgressBar()
  {
    if (!this.prbEntr.Visible)
    {
      this.prbEntr.Value = 0;
      this.prbEntr.Minimum = 0;
      this.prbEntr.Maximum = 20;
      this.prbEntr.Visible = true;
      this.prbEntr.TextVisible = true;
    }
    else
    {
      checked { ++this.prbEntr.Value; }
      this.prbEntr.Text = (checked (this.prbEntr.Value * 100) / this.prbEntr.Maximum).ToString() + " %";
    }
  }
}
