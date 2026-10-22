// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmPatternMain
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
public class frmPatternMain : cfrmMain
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtPrivateId")]
  private InputBox _txtPrivateId;

  [DebuggerNonUserCode]
  static frmPatternMain()
  {
  }

  [DebuggerNonUserCode]
  public frmPatternMain()
  {
    frmPatternMain.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPatternMain.__ENCList)
    {
      if (frmPatternMain.__ENCList.Count == frmPatternMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPatternMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPatternMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPatternMain.__ENCList[index1] = frmPatternMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPatternMain.__ENCList.RemoveRange(index1, checked (frmPatternMain.__ENCList.Count - index1));
        frmPatternMain.__ENCList.Capacity = frmPatternMain.__ENCList.Count;
      }
      frmPatternMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    InputButtonSettings inputButtonSettings = new InputButtonSettings();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPatternMain));
    this.txtPrivateId = new InputBox();
    this.SearchBar.SuspendLayout();
    this.DataTable.BeginInit();
    this.SuspendLayout();
    this.SearchBar.Controls.Add((Control) this.txtPrivateId);
    GroupBox searchBar = this.SearchBar;
    Point point1 = new Point(0, 401);
    Point point2 = point1;
    searchBar.Location = point2;
    this.txtPrivateId.Alighment = HorizontalAlignment.Left;
    this.txtPrivateId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtPrivateId.BackColor = Color.Transparent;
    inputButtonSettings.DisplayPosition = 1;
    inputButtonSettings.Enabled = false;
    this.txtPrivateId.Button = inputButtonSettings;
    this.txtPrivateId.ButtonDropDownEnable = true;
    this.txtPrivateId.ControlType = Enum_ControlType.TextBox;
    this.txtPrivateId.DefaultLanguge = Enum_Languge.English;
    this.txtPrivateId.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPrivateId.InputValidation = Enum_InputValidation.Integer;
    this.txtPrivateId.Key = "";
    this.txtPrivateId.LabelForeColor = SystemColors.ControlText;
    this.txtPrivateId.LabelText = "شماره پله مصرف";
    InputBox txtPrivateId1 = this.txtPrivateId;
    point1 = new Point(254, 37);
    Point point3 = point1;
    txtPrivateId1.Location = point3;
    this.txtPrivateId.MaxLenght = 3;
    this.txtPrivateId.MinLenght = 0;
    this.txtPrivateId.Multiline = false;
    this.txtPrivateId.Name = "txtPrivateId";
    this.txtPrivateId.RangeDown = "";
    this.txtPrivateId.RangeUp = "224";
    this.txtPrivateId.RequiredField = false;
    InputBox txtPrivateId2 = this.txtPrivateId;
    Size size1 = new Size(158, 24);
    Size size2 = size1;
    txtPrivateId2.Size = size2;
    this.txtPrivateId.TabIndex = 1;
    this.txtPrivateId.ToolTipText = "لطفا شماره پله مصرف را در اين قسمت وارد نمائيد";
    this.txtPrivateId.UseSystemPasswordChar = false;
    this.txtPrivateId.WatermarkText = "";
    this.txtPrivateId.WriteType = Enum_WriteType.Defualt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(424, 535);
    this.ClientSize = size1;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmPatternMain);
    this.Text = "پلكان مصرف";
    this.SearchBar.ResumeLayout(false);
    this.DataTable.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual InputBox txtPrivateId
  {
    [DebuggerNonUserCode] get => this._txtPrivateId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrivateId = value;
    }
  }

  protected override void New()
  {
    base.New();
    frmPatternData TargetForm = new frmPatternData();
    if (!this.CheckOpenform((cfrmData) TargetForm))
    {
      TargetForm.Dispose();
    }
    else
    {
      TargetForm.Text = "اضافه كردن پله مصرف جديد";
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
    frmPatternData frmPatternData = new frmPatternData();
    if (!this.CheckOpenform((cfrmData) frmPatternData))
    {
      frmPatternData.Dispose();
    }
    else
    {
      frmPatternData.Text = "بازبيني پله هاي مصرف";
      frmPatternData.buttNext.Visible = true;
      frmPatternData.buttPreview.Visible = true;
      frmPatternData.FormType = Enum_ToolbarButtons.View;
      frmPatternData.FormParent = (cfrmMain) this;
      if (!this.LoadRecord((cfrmData) frmPatternData))
        frmPatternData.Dispose();
      else
        frmPatternData.Show();
    }
  }

  protected override void Edit()
  {
    base.Edit();
    frmPatternData frmPatternData = new frmPatternData();
    if (!this.CheckOpenform((cfrmData) frmPatternData))
    {
      frmPatternData.Dispose();
    }
    else
    {
      frmPatternData.Text = "ويرايش  پله مصرف";
      frmPatternData.buttAdd.Visible = true;
      frmPatternData.FormType = Enum_ToolbarButtons.Edit;
      frmPatternData.FormParent = (cfrmMain) this;
      if (!this.LoadRecord((cfrmData) frmPatternData))
        frmPatternData.Dispose();
      else
        frmPatternData.Show();
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
      cPattern cPattern = new cPattern();
      cPattern.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[index1].Cells["Id"].Value);
      string str2 = Conversions.ToString(cPattern.Identity);
      if (!cPattern.delete())
        str1 = $"{str1}\r\nسند شماره {Conversions.ToString(cPattern.Identity)} : {cPattern.ErrorDescription}";
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
    cPattern cPattern = new cPattern();
    cPattern.PrivateId = this.txtPrivateId.Text;
    if (!cPattern.Load())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cPattern.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cPattern.ErrorDescription);
    }
    else
    {
      this.DataTable = cPattern.ResaultTable;
      this.DataGridMain.DataSource = (object) this.DataTable;
    }
  }

  public override bool LoadRecord(cfrmData frmData)
  {
    frmPatternData frmPatternData = (frmPatternData) frmData;
    cPattern cPattern = new cPattern();
    cPattern.Identity = Conversions.ToInteger(this.DataGridMain.SelectedRows[0].Cells["Id"].Value);
    if (!cPattern.LoadRecord())
    {
      int num = (int) MessageBoxMPS.show((Form) this, cPattern.ErrorMessage, Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1, cPattern.ErrorDescription);
      return false;
    }
    if (cPattern.ResaultTable.Rows.Count == 0)
    {
      int num = (int) MessageBoxMPS.show((Form) this, "اطلاعاتي يافت نشد", Enum_MsgboxTitle.Error, Enum_MsgboxButton.Ok, Enum_MsgboxDefualButton.Butt1);
      return false;
    }
    DataTable resaultTable = cPattern.ResaultTable;
    frmPatternData.FormValue = Conversions.ToInteger(resaultTable.Rows[0]["fldPatternId"]);
    frmPatternData.txtPrivateId.Text = Conversions.ToString(resaultTable.Rows[0]["fldPrivateId"]);
    frmPatternData.txtToDigit.Text = Conversions.ToString(resaultTable.Rows[0]["fldToDigit"]);
    string[] strArray = resaultTable.Rows[0]["fldPrice"].ToString().Split('.');
    frmPatternData.txtPrice.Text = strArray[0];
    return true;
  }

  protected override void DataGridMain_CellFormatting(
    object sender,
    DataGridViewCellFormattingEventArgs e)
  {
    this.DataGridMain.Rows[e.RowIndex].Cells["fldPriceFormat"].Value = (object) cFormat.Currency(Conversions.ToString(this.DataGridMain.Rows[e.RowIndex].Cells["fldPrice"].Value));
  }

  protected override void MakeDatagridColumn()
  {
    base.MakeDatagridColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn2 = viewTextBoxColumn1;
    viewTextBoxColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn2.HeaderText = "";
    viewTextBoxColumn2.Name = "fldPatternId";
    viewTextBoxColumn2.Visible = false;
    viewTextBoxColumn2.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
    DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn4 = viewTextBoxColumn3;
    viewTextBoxColumn4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    viewTextBoxColumn4.HeaderText = "شماره پله مصرف";
    viewTextBoxColumn4.Name = "fldPrivateId";
    viewTextBoxColumn4.Width = 100;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn3);
    DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn6 = viewTextBoxColumn5;
    viewTextBoxColumn6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn6.HeaderText = "سقف مصرف (ليتر)";
    viewTextBoxColumn6.Name = "fldToDigit";
    viewTextBoxColumn6.Width = 135;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn5);
    DataGridViewTextBoxColumn viewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn8 = viewTextBoxColumn7;
    viewTextBoxColumn8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn8.HeaderText = "مبلغ (ريال)";
    viewTextBoxColumn8.Name = "fldPrice";
    viewTextBoxColumn8.Width = 170;
    viewTextBoxColumn8.Visible = false;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn7);
    DataGridViewTextBoxColumn viewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    DataGridViewTextBoxColumn viewTextBoxColumn10 = viewTextBoxColumn9;
    viewTextBoxColumn10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    viewTextBoxColumn10.HeaderText = "مبلغ (ريال)";
    viewTextBoxColumn10.Name = "fldPriceFormat";
    viewTextBoxColumn10.Width = 170;
    this.DataGridMain.Columns.Add((DataGridViewColumn) viewTextBoxColumn9);
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
    this.txtPrivateId.TextChanged += (InputBox.TextChangedEventHandler) ([DebuggerStepThrough, SpecialName] (a0) => this.Refreshes());
  }
}
