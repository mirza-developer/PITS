// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmPatternData
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
public class frmPatternData : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtPrivateId")]
  private InputBox _txtPrivateId;
  [AccessedThroughProperty("txtToDigit")]
  private InputBox _txtToDigit;
  [AccessedThroughProperty("txtPrice")]
  private InputBox _txtPrice;

  [DebuggerNonUserCode]
  static frmPatternData()
  {
  }

  [DebuggerNonUserCode]
  public frmPatternData()
  {
    this.Shown += new EventHandler(this.frmPatternData_Shown);
    frmPatternData.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPatternData.__ENCList)
    {
      if (frmPatternData.__ENCList.Count == frmPatternData.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPatternData.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPatternData.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPatternData.__ENCList[index1] = frmPatternData.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPatternData.__ENCList.RemoveRange(index1, checked (frmPatternData.__ENCList.Count - index1));
        frmPatternData.__ENCList.Capacity = frmPatternData.__ENCList.Count;
      }
      frmPatternData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPatternData));
    this.txtPrivateId = new InputBox();
    this.txtToDigit = new InputBox();
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
    this.txtPrivateId.LabelText = "شماره پله مصرف";
    InputBox txtPrivateId1 = this.txtPrivateId;
    Point point1 = new Point(122, 66);
    Point point2 = point1;
    txtPrivateId1.Location = point2;
    this.txtPrivateId.MaxLenght = 3;
    this.txtPrivateId.MinLenght = 0;
    this.txtPrivateId.Multiline = false;
    this.txtPrivateId.Name = "txtPrivateId";
    this.txtPrivateId.RangeDown = "";
    this.txtPrivateId.RangeUp = "224";
    this.txtPrivateId.RequiredField = true;
    InputBox txtPrivateId2 = this.txtPrivateId;
    Size size1 = new Size(158, 24);
    Size size2 = size1;
    txtPrivateId2.Size = size2;
    this.txtPrivateId.TabIndex = 0;
    this.txtPrivateId.ToolTipText = "لطفا شماره پله مصرف را در اين قسمت وارد نمائيد";
    this.txtPrivateId.UseSystemPasswordChar = false;
    this.txtPrivateId.WatermarkText = "";
    this.txtPrivateId.WriteType = Enum_WriteType.Defualt;
    this.txtToDigit.Alighment = HorizontalAlignment.Left;
    this.txtToDigit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtToDigit.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtToDigit.Button = inputButtonSettings2;
    this.txtToDigit.ButtonDropDownEnable = true;
    this.txtToDigit.ControlType = Enum_ControlType.TextBox;
    this.txtToDigit.DefaultLanguge = Enum_Languge.English;
    this.txtToDigit.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtToDigit.InputValidation = Enum_InputValidation.Integer;
    this.txtToDigit.Key = "";
    this.txtToDigit.LabelForeColor = SystemColors.ControlText;
    this.txtToDigit.LabelText = "سقف مصرف (ليتر)";
    InputBox txtToDigit1 = this.txtToDigit;
    point1 = new Point(57, 96 /*0x60*/);
    Point point3 = point1;
    txtToDigit1.Location = point3;
    this.txtToDigit.MaxLenght = (int) short.MaxValue;
    this.txtToDigit.MinLenght = 0;
    this.txtToDigit.Multiline = false;
    this.txtToDigit.Name = "txtToDigit";
    this.txtToDigit.RangeDown = "";
    this.txtToDigit.RangeUp = "";
    this.txtToDigit.RequiredField = true;
    InputBox txtToDigit2 = this.txtToDigit;
    size1 = new Size(231, 24);
    Size size3 = size1;
    txtToDigit2.Size = size3;
    this.txtToDigit.TabIndex = 1;
    this.txtToDigit.ToolTipText = "سقف مصرف را در اين قسمت وارد نمائيد";
    this.txtToDigit.UseSystemPasswordChar = false;
    this.txtToDigit.WatermarkText = "";
    this.txtToDigit.WriteType = Enum_WriteType.Defualt;
    this.txtPrice.Alighment = HorizontalAlignment.Left;
    this.txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPrice.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtPrice.Button = inputButtonSettings3;
    this.txtPrice.ButtonDropDownEnable = true;
    this.txtPrice.ControlType = Enum_ControlType.TextBox;
    this.txtPrice.DefaultLanguge = Enum_Languge.English;
    this.txtPrice.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPrice.InputValidation = Enum_InputValidation.Currency;
    this.txtPrice.Key = "";
    this.txtPrice.LabelForeColor = SystemColors.ControlText;
    this.txtPrice.LabelText = "مبلغ (ريال)";
    InputBox txtPrice1 = this.txtPrice;
    point1 = new Point(57, 126);
    Point point4 = point1;
    txtPrice1.Location = point4;
    this.txtPrice.MaxLenght = (int) short.MaxValue;
    this.txtPrice.MinLenght = 0;
    this.txtPrice.Multiline = false;
    this.txtPrice.Name = "txtPrice";
    this.txtPrice.RangeDown = "";
    this.txtPrice.RangeUp = "";
    this.txtPrice.RequiredField = true;
    InputBox txtPrice2 = this.txtPrice;
    size1 = new Size(192 /*0xC0*/, 24);
    Size size4 = size1;
    txtPrice2.Size = size4;
    this.txtPrice.TabIndex = 2;
    this.txtPrice.ToolTipText = "لطفا مبلغ را در اين قسمت وارد نمائيد";
    this.txtPrice.UseSystemPasswordChar = false;
    this.txtPrice.WatermarkText = "";
    this.txtPrice.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(313, 180);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtPrivateId);
    this.Controls.Add((Control) this.txtToDigit);
    this.Controls.Add((Control) this.txtPrice);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmPatternData);
    this.Text = nameof (frmPatternData);
    this.Controls.SetChildIndex((Control) this.txtPrice, 0);
    this.Controls.SetChildIndex((Control) this.txtToDigit, 0);
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

  internal virtual InputBox txtToDigit
  {
    [DebuggerNonUserCode] get => this._txtToDigit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtToDigit != null)
        this._txtToDigit.IsValidChange -= changeEventHandler;
      this._txtToDigit = value;
      if (this._txtToDigit == null)
        return;
      this._txtToDigit.IsValidChange += changeEventHandler;
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
    cPattern cPattern = new cPattern();
    cPattern.PrivateId = this.txtPrivateId.Text;
    cPattern.ToDigit = this.txtToDigit.Text;
    cPattern.Price = this.txtPrice.Text;
    bool flag = true;
    switch (this.FormType)
    {
      case Enum_ToolbarButtons.New:
        flag = cPattern.Add();
        break;
      case Enum_ToolbarButtons.Edit:
        cPattern.Identity = this.FormValue;
        flag = cPattern.Edit();
        break;
    }
    if (!flag)
    {
      string BodyText = cPattern.ErrorMessage;
      if (cPattern.ErrorDescription.Contains("UQ_fldPrivateIdfldDel_tblPattern"))
      {
        BodyText = "شماره پلكان مصرف وارد شده تكراري ميباشد";
        this.txtPrivateId.Focus();
      }
      int num = (int) MessageBoxMPS.show((Form) this, BodyText, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cPattern.ErrorDescription);
      this.buttAdd.Enabled = true;
    }
    else
    {
      switch (this.FormType)
      {
        case Enum_ToolbarButtons.New:
          DataRow row = this.FormParent.DataTable.NewRow();
          row["fldPatternId"] = (object) cPattern.Identity;
          row["fldPrivateId"] = (object) cPattern.PrivateId;
          row["fldToDigit"] = (object) cPattern.ToDigit;
          row["fldPrice"] = (object) cPattern.Price;
          this.FormParent.DataTable.Rows.Add(row);
          break;
        case Enum_ToolbarButtons.Edit:
          DataTable dataTable = this.FormParent.DataTable;
          int num = checked (dataTable.Rows.Count - 1);
          int index = 0;
          while (index <= num)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataTable.Rows[index][0], (object) cPattern.Identity, false))
            {
              dataTable.Rows[index]["fldPatternId"] = (object) cPattern.Identity;
              dataTable.Rows[index]["fldPrivateId"] = (object) cPattern.PrivateId;
              dataTable.Rows[index]["fldToDigit"] = (object) cPattern.ToDigit;
              dataTable.Rows[index]["fldPrice"] = (object) cPattern.Price;
              break;
            }
            checked { ++index; }
          }
          break;
      }
      this.Dispose();
    }
  }

  private void frmPatternData_Shown(object sender, EventArgs e)
  {
    this.txtPrice.Focus();
    this.txtPrivateId.Focus();
  }
}
