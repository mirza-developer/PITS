// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmHomeMain
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
public class frmHomeMain : cfrmMain
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtBlock")]
  private InputBox _txtBlock;
  [AccessedThroughProperty("txtNumber")]
  private InputBox _txtNumber;
  [AccessedThroughProperty("txtRent")]
  private InputBox _txtRent;
  [AccessedThroughProperty("txtName")]
  private InputBox _txtName;
  [AccessedThroughProperty("txtName1")]
  private InputBox _txtName1;

  [DebuggerNonUserCode]
  static frmHomeMain()
  {
  }

  [DebuggerNonUserCode]
  public frmHomeMain()
  {
    frmHomeMain.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmHomeMain.__ENCList)
    {
      if (frmHomeMain.__ENCList.Count == frmHomeMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmHomeMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmHomeMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmHomeMain.__ENCList[index1] = frmHomeMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmHomeMain.__ENCList.RemoveRange(index1, checked (frmHomeMain.__ENCList.Count - index1));
        frmHomeMain.__ENCList.Capacity = frmHomeMain.__ENCList.Count;
      }
      frmHomeMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    InputButtonSettings inputButtonSettings3 = new InputButtonSettings();
    InputButtonSettings inputButtonSettings4 = new InputButtonSettings();
    InputButtonSettings inputButtonSettings5 = new InputButtonSettings();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmHomeMain));
    this.txtBlock = new InputBox();
    this.txtNumber = new InputBox();
    this.txtRent = new InputBox();
    this.txtName = new InputBox();
    this.txtName1 = new InputBox();
    this.SearchBar.SuspendLayout();
    this.DataTable.BeginInit();
    this.SuspendLayout();
    this.SearchBar.Controls.Add((Control) this.txtName1);
    this.SearchBar.Controls.Add((Control) this.txtRent);
    this.SearchBar.Controls.Add((Control) this.txtName);
    this.SearchBar.Controls.Add((Control) this.txtBlock);
    this.SearchBar.Controls.Add((Control) this.txtNumber);
    GroupBox searchBar1 = this.SearchBar;
    Point point1 = new Point(0, 416);
    Point point2 = point1;
    searchBar1.Location = point2;
    GroupBox searchBar2 = this.SearchBar;
    Size size1 = new Size(668, 112 /*0x70*/);
    Size size2 = size1;
    searchBar2.Size = size2;
    this.txtBlock.Alighment = HorizontalAlignment.Left;
    this.txtBlock.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtBlock.Button = inputButtonSettings1;
    this.txtBlock.ButtonDropDownEnable = true;
    this.txtBlock.ControlType = Enum_ControlType.TextBox;
    this.txtBlock.DefaultLanguge = Enum_Languge.English;
    this.txtBlock.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtBlock.InputValidation = Enum_InputValidation.Integer;
    this.txtBlock.Key = "";
    this.txtBlock.LabelForeColor = SystemColors.ControlText;
    this.txtBlock.LabelText = "بلوك";
    InputBox txtBlock1 = this.txtBlock;
    point1 = new Point(463, 62);
    Point point3 = point1;
    txtBlock1.Location = point3;
    this.txtBlock.MaxLenght = 2;
    this.txtBlock.MinLenght = 1;
    this.txtBlock.Multiline = false;
    this.txtBlock.Name = "txtBlock";
    this.txtBlock.RangeDown = "0";
    this.txtBlock.RangeUp = "99";
    this.txtBlock.RequiredField = false;
    InputBox txtBlock2 = this.txtBlock;
    size1 = new Size(97, 24);
    Size size3 = size1;
    txtBlock2.Size = size3;
    this.txtBlock.TabIndex = 2;
    this.txtBlock.ToolTipText = "شماره بلوك را در اين قسمت وارد نمائيد";
    this.txtBlock.UseSystemPasswordChar = false;
    this.txtBlock.WatermarkText = "";
    this.txtBlock.WriteType = Enum_WriteType.Defualt;
    this.txtNumber.Alighment = HorizontalAlignment.Left;
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
    this.txtNumber.LabelText = "پلاك";
    InputBox txtNumber1 = this.txtNumber;
    point1 = new Point(463, 32 /*0x20*/);
    Point point4 = point1;
    txtNumber1.Location = point4;
    this.txtNumber.MaxLenght = 3;
    this.txtNumber.MinLenght = 1;
    this.txtNumber.Multiline = false;
    this.txtNumber.Name = "txtNumber";
    this.txtNumber.RangeDown = "1";
    this.txtNumber.RangeUp = "999";
    this.txtNumber.RequiredField = false;
    InputBox txtNumber2 = this.txtNumber;
    size1 = new Size(96 /*0x60*/, 24);
    Size size4 = size1;
    txtNumber2.Size = size4;
    this.txtNumber.TabIndex = 1;
    this.txtNumber.ToolTipText = "پلاك واحد را در اين قسمت وارد نمائيد";
    this.txtNumber.UseSystemPasswordChar = false;
    this.txtNumber.WatermarkText = "";
    this.txtNumber.WriteType = Enum_WriteType.Defualt;
    this.txtRent.Alighment = HorizontalAlignment.Left;
    this.txtRent.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtRent.Button = inputButtonSettings3;
    this.txtRent.ButtonDropDownEnable = true;
    this.txtRent.ControlType = Enum_ControlType.ComboBox;
    this.txtRent.DefaultLanguge = Enum_Languge.English;
    this.txtRent.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtRent.InputValidation = Enum_InputValidation.All;
    this.txtRent.Key = "";
    this.txtRent.LabelForeColor = SystemColors.ControlText;
    this.txtRent.LabelText = "نوع سكونت";
    InputBox txtRent1 = this.txtRent;
    point1 = new Point(22, 32 /*0x20*/);
    Point point5 = point1;
    txtRent1.Location = point5;
    this.txtRent.MaxLenght = 0;
    this.txtRent.MinLenght = 0;
    this.txtRent.Multiline = false;
    this.txtRent.Name = "txtRent";
    this.txtRent.RangeDown = "";
    this.txtRent.RangeUp = "";
    this.txtRent.RequiredField = false;
    InputBox txtRent2 = this.txtRent;
    size1 = new Size(206, 24);
    Size size5 = size1;
    txtRent2.Size = size5;
    this.txtRent.TabIndex = 5;
    this.txtRent.ToolTipText = "نوع سكونت را از ليست انتخاب كنيد";
    this.txtRent.UseSystemPasswordChar = false;
    this.txtRent.WatermarkText = "";
    this.txtRent.WriteType = Enum_WriteType.SelectOnly;
    this.txtName.Alighment = HorizontalAlignment.Left;
    this.txtName.BackColor = Color.Transparent;
    inputButtonSettings4.DisplayPosition = 1;
    inputButtonSettings4.Enabled = false;
    this.txtName.Button = inputButtonSettings4;
    this.txtName.ButtonDropDownEnable = true;
    this.txtName.ControlType = Enum_ControlType.TextBox;
    this.txtName.DefaultLanguge = Enum_Languge.Persian;
    this.txtName.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtName.InputValidation = Enum_InputValidation.All;
    this.txtName.Key = "";
    this.txtName.LabelForeColor = SystemColors.ControlText;
    this.txtName.LabelText = "نام ساكن";
    InputBox txtName1 = this.txtName;
    point1 = new Point(234, 32 /*0x20*/);
    Point point6 = point1;
    txtName1.Location = point6;
    this.txtName.MaxLenght = 50;
    this.txtName.MinLenght = 1;
    this.txtName.Multiline = false;
    this.txtName.Name = "txtName";
    this.txtName.RangeDown = "";
    this.txtName.RangeUp = "";
    this.txtName.RequiredField = false;
    InputBox txtName2 = this.txtName;
    size1 = new Size(196, 24);
    Size size6 = size1;
    txtName2.Size = size6;
    this.txtName.TabIndex = 3;
    this.txtName.ToolTipText = "نام ساكن فعلي منزل را در اين قسمت وارد نمائيد";
    this.txtName.UseSystemPasswordChar = false;
    this.txtName.WatermarkText = "";
    this.txtName.WriteType = Enum_WriteType.Defualt;
    this.txtName1.Alighment = HorizontalAlignment.Left;
    this.txtName1.BackColor = Color.Transparent;
    inputButtonSettings5.DisplayPosition = 1;
    inputButtonSettings5.Enabled = false;
    this.txtName1.Button = inputButtonSettings5;
    this.txtName1.ButtonDropDownEnable = true;
    this.txtName1.ControlType = Enum_ControlType.TextBox;
    this.txtName1.DefaultLanguge = Enum_Languge.Persian;
    this.txtName1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtName1.InputValidation = Enum_InputValidation.All;
    this.txtName1.Key = "";
    this.txtName1.LabelForeColor = SystemColors.ControlText;
    this.txtName1.LabelText = "نام مالك";
    InputBox txtName1_1 = this.txtName1;
    point1 = new Point(234, 62);
    Point point7 = point1;
    txtName1_1.Location = point7;
    this.txtName1.MaxLenght = 50;
    this.txtName1.MinLenght = 1;
    this.txtName1.Multiline = false;
    this.txtName1.Name = "txtName1";
    this.txtName1.RangeDown = "";
    this.txtName1.RangeUp = "";
    this.txtName1.RequiredField = false;
    InputBox txtName1_2 = this.txtName1;
    size1 = new Size(190, 24);
    Size size7 = size1;
    txtName1_2.Size = size7;
    this.txtName1.TabIndex = 4;
    this.txtName1.ToolTipText = "نام ساكن فعلي منزل را در اين قسمت وارد نمائيد";
    this.txtName1.UseSystemPasswordChar = false;
    this.txtName1.WatermarkText = "";
    this.txtName1.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(668, 550);
    this.ClientSize = size1;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmHomeMain);
    this.SearchBar.ResumeLayout(false);
    this.DataTable.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual InputBox txtBlock
  {
    [DebuggerNonUserCode] get => this._txtBlock;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtBlock = value;
  }

  internal virtual InputBox txtNumber
  {
    [DebuggerNonUserCode] get => this._txtNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNumber = value;
    }
  }

  internal virtual InputBox txtRent
  {
    [DebuggerNonUserCode] get => this._txtRent;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRent = value;
  }

  internal virtual InputBox txtName
  {
    [DebuggerNonUserCode] get => this._txtName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName = value;
  }

  internal virtual InputBox txtName1
  {
    [DebuggerNonUserCode] get => this._txtName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName1 = value;
  }

  protected override void New()
  {
    base.New();
    frmHomeData TargetForm = new frmHomeData();
    if (!this.CheckOpenform((cfrmData) TargetForm))
    {
      TargetForm.Dispose();
    }
    else
    {
      TargetForm.Text = "اضافه كردن واحد جديد";
      TargetForm.buttAdd.Visible = true;
      TargetForm.FormType = Enum_ToolbarButtons.New;
      TargetForm.FormParent = (cfrmMain) this;
      this.LoadtxtRent(TargetForm.txtRent);
      TargetForm.Show();
    }
  }

  protected override void View()
  {
    base.View();
    frmHomeData frmHomeData = new frmHomeData();
    if (!this.CheckOpenform((cfrmData) frmHomeData))
    {
      frmHomeData.Dispose();
    }
    else
    {
      frmHomeData.Text = "بازبيني اطلاعات واحد";
      frmHomeData.buttNext.Visible = true;
      frmHomeData.buttPreview.Visible = true;
      frmHomeData.FormType = Enum_ToolbarButtons.View;
      frmHomeData.FormParent = (cfrmMain) this;
      this.LoadtxtRent(frmHomeData.txtRent);
      if (!this.LoadRecord((cfrmData) frmHomeData))
        frmHomeData.Dispose();
      else
        frmHomeData.Show();
    }
  }

  protected override void Edit()
  {
    base.Edit();
    frmHomeData frmHomeData = new frmHomeData();
    if (!this.CheckOpenform((cfrmData) frmHomeData))
    {
      frmHomeData.Dispose();
    }
    else
    {
      frmHomeData.Text = "ويرايش اطلاعات واحدها";
      frmHomeData.buttAdd.Visible = true;
      frmHomeData.FormType = Enum_ToolbarButtons.Edit;
      frmHomeData.FormParent = (cfrmMain) this;
      this.LoadtxtRent(frmHomeData.txtRent);
      if (!this.LoadRecord((cfrmData) frmHomeData))
        frmHomeData.Dispose();
      else
        frmHomeData.Show();
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
      cHome cHome = new cHome();
      cHome.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[index1].Cells[0].Value);
      string str2 = Conversions.ToString(cHome.Identity);
      if (!cHome.delete())
        str1 = $"{str1}\r\nسند شماره {Conversions.ToString(cHome.Identity)} : {cHome.ErrorDescription}";
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
    cHome cHome = new cHome();
    cHome.Number = this.txtNumber.Text;
    cHome.Block = this.txtBlock.Text;
    cHome.Name = this.txtName.Text;
    cHome.Name1 = this.txtName1.Text;
    cHome.Rent = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtRent.Text, "مالك", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtRent.Text, "استيجاري", false) != 0 ? "" : "1") : "0";
    if (!cHome.Load())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cHome.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cHome.ErrorDescription);
    }
    else
    {
      this.DataTable = cHome.ResaultTable;
      this.DataGridMain.DataSource = (object) this.DataTable;
    }
  }

  public override bool LoadRecord(cfrmData frmData)
  {
    frmHomeData frmHomeData = (frmHomeData) frmData;
    cHome cHome = new cHome();
    cHome.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells[0].Value);
    if (!cHome.LoadRecord())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cHome.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cHome.ErrorDescription);
      return false;
    }
    if (cHome.ResaultTable.Rows.Count == 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "اطلاعاتي يافت نشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      return false;
    }
    DataTable resaultTable = cHome.ResaultTable;
    frmHomeData.FormValue = Conversions.ToInteger(resaultTable.Rows[0]["fldHomeId"]);
    frmHomeData.txtNumber.Text = Conversions.ToString(resaultTable.Rows[0]["fldNumber"]);
    frmHomeData.txtBlock.Text = Conversions.ToString(resaultTable.Rows[0]["fldBlockNumber"]);
    frmHomeData.txtTel.Text = Conversions.ToString(resaultTable.Rows[0]["fldTel"]);
    frmHomeData.txtName.Text = Conversions.ToString(resaultTable.Rows[0]["fldName"]);
    frmHomeData.txtMobile.Text = Conversions.ToString(resaultTable.Rows[0]["fldMobile"]);
    frmHomeData.txtRent.Text = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(resaultTable.Rows[0]["fldRent"], (object) "0", false) ? "استيجاري" : "مالك";
    frmHomeData.txtRent.Key = Conversions.ToString(resaultTable.Rows[0]["fldRent"]);
    frmHomeData.txtName1.Text = Information.IsDBNull(RuntimeHelpers.GetObjectValue(resaultTable.Rows[0]["fldName1"])) ? "" : Conversions.ToString(resaultTable.Rows[0]["fldName1"]);
    frmHomeData.txtMobile1.Text = Information.IsDBNull(RuntimeHelpers.GetObjectValue(resaultTable.Rows[0]["fldMobile1"])) ? "" : Conversions.ToString(resaultTable.Rows[0]["fldMobile1"]);
    return true;
  }

  protected override void MakeDatagridColumn()
  {
    base.MakeDatagridColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn2 = viewTextBoxColumn1;
    viewTextBoxColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn2.HeaderText = "";
    viewTextBoxColumn2.Name = "fldHomeId";
    viewTextBoxColumn2.Visible = false;
    viewTextBoxColumn2.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
    DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn4 = viewTextBoxColumn3;
    viewTextBoxColumn4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn4.HeaderText = "شماره واحد";
    viewTextBoxColumn4.Name = "fldNumber";
    viewTextBoxColumn4.Width = 90;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
    DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn6 = viewTextBoxColumn5;
    viewTextBoxColumn6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn6.HeaderText = "شماره بلوك";
    viewTextBoxColumn6.Name = "fldBlockNumber";
    viewTextBoxColumn6.Width = 90;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn5);
    DataGridViewTextBoxColumn viewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn8 = viewTextBoxColumn7;
    viewTextBoxColumn8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn8.HeaderText = "تلفن";
    viewTextBoxColumn8.Name = "fldTel";
    viewTextBoxColumn8.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn7);
    DataGridViewTextBoxColumn viewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn10 = viewTextBoxColumn9;
    viewTextBoxColumn10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn10.HeaderText = "نام ساكن";
    viewTextBoxColumn10.Name = "fldName";
    viewTextBoxColumn10.Width = 200;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn9);
    DataGridViewTextBoxColumn viewTextBoxColumn11 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn12 = viewTextBoxColumn11;
    viewTextBoxColumn12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn12.HeaderText = "موبايل ساكن";
    viewTextBoxColumn12.Name = "fldMobile";
    viewTextBoxColumn12.Width = 110;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn11);
    DataGridViewCheckBoxColumn viewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
    DataGridViewCheckBoxColumn viewCheckBoxColumn2 = viewCheckBoxColumn1;
    viewCheckBoxColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewCheckBoxColumn2.HeaderText = "استيجاري";
    viewCheckBoxColumn2.Name = "fldRent";
    viewCheckBoxColumn2.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewCheckBoxColumn1);
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
    this.txtBlock.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtName.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtName1.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtRent.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.LoadtxtRent(this.txtRent);
  }

  private void LoadtxtRent(InputBox txt)
  {
    txt.AddItem("مالك", "0");
    txt.AddItem("استيجاري", "1");
  }
}
