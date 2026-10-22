// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmBillMain
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
public class frmBillMain : cfrmMain
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtPrivateId")]
  private InputBox _txtPrivateId;

  [DebuggerNonUserCode]
  static frmBillMain()
  {
  }

  [DebuggerNonUserCode]
  public frmBillMain()
  {
    frmBillMain.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBillMain.__ENCList)
    {
      if (frmBillMain.__ENCList.Count == frmBillMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBillMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBillMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBillMain.__ENCList[index1] = frmBillMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBillMain.__ENCList.RemoveRange(index1, checked (frmBillMain.__ENCList.Count - index1));
        frmBillMain.__ENCList.Capacity = frmBillMain.__ENCList.Count;
      }
      frmBillMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBillMain));
    this.txtPrivateId = new InputBox();
    this.SearchBar.SuspendLayout();
    this.DataTable.BeginInit();
    this.SuspendLayout();
    this.SearchBar.Controls.Add((Control) this.txtPrivateId);
    GroupBox searchBar1 = this.SearchBar;
    Point point1 = new Point(0, 368);
    Point point2 = point1;
    searchBar1.Location = point2;
    GroupBox searchBar2 = this.SearchBar;
    Size size1 = new Size(453, 112 /*0x70*/);
    Size size2 = size1;
    searchBar2.Size = size2;
    this.txtPrivateId.Alighment = HorizontalAlignment.Left;
    this.txtPrivateId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPrivateId.BackColor = Color.Transparent;
    inputButtonSettings.DisplayPosition = 1;
    inputButtonSettings.Enabled = false;
    this.txtPrivateId.Button = inputButtonSettings;
    this.txtPrivateId.ButtonDropDownEnable = true;
    this.txtPrivateId.ControlType = Enum_ControlType.TextBox;
    this.txtPrivateId.DefaultLanguge = Enum_Languge.English;
    this.txtPrivateId.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPrivateId.InputValidation = Enum_InputValidation.Integer;
    this.txtPrivateId.Key = "";
    this.txtPrivateId.LabelForeColor = SystemColors.ControlText;
    this.txtPrivateId.LabelText = "دوره قرائت";
    InputBox txtPrivateId1 = this.txtPrivateId;
    point1 = new Point(303, 39);
    Point point3 = point1;
    txtPrivateId1.Location = point3;
    this.txtPrivateId.MaxLenght = 5;
    this.txtPrivateId.MinLenght = 0;
    this.txtPrivateId.Multiline = false;
    this.txtPrivateId.Name = "txtPrivateId";
    this.txtPrivateId.RangeDown = "";
    this.txtPrivateId.RangeUp = "";
    this.txtPrivateId.RequiredField = false;
    InputBox txtPrivateId2 = this.txtPrivateId;
    size1 = new Size(129, 24);
    Size size3 = size1;
    txtPrivateId2.Size = size3;
    this.txtPrivateId.TabIndex = 9;
    this.txtPrivateId.ToolTipText = "لطفا عدد قرائت دوره قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtPrivateId.UseSystemPasswordChar = false;
    this.txtPrivateId.WatermarkText = "";
    this.txtPrivateId.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(453, 502);
    this.ClientSize = size1;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmBillMain);
    this.Text = "قبوض سازمان آب";
    this.SearchBar.ResumeLayout(false);
    this.DataTable.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual InputBox txtPrivateId
  {
    [DebuggerNonUserCode] get => this._txtPrivateId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrivateId = value;
    }
  }

  protected override void New()
  {
    base.New();
    frmBillData TargetForm = new frmBillData();
    if (!this.CheckOpenform((cfrmData) TargetForm))
    {
      TargetForm.Dispose();
    }
    else
    {
      TargetForm.Text = "اضافه كردن قبض جديد";
      TargetForm.buttAdd.Visible = true;
      TargetForm.buttAdd.Enabled = false;
      TargetForm.FormType = Enum_ToolbarButtons.New;
      TargetForm.FormParent = (cfrmMain) this;
      TargetForm.Show();
    }
  }

  protected override void View()
  {
    base.View();
    frmBillData frmBillData = new frmBillData();
    if (!this.CheckOpenform((cfrmData) frmBillData))
    {
      frmBillData.Dispose();
    }
    else
    {
      frmBillData.Text = "بازبيني قبوض";
      frmBillData.buttNext.Visible = true;
      frmBillData.buttPreview.Visible = true;
      frmBillData.FormType = Enum_ToolbarButtons.View;
      frmBillData.FormParent = (cfrmMain) this;
      if (!this.LoadRecord((cfrmData) frmBillData))
        frmBillData.Dispose();
      else
        frmBillData.Show();
    }
  }

  protected override void Edit()
  {
    base.Edit();
    frmBillData frmBillData = new frmBillData();
    if (!this.CheckOpenform((cfrmData) frmBillData))
    {
      frmBillData.Dispose();
    }
    else
    {
      cBill cBill = new cBill();
      cBill.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells["Id"].Value);
      if (cBill.CheckForLock())
      {
        frmBillData.Text = "ويرايش  قبوض";
        frmBillData.buttAdd.Visible = true;
        frmBillData.FormType = Enum_ToolbarButtons.Edit;
        frmBillData.FormParent = (cfrmMain) this;
        if (!this.LoadRecord((cfrmData) frmBillData))
          frmBillData.Dispose();
        else
          frmBillData.Show();
      }
      else
      {
        int num = (int) MessageBoxMPS.show((Form) this, cBill.ErrorMessage, Enum_MsgboxTitle.Permission, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
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
      cBill cBill = new cBill();
      cBill.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[index1].Cells["Id"].Value);
      string str2 = Conversions.ToString(cBill.Identity);
      if (!cBill.delete())
        str1 = $"{str1}\r\nسند شماره {Conversions.ToString(cBill.Identity)} : {cBill.ErrorDescription}";
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
    cBill cBill = new cBill();
    cBill.PrivateId = this.txtPrivateId.Text;
    if (!cBill.Load())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cBill.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cBill.ErrorDescription);
    }
    else
    {
      this.DataTable = cBill.ResaultTable;
      this.DataGridMain.DataSource = (object) this.DataTable;
    }
  }

  public override bool LoadRecord(cfrmData frmData)
  {
    frmBillData frmBillData = (frmBillData) frmData;
    cBill cBill = new cBill();
    cBill.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells["Id"].Value);
    if (!cBill.LoadRecord())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cBill.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cBill.ErrorDescription);
      return false;
    }
    if (cBill.ResaultTable.Rows.Count == 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "اطلاعاتي يافت نشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      return false;
    }
    DataTable resaultTable = cBill.ResaultTable;
    frmBillData.FormValue = Conversions.ToInteger(resaultTable.Rows[0]["fldBillId"]);
    frmBillData.txtPrivateId.Text = Conversions.ToString(resaultTable.Rows[0]["fldPrivateId"]);
    frmBillData.txtStartDate.Text = Conversions.ToString(resaultTable.Rows[0]["fldStartDate"]);
    frmBillData.txtEndDate.Text = Conversions.ToString(resaultTable.Rows[0]["fldEndDate"]);
    frmBillData.txtPeriod.Text = Conversions.ToString(resaultTable.Rows[0]["fldPeriod"]);
    frmBillData.txtUse.Text = Conversions.ToString(resaultTable.Rows[0]["fldUse"]);
    string[] strArray1 = resaultTable.Rows[0]["fldTax"].ToString().Split('.');
    frmBillData.txtTax.Text = strArray1[0];
    string[] strArray2 = resaultTable.Rows[0]["fldPrice"].ToString().Split('.');
    frmBillData.txtPrice.Text = strArray2[0];
    return true;
  }

  protected override void DataGridMain_CellFormatting(
    object sender,
    DataGridViewCellFormattingEventArgs e)
  {
    this.DataGridMain.Rows[e.RowIndex].Cells["fldDate"].Value = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.DataGridMain.Rows[e.RowIndex].Cells["fldStartDate"].Value, (object) "\r\n"), this.DataGridMain.Rows[e.RowIndex].Cells["fldEndDate"].Value);
    this.DataGridMain.Rows[e.RowIndex].Cells["fldPriceFormat"].Value = (object) cFormat.Currency(Conversions.ToString(this.DataGridMain.Rows[e.RowIndex].Cells["fldPrice"].Value));
  }

  protected override void MakeDatagridColumn()
  {
    base.MakeDatagridColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn2 = viewTextBoxColumn1;
    viewTextBoxColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn2.HeaderText = "";
    viewTextBoxColumn2.Name = "fldBillId";
    viewTextBoxColumn2.Visible = false;
    viewTextBoxColumn2.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
    DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn4 = viewTextBoxColumn3;
    viewTextBoxColumn4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn4.HeaderText = "دوره قرائت";
    viewTextBoxColumn4.Name = "fldPrivateId";
    viewTextBoxColumn4.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
    DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn6 = viewTextBoxColumn5;
    viewTextBoxColumn6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn6.HeaderText = "تاريخ قرائت قبلي";
    viewTextBoxColumn6.Name = "fldStartDate";
    viewTextBoxColumn6.Width = 90;
    viewTextBoxColumn6.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn5);
    DataGridViewTextBoxColumn viewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn8 = viewTextBoxColumn7;
    viewTextBoxColumn8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn8.HeaderText = "دوره تاريخ قرائت";
    viewTextBoxColumn8.Name = "fldDate";
    viewTextBoxColumn8.Width = 90;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn7);
    DataGridViewTextBoxColumn viewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn10 = viewTextBoxColumn9;
    viewTextBoxColumn10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn10.HeaderText = "تاريخ قرائت فعلي";
    viewTextBoxColumn10.Name = "fldEndDate";
    viewTextBoxColumn10.Width = 100;
    viewTextBoxColumn10.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn9);
    DataGridViewTextBoxColumn viewTextBoxColumn11 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn12 = viewTextBoxColumn11;
    viewTextBoxColumn12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn12.HeaderText = "طول دوره  (روز)";
    viewTextBoxColumn12.Name = "fldPeriod";
    viewTextBoxColumn12.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn11);
    DataGridViewTextBoxColumn viewTextBoxColumn13 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn14 = viewTextBoxColumn13;
    viewTextBoxColumn14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn14.HeaderText = "ميزان مصرف (ليتر)";
    viewTextBoxColumn14.Name = "fldUse";
    viewTextBoxColumn14.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn13);
    DataGridViewTextBoxColumn viewTextBoxColumn15 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn16 = viewTextBoxColumn15;
    viewTextBoxColumn16.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn16.HeaderText = "مبلغ (ريال)";
    viewTextBoxColumn16.Name = "fldPrice";
    viewTextBoxColumn16.Width = 120;
    viewTextBoxColumn16.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn15);
    DataGridViewTextBoxColumn viewTextBoxColumn17 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn18 = viewTextBoxColumn17;
    viewTextBoxColumn18.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn18.HeaderText = "مبلغ (ريال)";
    viewTextBoxColumn18.Name = "fldPriceFormat";
    viewTextBoxColumn18.Width = 120;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn17);
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
    this.txtPrivateId.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
  }
}
