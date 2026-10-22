// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmAbout
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

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
public class frmAbout : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("lblSoftwareDescription")]
  private Label _lblSoftwareDescription;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;

  [DebuggerNonUserCode]
  static frmAbout()
  {
  }

  [DebuggerNonUserCode]
  public frmAbout()
  {
    frmAbout.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAbout.__ENCList)
    {
      if (frmAbout.__ENCList.Count == frmAbout.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAbout.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAbout.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAbout.__ENCList[index1] = frmAbout.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAbout.__ENCList.RemoveRange(index1, checked (frmAbout.__ENCList.Count - index1));
        frmAbout.__ENCList.Capacity = frmAbout.__ENCList.Count;
      }
      frmAbout.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAbout));
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.lblSoftwareDescription = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    Point point1 = new Point(98, 59);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(195, 13);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 8;
    this.Label1.Text = "سامانه نرم افزاري مجتمع مسكوني تكش";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(41, 132);
    Point point3 = point1;
    label2_1.Location = point3;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(253, 13);
    Size size3 = size1;
    label2_2.Size = size3;
    this.Label2.TabIndex = 9;
    this.Label2.Text = "شركت راهكارهاي فناوري اطلاعات پينك - كاوه سمائي";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(266, 86);
    Point point4 = point1;
    label3_1.Location = point4;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(28, 13);
    Size size4 = size1;
    label3_2.Size = size4;
    this.Label3.TabIndex = 10;
    this.Label3.Text = "مالك";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(242, 109);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(52, 13);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 11;
    this.Label4.Text = "نگارش : 1";
    Label softwareDescription1 = this.lblSoftwareDescription;
    point1 = new Point(115, 86);
    Point point6 = point1;
    softwareDescription1.Location = point6;
    this.lblSoftwareDescription.Name = "lblSoftwareDescription";
    this.lblSoftwareDescription.RightToLeft = RightToLeft.Yes;
    Label softwareDescription2 = this.lblSoftwareDescription;
    size1 = new Size(145, 16 /*0x10*/);
    Size size6 = size1;
    softwareDescription2.Size = size6;
    this.lblSoftwareDescription.TabIndex = 43;
    this.lblSoftwareDescription.Text = "مجتمع مسكوني تكش";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(115, 156);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(178, 13);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 44;
    this.Label5.Text = "تلفن : 27447  همراه : 09124576680";
    this.Label6.ForeColor = Color.Red;
    Label label6_1 = this.Label6;
    point1 = new Point(13, 189);
    Point point8 = point1;
    label6_1.Location = point8;
    this.Label6.Name = "Label6";
    this.Label6.RightToLeft = RightToLeft.Yes;
    Label label6_2 = this.Label6;
    size1 = new Size(281, 47);
    Size size8 = size1;
    label6_2.Size = size8;
    this.Label6.TabIndex = 45;
    this.Label6.Text = "اين سامانه صرفا جهت استفاده مجتمع مسكوني تكش طراحي شده است و كپي و استفاده از آن در هر مكان ديگر مجاز نميباشد";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(306, 245);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.lblSoftwareDescription);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAbout);
    this.Text = "درباره برنامه";
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    this.Controls.SetChildIndex((Control) this.Label3, 0);
    this.Controls.SetChildIndex((Control) this.Label4, 0);
    this.Controls.SetChildIndex((Control) this.lblSoftwareDescription, 0);
    this.Controls.SetChildIndex((Control) this.Label5, 0);
    this.Controls.SetChildIndex((Control) this.Label6, 0);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label lblSoftwareDescription
  {
    [DebuggerNonUserCode] get => this._lblSoftwareDescription;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSoftwareDescription = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }
}
