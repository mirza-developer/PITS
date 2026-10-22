// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmPrint
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using CrystalDecisions.Windows.Forms;
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
public class frmPrint : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("CrystalReportViewer1")]
  private CrystalReportViewer _CrystalReportViewer1;
  [AccessedThroughProperty("rptPrint1")]
  private rptPrint _rptPrint1;
  [AccessedThroughProperty("rptPrint2")]
  private rptPrint _rptPrint2;
  [AccessedThroughProperty("rptPrint3")]
  private rptPrint _rptPrint3;

  [DebuggerNonUserCode]
  static frmPrint()
  {
  }

  [DebuggerNonUserCode]
  public frmPrint()
  {
    this.Load += new EventHandler(this.frmPrint_Load);
    frmPrint.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPrint.__ENCList)
    {
      if (frmPrint.__ENCList.Count == frmPrint.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPrint.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPrint.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPrint.__ENCList[index1] = frmPrint.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPrint.__ENCList.RemoveRange(index1, checked (frmPrint.__ENCList.Count - index1));
        frmPrint.__ENCList.Capacity = frmPrint.__ENCList.Count;
      }
      frmPrint.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPrint));
    this.CrystalReportViewer1 = new CrystalReportViewer();
    this.rptPrint3 = new rptPrint();
    this.rptPrint2 = new rptPrint();
    this.rptPrint1 = new rptPrint();
    this.SuspendLayout();
    this.CrystalReportViewer1.ActiveViewIndex = -1;
    ((UserControl) this.CrystalReportViewer1).BorderStyle = BorderStyle.FixedSingle;
    ((Control) this.CrystalReportViewer1).Cursor = Cursors.Default;
    ((Control) this.CrystalReportViewer1).Dock = DockStyle.Fill;
    ((Control) this.CrystalReportViewer1).Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    ((Control) this.CrystalReportViewer1).Location = new Point(0, 0);
    ((Control) this.CrystalReportViewer1).Name = "CrystalReportViewer1";
    CrystalReportViewer crystalReportViewer1 = this.CrystalReportViewer1;
    Size size1 = new Size(770, 266);
    Size size2 = size1;
    ((Control) crystalReportViewer1).Size = size2;
    ((Control) this.CrystalReportViewer1).TabIndex = 0;
    this.CrystalReportViewer1.ToolPanelView = (ToolPanelViewType) 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(770, 266);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.CrystalReportViewer1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmPrint);
    this.RightToLeft = RightToLeft.Yes;
    this.Text = nameof (frmPrint);
    this.WindowState = FormWindowState.Maximized;
    this.ResumeLayout(false);
  }

  internal virtual CrystalReportViewer CrystalReportViewer1
  {
    [DebuggerNonUserCode] get => this._CrystalReportViewer1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._CrystalReportViewer1 = value;
    }
  }

  internal virtual rptPrint rptPrint1
  {
    [DebuggerNonUserCode] get => this._rptPrint1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._rptPrint1 = value;
    }
  }

  internal virtual rptPrint rptPrint2
  {
    [DebuggerNonUserCode] get => this._rptPrint2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._rptPrint2 = value;
    }
  }

  internal virtual rptPrint rptPrint3
  {
    [DebuggerNonUserCode] get => this._rptPrint3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._rptPrint3 = value;
    }
  }

  private void frmPrint_Load(object sender, EventArgs e)
  {
  }
}
