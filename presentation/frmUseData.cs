// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmUseData
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
public class frmUseData : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtPrivateId")]
  private InputBox _txtPrivateId;
  [AccessedThroughProperty("txtNumber")]
  private InputBox _txtNumber;
  [AccessedThroughProperty("txtLastDigitCold")]
  private InputBox _txtLastDigitCold;
  [AccessedThroughProperty("txtNewDigitCold")]
  private InputBox _txtNewDigitCold;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtNewDigitHot")]
  private InputBox _txtNewDigitHot;
  [AccessedThroughProperty("txtLastDigitHot")]
  private InputBox _txtLastDigitHot;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("lblTotalCold")]
  private Label _lblTotalCold;
  [AccessedThroughProperty("lblTotalHot")]
  private Label _lblTotalHot;
  [AccessedThroughProperty("lblTotal")]
  private Label _lblTotal;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("llll")]
  private Label _llll;
  [AccessedThroughProperty("lblAverage")]
  private Label _lblAverage;
  [AccessedThroughProperty("lblPatternId")]
  private Label _lblPatternId;
  [AccessedThroughProperty("sdfsdf")]
  private Label _sdfsdf;
  [AccessedThroughProperty("lblPrice")]
  private Label _lblPrice;
  [AccessedThroughProperty("ddddd")]
  private Label _ddddd;
  [AccessedThroughProperty("lblPeriod")]
  private Label _lblPeriod;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("lblPriceUse")]
  private Label _lblPriceUse;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("lblTax")]
  private Label _lblTax;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("lblTotalPrice")]
  private Label _lblTotalPrice;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  public string PrPatternId;

  [DebuggerNonUserCode]
  static frmUseData()
  {
  }

  [DebuggerNonUserCode]
  public frmUseData()
  {
    this.Load += new EventHandler(this.frmUseData_Load);
    this.Shown += new EventHandler(this.SetDefaultValue);
    frmUseData.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmUseData.__ENCList)
    {
      if (frmUseData.__ENCList.Count == frmUseData.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmUseData.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmUseData.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmUseData.__ENCList[index1] = frmUseData.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmUseData.__ENCList.RemoveRange(index1, checked (frmUseData.__ENCList.Count - index1));
        frmUseData.__ENCList.Capacity = frmUseData.__ENCList.Count;
      }
      frmUseData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUseData));
    this.txtNewDigitCold = new InputBox();
    this.txtLastDigitCold = new InputBox();
    this.txtNumber = new InputBox();
    this.txtPrivateId = new InputBox();
    this.Label1 = new Label();
    this.txtNewDigitHot = new InputBox();
    this.txtLastDigitHot = new InputBox();
    this.Label2 = new Label();
    this.lblTotalCold = new Label();
    this.lblTotalHot = new Label();
    this.lblTotal = new Label();
    this.Label4 = new Label();
    this.llll = new Label();
    this.lblAverage = new Label();
    this.lblPatternId = new Label();
    this.sdfsdf = new Label();
    this.lblPrice = new Label();
    this.ddddd = new Label();
    this.lblPeriod = new Label();
    this.Label5 = new Label();
    this.lblPriceUse = new Label();
    this.Label7 = new Label();
    this.lblTax = new Label();
    this.Label9 = new Label();
    this.lblTotalPrice = new Label();
    this.Label11 = new Label();
    this.SuspendLayout();
    this.txtNewDigitCold.Alighment = HorizontalAlignment.Left;
    this.txtNewDigitCold.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtNewDigitCold.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtNewDigitCold.Button = inputButtonSettings1;
    this.txtNewDigitCold.ButtonDropDownEnable = true;
    this.txtNewDigitCold.ControlType = Enum_ControlType.TextBox;
    this.txtNewDigitCold.DefaultLanguge = Enum_Languge.English;
    this.txtNewDigitCold.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtNewDigitCold.InputValidation = Enum_InputValidation.Integer;
    this.txtNewDigitCold.Key = "";
    this.txtNewDigitCold.LabelForeColor = Color.Blue;
    this.txtNewDigitCold.LabelText = "ميزان مصرف فعلي آب سرد (ليتر)";
    InputBox txtNewDigitCold1 = this.txtNewDigitCold;
    Point point1 = new Point(84, 153);
    Point point2 = point1;
    txtNewDigitCold1.Location = point2;
    this.txtNewDigitCold.MaxLenght = 10;
    this.txtNewDigitCold.MinLenght = 0;
    this.txtNewDigitCold.Multiline = false;
    this.txtNewDigitCold.Name = "txtNewDigitCold";
    this.txtNewDigitCold.RangeDown = "";
    this.txtNewDigitCold.RangeUp = "";
    this.txtNewDigitCold.RequiredField = true;
    InputBox txtNewDigitCold2 = this.txtNewDigitCold;
    Size size1 = new Size(268, 24);
    Size size2 = size1;
    txtNewDigitCold2.Size = size2;
    this.txtNewDigitCold.TabIndex = 3;
    this.txtNewDigitCold.ToolTipText = "ميزان مصرف فعلي را در اين قسمت وارد نمائيد";
    this.txtNewDigitCold.UseSystemPasswordChar = false;
    this.txtNewDigitCold.WatermarkText = "";
    this.txtNewDigitCold.WriteType = Enum_WriteType.Defualt;
    this.txtLastDigitCold.Alighment = HorizontalAlignment.Left;
    this.txtLastDigitCold.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtLastDigitCold.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtLastDigitCold.Button = inputButtonSettings2;
    this.txtLastDigitCold.ButtonDropDownEnable = true;
    this.txtLastDigitCold.ControlType = Enum_ControlType.TextBox;
    this.txtLastDigitCold.DefaultLanguge = Enum_Languge.English;
    this.txtLastDigitCold.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtLastDigitCold.InputValidation = Enum_InputValidation.Integer;
    this.txtLastDigitCold.Key = "";
    this.txtLastDigitCold.LabelForeColor = Color.Blue;
    this.txtLastDigitCold.LabelText = "ميزان مصرف قبلي آب سرد (ليتر)";
    InputBox txtLastDigitCold1 = this.txtLastDigitCold;
    point1 = new Point(84, 123);
    Point point3 = point1;
    txtLastDigitCold1.Location = point3;
    this.txtLastDigitCold.MaxLenght = 10;
    this.txtLastDigitCold.MinLenght = 0;
    this.txtLastDigitCold.Multiline = false;
    this.txtLastDigitCold.Name = "txtLastDigitCold";
    this.txtLastDigitCold.RangeDown = "";
    this.txtLastDigitCold.RangeUp = "";
    this.txtLastDigitCold.RequiredField = true;
    InputBox txtLastDigitCold2 = this.txtLastDigitCold;
    size1 = new Size(266, 24);
    Size size3 = size1;
    txtLastDigitCold2.Size = size3;
    this.txtLastDigitCold.TabIndex = 2;
    this.txtLastDigitCold.ToolTipText = "ميزان مصرف قبلي را در اين قسمت وارد نمائيد";
    this.txtLastDigitCold.UseSystemPasswordChar = false;
    this.txtLastDigitCold.WatermarkText = "";
    this.txtLastDigitCold.WriteType = Enum_WriteType.Defualt;
    this.txtNumber.Alighment = HorizontalAlignment.Left;
    this.txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtNumber.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtNumber.Button = inputButtonSettings3;
    this.txtNumber.ButtonDropDownEnable = true;
    this.txtNumber.ControlType = Enum_ControlType.TextBox;
    this.txtNumber.DefaultLanguge = Enum_Languge.English;
    this.txtNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtNumber.InputValidation = Enum_InputValidation.Integer;
    this.txtNumber.Key = "";
    this.txtNumber.LabelForeColor = SystemColors.ControlText;
    this.txtNumber.LabelText = "شماره واحد";
    InputBox txtNumber1 = this.txtNumber;
    point1 = new Point(125, 93);
    Point point4 = point1;
    txtNumber1.Location = point4;
    this.txtNumber.MaxLenght = 3;
    this.txtNumber.MinLenght = 1;
    this.txtNumber.Multiline = false;
    this.txtNumber.Name = "txtNumber";
    this.txtNumber.RangeDown = "0";
    this.txtNumber.RangeUp = "999";
    this.txtNumber.RequiredField = true;
    InputBox txtNumber2 = this.txtNumber;
    size1 = new Size(128 /*0x80*/, 24);
    Size size4 = size1;
    txtNumber2.Size = size4;
    this.txtNumber.TabIndex = 1;
    this.txtNumber.ToolTipText = "شماره واحد را در اين قسمت وارد نمائيد";
    this.txtNumber.UseSystemPasswordChar = false;
    this.txtNumber.WatermarkText = "";
    this.txtNumber.WriteType = Enum_WriteType.Defualt;
    this.txtPrivateId.Alighment = HorizontalAlignment.Left;
    this.txtPrivateId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPrivateId.BackColor = Color.Transparent;
    inputButtonSettings4.DisplayPosition = 1;
    inputButtonSettings4.Enabled = false;
    this.txtPrivateId.Button = inputButtonSettings4;
    this.txtPrivateId.ButtonDropDownEnable = true;
    this.txtPrivateId.ControlType = Enum_ControlType.TextBox;
    this.txtPrivateId.DefaultLanguge = Enum_Languge.English;
    this.txtPrivateId.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPrivateId.InputValidation = Enum_InputValidation.Integer;
    this.txtPrivateId.Key = "";
    this.txtPrivateId.LabelForeColor = SystemColors.ControlText;
    this.txtPrivateId.LabelText = "دوره مصرف";
    InputBox txtPrivateId1 = this.txtPrivateId;
    point1 = new Point(125, 63 /*0x3F*/);
    Point point5 = point1;
    txtPrivateId1.Location = point5;
    this.txtPrivateId.MaxLenght = (int) short.MaxValue;
    this.txtPrivateId.MinLenght = 0;
    this.txtPrivateId.Multiline = false;
    this.txtPrivateId.Name = "txtPrivateId";
    this.txtPrivateId.RangeDown = "";
    this.txtPrivateId.RangeUp = "";
    this.txtPrivateId.RequiredField = true;
    InputBox txtPrivateId2 = this.txtPrivateId;
    size1 = new Size(126, 24);
    Size size5 = size1;
    txtPrivateId2.Size = size5;
    this.txtPrivateId.TabIndex = 0;
    this.txtPrivateId.ToolTipText = "اطلاعات دوره مصرف را در اين قسمت وارد نمائيد";
    this.txtPrivateId.UseSystemPasswordChar = false;
    this.txtPrivateId.WatermarkText = "";
    this.txtPrivateId.WriteType = Enum_WriteType.Defualt;
    this.Label1.AutoSize = true;
    this.Label1.ForeColor = Color.Blue;
    Label label1_1 = this.Label1;
    point1 = new Point(166, 185);
    Point point6 = point1;
    label1_1.Location = point6;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(125, 13);
    Size size6 = size1;
    label1_2.Size = size6;
    this.Label1.TabIndex = 8;
    this.Label1.Text = "مصرف دوره آب سرد (ليتر)";
    this.txtNewDigitHot.Alighment = HorizontalAlignment.Left;
    this.txtNewDigitHot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtNewDigitHot.BackColor = Color.Transparent;
    inputButtonSettings5.DisplayPosition = 1;
    inputButtonSettings5.Enabled = false;
    this.txtNewDigitHot.Button = inputButtonSettings5;
    this.txtNewDigitHot.ButtonDropDownEnable = true;
    this.txtNewDigitHot.ControlType = Enum_ControlType.TextBox;
    this.txtNewDigitHot.DefaultLanguge = Enum_Languge.English;
    this.txtNewDigitHot.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtNewDigitHot.InputValidation = Enum_InputValidation.Integer;
    this.txtNewDigitHot.Key = "";
    this.txtNewDigitHot.LabelForeColor = Color.Red;
    this.txtNewDigitHot.LabelText = "ميزان مصرف فعلي آب گرم (ليتر)";
    InputBox txtNewDigitHot1 = this.txtNewDigitHot;
    point1 = new Point(84, 235);
    Point point7 = point1;
    txtNewDigitHot1.Location = point7;
    this.txtNewDigitHot.MaxLenght = 10;
    this.txtNewDigitHot.MinLenght = 0;
    this.txtNewDigitHot.Multiline = false;
    this.txtNewDigitHot.Name = "txtNewDigitHot";
    this.txtNewDigitHot.RangeDown = "";
    this.txtNewDigitHot.RangeUp = "";
    this.txtNewDigitHot.RequiredField = true;
    InputBox txtNewDigitHot2 = this.txtNewDigitHot;
    size1 = new Size(264, 24);
    Size size7 = size1;
    txtNewDigitHot2.Size = size7;
    this.txtNewDigitHot.TabIndex = 5;
    this.txtNewDigitHot.ToolTipText = "ميزان مصرف فعلي را در اين قسمت وارد نمائيد";
    this.txtNewDigitHot.UseSystemPasswordChar = false;
    this.txtNewDigitHot.WatermarkText = "";
    this.txtNewDigitHot.WriteType = Enum_WriteType.Defualt;
    this.txtLastDigitHot.Alighment = HorizontalAlignment.Left;
    this.txtLastDigitHot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtLastDigitHot.BackColor = Color.Transparent;
    inputButtonSettings6.DisplayPosition = 1;
    inputButtonSettings6.Enabled = false;
    this.txtLastDigitHot.Button = inputButtonSettings6;
    this.txtLastDigitHot.ButtonDropDownEnable = true;
    this.txtLastDigitHot.ControlType = Enum_ControlType.TextBox;
    this.txtLastDigitHot.DefaultLanguge = Enum_Languge.English;
    this.txtLastDigitHot.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtLastDigitHot.InputValidation = Enum_InputValidation.Integer;
    this.txtLastDigitHot.Key = "";
    this.txtLastDigitHot.LabelForeColor = Color.Red;
    this.txtLastDigitHot.LabelText = "ميزان مصرف قبلي آب گرم (ليتر)";
    InputBox txtLastDigitHot1 = this.txtLastDigitHot;
    point1 = new Point(84, 205);
    Point point8 = point1;
    txtLastDigitHot1.Location = point8;
    this.txtLastDigitHot.MaxLenght = 10;
    this.txtLastDigitHot.MinLenght = 0;
    this.txtLastDigitHot.Multiline = false;
    this.txtLastDigitHot.Name = "txtLastDigitHot";
    this.txtLastDigitHot.RangeDown = "";
    this.txtLastDigitHot.RangeUp = "";
    this.txtLastDigitHot.RequiredField = true;
    InputBox txtLastDigitHot2 = this.txtLastDigitHot;
    size1 = new Size(262, 24);
    Size size8 = size1;
    txtLastDigitHot2.Size = size8;
    this.txtLastDigitHot.TabIndex = 4;
    this.txtLastDigitHot.ToolTipText = "ميزان مصرف قبلي را در اين قسمت وارد نمائيد";
    this.txtLastDigitHot.UseSystemPasswordChar = false;
    this.txtLastDigitHot.WatermarkText = "";
    this.txtLastDigitHot.WriteType = Enum_WriteType.Defualt;
    this.Label2.AutoSize = true;
    this.Label2.ForeColor = Color.Red;
    Label label2_1 = this.Label2;
    point1 = new Point(166, 272);
    Point point9 = point1;
    label2_1.Location = point9;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(121, 13);
    Size size9 = size1;
    label2_2.Size = size9;
    this.Label2.TabIndex = 11;
    this.Label2.Text = "مصرف دوره آب گرم (ليتر)";
    this.lblTotalCold.ForeColor = Color.Blue;
    Label lblTotalCold1 = this.lblTotalCold;
    point1 = new Point(35, 185);
    Point point10 = point1;
    lblTotalCold1.Location = point10;
    this.lblTotalCold.Name = "lblTotalCold";
    Label lblTotalCold2 = this.lblTotalCold;
    size1 = new Size(125, 13);
    Size size10 = size1;
    lblTotalCold2.Size = size10;
    this.lblTotalCold.TabIndex = 12;
    this.lblTotalHot.ForeColor = Color.Red;
    Label lblTotalHot1 = this.lblTotalHot;
    point1 = new Point(35, 272);
    Point point11 = point1;
    lblTotalHot1.Location = point11;
    this.lblTotalHot.Name = "lblTotalHot";
    Label lblTotalHot2 = this.lblTotalHot;
    size1 = new Size(125, 13);
    Size size11 = size1;
    lblTotalHot2.Size = size11;
    this.lblTotalHot.TabIndex = 13;
    this.lblTotal.ForeColor = Color.Black;
    Label lblTotal1 = this.lblTotal;
    point1 = new Point(35, 301);
    Point point12 = point1;
    lblTotal1.Location = point12;
    this.lblTotal.Name = "lblTotal";
    Label lblTotal2 = this.lblTotal;
    size1 = new Size(125, 13);
    Size size12 = size1;
    lblTotal2.Size = size12;
    this.lblTotal.TabIndex = 15;
    this.Label4.AutoSize = true;
    this.Label4.ForeColor = Color.Black;
    Label label4_1 = this.Label4;
    point1 = new Point(166, 301);
    Point point13 = point1;
    label4_1.Location = point13;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(95, 13);
    Size size13 = size1;
    label4_2.Size = size13;
    this.Label4.TabIndex = 14;
    this.Label4.Text = "مصرف كل آب (ليتر)";
    this.llll.AutoSize = true;
    this.llll.ForeColor = Color.Black;
    Label llll1 = this.llll;
    point1 = new Point(166, 328);
    Point point14 = point1;
    llll1.Location = point14;
    this.llll.Name = "llll";
    Label llll2 = this.llll;
    size1 = new Size(130, 13);
    Size size14 = size1;
    llll2.Size = size14;
    this.llll.TabIndex = 16 /*0x10*/;
    this.llll.Text = "ميانگين مصرف (ليتر در ماه)";
    this.lblAverage.ForeColor = Color.Black;
    Label lblAverage1 = this.lblAverage;
    point1 = new Point(35, 328);
    Point point15 = point1;
    lblAverage1.Location = point15;
    this.lblAverage.Name = "lblAverage";
    Label lblAverage2 = this.lblAverage;
    size1 = new Size(125, 13);
    Size size15 = size1;
    lblAverage2.Size = size15;
    this.lblAverage.TabIndex = 17;
    this.lblPatternId.ForeColor = Color.Black;
    Label lblPatternId1 = this.lblPatternId;
    point1 = new Point(35, 355);
    Point point16 = point1;
    lblPatternId1.Location = point16;
    this.lblPatternId.Name = "lblPatternId";
    Label lblPatternId2 = this.lblPatternId;
    size1 = new Size(125, 13);
    Size size16 = size1;
    lblPatternId2.Size = size16;
    this.lblPatternId.TabIndex = 19;
    this.sdfsdf.AutoSize = true;
    this.sdfsdf.ForeColor = Color.Black;
    Label sdfsdf1 = this.sdfsdf;
    point1 = new Point(166, 355);
    Point point17 = point1;
    sdfsdf1.Location = point17;
    this.sdfsdf.Name = "sdfsdf";
    Label sdfsdf2 = this.sdfsdf;
    size1 = new Size(53, 13);
    Size size17 = size1;
    sdfsdf2.Size = size17;
    this.sdfsdf.TabIndex = 18;
    this.sdfsdf.Text = "پله مصرف";
    this.lblPrice.ForeColor = Color.Black;
    Label lblPrice1 = this.lblPrice;
    point1 = new Point(35, 380);
    Point point18 = point1;
    lblPrice1.Location = point18;
    this.lblPrice.Name = "lblPrice";
    Label lblPrice2 = this.lblPrice;
    size1 = new Size(125, 13);
    Size size18 = size1;
    lblPrice2.Size = size18;
    this.lblPrice.TabIndex = 21;
    this.ddddd.AutoSize = true;
    this.ddddd.ForeColor = Color.Black;
    Label ddddd1 = this.ddddd;
    point1 = new Point(166, 380);
    Point point19 = point1;
    ddddd1.Location = point19;
    this.ddddd.Name = "ddddd";
    Label ddddd2 = this.ddddd;
    size1 = new Size(136, 13);
    Size size19 = size1;
    ddddd2.Size = size19;
    this.ddddd.TabIndex = 20;
    this.ddddd.Text = "مبلغ آب بهاي يك ماهه (ريال)";
    this.lblPeriod.ForeColor = Color.Black;
    Label lblPeriod1 = this.lblPeriod;
    point1 = new Point(35, 407);
    Point point20 = point1;
    lblPeriod1.Location = point20;
    this.lblPeriod.Name = "lblPeriod";
    Label lblPeriod2 = this.lblPeriod;
    size1 = new Size(125, 13);
    Size size20 = size1;
    lblPeriod2.Size = size20;
    this.lblPeriod.TabIndex = 23;
    this.Label5.AutoSize = true;
    this.Label5.ForeColor = Color.Black;
    Label label5_1 = this.Label5;
    point1 = new Point(166, 407);
    Point point21 = point1;
    label5_1.Location = point21;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(72, 13);
    Size size21 = size1;
    label5_2.Size = size21;
    this.Label5.TabIndex = 22;
    this.Label5.Text = "طول دوره (روز)";
    this.lblPriceUse.ForeColor = Color.Black;
    Label lblPriceUse1 = this.lblPriceUse;
    point1 = new Point(35, 432);
    Point point22 = point1;
    lblPriceUse1.Location = point22;
    this.lblPriceUse.Name = "lblPriceUse";
    Label lblPriceUse2 = this.lblPriceUse;
    size1 = new Size(125, 13);
    Size size22 = size1;
    lblPriceUse2.Size = size22;
    this.lblPriceUse.TabIndex = 25;
    this.Label7.AutoSize = true;
    this.Label7.ForeColor = Color.Black;
    Label label7_1 = this.Label7;
    point1 = new Point(166, 432);
    Point point23 = point1;
    label7_1.Location = point23;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(59, 13);
    Size size23 = size1;
    label7_2.Size = size23;
    this.Label7.TabIndex = 24;
    this.Label7.Text = "آب بها(ريال)";
    this.lblTax.ForeColor = Color.Black;
    Label lblTax1 = this.lblTax;
    point1 = new Point(35, 457);
    Point point24 = point1;
    lblTax1.Location = point24;
    this.lblTax.Name = "lblTax";
    Label lblTax2 = this.lblTax;
    size1 = new Size(125, 13);
    Size size24 = size1;
    lblTax2.Size = size24;
    this.lblTax.TabIndex = 27;
    this.Label9.AutoSize = true;
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(166, 457);
    Point point25 = point1;
    label9_1.Location = point25;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size25 = size1;
    label9_2.Size = size25;
    this.Label9.TabIndex = 26;
    this.Label9.Text = "ماليات (ريال)";
    this.lblTotalPrice.ForeColor = Color.Black;
    Label lblTotalPrice1 = this.lblTotalPrice;
    point1 = new Point(35, 486);
    Point point26 = point1;
    lblTotalPrice1.Location = point26;
    this.lblTotalPrice.Name = "lblTotalPrice";
    Label lblTotalPrice2 = this.lblTotalPrice;
    size1 = new Size(125, 13);
    Size size26 = size1;
    lblTotalPrice2.Size = size26;
    this.lblTotalPrice.TabIndex = 29;
    this.Label11.AutoSize = true;
    this.Label11.ForeColor = Color.Black;
    Label label11_1 = this.Label11;
    point1 = new Point(166, 486);
    Point point27 = point1;
    label11_1.Location = point27;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(90, 13);
    Size size27 = size1;
    label11_2.Size = size27;
    this.Label11.TabIndex = 28;
    this.Label11.Text = "قابل پرداخت (ريال)";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(366, 508);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblTotalPrice);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.lblTax);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.lblPriceUse);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.lblPeriod);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.lblPrice);
    this.Controls.Add((Control) this.ddddd);
    this.Controls.Add((Control) this.lblPatternId);
    this.Controls.Add((Control) this.sdfsdf);
    this.Controls.Add((Control) this.lblAverage);
    this.Controls.Add((Control) this.llll);
    this.Controls.Add((Control) this.lblTotal);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblTotalHot);
    this.Controls.Add((Control) this.lblTotalCold);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtNewDigitHot);
    this.Controls.Add((Control) this.txtLastDigitHot);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtNewDigitCold);
    this.Controls.Add((Control) this.txtLastDigitCold);
    this.Controls.Add((Control) this.txtNumber);
    this.Controls.Add((Control) this.txtPrivateId);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmUseData);
    this.Text = nameof (frmUseData);
    this.Controls.SetChildIndex((Control) this.txtPrivateId, 0);
    this.Controls.SetChildIndex((Control) this.txtNumber, 0);
    this.Controls.SetChildIndex((Control) this.txtLastDigitCold, 0);
    this.Controls.SetChildIndex((Control) this.txtNewDigitCold, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.txtLastDigitHot, 0);
    this.Controls.SetChildIndex((Control) this.txtNewDigitHot, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    this.Controls.SetChildIndex((Control) this.lblTotalCold, 0);
    this.Controls.SetChildIndex((Control) this.lblTotalHot, 0);
    this.Controls.SetChildIndex((Control) this.Label4, 0);
    this.Controls.SetChildIndex((Control) this.lblTotal, 0);
    this.Controls.SetChildIndex((Control) this.llll, 0);
    this.Controls.SetChildIndex((Control) this.lblAverage, 0);
    this.Controls.SetChildIndex((Control) this.sdfsdf, 0);
    this.Controls.SetChildIndex((Control) this.lblPatternId, 0);
    this.Controls.SetChildIndex((Control) this.ddddd, 0);
    this.Controls.SetChildIndex((Control) this.lblPrice, 0);
    this.Controls.SetChildIndex((Control) this.Label5, 0);
    this.Controls.SetChildIndex((Control) this.lblPeriod, 0);
    this.Controls.SetChildIndex((Control) this.Label7, 0);
    this.Controls.SetChildIndex((Control) this.lblPriceUse, 0);
    this.Controls.SetChildIndex((Control) this.Label9, 0);
    this.Controls.SetChildIndex((Control) this.lblTax, 0);
    this.Controls.SetChildIndex((Control) this.Label11, 0);
    this.Controls.SetChildIndex((Control) this.lblTotalPrice, 0);
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual InputBox txtNumber
  {
    [DebuggerNonUserCode] get => this._txtNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = new InputBox.TextChangedEventHandler(this.SetLastDigit);
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtNumber != null)
      {
        this._txtNumber.TextChanged -= changedEventHandler;
        this._txtNumber.IsValidChange -= changeEventHandler;
      }
      this._txtNumber = value;
      if (this._txtNumber == null)
        return;
      this._txtNumber.TextChanged += changedEventHandler;
      this._txtNumber.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtLastDigitCold
  {
    [DebuggerNonUserCode] get => this._txtLastDigitCold;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.CalculateDeffCold());
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtLastDigitCold != null)
      {
        this._txtLastDigitCold.TextChanged -= changedEventHandler;
        this._txtLastDigitCold.IsValidChange -= changeEventHandler;
      }
      this._txtLastDigitCold = value;
      if (this._txtLastDigitCold == null)
        return;
      this._txtLastDigitCold.TextChanged += changedEventHandler;
      this._txtLastDigitCold.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtNewDigitCold
  {
    [DebuggerNonUserCode] get => this._txtNewDigitCold;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.CalculateDeffCold());
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtNewDigitCold != null)
      {
        this._txtNewDigitCold.TextChanged -= changedEventHandler;
        this._txtNewDigitCold.IsValidChange -= changeEventHandler;
      }
      this._txtNewDigitCold = value;
      if (this._txtNewDigitCold == null)
        return;
      this._txtNewDigitCold.TextChanged += changedEventHandler;
      this._txtNewDigitCold.IsValidChange += changeEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual InputBox txtNewDigitHot
  {
    [DebuggerNonUserCode] get => this._txtNewDigitHot;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.CalculateDeffHot());
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtNewDigitHot != null)
      {
        this._txtNewDigitHot.TextChanged -= changedEventHandler;
        this._txtNewDigitHot.IsValidChange -= changeEventHandler;
      }
      this._txtNewDigitHot = value;
      if (this._txtNewDigitHot == null)
        return;
      this._txtNewDigitHot.TextChanged += changedEventHandler;
      this._txtNewDigitHot.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtLastDigitHot
  {
    [DebuggerNonUserCode] get => this._txtLastDigitHot;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.CalculateDeffHot());
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtLastDigitHot != null)
      {
        this._txtLastDigitHot.TextChanged -= changedEventHandler;
        this._txtLastDigitHot.IsValidChange -= changeEventHandler;
      }
      this._txtLastDigitHot = value;
      if (this._txtLastDigitHot == null)
        return;
      this._txtLastDigitHot.TextChanged += changedEventHandler;
      this._txtLastDigitHot.IsValidChange += changeEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label lblTotalCold
  {
    [DebuggerNonUserCode] get => this._lblTotalCold;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.CalculateTotalUse());
      if (this._lblTotalCold != null)
        this._lblTotalCold.TextChanged -= eventHandler;
      this._lblTotalCold = value;
      if (this._lblTotalCold == null)
        return;
      this._lblTotalCold.TextChanged += eventHandler;
    }
  }

  internal virtual Label lblTotalHot
  {
    [DebuggerNonUserCode] get => this._lblTotalHot;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.CalculateTotalUse());
      if (this._lblTotalHot != null)
        this._lblTotalHot.TextChanged -= eventHandler;
      this._lblTotalHot = value;
      if (this._lblTotalHot == null)
        return;
      this._lblTotalHot.TextChanged += eventHandler;
    }
  }

  internal virtual Label lblTotal
  {
    [DebuggerNonUserCode] get => this._lblTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.CalculateAverage());
      if (this._lblTotal != null)
        this._lblTotal.TextChanged -= eventHandler;
      this._lblTotal = value;
      if (this._lblTotal == null)
        return;
      this._lblTotal.TextChanged += eventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label llll
  {
    [DebuggerNonUserCode] get => this._llll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._llll = value;
  }

  internal virtual Label lblAverage
  {
    [DebuggerNonUserCode] get => this._lblAverage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAverage = value;
    }
  }

  internal virtual Label lblPatternId
  {
    [DebuggerNonUserCode] get => this._lblPatternId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPatternId = value;
    }
  }

  internal virtual Label sdfsdf
  {
    [DebuggerNonUserCode] get => this._sdfsdf;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._sdfsdf = value;
  }

  internal virtual Label lblPrice
  {
    [DebuggerNonUserCode] get => this._lblPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.SetPriceUse());
      if (this._lblPrice != null)
        this._lblPrice.TextChanged -= eventHandler;
      this._lblPrice = value;
      if (this._lblPrice == null)
        return;
      this._lblPrice.TextChanged += eventHandler;
    }
  }

  internal virtual Label ddddd
  {
    [DebuggerNonUserCode] get => this._ddddd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ddddd = value;
  }

  internal virtual Label lblPeriod
  {
    [DebuggerNonUserCode] get => this._lblPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPeriod = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label lblPriceUse
  {
    [DebuggerNonUserCode] get => this._lblPriceUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPriceUse = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label lblTax
  {
    [DebuggerNonUserCode] get => this._lblTax;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTax = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label lblTotalPrice
  {
    [DebuggerNonUserCode] get => this._lblTotalPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalPrice = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
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
    cUse cUse = new cUse();
    cUse.PrivateId = this.txtPrivateId.Text;
    cUse.Number = this.txtNumber.Text;
    cUse.LastDigitCold = this.txtLastDigitCold.Text;
    cUse.NewDigitCold = this.txtNewDigitCold.Text;
    cUse.LastDigitHot = this.txtLastDigitHot.Text;
    cUse.NewDigitHot = this.txtNewDigitHot.Text;
    cUse.PatternId = this.PrPatternId;
    this.FormParent.obj1 = this.txtPrivateId.Text;
    this.FormParent.obj2 = Conversions.ToString(Conversion.Val(this.txtNumber.Text) + 1.0);
    bool flag = true;
    switch (this.FormType)
    {
      case Enum_ToolbarButtons.New:
        flag = cUse.Add();
        break;
      case Enum_ToolbarButtons.Edit:
        cUse.Identity = this.FormValue;
        flag = cUse.Edit();
        break;
    }
    if (!flag)
    {
      string BodyText = cUse.ErrorMessage;
      if (cUse.ErrorDescription.Contains("'fldPeriodUseId'"))
      {
        BodyText = "شماره دوره وارد شده اشتباه ميباشد. اين شماره دوره يافت نشد";
        this.txtPrivateId.Focus();
      }
      else if (cUse.ErrorDescription.Contains("'fldHomeId'"))
      {
        BodyText = "شماره واحد وارد شده اشتباه ميباشد. اين شماره واحد يافت نشد";
        this.txtNumber.Focus();
      }
      else if (cUse.ErrorDescription.Contains("UQ_fldPeriodUseIdfldHomeId_tblUse"))
      {
        BodyText = "براي اين واحد در دوره مورد نظر اطلاعات ثبت شده است . شما مجاز به ثبت مجدد نميباشيد";
        this.txtNumber.Focus();
      }
      int num = (int) MessageBoxMPS.show((Form) this, BodyText, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cUse.ErrorDescription);
      this.buttAdd.Enabled = true;
    }
    else
    {
      switch (this.FormType)
      {
        case Enum_ToolbarButtons.New:
          DataRow row = this.FormParent.DataTable.NewRow();
          row["fldUseId"] = (object) cUse.Identity;
          row["fldPrivateIdPeriodUse"] = (object) cUse.PrivateId;
          row["fldNumber"] = (object) cUse.Number;
          row["fldTotalUseCold"] = (object) (Conversion.Val(cUse.NewDigitCold) - Conversion.Val(cUse.LastDigitCold));
          row["fldTotalUseHot"] = (object) (Conversion.Val(cUse.NewDigitHot) - Conversion.Val(cUse.LastDigitHot));
          if (Versioned.IsNumeric((object) this.lblPatternId.Text))
            row["fldPrivateIdPattern"] = (object) this.lblPatternId.Text;
          this.FormParent.DataTable.Rows.Add(row);
          break;
        case Enum_ToolbarButtons.Edit:
          DataTable dataTable = this.FormParent.DataTable;
          int num = checked (dataTable.Rows.Count - 1);
          int index = 0;
          while (index <= num)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataTable.Rows[index][0], (object) cUse.Identity, false))
            {
              dataTable.Rows[index]["fldUseId"] = (object) cUse.Identity;
              dataTable.Rows[index]["fldPrivateIdPeriodUse"] = (object) cUse.PrivateId;
              dataTable.Rows[index]["fldNumber"] = (object) cUse.Number;
              dataTable.Rows[index]["fldTotalUseCold"] = (object) (Conversion.Val(cUse.NewDigitCold) - Conversion.Val(cUse.LastDigitCold));
              dataTable.Rows[index]["fldTotalUseHot"] = (object) (Conversion.Val(cUse.NewDigitHot) - Conversion.Val(cUse.LastDigitHot));
              if (Versioned.IsNumeric((object) this.lblPatternId.Text))
              {
                dataTable.Rows[index]["fldPrivateIdPattern"] = (object) this.lblPatternId.Text;
                break;
              }
              break;
            }
            checked { ++index; }
          }
          break;
      }
      this.Dispose();
    }
  }

  private void SetDefaultValue(object sender, EventArgs e)
  {
    if (this.FormType != Enum_ToolbarButtons.New)
      return;
    this.txtPrivateId.Text = this.FormParent.obj1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPrivateId.Text, "", false) != 0)
    {
      this.SetPeriod();
      this.txtNumber.Focus();
    }
    this.txtPrivateId.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.SetPeriod());
    this.txtNumber.Text = this.FormParent.obj2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNumber.Text, "", false) != 0)
      this.txtLastDigitCold.Focus();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLastDigitCold.Text, "", false) == 0)
      return;
    this.txtNewDigitCold.Focus();
  }

  private void SetPeriod()
  {
    if (this.FormType != Enum_ToolbarButtons.New || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPrivateId.Text, "", false) == 0)
      return;
    cPeriodUse cPeriodUse = new cPeriodUse();
    cPeriodUse.Number = this.txtPrivateId.Text;
    cPeriodUse.GetPeriod();
    this.lblPeriod.Text = cPeriodUse.Period;
  }

  private void SetLastDigit(object sender)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNumber.Text, "", false) == 0)
      return;
    cUse cUse = new cUse();
    cUse.Number = this.txtNumber.Text;
    if (cUse.GetLastUse())
    {
      this.txtLastDigitCold.Text = cUse.LastDigitCold;
      this.txtLastDigitHot.Text = cUse.LastDigitHot;
    }
  }

  private void CalculateDeffCold()
  {
    this.lblTotalCold.Text = Conversions.ToString(Conversion.Val(this.txtNewDigitCold.Text) - Conversion.Val(this.txtLastDigitCold.Text));
  }

  private void CalculateDeffHot()
  {
    this.lblTotalHot.Text = Conversions.ToString(Conversion.Val(this.txtNewDigitHot.Text) - Conversion.Val(this.txtLastDigitHot.Text));
  }

  private void CalculateTotalUse()
  {
    this.lblTotal.Text = Conversions.ToString(Conversion.Val(this.lblTotalCold.Text) + Conversion.Val(this.lblTotalHot.Text));
  }

  private void CalculateAverage()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblPeriod.Text, "", false) == 0)
      this.lblAverage.Text = "";
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTotal.Text, "", false) == 0)
      this.lblAverage.Text = "";
    else
      this.lblAverage.Text = (checked ((int) Math.Round(unchecked (Conversion.Val(this.lblTotal.Text) / Conversion.Val(this.lblPeriod.Text) * 30.0)))).ToString();
  }

  public void FindPattern()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAverage.Text, "", false) == 0)
    {
      this.lblPatternId.Text = "";
      this.PrPatternId = "";
      this.lblPrice.Text = "";
    }
    else
    {
      cPattern cPattern = new cPattern();
      cPattern.ToDigit = this.lblAverage.Text;
      cPattern.GetPattern();
      this.PrPatternId = Conversions.ToString(cPattern.Identity);
      this.lblPatternId.Text = cPattern.PrivateId;
      this.lblPrice.Text = cFormat.Currency((checked ((int) Math.Round(Conversion.Val(cPattern.Price)))).ToString());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cPattern.PrivateId, "", false) == 0)
      {
        this.PrPatternId = "";
        this.lblPatternId.Text = "!";
        this.lblPrice.Text = cFormat.Currency((checked ((int) Math.Round(unchecked (56625.0 * (Conversion.Val(this.lblAverage.Text) / 1000.0) - 2311016.0)))).ToString());
      }
    }
  }

  private void SetPriceUse()
  {
    int num1 = checked ((int) Math.Round(unchecked (Conversion.Val(this.lblPeriod.Text) * Conversion.Val(cConvert.CurrencyToDigit(this.lblPrice.Text)) / 30.0)));
    int num2 = checked ((int) Math.Round(unchecked ((double) num1 * 0.04)));
    int num3 = checked (num1 + num2);
    this.lblPriceUse.Text = cFormat.Currency(num1.ToString());
    this.lblTax.Text = cFormat.Currency(num2.ToString());
    this.lblTotalPrice.Text = cFormat.Currency(num3.ToString());
  }

  private void frmUseData_Load(object sender, EventArgs e)
  {
  }
}
