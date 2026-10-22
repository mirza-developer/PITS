// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmFinalBill
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using CrystalDecisions.CrystalReports.Engine;
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
public class frmFinalBill : cfrmMain
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtBlockNumber")]
  private InputBox _txtBlockNumber;
  [AccessedThroughProperty("txtName")]
  private InputBox _txtName;
  [AccessedThroughProperty("txtNumber")]
  private InputBox _txtNumber;
  [AccessedThroughProperty("txtUse")]
  private InputBox _txtUse;
  [AccessedThroughProperty("txtBill")]
  private InputBox _txtBill;
  [AccessedThroughProperty("txtPeriodUse")]
  private InputBox _txtPeriodUse;
  [AccessedThroughProperty("lblTotalPriceHome")]
  private Label _lblTotalPriceHome;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("lblTotal")]
  private Label _lblTotal;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("lblTotalHot")]
  private Label _lblTotalHot;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("lblTotalCold")]
  private Label _lblTotalCold;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("lblTotalPriceReal")]
  private Label _lblTotalPriceReal;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("lblTotalPriceTown")]
  private Label _lblTotalPriceTown;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("lblTotalPriceShared")]
  private Label _lblTotalPriceShared;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("lblTotalSharedUse")]
  private Label _lblTotalSharedUse;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("lblBillPrice")]
  private Label _lblBillPrice;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("lblBillUse")]
  private Label _lblBillUse;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("lblTotalUseTown")]
  private Label _lblTotalUseTown;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("lblIncreaser")]
  private Label _lblIncreaser;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("lblRoundPrice")]
  private Label _lblRoundPrice;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("lblFinal")]
  private Label _lblFinal;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;

  [DebuggerNonUserCode]
  static frmFinalBill()
  {
  }

  [DebuggerNonUserCode]
  public frmFinalBill()
  {
    frmFinalBill.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmFinalBill.__ENCList)
    {
      if (frmFinalBill.__ENCList.Count == frmFinalBill.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmFinalBill.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmFinalBill.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmFinalBill.__ENCList[index1] = frmFinalBill.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmFinalBill.__ENCList.RemoveRange(index1, checked (frmFinalBill.__ENCList.Count - index1));
        frmFinalBill.__ENCList.Capacity = frmFinalBill.__ENCList.Count;
      }
      frmFinalBill.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFinalBill));
    this.lblTotalPriceHome = new Label();
    this.Label5 = new Label();
    this.lblTotal = new Label();
    this.Label4 = new Label();
    this.lblTotalHot = new Label();
    this.Label2 = new Label();
    this.lblTotalCold = new Label();
    this.Label1 = new Label();
    this.GroupBox1 = new GroupBox();
    this.txtUse = new InputBox();
    this.txtNumber = new InputBox();
    this.txtName = new InputBox();
    this.txtBlockNumber = new InputBox();
    this.GroupBox2 = new GroupBox();
    this.lblRoundPrice = new Label();
    this.Label7 = new Label();
    this.lblFinal = new Label();
    this.Label15 = new Label();
    this.lblIncreaser = new Label();
    this.Label13 = new Label();
    this.lblTotalUseTown = new Label();
    this.Label11 = new Label();
    this.lblTotalPriceReal = new Label();
    this.Label16 = new Label();
    this.lblTotalPriceTown = new Label();
    this.Label14 = new Label();
    this.lblTotalPriceShared = new Label();
    this.Label10 = new Label();
    this.lblTotalSharedUse = new Label();
    this.Label12 = new Label();
    this.lblBillPrice = new Label();
    this.Label8 = new Label();
    this.lblBillUse = new Label();
    this.Label6 = new Label();
    this.txtPeriodUse = new InputBox();
    this.txtBill = new InputBox();
    this.SearchBar.SuspendLayout();
    this.DataTable.BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.SuspendLayout();
    this.SearchBar.Controls.Add((Control) this.GroupBox2);
    this.SearchBar.Controls.Add((Control) this.GroupBox1);
    GroupBox searchBar1 = this.SearchBar;
    Point point1 = new Point(0, 91);
    Point point2 = point1;
    searchBar1.Location = point2;
    GroupBox searchBar2 = this.SearchBar;
    Size size1 = new Size(1095, 352);
    Size size2 = size1;
    searchBar2.Size = size2;
    this.SearchBar.Text = "";
    this.lblTotalPriceHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotalPriceHome.ForeColor = Color.Black;
    Label lblTotalPriceHome1 = this.lblTotalPriceHome;
    point1 = new Point(473, 140);
    Point point3 = point1;
    lblTotalPriceHome1.Location = point3;
    this.lblTotalPriceHome.Name = "lblTotalPriceHome";
    Label lblTotalPriceHome2 = this.lblTotalPriceHome;
    size1 = new Size(125, 13);
    Size size3 = size1;
    lblTotalPriceHome2.Size = size3;
    this.lblTotalPriceHome.TabIndex = 34;
    this.Label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label5.AutoSize = true;
    this.Label5.ForeColor = Color.Black;
    Label label5_1 = this.Label5;
    point1 = new Point(604, 140);
    Point point4 = point1;
    label5_1.Location = point4;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(173, 14);
    Size size4 = size1;
    label5_2.Size = size4;
    this.Label5.TabIndex = 33;
    this.Label5.Text = "جمع كل مبلغ مصرف خانگي(ريال)";
    this.lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotal.ForeColor = Color.Black;
    Label lblTotal1 = this.lblTotal;
    point1 = new Point(473, 112 /*0x70*/);
    Point point5 = point1;
    lblTotal1.Location = point5;
    this.lblTotal.Name = "lblTotal";
    Label lblTotal2 = this.lblTotal;
    size1 = new Size(125, 13);
    Size size5 = size1;
    lblTotal2.Size = size5;
    this.lblTotal.TabIndex = 32 /*0x20*/;
    this.Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label4.AutoSize = true;
    this.Label4.ForeColor = Color.Black;
    Label label4_1 = this.Label4;
    point1 = new Point(604, 112 /*0x70*/);
    Point point6 = point1;
    label4_1.Location = point6;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(136, 14);
    Size size6 = size1;
    label4_2.Size = size6;
    this.Label4.TabIndex = 31 /*0x1F*/;
    this.Label4.Text = "مصرف كل آب خانگي(ليتر)";
    this.lblTotalHot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotalHot.ForeColor = Color.Red;
    Label lblTotalHot1 = this.lblTotalHot;
    point1 = new Point(473, 87);
    Point point7 = point1;
    lblTotalHot1.Location = point7;
    this.lblTotalHot.Name = "lblTotalHot";
    Label lblTotalHot2 = this.lblTotalHot;
    size1 = new Size(125, 13);
    Size size7 = size1;
    lblTotalHot2.Size = size7;
    this.lblTotalHot.TabIndex = 30;
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.ForeColor = Color.Red;
    Label label2_1 = this.Label2;
    point1 = new Point(604, 87);
    Point point8 = point1;
    label2_1.Location = point8;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(125, 14);
    Size size8 = size1;
    label2_2.Size = size8;
    this.Label2.TabIndex = 29;
    this.Label2.Text = "مصرف كل آب گرم (ليتر)";
    this.lblTotalCold.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotalCold.ForeColor = Color.Blue;
    Label lblTotalCold1 = this.lblTotalCold;
    point1 = new Point(473, 62);
    Point point9 = point1;
    lblTotalCold1.Location = point9;
    this.lblTotalCold.Name = "lblTotalCold";
    Label lblTotalCold2 = this.lblTotalCold;
    size1 = new Size(125, 13);
    Size size9 = size1;
    lblTotalCold2.Size = size9;
    this.lblTotalCold.TabIndex = 28;
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.ForeColor = Color.Blue;
    Label label1_1 = this.Label1;
    point1 = new Point(604, 62);
    Point point10 = point1;
    label1_1.Location = point10;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(130, 14);
    Size size10 = size1;
    label1_2.Size = size10;
    this.Label1.TabIndex = 27;
    this.Label1.Text = "مصرف كل آب سرد (ليتر)";
    this.GroupBox1.Controls.Add((Control) this.txtUse);
    this.GroupBox1.Controls.Add((Control) this.txtNumber);
    this.GroupBox1.Controls.Add((Control) this.txtName);
    this.GroupBox1.Controls.Add((Control) this.txtBlockNumber);
    this.GroupBox1.Dock = DockStyle.Right;
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(841, 18);
    Point point11 = point1;
    groupBox1_1.Location = point11;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(251, 331);
    Size size11 = size1;
    groupBox1_2.Size = size11;
    this.GroupBox1.TabIndex = 35;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "جستجو بر اساس";
    this.txtUse.Alighment = HorizontalAlignment.Left;
    this.txtUse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtUse.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtUse.Button = inputButtonSettings1;
    this.txtUse.ButtonDropDownEnable = true;
    this.txtUse.ControlType = Enum_ControlType.TextBox;
    this.txtUse.DefaultLanguge = Enum_Languge.English;
    this.txtUse.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtUse.InputValidation = Enum_InputValidation.Integer;
    this.txtUse.Key = "";
    this.txtUse.LabelForeColor = SystemColors.ControlText;
    this.txtUse.LabelText = "شماره قبض";
    InputBox txtUse1 = this.txtUse;
    point1 = new Point(113, 22);
    Point point12 = point1;
    txtUse1.Location = point12;
    this.txtUse.MaxLenght = (int) short.MaxValue;
    this.txtUse.MinLenght = 0;
    this.txtUse.Multiline = false;
    this.txtUse.Name = "txtUse";
    this.txtUse.RangeDown = "";
    this.txtUse.RangeUp = "";
    this.txtUse.RequiredField = false;
    InputBox txtUse2 = this.txtUse;
    size1 = new Size(129, 24);
    Size size12 = size1;
    txtUse2.Size = size12;
    this.txtUse.TabIndex = 0;
    this.txtUse.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtUse.UseSystemPasswordChar = false;
    this.txtUse.WatermarkText = "";
    this.txtUse.WriteType = Enum_WriteType.Defualt;
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
    this.txtNumber.LabelText = "پلاك";
    InputBox txtNumber1 = this.txtNumber;
    point1 = new Point(112 /*0x70*/, 81);
    Point point13 = point1;
    txtNumber1.Location = point13;
    this.txtNumber.MaxLenght = 3;
    this.txtNumber.MinLenght = 1;
    this.txtNumber.Multiline = false;
    this.txtNumber.Name = "txtNumber";
    this.txtNumber.RangeDown = "1";
    this.txtNumber.RangeUp = "999";
    this.txtNumber.RequiredField = false;
    InputBox txtNumber2 = this.txtNumber;
    size1 = new Size(96 /*0x60*/, 24);
    Size size13 = size1;
    txtNumber2.Size = size13;
    this.txtNumber.TabIndex = 2;
    this.txtNumber.ToolTipText = "پلاك واحد را در اين قسمت وارد نمائيد";
    this.txtNumber.UseSystemPasswordChar = false;
    this.txtNumber.WatermarkText = "";
    this.txtNumber.WriteType = Enum_WriteType.Defualt;
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
    point1 = new Point(13, 107);
    Point point14 = point1;
    txtName1.Location = point14;
    this.txtName.MaxLenght = 50;
    this.txtName.MinLenght = 1;
    this.txtName.Multiline = false;
    this.txtName.Name = "txtName";
    this.txtName.RangeDown = "";
    this.txtName.RangeUp = "";
    this.txtName.RequiredField = false;
    InputBox txtName2 = this.txtName;
    size1 = new Size(219, 24);
    Size size14 = size1;
    txtName2.Size = size14;
    this.txtName.TabIndex = 3;
    this.txtName.ToolTipText = "نام ساكن فعلي منزل را در اين قسمت وارد نمائيد";
    this.txtName.UseSystemPasswordChar = false;
    this.txtName.WatermarkText = "";
    this.txtName.WriteType = Enum_WriteType.Defualt;
    this.txtBlockNumber.Alighment = HorizontalAlignment.Left;
    this.txtBlockNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtBlockNumber.BackColor = Color.Transparent;
    inputButtonSettings4.DisplayPosition = 1;
    inputButtonSettings4.Enabled = false;
    this.txtBlockNumber.Button = inputButtonSettings4;
    this.txtBlockNumber.ButtonDropDownEnable = true;
    this.txtBlockNumber.ControlType = Enum_ControlType.TextBox;
    this.txtBlockNumber.DefaultLanguge = Enum_Languge.English;
    this.txtBlockNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtBlockNumber.InputValidation = Enum_InputValidation.Integer;
    this.txtBlockNumber.Key = "";
    this.txtBlockNumber.LabelForeColor = SystemColors.ControlText;
    this.txtBlockNumber.LabelText = "شماره بلوك";
    InputBox txtBlockNumber1 = this.txtBlockNumber;
    point1 = new Point(113, 51);
    Point point15 = point1;
    txtBlockNumber1.Location = point15;
    this.txtBlockNumber.MaxLenght = (int) short.MaxValue;
    this.txtBlockNumber.MinLenght = 0;
    this.txtBlockNumber.Multiline = false;
    this.txtBlockNumber.Name = "txtBlockNumber";
    this.txtBlockNumber.RangeDown = "";
    this.txtBlockNumber.RangeUp = "";
    this.txtBlockNumber.RequiredField = false;
    InputBox txtBlockNumber2 = this.txtBlockNumber;
    size1 = new Size((int) sbyte.MaxValue, 24);
    Size size15 = size1;
    txtBlockNumber2.Size = size15;
    this.txtBlockNumber.TabIndex = 1;
    this.txtBlockNumber.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtBlockNumber.UseSystemPasswordChar = false;
    this.txtBlockNumber.WatermarkText = "";
    this.txtBlockNumber.WriteType = Enum_WriteType.Defualt;
    this.GroupBox2.Controls.Add((Control) this.lblRoundPrice);
    this.GroupBox2.Controls.Add((Control) this.Label7);
    this.GroupBox2.Controls.Add((Control) this.lblFinal);
    this.GroupBox2.Controls.Add((Control) this.Label15);
    this.GroupBox2.Controls.Add((Control) this.lblIncreaser);
    this.GroupBox2.Controls.Add((Control) this.Label13);
    this.GroupBox2.Controls.Add((Control) this.lblTotalUseTown);
    this.GroupBox2.Controls.Add((Control) this.Label11);
    this.GroupBox2.Controls.Add((Control) this.lblTotalPriceReal);
    this.GroupBox2.Controls.Add((Control) this.Label16);
    this.GroupBox2.Controls.Add((Control) this.lblTotalPriceTown);
    this.GroupBox2.Controls.Add((Control) this.Label14);
    this.GroupBox2.Controls.Add((Control) this.lblTotalPriceShared);
    this.GroupBox2.Controls.Add((Control) this.Label10);
    this.GroupBox2.Controls.Add((Control) this.lblTotalSharedUse);
    this.GroupBox2.Controls.Add((Control) this.Label12);
    this.GroupBox2.Controls.Add((Control) this.lblBillPrice);
    this.GroupBox2.Controls.Add((Control) this.Label8);
    this.GroupBox2.Controls.Add((Control) this.lblBillUse);
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.Label1);
    this.GroupBox2.Controls.Add((Control) this.txtPeriodUse);
    this.GroupBox2.Controls.Add((Control) this.lblTotalPriceHome);
    this.GroupBox2.Controls.Add((Control) this.txtBill);
    this.GroupBox2.Controls.Add((Control) this.Label5);
    this.GroupBox2.Controls.Add((Control) this.lblTotalCold);
    this.GroupBox2.Controls.Add((Control) this.lblTotal);
    this.GroupBox2.Controls.Add((Control) this.Label2);
    this.GroupBox2.Controls.Add((Control) this.Label4);
    this.GroupBox2.Controls.Add((Control) this.lblTotalHot);
    this.GroupBox2.Dock = DockStyle.Fill;
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(3, 18);
    Point point16 = point1;
    groupBox2_1.Location = point16;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(838, 331);
    Size size16 = size1;
    groupBox2_2.Size = size16;
    this.GroupBox2.TabIndex = 36;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "آمار";
    this.lblRoundPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblRoundPrice.ForeColor = Color.Black;
    Label lblRoundPrice1 = this.lblRoundPrice;
    point1 = new Point(473, 277);
    Point point17 = point1;
    lblRoundPrice1.Location = point17;
    this.lblRoundPrice.Name = "lblRoundPrice";
    Label lblRoundPrice2 = this.lblRoundPrice;
    size1 = new Size(125, 13);
    Size size17 = size1;
    lblRoundPrice2.Size = size17;
    this.lblRoundPrice.TabIndex = 54;
    this.Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label7.AutoSize = true;
    this.Label7.ForeColor = Color.Black;
    Label label7_1 = this.Label7;
    point1 = new Point(604, 277);
    Point point18 = point1;
    label7_1.Location = point18;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(159, 14);
    Size size18 = size1;
    label7_2.Size = size18;
    this.Label7.TabIndex = 53;
    this.Label7.Text = "جمع كل هزينه رند كردن (ريال)";
    this.lblFinal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblFinal.ForeColor = Color.Black;
    Label lblFinal1 = this.lblFinal;
    point1 = new Point(473, 302);
    Point point19 = point1;
    lblFinal1.Location = point19;
    this.lblFinal.Name = "lblFinal";
    Label lblFinal2 = this.lblFinal;
    size1 = new Size(125, 13);
    Size size19 = size1;
    lblFinal2.Size = size19;
    this.lblFinal.TabIndex = 52;
    this.Label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label15.AutoSize = true;
    this.Label15.ForeColor = Color.Black;
    Label label15_1 = this.Label15;
    point1 = new Point(604, 302);
    Point point20 = point1;
    label15_1.Location = point20;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(174, 14);
    Size size20 = size1;
    label15_2.Size = size20;
    this.Label15.TabIndex = 51;
    this.Label15.Text = "جمع كل مبالغ قابل پرداخت (ريال)";
    this.lblIncreaser.ForeColor = Color.Black;
    Label lblIncreaser1 = this.lblIncreaser;
    point1 = new Point(9, 140);
    Point point21 = point1;
    lblIncreaser1.Location = point21;
    this.lblIncreaser.Name = "lblIncreaser";
    Label lblIncreaser2 = this.lblIncreaser;
    size1 = new Size(125, 13);
    Size size21 = size1;
    lblIncreaser2.Size = size21;
    this.lblIncreaser.TabIndex = 50;
    this.Label13.AutoSize = true;
    this.Label13.ForeColor = Color.Black;
    Label label13_1 = this.Label13;
    point1 = new Point(140, 140);
    Point point22 = point1;
    label13_1.Location = point22;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(107, 14);
    Size size22 = size1;
    label13_2.Size = size22;
    this.Label13.TabIndex = 49;
    this.Label13.Text = "ضريب كاهشي دوره";
    this.lblTotalUseTown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotalUseTown.ForeColor = Color.Black;
    Label lblTotalUseTown1 = this.lblTotalUseTown;
    point1 = new Point(473, 222);
    Point point23 = point1;
    lblTotalUseTown1.Location = point23;
    this.lblTotalUseTown.Name = "lblTotalUseTown";
    Label lblTotalUseTown2 = this.lblTotalUseTown;
    size1 = new Size(125, 13);
    Size size23 = size1;
    lblTotalUseTown2.Size = size23;
    this.lblTotalUseTown.TabIndex = 48 /*0x30*/;
    this.Label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label11.AutoSize = true;
    this.Label11.ForeColor = Color.Black;
    Label label11_1 = this.Label11;
    point1 = new Point(604, 222);
    Point point24 = point1;
    label11_1.Location = point24;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(103, 14);
    Size size24 = size1;
    label11_2.Size = size24;
    this.Label11.TabIndex = 47;
    this.Label11.Text = "مصرف كل آب (ليتر)";
    this.lblTotalPriceReal.ForeColor = Color.Black;
    Label lblTotalPriceReal1 = this.lblTotalPriceReal;
    point1 = new Point(9, 118);
    Point point25 = point1;
    lblTotalPriceReal1.Location = point25;
    this.lblTotalPriceReal.Name = "lblTotalPriceReal";
    Label lblTotalPriceReal2 = this.lblTotalPriceReal;
    size1 = new Size(125, 13);
    Size size25 = size1;
    lblTotalPriceReal2.Size = size25;
    this.lblTotalPriceReal.TabIndex = 46;
    this.Label16.AutoSize = true;
    this.Label16.ForeColor = Color.Black;
    Label label16_1 = this.Label16;
    point1 = new Point(140, 118);
    Point point26 = point1;
    label16_1.Location = point26;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(225, 14);
    Size size26 = size1;
    label16_2.Size = size26;
    this.Label16.TabIndex = 45;
    this.Label16.Text = "جمع كل قبوض طبق تعرفه سازمان آب(ريال)";
    this.lblTotalPriceTown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotalPriceTown.ForeColor = Color.Black;
    Label lblTotalPriceTown1 = this.lblTotalPriceTown;
    point1 = new Point(473, 247);
    Point point27 = point1;
    lblTotalPriceTown1.Location = point27;
    this.lblTotalPriceTown.Name = "lblTotalPriceTown";
    Label lblTotalPriceTown2 = this.lblTotalPriceTown;
    size1 = new Size(125, 13);
    Size size27 = size1;
    lblTotalPriceTown2.Size = size27;
    this.lblTotalPriceTown.TabIndex = 44;
    this.Label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label14.AutoSize = true;
    this.Label14.ForeColor = Color.Black;
    Label label14_1 = this.Label14;
    point1 = new Point(604, 247);
    Point point28 = point1;
    label14_1.Location = point28;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(146, 14);
    Size size28 = size1;
    label14_2.Size = size28;
    this.Label14.TabIndex = 43;
    this.Label14.Text = "جمع كل قبوض صادره (ريال)";
    this.lblTotalPriceShared.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotalPriceShared.ForeColor = Color.Black;
    Label totalPriceShared1 = this.lblTotalPriceShared;
    point1 = new Point(473, 194);
    Point point29 = point1;
    totalPriceShared1.Location = point29;
    this.lblTotalPriceShared.Name = "lblTotalPriceShared";
    Label totalPriceShared2 = this.lblTotalPriceShared;
    size1 = new Size(125, 13);
    Size size29 = size1;
    totalPriceShared2.Size = size29;
    this.lblTotalPriceShared.TabIndex = 42;
    this.Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label10.AutoSize = true;
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(604, 194);
    Point point30 = point1;
    label10_1.Location = point30;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(174, 14);
    Size size30 = size1;
    label10_2.Size = size30;
    this.Label10.TabIndex = 41;
    this.Label10.Text = "جمع كل مبلغ مصرف مشاع (ريال)";
    this.lblTotalSharedUse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblTotalSharedUse.ForeColor = Color.Black;
    Label lblTotalSharedUse1 = this.lblTotalSharedUse;
    point1 = new Point(473, 166);
    Point point31 = point1;
    lblTotalSharedUse1.Location = point31;
    this.lblTotalSharedUse.Name = "lblTotalSharedUse";
    Label lblTotalSharedUse2 = this.lblTotalSharedUse;
    size1 = new Size(125, 13);
    Size size31 = size1;
    lblTotalSharedUse2.Size = size31;
    this.lblTotalSharedUse.TabIndex = 40;
    this.Label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label12.AutoSize = true;
    this.Label12.ForeColor = Color.Black;
    Label label12_1 = this.Label12;
    point1 = new Point(604, 166);
    Point point32 = point1;
    label12_1.Location = point32;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(133, 14);
    Size size32 = size1;
    label12_2.Size = size32;
    this.Label12.TabIndex = 39;
    this.Label12.Text = "مصرف كل آب مشاع(ليتر)";
    this.lblBillPrice.ForeColor = Color.Black;
    Label lblBillPrice1 = this.lblBillPrice;
    point1 = new Point(9, 249);
    Point point33 = point1;
    lblBillPrice1.Location = point33;
    this.lblBillPrice.Name = "lblBillPrice";
    Label lblBillPrice2 = this.lblBillPrice;
    size1 = new Size(125, 13);
    Size size33 = size1;
    lblBillPrice2.Size = size33;
    this.lblBillPrice.TabIndex = 38;
    this.Label8.AutoSize = true;
    this.Label8.ForeColor = Color.Black;
    Label label8_1 = this.Label8;
    point1 = new Point(140, 220);
    Point point34 = point1;
    label8_1.Location = point34;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(197, 14);
    Size size34 = size1;
    label8_2.Size = size34;
    this.Label8.TabIndex = 37;
    this.Label8.Text = "ميزان مصرف در قبض سازمان آب (ليتر)";
    this.lblBillUse.ForeColor = Color.Black;
    Label lblBillUse1 = this.lblBillUse;
    point1 = new Point(9, 221);
    Point point35 = point1;
    lblBillUse1.Location = point35;
    this.lblBillUse.Name = "lblBillUse";
    Label lblBillUse2 = this.lblBillUse;
    size1 = new Size(125, 13);
    Size size35 = size1;
    lblBillUse2.Size = size35;
    this.lblBillUse.TabIndex = 36;
    this.Label6.AutoSize = true;
    this.Label6.ForeColor = Color.Black;
    Label label6_1 = this.Label6;
    point1 = new Point(140, 248);
    Point point36 = point1;
    label6_1.Location = point36;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(192 /*0xC0*/, 14);
    Size size36 = size1;
    label6_2.Size = size36;
    this.Label6.TabIndex = 35;
    this.Label6.Text = "جمع كل مبلغ قبض سازمان آب (ريال)";
    this.txtPeriodUse.Alighment = HorizontalAlignment.Left;
    this.txtPeriodUse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPeriodUse.BackColor = Color.Transparent;
    inputButtonSettings5.DisplayPosition = 1;
    inputButtonSettings5.Enabled = false;
    this.txtPeriodUse.Button = inputButtonSettings5;
    this.txtPeriodUse.ButtonDropDownEnable = true;
    this.txtPeriodUse.ControlType = Enum_ControlType.TextBox;
    this.txtPeriodUse.DefaultLanguge = Enum_Languge.English;
    this.txtPeriodUse.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPeriodUse.InputValidation = Enum_InputValidation.Integer;
    this.txtPeriodUse.Key = "";
    this.txtPeriodUse.LabelForeColor = SystemColors.ControlText;
    this.txtPeriodUse.LabelText = "شماره دوره كنترخواني";
    InputBox txtPeriodUse1 = this.txtPeriodUse;
    point1 = new Point(615, 25);
    Point point37 = point1;
    txtPeriodUse1.Location = point37;
    this.txtPeriodUse.MaxLenght = (int) short.MaxValue;
    this.txtPeriodUse.MinLenght = 0;
    this.txtPeriodUse.Multiline = false;
    this.txtPeriodUse.Name = "txtPeriodUse";
    this.txtPeriodUse.RangeDown = "";
    this.txtPeriodUse.RangeUp = "";
    this.txtPeriodUse.RequiredField = false;
    InputBox txtPeriodUse2 = this.txtPeriodUse;
    size1 = new Size(176 /*0xB0*/, 24);
    Size size37 = size1;
    txtPeriodUse2.Size = size37;
    this.txtPeriodUse.TabIndex = 4;
    this.txtPeriodUse.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtPeriodUse.UseSystemPasswordChar = false;
    this.txtPeriodUse.WatermarkText = "";
    this.txtPeriodUse.WriteType = Enum_WriteType.Defualt;
    this.txtBill.Alighment = HorizontalAlignment.Left;
    this.txtBill.BackColor = Color.Transparent;
    inputButtonSettings6.DisplayPosition = 1;
    inputButtonSettings6.Enabled = false;
    this.txtBill.Button = inputButtonSettings6;
    this.txtBill.ButtonDropDownEnable = true;
    this.txtBill.ControlType = Enum_ControlType.TextBox;
    this.txtBill.DefaultLanguge = Enum_Languge.English;
    this.txtBill.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtBill.InputValidation = Enum_InputValidation.Integer;
    this.txtBill.Key = "";
    this.txtBill.LabelForeColor = SystemColors.ControlText;
    this.txtBill.LabelText = "شماره دوره قبض سازمان آب";
    InputBox txtBill1 = this.txtBill;
    point1 = new Point(97, 25);
    Point point38 = point1;
    txtBill1.Location = point38;
    this.txtBill.MaxLenght = (int) short.MaxValue;
    this.txtBill.MinLenght = 0;
    this.txtBill.Multiline = false;
    this.txtBill.Name = "txtBill";
    this.txtBill.RangeDown = "";
    this.txtBill.RangeUp = "";
    this.txtBill.RequiredField = false;
    InputBox txtBill2 = this.txtBill;
    size1 = new Size(203, 24);
    Size size38 = size1;
    txtBill2.Size = size38;
    this.txtBill.TabIndex = 5;
    this.txtBill.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtBill.UseSystemPasswordChar = false;
    this.txtBill.WatermarkText = "";
    this.txtBill.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(1095, 465);
    this.ClientSize = size1;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmFinalBill);
    this.Text = "قبوض صادره";
    this.WindowState = FormWindowState.Maximized;
    this.SearchBar.ResumeLayout(false);
    this.DataTable.EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual InputBox txtBlockNumber
  {
    [DebuggerNonUserCode] get => this._txtBlockNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBlockNumber = value;
    }
  }

  internal virtual InputBox txtName
  {
    [DebuggerNonUserCode] get => this._txtName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName = value;
  }

  internal virtual InputBox txtNumber
  {
    [DebuggerNonUserCode] get => this._txtNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtNumber = value;
    }
  }

  internal virtual InputBox txtUse
  {
    [DebuggerNonUserCode] get => this._txtUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtUse = value;
  }

  internal virtual InputBox txtBill
  {
    [DebuggerNonUserCode] get => this._txtBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = new InputBox.TextChangedEventHandler(this.txtBill_TextChanged);
      if (this._txtBill != null)
        this._txtBill.TextChanged -= changedEventHandler;
      this._txtBill = value;
      if (this._txtBill == null)
        return;
      this._txtBill.TextChanged += changedEventHandler;
    }
  }

  internal virtual InputBox txtPeriodUse
  {
    [DebuggerNonUserCode] get => this._txtPeriodUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.TextChangedEventHandler changedEventHandler = new InputBox.TextChangedEventHandler(this.txtBill_TextChanged);
      if (this._txtPeriodUse != null)
        this._txtPeriodUse.TextChanged -= changedEventHandler;
      this._txtPeriodUse = value;
      if (this._txtPeriodUse == null)
        return;
      this._txtPeriodUse.TextChanged += changedEventHandler;
    }
  }

  internal virtual Label lblTotalPriceHome
  {
    [DebuggerNonUserCode] get => this._lblTotalPriceHome;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalPriceHome = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label lblTotal
  {
    [DebuggerNonUserCode] get => this._lblTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTotal = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label lblTotalHot
  {
    [DebuggerNonUserCode] get => this._lblTotalHot;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalHot = value;
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
      this._lblTotalCold = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual Label lblTotalPriceReal
  {
    [DebuggerNonUserCode] get => this._lblTotalPriceReal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalPriceReal = value;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Label lblTotalPriceTown
  {
    [DebuggerNonUserCode] get => this._lblTotalPriceTown;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalPriceTown = value;
    }
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual Label lblTotalPriceShared
  {
    [DebuggerNonUserCode] get => this._lblTotalPriceShared;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalPriceShared = value;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Label lblTotalSharedUse
  {
    [DebuggerNonUserCode] get => this._lblTotalSharedUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalSharedUse = value;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual Label lblBillPrice
  {
    [DebuggerNonUserCode] get => this._lblBillPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBillPrice = value;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label lblBillUse
  {
    [DebuggerNonUserCode] get => this._lblBillUse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBillUse = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual Label lblTotalUseTown
  {
    [DebuggerNonUserCode] get => this._lblTotalUseTown;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalUseTown = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label lblIncreaser
  {
    [DebuggerNonUserCode] get => this._lblIncreaser;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblIncreaser = value;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label lblRoundPrice
  {
    [DebuggerNonUserCode] get => this._lblRoundPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblRoundPrice = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label lblFinal
  {
    [DebuggerNonUserCode] get => this._lblFinal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblFinal = value;
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  protected override void New()
  {
    base.New();
    frmFinalBillData TargetForm = new frmFinalBillData();
    if (!this.CheckOpenform((cfrmData) TargetForm))
    {
      TargetForm.Dispose();
    }
    else
    {
      TargetForm.Text = "صدور قبوض جديد";
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
    frmFinalBillData frmFinalBillData = new frmFinalBillData();
    if (!this.CheckOpenform((cfrmData) frmFinalBillData))
    {
      frmFinalBillData.Dispose();
    }
    else
    {
      frmFinalBillData.Text = "بازبيني قبوض صادره";
      frmFinalBillData.buttNext.Visible = true;
      frmFinalBillData.buttPreview.Visible = true;
      frmFinalBillData.FormType = Enum_ToolbarButtons.View;
      frmFinalBillData.FormParent = (cfrmMain) this;
      if (!this.LoadRecord((cfrmData) frmFinalBillData))
        frmFinalBillData.Dispose();
      else
        frmFinalBillData.Show();
    }
  }

  protected override bool Delete()
  {
    if (!base.Delete())
    {
      this.buttDelete.Enabled = true;
      return false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBill.Text, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPeriodUse.Text, "", false) == 0)
      return false;
    cFinalBill cFinalBill = new cFinalBill();
    cFinalBill.Identity = Conversions.ToInteger(this.txtPeriodUse.Text);
    cFinalBill.BillId = this.txtBill.Text;
    if (!cFinalBill.delete())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cFinalBill.ErrorMessage, Enum_MsgboxTitle.Alarm, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cFinalBill.ErrorDescription);
    }
    else
      this.Refreshes();
    return true;
  }

  protected override void Print()
  {
    base.Print();
    cFinalBill cFinalBill = new cFinalBill();
    cFinalBill.UseId = this.txtUse.Text;
    cFinalBill.Number = this.txtNumber.Text;
    cFinalBill.BlockNumber = this.txtBlockNumber.Text;
    cFinalBill.Name = this.txtName.Text;
    cFinalBill.PeriodUseId = this.txtPeriodUse.Text;
    cFinalBill.BillId = this.txtBill.Text;
    if (!cFinalBill.LoadReport())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cFinalBill.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cFinalBill.ErrorDescription);
    }
    else
    {
      frmPrint frmPrint = new frmPrint();
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load(Application.StartupPath + "\\rptPrint.rpt");
      reportDocument.SetDataSource(cFinalBill.ResaultTable);
      frmPrint.Text = "چاپ قبوض ";
      frmPrint.Show();
      frmPrint.CrystalReportViewer1.ReportSource = (object) reportDocument;
    }
  }

  protected override void Refreshes()
  {
    base.Refreshes();
    cFinalBill cFinalBill = new cFinalBill();
    cFinalBill.UseId = this.txtUse.Text;
    cFinalBill.Number = this.txtNumber.Text;
    cFinalBill.BlockNumber = this.txtBlockNumber.Text;
    cFinalBill.Name = this.txtName.Text;
    cFinalBill.PeriodUseId = this.txtPeriodUse.Text;
    cFinalBill.BillId = this.txtBill.Text;
    if (!cFinalBill.Load())
    {
      int num1 = (int) MessageBoxMPS.show((Form) this, cFinalBill.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cFinalBill.ErrorDescription);
    }
    else
    {
      this.DataTable = cFinalBill.ResaultTable;
      this.DataGridMain.DataSource = (object) this.DataTable;
      this.DataGridMain.Columns["Id"].DisplayIndex = 0;
      this.DataGridMain.Columns["fldPrivateIdPeriodUse"].DisplayIndex = 1;
      this.DataGridMain.Columns["fldDate"].DisplayIndex = 2;
      this.DataGridMain.Columns["fldPeriod"].DisplayIndex = 3;
      this.DataGridMain.Columns["fldPrivateIdBill"].DisplayIndex = 4;
      this.DataGridMain.Columns["fldHome"].DisplayIndex = 5;
      this.DataGridMain.Columns["fldTotalUseCold"].DisplayIndex = 6;
      this.DataGridMain.Columns["fldTotalUseHot"].DisplayIndex = 7;
      this.DataGridMain.Columns["fldTotalUseFormat"].DisplayIndex = 8;
      this.DataGridMain.Columns["fldPrivateIdPattern"].DisplayIndex = 9;
      this.DataGridMain.Columns["fldTotalPriceFormat"].DisplayIndex = 10;
      this.DataGridMain.Columns["fldRealPriceFormat"].DisplayIndex = 11;
      this.DataGridMain.Columns["fldSharedPriceFormat"].DisplayIndex = 12;
      this.DataGridMain.Columns["fldTotalRealPriceFormat"].DisplayIndex = 13;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPeriodUse.Text, "", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBill.Text, "", false) != 0 & this.DataGridMain.Rows.Count > 0)
      {
        this.lblIncreaser.Text = Conversions.ToString(this.DataGridMain.Rows[0].Cells["fldIncreaser"].Value);
        this.lblBillUse.Text = Conversions.ToString(this.DataGridMain.Rows[0].Cells["fldBillUse"].Value);
        this.lblBillPrice.Text = cFormat.Currency(Conversions.ToInteger(this.DataGridMain.Rows[0].Cells["fldBillPrice"].Value).ToString());
      }
      else
      {
        this.lblIncreaser.Text = "";
        this.lblBillUse.Text = "";
        this.lblBillPrice.Text = "";
        this.lblTotalUseTown.Text = "";
      }
      int num2 = 0;
      int num3 = 0;
      double a1 = 0.0;
      double a2 = 0.0;
      double a3 = 0.0;
      double a4 = 0.0;
      double num4 = 0.0;
      int num5 = checked (this.DataGridMain.Rows.Count - 1);
      int index = 0;
      while (index <= num5)
      {
        num2 = checked ((int) Math.Round(unchecked ((double) num2 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldTotalUseCold"].Value)))));
        num3 = checked ((int) Math.Round(unchecked ((double) num3 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldTotalUseHot"].Value)))));
        a1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldRealPrice"].Value));
        a2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldSharedPrice"].Value));
        a3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldTotalPrice"].Value));
        a4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldRoundPrice"].Value));
        num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldFinalRealPrice"].Value));
        checked { ++index; }
      }
      this.lblTotalCold.Text = cFormat.Currency(num2.ToString());
      this.lblTotalHot.Text = cFormat.Currency(num3.ToString());
      this.lblTotal.Text = cFormat.Currency(checked (num2 + num3).ToString());
      this.lblTotalPriceHome.Text = cFormat.Currency(Conversions.ToString(Math.Round(a1)));
      this.lblTotalSharedUse.Text = "";
      this.lblTotalPriceShared.Text = cFormat.Currency(Math.Round(a2).ToString());
      this.lblTotalUseTown.Text = "";
      this.lblTotalPriceTown.Text = cFormat.Currency(Conversions.ToString(a1 + a2));
      this.lblTotalPriceReal.Text = cFormat.Currency(Conversions.ToString(Math.Round(a3)));
      this.lblRoundPrice.Text = cFormat.Currency(Conversions.ToString(Math.Round(a4)));
      this.lblFinal.Text = cFormat.Currency(Conversions.ToString(num4));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBillUse.Text, "", false) != 0)
      {
        this.lblTotalSharedUse.Text = cFormat.Currency(Conversions.ToString(Conversion.Val(this.lblBillUse.Text) - (double) checked (num2 + num3)));
        this.lblBillUse.Text = cFormat.Currency(this.lblBillUse.Text);
        this.lblTotalUseTown.Text = this.lblBillUse.Text;
      }
    }
  }

  public override bool LoadRecord(cfrmData frmData)
  {
    frmFinalBillData frmFinalBillData = (frmFinalBillData) frmData;
    cFinalBill cFinalBill = new cFinalBill();
    frmFinalBillData.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (frmFinalBillData.Text + " - قبض شماره "), this.DataGridMain.SelectedRows[0].Cells["Id"].Value));
    cFinalBill.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells["Id"].Value);
    if (!cFinalBill.LoadRecord())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cFinalBill.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cFinalBill.ErrorDescription);
      return false;
    }
    if (cFinalBill.ResaultTable.Rows.Count == 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "اطلاعاتي يافت نشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      return false;
    }
    DataTable resaultTable = cFinalBill.ResaultTable;
    frmFinalBillData.FormValue = Conversions.ToInteger(resaultTable.Rows[0]["fldUseId"]);
    frmFinalBillData.lblNumber.Text = Conversions.ToString(resaultTable.Rows[0]["fldNumber"]);
    frmFinalBillData.lblBlockNumber.Text = Conversions.ToString(resaultTable.Rows[0]["fldBlockNumber"]);
    frmFinalBillData.lblName.Text = Conversions.ToString(resaultTable.Rows[0]["fldName"]);
    frmFinalBillData.lblTel.Text = Conversions.ToString(resaultTable.Rows[0]["fldTel"]);
    frmFinalBillData.txtPeriodUse.Text = Conversions.ToString(resaultTable.Rows[0]["fldPrivateIdPeriodUse"]);
    frmFinalBillData.lblFromDate.Text = Conversions.ToString(resaultTable.Rows[0]["fldStartDate"]);
    frmFinalBillData.lblToDate.Text = Conversions.ToString(resaultTable.Rows[0]["fldEndDate"]);
    frmFinalBillData.lblPeriod.Text = Conversions.ToString(resaultTable.Rows[0]["fldPeriod"]);
    frmFinalBillData.txtBillId.Text = Conversions.ToString(resaultTable.Rows[0]["fldPrivateIdBill"]);
    frmFinalBillData.lblFromDateBill.Text = Conversions.ToString(resaultTable.Rows[0]["fldStartDateBill"]);
    frmFinalBillData.lblTodateBill.Text = Conversions.ToString(resaultTable.Rows[0]["fldEndDateBill"]);
    frmFinalBillData.lblPeriodBill.Text = Conversions.ToString(resaultTable.Rows[0]["fldPeriodBill"]);
    frmFinalBillData.lblTotalUseCold.Text = Conversions.ToString(resaultTable.Rows[0]["fldTotalUseCold"]);
    frmFinalBillData.lblTotalUseHot.Text = Conversions.ToString(resaultTable.Rows[0]["fldTotalUseHot"]);
    frmFinalBillData.lblTotalUse.Text = Conversions.ToString(resaultTable.Rows[0]["fldTotalUse"]);
    Label lblAverageUse = frmFinalBillData.lblAverageUse;
    Type Type1 = typeof (Math);
    object[] objArray1 = new object[1];
    object[] objArray2 = objArray1;
    DataRow row1 = resaultTable.Rows[0];
    DataRow dataRow1 = row1;
    string columnName1 = "fldAverageUse";
    string columnName2 = columnName1;
    object objectValue1 = RuntimeHelpers.GetObjectValue(dataRow1[columnName2]);
    objArray2[0] = objectValue1;
    object[] objArray3 = objArray1;
    object[] Arguments1 = objArray3;
    bool[] flagArray1 = new bool[1]{ true };
    bool[] CopyBack1 = flagArray1;
    object obj1 = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (Type[]) null, CopyBack1);
    if (flagArray1[0])
      row1[columnName1] = RuntimeHelpers.GetObjectValue(objArray3[0]);
    string str1 = Conversions.ToString(obj1);
    lblAverageUse.Text = str1;
    frmFinalBillData.lblPatternId.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(resaultTable.Rows[0]["fldPrivateIdPattern"])) ? Conversions.ToString(resaultTable.Rows[0]["fldPrivateIdPattern"]) : "!";
    Label lblAveragePrice = frmFinalBillData.lblAveragePrice;
    Type Type2 = typeof (Math);
    object[] objArray4 = new object[1];
    object[] objArray5 = objArray4;
    DataRow row2 = resaultTable.Rows[0];
    DataRow dataRow2 = row2;
    string columnName3 = "fldMonthPrice";
    string columnName4 = columnName3;
    object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow2[columnName4]);
    objArray5[0] = objectValue2;
    object[] objArray6 = objArray4;
    object[] Arguments2 = objArray6;
    bool[] flagArray2 = new bool[1]{ true };
    bool[] CopyBack2 = flagArray2;
    object obj2 = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (Type[]) null, CopyBack2);
    if (flagArray2[0])
      row2[columnName3] = RuntimeHelpers.GetObjectValue(objArray6[0]);
    string str2 = cFormat.Currency(Conversions.ToString(obj2));
    lblAveragePrice.Text = str2;
    Label lblPrice = frmFinalBillData.lblPrice;
    Type Type3 = typeof (Math);
    object[] objArray7 = new object[1];
    object[] objArray8 = objArray7;
    DataRow row3 = resaultTable.Rows[0];
    DataRow dataRow3 = row3;
    string columnName5 = "fldPrice";
    string columnName6 = columnName5;
    object objectValue3 = RuntimeHelpers.GetObjectValue(dataRow3[columnName6]);
    objArray8[0] = objectValue3;
    object[] objArray9 = objArray7;
    object[] Arguments3 = objArray9;
    bool[] flagArray3 = new bool[1]{ true };
    bool[] CopyBack3 = flagArray3;
    object obj3 = NewLateBinding.LateGet((object) null, Type3, "Round", Arguments3, (string[]) null, (Type[]) null, CopyBack3);
    if (flagArray3[0])
      row3[columnName5] = RuntimeHelpers.GetObjectValue(objArray9[0]);
    string str3 = cFormat.Currency(Conversions.ToString(obj3));
    lblPrice.Text = str3;
    Label lblTax = frmFinalBillData.lblTax;
    Type Type4 = typeof (Math);
    object[] objArray10 = new object[1];
    object[] objArray11 = objArray10;
    DataRow row4 = resaultTable.Rows[0];
    DataRow dataRow4 = row4;
    string columnName7 = "fldTax";
    string columnName8 = columnName7;
    object objectValue4 = RuntimeHelpers.GetObjectValue(dataRow4[columnName8]);
    objArray11[0] = objectValue4;
    object[] objArray12 = objArray10;
    object[] Arguments4 = objArray12;
    bool[] flagArray4 = new bool[1]{ true };
    bool[] CopyBack4 = flagArray4;
    object obj4 = NewLateBinding.LateGet((object) null, Type4, "Round", Arguments4, (string[]) null, (Type[]) null, CopyBack4);
    if (flagArray4[0])
      row4[columnName7] = RuntimeHelpers.GetObjectValue(objArray12[0]);
    string str4 = cFormat.Currency(Conversions.ToString(obj4));
    lblTax.Text = str4;
    Label lblTotalPrice = frmFinalBillData.lblTotalPrice;
    Type Type5 = typeof (Math);
    object[] objArray13 = new object[1];
    object[] objArray14 = objArray13;
    DataRow row5 = resaultTable.Rows[0];
    DataRow dataRow5 = row5;
    string columnName9 = "fldTotalPrice";
    string columnName10 = columnName9;
    object objectValue5 = RuntimeHelpers.GetObjectValue(dataRow5[columnName10]);
    objArray14[0] = objectValue5;
    object[] objArray15 = objArray13;
    object[] Arguments5 = objArray15;
    bool[] flagArray5 = new bool[1]{ true };
    bool[] CopyBack5 = flagArray5;
    object obj5 = NewLateBinding.LateGet((object) null, Type5, "Round", Arguments5, (string[]) null, (Type[]) null, CopyBack5);
    if (flagArray5[0])
      row5[columnName9] = RuntimeHelpers.GetObjectValue(objArray15[0]);
    string str5 = cFormat.Currency(Conversions.ToString(obj5));
    lblTotalPrice.Text = str5;
    frmFinalBillData.lblIncreaser.Text = Conversions.ToString(resaultTable.Rows[0]["fldIncreaser"]);
    Label lblRealPrice = frmFinalBillData.lblRealPrice;
    Type Type6 = typeof (Math);
    object[] objArray16 = new object[1];
    object[] objArray17 = objArray16;
    DataRow row6 = resaultTable.Rows[0];
    DataRow dataRow6 = row6;
    string columnName11 = "fldRealPrice";
    string columnName12 = columnName11;
    object objectValue6 = RuntimeHelpers.GetObjectValue(dataRow6[columnName12]);
    objArray17[0] = objectValue6;
    object[] objArray18 = objArray16;
    object[] Arguments6 = objArray18;
    bool[] flagArray6 = new bool[1]{ true };
    bool[] CopyBack6 = flagArray6;
    object obj6 = NewLateBinding.LateGet((object) null, Type6, "Round", Arguments6, (string[]) null, (Type[]) null, CopyBack6);
    if (flagArray6[0])
      row6[columnName11] = RuntimeHelpers.GetObjectValue(objArray18[0]);
    string str6 = cFormat.Currency(Conversions.ToString(obj6));
    lblRealPrice.Text = str6;
    Label lblSharedPrice = frmFinalBillData.lblSharedPrice;
    Type Type7 = typeof (Math);
    object[] objArray19 = new object[1];
    object[] objArray20 = objArray19;
    DataRow row7 = resaultTable.Rows[0];
    DataRow dataRow7 = row7;
    string columnName13 = "fldSharedPrice";
    string columnName14 = columnName13;
    object objectValue7 = RuntimeHelpers.GetObjectValue(dataRow7[columnName14]);
    objArray20[0] = objectValue7;
    object[] objArray21 = objArray19;
    object[] Arguments7 = objArray21;
    bool[] flagArray7 = new bool[1]{ true };
    bool[] CopyBack7 = flagArray7;
    object obj7 = NewLateBinding.LateGet((object) null, Type7, "Round", Arguments7, (string[]) null, (Type[]) null, CopyBack7);
    if (flagArray7[0])
      row7[columnName13] = RuntimeHelpers.GetObjectValue(objArray21[0]);
    string str7 = cFormat.Currency(Conversions.ToString(obj7));
    lblSharedPrice.Text = str7;
    Label lblTotal = frmFinalBillData.lblTotal;
    Type Type8 = typeof (Math);
    object[] objArray22 = new object[1];
    object[] objArray23 = objArray22;
    DataRow row8 = resaultTable.Rows[0];
    DataRow dataRow8 = row8;
    string columnName15 = "fldTotalRealPrice";
    string columnName16 = columnName15;
    object objectValue8 = RuntimeHelpers.GetObjectValue(dataRow8[columnName16]);
    objArray23[0] = objectValue8;
    object[] objArray24 = objArray22;
    object[] Arguments8 = objArray24;
    bool[] flagArray8 = new bool[1]{ true };
    bool[] CopyBack8 = flagArray8;
    object obj8 = NewLateBinding.LateGet((object) null, Type8, "Round", Arguments8, (string[]) null, (Type[]) null, CopyBack8);
    if (flagArray8[0])
      row8[columnName15] = RuntimeHelpers.GetObjectValue(objArray24[0]);
    string str8 = cFormat.Currency(Conversions.ToString(obj8));
    lblTotal.Text = str8;
    Label lblRoundPrice = frmFinalBillData.lblRoundPrice;
    Type Type9 = typeof (Math);
    object[] objArray25 = new object[1];
    object[] objArray26 = objArray25;
    DataRow row9 = resaultTable.Rows[0];
    DataRow dataRow9 = row9;
    string columnName17 = "fldRoundPrice";
    string columnName18 = columnName17;
    object objectValue9 = RuntimeHelpers.GetObjectValue(dataRow9[columnName18]);
    objArray26[0] = objectValue9;
    object[] objArray27 = objArray25;
    object[] Arguments9 = objArray27;
    bool[] flagArray9 = new bool[1]{ true };
    bool[] CopyBack9 = flagArray9;
    object obj9 = NewLateBinding.LateGet((object) null, Type9, "Round", Arguments9, (string[]) null, (Type[]) null, CopyBack9);
    if (flagArray9[0])
      row9[columnName17] = RuntimeHelpers.GetObjectValue(objArray27[0]);
    string str9 = Conversions.ToString(obj9);
    lblRoundPrice.Text = str9;
    Label lblTotalRealPrice = frmFinalBillData.lblTotalRealPrice;
    Type Type10 = typeof (Math);
    object[] objArray28 = new object[1];
    object[] objArray29 = objArray28;
    DataRow row10 = resaultTable.Rows[0];
    DataRow dataRow10 = row10;
    string columnName19 = "fldFinalRealPrice";
    string columnName20 = columnName19;
    object objectValue10 = RuntimeHelpers.GetObjectValue(dataRow10[columnName20]);
    objArray29[0] = objectValue10;
    object[] objArray30 = objArray28;
    object[] Arguments10 = objArray30;
    bool[] flagArray10 = new bool[1]{ true };
    bool[] CopyBack10 = flagArray10;
    object obj10 = NewLateBinding.LateGet((object) null, Type10, "Round", Arguments10, (string[]) null, (Type[]) null, CopyBack10);
    if (flagArray10[0])
      row10[columnName19] = RuntimeHelpers.GetObjectValue(objArray30[0]);
    string str10 = cFormat.Currency(Conversions.ToString(obj10));
    lblTotalRealPrice.Text = str10;
    frmFinalBillData.txtDescription.Text = Conversions.ToString(resaultTable.Rows[0]["fldDescription"]);
    return true;
  }

  protected override void DataGridMain_CellFormatting(
    object sender,
    DataGridViewCellFormattingEventArgs e)
  {
    this.DataGridMain.Rows[e.RowIndex].Cells["fldDate"].Value = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.DataGridMain.Rows[e.RowIndex].Cells["fldStartDate"].Value, (object) "\r\n"), this.DataGridMain.Rows[e.RowIndex].Cells["fldEndDate"].Value);
    this.DataGridMain.Rows[e.RowIndex].Cells["fldHome"].Value = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.DataGridMain.Rows[e.RowIndex].Cells["fldNumber"].Value, (object) "\r\n"), this.DataGridMain.Rows[e.RowIndex].Cells["fldName"].Value), (object) "\r\n"), this.DataGridMain.Rows[e.RowIndex].Cells["fldBlockNumber"].Value);
    this.DataGridMain.Rows[e.RowIndex].Cells["fldTotalUseFormat"].Value = (object) cFormat.Currency(Conversions.ToString(this.DataGridMain.Rows[e.RowIndex].Cells["fldTotalUse"].Value));
    DataGridViewCell cell1 = this.DataGridMain.Rows[e.RowIndex].Cells["fldTotalPriceFormat"];
    Type Type1 = typeof (Math);
    object[] objArray1 = new object[1];
    object[] objArray2 = objArray1;
    DataGridViewCell cell2 = this.DataGridMain.Rows[e.RowIndex].Cells["fldTotalPrice"];
    object objectValue1 = RuntimeHelpers.GetObjectValue(cell2.Value);
    objArray2[0] = objectValue1;
    object[] objArray3 = objArray1;
    object[] Arguments1 = objArray3;
    bool[] flagArray1 = new bool[1]{ true };
    bool[] CopyBack1 = flagArray1;
    object obj1 = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (Type[]) null, CopyBack1);
    if (flagArray1[0])
      cell2.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
    string str1 = cFormat.Currency(Conversions.ToString(obj1));
    cell1.Value = (object) str1;
    DataGridViewCell cell3 = this.DataGridMain.Rows[e.RowIndex].Cells["fldRealPriceFormat"];
    Type Type2 = typeof (Math);
    object[] objArray4 = new object[1];
    object[] objArray5 = objArray4;
    DataGridViewCell cell4 = this.DataGridMain.Rows[e.RowIndex].Cells["fldRealPrice"];
    object objectValue2 = RuntimeHelpers.GetObjectValue(cell4.Value);
    objArray5[0] = objectValue2;
    object[] objArray6 = objArray4;
    object[] Arguments2 = objArray6;
    bool[] flagArray2 = new bool[1]{ true };
    bool[] CopyBack2 = flagArray2;
    object obj2 = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (Type[]) null, CopyBack2);
    if (flagArray2[0])
      cell4.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
    string str2 = cFormat.Currency(Conversions.ToString(obj2));
    cell3.Value = (object) str2;
    DataGridViewCell cell5 = this.DataGridMain.Rows[e.RowIndex].Cells["fldSharedPriceFormat"];
    Type Type3 = typeof (Math);
    object[] objArray7 = new object[1];
    object[] objArray8 = objArray7;
    DataGridViewCell cell6 = this.DataGridMain.Rows[e.RowIndex].Cells["fldSharedPrice"];
    object objectValue3 = RuntimeHelpers.GetObjectValue(cell6.Value);
    objArray8[0] = objectValue3;
    object[] objArray9 = objArray7;
    object[] Arguments3 = objArray9;
    bool[] flagArray3 = new bool[1]{ true };
    bool[] CopyBack3 = flagArray3;
    object obj3 = NewLateBinding.LateGet((object) null, Type3, "Round", Arguments3, (string[]) null, (Type[]) null, CopyBack3);
    if (flagArray3[0])
      cell6.Value = RuntimeHelpers.GetObjectValue(objArray9[0]);
    string str3 = cFormat.Currency(Conversions.ToString(obj3));
    cell5.Value = (object) str3;
    DataGridViewCell cell7 = this.DataGridMain.Rows[e.RowIndex].Cells["fldTotalRealPriceFormat"];
    Type Type4 = typeof (Math);
    object[] objArray10 = new object[1];
    object[] objArray11 = objArray10;
    DataGridViewCell cell8 = this.DataGridMain.Rows[e.RowIndex].Cells["fldTotalRealPrice"];
    object objectValue4 = RuntimeHelpers.GetObjectValue(cell8.Value);
    objArray11[0] = objectValue4;
    object[] objArray12 = objArray10;
    object[] Arguments4 = objArray12;
    bool[] flagArray4 = new bool[1]{ true };
    bool[] CopyBack4 = flagArray4;
    object obj4 = NewLateBinding.LateGet((object) null, Type4, "Round", Arguments4, (string[]) null, (Type[]) null, CopyBack4);
    if (flagArray4[0])
      cell8.Value = RuntimeHelpers.GetObjectValue(objArray12[0]);
    string str4 = cFormat.Currency(Conversions.ToString(obj4));
    cell7.Value = (object) str4;
    DataGridViewCell cell9 = this.DataGridMain.Rows[e.RowIndex].Cells["fldRoundPriceFormat"];
    Type Type5 = typeof (Math);
    object[] objArray13 = new object[1];
    object[] objArray14 = objArray13;
    DataGridViewCell cell10 = this.DataGridMain.Rows[e.RowIndex].Cells["fldRoundPrice"];
    object objectValue5 = RuntimeHelpers.GetObjectValue(cell10.Value);
    objArray14[0] = objectValue5;
    object[] objArray15 = objArray13;
    object[] Arguments5 = objArray15;
    bool[] flagArray5 = new bool[1]{ true };
    bool[] CopyBack5 = flagArray5;
    object obj5 = NewLateBinding.LateGet((object) null, Type5, "Round", Arguments5, (string[]) null, (Type[]) null, CopyBack5);
    if (flagArray5[0])
      cell10.Value = RuntimeHelpers.GetObjectValue(objArray15[0]);
    object objectValue6 = RuntimeHelpers.GetObjectValue(obj5);
    cell9.Value = objectValue6;
    DataGridViewCell cell11 = this.DataGridMain.Rows[e.RowIndex].Cells["fldFinalRealPriceFormat"];
    Type Type6 = typeof (Math);
    object[] objArray16 = new object[1];
    object[] objArray17 = objArray16;
    DataGridViewCell cell12 = this.DataGridMain.Rows[e.RowIndex].Cells["fldFinalRealPrice"];
    object objectValue7 = RuntimeHelpers.GetObjectValue(cell12.Value);
    objArray17[0] = objectValue7;
    object[] objArray18 = objArray16;
    object[] Arguments6 = objArray18;
    bool[] flagArray6 = new bool[1]{ true };
    bool[] CopyBack6 = flagArray6;
    object obj6 = NewLateBinding.LateGet((object) null, Type6, "Round", Arguments6, (string[]) null, (Type[]) null, CopyBack6);
    if (flagArray6[0])
      cell12.Value = RuntimeHelpers.GetObjectValue(objArray18[0]);
    string str5 = cFormat.Currency(Conversions.ToString(obj6));
    cell11.Value = (object) str5;
  }

  protected override void MakeDatagridColumn()
  {
    base.MakeDatagridColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn2 = viewTextBoxColumn1;
    viewTextBoxColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn2.HeaderText = "شماره قبض";
    viewTextBoxColumn2.Name = "fldUseId";
    viewTextBoxColumn2.Width = 40;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
    DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn4 = viewTextBoxColumn3;
    viewTextBoxColumn4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn4.HeaderText = "شماره دوره كنترخواني";
    viewTextBoxColumn4.Name = "fldPrivateIdPeriodUse";
    viewTextBoxColumn4.Width = 40;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
    DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn6 = viewTextBoxColumn5;
    viewTextBoxColumn6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn6.HeaderText = "";
    viewTextBoxColumn6.Name = "fldStartDate";
    viewTextBoxColumn6.Width = 60;
    viewTextBoxColumn6.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn5);
    DataGridViewTextBoxColumn viewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn8 = viewTextBoxColumn7;
    viewTextBoxColumn8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn8.HeaderText = "";
    viewTextBoxColumn8.Name = "fldEndDate";
    viewTextBoxColumn8.Width = 90;
    viewTextBoxColumn8.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn7);
    DataGridViewTextBoxColumn viewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn10 = viewTextBoxColumn9;
    viewTextBoxColumn10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn10.HeaderText = "دوره تاريخ قرائت";
    viewTextBoxColumn10.Name = "fldDate";
    viewTextBoxColumn10.Width = 80 /*0x50*/;
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
    viewTextBoxColumn14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn14.HeaderText = "شماره دوره قبض سازمان آب";
    viewTextBoxColumn14.Name = "fldPrivateIdBill";
    viewTextBoxColumn14.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn13);
    DataGridViewTextBoxColumn viewTextBoxColumn15 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn16 = viewTextBoxColumn15;
    viewTextBoxColumn16.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn16.HeaderText = "";
    viewTextBoxColumn16.Name = "fldNumber";
    viewTextBoxColumn16.Width = 110;
    viewTextBoxColumn16.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn15);
    DataGridViewTextBoxColumn viewTextBoxColumn17 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn18 = viewTextBoxColumn17;
    viewTextBoxColumn18.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn18.HeaderText = "";
    viewTextBoxColumn18.Name = "fldName";
    viewTextBoxColumn18.Width = 110;
    viewTextBoxColumn18.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn17);
    DataGridViewTextBoxColumn viewTextBoxColumn19 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn20 = viewTextBoxColumn19;
    viewTextBoxColumn20.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn20.HeaderText = "";
    viewTextBoxColumn20.Name = "fldBlockNumber";
    viewTextBoxColumn20.Width = 110;
    viewTextBoxColumn20.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn19);
    DataGridViewTextBoxColumn viewTextBoxColumn21 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn22 = viewTextBoxColumn21;
    viewTextBoxColumn22.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn22.HeaderText = "پلاك واحد و شماره بلوك  و نام ساكن";
    viewTextBoxColumn22.Name = "fldHome";
    viewTextBoxColumn22.Width = 150;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn21);
    DataGridViewTextBoxColumn viewTextBoxColumn23 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn24 = viewTextBoxColumn23;
    viewTextBoxColumn24.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn24.HeaderText = "ميزان استفاده آب سرد (ليتر)";
    viewTextBoxColumn24.Name = "fldTotalUseCold";
    viewTextBoxColumn24.Width = 80 /*0x50*/;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn23);
    DataGridViewTextBoxColumn viewTextBoxColumn25 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn26 = viewTextBoxColumn25;
    viewTextBoxColumn26.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn26.HeaderText = "ميزان استفاده آب گرم (ليتر)";
    viewTextBoxColumn26.Name = "fldTotalUseHot";
    viewTextBoxColumn26.Width = 80 /*0x50*/;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn25);
    DataGridViewTextBoxColumn viewTextBoxColumn27 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn28 = viewTextBoxColumn27;
    viewTextBoxColumn28.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn28.HeaderText = "مصرف كل (ليتر)";
    viewTextBoxColumn28.Name = "fldTotalUse";
    viewTextBoxColumn28.Width = 100;
    viewTextBoxColumn28.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn27);
    DataGridViewTextBoxColumn viewTextBoxColumn29 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn30 = viewTextBoxColumn29;
    viewTextBoxColumn30.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn30.HeaderText = "مصرف كل (ليتر)";
    viewTextBoxColumn30.Name = "fldTotalUseFormat";
    viewTextBoxColumn30.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn29);
    DataGridViewTextBoxColumn viewTextBoxColumn31 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn32 = viewTextBoxColumn31;
    viewTextBoxColumn32.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn32.HeaderText = "شماره پله مصرف";
    viewTextBoxColumn32.Name = "fldPrivateIdPattern";
    viewTextBoxColumn32.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn31);
    DataGridViewTextBoxColumn viewTextBoxColumn33 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn34 = viewTextBoxColumn33;
    viewTextBoxColumn34.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn34.HeaderText = "مبلغ قابل پرداخت طبق تعرفه سازمان آب (ريال)";
    viewTextBoxColumn34.Name = "fldTotalPrice";
    viewTextBoxColumn34.Width = 110;
    viewTextBoxColumn34.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn33);
    DataGridViewTextBoxColumn viewTextBoxColumn35 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn36 = viewTextBoxColumn35;
    viewTextBoxColumn36.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn36.HeaderText = "مبلغ قابل پرداخت طبق تعرفه سازمان آب (ريال)";
    viewTextBoxColumn36.Name = "fldTotalPriceFormat";
    viewTextBoxColumn36.Width = 120;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn35);
    DataGridViewTextBoxColumn viewTextBoxColumn37 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn38 = viewTextBoxColumn37;
    viewTextBoxColumn38.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn38.HeaderText = "مبلغ آب بهاي مصرفي خانگي (ريال)";
    viewTextBoxColumn38.Name = "fldRealPrice";
    viewTextBoxColumn38.Width = 100;
    viewTextBoxColumn38.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn37);
    DataGridViewTextBoxColumn viewTextBoxColumn39 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn40 = viewTextBoxColumn39;
    viewTextBoxColumn40.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn40.HeaderText = "مبلغ آب بهاي مصرفي خانگي (ريال)";
    viewTextBoxColumn40.Name = "fldRealPriceFormat";
    viewTextBoxColumn40.Width = 110;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn39);
    DataGridViewTextBoxColumn viewTextBoxColumn41 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn42 = viewTextBoxColumn41;
    viewTextBoxColumn42.Name = "fldSharedPrice";
    viewTextBoxColumn42.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn41);
    DataGridViewTextBoxColumn viewTextBoxColumn43 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn44 = viewTextBoxColumn43;
    viewTextBoxColumn44.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn44.HeaderText = "مبلغ آب بهاي مشاع (ريال)";
    viewTextBoxColumn44.Name = "fldSharedPriceFormat";
    viewTextBoxColumn44.Width = 75;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn43);
    DataGridViewTextBoxColumn viewTextBoxColumn45 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn46 = viewTextBoxColumn45;
    viewTextBoxColumn46.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn46.Name = "fldTotalRealPrice";
    viewTextBoxColumn46.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn45);
    DataGridViewTextBoxColumn viewTextBoxColumn47 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn48 = viewTextBoxColumn47;
    viewTextBoxColumn48.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn48.HeaderText = "جمع مبلغ كل آب بها (ريال)";
    viewTextBoxColumn48.Name = "fldTotalRealPriceFormat";
    viewTextBoxColumn48.Width = 80 /*0x50*/;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn47);
    DataGridViewTextBoxColumn viewTextBoxColumn49 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn50 = viewTextBoxColumn49;
    viewTextBoxColumn50.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn50.Name = "fldSharedPrice";
    viewTextBoxColumn50.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn49);
    DataGridViewTextBoxColumn viewTextBoxColumn51 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn52 = viewTextBoxColumn51;
    viewTextBoxColumn52.Name = "fldIncreaser";
    viewTextBoxColumn52.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn51);
    DataGridViewTextBoxColumn viewTextBoxColumn53 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn54 = viewTextBoxColumn53;
    viewTextBoxColumn54.Name = "fldBillPrice";
    viewTextBoxColumn54.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn53);
    DataGridViewTextBoxColumn viewTextBoxColumn55 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn56 = viewTextBoxColumn55;
    viewTextBoxColumn56.Name = "fldBillUse";
    viewTextBoxColumn56.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn55);
    DataGridViewTextBoxColumn viewTextBoxColumn57 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn58 = viewTextBoxColumn57;
    viewTextBoxColumn58.Name = "fldRoundPrice";
    viewTextBoxColumn58.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn57);
    DataGridViewTextBoxColumn viewTextBoxColumn59 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn60 = viewTextBoxColumn59;
    viewTextBoxColumn60.HeaderText = "هزينه رند كردن (ريال)";
    viewTextBoxColumn60.Name = "fldRoundPriceFormat";
    viewTextBoxColumn60.Width = 65;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn59);
    DataGridViewTextBoxColumn viewTextBoxColumn61 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn62 = viewTextBoxColumn61;
    viewTextBoxColumn62.Name = "fldFinalRealPrice";
    viewTextBoxColumn62.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn61);
    DataGridViewTextBoxColumn viewTextBoxColumn63 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn64 = viewTextBoxColumn63;
    viewTextBoxColumn64.HeaderText = "مبلغ قابل پرداخت (ريال)";
    viewTextBoxColumn64.Name = "fldFinalRealPriceFormat";
    viewTextBoxColumn64.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn63);
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
    this.txtBlockNumber.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtName.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtPeriodUse.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtBill.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtUse.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
  }

  private void txtBill_TextChanged(object sender)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPeriodUse.Text, "", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtBill.Text, "", false) != 0)
      this.buttDelete.Enabled = true;
    else
      this.buttDelete.Enabled = false;
  }
}
