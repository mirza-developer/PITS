// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmMain
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using MPS.NET_Controls;
using PITS.Town_PresentationLayer.My;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer;

[DesignerGenerated]
public class frmMain : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("buttHome")]
  private ButtonMps _buttHome;
  [AccessedThroughProperty("ImageList1")]
  private ImageList _ImageList1;
  [AccessedThroughProperty("buttPeriodUse")]
  private ButtonMps _buttPeriodUse;
  [AccessedThroughProperty("buttTotalBill")]
  private ButtonMps _buttTotalBill;
  [AccessedThroughProperty("buttExit")]
  private ButtonMps _buttExit;
  [AccessedThroughProperty("buttAbout")]
  private ButtonMps _buttAbout;
  [AccessedThroughProperty("buttBackup")]
  private ButtonMps _buttBackup;
  [AccessedThroughProperty("buttPass")]
  private ButtonMps _buttPass;
  [AccessedThroughProperty("buttUse")]
  private ButtonMps _buttUse;
  [AccessedThroughProperty("buttBill")]
  private ButtonMps _buttBill;
  [AccessedThroughProperty("buttPattern")]
  private ButtonMps _buttPattern;
  private cfrmMain frm;

  [DebuggerNonUserCode]
  static frmMain()
  {
  }

  [DebuggerNonUserCode]
  public frmMain()
  {
    this.Disposed += new EventHandler(this.frmMain_Disposed);
    this.Load += new EventHandler(this.frmMain_Load);
    frmMain.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMain.__ENCList)
    {
      if (frmMain.__ENCList.Count == frmMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMain.__ENCList[index1] = frmMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMain.__ENCList.RemoveRange(index1, checked (frmMain.__ENCList.Count - index1));
        frmMain.__ENCList.Capacity = frmMain.__ENCList.Count;
      }
      frmMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
    this.buttHome = new ButtonMps();
    this.ImageList1 = new ImageList(this.components);
    this.buttPeriodUse = new ButtonMps();
    this.buttTotalBill = new ButtonMps();
    this.buttExit = new ButtonMps();
    this.buttAbout = new ButtonMps();
    this.buttBackup = new ButtonMps();
    this.buttPass = new ButtonMps();
    this.buttUse = new ButtonMps();
    this.buttBill = new ButtonMps();
    this.buttPattern = new ButtonMps();
    this.SuspendLayout();
    this.buttHome.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttHome.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttHome.ImageAlign = ContentAlignment.MiddleRight;
    this.buttHome.ImageKey = "home.ico";
    this.buttHome.ImageList = this.ImageList1;
    ButtonMps buttHome1 = this.buttHome;
    Point point1 = new Point(2, 3);
    Point point2 = point1;
    buttHome1.Location = point2;
    this.buttHome.Name = "buttHome";
    this.buttHome.RightToLeft = RightToLeft.Yes;
    this.buttHome.ShortcutKeys = "";
    ButtonMps buttHome2 = this.buttHome;
    Size size1 = new Size(146, 45);
    Size size2 = size1;
    buttHome2.Size = size2;
    this.buttHome.TabIndex = 0;
    this.buttHome.Tag = (object) "0";
    this.buttHome.Text = "واحدهاي مسكوني";
    this.buttHome.TextAlign = ContentAlignment.MiddleLeft;
    this.buttHome.TooltipText = "";
    this.buttHome.UseVisualStyleBackColor = false;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "binary-tree.ico");
    this.ImageList1.Images.SetKeyName(1, "product.ico");
    this.ImageList1.Images.SetKeyName(2, "Process-Accept.ico");
    this.ImageList1.Images.SetKeyName(3, "انصراف.ico");
    this.ImageList1.Images.SetKeyName(4, "FAQ.ico");
    this.ImageList1.Images.SetKeyName(5, "download-database.ico");
    this.ImageList1.Images.SetKeyName(6, "key.ico");
    this.ImageList1.Images.SetKeyName(7, "signature.ico");
    this.ImageList1.Images.SetKeyName(8, "statistics.ico");
    this.ImageList1.Images.SetKeyName(9, "home.ico");
    this.buttPeriodUse.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttPeriodUse.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttPeriodUse.ImageAlign = ContentAlignment.MiddleRight;
    this.buttPeriodUse.ImageKey = "signature.ico";
    this.buttPeriodUse.ImageList = this.ImageList1;
    ButtonMps buttPeriodUse1 = this.buttPeriodUse;
    point1 = new Point(2, 156);
    Point point3 = point1;
    buttPeriodUse1.Location = point3;
    this.buttPeriodUse.Name = "buttPeriodUse";
    this.buttPeriodUse.RightToLeft = RightToLeft.Yes;
    this.buttPeriodUse.ShortcutKeys = "";
    ButtonMps buttPeriodUse2 = this.buttPeriodUse;
    size1 = new Size(146, 45);
    Size size3 = size1;
    buttPeriodUse2.Size = size3;
    this.buttPeriodUse.TabIndex = 3;
    this.buttPeriodUse.Tag = (object) "1";
    this.buttPeriodUse.Text = "دوره هاي كنترخواني";
    this.buttPeriodUse.TextAlign = ContentAlignment.MiddleLeft;
    this.buttPeriodUse.TooltipText = "";
    this.buttPeriodUse.UseVisualStyleBackColor = false;
    this.buttTotalBill.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttTotalBill.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttTotalBill.ImageAlign = ContentAlignment.MiddleRight;
    this.buttTotalBill.ImageKey = "Process-Accept.ico";
    this.buttTotalBill.ImageList = this.ImageList1;
    ButtonMps buttTotalBill1 = this.buttTotalBill;
    point1 = new Point(2, 258);
    Point point4 = point1;
    buttTotalBill1.Location = point4;
    this.buttTotalBill.Name = "buttTotalBill";
    this.buttTotalBill.RightToLeft = RightToLeft.Yes;
    this.buttTotalBill.ShortcutKeys = "";
    ButtonMps buttTotalBill2 = this.buttTotalBill;
    size1 = new Size(146, 45);
    Size size4 = size1;
    buttTotalBill2.Size = size4;
    this.buttTotalBill.TabIndex = 5;
    this.buttTotalBill.Tag = (object) "5";
    this.buttTotalBill.Text = "صدور قبوض";
    this.buttTotalBill.TextAlign = ContentAlignment.MiddleLeft;
    this.buttTotalBill.TooltipText = "";
    this.buttTotalBill.UseVisualStyleBackColor = false;
    this.buttExit.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttExit.DialogResult = DialogResult.Cancel;
    this.buttExit.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttExit.ImageAlign = ContentAlignment.MiddleRight;
    this.buttExit.ImageKey = "انصراف.ico";
    this.buttExit.ImageList = this.ImageList1;
    ButtonMps buttExit1 = this.buttExit;
    point1 = new Point(2, 462);
    Point point5 = point1;
    buttExit1.Location = point5;
    this.buttExit.Name = "buttExit";
    this.buttExit.RightToLeft = RightToLeft.Yes;
    this.buttExit.ShortcutKeys = "";
    ButtonMps buttExit2 = this.buttExit;
    size1 = new Size(146, 45);
    Size size5 = size1;
    buttExit2.Size = size5;
    this.buttExit.TabIndex = 9;
    this.buttExit.Tag = (object) "9";
    this.buttExit.Text = "خروج";
    this.buttExit.TextAlign = ContentAlignment.MiddleLeft;
    this.buttExit.TooltipText = "";
    this.buttExit.UseVisualStyleBackColor = false;
    this.buttAbout.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttAbout.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttAbout.ImageAlign = ContentAlignment.MiddleRight;
    this.buttAbout.ImageKey = "FAQ.ico";
    this.buttAbout.ImageList = this.ImageList1;
    ButtonMps buttAbout1 = this.buttAbout;
    point1 = new Point(2, 411);
    Point point6 = point1;
    buttAbout1.Location = point6;
    this.buttAbout.Name = "buttAbout";
    this.buttAbout.RightToLeft = RightToLeft.Yes;
    this.buttAbout.ShortcutKeys = "";
    ButtonMps buttAbout2 = this.buttAbout;
    size1 = new Size(146, 45);
    Size size6 = size1;
    buttAbout2.Size = size6;
    this.buttAbout.TabIndex = 8;
    this.buttAbout.Tag = (object) "8";
    this.buttAbout.Text = "درباره نرم افزار";
    this.buttAbout.TextAlign = ContentAlignment.MiddleLeft;
    this.buttAbout.TooltipText = "";
    this.buttAbout.UseVisualStyleBackColor = false;
    this.buttBackup.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttBackup.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttBackup.ImageAlign = ContentAlignment.MiddleRight;
    this.buttBackup.ImageKey = "download-database.ico";
    this.buttBackup.ImageList = this.ImageList1;
    ButtonMps buttBackup1 = this.buttBackup;
    point1 = new Point(2, 362);
    Point point7 = point1;
    buttBackup1.Location = point7;
    this.buttBackup.Name = "buttBackup";
    this.buttBackup.RightToLeft = RightToLeft.Yes;
    this.buttBackup.ShortcutKeys = "";
    ButtonMps buttBackup2 = this.buttBackup;
    size1 = new Size(146, 45);
    Size size7 = size1;
    buttBackup2.Size = size7;
    this.buttBackup.TabIndex = 7;
    this.buttBackup.Tag = (object) "7";
    this.buttBackup.Text = "نسخه پشتيبان";
    this.buttBackup.TextAlign = ContentAlignment.MiddleLeft;
    this.buttBackup.TooltipText = "";
    this.buttBackup.UseVisualStyleBackColor = false;
    this.buttPass.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttPass.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttPass.ImageAlign = ContentAlignment.MiddleRight;
    this.buttPass.ImageKey = "key.ico";
    this.buttPass.ImageList = this.ImageList1;
    ButtonMps buttPass1 = this.buttPass;
    point1 = new Point(2, 311);
    Point point8 = point1;
    buttPass1.Location = point8;
    this.buttPass.Name = "buttPass";
    this.buttPass.RightToLeft = RightToLeft.Yes;
    this.buttPass.ShortcutKeys = "";
    ButtonMps buttPass2 = this.buttPass;
    size1 = new Size(146, 45);
    Size size8 = size1;
    buttPass2.Size = size8;
    this.buttPass.TabIndex = 6;
    this.buttPass.Tag = (object) "6";
    this.buttPass.Text = "تغيير كلمه عبور";
    this.buttPass.TextAlign = ContentAlignment.MiddleLeft;
    this.buttPass.TooltipText = "";
    this.buttPass.UseVisualStyleBackColor = false;
    this.buttUse.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttUse.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttUse.ImageAlign = ContentAlignment.MiddleRight;
    this.buttUse.ImageKey = "statistics.ico";
    this.buttUse.ImageList = this.ImageList1;
    ButtonMps buttUse1 = this.buttUse;
    point1 = new Point(2, 207);
    Point point9 = point1;
    buttUse1.Location = point9;
    this.buttUse.Name = "buttUse";
    this.buttUse.RightToLeft = RightToLeft.Yes;
    this.buttUse.ShortcutKeys = "";
    ButtonMps buttUse2 = this.buttUse;
    size1 = new Size(146, 45);
    Size size9 = size1;
    buttUse2.Size = size9;
    this.buttUse.TabIndex = 4;
    this.buttUse.Tag = (object) "2";
    this.buttUse.Text = "مصرف واحدها";
    this.buttUse.TextAlign = ContentAlignment.MiddleLeft;
    this.buttUse.TooltipText = "";
    this.buttUse.UseVisualStyleBackColor = false;
    this.buttBill.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttBill.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttBill.ImageAlign = ContentAlignment.MiddleRight;
    this.buttBill.ImageKey = "product.ico";
    this.buttBill.ImageList = this.ImageList1;
    ButtonMps buttBill1 = this.buttBill;
    point1 = new Point(2, 105);
    Point point10 = point1;
    buttBill1.Location = point10;
    this.buttBill.Name = "buttBill";
    this.buttBill.RightToLeft = RightToLeft.Yes;
    this.buttBill.ShortcutKeys = "";
    ButtonMps buttBill2 = this.buttBill;
    size1 = new Size(146, 45);
    Size size10 = size1;
    buttBill2.Size = size10;
    this.buttBill.TabIndex = 2;
    this.buttBill.Tag = (object) "3";
    this.buttBill.Text = "قبوض سازمان آب";
    this.buttBill.TextAlign = ContentAlignment.MiddleLeft;
    this.buttBill.TooltipText = "";
    this.buttBill.UseVisualStyleBackColor = false;
    this.buttPattern.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttPattern.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttPattern.ImageAlign = ContentAlignment.MiddleRight;
    this.buttPattern.ImageKey = "binary-tree.ico";
    this.buttPattern.ImageList = this.ImageList1;
    ButtonMps buttPattern1 = this.buttPattern;
    point1 = new Point(2, 54);
    Point point11 = point1;
    buttPattern1.Location = point11;
    this.buttPattern.Name = "buttPattern";
    this.buttPattern.RightToLeft = RightToLeft.Yes;
    this.buttPattern.ShortcutKeys = "";
    ButtonMps buttPattern2 = this.buttPattern;
    size1 = new Size(146, 45);
    Size size11 = size1;
    buttPattern2.Size = size11;
    this.buttPattern.TabIndex = 1;
    this.buttPattern.Tag = (object) "4";
    this.buttPattern.Text = "تعريف پلكان مصرف";
    this.buttPattern.TextAlign = ContentAlignment.MiddleLeft;
    this.buttPattern.TooltipText = "";
    this.buttPattern.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(7f, 14f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttExit;
    size1 = new Size(152, 514);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.buttPattern);
    this.Controls.Add((Control) this.buttBill);
    this.Controls.Add((Control) this.buttUse);
    this.Controls.Add((Control) this.buttPass);
    this.Controls.Add((Control) this.buttBackup);
    this.Controls.Add((Control) this.buttAbout);
    this.Controls.Add((Control) this.buttExit);
    this.Controls.Add((Control) this.buttTotalBill);
    this.Controls.Add((Control) this.buttPeriodUse);
    this.Controls.Add((Control) this.buttHome);
    this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMain);
    this.RightToLeft = RightToLeft.Yes;
    this.Text = "پنل مديريتي";
    this.ResumeLayout(false);
  }

  internal virtual ButtonMps buttHome
  {
    [DebuggerNonUserCode] get => this._buttHome;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttHome != null)
        this._buttHome.Click -= eventHandler;
      this._buttHome = value;
      if (this._buttHome == null)
        return;
      this._buttHome.Click += eventHandler;
    }
  }

  internal virtual ImageList ImageList1
  {
    [DebuggerNonUserCode] get => this._ImageList1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ImageList1 = value;
    }
  }

  internal virtual ButtonMps buttPeriodUse
  {
    [DebuggerNonUserCode] get => this._buttPeriodUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttPeriodUse != null)
        this._buttPeriodUse.Click -= eventHandler;
      this._buttPeriodUse = value;
      if (this._buttPeriodUse == null)
        return;
      this._buttPeriodUse.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttTotalBill
  {
    [DebuggerNonUserCode] get => this._buttTotalBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.SelectPrograms);
      EventHandler eventHandler2 = new EventHandler(this.SelectPrograms);
      if (this._buttTotalBill != null)
      {
        this._buttTotalBill.Click -= eventHandler1;
        this._buttTotalBill.Click -= eventHandler2;
      }
      this._buttTotalBill = value;
      if (this._buttTotalBill == null)
        return;
      this._buttTotalBill.Click += eventHandler1;
      this._buttTotalBill.Click += eventHandler2;
    }
  }

  internal virtual ButtonMps buttExit
  {
    [DebuggerNonUserCode] get => this._buttExit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttExit != null)
        this._buttExit.Click -= eventHandler;
      this._buttExit = value;
      if (this._buttExit == null)
        return;
      this._buttExit.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttAbout
  {
    [DebuggerNonUserCode] get => this._buttAbout;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttAbout != null)
        this._buttAbout.Click -= eventHandler;
      this._buttAbout = value;
      if (this._buttAbout == null)
        return;
      this._buttAbout.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttBackup
  {
    [DebuggerNonUserCode] get => this._buttBackup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttBackup != null)
        this._buttBackup.Click -= eventHandler;
      this._buttBackup = value;
      if (this._buttBackup == null)
        return;
      this._buttBackup.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttPass
  {
    [DebuggerNonUserCode] get => this._buttPass;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttPass != null)
        this._buttPass.Click -= eventHandler;
      this._buttPass = value;
      if (this._buttPass == null)
        return;
      this._buttPass.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttUse
  {
    [DebuggerNonUserCode] get => this._buttUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttUse != null)
        this._buttUse.Click -= eventHandler;
      this._buttUse = value;
      if (this._buttUse == null)
        return;
      this._buttUse.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttBill
  {
    [DebuggerNonUserCode] get => this._buttBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttBill != null)
        this._buttBill.Click -= eventHandler;
      this._buttBill = value;
      if (this._buttBill == null)
        return;
      this._buttBill.Click += eventHandler;
    }
  }

  internal virtual ButtonMps buttPattern
  {
    [DebuggerNonUserCode] get => this._buttPattern;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectPrograms);
      if (this._buttPattern != null)
        this._buttPattern.Click -= eventHandler;
      this._buttPattern = value;
      if (this._buttPattern == null)
        return;
      this._buttPattern.Click += eventHandler;
    }
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void SelectPrograms(object sender, EventArgs e)
  {
    NewLateBinding.LateSet(sender, (Type) null, "Enabled", new object[1]
    {
      (object) false
    }, (string[]) null, (Type[]) null);
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttHome", false))
      this.frm = (cfrmMain) new frmHomeMain();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttPeriodUse", false))
      this.frm = (cfrmMain) new frmPeriodUseMain();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttUse", false))
      this.frm = (cfrmMain) new frmUseMain();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttBill", false))
      this.frm = (cfrmMain) new frmBillMain();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttPattern", false))
      this.frm = (cfrmMain) new frmPatternMain();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttTotalBill", false))
    {
      this.frm = (cfrmMain) new frmFinalBill();
      this.frm.buttEdit.Visible = false;
      this.frm.buttPrint.Visible = true;
    }
    else
    {
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttPass", false))
      {
        frmPassword frmPassword = new frmPassword();
        frmPassword.StartPosition = FormStartPosition.Manual;
        frmPassword.Location = new Point(checked (this.Location.X - frmPassword.Width), 0);
        frmPassword.buttAdd.Visible = true;
        frmPassword.Show();
        NewLateBinding.LateSet(sender, (Type) null, "Enabled", new object[1]
        {
          (object) true
        }, (string[]) null, (Type[]) null);
        return;
      }
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttBackup", false))
      {
        frmBackUp frmBackUp = new frmBackUp();
        frmBackUp.StartPosition = FormStartPosition.Manual;
        frmBackUp.Location = new Point(checked (this.Location.X - frmBackUp.Width), 0);
        frmBackUp.buttAdd.Visible = true;
        frmBackUp.Show();
        NewLateBinding.LateSet(sender, (Type) null, "Enabled", new object[1]
        {
          (object) true
        }, (string[]) null, (Type[]) null);
        return;
      }
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttAbout", false))
      {
        frmAbout frmAbout = new frmAbout();
        frmAbout.StartPosition = FormStartPosition.Manual;
        frmAbout.Location = new Point(checked (this.Location.X - frmAbout.Width), 0);
        frmAbout.Show();
        NewLateBinding.LateSet(sender, (Type) null, "Enabled", new object[1]
        {
          (object) true
        }, (string[]) null, (Type[]) null);
        return;
      }
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttExit", false))
        ProjectData.EndApp();
    }
    try
    {
      foreach (Form openForm in (ReadOnlyCollectionBase) MyProject.Application.OpenForms)
      {
        if (Operators.CompareString(openForm.Name, this.frm.Name, false) == 0)
        {
          openForm.Focus();
          NewLateBinding.LateSet(sender, (Type) null, "Enabled", new object[1]
          {
            (object) true
          }, (string[]) null, (Type[]) null);
          return;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.frm.StartPosition = FormStartPosition.Manual;
    this.frm.MinimumSize = this.frm.Size;
    this.frm.Location = new Point(checked (this.Location.X - this.frm.Width), 0);
    this.frm.Text = Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    this.frm.Show();
    NewLateBinding.LateSet(sender, (Type) null, "Enabled", new object[1]
    {
      (object) true
    }, (string[]) null, (Type[]) null);
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void frmMain_Disposed(object sender, EventArgs e) => ProjectData.EndApp();

  private void frmMain_Load(object sender, EventArgs e)
  {
    this.Location = new Point(checked (Screen.GetWorkingArea((Control) this).Width - this.Width), 0);
  }
}
