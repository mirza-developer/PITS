// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmHomeData
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
public class frmHomeData : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtBlock")]
  private InputBox _txtBlock;
  [AccessedThroughProperty("txtTel")]
  private InputBox _txtTel;
  [AccessedThroughProperty("txtName")]
  private InputBox _txtName;
  [AccessedThroughProperty("txtMobile")]
  private InputBox _txtMobile;
  [AccessedThroughProperty("txtMobile1")]
  private InputBox _txtMobile1;
  [AccessedThroughProperty("txtName1")]
  private InputBox _txtName1;
  [AccessedThroughProperty("txtRent")]
  private InputBox _txtRent;
  [AccessedThroughProperty("txtNumber")]
  private InputBox _txtNumber;

  [DebuggerNonUserCode]
  static frmHomeData()
  {
  }

  [DebuggerNonUserCode]
  public frmHomeData()
  {
    frmHomeData.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmHomeData.__ENCList)
    {
      if (frmHomeData.__ENCList.Count == frmHomeData.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmHomeData.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmHomeData.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmHomeData.__ENCList[index1] = frmHomeData.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmHomeData.__ENCList.RemoveRange(index1, checked (frmHomeData.__ENCList.Count - index1));
        frmHomeData.__ENCList.Capacity = frmHomeData.__ENCList.Count;
      }
      frmHomeData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    InputButtonSettings inputButtonSettings8 = new InputButtonSettings();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmHomeData));
    this.txtBlock = new InputBox();
    this.txtTel = new InputBox();
    this.txtName = new InputBox();
    this.txtMobile = new InputBox();
    this.txtMobile1 = new InputBox();
    this.txtName1 = new InputBox();
    this.txtRent = new InputBox();
    this.txtNumber = new InputBox();
    this.SuspendLayout();
    this.txtBlock.Alighment = HorizontalAlignment.Left;
    this.txtBlock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
    Point point1 = new Point(249, 82);
    Point point2 = point1;
    txtBlock1.Location = point2;
    this.txtBlock.MaxLenght = 2;
    this.txtBlock.MinLenght = 1;
    this.txtBlock.Multiline = false;
    this.txtBlock.Name = "txtBlock";
    this.txtBlock.RangeDown = "0";
    this.txtBlock.RangeUp = "99";
    this.txtBlock.RequiredField = true;
    InputBox txtBlock2 = this.txtBlock;
    Size size1 = new Size(97, 24);
    Size size2 = size1;
    txtBlock2.Size = size2;
    this.txtBlock.TabIndex = 1;
    this.txtBlock.ToolTipText = "شماره بلوك را در اين قسمت وارد نمائيد";
    this.txtBlock.UseSystemPasswordChar = false;
    this.txtBlock.WatermarkText = "";
    this.txtBlock.WriteType = Enum_WriteType.Defualt;
    this.txtTel.Alighment = HorizontalAlignment.Left;
    this.txtTel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtTel.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtTel.Button = inputButtonSettings2;
    this.txtTel.ButtonDropDownEnable = true;
    this.txtTel.ControlType = Enum_ControlType.TextBox;
    this.txtTel.DefaultLanguge = Enum_Languge.English;
    this.txtTel.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtTel.InputValidation = Enum_InputValidation.Integer;
    this.txtTel.Key = "";
    this.txtTel.LabelForeColor = SystemColors.ControlText;
    this.txtTel.LabelText = "تلفن";
    InputBox txtTel1 = this.txtTel;
    point1 = new Point(218, 112 /*0x70*/);
    Point point3 = point1;
    txtTel1.Location = point3;
    this.txtTel.MaxLenght = 8;
    this.txtTel.MinLenght = 8;
    this.txtTel.Multiline = false;
    this.txtTel.Name = "txtTel";
    this.txtTel.RangeDown = "";
    this.txtTel.RangeUp = "";
    this.txtTel.RequiredField = true;
    InputBox txtTel2 = this.txtTel;
    size1 = new Size(129, 24);
    Size size3 = size1;
    txtTel2.Size = size3;
    this.txtTel.TabIndex = 2;
    this.txtTel.ToolTipText = "شماره تلفن واحد را در اين قسمت وارد نمائيد";
    this.txtTel.UseSystemPasswordChar = false;
    this.txtTel.WatermarkText = "";
    this.txtTel.WriteType = Enum_WriteType.Defualt;
    this.txtName.Alighment = HorizontalAlignment.Left;
    this.txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtName.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtName.Button = inputButtonSettings3;
    this.txtName.ButtonDropDownEnable = true;
    this.txtName.ControlType = Enum_ControlType.TextBox;
    this.txtName.DefaultLanguge = Enum_Languge.Persian;
    this.txtName.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtName.InputValidation = Enum_InputValidation.All;
    this.txtName.Key = "";
    this.txtName.LabelForeColor = SystemColors.ControlText;
    this.txtName.LabelText = "نام ساكن";
    InputBox txtName1 = this.txtName;
    point1 = new Point(26, 142);
    Point point4 = point1;
    txtName1.Location = point4;
    this.txtName.MaxLenght = 50;
    this.txtName.MinLenght = 1;
    this.txtName.Multiline = false;
    this.txtName.Name = "txtName";
    this.txtName.RangeDown = "";
    this.txtName.RangeUp = "";
    this.txtName.RequiredField = true;
    InputBox txtName2 = this.txtName;
    size1 = new Size(343, 24);
    Size size4 = size1;
    txtName2.Size = size4;
    this.txtName.TabIndex = 3;
    this.txtName.ToolTipText = "نام ساكن فعلي منزل را در اين قسمت وارد نمائيد";
    this.txtName.UseSystemPasswordChar = false;
    this.txtName.WatermarkText = "";
    this.txtName.WriteType = Enum_WriteType.Defualt;
    this.txtMobile.Alighment = HorizontalAlignment.Left;
    this.txtMobile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtMobile.BackColor = Color.Transparent;
    inputButtonSettings4.DisplayPosition = 1;
    inputButtonSettings4.Enabled = false;
    this.txtMobile.Button = inputButtonSettings4;
    this.txtMobile.ButtonDropDownEnable = true;
    this.txtMobile.ControlType = Enum_ControlType.TextBox;
    this.txtMobile.DefaultLanguge = Enum_Languge.English;
    this.txtMobile.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtMobile.InputValidation = Enum_InputValidation.Integer;
    this.txtMobile.Key = "";
    this.txtMobile.LabelForeColor = SystemColors.ControlText;
    this.txtMobile.LabelText = "موبايل ساكن";
    InputBox txtMobile1 = this.txtMobile;
    point1 = new Point(203, 172);
    Point point5 = point1;
    txtMobile1.Location = point5;
    this.txtMobile.MaxLenght = 11;
    this.txtMobile.MinLenght = 11;
    this.txtMobile.Multiline = false;
    this.txtMobile.Name = "txtMobile";
    this.txtMobile.RangeDown = "";
    this.txtMobile.RangeUp = "";
    this.txtMobile.RequiredField = false;
    InputBox txtMobile2 = this.txtMobile;
    size1 = new Size(181, 24);
    Size size5 = size1;
    txtMobile2.Size = size5;
    this.txtMobile.TabIndex = 4;
    this.txtMobile.ToolTipText = "شماره تلفن همراه ساكن را در اين قسمت وارد نمائيد";
    this.txtMobile.UseSystemPasswordChar = false;
    this.txtMobile.WatermarkText = "";
    this.txtMobile.WriteType = Enum_WriteType.Defualt;
    this.txtMobile1.Alighment = HorizontalAlignment.Left;
    this.txtMobile1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtMobile1.BackColor = Color.Transparent;
    inputButtonSettings5.DisplayPosition = 1;
    inputButtonSettings5.Enabled = false;
    this.txtMobile1.Button = inputButtonSettings5;
    this.txtMobile1.ButtonDropDownEnable = true;
    this.txtMobile1.ControlType = Enum_ControlType.TextBox;
    this.txtMobile1.DefaultLanguge = Enum_Languge.English;
    this.txtMobile1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtMobile1.InputValidation = Enum_InputValidation.Integer;
    this.txtMobile1.Key = "";
    this.txtMobile1.LabelForeColor = SystemColors.ControlText;
    this.txtMobile1.LabelText = "موبايل مالك";
    InputBox txtMobile1_1 = this.txtMobile1;
    point1 = new Point(164, 259);
    Point point6 = point1;
    txtMobile1_1.Location = point6;
    this.txtMobile1.MaxLenght = 11;
    this.txtMobile1.MinLenght = 11;
    this.txtMobile1.Multiline = false;
    this.txtMobile1.Name = "txtMobile1";
    this.txtMobile1.RangeDown = "";
    this.txtMobile1.RangeUp = "";
    this.txtMobile1.RequiredField = false;
    InputBox txtMobile1_2 = this.txtMobile1;
    size1 = new Size(214, 24);
    Size size6 = size1;
    txtMobile1_2.Size = size6;
    this.txtMobile1.TabIndex = 7;
    this.txtMobile1.ToolTipText = "شماره تلفن همراه مالك را در اين قسمت وارد نمائيد";
    this.txtMobile1.UseSystemPasswordChar = false;
    this.txtMobile1.WatermarkText = "";
    this.txtMobile1.WriteType = Enum_WriteType.Defualt;
    this.txtName1.Alighment = HorizontalAlignment.Left;
    this.txtName1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtName1.BackColor = Color.Transparent;
    inputButtonSettings6.DisplayPosition = 1;
    inputButtonSettings6.Enabled = false;
    this.txtName1.Button = inputButtonSettings6;
    this.txtName1.ButtonDropDownEnable = true;
    this.txtName1.ControlType = Enum_ControlType.TextBox;
    this.txtName1.DefaultLanguge = Enum_Languge.Persian;
    this.txtName1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtName1.InputValidation = Enum_InputValidation.All;
    this.txtName1.Key = "";
    this.txtName1.LabelForeColor = SystemColors.ControlText;
    this.txtName1.LabelText = "نام مالك";
    InputBox txtName1_1 = this.txtName1;
    point1 = new Point(26, 229);
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
    size1 = new Size(337, 24);
    Size size7 = size1;
    txtName1_2.Size = size7;
    this.txtName1.TabIndex = 6;
    this.txtName1.ToolTipText = "نام مالك منزل را در اين قسمت وارد نمائيد";
    this.txtName1.UseSystemPasswordChar = false;
    this.txtName1.WatermarkText = "";
    this.txtName1.WriteType = Enum_WriteType.Defualt;
    this.txtRent.Alighment = HorizontalAlignment.Left;
    this.txtRent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtRent.BackColor = Color.Transparent;
    inputButtonSettings7.DisplayPosition = 1;
    inputButtonSettings7.Enabled = false;
    this.txtRent.Button = inputButtonSettings7;
    this.txtRent.ButtonDropDownEnable = true;
    this.txtRent.ControlType = Enum_ControlType.ComboBox;
    this.txtRent.DefaultLanguge = Enum_Languge.English;
    this.txtRent.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtRent.InputValidation = Enum_InputValidation.All;
    this.txtRent.Key = "";
    this.txtRent.LabelForeColor = SystemColors.ControlText;
    this.txtRent.LabelText = "نوع سكونت";
    InputBox txtRent1 = this.txtRent;
    point1 = new Point(164, 199);
    Point point8 = point1;
    txtRent1.Location = point8;
    this.txtRent.MaxLenght = 0;
    this.txtRent.MinLenght = 0;
    this.txtRent.Multiline = false;
    this.txtRent.Name = "txtRent";
    this.txtRent.RangeDown = "";
    this.txtRent.RangeUp = "";
    this.txtRent.RequiredField = true;
    InputBox txtRent2 = this.txtRent;
    size1 = new Size(215, 24);
    Size size8 = size1;
    txtRent2.Size = size8;
    this.txtRent.TabIndex = 5;
    this.txtRent.ToolTipText = "نوع سكونت را از ليست انتخاب كنيد";
    this.txtRent.UseSystemPasswordChar = false;
    this.txtRent.WatermarkText = "";
    this.txtRent.WriteType = Enum_WriteType.SelectOnly;
    this.txtNumber.Alighment = HorizontalAlignment.Left;
    this.txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtNumber.BackColor = Color.Transparent;
    inputButtonSettings8.DisplayPosition = 1;
    inputButtonSettings8.Enabled = false;
    this.txtNumber.Button = inputButtonSettings8;
    this.txtNumber.ButtonDropDownEnable = true;
    this.txtNumber.ControlType = Enum_ControlType.TextBox;
    this.txtNumber.DefaultLanguge = Enum_Languge.English;
    this.txtNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtNumber.InputValidation = Enum_InputValidation.Integer;
    this.txtNumber.Key = "";
    this.txtNumber.LabelForeColor = SystemColors.ControlText;
    this.txtNumber.LabelText = "پلاك";
    InputBox txtNumber1 = this.txtNumber;
    point1 = new Point(249, 52);
    Point point9 = point1;
    txtNumber1.Location = point9;
    this.txtNumber.MaxLenght = 3;
    this.txtNumber.MinLenght = 1;
    this.txtNumber.Multiline = false;
    this.txtNumber.Name = "txtNumber";
    this.txtNumber.RangeDown = "1";
    this.txtNumber.RangeUp = "999";
    this.txtNumber.RequiredField = true;
    InputBox txtNumber2 = this.txtNumber;
    size1 = new Size(96 /*0x60*/, 24);
    Size size9 = size1;
    txtNumber2.Size = size9;
    this.txtNumber.TabIndex = 0;
    this.txtNumber.ToolTipText = "پلاك واحد را در اين قسمت وارد نمائيد";
    this.txtNumber.UseSystemPasswordChar = false;
    this.txtNumber.WatermarkText = "";
    this.txtNumber.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(392, 301);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtRent);
    this.Controls.Add((Control) this.txtMobile1);
    this.Controls.Add((Control) this.txtName1);
    this.Controls.Add((Control) this.txtMobile);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.txtTel);
    this.Controls.Add((Control) this.txtBlock);
    this.Controls.Add((Control) this.txtNumber);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmHomeData);
    this.Text = nameof (frmHomeData);
    this.Controls.SetChildIndex((Control) this.txtNumber, 0);
    this.Controls.SetChildIndex((Control) this.txtBlock, 0);
    this.Controls.SetChildIndex((Control) this.txtTel, 0);
    this.Controls.SetChildIndex((Control) this.txtName, 0);
    this.Controls.SetChildIndex((Control) this.txtMobile, 0);
    this.Controls.SetChildIndex((Control) this.txtName1, 0);
    this.Controls.SetChildIndex((Control) this.txtMobile1, 0);
    this.Controls.SetChildIndex((Control) this.txtRent, 0);
    this.ResumeLayout(false);
  }

  internal virtual InputBox txtBlock
  {
    [DebuggerNonUserCode] get => this._txtBlock;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtBlock != null)
        this._txtBlock.IsValidChange -= changeEventHandler;
      this._txtBlock = value;
      if (this._txtBlock == null)
        return;
      this._txtBlock.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtTel
  {
    [DebuggerNonUserCode] get => this._txtTel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtTel != null)
        this._txtTel.IsValidChange -= changeEventHandler;
      this._txtTel = value;
      if (this._txtTel == null)
        return;
      this._txtTel.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtName
  {
    [DebuggerNonUserCode] get => this._txtName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtName != null)
        this._txtName.IsValidChange -= changeEventHandler;
      this._txtName = value;
      if (this._txtName == null)
        return;
      this._txtName.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtMobile
  {
    [DebuggerNonUserCode] get => this._txtMobile;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtMobile != null)
        this._txtMobile.IsValidChange -= changeEventHandler;
      this._txtMobile = value;
      if (this._txtMobile == null)
        return;
      this._txtMobile.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtMobile1
  {
    [DebuggerNonUserCode] get => this._txtMobile1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtMobile1 != null)
        this._txtMobile1.IsValidChange -= changeEventHandler;
      this._txtMobile1 = value;
      if (this._txtMobile1 == null)
        return;
      this._txtMobile1.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtName1
  {
    [DebuggerNonUserCode] get => this._txtName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtName1 != null)
        this._txtName1.IsValidChange -= changeEventHandler;
      this._txtName1 = value;
      if (this._txtName1 == null)
        return;
      this._txtName1.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtRent
  {
    [DebuggerNonUserCode] get => this._txtRent;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = new InputBox.TextChangedEventHandler(this.txtRent_TextChanged);
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtRent != null)
      {
        this._txtRent.TextChanged -= changedEventHandler;
        this._txtRent.IsValidChange -= changeEventHandler;
      }
      this._txtRent = value;
      if (this._txtRent == null)
        return;
      this._txtRent.TextChanged += changedEventHandler;
      this._txtRent.IsValidChange += changeEventHandler;
    }
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
    cHome cHome = new cHome();
    cHome.Number = this.txtNumber.Text;
    cHome.Block = this.txtBlock.Text;
    cHome.Tel = this.txtTel.Text;
    cHome.Name = this.txtName.Text;
    cHome.Mobile = this.txtMobile.Text;
    cHome.Name1 = this.txtName1.Text;
    cHome.Mobile1 = this.txtMobile1.Text;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtRent.Key, "", false) == 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "لطفا نوع سكونت را از ليست انتخاب كنيد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      this.buttAdd.Enabled = true;
      this.txtRent.Focus();
    }
    else
    {
      cHome.Rent = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtRent.Key, "0", false) != 0 ? Conversions.ToString(true) : Conversions.ToString(false);
      bool flag = true;
      switch (this.FormType)
      {
        case Enum_ToolbarButtons.New:
          flag = cHome.Add();
          break;
        case Enum_ToolbarButtons.Edit:
          cHome.Identity = this.FormValue;
          flag = cHome.Edit();
          break;
      }
      if (!flag)
      {
        string BodyText = cHome.ErrorMessage;
        if (cHome.ErrorDescription.Contains("UQ_fldNumber_tblHome"))
        {
          BodyText = "شماره واحد وارد شده تكراري ميباشد";
          this.txtNumber.Focus();
        }
        else if (cHome.ErrorDescription.Contains("UQ_fldTel_tblHome"))
        {
          BodyText = "شماره تلفن وارد شده تكراري ميباشد";
          this.txtTel.Focus();
        }
        int num = (int) MessageBoxMPS.show((Form) this, BodyText, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cHome.ErrorDescription);
        this.buttAdd.Enabled = true;
      }
      else
      {
        switch (this.FormType)
        {
          case Enum_ToolbarButtons.New:
            DataRow row = this.FormParent.DataTable.NewRow();
            row["fldHomeId"] = (object) cHome.Identity;
            row["fldNumber"] = (object) cHome.Number;
            row["fldBlockNumber"] = (object) cHome.Block;
            row["fldTel"] = (object) cHome.Tel;
            row["fldName"] = (object) cHome.Name;
            row["fldMobile"] = (object) cHome.Mobile;
            row["fldRent"] = (object) cHome.Rent;
            this.FormParent.DataTable.Rows.Add(row);
            break;
          case Enum_ToolbarButtons.Edit:
            DataTable dataTable = this.FormParent.DataTable;
            int num = checked (dataTable.Rows.Count - 1);
            int index = 0;
            while (index <= num)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataTable.Rows[index][0], (object) cHome.Identity, false))
              {
                dataTable.Rows[index]["fldHomeId"] = (object) cHome.Identity;
                dataTable.Rows[index]["fldNumber"] = (object) cHome.Number;
                dataTable.Rows[index]["fldBlockNumber"] = (object) cHome.Block;
                dataTable.Rows[index]["fldTel"] = (object) cHome.Tel;
                dataTable.Rows[index]["fldName"] = (object) cHome.Name;
                dataTable.Rows[index]["fldMobile"] = (object) cHome.Mobile;
                dataTable.Rows[index]["fldRent"] = (object) cHome.Rent;
                break;
              }
              checked { ++index; }
            }
            break;
        }
        this.Dispose();
      }
    }
  }

  private void txtRent_TextChanged(object sender)
  {
    if (!this.txtRent.Created || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtRent.Text, "", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtRent.Text, "مالك", false) != 0)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtName.Text, "", false) != 0)
      this.txtName1.Text = this.txtName.Text;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMobile.Text, "", false) != 0)
      this.txtMobile1.Text = this.txtMobile.Text;
  }
}
