// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.cfrmMain
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using PITS.Admin_BussinessLayer.Enumaration;
using PITS.Town_PresentationLayer.My;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer;

[DesignerGenerated]
public class cfrmMain : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Toolbar")]
  private ToolStrip _Toolbar;
  [AccessedThroughProperty("buttNew")]
  private ToolStripButton _buttNew;
  [AccessedThroughProperty("buttView")]
  private ToolStripButton _buttView;
  [AccessedThroughProperty("buttEdit")]
  private ToolStripButton _buttEdit;
  [AccessedThroughProperty("buttDelete")]
  private ToolStripButton _buttDelete;
  [AccessedThroughProperty("buttRefresh")]
  private ToolStripButton _buttRefresh;
  [AccessedThroughProperty("buttExit")]
  private ToolStripButton _buttExit;
  [AccessedThroughProperty("DataGridMain")]
  private DataGridView _DataGridMain;
  [AccessedThroughProperty("StatusBar")]
  private StatusStrip _StatusBar;
  [AccessedThroughProperty("ToolStripStatusLabel1")]
  private ToolStripStatusLabel _ToolStripStatusLabel1;
  [AccessedThroughProperty("SearchBar")]
  private GroupBox _SearchBar;
  [AccessedThroughProperty("buttPrint")]
  private ToolStripButton _buttPrint;
  public DataTable DataTable;
  public string obj1;
  public string obj2;

  [DebuggerNonUserCode]
  static cfrmMain()
  {
  }

  public cfrmMain()
  {
    this.Resize += new EventHandler(this.SetDatagridSize);
    this.Shown += (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.SetDatagridSetting());
    this.KeyDown += new KeyEventHandler(this.ShortcutKey);
    cfrmMain.__ENCAddToList((object) this);
    this.DataTable = new DataTable();
    this.obj1 = "";
    this.obj2 = "";
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (cfrmMain.__ENCList)
    {
      if (cfrmMain.__ENCList.Count == cfrmMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (cfrmMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (cfrmMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              cfrmMain.__ENCList[index1] = cfrmMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        cfrmMain.__ENCList.RemoveRange(index1, checked (cfrmMain.__ENCList.Count - index1));
        cfrmMain.__ENCList.Capacity = cfrmMain.__ENCList.Count;
      }
      cfrmMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (cfrmMain));
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
    this.Toolbar = new ToolStrip();
    this.buttNew = new ToolStripButton();
    this.buttView = new ToolStripButton();
    this.buttEdit = new ToolStripButton();
    this.buttDelete = new ToolStripButton();
    this.buttPrint = new ToolStripButton();
    this.buttRefresh = new ToolStripButton();
    this.buttExit = new ToolStripButton();
    this.DataGridMain = new DataGridView();
    this.StatusBar = new StatusStrip();
    this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
    this.SearchBar = new GroupBox();
    this.Toolbar.SuspendLayout();
    ((ISupportInitialize) this.DataGridMain).BeginInit();
    this.StatusBar.SuspendLayout();
    this.SuspendLayout();
    this.Toolbar.AutoSize = false;
    this.Toolbar.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Toolbar.Items.AddRange(new ToolStripItem[7]
    {
      (ToolStripItem) this.buttNew,
      (ToolStripItem) this.buttView,
      (ToolStripItem) this.buttEdit,
      (ToolStripItem) this.buttDelete,
      (ToolStripItem) this.buttPrint,
      (ToolStripItem) this.buttRefresh,
      (ToolStripItem) this.buttExit
    });
    ToolStrip toolbar1 = this.Toolbar;
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    toolbar1.Location = point2;
    this.Toolbar.Name = "Toolbar";
    this.Toolbar.RightToLeft = RightToLeft.Yes;
    ToolStrip toolbar2 = this.Toolbar;
    Size size1 = new Size(516, 38);
    Size size2 = size1;
    toolbar2.Size = size2;
    this.Toolbar.TabIndex = 6;
    this.Toolbar.Text = "ToolStrip1";
    this.buttNew.AutoSize = false;
    this.buttNew.AutoToolTip = false;
    this.buttNew.Image = (Image) componentResourceManager.GetObject("buttNew.Image");
    this.buttNew.ImageTransparentColor = Color.Magenta;
    this.buttNew.Name = "buttNew";
    ToolStripButton buttNew = this.buttNew;
    size1 = new Size(65, 35);
    Size size3 = size1;
    buttNew.Size = size3;
    this.buttNew.Text = "جديد";
    this.buttNew.TextAlign = ContentAlignment.MiddleRight;
    this.buttNew.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttView.AutoSize = false;
    this.buttView.AutoToolTip = false;
    this.buttView.Image = (Image) componentResourceManager.GetObject("buttView.Image");
    this.buttView.ImageTransparentColor = Color.Magenta;
    this.buttView.Name = "buttView";
    ToolStripButton buttView = this.buttView;
    size1 = new Size(65, 35);
    Size size4 = size1;
    buttView.Size = size4;
    this.buttView.Text = "بازبيني";
    this.buttView.TextAlign = ContentAlignment.MiddleRight;
    this.buttView.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttEdit.AutoSize = false;
    this.buttEdit.AutoToolTip = false;
    this.buttEdit.Image = (Image) componentResourceManager.GetObject("buttEdit.Image");
    this.buttEdit.ImageTransparentColor = Color.Magenta;
    this.buttEdit.Name = "buttEdit";
    ToolStripButton buttEdit = this.buttEdit;
    size1 = new Size(65, 35);
    Size size5 = size1;
    buttEdit.Size = size5;
    this.buttEdit.Text = "ويرايش";
    this.buttEdit.TextAlign = ContentAlignment.MiddleRight;
    this.buttEdit.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttDelete.AutoSize = false;
    this.buttDelete.AutoToolTip = false;
    this.buttDelete.Image = (Image) componentResourceManager.GetObject("buttDelete.Image");
    this.buttDelete.ImageTransparentColor = Color.Magenta;
    this.buttDelete.Name = "buttDelete";
    ToolStripButton buttDelete = this.buttDelete;
    size1 = new Size(65, 35);
    Size size6 = size1;
    buttDelete.Size = size6;
    this.buttDelete.Text = "حذف";
    this.buttDelete.TextAlign = ContentAlignment.MiddleRight;
    this.buttDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttPrint.AutoSize = false;
    this.buttPrint.AutoToolTip = false;
    this.buttPrint.Image = (Image) componentResourceManager.GetObject("buttPrint.Image");
    this.buttPrint.ImageTransparentColor = Color.Magenta;
    this.buttPrint.Name = "buttPrint";
    ToolStripButton buttPrint = this.buttPrint;
    size1 = new Size(65, 35);
    Size size7 = size1;
    buttPrint.Size = size7;
    this.buttPrint.Text = "چاپ";
    this.buttPrint.TextAlign = ContentAlignment.MiddleRight;
    this.buttPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttPrint.Visible = false;
    this.buttRefresh.AutoSize = false;
    this.buttRefresh.AutoToolTip = false;
    this.buttRefresh.Image = (Image) componentResourceManager.GetObject("buttRefresh.Image");
    this.buttRefresh.ImageTransparentColor = Color.Magenta;
    this.buttRefresh.Name = "buttRefresh";
    ToolStripButton buttRefresh = this.buttRefresh;
    size1 = new Size(65, 35);
    Size size8 = size1;
    buttRefresh.Size = size8;
    this.buttRefresh.Text = "نوسازي";
    this.buttRefresh.TextAlign = ContentAlignment.MiddleRight;
    this.buttRefresh.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.buttExit.AutoSize = false;
    this.buttExit.AutoToolTip = false;
    this.buttExit.Image = (Image) componentResourceManager.GetObject("buttExit.Image");
    this.buttExit.ImageTransparentColor = Color.Magenta;
    this.buttExit.Name = "buttExit";
    ToolStripButton buttExit = this.buttExit;
    size1 = new Size(65, 35);
    Size size9 = size1;
    buttExit.Size = size9;
    this.buttExit.Text = "خروج";
    this.buttExit.TextAlign = ContentAlignment.MiddleRight;
    this.buttExit.TextImageRelation = TextImageRelation.TextBeforeImage;
    this.DataGridMain.AllowDrop = true;
    this.DataGridMain.AllowUserToAddRows = false;
    this.DataGridMain.AllowUserToDeleteRows = false;
    this.DataGridMain.AllowUserToOrderColumns = true;
    this.DataGridMain.AllowUserToResizeRows = false;
    gridViewCellStyle1.BackColor = Color.WhiteSmoke;
    this.DataGridMain.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
    this.DataGridMain.BackgroundColor = Color.Gray;
    this.DataGridMain.BorderStyle = BorderStyle.Fixed3D;
    this.DataGridMain.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
    this.DataGridMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = Color.WhiteSmoke;
    gridViewCellStyle2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    gridViewCellStyle2.ForeColor = Color.Black;
    gridViewCellStyle2.SelectionBackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    gridViewCellStyle2.SelectionForeColor = Color.Black;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridMain.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridMain.ColumnHeadersHeight = 30;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = Color.White;
    gridViewCellStyle3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    gridViewCellStyle3.ForeColor = Color.Black;
    gridViewCellStyle3.SelectionBackColor = Color.Silver;
    gridViewCellStyle3.SelectionForeColor = Color.Black;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
    this.DataGridMain.DefaultCellStyle = gridViewCellStyle3;
    this.DataGridMain.Dock = DockStyle.Top;
    this.DataGridMain.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.DataGridMain.EnableHeadersVisualStyles = false;
    DataGridView dataGridMain1 = this.DataGridMain;
    point1 = new Point(0, 38);
    Point point3 = point1;
    dataGridMain1.Location = point3;
    this.DataGridMain.Name = "DataGridMain";
    this.DataGridMain.ReadOnly = true;
    this.DataGridMain.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    gridViewCellStyle4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    gridViewCellStyle4.ForeColor = Color.Black;
    gridViewCellStyle4.SelectionBackColor = Color.Silver;
    gridViewCellStyle4.SelectionForeColor = Color.Black;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridMain.RowHeadersDefaultCellStyle = gridViewCellStyle4;
    this.DataGridMain.RowHeadersVisible = false;
    gridViewCellStyle5.SelectionBackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridMain.RowsDefaultCellStyle = gridViewCellStyle5;
    this.DataGridMain.RowTemplate.Height = 50;
    this.DataGridMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.DataGridMain.ShowCellErrors = false;
    this.DataGridMain.ShowEditingIcon = false;
    this.DataGridMain.ShowRowErrors = false;
    DataGridView dataGridMain2 = this.DataGridMain;
    size1 = new Size(516, 163);
    Size size10 = size1;
    dataGridMain2.Size = size10;
    this.DataGridMain.TabIndex = 29;
    this.StatusBar.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.ToolStripStatusLabel1
    });
    StatusStrip statusBar1 = this.StatusBar;
    point1 = new Point(0, 313);
    Point point4 = point1;
    statusBar1.Location = point4;
    this.StatusBar.Name = "StatusBar";
    StatusStrip statusBar2 = this.StatusBar;
    size1 = new Size(516, 22);
    Size size11 = size1;
    statusBar2.Size = size11;
    this.StatusBar.TabIndex = 30;
    this.StatusBar.Text = "StatusStrip1";
    this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
    ToolStripStatusLabel stripStatusLabel1 = this.ToolStripStatusLabel1;
    size1 = new Size(0, 17);
    Size size12 = size1;
    stripStatusLabel1.Size = size12;
    this.SearchBar.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.SearchBar.Dock = DockStyle.Bottom;
    this.SearchBar.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    GroupBox searchBar1 = this.SearchBar;
    point1 = new Point(0, 201);
    Point point5 = point1;
    searchBar1.Location = point5;
    this.SearchBar.Name = "SearchBar";
    GroupBox searchBar2 = this.SearchBar;
    size1 = new Size(516, 112 /*0x70*/);
    Size size13 = size1;
    searchBar2.Size = size13;
    this.SearchBar.TabIndex = 31 /*0x1F*/;
    this.SearchBar.TabStop = false;
    this.SearchBar.Text = "جستجو بر اساس ..";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(516, 335);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.SearchBar);
    this.Controls.Add((Control) this.StatusBar);
    this.Controls.Add((Control) this.DataGridMain);
    this.Controls.Add((Control) this.Toolbar);
    this.KeyPreview = true;
    this.Name = nameof (cfrmMain);
    this.RightToLeft = RightToLeft.Yes;
    this.Toolbar.ResumeLayout(false);
    this.Toolbar.PerformLayout();
    ((ISupportInitialize) this.DataGridMain).EndInit();
    this.StatusBar.ResumeLayout(false);
    this.StatusBar.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public virtual ToolStrip Toolbar
  {
    [DebuggerNonUserCode] get => this._Toolbar;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Toolbar = value;
  }

  internal virtual ToolStripButton buttNew
  {
    [DebuggerNonUserCode] get => this._buttNew;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttNew != null)
        this._buttNew.Click -= eventHandler;
      this._buttNew = value;
      if (this._buttNew == null)
        return;
      this._buttNew.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton buttView
  {
    [DebuggerNonUserCode] get => this._buttView;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttView != null)
        this._buttView.Click -= eventHandler;
      this._buttView = value;
      if (this._buttView == null)
        return;
      this._buttView.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton buttEdit
  {
    [DebuggerNonUserCode] get => this._buttEdit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttEdit != null)
        this._buttEdit.Click -= eventHandler;
      this._buttEdit = value;
      if (this._buttEdit == null)
        return;
      this._buttEdit.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton buttDelete
  {
    [DebuggerNonUserCode] get => this._buttDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttDelete != null)
        this._buttDelete.Click -= eventHandler;
      this._buttDelete = value;
      if (this._buttDelete == null)
        return;
      this._buttDelete.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton buttRefresh
  {
    [DebuggerNonUserCode] get => this._buttRefresh;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttRefresh != null)
        this._buttRefresh.Click -= eventHandler;
      this._buttRefresh = value;
      if (this._buttRefresh == null)
        return;
      this._buttRefresh.Click += eventHandler;
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

  public virtual DataGridView DataGridMain
  {
    [DebuggerNonUserCode] get => this._DataGridMain;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellFormattingEventHandler formattingEventHandler = new DataGridViewCellFormattingEventHandler(this.DataGridMain_CellFormatting);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.ShortcutKey);
      DataGridViewRowsRemovedEventHandler removedEventHandler = (DataGridViewRowsRemovedEventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.ShowRecordCount());
      DataGridViewRowsAddedEventHandler addedEventHandler = (DataGridViewRowsAddedEventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.ShowRecordCount());
      EventHandler eventHandler = new EventHandler(this.DataGridMain_DoubleClick);
      DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.DataGridMain_DataError);
      if (this._DataGridMain != null)
      {
        this._DataGridMain.CellFormatting -= formattingEventHandler;
        this._DataGridMain.KeyDown -= keyEventHandler;
        this._DataGridMain.RowsRemoved -= removedEventHandler;
        this._DataGridMain.RowsAdded -= addedEventHandler;
        this._DataGridMain.DoubleClick -= eventHandler;
        this._DataGridMain.DataError -= errorEventHandler;
      }
      this._DataGridMain = value;
      if (this._DataGridMain == null)
        return;
      this._DataGridMain.CellFormatting += formattingEventHandler;
      this._DataGridMain.KeyDown += keyEventHandler;
      this._DataGridMain.RowsRemoved += removedEventHandler;
      this._DataGridMain.RowsAdded += addedEventHandler;
      this._DataGridMain.DoubleClick += eventHandler;
      this._DataGridMain.DataError += errorEventHandler;
    }
  }

  internal virtual StatusStrip StatusBar
  {
    [DebuggerNonUserCode] get => this._StatusBar;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._StatusBar = value;
    }
  }

  internal virtual ToolStripStatusLabel ToolStripStatusLabel1
  {
    [DebuggerNonUserCode] get => this._ToolStripStatusLabel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripStatusLabel1 = value;
    }
  }

  public virtual GroupBox SearchBar
  {
    [DebuggerNonUserCode] get => this._SearchBar;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._SearchBar = value;
    }
  }

  internal virtual ToolStripButton buttPrint
  {
    [DebuggerNonUserCode] get => this._buttPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolbarButtonClick);
      if (this._buttPrint != null)
        this._buttPrint.Click -= eventHandler;
      this._buttPrint = value;
      if (this._buttPrint == null)
        return;
      this._buttPrint.Click += eventHandler;
    }
  }

  private void ShortcutKey(object sender, KeyEventArgs e)
  {
    Keys keyData = e.KeyData;
    switch (keyData)
    {
      case Keys.Return:
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "DataGridMain", false))
          break;
        this.ToolbarButtonClick((object) this.buttView, (EventArgs) e);
        break;
      case Keys.Escape:
        this.ToolbarButtonClick((object) this.buttExit, (EventArgs) e);
        break;
      case Keys.Insert:
        this.ToolbarButtonClick((object) this.buttNew, (EventArgs) e);
        break;
      case Keys.F5:
        this.ToolbarButtonClick((object) this.buttRefresh, (EventArgs) e);
        break;
      case Keys.F8:
        this.ToolbarButtonClick((object) this.buttEdit, (EventArgs) e);
        break;
      default:
        if (keyData == (Keys) (-(e.Control ? 1 : 0) & 80 /*0x50*/))
        {
          this.ToolbarButtonClick((object) this.buttPrint, (EventArgs) e);
          break;
        }
        if (keyData == Keys.Delete)
        {
          this.ToolbarButtonClick((object) this.buttDelete, (EventArgs) e);
          break;
        }
        break;
    }
  }

  private void ToolbarButtonClick(object sender, EventArgs e)
  {
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "buttNew", false))
      this.New();
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "buttView", false))
      this.View();
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "buttEdit", false))
      this.Edit();
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "buttDelete", false))
      this.Delete();
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "buttPrint", false))
      this.Print();
    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "buttRefresh", false))
    {
      this.Refreshes();
    }
    else
    {
      if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left, (object) "buttExit", false))
        return;
      this.Dispose();
    }
  }

  protected virtual void New()
  {
  }

  protected virtual void View()
  {
  }

  protected virtual void Edit()
  {
  }

  protected virtual bool Delete()
  {
    if (!this.buttDelete.Enabled)
      return false;
    this.buttDelete.Enabled = false;
    if (this.DataGridMain.SelectedRows.Count == 0)
      return false;
    if (this.DataGridMain.SelectedRows.Count > 0)
    {
      string str = "";
      int num = checked (this.DataGridMain.SelectedRows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str + " سند "), this.DataGridMain.SelectedRows[index].Cells[1].Value));
        checked { ++index; }
      }
      if (MessageBoxMPS.show((Form) this, $" آيا از حذف  {str} اطمينان داريد؟ ", Enum_MsgboxTitle.Confrim, Enum_MsgboxButton.YesNo, Enum_MsgboxDefualButton.Butt1) == Enum_MsgboxResualt.Butt2Clicked)
        return false;
    }
    return true;
  }

  protected virtual void Refreshes()
  {
    if (this.buttRefresh.Enabled)
      ;
  }

  protected virtual void Print()
  {
  }

  protected bool CheckOpenform(cfrmData TargetForm)
  {
    try
    {
      foreach (Form openForm in (ReadOnlyCollectionBase) MyProject.Application.OpenForms)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(openForm.Name, TargetForm.Name, false) == 0)
        {
          openForm.Focus();
          return false;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    TargetForm.StartPosition = FormStartPosition.Manual;
    TargetForm.Location = new Point(checked (this.Location.X + this.Width - TargetForm.Width), checked (this.Location.Y + 20));
    return true;
  }

  private void SetDatagridSize(object sender, EventArgs e)
  {
    this.DataGridMain.Size = new Size(this.DataGridMain.Size.Width, checked (this.Height - this.Toolbar.Height - this.SearchBar.Height - this.StatusBar.Height));
  }

  protected virtual void DataGridMain_CellFormatting(
    object sender,
    DataGridViewCellFormattingEventArgs e)
  {
  }

  private void DataGridMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
  {
    try
    {
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public virtual bool LoadRecord(cfrmData frmData) => true;

  protected virtual void MakeDatagridColumn()
  {
  }

  private void DataGridMain_DoubleClick(object sender, EventArgs e)
  {
    this.ToolbarButtonClick((object) this.buttView, e);
  }

  protected virtual void SetDatagridSetting()
  {
    this.MakeDatagridColumn();
    this.Refreshes();
  }

  private void ShowRecordCount()
  {
    this.StatusBar.Items[0].Text = "تعداد اطلاعات  :" + Conversions.ToString(this.DataGridMain.Rows.Count);
  }
}
