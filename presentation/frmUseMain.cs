// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmUseMain
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
public class frmUseMain : cfrmMain
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtPeriod")]
  private InputBox _txtPeriod;
  [AccessedThroughProperty("txtName")]
  private InputBox _txtName;
  [AccessedThroughProperty("txtNumber")]
  private InputBox _txtNumber;
  [AccessedThroughProperty("lblTotalCold")]
  private Label _lblTotalCold;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("lblTotal")]
  private Label _lblTotal;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("lblTotalHot")]
  private Label _lblTotalHot;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtBlockNumber")]
  private InputBox _txtBlockNumber;
  [AccessedThroughProperty("lblTotalPrice")]
  private Label _lblTotalPrice;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;

  [DebuggerNonUserCode]
  static frmUseMain()
  {
  }

  [DebuggerNonUserCode]
  public frmUseMain()
  {
    frmUseMain.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmUseMain.__ENCList)
    {
      if (frmUseMain.__ENCList.Count == frmUseMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmUseMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmUseMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmUseMain.__ENCList[index1] = frmUseMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmUseMain.__ENCList.RemoveRange(index1, checked (frmUseMain.__ENCList.Count - index1));
        frmUseMain.__ENCList.Capacity = frmUseMain.__ENCList.Count;
      }
      frmUseMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUseMain));
    this.lblTotalCold = new Label();
    this.Label1 = new Label();
    this.lblTotal = new Label();
    this.Label4 = new Label();
    this.lblTotalHot = new Label();
    this.Label2 = new Label();
    this.txtName = new InputBox();
    this.txtNumber = new InputBox();
    this.txtPeriod = new InputBox();
    this.txtBlockNumber = new InputBox();
    this.lblTotalPrice = new Label();
    this.Label5 = new Label();
    this.SearchBar.SuspendLayout();
    this.DataTable.BeginInit();
    this.SuspendLayout();
    this.SearchBar.Controls.Add((Control) this.lblTotalPrice);
    this.SearchBar.Controls.Add((Control) this.Label5);
    this.SearchBar.Controls.Add((Control) this.txtBlockNumber);
    this.SearchBar.Controls.Add((Control) this.lblTotal);
    this.SearchBar.Controls.Add((Control) this.Label4);
    this.SearchBar.Controls.Add((Control) this.lblTotalHot);
    this.SearchBar.Controls.Add((Control) this.Label2);
    this.SearchBar.Controls.Add((Control) this.lblTotalCold);
    this.SearchBar.Controls.Add((Control) this.Label1);
    this.SearchBar.Controls.Add((Control) this.txtName);
    this.SearchBar.Controls.Add((Control) this.txtNumber);
    this.SearchBar.Controls.Add((Control) this.txtPeriod);
    GroupBox searchBar1 = this.SearchBar;
    Point point1 = new Point(0, 577);
    Point point2 = point1;
    searchBar1.Location = point2;
    GroupBox searchBar2 = this.SearchBar;
    Size size1 = new Size(849, 122);
    Size size2 = size1;
    searchBar2.Size = size2;
    this.lblTotalCold.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblTotalCold.ForeColor = Color.Blue;
    Label lblTotalCold1 = this.lblTotalCold;
    point1 = new Point(12, 18);
    Point point3 = point1;
    lblTotalCold1.Location = point3;
    this.lblTotalCold.Name = "lblTotalCold";
    Label lblTotalCold2 = this.lblTotalCold;
    size1 = new Size(125, 13);
    Size size3 = size1;
    lblTotalCold2.Size = size3;
    this.lblTotalCold.TabIndex = 14;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label1.AutoSize = true;
    this.Label1.ForeColor = Color.Blue;
    Label label1_1 = this.Label1;
    point1 = new Point(143, 18);
    Point point4 = point1;
    label1_1.Location = point4;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(130, 14);
    Size size4 = size1;
    label1_2.Size = size4;
    this.Label1.TabIndex = 13;
    this.Label1.Text = "مصرف كل آب سرد (ليتر)";
    this.lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblTotal.ForeColor = Color.Black;
    Label lblTotal1 = this.lblTotal;
    point1 = new Point(12, 68);
    Point point5 = point1;
    lblTotal1.Location = point5;
    this.lblTotal.Name = "lblTotal";
    Label lblTotal2 = this.lblTotal;
    size1 = new Size(125, 13);
    Size size5 = size1;
    lblTotal2.Size = size5;
    this.lblTotal.TabIndex = 19;
    this.Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label4.AutoSize = true;
    this.Label4.ForeColor = Color.Black;
    Label label4_1 = this.Label4;
    point1 = new Point(143, 68);
    Point point6 = point1;
    label4_1.Location = point6;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(103, 14);
    Size size6 = size1;
    label4_2.Size = size6;
    this.Label4.TabIndex = 18;
    this.Label4.Text = "مصرف كل آب (ليتر)";
    this.lblTotalHot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblTotalHot.ForeColor = Color.Red;
    Label lblTotalHot1 = this.lblTotalHot;
    point1 = new Point(12, 43);
    Point point7 = point1;
    lblTotalHot1.Location = point7;
    this.lblTotalHot.Name = "lblTotalHot";
    Label lblTotalHot2 = this.lblTotalHot;
    size1 = new Size(125, 13);
    Size size7 = size1;
    lblTotalHot2.Size = size7;
    this.lblTotalHot.TabIndex = 17;
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label2.AutoSize = true;
    this.Label2.ForeColor = Color.Red;
    Label label2_1 = this.Label2;
    point1 = new Point(143, 43);
    Point point8 = point1;
    label2_1.Location = point8;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(125, 14);
    Size size8 = size1;
    label2_2.Size = size8;
    this.Label2.TabIndex = 16 /*0x10*/;
    this.Label2.Text = "مصرف كل آب گرم (ليتر)";
    this.txtName.Alighment = HorizontalAlignment.Left;
    this.txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtName.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtName.Button = inputButtonSettings1;
    this.txtName.ButtonDropDownEnable = true;
    this.txtName.ControlType = Enum_ControlType.TextBox;
    this.txtName.DefaultLanguge = Enum_Languge.Persian;
    this.txtName.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtName.InputValidation = Enum_InputValidation.All;
    this.txtName.Key = "";
    this.txtName.LabelForeColor = SystemColors.ControlText;
    this.txtName.LabelText = "نام ساكن";
    InputBox txtName1 = this.txtName;
    point1 = new Point(459, 61);
    Point point9 = point1;
    txtName1.Location = point9;
    this.txtName.MaxLenght = 50;
    this.txtName.MinLenght = 1;
    this.txtName.Multiline = false;
    this.txtName.Name = "txtName";
    this.txtName.RangeDown = "";
    this.txtName.RangeUp = "";
    this.txtName.RequiredField = false;
    InputBox txtName2 = this.txtName;
    size1 = new Size(202, 24);
    Size size9 = size1;
    txtName2.Size = size9;
    this.txtName.TabIndex = 5;
    this.txtName.ToolTipText = "نام ساكن فعلي منزل را در اين قسمت وارد نمائيد";
    this.txtName.UseSystemPasswordChar = false;
    this.txtName.WatermarkText = "";
    this.txtName.WriteType = Enum_WriteType.Defualt;
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
    point1 = new Point(541, 35);
    Point point10 = point1;
    txtNumber1.Location = point10;
    this.txtNumber.MaxLenght = 3;
    this.txtNumber.MinLenght = 1;
    this.txtNumber.Multiline = false;
    this.txtNumber.Name = "txtNumber";
    this.txtNumber.RangeDown = "1";
    this.txtNumber.RangeUp = "999";
    this.txtNumber.RequiredField = false;
    InputBox txtNumber2 = this.txtNumber;
    size1 = new Size(96 /*0x60*/, 24);
    Size size10 = size1;
    txtNumber2.Size = size10;
    this.txtNumber.TabIndex = 4;
    this.txtNumber.ToolTipText = "پلاك واحد را در اين قسمت وارد نمائيد";
    this.txtNumber.UseSystemPasswordChar = false;
    this.txtNumber.WatermarkText = "";
    this.txtNumber.WriteType = Enum_WriteType.Defualt;
    this.txtPeriod.Alighment = HorizontalAlignment.Left;
    this.txtPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPeriod.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtPeriod.Button = inputButtonSettings3;
    this.txtPeriod.ButtonDropDownEnable = true;
    this.txtPeriod.ControlType = Enum_ControlType.TextBox;
    this.txtPeriod.DefaultLanguge = Enum_Languge.English;
    this.txtPeriod.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPeriod.InputValidation = Enum_InputValidation.Integer;
    this.txtPeriod.Key = "";
    this.txtPeriod.LabelForeColor = SystemColors.ControlText;
    this.txtPeriod.LabelText = "شماره دوره";
    InputBox txtPeriod1 = this.txtPeriod;
    point1 = new Point(693, 35);
    Point point11 = point1;
    txtPeriod1.Location = point11;
    this.txtPeriod.MaxLenght = (int) short.MaxValue;
    this.txtPeriod.MinLenght = 0;
    this.txtPeriod.Multiline = false;
    this.txtPeriod.Name = "txtPeriod";
    this.txtPeriod.RangeDown = "";
    this.txtPeriod.RangeUp = "";
    this.txtPeriod.RequiredField = false;
    InputBox txtPeriod2 = this.txtPeriod;
    size1 = new Size(126, 24);
    Size size11 = size1;
    txtPeriod2.Size = size11;
    this.txtPeriod.TabIndex = 1;
    this.txtPeriod.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtPeriod.UseSystemPasswordChar = false;
    this.txtPeriod.WatermarkText = "";
    this.txtPeriod.WriteType = Enum_WriteType.Defualt;
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
    point1 = new Point(693, 61);
    Point point12 = point1;
    txtBlockNumber1.Location = point12;
    this.txtBlockNumber.MaxLenght = (int) short.MaxValue;
    this.txtBlockNumber.MinLenght = 0;
    this.txtBlockNumber.Multiline = false;
    this.txtBlockNumber.Name = "txtBlockNumber";
    this.txtBlockNumber.RangeDown = "";
    this.txtBlockNumber.RangeUp = "";
    this.txtBlockNumber.RequiredField = false;
    InputBox txtBlockNumber2 = this.txtBlockNumber;
    size1 = new Size((int) sbyte.MaxValue, 24);
    Size size12 = size1;
    txtBlockNumber2.Size = size12;
    this.txtBlockNumber.TabIndex = 20;
    this.txtBlockNumber.ToolTipText = "شماره دوره را در اين قسمت وارد نمائيد";
    this.txtBlockNumber.UseSystemPasswordChar = false;
    this.txtBlockNumber.WatermarkText = "";
    this.txtBlockNumber.WriteType = Enum_WriteType.Defualt;
    this.lblTotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblTotalPrice.ForeColor = Color.Black;
    Label lblTotalPrice1 = this.lblTotalPrice;
    point1 = new Point(12, 96 /*0x60*/);
    Point point13 = point1;
    lblTotalPrice1.Location = point13;
    this.lblTotalPrice.Name = "lblTotalPrice";
    Label lblTotalPrice2 = this.lblTotalPrice;
    size1 = new Size(125, 13);
    Size size13 = size1;
    lblTotalPrice2.Size = size13;
    this.lblTotalPrice.TabIndex = 22;
    this.Label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label5.AutoSize = true;
    this.Label5.ForeColor = Color.Black;
    Label label5_1 = this.Label5;
    point1 = new Point(143, 96 /*0x60*/);
    Point point14 = point1;
    label5_1.Location = point14;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(106, 14);
    Size size14 = size1;
    label5_2.Size = size14;
    this.Label5.TabIndex = 21;
    this.Label5.Text = "جمع كل مبلغ (ريال)";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(849, 721);
    this.ClientSize = size1;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmUseMain);
    this.Text = "مصرف واحدها";
    this.SearchBar.ResumeLayout(false);
    this.SearchBar.PerformLayout();
    this.DataTable.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual InputBox txtPeriod
  {
    [DebuggerNonUserCode] get => this._txtPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPeriod = value;
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

  internal virtual InputBox txtBlockNumber
  {
    [DebuggerNonUserCode] get => this._txtBlockNumber;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBlockNumber = value;
    }
  }

  internal virtual Label lblTotalPrice
  {
    [DebuggerNonUserCode] get => this._lblTotalPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalPrice = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  protected override void New()
  {
    base.New();
    frmUseData TargetForm = new frmUseData();
    if (!this.CheckOpenform((cfrmData) TargetForm))
    {
      TargetForm.Dispose();
    }
    else
    {
      TargetForm.Text = "اضافه كردن مصرف جديد";
      TargetForm.buttAdd.Visible = true;
      TargetForm.FormType = Enum_ToolbarButtons.New;
      TargetForm.FormParent = (cfrmMain) this;
      TargetForm.Show();
      Label lblAverage = TargetForm.lblAverage;
      frmUseData frmUseData = TargetForm;
      EventHandler eventHandler = (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => frmUseData.FindPattern());
      lblAverage.TextChanged += eventHandler;
    }
  }

  protected override void View()
  {
    base.View();
    frmUseData frmUseData = new frmUseData();
    if (!this.CheckOpenform((cfrmData) frmUseData))
    {
      frmUseData.Dispose();
    }
    else
    {
      frmUseData.Text = "بازبيني اطلاعات مصرف ها";
      frmUseData.buttNext.Visible = true;
      frmUseData.buttPreview.Visible = true;
      frmUseData.FormType = Enum_ToolbarButtons.View;
      frmUseData.FormParent = (cfrmMain) this;
      if (!this.LoadRecord((cfrmData) frmUseData))
        frmUseData.Dispose();
      else
        frmUseData.Show();
    }
  }

  protected override void Edit()
  {
    base.Edit();
    frmUseData frmUseData1 = new frmUseData();
    if (!this.CheckOpenform((cfrmData) frmUseData1))
    {
      frmUseData1.Dispose();
    }
    else
    {
      cUse cUse = new cUse();
      cUse.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells["Id"].Value);
      if (cUse.CheckForLock())
      {
        frmUseData1.Text = "ويرايش اطلاعات مصرف ها";
        frmUseData1.buttAdd.Visible = true;
        frmUseData1.FormType = Enum_ToolbarButtons.Edit;
        frmUseData1.FormParent = (cfrmMain) this;
        if (!this.LoadRecord((cfrmData) frmUseData1))
        {
          frmUseData1.Dispose();
        }
        else
        {
          frmUseData1.Show();
          Label lblAverage = frmUseData1.lblAverage;
          frmUseData frmUseData = frmUseData1;
          EventHandler eventHandler = (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => frmUseData.FindPattern());
          lblAverage.TextChanged += eventHandler;
        }
      }
      else
      {
        int num = (int) MessageBoxMPS.show((Form) this, "براي اين قبض مصرف ، قبض آب صادر شده است شما مجاز به ويرايش نميباشد", Enum_MsgboxTitle.Permission, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
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
      cUse cUse = new cUse();
      cUse.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[index1].Cells["Id"].Value);
      string str2 = Conversions.ToString(cUse.Identity);
      if (!cUse.CheckForLock())
        str1 = $"{str1}\r\nسند شماره {Conversions.ToString(cUse.Identity)} : براي اين قبض مصرف ، قبض آب صادر شده است شما مجاز به حذف نميباشد";
      else if (!cUse.delete())
        str1 = $"{str1}\r\nسند شماره {Conversions.ToString(cUse.Identity)} : {cUse.ErrorDescription}";
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
    cUse cUse = new cUse();
    cUse.PrivateId = this.txtPeriod.Text;
    cUse.Name = this.txtName.Text;
    cUse.Number = this.txtNumber.Text;
    cUse.BlockNumber = this.txtBlockNumber.Text;
    if (!cUse.Load())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cUse.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cUse.ErrorDescription);
      this.lblTotalCold.Text = "";
      this.lblTotalHot.Text = "";
      this.lblTotal.Text = "";
    }
    else
    {
      this.DataTable = cUse.ResaultTable;
      this.DataGridMain.DataSource = (object) this.DataTable;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = checked (this.DataGridMain.Rows.Count - 1);
      int index = 0;
      while (index <= num4)
      {
        num1 = checked ((int) Math.Round(unchecked ((double) num1 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldTotalUseCold"].Value)))));
        num2 = checked ((int) Math.Round(unchecked ((double) num2 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldTotalUseHot"].Value)))));
        num3 = checked ((int) Math.Round(unchecked ((double) num3 + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridMain.Rows[index].Cells["fldTotalPrice"].Value)))));
        checked { ++index; }
      }
      this.lblTotalCold.Text = cFormat.Currency(num1.ToString());
      this.lblTotalHot.Text = cFormat.Currency(num2.ToString());
      this.lblTotal.Text = cFormat.Currency(checked (num1 + num2).ToString());
      this.lblTotalPrice.Text = cFormat.Currency(num3.ToString());
    }
  }

  public override bool LoadRecord(cfrmData frmData)
  {
    frmUseData frmUseData = (frmUseData) frmData;
    cUse cUse = new cUse();
    cUse.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells["Id"].Value);
    if (!cUse.LoadRecord())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cUse.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cUse.ErrorDescription);
      return false;
    }
    if (cUse.ResaultTable.Rows.Count == 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "اطلاعاتي يافت نشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      return false;
    }
    DataTable resaultTable = cUse.ResaultTable;
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(resaultTable.Rows[0]["fldPatternIdUse"])))
      frmUseData.PrPatternId = Conversions.ToString(resaultTable.Rows[0]["fldPatternIdUse"]);
    frmUseData.lblPeriod.Text = Conversions.ToString(resaultTable.Rows[0]["fldPeriod"]);
    frmUseData.FormValue = Conversions.ToInteger(resaultTable.Rows[0]["fldUseId"]);
    frmUseData.txtNumber.Text = Conversions.ToString(resaultTable.Rows[0]["fldNumber"]);
    frmUseData.txtPrivateId.Text = Conversions.ToString(resaultTable.Rows[0]["fldPrivateIdPeriodUse"]);
    frmUseData.txtLastDigitCold.Text = Conversions.ToString(resaultTable.Rows[0]["fldLastDigitCold"]);
    frmUseData.txtNewDigitCold.Text = Conversions.ToString(resaultTable.Rows[0]["fldNewDigitCold"]);
    frmUseData.txtLastDigitHot.Text = Conversions.ToString(resaultTable.Rows[0]["fldLastDigitHot"]);
    frmUseData.txtNewDigitHot.Text = Conversions.ToString(resaultTable.Rows[0]["fldNewDigitHot"]);
    frmUseData.lblPatternId.Text = Information.IsDBNull(RuntimeHelpers.GetObjectValue(resaultTable.Rows[0]["fldPrivateIdPattern"])) ? "!" : Conversions.ToString(resaultTable.Rows[0]["fldPrivateIdPattern"]);
    int num1 = 0;
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(resaultTable.Rows[0]["fldPrice"])))
      num1 = Conversions.ToInteger(resaultTable.Rows[0]["fldPrice"]);
    frmUseData.lblPrice.Text = cFormat.Currency(num1.ToString());
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
    Type Type = typeof (Math);
    object[] objArray1 = new object[1];
    object[] objArray2 = objArray1;
    DataGridViewCell cell2 = this.DataGridMain.Rows[e.RowIndex].Cells["fldTotalPrice"];
    object objectValue = RuntimeHelpers.GetObjectValue(cell2.Value);
    objArray2[0] = objectValue;
    object[] objArray3 = objArray1;
    object[] Arguments = objArray3;
    bool[] flagArray = new bool[1]{ true };
    bool[] CopyBack = flagArray;
    object obj = NewLateBinding.LateGet((object) null, Type, "Round", Arguments, (string[]) null, (Type[]) null, CopyBack);
    if (flagArray[0])
      cell2.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
    string str = cFormat.Currency(Conversions.ToString(obj));
    cell1.Value = (object) str;
  }

  protected override void MakeDatagridColumn()
  {
    base.MakeDatagridColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn2 = viewTextBoxColumn1;
    viewTextBoxColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn2.HeaderText = "";
    viewTextBoxColumn2.Name = "fldUseId";
    viewTextBoxColumn2.Visible = false;
    viewTextBoxColumn2.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
    DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn4 = viewTextBoxColumn3;
    viewTextBoxColumn4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn4.HeaderText = "دوره مصرف";
    viewTextBoxColumn4.Name = "fldPrivateIdPeriodUse";
    viewTextBoxColumn4.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
    DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn6 = viewTextBoxColumn5;
    viewTextBoxColumn6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn6.HeaderText = "";
    viewTextBoxColumn6.Name = "fldStartDate";
    viewTextBoxColumn6.Width = 90;
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
    viewTextBoxColumn10.HeaderText = "تاريخ دوره مصرف";
    viewTextBoxColumn10.Name = "fldDate";
    viewTextBoxColumn10.Width = 90;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn9);
    DataGridViewTextBoxColumn viewTextBoxColumn11 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn12 = viewTextBoxColumn11;
    viewTextBoxColumn12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn12.HeaderText = "";
    viewTextBoxColumn12.Name = "fldNumber";
    viewTextBoxColumn12.Width = 110;
    viewTextBoxColumn12.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn11);
    DataGridViewTextBoxColumn viewTextBoxColumn13 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn14 = viewTextBoxColumn13;
    viewTextBoxColumn14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn14.HeaderText = "";
    viewTextBoxColumn14.Name = "fldName";
    viewTextBoxColumn14.Width = 110;
    viewTextBoxColumn14.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn13);
    DataGridViewTextBoxColumn viewTextBoxColumn15 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn16 = viewTextBoxColumn15;
    viewTextBoxColumn16.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn16.HeaderText = "";
    viewTextBoxColumn16.Name = "fldBlockNumber";
    viewTextBoxColumn16.Width = 110;
    viewTextBoxColumn16.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn15);
    DataGridViewTextBoxColumn viewTextBoxColumn17 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn18 = viewTextBoxColumn17;
    viewTextBoxColumn18.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn18.HeaderText = "پلاك واحد و شماره بلوك  و نام ساكن";
    viewTextBoxColumn18.Name = "fldHome";
    viewTextBoxColumn18.Width = 200;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn17);
    DataGridViewTextBoxColumn viewTextBoxColumn19 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn20 = viewTextBoxColumn19;
    viewTextBoxColumn20.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn20.HeaderText = "ميزان استفاده آب سرد (ليتر)";
    viewTextBoxColumn20.Name = "fldTotalUseCold";
    viewTextBoxColumn20.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn19);
    DataGridViewTextBoxColumn viewTextBoxColumn21 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn22 = viewTextBoxColumn21;
    viewTextBoxColumn22.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn22.HeaderText = "ميزان استفاده آب گرم (ليتر)";
    viewTextBoxColumn22.Name = "fldTotalUseHot";
    viewTextBoxColumn22.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn21);
    DataGridViewTextBoxColumn viewTextBoxColumn23 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn24 = viewTextBoxColumn23;
    viewTextBoxColumn24.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn24.HeaderText = "مصرف كل (ليتر)";
    viewTextBoxColumn24.Name = "fldTotalUse";
    viewTextBoxColumn24.Width = 100;
    viewTextBoxColumn24.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn23);
    DataGridViewTextBoxColumn viewTextBoxColumn25 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn26 = viewTextBoxColumn25;
    viewTextBoxColumn26.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn26.HeaderText = "مصرف كل (ليتر)";
    viewTextBoxColumn26.Name = "fldTotalUseFormat";
    viewTextBoxColumn26.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn25);
    DataGridViewTextBoxColumn viewTextBoxColumn27 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn28 = viewTextBoxColumn27;
    viewTextBoxColumn28.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn28.HeaderText = "شماره پله مصرف";
    viewTextBoxColumn28.Name = "fldPrivateIdPattern";
    viewTextBoxColumn28.Width = 60;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn27);
    DataGridViewTextBoxColumn viewTextBoxColumn29 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn30 = viewTextBoxColumn29;
    viewTextBoxColumn30.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn30.HeaderText = "مبلغ قابل پرداخت طبق تعرفه سازمان آب (ريال)";
    viewTextBoxColumn30.Name = "fldTotalPrice";
    viewTextBoxColumn30.Width = 120;
    viewTextBoxColumn30.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn29);
    DataGridViewTextBoxColumn viewTextBoxColumn31 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn32 = viewTextBoxColumn31;
    viewTextBoxColumn32.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn32.HeaderText = "مبلغ قابل پرداخت طبق تعرفه سازمان آب (ريال)";
    viewTextBoxColumn32.Name = "fldTotalPriceFormat";
    viewTextBoxColumn32.Width = 120;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn31);
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
    viewTextBoxColumn3.DisplayIndex = 0;
    viewTextBoxColumn9.DisplayIndex = 1;
    viewTextBoxColumn17.DisplayIndex = 2;
    viewTextBoxColumn19.DisplayIndex = 3;
    viewTextBoxColumn21.DisplayIndex = 4;
    viewTextBoxColumn25.DisplayIndex = 5;
    viewTextBoxColumn27.DisplayIndex = 6;
    viewTextBoxColumn31.DisplayIndex = 7;
  }

  protected override void SetDatagridSetting()
  {
    base.SetDatagridSetting();
    this.txtNumber.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtName.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtPeriod.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
    this.txtBlockNumber.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
  }
}
