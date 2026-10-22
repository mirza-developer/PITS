// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.cfrmData
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using PITS.Admin_BussinessLayer.Enumaration;
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
public class cfrmData : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Toolbar")]
  private ToolStrip _Toolbar;
  [AccessedThroughProperty("buttAdd")]
  private ToolStripButton _buttAdd;
  [AccessedThroughProperty("buttPreview")]
  private ToolStripButton _buttPreview;
  [AccessedThroughProperty("buttNext")]
  private ToolStripButton _buttNext;
  [AccessedThroughProperty("buttExit")]
  private ToolStripButton _buttExit;
  public Enum_ToolbarButtons FormType;
  public int FormValue;
  public cfrmMain FormParent;

  [DebuggerNonUserCode]
  static cfrmData()
  {
  }

  [DebuggerNonUserCode]
  public cfrmData()
  {
    this.KeyDown += new KeyEventHandler(this.ShortcutKey);
    cfrmData.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (cfrmData.__ENCList)
    {
      if (cfrmData.__ENCList.Count == cfrmData.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (cfrmData.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (cfrmData.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              cfrmData.__ENCList[index1] = cfrmData.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        cfrmData.__ENCList.RemoveRange(index1, checked (cfrmData.__ENCList.Count - index1));
        cfrmData.__ENCList.Capacity = cfrmData.__ENCList.Count;
      }
      cfrmData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (cfrmData));
    this.Toolbar = new ToolStrip();
    this.buttAdd = new ToolStripButton();
    this.buttNext = new ToolStripButton();
    this.buttPreview = new ToolStripButton();
    this.buttExit = new ToolStripButton();
    this.Toolbar.SuspendLayout();
    this.SuspendLayout();
    this.Toolbar.AutoSize = false;
    this.Toolbar.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Toolbar.Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.buttAdd,
      (ToolStripItem) this.buttNext,
      (ToolStripItem) this.buttPreview,
      (ToolStripItem) this.buttExit
    });
    this.Toolbar.Location = new Point(0, 0);
    this.Toolbar.Name = "Toolbar";
    this.Toolbar.RightToLeft = RightToLeft.Yes;
    ToolStrip toolbar = this.Toolbar;
    Size size1 = new Size(306, 38);
    Size size2 = size1;
    toolbar.Size = size2;
    this.Toolbar.TabIndex = 7;
    this.Toolbar.Text = "ToolStrip1";
    this.buttAdd.AutoSize = false;
    this.buttAdd.AutoToolTip = false;
    this.buttAdd.Enabled = false;
    this.buttAdd.Image = (Image) componentResourceManager.GetObject("buttAdd.Image");
    this.buttAdd.ImageTransparentColor = Color.Magenta;
    this.buttAdd.Name = "buttAdd";
    ToolStripButton buttAdd = this.buttAdd;
    size1 = new Size(65, 35);
    Size size3 = size1;
    buttAdd.Size = size3;
    this.buttAdd.Text = "ثبت";
    this.buttAdd.TextAlign = ContentAlignment.MiddleRight;
    this.buttAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttAdd.Visible = false;
    this.buttNext.AutoSize = false;
    this.buttNext.AutoToolTip = false;
    this.buttNext.Image = (Image) componentResourceManager.GetObject("buttNext.Image");
    this.buttNext.ImageTransparentColor = Color.Magenta;
    this.buttNext.Name = "buttNext";
    ToolStripButton buttNext = this.buttNext;
    size1 = new Size(65, 35);
    Size size4 = size1;
    buttNext.Size = size4;
    this.buttNext.Text = "بعدي";
    this.buttNext.TextAlign = ContentAlignment.MiddleRight;
    this.buttNext.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttNext.Visible = false;
    this.buttPreview.AutoSize = false;
    this.buttPreview.AutoToolTip = false;
    this.buttPreview.Image = (Image) componentResourceManager.GetObject("buttPreview.Image");
    this.buttPreview.ImageTransparentColor = Color.Magenta;
    this.buttPreview.Name = "buttPreview";
    ToolStripButton buttPreview = this.buttPreview;
    size1 = new Size(65, 35);
    Size size5 = size1;
    buttPreview.Size = size5;
    this.buttPreview.Text = "قبلي";
    this.buttPreview.TextAlign = ContentAlignment.MiddleRight;
    this.buttPreview.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttPreview.Visible = false;
    this.buttExit.AutoSize = false;
    this.buttExit.AutoToolTip = false;
    this.buttExit.Image = (Image) componentResourceManager.GetObject("buttExit.Image");
    this.buttExit.ImageTransparentColor = Color.Magenta;
    this.buttExit.Name = "buttExit";
    ToolStripButton buttExit = this.buttExit;
    size1 = new Size(65, 35);
    Size size6 = size1;
    buttExit.Size = size6;
    this.buttExit.Text = "خروج";
    this.buttExit.TextAlign = ContentAlignment.MiddleRight;
    this.buttExit.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(306, 235);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Toolbar);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.KeyPreview = true;
    this.Name = nameof (cfrmData);
    this.RightToLeft = RightToLeft.Yes;
    this.Toolbar.ResumeLayout(false);
    this.Toolbar.PerformLayout();
    this.ResumeLayout(false);
  }

  public virtual ToolStrip Toolbar
  {
    [DebuggerNonUserCode] get => this._Toolbar;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Toolbar = value;
  }

  internal virtual ToolStripButton buttAdd
  {
    [DebuggerNonUserCode] get => this._buttAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttAdd != null)
        this._buttAdd.Click -= eventHandler;
      this._buttAdd = value;
      if (this._buttAdd == null)
        return;
      this._buttAdd.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton buttPreview
  {
    [DebuggerNonUserCode] get => this._buttPreview;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttPreview != null)
        this._buttPreview.Click -= eventHandler;
      this._buttPreview = value;
      if (this._buttPreview == null)
        return;
      this._buttPreview.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton buttNext
  {
    [DebuggerNonUserCode] get => this._buttNext;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttNext != null)
        this._buttNext.Click -= eventHandler;
      this._buttNext = value;
      if (this._buttNext == null)
        return;
      this._buttNext.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton buttExit
  {
    [DebuggerNonUserCode] get => this._buttExit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttExit != null)
        this._buttExit.Click -= eventHandler;
      this._buttExit = value;
      if (this._buttExit == null)
        return;
      this._buttExit.Click += eventHandler;
    }
  }

  private void ToolbarButtonClick(object sender, EventArgs e)
  {
    if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "enabled", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) false, false))
      return;
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttAdd", false))
      this.Add();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttNext", false))
      this.Next();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttPreview", false))
      this.Preview();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttExit", false))
      this.Dispose();
  }

  private void ShortcutKey(object sender, KeyEventArgs e)
  {
    Keys keyData = e.KeyData;
    switch (keyData)
    {
      case Keys.Escape:
        this.ToolbarButtonClick((object) this.buttExit, (EventArgs) e);
        break;
      case Keys.F10:
        this.ToolbarButtonClick((object) this.buttAdd, (EventArgs) e);
        break;
      default:
        if (keyData == (Keys) (-(e.Control ? 1 : 0) & 78))
        {
          this.ToolbarButtonClick((object) this.buttNext, (EventArgs) e);
          break;
        }
        if (keyData != (Keys) (-(e.Control ? 1 : 0) & 80 /*0x50*/))
          break;
        this.ToolbarButtonClick((object) this.buttPreview, (EventArgs) e);
        break;
    }
  }

  protected virtual void Add() => this.buttAdd.Enabled = false;

  protected virtual void Next()
  {
    DataGridView dataGridMain = this.FormParent.DataGridMain;
    if (dataGridMain.Rows.Count == 0)
      return;
    int index1 = checked (dataGridMain.Rows.Count - 1);
    int num = checked (dataGridMain.Rows.Count - 1);
    int index2 = 0;
    while (index2 <= num)
    {
      if (Operators.ConditionalCompareObjectEqual(dataGridMain.Rows[index2].Cells["Id"].Value, (object) this.FormValue, false))
      {
        if (checked (index2 + 1) >= dataGridMain.Rows.Count)
        {
          index1 = 0;
          break;
        }
        index1 = checked (index2 + 1);
      }
      checked { ++index2; }
    }
    dataGridMain.ClearSelection();
    dataGridMain.Rows[index1].Selected = true;
    this.FormParent.LoadRecord(this);
  }

  protected virtual void Preview()
  {
    DataGridView dataGridMain = this.FormParent.DataGridMain;
    if (dataGridMain.Rows.Count == 0)
      return;
    int index1 = 0;
    int num = checked (dataGridMain.Rows.Count - 1);
    int index2 = 0;
    while (index2 <= num)
    {
      if (Operators.ConditionalCompareObjectEqual(dataGridMain.Rows[index2].Cells["Id"].Value, (object) this.FormValue, false))
      {
        if (checked (index2 - 1) < 0)
        {
          index1 = checked (dataGridMain.Rows.Count - 1);
          break;
        }
        index1 = checked (index2 - 1);
      }
      checked { ++index2; }
    }
    dataGridMain.ClearSelection();
    dataGridMain.Rows[index1].Selected = true;
    this.FormParent.LoadRecord(this);
  }
}
