// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmFinalBillData
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer;

[DesignerGenerated]
public class frmFinalBillData : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("txtBillId")]
  private InputBox _txtBillId;
  [AccessedThroughProperty("lblPeriodBill")]
  private Label _lblPeriodBill;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("lblTodateBill")]
  private Label _lblTodateBill;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("lblFromDateBill")]
  private Label _lblFromDateBill;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("lblPeriod")]
  private Label _lblPeriod;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("lblToDate")]
  private Label _lblToDate;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("lblFromDate")]
  private Label _lblFromDate;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("lblNumber")]
  private Label _lblNumber;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("lblTel")]
  private Label _lblTel;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("lblName")]
  private Label _lblName;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("lblBlockNumber")]
  private Label _lblBlockNumber;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("txtPeriodUse")]
  private InputBox _txtPeriodUse;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("lblTotalUseCold")]
  private Label _lblTotalUseCold;
  [AccessedThroughProperty("lblTotalUse")]
  private Label _lblTotalUse;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("lblTotalUseHot")]
  private Label _lblTotalUseHot;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("lblPrice")]
  private Label _lblPrice;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("lblTotalPrice")]
  private Label _lblTotalPrice;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("lblTax")]
  private Label _lblTax;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("lblAverageUse")]
  private Label _lblAverageUse;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("lblAveragePrice")]
  private Label _lblAveragePrice;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("lblPatternId")]
  private Label _lblPatternId;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("GroupBox6")]
  private GroupBox _GroupBox6;
  [AccessedThroughProperty("lblIncreaser")]
  private Label _lblIncreaser;
  [AccessedThroughProperty("Label40")]
  private Label _Label40;
  [AccessedThroughProperty("lblTotalRealPrice")]
  private Label _lblTotalRealPrice;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("lblSharedPrice")]
  private Label _lblSharedPrice;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("lblRealPrice")]
  private Label _lblRealPrice;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("GroupBox7")]
  private GroupBox _GroupBox7;
  [AccessedThroughProperty("txtDescription")]
  private InputBox _txtDescription;
  [AccessedThroughProperty("lblRoundPrice")]
  private Label _lblRoundPrice;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("lblTotal")]
  private Label _lblTotal;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;

  [DebuggerNonUserCode]
  static frmFinalBillData()
  {
  }

  [DebuggerNonUserCode]
  public frmFinalBillData()
  {
    frmFinalBillData.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmFinalBillData.__ENCList)
    {
      if (frmFinalBillData.__ENCList.Count == frmFinalBillData.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmFinalBillData.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmFinalBillData.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmFinalBillData.__ENCList[index1] = frmFinalBillData.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmFinalBillData.__ENCList.RemoveRange(index1, checked (frmFinalBillData.__ENCList.Count - index1));
        frmFinalBillData.__ENCList.Capacity = frmFinalBillData.__ENCList.Count;
      }
      frmFinalBillData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFinalBillData));
    this.GroupBox1 = new GroupBox();
    this.lblPeriod = new Label();
    this.Label11 = new Label();
    this.lblToDate = new Label();
    this.Label3 = new Label();
    this.lblFromDate = new Label();
    this.Label7 = new Label();
    this.txtPeriodUse = new InputBox();
    this.GroupBox2 = new GroupBox();
    this.lblPeriodBill = new Label();
    this.Label6 = new Label();
    this.lblTodateBill = new Label();
    this.Label4 = new Label();
    this.lblFromDateBill = new Label();
    this.Label1 = new Label();
    this.txtBillId = new InputBox();
    this.GroupBox3 = new GroupBox();
    this.lblNumber = new Label();
    this.Label10 = new Label();
    this.lblTel = new Label();
    this.Label23 = new Label();
    this.lblName = new Label();
    this.Label25 = new Label();
    this.lblBlockNumber = new Label();
    this.Label27 = new Label();
    this.GroupBox4 = new GroupBox();
    this.Label12 = new Label();
    this.lblTotalUseCold = new Label();
    this.lblTotalUse = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.lblTotalUseHot = new Label();
    this.GroupBox5 = new GroupBox();
    this.lblPrice = new Label();
    this.Label28 = new Label();
    this.lblTotalPrice = new Label();
    this.Label30 = new Label();
    this.lblTax = new Label();
    this.Label32 = new Label();
    this.lblAverageUse = new Label();
    this.Label16 = new Label();
    this.lblAveragePrice = new Label();
    this.Label18 = new Label();
    this.lblPatternId = new Label();
    this.Label20 = new Label();
    this.GroupBox6 = new GroupBox();
    this.lblIncreaser = new Label();
    this.Label40 = new Label();
    this.lblTotalRealPrice = new Label();
    this.Label34 = new Label();
    this.lblSharedPrice = new Label();
    this.Label36 = new Label();
    this.lblRealPrice = new Label();
    this.Label38 = new Label();
    this.GroupBox7 = new GroupBox();
    this.txtDescription = new InputBox();
    this.lblTotal = new Label();
    this.Label5 = new Label();
    this.lblRoundPrice = new Label();
    this.Label9 = new Label();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox4.SuspendLayout();
    this.GroupBox5.SuspendLayout();
    this.GroupBox6.SuspendLayout();
    this.GroupBox7.SuspendLayout();
    this.SuspendLayout();
    this.GroupBox1.Controls.Add((Control) this.lblPeriod);
    this.GroupBox1.Controls.Add((Control) this.Label11);
    this.GroupBox1.Controls.Add((Control) this.lblToDate);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.lblFromDate);
    this.GroupBox1.Controls.Add((Control) this.Label7);
    this.GroupBox1.Controls.Add((Control) this.txtPeriodUse);
    GroupBox groupBox1_1 = this.GroupBox1;
    Point point1 = new Point(322, 41);
    Point point2 = point1;
    groupBox1_1.Location = point2;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    Size size1 = new Size(319, 166);
    Size size2 = size1;
    groupBox1_2.Size = size2;
    this.GroupBox1.TabIndex = 9;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "اطلاعات دوره كنترخواني";
    this.lblPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblPeriod1 = this.lblPeriod;
    point1 = new Point(16 /*0x10*/, 122);
    Point point3 = point1;
    lblPeriod1.Location = point3;
    this.lblPeriod.Name = "lblPeriod";
    Label lblPeriod2 = this.lblPeriod;
    size1 = new Size(173, 13);
    Size size3 = size1;
    lblPeriod2.Size = size3;
    this.lblPeriod.TabIndex = 10;
    this.Label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(195, 122);
    Point point4 = point1;
    label11_1.Location = point4;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(48 /*0x30*/, 13);
    Size size4 = size1;
    label11_2.Size = size4;
    this.Label11.TabIndex = 9;
    this.Label11.Text = "طول دوره";
    this.lblToDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblToDate1 = this.lblToDate;
    point1 = new Point(16 /*0x10*/, 93);
    Point point5 = point1;
    lblToDate1.Location = point5;
    this.lblToDate.Name = "lblToDate";
    Label lblToDate2 = this.lblToDate;
    size1 = new Size(173, 13);
    Size size5 = size1;
    lblToDate2.Size = size5;
    this.lblToDate.TabIndex = 8;
    this.Label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(195, 93);
    Point point6 = point1;
    label3_1.Location = point6;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(37, 13);
    Size size6 = size1;
    label3_2.Size = size6;
    this.Label3.TabIndex = 7;
    this.Label3.Text = "تا تاريخ";
    this.lblFromDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblFromDate1 = this.lblFromDate;
    point1 = new Point(16 /*0x10*/, 64 /*0x40*/);
    Point point7 = point1;
    lblFromDate1.Location = point7;
    this.lblFromDate.Name = "lblFromDate";
    Label lblFromDate2 = this.lblFromDate;
    size1 = new Size(173, 13);
    Size size7 = size1;
    lblFromDate2.Size = size7;
    this.lblFromDate.TabIndex = 6;
    this.Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(195, 64 /*0x40*/);
    Point point8 = point1;
    label7_1.Location = point8;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(35, 13);
    Size size8 = size1;
    label7_2.Size = size8;
    this.Label7.TabIndex = 5;
    this.Label7.Text = "ازتاريخ";
    this.txtPeriodUse.Alighment = HorizontalAlignment.Left;
    this.txtPeriodUse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPeriodUse.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtPeriodUse.Button = inputButtonSettings1;
    this.txtPeriodUse.ButtonDropDownEnable = true;
    this.txtPeriodUse.ControlType = Enum_ControlType.TextBox;
    this.txtPeriodUse.DefaultLanguge = Enum_Languge.English;
    this.txtPeriodUse.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPeriodUse.InputValidation = Enum_InputValidation.Integer;
    this.txtPeriodUse.Key = "";
    this.txtPeriodUse.LabelForeColor = SystemColors.ControlText;
    this.txtPeriodUse.LabelText = "دوره كنترخواني";
    InputBox txtPeriodUse1 = this.txtPeriodUse;
    point1 = new Point(141, 30);
    Point point9 = point1;
    txtPeriodUse1.Location = point9;
    this.txtPeriodUse.MaxLenght = (int) short.MaxValue;
    this.txtPeriodUse.MinLenght = 0;
    this.txtPeriodUse.Multiline = false;
    this.txtPeriodUse.Name = "txtPeriodUse";
    this.txtPeriodUse.RangeDown = "";
    this.txtPeriodUse.RangeUp = "";
    this.txtPeriodUse.RequiredField = true;
    InputBox txtPeriodUse2 = this.txtPeriodUse;
    size1 = new Size(149, 24);
    Size size9 = size1;
    txtPeriodUse2.Size = size9;
    this.txtPeriodUse.TabIndex = 0;
    this.txtPeriodUse.ToolTipText = "لطفا شماره دوره كنترخواني را در اين قسمت وارد نمائيد";
    this.txtPeriodUse.UseSystemPasswordChar = false;
    this.txtPeriodUse.WatermarkText = "";
    this.txtPeriodUse.WriteType = Enum_WriteType.Defualt;
    this.GroupBox2.Controls.Add((Control) this.lblPeriodBill);
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.lblTodateBill);
    this.GroupBox2.Controls.Add((Control) this.Label4);
    this.GroupBox2.Controls.Add((Control) this.lblFromDateBill);
    this.GroupBox2.Controls.Add((Control) this.Label1);
    this.GroupBox2.Controls.Add((Control) this.txtBillId);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(12, 41);
    Point point10 = point1;
    groupBox2_1.Location = point10;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(304, 166);
    Size size10 = size1;
    groupBox2_2.Size = size10;
    this.GroupBox2.TabIndex = 10;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "اطلاعات قبض سازمان آب";
    this.lblPeriodBill.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblPeriodBill1 = this.lblPeriodBill;
    point1 = new Point(6, 122);
    Point point11 = point1;
    lblPeriodBill1.Location = point11;
    this.lblPeriodBill.Name = "lblPeriodBill";
    Label lblPeriodBill2 = this.lblPeriodBill;
    size1 = new Size(198, 13);
    Size size11 = size1;
    lblPeriodBill2.Size = size11;
    this.lblPeriodBill.TabIndex = 6;
    this.Label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(210, 122);
    Point point12 = point1;
    label6_1.Location = point12;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(48 /*0x30*/, 13);
    Size size12 = size1;
    label6_2.Size = size12;
    this.Label6.TabIndex = 5;
    this.Label6.Text = "طول دوره";
    this.lblTodateBill.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblTodateBill1 = this.lblTodateBill;
    point1 = new Point(6, 93);
    Point point13 = point1;
    lblTodateBill1.Location = point13;
    this.lblTodateBill.Name = "lblTodateBill";
    Label lblTodateBill2 = this.lblTodateBill;
    size1 = new Size(198, 13);
    Size size13 = size1;
    lblTodateBill2.Size = size13;
    this.lblTodateBill.TabIndex = 4;
    this.Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(210, 93);
    Point point14 = point1;
    label4_1.Location = point14;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(37, 13);
    Size size14 = size1;
    label4_2.Size = size14;
    this.Label4.TabIndex = 3;
    this.Label4.Text = "تا تاريخ";
    this.lblFromDateBill.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblFromDateBill1 = this.lblFromDateBill;
    point1 = new Point(6, 64 /*0x40*/);
    Point point15 = point1;
    lblFromDateBill1.Location = point15;
    this.lblFromDateBill.Name = "lblFromDateBill";
    Label lblFromDateBill2 = this.lblFromDateBill;
    size1 = new Size(198, 13);
    Size size15 = size1;
    lblFromDateBill2.Size = size15;
    this.lblFromDateBill.TabIndex = 2;
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(210, 64 /*0x40*/);
    Point point16 = point1;
    label1_1.Location = point16;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(35, 13);
    Size size16 = size1;
    label1_2.Size = size16;
    this.Label1.TabIndex = 1;
    this.Label1.Text = "ازتاريخ";
    this.txtBillId.Alighment = HorizontalAlignment.Left;
    this.txtBillId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtBillId.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtBillId.Button = inputButtonSettings2;
    this.txtBillId.ButtonDropDownEnable = true;
    this.txtBillId.ControlType = Enum_ControlType.TextBox;
    this.txtBillId.DefaultLanguge = Enum_Languge.English;
    this.txtBillId.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtBillId.InputValidation = Enum_InputValidation.Integer;
    this.txtBillId.Key = "";
    this.txtBillId.LabelForeColor = SystemColors.ControlText;
    this.txtBillId.LabelText = "دوره قرائت";
    InputBox txtBillId1 = this.txtBillId;
    point1 = new Point(155, 30);
    Point point17 = point1;
    txtBillId1.Location = point17;
    this.txtBillId.MaxLenght = (int) short.MaxValue;
    this.txtBillId.MinLenght = 0;
    this.txtBillId.Multiline = false;
    this.txtBillId.Name = "txtBillId";
    this.txtBillId.RangeDown = "";
    this.txtBillId.RangeUp = "";
    this.txtBillId.RequiredField = true;
    InputBox txtBillId2 = this.txtBillId;
    size1 = new Size(130, 24);
    Size size17 = size1;
    txtBillId2.Size = size17;
    this.txtBillId.TabIndex = 0;
    this.txtBillId.ToolTipText = "لطفا شماره قرائت دوره قبض سازمان آب را در اين قسمت وارد نمائيد";
    this.txtBillId.UseSystemPasswordChar = false;
    this.txtBillId.WatermarkText = "";
    this.txtBillId.WriteType = Enum_WriteType.Defualt;
    this.GroupBox3.Controls.Add((Control) this.lblNumber);
    this.GroupBox3.Controls.Add((Control) this.Label10);
    this.GroupBox3.Controls.Add((Control) this.lblTel);
    this.GroupBox3.Controls.Add((Control) this.Label23);
    this.GroupBox3.Controls.Add((Control) this.lblName);
    this.GroupBox3.Controls.Add((Control) this.Label25);
    this.GroupBox3.Controls.Add((Control) this.lblBlockNumber);
    this.GroupBox3.Controls.Add((Control) this.Label27);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(647, 41);
    Point point18 = point1;
    groupBox3_1.Location = point18;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(298, 166);
    Size size18 = size1;
    groupBox3_2.Size = size18;
    this.GroupBox3.TabIndex = 11;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "اطلاعات واحد مسكوني";
    this.lblNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblNumber1 = this.lblNumber;
    point1 = new Point(16 /*0x10*/, 41);
    Point point19 = point1;
    lblNumber1.Location = point19;
    this.lblNumber.Name = "lblNumber";
    Label lblNumber2 = this.lblNumber;
    size1 = new Size(152, 13);
    Size size19 = size1;
    lblNumber2.Size = size19;
    this.lblNumber.TabIndex = 16 /*0x10*/;
    this.Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(174, 41);
    Point point20 = point1;
    label10_1.Location = point20;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(50, 13);
    Size size20 = size1;
    label10_2.Size = size20;
    this.Label10.TabIndex = 15;
    this.Label10.Text = "پلاك واحد";
    this.lblTel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblTel1 = this.lblTel;
    point1 = new Point(16 /*0x10*/, 122);
    Point point21 = point1;
    lblTel1.Location = point21;
    this.lblTel.Name = "lblTel";
    Label lblTel2 = this.lblTel;
    size1 = new Size(152, 13);
    Size size21 = size1;
    lblTel2.Size = size21;
    this.lblTel.TabIndex = 10;
    this.Label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label23.AutoSize = true;
    Label label23_1 = this.Label23;
    point1 = new Point(174, 122);
    Point point22 = point1;
    label23_1.Location = point22;
    this.Label23.Name = "Label23";
    Label label23_2 = this.Label23;
    size1 = new Size(28, 13);
    Size size22 = size1;
    label23_2.Size = size22;
    this.Label23.TabIndex = 9;
    this.Label23.Text = "تلفن";
    this.lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblName1 = this.lblName;
    point1 = new Point(16 /*0x10*/, 93);
    Point point23 = point1;
    lblName1.Location = point23;
    this.lblName.Name = "lblName";
    Label lblName2 = this.lblName;
    size1 = new Size(152, 13);
    Size size23 = size1;
    lblName2.Size = size23;
    this.lblName.TabIndex = 8;
    this.Label25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label25.AutoSize = true;
    Label label25_1 = this.Label25;
    point1 = new Point(174, 93);
    Point point24 = point1;
    label25_1.Location = point24;
    this.Label25.Name = "Label25";
    Label label25_2 = this.Label25;
    size1 = new Size(50, 13);
    Size size24 = size1;
    label25_2.Size = size24;
    this.Label25.TabIndex = 7;
    this.Label25.Text = "نام ساكن";
    this.lblBlockNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    Label lblBlockNumber1 = this.lblBlockNumber;
    point1 = new Point(16 /*0x10*/, 64 /*0x40*/);
    Point point25 = point1;
    lblBlockNumber1.Location = point25;
    this.lblBlockNumber.Name = "lblBlockNumber";
    Label lblBlockNumber2 = this.lblBlockNumber;
    size1 = new Size(152, 13);
    Size size25 = size1;
    lblBlockNumber2.Size = size25;
    this.lblBlockNumber.TabIndex = 6;
    this.Label27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label27.AutoSize = true;
    Label label27_1 = this.Label27;
    point1 = new Point(174, 64 /*0x40*/);
    Point point26 = point1;
    label27_1.Location = point26;
    this.Label27.Name = "Label27";
    Label label27_2 = this.Label27;
    size1 = new Size(60, 13);
    Size size26 = size1;
    label27_2.Size = size26;
    this.Label27.TabIndex = 5;
    this.Label27.Text = "شماره بلوك";
    this.GroupBox4.Controls.Add((Control) this.Label12);
    this.GroupBox4.Controls.Add((Control) this.lblTotalUseCold);
    this.GroupBox4.Controls.Add((Control) this.lblTotalUse);
    this.GroupBox4.Controls.Add((Control) this.Label13);
    this.GroupBox4.Controls.Add((Control) this.Label14);
    this.GroupBox4.Controls.Add((Control) this.lblTotalUseHot);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(647, 213);
    Point point27 = point1;
    groupBox4_1.Location = point27;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(298, 195);
    Size size27 = size1;
    groupBox4_2.Size = size27;
    this.GroupBox4.TabIndex = 12;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "اطلاعات مصرف";
    this.Label12.AutoSize = true;
    this.Label12.ForeColor = Color.Blue;
    Label label12_1 = this.Label12;
    point1 = new Point(157, 37);
    Point point28 = point1;
    label12_1.Location = point28;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(119, 13);
    Size size28 = size1;
    label12_2.Size = size28;
    this.Label12.TabIndex = 33;
    this.Label12.Text = "مصرف كل آب سرد (ليتر)";
    this.lblTotalUseCold.ForeColor = Color.Blue;
    Label lblTotalUseCold1 = this.lblTotalUseCold;
    point1 = new Point(26, 37);
    Point point29 = point1;
    lblTotalUseCold1.Location = point29;
    this.lblTotalUseCold.Name = "lblTotalUseCold";
    Label lblTotalUseCold2 = this.lblTotalUseCold;
    size1 = new Size(125, 13);
    Size size29 = size1;
    lblTotalUseCold2.Size = size29;
    this.lblTotalUseCold.TabIndex = 34;
    this.lblTotalUse.ForeColor = Color.Black;
    Label lblTotalUse1 = this.lblTotalUse;
    point1 = new Point(26, 87);
    Point point30 = point1;
    lblTotalUse1.Location = point30;
    this.lblTotalUse.Name = "lblTotalUse";
    Label lblTotalUse2 = this.lblTotalUse;
    size1 = new Size(125, 13);
    Size size30 = size1;
    lblTotalUse2.Size = size30;
    this.lblTotalUse.TabIndex = 38;
    this.Label13.AutoSize = true;
    this.Label13.ForeColor = Color.Red;
    Label label13_1 = this.Label13;
    point1 = new Point(157, 62);
    Point point31 = point1;
    label13_1.Location = point31;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(115, 13);
    Size size31 = size1;
    label13_2.Size = size31;
    this.Label13.TabIndex = 35;
    this.Label13.Text = "مصرف كل آب گرم (ليتر)";
    this.Label14.AutoSize = true;
    this.Label14.ForeColor = Color.Black;
    Label label14_1 = this.Label14;
    point1 = new Point(157, 87);
    Point point32 = point1;
    label14_1.Location = point32;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(125, 13);
    Size size32 = size1;
    label14_2.Size = size32;
    this.Label14.TabIndex = 37;
    this.Label14.Text = "مصرف كل آب خانگي(ليتر)";
    this.lblTotalUseHot.ForeColor = Color.Red;
    Label lblTotalUseHot1 = this.lblTotalUseHot;
    point1 = new Point(26, 62);
    Point point33 = point1;
    lblTotalUseHot1.Location = point33;
    this.lblTotalUseHot.Name = "lblTotalUseHot";
    Label lblTotalUseHot2 = this.lblTotalUseHot;
    size1 = new Size(125, 13);
    Size size33 = size1;
    lblTotalUseHot2.Size = size33;
    this.lblTotalUseHot.TabIndex = 36;
    this.GroupBox5.Controls.Add((Control) this.lblPrice);
    this.GroupBox5.Controls.Add((Control) this.Label28);
    this.GroupBox5.Controls.Add((Control) this.lblTotalPrice);
    this.GroupBox5.Controls.Add((Control) this.Label30);
    this.GroupBox5.Controls.Add((Control) this.lblTax);
    this.GroupBox5.Controls.Add((Control) this.Label32);
    this.GroupBox5.Controls.Add((Control) this.lblAverageUse);
    this.GroupBox5.Controls.Add((Control) this.Label16);
    this.GroupBox5.Controls.Add((Control) this.lblAveragePrice);
    this.GroupBox5.Controls.Add((Control) this.Label18);
    this.GroupBox5.Controls.Add((Control) this.lblPatternId);
    this.GroupBox5.Controls.Add((Control) this.Label20);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(322, 213);
    Point point34 = point1;
    groupBox5_1.Location = point34;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(319, 195);
    Size size34 = size1;
    groupBox5_2.Size = size34;
    this.GroupBox5.TabIndex = 13;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "محاسبه قبض طبق تعرفه سازمان آب";
    Label lblPrice1 = this.lblPrice;
    point1 = new Point(16 /*0x10*/, 116);
    Point point35 = point1;
    lblPrice1.Location = point35;
    this.lblPrice.Name = "lblPrice";
    Label lblPrice2 = this.lblPrice;
    size1 = new Size(121, 13);
    Size size35 = size1;
    lblPrice2.Size = size35;
    this.lblPrice.TabIndex = 28;
    this.Label28.AutoSize = true;
    Label label28_1 = this.Label28;
    point1 = new Point(146, 116);
    Point point36 = point1;
    label28_1.Location = point36;
    this.Label28.Name = "Label28";
    Label label28_2 = this.Label28;
    size1 = new Size(85, 13);
    Size size36 = size1;
    label28_2.Size = size36;
    this.Label28.TabIndex = 27;
    this.Label28.Text = "آب بهاء دوره(ريال)";
    Label lblTotalPrice1 = this.lblTotalPrice;
    point1 = new Point(16 /*0x10*/, 168);
    Point point37 = point1;
    lblTotalPrice1.Location = point37;
    this.lblTotalPrice.Name = "lblTotalPrice";
    Label lblTotalPrice2 = this.lblTotalPrice;
    size1 = new Size(121, 13);
    Size size37 = size1;
    lblTotalPrice2.Size = size37;
    this.lblTotalPrice.TabIndex = 26;
    this.Label30.AutoSize = true;
    Label label30_1 = this.Label30;
    point1 = new Point(146, 168);
    Point point38 = point1;
    label30_1.Location = point38;
    this.Label30.Name = "Label30";
    Label label30_2 = this.Label30;
    size1 = new Size(84, 13);
    Size size38 = size1;
    label30_2.Size = size38;
    this.Label30.TabIndex = 25;
    this.Label30.Text = "مبلغ نهائي (ريال)";
    Label lblTax1 = this.lblTax;
    point1 = new Point(16 /*0x10*/, 139);
    Point point39 = point1;
    lblTax1.Location = point39;
    this.lblTax.Name = "lblTax";
    Label lblTax2 = this.lblTax;
    size1 = new Size(121, 13);
    Size size39 = size1;
    lblTax2.Size = size39;
    this.lblTax.TabIndex = 24;
    this.Label32.AutoSize = true;
    Label label32_1 = this.Label32;
    point1 = new Point(146, 139);
    Point point40 = point1;
    label32_1.Location = point40;
    this.Label32.Name = "Label32";
    Label label32_2 = this.Label32;
    size1 = new Size(132, 13);
    Size size40 = size1;
    label32_2.Size = size40;
    this.Label32.TabIndex = 23;
    this.Label32.Text = "ماليات بر ارزش افزوده (ريال)";
    Label lblAverageUse1 = this.lblAverageUse;
    point1 = new Point(16 /*0x10*/, 37);
    Point point41 = point1;
    lblAverageUse1.Location = point41;
    this.lblAverageUse.Name = "lblAverageUse";
    Label lblAverageUse2 = this.lblAverageUse;
    size1 = new Size(121, 13);
    Size size41 = size1;
    lblAverageUse2.Size = size41;
    this.lblAverageUse.TabIndex = 22;
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(146, 37);
    Point point42 = point1;
    label16_1.Location = point42;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(130, 13);
    Size size42 = size1;
    label16_2.Size = size42;
    this.Label16.TabIndex = 21;
    this.Label16.Text = "متوسط مصرف در ماه (ليتر)";
    Label lblAveragePrice1 = this.lblAveragePrice;
    point1 = new Point(16 /*0x10*/, 89);
    Point point43 = point1;
    lblAveragePrice1.Location = point43;
    this.lblAveragePrice.Name = "lblAveragePrice";
    Label lblAveragePrice2 = this.lblAveragePrice;
    size1 = new Size(121, 13);
    Size size43 = size1;
    lblAveragePrice2.Size = size43;
    this.lblAveragePrice.TabIndex = 20;
    this.Label18.AutoSize = true;
    Label label18_1 = this.Label18;
    point1 = new Point(146, 89);
    Point point44 = point1;
    label18_1.Location = point44;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(145, 13);
    Size size44 = size1;
    label18_2.Size = size44;
    this.Label18.TabIndex = 19;
    this.Label18.Text = "مبلغ آب بهاء براي يك ماه (ريال)";
    Label lblPatternId1 = this.lblPatternId;
    point1 = new Point(16 /*0x10*/, 60);
    Point point45 = point1;
    lblPatternId1.Location = point45;
    this.lblPatternId.Name = "lblPatternId";
    Label lblPatternId2 = this.lblPatternId;
    size1 = new Size(121, 13);
    Size size45 = size1;
    lblPatternId2.Size = size45;
    this.lblPatternId.TabIndex = 18;
    this.Label20.AutoSize = true;
    Label label20_1 = this.Label20;
    point1 = new Point(146, 60);
    Point point46 = point1;
    label20_1.Location = point46;
    this.Label20.Name = "Label20";
    Label label20_2 = this.Label20;
    size1 = new Size(53, 13);
    Size size46 = size1;
    label20_2.Size = size46;
    this.Label20.TabIndex = 17;
    this.Label20.Text = "پله مصرف";
    this.GroupBox6.Controls.Add((Control) this.lblRoundPrice);
    this.GroupBox6.Controls.Add((Control) this.Label9);
    this.GroupBox6.Controls.Add((Control) this.lblTotal);
    this.GroupBox6.Controls.Add((Control) this.Label5);
    this.GroupBox6.Controls.Add((Control) this.lblIncreaser);
    this.GroupBox6.Controls.Add((Control) this.Label40);
    this.GroupBox6.Controls.Add((Control) this.lblTotalRealPrice);
    this.GroupBox6.Controls.Add((Control) this.Label34);
    this.GroupBox6.Controls.Add((Control) this.lblSharedPrice);
    this.GroupBox6.Controls.Add((Control) this.Label36);
    this.GroupBox6.Controls.Add((Control) this.lblRealPrice);
    this.GroupBox6.Controls.Add((Control) this.Label38);
    GroupBox groupBox6_1 = this.GroupBox6;
    point1 = new Point(12, 213);
    Point point47 = point1;
    groupBox6_1.Location = point47;
    this.GroupBox6.Name = "GroupBox6";
    GroupBox groupBox6_2 = this.GroupBox6;
    size1 = new Size(304, 195);
    Size size47 = size1;
    groupBox6_2.Size = size47;
    this.GroupBox6.TabIndex = 14;
    this.GroupBox6.TabStop = false;
    this.GroupBox6.Text = "محاسبات قبض اين دوره";
    Label lblIncreaser1 = this.lblIncreaser;
    point1 = new Point(6, 37);
    Point point48 = point1;
    lblIncreaser1.Location = point48;
    this.lblIncreaser.Name = "lblIncreaser";
    Label lblIncreaser2 = this.lblIncreaser;
    size1 = new Size(166, 13);
    Size size48 = size1;
    lblIncreaser2.Size = size48;
    this.lblIncreaser.TabIndex = 8;
    this.Label40.AutoSize = true;
    Label label40_1 = this.Label40;
    point1 = new Point(178, 37);
    Point point49 = point1;
    label40_1.Location = point49;
    this.Label40.Name = "Label40";
    Label label40_2 = this.Label40;
    size1 = new Size(98, 13);
    Size size49 = size1;
    label40_2.Size = size49;
    this.Label40.TabIndex = 7;
    this.Label40.Text = "ضريب كاهشي دوره";
    this.lblTotalRealPrice.ForeColor = Color.Red;
    Label lblTotalRealPrice1 = this.lblTotalRealPrice;
    point1 = new Point(6, 168);
    Point point50 = point1;
    lblTotalRealPrice1.Location = point50;
    this.lblTotalRealPrice.Name = "lblTotalRealPrice";
    Label lblTotalRealPrice2 = this.lblTotalRealPrice;
    size1 = new Size(166, 13);
    Size size50 = size1;
    lblTotalRealPrice2.Size = size50;
    this.lblTotalRealPrice.TabIndex = 6;
    this.Label34.AutoSize = true;
    this.Label34.ForeColor = Color.Red;
    Label label34_1 = this.Label34;
    point1 = new Point(178, 168);
    Point point51 = point1;
    label34_1.Location = point51;
    this.Label34.Name = "Label34";
    Label label34_2 = this.Label34;
    size1 = new Size(90, 13);
    Size size51 = size1;
    label34_2.Size = size51;
    this.Label34.TabIndex = 5;
    this.Label34.Text = "قابل پرداخت (ريال)";
    Label lblSharedPrice1 = this.lblSharedPrice;
    point1 = new Point(6, 93);
    Point point52 = point1;
    lblSharedPrice1.Location = point52;
    this.lblSharedPrice.Name = "lblSharedPrice";
    Label lblSharedPrice2 = this.lblSharedPrice;
    size1 = new Size(166, 13);
    Size size52 = size1;
    lblSharedPrice2.Size = size52;
    this.lblSharedPrice.TabIndex = 4;
    this.Label36.AutoSize = true;
    Label label36_1 = this.Label36;
    point1 = new Point(178, 93);
    Point point53 = point1;
    label36_1.Location = point53;
    this.Label36.Name = "Label36";
    Label label36_2 = this.Label36;
    size1 = new Size(120, 13);
    Size size53 = size1;
    label36_2.Size = size53;
    this.Label36.TabIndex = 3;
    this.Label36.Text = "مبلغ آب بهاء مشاع (ريال)";
    Label lblRealPrice1 = this.lblRealPrice;
    point1 = new Point(6, 64 /*0x40*/);
    Point point54 = point1;
    lblRealPrice1.Location = point54;
    this.lblRealPrice.Name = "lblRealPrice";
    Label lblRealPrice2 = this.lblRealPrice;
    size1 = new Size(166, 13);
    Size size54 = size1;
    lblRealPrice2.Size = size54;
    this.lblRealPrice.TabIndex = 2;
    this.Label38.AutoSize = true;
    Label label38_1 = this.Label38;
    point1 = new Point(178, 64 /*0x40*/);
    Point point55 = point1;
    label38_1.Location = point55;
    this.Label38.Name = "Label38";
    Label label38_2 = this.Label38;
    size1 = new Size(122, 13);
    Size size55 = size1;
    label38_2.Size = size55;
    this.Label38.TabIndex = 1;
    this.Label38.Text = "مبلغ آب بهاء خانگي (ريال)";
    this.GroupBox7.Controls.Add((Control) this.txtDescription);
    GroupBox groupBox7_1 = this.GroupBox7;
    point1 = new Point(12, 414);
    Point point56 = point1;
    groupBox7_1.Location = point56;
    this.GroupBox7.Name = "GroupBox7";
    GroupBox groupBox7_2 = this.GroupBox7;
    size1 = new Size(933, 79);
    Size size56 = size1;
    groupBox7_2.Size = size56;
    this.GroupBox7.TabIndex = 15;
    this.GroupBox7.TabStop = false;
    this.GroupBox7.Text = "توضيحات";
    this.txtDescription.Alighment = HorizontalAlignment.Left;
    this.txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtDescription.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtDescription.Button = inputButtonSettings3;
    this.txtDescription.ButtonDropDownEnable = true;
    this.txtDescription.ControlType = Enum_ControlType.TextBox;
    this.txtDescription.DefaultLanguge = Enum_Languge.English;
    this.txtDescription.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtDescription.InputValidation = Enum_InputValidation.All;
    this.txtDescription.Key = "";
    this.txtDescription.LabelForeColor = SystemColors.ControlText;
    this.txtDescription.LabelText = "";
    InputBox txtDescription1 = this.txtDescription;
    point1 = new Point(28, 11);
    Point point57 = point1;
    txtDescription1.Location = point57;
    this.txtDescription.MaxLenght = (int) short.MaxValue;
    this.txtDescription.MinLenght = 0;
    this.txtDescription.Multiline = true;
    this.txtDescription.Name = "txtDescription";
    this.txtDescription.RangeDown = "";
    this.txtDescription.RangeUp = "";
    this.txtDescription.RequiredField = false;
    InputBox txtDescription2 = this.txtDescription;
    size1 = new Size(876, 91);
    Size size57 = size1;
    txtDescription2.Size = size57;
    this.txtDescription.TabIndex = 1;
    this.txtDescription.ToolTipText = "لطفا شماره دوره كنترخواني را در اين قسمت وارد نمائيد";
    this.txtDescription.UseSystemPasswordChar = false;
    this.txtDescription.WatermarkText = "";
    this.txtDescription.WriteType = Enum_WriteType.Defualt;
    Label lblTotal1 = this.lblTotal;
    point1 = new Point(6, 116);
    Point point58 = point1;
    lblTotal1.Location = point58;
    this.lblTotal.Name = "lblTotal";
    Label lblTotal2 = this.lblTotal;
    size1 = new Size(166, 13);
    Size size58 = size1;
    lblTotal2.Size = size58;
    this.lblTotal.TabIndex = 10;
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(178, 116);
    Point point59 = point1;
    label5_1.Location = point59;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(105, 13);
    Size size59 = size1;
    label5_2.Size = size59;
    this.Label5.TabIndex = 9;
    this.Label5.Text = "مبلغ كل آب بهاء (ريال)";
    Label lblRoundPrice1 = this.lblRoundPrice;
    point1 = new Point(6, 139);
    Point point60 = point1;
    lblRoundPrice1.Location = point60;
    this.lblRoundPrice.Name = "lblRoundPrice";
    Label lblRoundPrice2 = this.lblRoundPrice;
    size1 = new Size(166, 13);
    Size size60 = size1;
    lblRoundPrice2.Size = size60;
    this.lblRoundPrice.TabIndex = 12;
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(178, 139);
    Point point61 = point1;
    label9_1.Location = point61;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(102, 13);
    Size size61 = size1;
    label9_2.Size = size61;
    this.Label9.TabIndex = 11;
    this.Label9.Text = "هزينه رند كردن (ريال)";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(953, 495);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox7);
    this.Controls.Add((Control) this.GroupBox6);
    this.Controls.Add((Control) this.GroupBox5);
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmFinalBillData);
    this.Text = nameof (frmFinalBillData);
    this.Controls.SetChildIndex((Control) this.GroupBox1, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox3, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox2, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox4, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox5, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox6, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox7, 0);
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.GroupBox6.ResumeLayout(false);
    this.GroupBox6.PerformLayout();
    this.GroupBox7.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual InputBox txtBillId
  {
    [DebuggerNonUserCode] get => this._txtBillId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtBillId != null)
        this._txtBillId.IsValidChange -= changeEventHandler;
      this._txtBillId = value;
      if (this._txtBillId == null)
        return;
      this._txtBillId.IsValidChange += changeEventHandler;
    }
  }

  internal virtual Label lblPeriodBill
  {
    [DebuggerNonUserCode] get => this._lblPeriodBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPeriodBill = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label lblTodateBill
  {
    [DebuggerNonUserCode] get => this._lblTodateBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTodateBill = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label lblFromDateBill
  {
    [DebuggerNonUserCode] get => this._lblFromDateBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFromDateBill = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label lblPeriod
  {
    [DebuggerNonUserCode] get => this._lblPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPeriod = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label lblToDate
  {
    [DebuggerNonUserCode] get => this._lblToDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblToDate = value;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label lblFromDate
  {
    [DebuggerNonUserCode] get => this._lblFromDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFromDate = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual Label lblNumber
  {
    [DebuggerNonUserCode] get => this._lblNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblNumber = value;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Label lblTel
  {
    [DebuggerNonUserCode] get => this._lblTel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTel = value;
  }

  internal virtual Label Label23
  {
    [DebuggerNonUserCode] get => this._Label23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
  }

  internal virtual Label lblName
  {
    [DebuggerNonUserCode] get => this._lblName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName = value;
  }

  internal virtual Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  internal virtual Label lblBlockNumber
  {
    [DebuggerNonUserCode] get => this._lblBlockNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBlockNumber = value;
    }
  }

  internal virtual Label Label27
  {
    [DebuggerNonUserCode] get => this._Label27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
  }

  internal virtual GroupBox GroupBox4
  {
    [DebuggerNonUserCode] get => this._GroupBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox4 = value;
    }
  }

  internal virtual InputBox txtPeriodUse
  {
    [DebuggerNonUserCode] get => this._txtPeriodUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtPeriodUse != null)
        this._txtPeriodUse.IsValidChange -= changeEventHandler;
      this._txtPeriodUse = value;
      if (this._txtPeriodUse == null)
        return;
      this._txtPeriodUse.IsValidChange += changeEventHandler;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual Label lblTotalUseCold
  {
    [DebuggerNonUserCode] get => this._lblTotalUseCold;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalUseCold = value;
    }
  }

  internal virtual Label lblTotalUse
  {
    [DebuggerNonUserCode] get => this._lblTotalUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalUse = value;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual Label lblTotalUseHot
  {
    [DebuggerNonUserCode] get => this._lblTotalUseHot;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalUseHot = value;
    }
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual Label lblPrice
  {
    [DebuggerNonUserCode] get => this._lblPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblPrice = value;
  }

  internal virtual Label Label28
  {
    [DebuggerNonUserCode] get => this._Label28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
  }

  internal virtual Label lblTotalPrice
  {
    [DebuggerNonUserCode] get => this._lblTotalPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalPrice = value;
    }
  }

  internal virtual Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual Label lblTax
  {
    [DebuggerNonUserCode] get => this._lblTax;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTax = value;
  }

  internal virtual Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual Label lblAverageUse
  {
    [DebuggerNonUserCode] get => this._lblAverageUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAverageUse = value;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Label lblAveragePrice
  {
    [DebuggerNonUserCode] get => this._lblAveragePrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAveragePrice = value;
    }
  }

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual Label lblPatternId
  {
    [DebuggerNonUserCode] get => this._lblPatternId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPatternId = value;
    }
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual GroupBox GroupBox6
  {
    [DebuggerNonUserCode] get => this._GroupBox6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox6 = value;
    }
  }

  internal virtual Label lblIncreaser
  {
    [DebuggerNonUserCode] get => this._lblIncreaser;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblIncreaser = value;
    }
  }

  internal virtual Label Label40
  {
    [DebuggerNonUserCode] get => this._Label40;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label40 = value;
  }

  internal virtual Label lblTotalRealPrice
  {
    [DebuggerNonUserCode] get => this._lblTotalRealPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalRealPrice = value;
    }
  }

  internal virtual Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual Label lblSharedPrice
  {
    [DebuggerNonUserCode] get => this._lblSharedPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSharedPrice = value;
    }
  }

  internal virtual Label Label36
  {
    [DebuggerNonUserCode] get => this._Label36;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label36 = value;
  }

  internal virtual Label lblRealPrice
  {
    [DebuggerNonUserCode] get => this._lblRealPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblRealPrice = value;
    }
  }

  internal virtual Label Label38
  {
    [DebuggerNonUserCode] get => this._Label38;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
  }

  internal virtual GroupBox GroupBox7
  {
    [DebuggerNonUserCode] get => this._GroupBox7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox7 = value;
    }
  }

  internal virtual InputBox txtDescription
  {
    [DebuggerNonUserCode] get => this._txtDescription;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtDescription != null)
        this._txtDescription.IsValidChange -= changeEventHandler;
      this._txtDescription = value;
      if (this._txtDescription == null)
        return;
      this._txtDescription.IsValidChange += changeEventHandler;
    }
  }

  internal virtual Label lblRoundPrice
  {
    [DebuggerNonUserCode] get => this._lblRoundPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblRoundPrice = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label lblTotal
  {
    [DebuggerNonUserCode] get => this._lblTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTotal = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  private void checkValidation()
  {
    if (this.txtBillId.isValid & this.txtPeriodUse.isValid)
      this.buttAdd.Enabled = true;
    else
      this.buttAdd.Enabled = false;
  }

  protected override void Add()
  {
    base.Add();
    cFinalBill cFinalBill = new cFinalBill();
    cFinalBill.PeriodUseId = this.txtPeriodUse.Text;
    cFinalBill.BillId = this.txtBillId.Text;
    cFinalBill.Description = this.txtDescription.Text;
    bool flag = true;
    switch (this.FormType)
    {
      case Enum_ToolbarButtons.New:
        flag = cFinalBill.Add();
        break;
      case Enum_ToolbarButtons.Edit:
        cFinalBill.Identity = this.FormValue;
        flag = cFinalBill.Edit();
        break;
    }
    if (!flag)
    {
      string BodyText = cFinalBill.ErrorMessage;
      if (cFinalBill.ErrorDescription.Contains("'fldPeriodUseId'"))
      {
        BodyText = "شماره دوره كنترخواني وارد شده اشتباه ميباشد. اين شماره دوره يافت نشد";
        this.txtPeriodUse.Focus();
      }
      else if (cFinalBill.ErrorDescription.Contains("'fldBillId'"))
      {
        BodyText = "شماره دوره قبض سازمان آب وارد شده اشتباه ميباشد. اين شماره دوره يافت نشد";
        this.txtBillId.Focus();
      }
      else if (cFinalBill.ErrorDescription.Contains("UQ_fldPeriodUseIdfldBillId_tblFinalBill"))
        BodyText = "قبوض آب اين دوره كنترخواني و قبض سازمان آب قبلا صادر شده است ";
      int num = (int) MessageBoxMPS.show((Form) this, BodyText, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cFinalBill.ErrorDescription);
      this.buttAdd.Enabled = true;
    }
    else
    {
      switch (this.FormType)
      {
        case Enum_ToolbarButtons.New:
          frmFinalBill formParent = (frmFinalBill) this.FormParent;
          formParent.txtUse.Text = "";
          formParent.txtNumber.Text = "";
          formParent.txtBlockNumber.Text = "";
          formParent.txtName.Text = "";
          formParent.txtPeriodUse.Text = this.txtPeriodUse.Text;
          formParent.txtBill.Text = this.txtBillId.Text;
          break;
      }
      this.Dispose();
    }
  }
}
