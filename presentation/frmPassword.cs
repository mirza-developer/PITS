// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmPassword
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
public class frmPassword : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtOld")]
  private InputBox _txtOld;
  [AccessedThroughProperty("txtNew")]
  private InputBox _txtNew;
  [AccessedThroughProperty("txtConfrim")]
  private InputBox _txtConfrim;

  [DebuggerNonUserCode]
  static frmPassword()
  {
  }

  [DebuggerNonUserCode]
  public frmPassword()
  {
    frmPassword.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPassword.__ENCList)
    {
      if (frmPassword.__ENCList.Count == frmPassword.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPassword.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPassword.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPassword.__ENCList[index1] = frmPassword.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPassword.__ENCList.RemoveRange(index1, checked (frmPassword.__ENCList.Count - index1));
        frmPassword.__ENCList.Capacity = frmPassword.__ENCList.Count;
      }
      frmPassword.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPassword));
    this.txtOld = new InputBox();
    this.txtNew = new InputBox();
    this.txtConfrim = new InputBox();
    this.SuspendLayout();
    this.txtOld.Alighment = HorizontalAlignment.Center;
    this.txtOld.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtOld.Button = inputButtonSettings1;
    this.txtOld.ButtonDropDownEnable = true;
    this.txtOld.ControlType = Enum_ControlType.TextBox;
    this.txtOld.DefaultLanguge = Enum_Languge.English;
    this.txtOld.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtOld.InputValidation = Enum_InputValidation.All;
    this.txtOld.Key = "";
    this.txtOld.LabelForeColor = SystemColors.ControlText;
    this.txtOld.LabelText = "كلمه عبور قبلي";
    InputBox txtOld1 = this.txtOld;
    Point point1 = new Point(12, 67);
    Point point2 = point1;
    txtOld1.Location = point2;
    this.txtOld.MaxLenght = 10;
    this.txtOld.MinLenght = 1;
    this.txtOld.Multiline = false;
    this.txtOld.Name = "txtOld";
    this.txtOld.RangeDown = "";
    this.txtOld.RangeUp = "";
    this.txtOld.RequiredField = true;
    InputBox txtOld2 = this.txtOld;
    Size size1 = new Size(234, 24);
    Size size2 = size1;
    txtOld2.Size = size2;
    this.txtOld.TabIndex = 0;
    this.txtOld.ToolTipText = (string) null;
    this.txtOld.UseSystemPasswordChar = true;
    this.txtOld.WatermarkText = "";
    this.txtOld.WriteType = Enum_WriteType.Defualt;
    this.txtNew.Alighment = HorizontalAlignment.Center;
    this.txtNew.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtNew.Button = inputButtonSettings2;
    this.txtNew.ButtonDropDownEnable = true;
    this.txtNew.ControlType = Enum_ControlType.TextBox;
    this.txtNew.DefaultLanguge = Enum_Languge.English;
    this.txtNew.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtNew.InputValidation = Enum_InputValidation.All;
    this.txtNew.Key = "";
    this.txtNew.LabelForeColor = SystemColors.ControlText;
    this.txtNew.LabelText = "كلمه عبور جديد";
    InputBox txtNew1 = this.txtNew;
    point1 = new Point(12, 97);
    Point point3 = point1;
    txtNew1.Location = point3;
    this.txtNew.MaxLenght = 10;
    this.txtNew.MinLenght = 1;
    this.txtNew.Multiline = false;
    this.txtNew.Name = "txtNew";
    this.txtNew.RangeDown = "";
    this.txtNew.RangeUp = "";
    this.txtNew.RequiredField = true;
    InputBox txtNew2 = this.txtNew;
    size1 = new Size(232, 24);
    Size size3 = size1;
    txtNew2.Size = size3;
    this.txtNew.TabIndex = 1;
    this.txtNew.ToolTipText = (string) null;
    this.txtNew.UseSystemPasswordChar = true;
    this.txtNew.WatermarkText = "";
    this.txtNew.WriteType = Enum_WriteType.Defualt;
    this.txtConfrim.Alighment = HorizontalAlignment.Center;
    this.txtConfrim.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtConfrim.Button = inputButtonSettings3;
    this.txtConfrim.ButtonDropDownEnable = true;
    this.txtConfrim.ControlType = Enum_ControlType.TextBox;
    this.txtConfrim.DefaultLanguge = Enum_Languge.English;
    this.txtConfrim.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtConfrim.InputValidation = Enum_InputValidation.All;
    this.txtConfrim.Key = "";
    this.txtConfrim.LabelForeColor = SystemColors.ControlText;
    this.txtConfrim.LabelText = "تكرار كلمه عبور جديد";
    InputBox txtConfrim1 = this.txtConfrim;
    point1 = new Point(12, (int) sbyte.MaxValue);
    Point point4 = point1;
    txtConfrim1.Location = point4;
    this.txtConfrim.MaxLenght = 10;
    this.txtConfrim.MinLenght = 1;
    this.txtConfrim.Multiline = false;
    this.txtConfrim.Name = "txtConfrim";
    this.txtConfrim.RangeDown = "";
    this.txtConfrim.RangeUp = "";
    this.txtConfrim.RequiredField = true;
    InputBox txtConfrim2 = this.txtConfrim;
    size1 = new Size(256 /*0x0100*/, 24);
    Size size4 = size1;
    txtConfrim2.Size = size4;
    this.txtConfrim.TabIndex = 2;
    this.txtConfrim.ToolTipText = (string) null;
    this.txtConfrim.UseSystemPasswordChar = true;
    this.txtConfrim.WatermarkText = "";
    this.txtConfrim.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(279, 192 /*0xC0*/);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtConfrim);
    this.Controls.Add((Control) this.txtNew);
    this.Controls.Add((Control) this.txtOld);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPassword);
    this.Text = "تغيير كلمه عبور";
    this.Controls.SetChildIndex((Control) this.txtOld, 0);
    this.Controls.SetChildIndex((Control) this.txtNew, 0);
    this.Controls.SetChildIndex((Control) this.txtConfrim, 0);
    this.ResumeLayout(false);
  }

  internal virtual InputBox txtOld
  {
    [DebuggerNonUserCode] get => this._txtOld;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtOld != null)
        this._txtOld.IsValidChange -= changeEventHandler;
      this._txtOld = value;
      if (this._txtOld == null)
        return;
      this._txtOld.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtNew
  {
    [DebuggerNonUserCode] get => this._txtNew;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtNew != null)
        this._txtNew.IsValidChange -= changeEventHandler;
      this._txtNew = value;
      if (this._txtNew == null)
        return;
      this._txtNew.IsValidChange += changeEventHandler;
    }
  }

  internal virtual InputBox txtConfrim
  {
    [DebuggerNonUserCode] get => this._txtConfrim;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtConfrim != null)
        this._txtConfrim.IsValidChange -= changeEventHandler;
      this._txtConfrim = value;
      if (this._txtConfrim == null)
        return;
      this._txtConfrim.IsValidChange += changeEventHandler;
    }
  }

  private void checkValidation()
  {
    if (this.txtOld.isValid & this.txtConfrim.isValid & this.txtNew.isValid)
      this.buttAdd.Enabled = true;
    else
      this.buttAdd.Enabled = false;
  }

  protected override void Add()
  {
    base.Add();
    this.buttAdd.Enabled = false;
    cEnter cEnter = new cEnter();
    cConnection cConnection = new cConnection();
    cConnection.Open();
    if (!cEnter.CheckForUserInfo(this.txtOld.Text))
    {
      int num = (int) MessageBoxMPS.show((Form) this, cEnter.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cEnter.ErrorDescription);
      this.txtOld.Focus();
      cConnection.Close();
    }
    else if (Operators.CompareString(this.txtNew.Text, this.txtConfrim.Text, false) != 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "تكرار كلمه عبور صحيح نميباشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      this.txtConfrim.Focus();
    }
    else
    {
      cConnection.Close();
      cPassword cPassword = new cPassword();
      cPassword.Password = this.txtNew.Text;
      if (!cPassword.ChangePassword())
      {
        int num = (int) MessageBoxMPS.show((Form) this, cPassword.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
        this.buttAdd.Enabled = true;
      }
      else
        this.Dispose();
    }
  }
}
