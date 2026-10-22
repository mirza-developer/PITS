// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmPeriodUseMain
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using DevComponents.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MPS.NET_Controls;
using MPS.NET_Controls.Enumaration;
using PITS.Admin_BussinessLayer;
using PITS.Admin_BussinessLayer.Enumaration;
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
public class frmPeriodUseMain : cfrmMain
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtReader")]
  private InputBox _txtReader;
  [AccessedThroughProperty("txtNumber")]
  private InputBox _txtNumber;

  [DebuggerNonUserCode]
  static frmPeriodUseMain()
  {
  }

  [DebuggerNonUserCode]
  public frmPeriodUseMain()
  {
    frmPeriodUseMain.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPeriodUseMain.__ENCList)
    {
      if (frmPeriodUseMain.__ENCList.Count == frmPeriodUseMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPeriodUseMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPeriodUseMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPeriodUseMain.__ENCList[index1] = frmPeriodUseMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPeriodUseMain.__ENCList.RemoveRange(index1, checked (frmPeriodUseMain.__ENCList.Count - index1));
        frmPeriodUseMain.__ENCList.Capacity = frmPeriodUseMain.__ENCList.Count;
      }
      frmPeriodUseMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    InputButtonSettings inputButtonSettings1 = new InputButtonSettings();
    InputButtonSettings inputButtonSettings2 = new InputButtonSettings();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPeriodUseMain));
    this.txtReader = new InputBox();
    this.txtNumber = new InputBox();
    this.SearchBar.SuspendLayout();
    this.DataTable.BeginInit();
    this.SuspendLayout();
    this.SearchBar.Controls.Add((Control) this.txtReader);
    this.SearchBar.Controls.Add((Control) this.txtNumber);
    GroupBox searchBar1 = this.SearchBar;
    Point point1 = new Point(0, 249);
    Point point2 = point1;
    searchBar1.Location = point2;
    GroupBox searchBar2 = this.SearchBar;
    Size size1 = new Size(542, 112 /*0x70*/);
    Size size2 = size1;
    searchBar2.Size = size2;
    this.txtReader.Alighment = HorizontalAlignment.Right;
    this.txtReader.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtReader.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtReader.Button = inputButtonSettings1;
    this.txtReader.ButtonDropDownEnable = true;
    this.txtReader.ControlType = Enum_ControlType.TextBox;
    this.txtReader.DefaultLanguge = Enum_Languge.Persian;
    this.txtReader.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtReader.InputValidation = Enum_InputValidation.Persian;
    this.txtReader.Key = "";
    this.txtReader.LabelForeColor = SystemColors.ControlText;
    this.txtReader.LabelText = "نام كنترخوان";
    InputBox txtReader1 = this.txtReader;
    point1 = new Point(233, 62);
    Point point3 = point1;
    txtReader1.Location = point3;
    this.txtReader.MaxLenght = (int) short.MaxValue;
    this.txtReader.MinLenght = 0;
    this.txtReader.Multiline = false;
    this.txtReader.Name = "txtReader";
    this.txtReader.RangeDown = "";
    this.txtReader.RangeUp = "";
    this.txtReader.RequiredField = false;
    InputBox txtReader2 = this.txtReader;
    size1 = new Size(303, 24);
    Size size3 = size1;
    txtReader2.Size = size3;
    this.txtReader.TabIndex = 1;
    this.txtReader.ToolTipText = "لطفا نام شخصي را كه كنترها را خوانده است در اين قسمت وارد نمائيد";
    this.txtReader.UseSystemPasswordChar = false;
    this.txtReader.WatermarkText = "";
    this.txtReader.WriteType = Enum_WriteType.Defualt;
    this.txtNumber.Alighment = HorizontalAlignment.Left;
    this.txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtNumber.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtNumber.Button = inputButtonSettings2;
    this.txtNumber.ButtonDropDownEnable = true;
    this.txtNumber.ControlType = Enum_ControlType.TextBox;
    this.txtNumber.DefaultLanguge = Enum_Languge.English;
    this.txtNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtNumber.InputValidation = Enum_InputValidation.Integer;
    this.txtNumber.Key = "";
    this.txtNumber.LabelForeColor = SystemColors.ControlText;
    this.txtNumber.LabelText = "شماره دوره";
    InputBox txtNumber1 = this.txtNumber;
    point1 = new Point(404, 32 /*0x20*/);
    Point point4 = point1;
    txtNumber1.Location = point4;
    this.txtNumber.MaxLenght = (int) short.MaxValue;
    this.txtNumber.MinLenght = 0;
    this.txtNumber.Multiline = false;
    this.txtNumber.Name = "txtNumber";
    this.txtNumber.RangeDown = "";
    this.txtNumber.RangeUp = "";
    this.txtNumber.RequiredField = false;
    InputBox txtNumber2 = this.txtNumber;
    size1 = new Size(126, 24);
    Size size4 = size1;
    txtNumber2.Size = size4;
    this.txtNumber.TabIndex = 0;
    this.txtNumber.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtNumber.UseSystemPasswordChar = false;
    this.txtNumber.WatermarkText = "";
    this.txtNumber.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(542, 383);
    this.ClientSize = size1;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmPeriodUseMain);
    this.Text = "دوره هاي كنترخواني";
    this.SearchBar.ResumeLayout(false);
    this.DataTable.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual InputBox txtReader
  {
    [DebuggerNonUserCode] get => this._txtReader;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtReader = value;
    }
  }

  internal virtual InputBox txtNumber
  {
    [DebuggerNonUserCode] get => this._txtNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNumber = value;
    }
  }

  protected override void New()
  {
    base.New();
    frmPeriodUseData TargetForm = new frmPeriodUseData();
    if (!this.CheckOpenform((cfrmData) TargetForm))
    {
      TargetForm.Dispose();
    }
    else
    {
      TargetForm.Text = "اضافه كردن دوره جديد";
      TargetForm.buttAdd.Visible = true;
      TargetForm.FormType = Enum_ToolbarButtons.New;
      TargetForm.FormParent = (cfrmMain) this;
      TargetForm.Show();
    }
  }

  protected override void View()
  {
    base.View();
    frmPeriodUseData frmPeriodUseData = new frmPeriodUseData();
    if (!this.CheckOpenform((cfrmData) frmPeriodUseData))
    {
      frmPeriodUseData.Dispose();
    }
    else
    {
      frmPeriodUseData.Text = "بازبيني اطلاعات دوره ها";
      frmPeriodUseData.buttNext.Visible = true;
      frmPeriodUseData.buttPreview.Visible = true;
      frmPeriodUseData.FormType = Enum_ToolbarButtons.View;
      frmPeriodUseData.FormParent = (cfrmMain) this;
      if (!this.LoadRecord((cfrmData) frmPeriodUseData))
        frmPeriodUseData.Dispose();
      else
        frmPeriodUseData.Show();
    }
  }

  protected override void Edit()
  {
    base.Edit();
    frmPeriodUseData frmPeriodUseData = new frmPeriodUseData();
    if (!this.CheckOpenform((cfrmData) frmPeriodUseData))
    {
      frmPeriodUseData.Dispose();
    }
    else
    {
      cPeriodUse cPeriodUse = new cPeriodUse();
      cPeriodUse.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells[0].Value);
      if (cPeriodUse.CheckForLock())
      {
        frmPeriodUseData.Text = "ويرايش اطلاعات دوره ها";
        frmPeriodUseData.buttAdd.Visible = true;
        frmPeriodUseData.FormType = Enum_ToolbarButtons.Edit;
        frmPeriodUseData.FormParent = (cfrmMain) this;
        if (!this.LoadRecord((cfrmData) frmPeriodUseData))
          frmPeriodUseData.Dispose();
        else
          frmPeriodUseData.Show();
      }
      else
      {
        int num = (int) MessageBoxMPS.show((Form) this, cPeriodUse.ErrorMessage, Enum_MsgboxTitle.Permission, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
        this.buttEdit.Enabled = true;
      }
    }
  }

  protected override bool Delete()
  {
    if (!base.Delete())
    {
      this.buttDelete.Enabled = true;
      return false;
    }
    string str1 = "";
    Collection collection = new Collection();
    int num1 = checked (this.DataGridMain.SelectedRows.Count - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      cPeriodUse cPeriodUse = new cPeriodUse();
      cPeriodUse.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[index1].Cells[0].Value);
      string str2 = Conversions.ToString(cPeriodUse.Identity);
      if (!cPeriodUse.delete())
        str1 = $"{str1}\r\nسند شماره {Conversions.ToString(cPeriodUse.Identity)} : {cPeriodUse.ErrorDescription}";
      else
        collection.Add((object) str2, (string) null, (object) null, (object) null);
      checked { ++index1; }
    }
    int count = collection.Count;
    int Index = 1;
    while (Index <= count)
    {
      int num2 = checked (this.DataTable.Rows.Count - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataTable.Rows[index2][0], collection[Index], false))
        {
          this.DataTable.Rows[index2].Delete();
          break;
        }
        checked { ++index2; }
      }
      checked { ++Index; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "", false) != 0)
    {
      int num3 = (int) MessageBoxMPS.show((Form) this, "بعضي از اسناد انتخابي به دلايلي حذف نشد", Enum_MsgboxTitle.Alarm, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, str1);
    }
    this.buttDelete.Enabled = true;
    return true;
  }

  protected override void Refreshes()
  {
    base.Refreshes();
    cPeriodUse cPeriodUse = new cPeriodUse();
    cPeriodUse.Number = this.txtNumber.Text;
    cPeriodUse.Reader = this.txtReader.Text;
    if (!cPeriodUse.Load())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cPeriodUse.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cPeriodUse.ErrorDescription);
    }
    else
    {
      this.DataTable = cPeriodUse.ResaultTable;
      this.DataGridMain.DataSource = (object) this.DataTable;
    }
  }

  public override bool LoadRecord(cfrmData frmData)
  {
    frmPeriodUseData frmPeriodUseData = (frmPeriodUseData) frmData;
    cPeriodUse cPeriodUse = new cPeriodUse();
    cPeriodUse.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells[0].Value);
    if (!cPeriodUse.LoadRecord())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cPeriodUse.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cPeriodUse.ErrorDescription);
      return false;
    }
    if (cPeriodUse.ResaultTable.Rows.Count == 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "اطلاعاتي يافت نشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      return false;
    }
    DataTable resaultTable = cPeriodUse.ResaultTable;
    frmPeriodUseData.FormValue = Conversions.ToInteger(resaultTable.Rows[0]["fldPeriodUseId"]);
    frmPeriodUseData.txtNumber.Text = Conversions.ToString(resaultTable.Rows[0]["fldPrivateId"]);
    frmPeriodUseData.txtStartDate.Text = Conversions.ToString(resaultTable.Rows[0]["fldStartDate"]);
    frmPeriodUseData.txtEndDate.Text = Conversions.ToString(resaultTable.Rows[0]["fldEndDate"]);
    frmPeriodUseData.lblPeriod.Text = Conversions.ToString(resaultTable.Rows[0]["fldPeriod"]);
    frmPeriodUseData.txtReader.Text = Conversions.ToString(resaultTable.Rows[0]["fldReader"]);
    return true;
  }

  protected override void MakeDatagridColumn()
  {
    base.MakeDatagridColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn2 = viewTextBoxColumn1;
    viewTextBoxColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn2.HeaderText = "";
    viewTextBoxColumn2.Name = "fldPeriodUseId";
    viewTextBoxColumn2.Visible = false;
    viewTextBoxColumn2.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
    DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn4 = viewTextBoxColumn3;
    viewTextBoxColumn4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn4.HeaderText = "شماره دوره";
    viewTextBoxColumn4.Name = "fldPrivateId";
    viewTextBoxColumn4.Width = 80 /*0x50*/;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
    DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn6 = viewTextBoxColumn5;
    viewTextBoxColumn6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn6.HeaderText = "تاريخ شروع دوره";
    viewTextBoxColumn6.Name = "fldStartDate";
    viewTextBoxColumn6.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn5);
    DataGridViewTextBoxColumn viewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn8 = viewTextBoxColumn7;
    viewTextBoxColumn8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn8.HeaderText = "تاريخ پايان دوره";
    viewTextBoxColumn8.Name = "fldEndDate";
    viewTextBoxColumn8.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn7);
    DataGridViewTextBoxColumn viewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn10 = viewTextBoxColumn9;
    viewTextBoxColumn10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn10.HeaderText = "طول دوره";
    viewTextBoxColumn10.Name = "fldPeriod";
    viewTextBoxColumn10.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn9);
    DataGridViewTextBoxColumn viewTextBoxColumn11 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn12 = viewTextBoxColumn11;
    viewTextBoxColumn12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn12.HeaderText = "نام كنترخوان";
    viewTextBoxColumn12.Name = "fldReader";
    viewTextBoxColumn12.Width = 200;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn11);
    try
    {
      foreach (DataGridViewColumn column in (BaseCollection) this.DataGridMain.Columns)
      {
        column.ReadOnly = true;
        column.DataPropertyName = column.Name;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    viewTextBoxColumn1.Name = "Id";
  }

  protected override void SetDatagridSetting()
  {
    base.SetDatagridSetting();
    this.txtNumber.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtReader.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
  }
}
