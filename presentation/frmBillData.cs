// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmBillData
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
public class frmBillData : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtPrivateId")]
  private InputBox _txtPrivateId;
  [AccessedThroughProperty("txtStartDate")]
  private InputBox _txtStartDate;
  [AccessedThroughProperty("txtEndDate")]
  private InputBox _txtEndDate;
  [AccessedThroughProperty("txtPeriod")]
  private InputBox _txtPeriod;
  [AccessedThroughProperty("txtUse")]
  private InputBox _txtUse;
  [AccessedThroughProperty("txtTax")]
  private InputBox _txtTax;
  [AccessedThroughProperty("txtPrice")]
  private InputBox _txtPrice;

  [DebuggerNonUserCode]
  static frmBillData()
  {
  }

  [DebuggerNonUserCode]
  public frmBillData()
  {
    this.Shown += new EventHandler(this.frmBillData_Load);
    frmBillData.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBillData.__ENCList)
    {
      if (frmBillData.__ENCList.Count == frmBillData.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBillData.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBillData.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBillData.__ENCList[index1] = frmBillData.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBillData.__ENCList.RemoveRange(index1, checked (frmBillData.__ENCList.Count - index1));
        frmBillData.__ENCList.Capacity = frmBillData.__ENCList.Count;
      }
      frmBillData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    InputButtonSettings inputButtonSettings6 = new InputButtonSettings();
    InputButtonSettings inputButtonSettings7 = new InputButtonSettings();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBillData));
    this.txtPrivateId = new InputBox();
    this.txtStartDate = new InputBox();
    this.txtEndDate = new InputBox();
    this.txtPeriod = new InputBox();
    this.txtUse = new InputBox();
    this.txtTax = new InputBox();
    this.txtPrice = new InputBox();
    this.SuspendLayout();
    this.txtPrivateId.Alighment = HorizontalAlignment.Left;
    this.txtPrivateId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPrivateId.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtPrivateId.Button = inputButtonSettings1;
    this.txtPrivateId.ButtonDropDownEnable = true;
    this.txtPrivateId.ControlType = Enum_ControlType.TextBox;
    this.txtPrivateId.DefaultLanguge = Enum_Languge.English;
    this.txtPrivateId.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPrivateId.InputValidation = Enum_InputValidation.Integer;
    this.txtPrivateId.Key = "";
    this.txtPrivateId.LabelForeColor = SystemColors.ControlText;
    this.txtPrivateId.LabelText = "دوره قرائت";
    InputBox txtPrivateId1 = this.txtPrivateId;
    Point point1 = new Point(150, 63 /*0x3F*/);
    Point point2 = point1;
    txtPrivateId1.Location = point2;
    this.txtPrivateId.MaxLenght = 5;
    this.txtPrivateId.MinLenght = 0;
    this.txtPrivateId.Multiline = false;
    this.txtPrivateId.Name = "txtPrivateId";
    this.txtPrivateId.RangeDown = "";
    this.txtPrivateId.RangeUp = "";
    this.txtPrivateId.RequiredField = true;
    InputBox txtPrivateId2 = this.txtPrivateId;
    Size size1 = new Size(129, 24);
    Size size2 = size1;
    txtPrivateId2.Size = size2;
    this.txtPrivateId.TabIndex = 8;
    this.txtPrivateId.ToolTipText = "لطفا عدد قرائت دوره قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtPrivateId.UseSystemPasswordChar = false;
    this.txtPrivateId.WatermarkText = "";
    this.txtPrivateId.WriteType = Enum_WriteType.Defualt;
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
    this.txtStartDate.LabelText = "تاريخ قرائت قبلي";
    InputBox txtStartDate1 = this.txtStartDate;
    point1 = new Point(109, 93);
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
    size1 = new Size(198, 25);
    Size size3 = size1;
    txtStartDate2.Size = size3;
    this.txtStartDate.TabIndex = 9;
    this.txtStartDate.ToolTipText = "لطفا تاريخ قرائت قبلي قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtStartDate.UseSystemPasswordChar = false;
    this.txtStartDate.WatermarkText = "";
    this.txtStartDate.WriteType = Enum_WriteType.Defualt;
    this.txtEndDate.Alighment = HorizontalAlignment.Center;
    this.txtEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtEndDate.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtEndDate.Button = inputButtonSettings3;
    this.txtEndDate.ButtonDropDownEnable = true;
    this.txtEndDate.ControlType = Enum_ControlType.DateBox;
    this.txtEndDate.DefaultLanguge = Enum_Languge.Persian;
    this.txtEndDate.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtEndDate.InputValidation = Enum_InputValidation.Date;
    this.txtEndDate.Key = "";
    this.txtEndDate.LabelForeColor = SystemColors.ControlText;
    this.txtEndDate.LabelText = "تاريخ قرائت فعلي";
    InputBox txtEndDate1 = this.txtEndDate;
    point1 = new Point(109, 122);
    Point point4 = point1;
    txtEndDate1.Location = point4;
    this.txtEndDate.MaxLenght = 10;
    this.txtEndDate.MinLenght = 10;
    this.txtEndDate.Multiline = false;
    this.txtEndDate.Name = "txtEndDate";
    this.txtEndDate.RangeDown = "";
    this.txtEndDate.RangeUp = "";
    this.txtEndDate.RequiredField = true;
    InputBox txtEndDate2 = this.txtEndDate;
    size1 = new Size(200, 25);
    Size size4 = size1;
    txtEndDate2.Size = size4;
    this.txtEndDate.TabIndex = 10;
    this.txtEndDate.ToolTipText = "لطفا تاريخ قرائت فعلي قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtEndDate.UseSystemPasswordChar = false;
    this.txtEndDate.WatermarkText = "";
    this.txtEndDate.WriteType = Enum_WriteType.Defualt;
    this.txtPeriod.Alighment = HorizontalAlignment.Left;
    this.txtPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPeriod.BackColor = Color.Transparent;
    inputButtonSettings4.DisplayPosition = 1;
    inputButtonSettings4.Enabled = false;
    this.txtPeriod.Button = inputButtonSettings4;
    this.txtPeriod.ButtonDropDownEnable = true;
    this.txtPeriod.ControlType = Enum_ControlType.TextBox;
    this.txtPeriod.DefaultLanguge = Enum_Languge.English;
    this.txtPeriod.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPeriod.InputValidation = Enum_InputValidation.Integer;
    this.txtPeriod.Key = "";
    this.txtPeriod.LabelForeColor = SystemColors.ControlText;
    this.txtPeriod.LabelText = "طول دوره";
    InputBox txtPeriod1 = this.txtPeriod;
    point1 = new Point(150, 153);
    Point point5 = point1;
    txtPeriod1.Location = point5;
    this.txtPeriod.MaxLenght = 3;
    this.txtPeriod.MinLenght = 0;
    this.txtPeriod.Multiline = false;
    this.txtPeriod.Name = "txtPeriod";
    this.txtPeriod.RangeDown = "";
    this.txtPeriod.RangeUp = "";
    this.txtPeriod.RequiredField = true;
    InputBox txtPeriod2 = this.txtPeriod;
    size1 = new Size(122, 24);
    Size size5 = size1;
    txtPeriod2.Size = size5;
    this.txtPeriod.TabIndex = 11;
    this.txtPeriod.ToolTipText = "لطفا طول دوره قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtPeriod.UseSystemPasswordChar = false;
    this.txtPeriod.WatermarkText = "";
    this.txtPeriod.WriteType = Enum_WriteType.Defualt;
    this.txtUse.Alighment = HorizontalAlignment.Left;
    this.txtUse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtUse.BackColor = Color.Transparent;
    inputButtonSettings5.DisplayPosition = 1;
    inputButtonSettings5.Enabled = false;
    this.txtUse.Button = inputButtonSettings5;
    this.txtUse.ButtonDropDownEnable = true;
    this.txtUse.ControlType = Enum_ControlType.TextBox;
    this.txtUse.DefaultLanguge = Enum_Languge.English;
    this.txtUse.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtUse.InputValidation = Enum_InputValidation.Integer;
    this.txtUse.Key = "";
    this.txtUse.LabelForeColor = SystemColors.ControlText;
    this.txtUse.LabelText = "ميزان مصرف (ليتر)";
    InputBox txtUse1 = this.txtUse;
    point1 = new Point(109, 183);
    Point point6 = point1;
    txtUse1.Location = point6;
    this.txtUse.MaxLenght = 10;
    this.txtUse.MinLenght = 0;
    this.txtUse.Multiline = false;
    this.txtUse.Name = "txtUse";
    this.txtUse.RangeDown = "";
    this.txtUse.RangeUp = "";
    this.txtUse.RequiredField = true;
    InputBox txtUse2 = this.txtUse;
    size1 = new Size(207, 24);
    Size size6 = size1;
    txtUse2.Size = size6;
    this.txtUse.TabIndex = 12;
    this.txtUse.ToolTipText = "لطفا مصرف دوره  قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtUse.UseSystemPasswordChar = false;
    this.txtUse.WatermarkText = "";
    this.txtUse.WriteType = Enum_WriteType.Defualt;
    this.txtTax.Alighment = HorizontalAlignment.Left;
    this.txtTax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtTax.BackColor = Color.Transparent;
    inputButtonSettings6.DisplayPosition = 1;
    inputButtonSettings6.Enabled = false;
    this.txtTax.Button = inputButtonSettings6;
    this.txtTax.ButtonDropDownEnable = true;
    this.txtTax.ControlType = Enum_ControlType.TextBox;
    this.txtTax.DefaultLanguge = Enum_Languge.English;
    this.txtTax.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtTax.InputValidation = Enum_InputValidation.Currency;
    this.txtTax.Key = "";
    this.txtTax.LabelForeColor = SystemColors.ControlText;
    this.txtTax.LabelText = "ماليات (ريال)";
    InputBox txtTax1 = this.txtTax;
    point1 = new Point(69, 213);
    Point point7 = point1;
    txtTax1.Location = point7;
    this.txtTax.MaxLenght = (int) short.MaxValue;
    this.txtTax.MinLenght = 0;
    this.txtTax.Multiline = false;
    this.txtTax.Name = "txtTax";
    this.txtTax.RangeDown = "";
    this.txtTax.RangeUp = "";
    this.txtTax.RequiredField = true;
    InputBox txtTax2 = this.txtTax;
    size1 = new Size(218, 24);
    Size size7 = size1;
    txtTax2.Size = size7;
    this.txtTax.TabIndex = 13;
    this.txtTax.ToolTipText = "لطفا مبلغ ماليات قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtTax.UseSystemPasswordChar = false;
    this.txtTax.WatermarkText = "";
    this.txtTax.WriteType = Enum_WriteType.Defualt;
    this.txtPrice.Alighment = HorizontalAlignment.Left;
    this.txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPrice.BackColor = Color.Transparent;
    inputButtonSettings7.DisplayPosition = 1;
    inputButtonSettings7.Enabled = false;
    this.txtPrice.Button = inputButtonSettings7;
    this.txtPrice.ButtonDropDownEnable = true;
    this.txtPrice.ControlType = Enum_ControlType.TextBox;
    this.txtPrice.DefaultLanguge = Enum_Languge.English;
    this.txtPrice.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPrice.InputValidation = Enum_InputValidation.Currency;
    this.txtPrice.Key = "";
    this.txtPrice.LabelForeColor = SystemColors.ControlText;
    this.txtPrice.LabelText = "مبلغ قابل پرداخت (ريال)";
    InputBox txtPrice1 = this.txtPrice;
    point1 = new Point(69, 243);
    Point point8 = point1;
    txtPrice1.Location = point8;
    this.txtPrice.MaxLenght = (int) short.MaxValue;
    this.txtPrice.MinLenght = 0;
    this.txtPrice.Multiline = false;
    this.txtPrice.Name = "txtPrice";
    this.txtPrice.RangeDown = "";
    this.txtPrice.RangeUp = "";
    this.txtPrice.RequiredField = true;
    InputBox txtPrice2 = this.txtPrice;
    size1 = new Size(268, 24);
    Size size8 = size1;
    txtPrice2.Size = size8;
    this.txtPrice.TabIndex = 14;
    this.txtPrice.ToolTipText = "لطفا مبلغ قابل پرداخت قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtPrice.UseSystemPasswordChar = false;
    this.txtPrice.WatermarkText = "";
    this.txtPrice.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(400, 320);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtPrivateId);
    this.Controls.Add((Control) this.txtStartDate);
    this.Controls.Add((Control) this.txtEndDate);
    this.Controls.Add((Control) this.txtPeriod);
    this.Controls.Add((Control) this.txtUse);
    this.Controls.Add((Control) this.txtTax);
    this.Controls.Add((Control) this.txtPrice);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmBillData);
    this.Text = nameof (frmBillData);
    this.Controls.SetChildIndex((Control) this.txtPrice, 0);
    this.Controls.SetChildIndex((Control) this.txtTax, 0);
    this.Controls.SetChildIndex((Control) this.txtUse, 0);
    this.Controls.SetChildIndex((Control) this.txtPeriod, 0);
    this.Controls.SetChildIndex((Control) this.txtEndDate, 0);
    this.Controls.SetChildIndex((Control) this.txtStartDate, 0);
    this.Controls.SetChildIndex((Control) this.txtPrivateId, 0);
    this.ResumeLayout(false);
  }

  internal virtual InputBox txtPrivateId
  {
    [DebuggerNonUserCode] get => this._txtPrivateId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtPrivateId != null)
        this._txtPrivateId.IsValidChange -= changeEventHandler;
      this._txtPrivateId = value;
      if (this._txtPrivateId == null)
        return;
      this._txtPrivateId.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtStartDate
  {
    [DebuggerNonUserCode] get => this._txtStartDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtStartDate != null)
        this._txtStartDate.IsValidChange -= changeEventHandler;
      this._txtStartDate = value;
      if (this._txtStartDate == null)
        return;
      this._txtStartDate.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtEndDate
  {
    [DebuggerNonUserCode] get => this._txtEndDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtEndDate != null)
        this._txtEndDate.IsValidChange -= changeEventHandler;
      this._txtEndDate = value;
      if (this._txtEndDate == null)
        return;
      this._txtEndDate.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtPeriod
  {
    [DebuggerNonUserCode] get => this._txtPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtPeriod != null)
        this._txtPeriod.IsValidChange -= changeEventHandler;
      this._txtPeriod = value;
      if (this._txtPeriod == null)
        return;
      this._txtPeriod.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtUse
  {
    [DebuggerNonUserCode] get => this._txtUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtUse != null)
        this._txtUse.IsValidChange -= changeEventHandler;
      this._txtUse = value;
      if (this._txtUse == null)
        return;
      this._txtUse.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtTax
  {
    [DebuggerNonUserCode] get => this._txtTax;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtTax != null)
        this._txtTax.IsValidChange -= changeEventHandler;
      this._txtTax = value;
      if (this._txtTax == null)
        return;
      this._txtTax.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtPrice
  {
    [DebuggerNonUserCode] get => this._txtPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtPrice != null)
        this._txtPrice.IsValidChange -= changeEventHandler;
      this._txtPrice = value;
      if (this._txtPrice == null)
        return;
      this._txtPrice.IsValidChange += changeEventHandler;
    }
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
    this.buttAdd.Enabled = true;
  }

  protected override void Add()
  {
    base.Add();
    cBill cBill = new cBill();
    cBill.PrivateId = this.txtPrivateId.Text;
    cBill.StartDate = this.txtStartDate.Text;
    cBill.LastDate = this.txtEndDate.Text;
    cBill.Period = this.txtPeriod.Text;
    cBill.Use = this.txtUse.Text;
    cBill.Tax = this.txtTax.Text;
    cBill.Price = this.txtPrice.Text;
    bool flag = true;
    switch (this.FormType)
    {
      case Enum_ToolbarButtons.New:
        flag = cBill.Add();
        break;
      case Enum_ToolbarButtons.Edit:
        cBill.Identity = this.FormValue;
        flag = cBill.Edit();
        break;
    }
    if (!flag)
    {
      string BodyText = cBill.ErrorMessage;
      if (cBill.ErrorDescription.Contains("PK_fldPrivateId_tblBill"))
      {
        BodyText = "شماره دوره وارد شده تكراري ميباشد. اين شماره دوره قبلا ثبت شده است ";
        this.txtPrivateId.Focus();
      }
      int num = (int) MessageBoxMPS.show((Form) this, BodyText, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cBill.ErrorDescription);
      this.buttAdd.Enabled = true;
    }
    else
    {
      switch (this.FormType)
      {
        case Enum_ToolbarButtons.New:
          DataRow row = this.FormParent.DataTable.NewRow();
          row["fldBillId"] = (object) cBill.Identity;
          row["fldPrivateId"] = (object) this.txtPrivateId.Text;
          row["fldStartDate"] = (object) this.txtStartDate.Text;
          row["fldEndDate"] = (object) this.txtEndDate.Text;
          row["fldPeriod"] = (object) this.txtPeriod.Text;
          row["fldUse"] = (object) this.txtUse.Text;
          row["fldPrice"] = (object) cBill.Price;
          this.FormParent.DataTable.Rows.Add(row);
          break;
        case Enum_ToolbarButtons.Edit:
          DataTable dataTable = this.FormParent.DataTable;
          int num = checked (dataTable.Rows.Count - 1);
          int index = 0;
          while (index <= num)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataTable.Rows[index][0], (object) cBill.Identity, false))
            {
              dataTable.Rows[index]["fldBillId"] = (object) cBill.Identity;
              dataTable.Rows[index]["fldPrivateId"] = (object) this.txtPrivateId.Text;
              dataTable.Rows[index]["fldStartDate"] = (object) this.txtStartDate.Text;
              dataTable.Rows[index]["fldEndDate"] = (object) this.txtEndDate.Text;
              dataTable.Rows[index]["fldPeriod"] = (object) this.txtPeriod.Text;
              dataTable.Rows[index]["fldUse"] = (object) this.txtUse.Text;
              dataTable.Rows[index]["fldPrice"] = (object) cBill.Price;
              break;
            }
            checked { ++index; }
          }
          break;
      }
      this.Dispose();
    }
  }

  private void frmBillData_Load(object sender, EventArgs e)
  {
    this.txtTax.Focus();
    this.txtPrice.Focus();
    this.txtPrivateId.Focus();
  }
}
