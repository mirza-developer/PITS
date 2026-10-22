// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmMessageBox
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
public class frmMessageBox : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("exlblMessageBox")]
  private ExpandablePanel _exlblMessageBox;
  [AccessedThroughProperty("lblBodyText")]
  private Label _lblBodyText;
  [AccessedThroughProperty("pbxHelp")]
  private PictureBox _pbxHelp;
  [AccessedThroughProperty("pbxMessage")]
  private PictureBox _pbxMessage;
  [AccessedThroughProperty("pbxConfrim")]
  private PictureBox _pbxConfrim;
  [AccessedThroughProperty("pbxPermission")]
  private PictureBox _pbxPermission;
  [AccessedThroughProperty("pbxError")]
  private PictureBox _pbxError;
  [AccessedThroughProperty("pbxAlaram")]
  private PictureBox _pbxAlaram;
  [AccessedThroughProperty("txtDetails")]
  private TextBox _txtDetails;
  [AccessedThroughProperty("butt1")]
  private Button _butt1;
  [AccessedThroughProperty("buttShowDetails")]
  private Button _buttShowDetails;
  [AccessedThroughProperty("butt3")]
  private Button _butt3;
  [AccessedThroughProperty("butt2")]
  private Button _butt2;
  public int Resault;
  private int PrDefualtButton;
  private Form PrFrmParent;

  [DebuggerNonUserCode]
  static frmMessageBox()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMessageBox.__ENCList)
    {
      if (frmMessageBox.__ENCList.Count == frmMessageBox.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMessageBox.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMessageBox.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMessageBox.__ENCList[index1] = frmMessageBox.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMessageBox.__ENCList.RemoveRange(index1, checked (frmMessageBox.__ENCList.Count - index1));
        frmMessageBox.__ENCList.Capacity = frmMessageBox.__ENCList.Count;
      }
      frmMessageBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMessageBox));
    this.pbxAlaram = new PictureBox();
    this.pbxError = new PictureBox();
    this.pbxPermission = new PictureBox();
    this.pbxConfrim = new PictureBox();
    this.pbxMessage = new PictureBox();
    this.pbxHelp = new PictureBox();
    this.lblBodyText = new Label();
    this.exlblMessageBox = new ExpandablePanel();
    this.buttShowDetails = new Button();
    this.butt3 = new Button();
    this.butt2 = new Button();
    this.butt1 = new Button();
    this.txtDetails = new TextBox();
    ((ISupportInitialize) this.pbxAlaram).BeginInit();
    ((ISupportInitialize) this.pbxError).BeginInit();
    ((ISupportInitialize) this.pbxPermission).BeginInit();
    ((ISupportInitialize) this.pbxConfrim).BeginInit();
    ((ISupportInitialize) this.pbxMessage).BeginInit();
    ((ISupportInitialize) this.pbxHelp).BeginInit();
    this.exlblMessageBox.SuspendLayout();
    this.SuspendLayout();
    this.pbxAlaram.BackgroundImage = (Image) componentResourceManager.GetObject("pbxAlaram.BackgroundImage");
    this.pbxAlaram.BackgroundImageLayout = ImageLayout.Stretch;
    PictureBox pbxAlaram1 = this.pbxAlaram;
    Point point1 = new Point(12, 12);
    Point point2 = point1;
    pbxAlaram1.Location = point2;
    this.pbxAlaram.Name = "pbxAlaram";
    PictureBox pbxAlaram2 = this.pbxAlaram;
    Size size1 = new Size(30, 30);
    Size size2 = size1;
    pbxAlaram2.Size = size2;
    this.pbxAlaram.TabIndex = 5;
    this.pbxAlaram.TabStop = false;
    this.pbxAlaram.Visible = false;
    this.pbxError.BackgroundImage = (Image) componentResourceManager.GetObject("pbxError.BackgroundImage");
    this.pbxError.BackgroundImageLayout = ImageLayout.Stretch;
    PictureBox pbxError1 = this.pbxError;
    point1 = new Point(12, 12);
    Point point3 = point1;
    pbxError1.Location = point3;
    this.pbxError.Name = "pbxError";
    PictureBox pbxError2 = this.pbxError;
    size1 = new Size(30, 30);
    Size size3 = size1;
    pbxError2.Size = size3;
    this.pbxError.TabIndex = 4;
    this.pbxError.TabStop = false;
    this.pbxError.Visible = false;
    this.pbxPermission.BackgroundImage = (Image) componentResourceManager.GetObject("pbxPermission.BackgroundImage");
    this.pbxPermission.BackgroundImageLayout = ImageLayout.Stretch;
    PictureBox pbxPermission1 = this.pbxPermission;
    point1 = new Point(12, 12);
    Point point4 = point1;
    pbxPermission1.Location = point4;
    this.pbxPermission.Name = "pbxPermission";
    PictureBox pbxPermission2 = this.pbxPermission;
    size1 = new Size(30, 30);
    Size size4 = size1;
    pbxPermission2.Size = size4;
    this.pbxPermission.TabIndex = 0;
    this.pbxPermission.TabStop = false;
    this.pbxPermission.Visible = false;
    this.pbxConfrim.BackgroundImage = (Image) componentResourceManager.GetObject("pbxConfrim.BackgroundImage");
    this.pbxConfrim.BackgroundImageLayout = ImageLayout.Stretch;
    PictureBox pbxConfrim1 = this.pbxConfrim;
    point1 = new Point(12, 12);
    Point point5 = point1;
    pbxConfrim1.Location = point5;
    this.pbxConfrim.Name = "pbxConfrim";
    PictureBox pbxConfrim2 = this.pbxConfrim;
    size1 = new Size(30, 30);
    Size size5 = size1;
    pbxConfrim2.Size = size5;
    this.pbxConfrim.TabIndex = 2;
    this.pbxConfrim.TabStop = false;
    this.pbxConfrim.Visible = false;
    this.pbxMessage.BackgroundImage = (Image) componentResourceManager.GetObject("pbxMessage.BackgroundImage");
    this.pbxMessage.BackgroundImageLayout = ImageLayout.Stretch;
    PictureBox pbxMessage1 = this.pbxMessage;
    point1 = new Point(12, 12);
    Point point6 = point1;
    pbxMessage1.Location = point6;
    this.pbxMessage.Name = "pbxMessage";
    PictureBox pbxMessage2 = this.pbxMessage;
    size1 = new Size(30, 30);
    Size size6 = size1;
    pbxMessage2.Size = size6;
    this.pbxMessage.TabIndex = 1;
    this.pbxMessage.TabStop = false;
    this.pbxMessage.Visible = false;
    this.pbxHelp.BackgroundImage = (Image) componentResourceManager.GetObject("pbxHelp.BackgroundImage");
    this.pbxHelp.BackgroundImageLayout = ImageLayout.Stretch;
    PictureBox pbxHelp1 = this.pbxHelp;
    point1 = new Point(12, 12);
    Point point7 = point1;
    pbxHelp1.Location = point7;
    this.pbxHelp.Name = "pbxHelp";
    PictureBox pbxHelp2 = this.pbxHelp;
    size1 = new Size(30, 30);
    Size size7 = size1;
    pbxHelp2.Size = size7;
    this.pbxHelp.TabIndex = 3;
    this.pbxHelp.TabStop = false;
    this.pbxHelp.Visible = false;
    this.lblBodyText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lblBodyText.BorderStyle = BorderStyle.FixedSingle;
    this.lblBodyText.FlatStyle = FlatStyle.Flat;
    this.lblBodyText.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    Label lblBodyText1 = this.lblBodyText;
    point1 = new Point(54, 9);
    Point point8 = point1;
    lblBodyText1.Location = point8;
    this.lblBodyText.Name = "lblBodyText";
    this.lblBodyText.RightToLeft = RightToLeft.Yes;
    Label lblBodyText2 = this.lblBodyText;
    size1 = new Size(414, 48 /*0x30*/);
    Size size8 = size1;
    lblBodyText2.Size = size8;
    this.lblBodyText.TabIndex = 12;
    this.exlblMessageBox.CanvasColor = SystemColors.Control;
    this.exlblMessageBox.ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
    this.exlblMessageBox.Controls.Add((Control) this.buttShowDetails);
    this.exlblMessageBox.Controls.Add((Control) this.butt3);
    this.exlblMessageBox.Controls.Add((Control) this.butt2);
    this.exlblMessageBox.Controls.Add((Control) this.butt1);
    this.exlblMessageBox.Controls.Add((Control) this.lblBodyText);
    this.exlblMessageBox.Controls.Add((Control) this.pbxHelp);
    this.exlblMessageBox.Controls.Add((Control) this.pbxMessage);
    this.exlblMessageBox.Controls.Add((Control) this.pbxConfrim);
    this.exlblMessageBox.Controls.Add((Control) this.pbxPermission);
    this.exlblMessageBox.Controls.Add((Control) this.pbxError);
    this.exlblMessageBox.Controls.Add((Control) this.pbxAlaram);
    this.exlblMessageBox.Dock = DockStyle.Top;
    ExpandablePanel exlblMessageBox1 = this.exlblMessageBox;
    point1 = new Point(0, 0);
    Point point9 = point1;
    exlblMessageBox1.Location = point9;
    this.exlblMessageBox.Name = "exlblMessageBox";
    ExpandablePanel exlblMessageBox2 = this.exlblMessageBox;
    size1 = new Size(480, 103);
    Size size9 = size1;
    exlblMessageBox2.Size = size9;
    this.exlblMessageBox.Style.Alignment = StringAlignment.Center;
    this.exlblMessageBox.Style.BackColor1.Color = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.exlblMessageBox.Style.BackColor2.Color = Color.White;
    this.exlblMessageBox.Style.Border = eBorderType.SingleLine;
    this.exlblMessageBox.Style.BorderColor.Color = Color.Silver;
    this.exlblMessageBox.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
    this.exlblMessageBox.Style.GradientAngle = 360;
    this.exlblMessageBox.TabIndex = 11;
    this.exlblMessageBox.TitleHeight = 0;
    this.exlblMessageBox.TitleStyle.Alignment = StringAlignment.Center;
    this.exlblMessageBox.TitleStyle.BackColor1.Color = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.exlblMessageBox.TitleStyle.BackColor2.Color = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    this.exlblMessageBox.TitleStyle.Border = eBorderType.RaisedInner;
    this.exlblMessageBox.TitleStyle.BorderColor.Color = Color.Gray;
    this.exlblMessageBox.TitleStyle.ForeColor.Color = Color.FromArgb(64 /*0x40*/, 64 /*0x40*/, 64 /*0x40*/);
    this.exlblMessageBox.TitleStyle.GradientAngle = 90;
    this.exlblMessageBox.TitleText = "Title Bar";
    this.buttShowDetails.ImageAlign = ContentAlignment.MiddleRight;
    Button buttShowDetails1 = this.buttShowDetails;
    point1 = new Point(12, 66);
    Point point10 = point1;
    buttShowDetails1.Location = point10;
    this.buttShowDetails.Name = "buttShowDetails";
    Button buttShowDetails2 = this.buttShowDetails;
    size1 = new Size(22, 25);
    Size size10 = size1;
    buttShowDetails2.Size = size10;
    this.buttShowDetails.TabIndex = 3;
    this.buttShowDetails.Text = "^";
    this.buttShowDetails.UseVisualStyleBackColor = true;
    this.butt3.Image = (Image) componentResourceManager.GetObject("butt3.Image");
    this.butt3.ImageAlign = ContentAlignment.MiddleRight;
    Button butt3_1 = this.butt3;
    point1 = new Point(164, 66);
    Point point11 = point1;
    butt3_1.Location = point11;
    this.butt3.Name = "butt3";
    Button butt3_2 = this.butt3;
    size1 = new Size(68, 25);
    Size size11 = size1;
    butt3_2.Size = size11;
    this.butt3.TabIndex = 2;
    this.butt3.TextAlign = ContentAlignment.TopLeft;
    this.butt3.UseVisualStyleBackColor = true;
    this.butt3.Visible = false;
    this.butt2.Image = (Image) componentResourceManager.GetObject("butt2.Image");
    this.butt2.ImageAlign = ContentAlignment.MiddleRight;
    Button butt2_1 = this.butt2;
    point1 = new Point(238, 66);
    Point point12 = point1;
    butt2_1.Location = point12;
    this.butt2.Name = "butt2";
    Button butt2_2 = this.butt2;
    size1 = new Size(68, 25);
    Size size12 = size1;
    butt2_2.Size = size12;
    this.butt2.TabIndex = 1;
    this.butt2.TextAlign = ContentAlignment.TopLeft;
    this.butt2.UseVisualStyleBackColor = true;
    this.butt2.Visible = false;
    this.butt1.Image = (Image) componentResourceManager.GetObject("butt1.Image");
    this.butt1.ImageAlign = ContentAlignment.MiddleRight;
    Button butt1_1 = this.butt1;
    point1 = new Point(324, 66);
    Point point13 = point1;
    butt1_1.Location = point13;
    this.butt1.Name = "butt1";
    Button butt1_2 = this.butt1;
    size1 = new Size(68, 25);
    Size size13 = size1;
    butt1_2.Size = size13;
    this.butt1.TabIndex = 0;
    this.butt1.TextAlign = ContentAlignment.TopLeft;
    this.butt1.UseVisualStyleBackColor = true;
    this.butt1.Visible = false;
    this.txtDetails.BackColor = Color.Silver;
    this.txtDetails.Dock = DockStyle.Top;
    this.txtDetails.ForeColor = Color.Black;
    TextBox txtDetails1 = this.txtDetails;
    point1 = new Point(0, 103);
    Point point14 = point1;
    txtDetails1.Location = point14;
    this.txtDetails.Multiline = true;
    this.txtDetails.Name = "txtDetails";
    this.txtDetails.RightToLeft = RightToLeft.No;
    this.txtDetails.ScrollBars = ScrollBars.Horizontal;
    TextBox txtDetails2 = this.txtDetails;
    size1 = new Size(480, 130);
    Size size14 = size1;
    txtDetails2.Size = size14;
    this.txtDetails.TabIndex = 12;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    size1 = new Size(480, 103);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtDetails);
    this.Controls.Add((Control) this.exlblMessageBox);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.Name = nameof (frmMessageBox);
    this.RightToLeft = RightToLeft.Yes;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.pbxAlaram).EndInit();
    ((ISupportInitialize) this.pbxError).EndInit();
    ((ISupportInitialize) this.pbxPermission).EndInit();
    ((ISupportInitialize) this.pbxConfrim).EndInit();
    ((ISupportInitialize) this.pbxMessage).EndInit();
    ((ISupportInitialize) this.pbxHelp).EndInit();
    this.exlblMessageBox.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual ExpandablePanel exlblMessageBox
  {
    [DebuggerNonUserCode] get => this._exlblMessageBox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._exlblMessageBox = value;
    }
  }

  internal virtual Label lblBodyText
  {
    [DebuggerNonUserCode] get => this._lblBodyText;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBodyText = value;
    }
  }

  internal virtual PictureBox pbxHelp
  {
    [DebuggerNonUserCode] get => this._pbxHelp;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbxHelp = value;
  }

  internal virtual PictureBox pbxMessage
  {
    [DebuggerNonUserCode] get => this._pbxMessage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._pbxMessage = value;
    }
  }

  internal virtual PictureBox pbxConfrim
  {
    [DebuggerNonUserCode] get => this._pbxConfrim;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._pbxConfrim = value;
    }
  }

  internal virtual PictureBox pbxPermission
  {
    [DebuggerNonUserCode] get => this._pbxPermission;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._pbxPermission = value;
    }
  }

  internal virtual PictureBox pbxError
  {
    [DebuggerNonUserCode] get => this._pbxError;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbxError = value;
  }

  internal virtual PictureBox pbxAlaram
  {
    [DebuggerNonUserCode] get => this._pbxAlaram;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._pbxAlaram = value;
    }
  }

  internal virtual TextBox txtDetails
  {
    [DebuggerNonUserCode] get => this._txtDetails;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtDetails = value;
    }
  }

  internal virtual Button butt1
  {
    [DebuggerNonUserCode] get => this._butt1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Buttons);
      if (this._butt1 != null)
        this._butt1.Click -= eventHandler;
      this._butt1 = value;
      if (this._butt1 == null)
        return;
      this._butt1.Click += eventHandler;
    }
  }

  internal virtual Button buttShowDetails
  {
    [DebuggerNonUserCode] get => this._buttShowDetails;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ButtonDetails);
      if (this._buttShowDetails != null)
        this._buttShowDetails.Click -= eventHandler;
      this._buttShowDetails = value;
      if (this._buttShowDetails == null)
        return;
      this._buttShowDetails.Click += eventHandler;
    }
  }

  internal virtual Button butt3
  {
    [DebuggerNonUserCode] get => this._butt3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Buttons);
      if (this._butt3 != null)
        this._butt3.Click -= eventHandler;
      this._butt3 = value;
      if (this._butt3 == null)
        return;
      this._butt3.Click += eventHandler;
    }
  }

  internal virtual Button butt2
  {
    [DebuggerNonUserCode] get => this._butt2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Buttons);
      if (this._butt2 != null)
        this._butt2.Click -= eventHandler;
      this._butt2 = value;
      if (this._butt2 == null)
        return;
      this._butt2.Click += eventHandler;
    }
  }

  public frmMessageBox(
    Form frmParent,
    string BodyText,
    int Title,
    int Button,
    int DefualtButton,
    string Details = "")
  {
    this.Shown += new EventHandler(this.frmMessageBox_Shown);
    this.Load += new EventHandler(this.frmMessageBox_Load);
    frmMessageBox.__ENCAddToList((object) this);
    this.Resault = 3;
    this.InitializeComponent();
    ExpandablePanel exlblMessageBox1 = this.exlblMessageBox;
    Size size1 = new Size(this.Width, checked (this.Height - 20));
    Size size2 = size1;
    exlblMessageBox1.Size = size2;
    if (Strings.Len(BodyText) <= 130)
    {
      size1 = new Size(400, 130);
      this.Size = size1;
    }
    else if (Strings.Len(BodyText) > 130 & Strings.Len(BodyText) <= 200)
    {
      size1 = new Size(450, 130);
      this.Size = size1;
    }
    else if (Strings.Len(BodyText) > 200 & Strings.Len(BodyText) <= 250)
    {
      size1 = new Size(550, 130);
      this.Size = size1;
    }
    else if (Strings.Len(BodyText) > 250 & Strings.Len(BodyText) <= 300)
    {
      size1 = new Size(650, 130);
      this.Size = size1;
    }
    else if (Strings.Len(BodyText) > 300 & Strings.Len(BodyText) <= 400)
    {
      size1 = new Size(750, 130);
      this.Size = size1;
    }
    else if (Strings.Len(BodyText) > 400)
    {
      size1 = new Size(750, checked (this.Height + unchecked (checked (Strings.Len(BodyText) - 300) / 120) * 12));
      this.Size = size1;
      ExpandablePanel exlblMessageBox2 = this.exlblMessageBox;
      size1 = new Size(this.exlblMessageBox.Width, checked (this.Height - 23));
      Size size3 = size1;
      exlblMessageBox2.Size = size3;
    }
    this.lblBodyText.BorderStyle = BorderStyle.None;
    this.lblBodyText.Text = BodyText;
    switch (Title)
    {
      case 0:
        this.Text = "راهنمائي";
        this.pbxHelp.Visible = true;
        break;
      case 1:
        this.Text = "خطا";
        this.pbxError.Visible = true;
        break;
      case 2:
        this.Text = "هشدار";
        this.pbxAlaram.Visible = true;
        break;
      case 3:
        this.Text = "تاييديه";
        this.pbxConfrim.Visible = true;
        break;
      case 4:
        this.Text = "پيغام";
        this.pbxMessage.Visible = true;
        break;
      case 5:
        this.Text = "محدوديت دسترسي";
        this.pbxPermission.Visible = true;
        break;
    }
    int num;
    switch (Button)
    {
      case 0:
        this.butt1.Visible = true;
        this.butt1.Text = "تاييد";
        this.AcceptButton = (IButtonControl) this.butt1;
        num = 1;
        break;
      case 1:
        this.butt1.Visible = true;
        this.butt2.Visible = true;
        this.butt1.Text = "تاييد";
        this.butt2.Text = "انصراف";
        this.AcceptButton = (IButtonControl) this.butt1;
        this.CancelButton = (IButtonControl) this.butt2;
        num = 2;
        break;
      case 2:
        this.butt1.Visible = true;
        this.butt2.Visible = true;
        this.butt1.Text = "تكرار";
        this.butt2.Text = "انصراف";
        this.AcceptButton = (IButtonControl) this.butt1;
        this.CancelButton = (IButtonControl) this.butt2;
        num = 2;
        break;
      case 3:
        this.butt1.Visible = true;
        this.butt2.Visible = true;
        this.butt1.Text = "بله";
        this.butt2.Text = "خير";
        this.AcceptButton = (IButtonControl) this.butt1;
        this.CancelButton = (IButtonControl) this.butt2;
        num = 2;
        break;
      case 4:
        this.butt1.Visible = true;
        this.butt2.Visible = true;
        this.butt3.Visible = true;
        this.butt1.Text = "بله";
        this.butt2.Text = "خير";
        this.butt3.Text = "انصراف";
        this.AcceptButton = (IButtonControl) this.butt1;
        this.CancelButton = (IButtonControl) this.butt2;
        num = 3;
        break;
      case 5:
        this.butt1.Visible = true;
        this.butt2.Visible = true;
        this.butt3.Visible = true;
        this.butt1.Text = "تكرار";
        this.butt2.Text = "حذف";
        this.butt3.Text = "انصراف";
        this.AcceptButton = (IButtonControl) this.butt1;
        this.CancelButton = (IButtonControl) this.butt2;
        num = 3;
        break;
    }
    Point point1;
    switch (num)
    {
      case 1:
        Button butt1_1 = this.butt1;
        point1 = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 - (double) this.butt1.Width / 2.0))), checked (this.exlblMessageBox.Height - 37));
        Point point2 = point1;
        butt1_1.Location = point2;
        break;
      case 2:
        Button butt1_2 = this.butt1;
        point1 = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 + 10.0))), checked (this.exlblMessageBox.Height - 37));
        Point point3 = point1;
        butt1_2.Location = point3;
        Button butt2_1 = this.butt2;
        point1 = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 - 10.0 - (double) this.butt2.Width))), checked (this.exlblMessageBox.Height - 37));
        Point point4 = point1;
        butt2_1.Location = point4;
        break;
      case 3:
        Button butt1_3 = this.butt1;
        point1 = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 + (double) this.butt1.Width / 2.0 + 10.0))), checked (this.exlblMessageBox.Height - 37));
        Point point5 = point1;
        butt1_3.Location = point5;
        Button butt2_2 = this.butt2;
        point1 = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 - (double) this.butt1.Width / 2.0))), checked (this.exlblMessageBox.Height - 37));
        Point point6 = point1;
        butt2_2.Location = point6;
        Button butt3 = this.butt3;
        point1 = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 - (double) this.butt1.Width / 2.0 - 10.0 - (double) this.butt1.Width))), checked (this.exlblMessageBox.Height - 37));
        Point point7 = point1;
        butt3.Location = point7;
        break;
    }
    Button buttShowDetails = this.buttShowDetails;
    point1 = new Point(12, checked (this.exlblMessageBox.Height - 37));
    Point point8 = point1;
    buttShowDetails.Location = point8;
    this.PrDefualtButton = DefualtButton;
    this.PrFrmParent = frmParent;
    if (Operators.CompareString(Details, "", false) == 0)
      this.buttShowDetails.Visible = false;
    else
      this.txtDetails.Text = Details;
  }

  private void ButtonDetails(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.buttShowDetails.Text, "^", false) == 0)
    {
      this.buttShowDetails.Text = "V";
      this.Size = new Size(this.Width, checked (this.Height + 130));
    }
    else
    {
      this.buttShowDetails.Text = "^";
      this.Size = new Size(this.Width, checked (this.Height - 130));
    }
  }

  private void Buttons(object sender, EventArgs e)
  {
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Operators.ConditionalCompareObjectEqual(Left, (object) "butt1", false))
      this.Resault = 0;
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "butt2", false))
      this.Resault = 1;
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "butt3", false))
      this.Resault = 2;
    this.Close();
  }

  private void frmMessageBox_Load(object sender, EventArgs e)
  {
    int x = checked ((int) Math.Round(unchecked ((double) this.PrFrmParent.Location.X + (double) this.PrFrmParent.Width / 2.0 - (double) this.Size.Width / 2.0)));
    Point point = this.PrFrmParent.Location;
    int y = checked ((int) Math.Round(unchecked ((double) point.Y + (double) this.PrFrmParent.Size.Height / 2.0 - (double) this.Size.Height / 2.0)));
    Size size;
    if (checked (x + this.Size.Width) > Screen.GetWorkingArea((Control) this).Width)
    {
      int width1 = Screen.GetWorkingArea((Control) this).Width;
      size = this.Size;
      int width2 = size.Width;
      x = checked (width1 - width2);
    }
    else if (x < 0)
      x = 0;
    if (checked (y + this.Size.Height) > Screen.GetWorkingArea((Control) this).Height)
    {
      int height1 = Screen.GetWorkingArea((Control) this).Height;
      size = this.Size;
      int height2 = size.Height;
      y = checked (height1 - height2);
    }
    else if (y < 0)
      y = 0;
    point = new Point(x, y);
    this.Location = point;
  }

  private void frmMessageBox_Shown(object sender, EventArgs e)
  {
    switch (this.PrDefualtButton)
    {
      case 0:
        this.butt1.Focus();
        break;
      case 1:
        this.butt2.Focus();
        break;
      case 2:
        this.butt3.Focus();
        break;
    }
  }
}
