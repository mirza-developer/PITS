// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmBackUp
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
public class frmBackUp : cfrmData
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtName")]
  private InputBox _txtName;
  [AccessedThroughProperty("txtBrowse")]
  private InputBox _txtBrowse;

  [DebuggerNonUserCode]
  static frmBackUp()
  {
  }

  [DebuggerNonUserCode]
  public frmBackUp()
  {
    frmBackUp.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBackUp.__ENCList)
    {
      if (frmBackUp.__ENCList.Count == frmBackUp.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBackUp.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBackUp.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBackUp.__ENCList[index1] = frmBackUp.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBackUp.__ENCList.RemoveRange(index1, checked (frmBackUp.__ENCList.Count - index1));
        frmBackUp.__ENCList.Capacity = frmBackUp.__ENCList.Count;
      }
      frmBackUp.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBackUp));
    this.txtName = new InputBox();
    this.txtBrowse = new InputBox();
    this.SuspendLayout();
    this.txtName.Alighment = HorizontalAlignment.Left;
    this.txtName.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Enabled = false;
    this.txtName.Button = inputButtonSettings1;
    this.txtName.ButtonDropDownEnable = true;
    this.txtName.ControlType = Enum_ControlType.TextBox;
    this.txtName.DefaultLanguge = Enum_Languge.English;
    this.txtName.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtName.InputValidation = Enum_InputValidation.OnlyEnglish;
    this.txtName.Key = "";
    this.txtName.LabelForeColor = SystemColors.ControlText;
    this.txtName.LabelText = "نام نسخه پشتيبان";
    InputBox txtName1 = this.txtName;
    Point point1 = new Point(167, 98);
    Point point2 = point1;
    txtName1.Location = point2;
    this.txtName.MaxLenght = (int) short.MaxValue;
    this.txtName.MinLenght = 0;
    this.txtName.Multiline = false;
    this.txtName.Name = "txtName";
    this.txtName.RangeDown = "";
    this.txtName.RangeUp = "";
    this.txtName.RequiredField = true;
    InputBox txtName2 = this.txtName;
    Size size1 = new Size(246, 24);
    Size size2 = size1;
    txtName2.Size = size2;
    this.txtName.TabIndex = 1;
    this.txtName.ToolTipText = (string) null;
    this.txtName.UseSystemPasswordChar = false;
    this.txtName.WatermarkText = "";
    this.txtName.WriteType = Enum_WriteType.Defualt;
    this.txtBrowse.Alighment = HorizontalAlignment.Right;
    this.txtBrowse.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtBrowse.Button = inputButtonSettings2;
    this.txtBrowse.ButtonDropDownEnable = true;
    this.txtBrowse.ControlType = Enum_ControlType.TextBox;
    this.txtBrowse.DefaultLanguge = Enum_Languge.English;
    this.txtBrowse.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtBrowse.InputValidation = Enum_InputValidation.All;
    this.txtBrowse.Key = "";
    this.txtBrowse.LabelForeColor = SystemColors.ControlText;
    this.txtBrowse.LabelText = "مسير ذخيره نسخه پشتيبان";
    InputBox txtBrowse1 = this.txtBrowse;
    point1 = new Point(12, 68);
    Point point3 = point1;
    txtBrowse1.Location = point3;
    this.txtBrowse.MaxLenght = (int) short.MaxValue;
    this.txtBrowse.MinLenght = 0;
    this.txtBrowse.Multiline = false;
    this.txtBrowse.Name = "txtBrowse";
    this.txtBrowse.RangeDown = "";
    this.txtBrowse.RangeUp = "";
    this.txtBrowse.RequiredField = true;
    InputBox txtBrowse2 = this.txtBrowse;
    size1 = new Size(444, 24);
    Size size3 = size1;
    txtBrowse2.Size = size3;
    this.txtBrowse.TabIndex = 0;
    this.txtBrowse.ToolTipText = (string) null;
    this.txtBrowse.UseSystemPasswordChar = false;
    this.txtBrowse.WatermarkText = "";
    this.txtBrowse.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(474, 158);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtBrowse);
    this.Controls.Add((Control) this.txtName);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmBackUp);
    this.Text = "تهيه نسخه پشتيبان";
    this.Controls.SetChildIndex((Control) this.txtName, 0);
    this.Controls.SetChildIndex((Control) this.txtBrowse, 0);
    this.ResumeLayout(false);
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

  internal virtual InputBox txtBrowse
  {
    [DebuggerNonUserCode] get => this._txtBrowse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.checkValidation);
      if (this._txtBrowse != null)
        this._txtBrowse.IsValidChange -= changeEventHandler;
      this._txtBrowse = value;
      if (this._txtBrowse == null)
        return;
      this._txtBrowse.IsValidChange += changeEventHandler;
    }
  }

  private void checkValidation()
  {
    if (this.txtBrowse.isValid & this.txtName.isValid)
      this.buttAdd.Enabled = true;
    else
      this.buttAdd.Enabled = false;
  }

  protected override void Add()
  {
    base.Add();
    this.buttAdd.Enabled = false;
    cBackup cBackup = new cBackup();
    cBackup.Browse = this.txtBrowse.Text;
    cBackup.Name = this.txtName.Text;
    if (!cBackup.GoBackup())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cBackup.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      this.buttAdd.Enabled = true;
    }
    else
      this.Dispose();
  }
}
