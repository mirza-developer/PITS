// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmPeriodUseData
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using DevComponents.Editors;
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
public class frmPeriodUseData : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtNumber")]
  private InputBox _txtNumber;
  [AccessedThroughProperty("txtStartDate")]
  private InputBox _txtStartDate;
  [AccessedThroughProperty("txtReader")]
  private InputBox _txtReader;
  [AccessedThroughProperty("txtEndDate")]
  private InputBox _txtEndDate;
  [AccessedThroughProperty("lblPeriod")]
  private Label _lblPeriod;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;

  [DebuggerNonUserCode]
  static frmPeriodUseData()
  {
  }

  [DebuggerNonUserCode]
  public frmPeriodUseData()
  {
    frmPeriodUseData.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPeriodUseData.__ENCList)
    {
      if (frmPeriodUseData.__ENCList.Count == frmPeriodUseData.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPeriodUseData.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPeriodUseData.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPeriodUseData.__ENCList[index1] = frmPeriodUseData.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPeriodUseData.__ENCList.RemoveRange(index1, checked (frmPeriodUseData.__ENCList.Count - index1));
        frmPeriodUseData.__ENCList.Capacity = frmPeriodUseData.__ENCList.Count;
      }
      frmPeriodUseData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPeriodUseData));
    this.txtNumber = new InputBox();
    this.txtStartDate = new InputBox();
    this.txtReader = new InputBox();
    this.txtEndDate = new InputBox();
    this.lblPeriod = new Label();
    this.Label4 = new Label();
    this.SuspendLayout();
    this.txtNumber.Alighment = HorizontalAlignment.Left;
    this.txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtNumber.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtNumber.Button = inputButtonSettings1;
    this.txtNumber.ButtonDropDownEnable = true;
    this.txtNumber.ControlType = Enum_ControlType.TextBox;
    this.txtNumber.DefaultLanguge = Enum_Languge.English;
    this.txtNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtNumber.InputValidation = Enum_InputValidation.Integer;
    this.txtNumber.Key = "";
    this.txtNumber.LabelForeColor = SystemColors.ControlText;
    this.txtNumber.LabelText = "شماره دوره";
    InputBox txtNumber1 = this.txtNumber;
    Point point1 = new Point(193, 51);
    Point point2 = point1;
    txtNumber1.Location = point2;
    this.txtNumber.MaxLenght = (int) short.MaxValue;
    this.txtNumber.MinLenght = 0;
    this.txtNumber.Multiline = false;
    this.txtNumber.Name = "txtNumber";
    this.txtNumber.RangeDown = "";
    this.txtNumber.RangeUp = "";
    this.txtNumber.RequiredField = true;
    InputBox txtNumber2 = this.txtNumber;
    Size size1 = new Size(126, 24);
    Size size2 = size1;
    txtNumber2.Size = size2;
    this.txtNumber.TabIndex = 0;
    this.txtNumber.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtNumber.UseSystemPasswordChar = false;
    this.txtNumber.WatermarkText = "";
    this.txtNumber.WriteType = Enum_WriteType.Defualt;
    this.txtStartDate.Alighment = HorizontalAlignment.Center;
    this.txtStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtStartDate.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtStartDate.Button = inputButtonSettings2;
    this.txtStartDate.ButtonDropDownEnable = true;
    this.txtStartDate.ControlType = Enum_ControlType.DateBox;
    this.txtStartDate.DefaultLanguge = Enum_Languge.Persian;
    this.txtStartDate.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtStartDate.InputValidation = Enum_InputValidation.Date;
    this.txtStartDate.Key = "";
    this.txtStartDate.LabelForeColor = SystemColors.ControlText;
    this.txtStartDate.LabelText = "از تاريخ";
    InputBox txtStartDate1 = this.txtStartDate;
    point1 = new Point(145, 81);
    Point point3 = point1;
    txtStartDate1.Location = point3;
    this.txtStartDate.MaxLenght = 10;
    this.txtStartDate.MinLenght = 10;
    this.txtStartDate.Multiline = false;
    this.txtStartDate.Name = "txtStartDate";
    this.txtStartDate.RangeDown = "";
    this.txtStartDate.RangeUp = "";
    this.txtStartDate.RequiredField = true;
    InputBox txtStartDate2 = this.txtStartDate;
    size1 = new Size(152, 25);
    Size size3 = size1;
    txtStartDate2.Size = size3;
    this.txtStartDate.TabIndex = 1;
    this.txtStartDate.ToolTipText = "لطفا تاريخ شروع دوره را در اين قسمت وارد نمائيد";
    this.txtStartDate.UseSystemPasswordChar = false;
    this.txtStartDate.WatermarkText = "";
    this.txtStartDate.WriteType = Enum_WriteType.Defualt;
    this.txtReader.Alighment = HorizontalAlignment.Left;
    this.txtReader.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtReader.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtReader.Button = inputButtonSettings3;
    this.txtReader.ButtonDropDownEnable = true;
    this.txtReader.ControlType = Enum_ControlType.TextBox;
    this.txtReader.DefaultLanguge = Enum_Languge.Persian;
    this.txtReader.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtReader.InputValidation = Enum_InputValidation.All;
    this.txtReader.Key = "";
    this.txtReader.LabelForeColor = SystemColors.ControlText;
    this.txtReader.LabelText = "نام كنترخوان";
    InputBox txtReader1 = this.txtReader;
    point1 = new Point(16 /*0x10*/, 167);
    Point point4 = point1;
    txtReader1.Location = point4;
    this.txtReader.MaxLenght = (int) short.MaxValue;
    this.txtReader.MinLenght = 0;
    this.txtReader.Multiline = false;
    this.txtReader.Name = "txtReader";
    this.txtReader.RangeDown = "";
    this.txtReader.RangeUp = "";
    this.txtReader.RequiredField = false;
    InputBox txtReader2 = this.txtReader;
    size1 = new Size(303, 24);
    Size size4 = size1;
    txtReader2.Size = size4;
    this.txtReader.TabIndex = 3;
    this.txtReader.ToolTipText = "لطفا نام شخصي را كه كنترها را خوانده است در اين قسمت وارد نمائيد";
    this.txtReader.UseSystemPasswordChar = false;
    this.txtReader.WatermarkText = "";
    this.txtReader.WriteType = Enum_WriteType.Defualt;
    this.txtEndDate.Alighment = HorizontalAlignment.Center;
    this.txtEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtEndDate.BackColor = Color.Transparent;
    inputButtonSettings4.DisplayPosition = 1;
    inputButtonSettings4.Enabled = false;
    this.txtEndDate.Button = inputButtonSettings4;
    this.txtEndDate.ButtonDropDownEnable = true;
    this.txtEndDate.ControlType = Enum_ControlType.DateBox;
    this.txtEndDate.DefaultLanguge = Enum_Languge.Persian;
    this.txtEndDate.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtEndDate.InputValidation = Enum_InputValidation.Date;
    this.txtEndDate.Key = "";
    this.txtEndDate.LabelForeColor = SystemColors.ControlText;
    this.txtEndDate.LabelText = "تا تاريخ";
    InputBox txtEndDate1 = this.txtEndDate;
    point1 = new Point(145, 110);
    Point point5 = point1;
    txtEndDate1.Location = point5;
    this.txtEndDate.MaxLenght = 10;
    this.txtEndDate.MinLenght = 10;
    this.txtEndDate.Multiline = false;
    this.txtEndDate.Name = "txtEndDate";
    this.txtEndDate.RangeDown = "";
    this.txtEndDate.RangeUp = "";
    this.txtEndDate.RequiredField = true;
    InputBox txtEndDate2 = this.txtEndDate;
    size1 = new Size(151, 25);
    Size size5 = size1;
    txtEndDate2.Size = size5;
    this.txtEndDate.TabIndex = 2;
    this.txtEndDate.ToolTipText = "لطفا تاريخ پايان دوره را در اين قسمت وارد نمائيد";
    this.txtEndDate.UseSystemPasswordChar = false;
    this.txtEndDate.WatermarkText = "";
    this.txtEndDate.WriteType = Enum_WriteType.Defualt;
    this.lblPeriod.ForeColor = Color.Black;
    Label lblPeriod1 = this.lblPeriod;
    point1 = new Point(106, 144 /*0x90*/);
    Point point6 = point1;
    lblPeriod1.Location = point6;
    this.lblPeriod.Name = "lblPeriod";
    Label lblPeriod2 = this.lblPeriod;
    size1 = new Size(125, 13);
    Size size6 = size1;
    lblPeriod2.Size = size6;
    this.lblPeriod.TabIndex = 17;
    this.Label4.AutoSize = true;
    this.Label4.ForeColor = Color.Black;
    Label label4_1 = this.Label4;
    point1 = new Point(237, 144 /*0x90*/);
    Point point7 = point1;
    label4_1.Location = point7;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(72, 13);
    Size size7 = size1;
    label4_2.Size = size7;
    this.Label4.TabIndex = 16 /*0x10*/;
    this.Label4.Text = "طول دوره (روز)";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(347, 265);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtNumber);
    this.Controls.Add((Control) this.txtStartDate);
    this.Controls.Add((Control) this.txtEndDate);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblPeriod);
    this.Controls.Add((Control) this.txtReader);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmPeriodUseData);
    this.Text = nameof (frmPeriodUseData);
    this.Controls.SetChildIndex((Control) this.txtReader, 0);
    this.Controls.SetChildIndex((Control) this.lblPeriod, 0);
    this.Controls.SetChildIndex((Control) this.Label4, 0);
    this.Controls.SetChildIndex((Control) this.txtEndDate, 0);
    this.Controls.SetChildIndex((Control) this.txtStartDate, 0);
    this.Controls.SetChildIndex((Control) this.txtNumber, 0);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual InputBox txtNumber
  {
    [DebuggerNonUserCode] get => this._txtNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtNumber != null)
        this._txtNumber.IsValidChange -= changeEventHandler;
      this._txtNumber = value;
      if (this._txtNumber == null)
        return;
      this._txtNumber.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtStartDate
  {
    [DebuggerNonUserCode] get => this._txtStartDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler1 = new InputBox.IsValidChangeEventHandler(this.CalculatePeriod);
      InputBox.IsValidChangeEventHandler changeEventHandler2 = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtStartDate != null)
      {
        this._txtStartDate.IsValidChange -= changeEventHandler1;
        this._txtStartDate.IsValidChange -= changeEventHandler2;
      }
      this._txtStartDate = value;
      if (this._txtStartDate == null)
        return;
      this._txtStartDate.IsValidChange += changeEventHandler1;
      this._txtStartDate.IsValidChange += changeEventHandler2;
    }
  }

  internal virtual InputBox txtReader
  {
    [DebuggerNonUserCode] get => this._txtReader;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtReader != null)
        this._txtReader.IsValidChange -= changeEventHandler;
      this._txtReader = value;
      if (this._txtReader == null)
        return;
      this._txtReader.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtEndDate
  {
    [DebuggerNonUserCode] get => this._txtEndDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler1 = new InputBox.IsValidChangeEventHandler(this.CalculatePeriod);
      InputBox.IsValidChangeEventHandler changeEventHandler2 = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtEndDate != null)
      {
        this._txtEndDate.IsValidChange -= changeEventHandler1;
        this._txtEndDate.IsValidChange -= changeEventHandler2;
      }
      this._txtEndDate = value;
      if (this._txtEndDate == null)
        return;
      this._txtEndDate.IsValidChange += changeEventHandler1;
      this._txtEndDate.IsValidChange += changeEventHandler2;
    }
  }

  internal virtual Label lblPeriod
  {
    [DebuggerNonUserCode] get => this._lblPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPeriod = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  private void checkValidation()
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is InputBox && !((InputBox) control).isValid)
        {
          this.buttAdd.Enabled = false;
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblPeriod.Text, "", false) == 0)
      this.buttAdd.Enabled = false;
    else
      this.buttAdd.Enabled = true;
  }

  protected override void Add()
  {
    base.Add();
    cPeriodUse cPeriodUse = new cPeriodUse();
    cPeriodUse.Number = this.txtNumber.Text;
    cPeriodUse.StartDate = this.txtStartDate.Text;
    cPeriodUse.EndDate = this.txtEndDate.Text;
    cPeriodUse.Period = this.lblPeriod.Text;
    cPeriodUse.Reader = this.txtReader.Text;
    bool flag = true;
    switch (this.FormType)
    {
      case Enum_ToolbarButtons.New:
        flag = cPeriodUse.Add();
        break;
      case Enum_ToolbarButtons.Edit:
        cPeriodUse.Identity = this.FormValue;
        flag = cPeriodUse.Edit();
        break;
    }
    if (!flag)
    {
      string BodyText = cPeriodUse.ErrorMessage;
      if (cPeriodUse.ErrorDescription.Contains("UQ_fldPrivateId_tblPeriodUse"))
      {
        BodyText = "شماره دوره وارد شده تكراري ميباشد";
        this.txtNumber.Focus();
      }
      else if (cPeriodUse.ErrorDescription.Contains("UQ_fldStartDate_tblPeriodUse"))
      {
        BodyText = "تاريخ شروع دوره وارد شده تكراري ميباشد";
        this.txtStartDate.Focus();
      }
      else if (cPeriodUse.ErrorDescription.Contains("UQ_fldEndDate_tblPeriodUse"))
      {
        BodyText = "تاريخ پايان دوره وارد شده تكراري ميباشد";
        this.txtEndDate.Focus();
      }
      int num = (int) MessageBoxMPS.show((Form) this, BodyText, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cPeriodUse.ErrorDescription);
      this.buttAdd.Enabled = true;
    }
    else
    {
      switch (this.FormType)
      {
        case Enum_ToolbarButtons.New:
          DataRow row = this.FormParent.DataTable.NewRow();
          row["fldPeriodUseId"] = (object) cPeriodUse.Identity;
          row["fldPrivateId"] = (object) cPeriodUse.Number;
          row["fldStartDate"] = (object) cPeriodUse.StartDate;
          row["fldEndDate"] = (object) cPeriodUse.EndDate;
          row["fldPeriod"] = (object) cPeriodUse.Period;
          row["fldReader"] = (object) cPeriodUse.Reader;
          this.FormParent.DataTable.Rows.Add(row);
          break;
        case Enum_ToolbarButtons.Edit:
          DataTable dataTable = this.FormParent.DataTable;
          int num = checked (dataTable.Rows.Count - 1);
          int index = 0;
          while (index <= num)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataTable.Rows[index][0], (object) cPeriodUse.Identity, false))
            {
              dataTable.Rows[index]["fldPeriodUseId"] = (object) cPeriodUse.Identity;
              dataTable.Rows[index]["fldPrivateId"] = (object) cPeriodUse.Number;
              dataTable.Rows[index]["fldStartDate"] = (object) cPeriodUse.StartDate;
              dataTable.Rows[index]["fldEndDate"] = (object) cPeriodUse.EndDate;
              dataTable.Rows[index]["fldPeriod"] = (object) cPeriodUse.Period;
              dataTable.Rows[index]["fldReader"] = (object) cPeriodUse.Reader;
              break;
            }
            checked { ++index; }
          }
          break;
      }
      this.Dispose();
    }
  }

  private void CalculatePeriod()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtStartDate.Text, "", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtEndDate.Text, "", false) != 0 & this.txtEndDate.isValid & this.txtStartDate.isValid)
      this.lblPeriod.Text = cCalculate.DeffDate(this.txtStartDate.Text, this.txtEndDate.Text);
    else
      this.lblPeriod.Text = "";
  }
}
