// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.frmConnectionStringSetting
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using MPS.NET_Controls;
using MPS.NET_Controls.Enumaration;
using PITS.Admin_BussinessLayer;
using PITS.Town_PresentationLayer.LoadWithThread;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer;

[DesignerGenerated]
public class frmConnectionStringSetting : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtDatabase")]
  private InputBox _txtDatabase;
  [AccessedThroughProperty("txtProvider")]
  private InputBox _txtProvider;
  [AccessedThroughProperty("buttAdd")]
  private ButtonMps _buttAdd;
  [AccessedThroughProperty("txtPassword")]
  private InputBox _txtPassword;
  [AccessedThroughProperty("buttCancel")]
  private ButtonMps _buttCancel;
  [AccessedThroughProperty("txtUser")]
  private InputBox _txtUser;
  [AccessedThroughProperty("buttTest")]
  private ButtonMps _buttTest;
  private Thread ThreadSearchProvider;

  [DebuggerNonUserCode]
  static frmConnectionStringSetting()
  {
  }

  [DebuggerNonUserCode]
  public frmConnectionStringSetting()
  {
    this.Load += (EventHandler) ([DebuggerStepThrough, SpecialName] (a0, a1) => this.LoadInfo());
    this.KeyDown += new KeyEventHandler(this.ShortcutKeys);
    frmConnectionStringSetting.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmConnectionStringSetting.__ENCList)
    {
      if (frmConnectionStringSetting.__ENCList.Count == frmConnectionStringSetting.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmConnectionStringSetting.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmConnectionStringSetting.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmConnectionStringSetting.__ENCList[index1] = frmConnectionStringSetting.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmConnectionStringSetting.__ENCList.RemoveRange(index1, checked (frmConnectionStringSetting.__ENCList.Count - index1));
        frmConnectionStringSetting.__ENCList.Capacity = frmConnectionStringSetting.__ENCList.Count;
      }
      frmConnectionStringSetting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmConnectionStringSetting));
    InputButtonSettings inputButtonSettings2 = new InputButtonSettings();
    InputButtonSettings inputButtonSettings3 = new InputButtonSettings();
    InputButtonSettings inputButtonSettings4 = new InputButtonSettings();
    this.txtProvider = new InputBox();
    this.txtDatabase = new InputBox();
    this.buttCancel = new ButtonMps();
    this.txtPassword = new InputBox();
    this.buttAdd = new ButtonMps();
    this.txtUser = new InputBox();
    this.buttTest = new ButtonMps();
    this.SuspendLayout();
    this.txtProvider.Alighment = HorizontalAlignment.Right;
    this.txtProvider.BackColor = Color.Transparent;
    inputButtonSettings1.DisplayPosition = 1;
    inputButtonSettings1.Image = (Image) componentResourceManager.GetObject("InputButtonSettings1.Image");
    inputButtonSettings1.Visible = true;
    this.txtProvider.Button = inputButtonSettings1;
    this.txtProvider.ButtonDropDownEnable = true;
    this.txtProvider.ControlType = Enum_ControlType.ComboBox;
    this.txtProvider.DefaultLanguge = Enum_Languge.English;
    this.txtProvider.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtProvider.InputValidation = Enum_InputValidation.All;
    this.txtProvider.LabelText = "نام سرويس دهنده";
    InputBox txtProvider1 = this.txtProvider;
    Point point1 = new Point(21, 12);
    Point point2 = point1;
    txtProvider1.Location = point2;
    this.txtProvider.MaxLenght = 0;
    this.txtProvider.MinLenght = 0;
    this.txtProvider.Multiline = false;
    this.txtProvider.Name = "txtProvider";
    this.txtProvider.RangeDown = "";
    this.txtProvider.RangeUp = "";
    this.txtProvider.RequiredField = true;
    InputBox txtProvider2 = this.txtProvider;
    Size size1 = new Size(286, 24);
    Size size2 = size1;
    txtProvider2.Size = size2;
    this.txtProvider.TabIndex = 0;
    this.txtProvider.ToolTipText = "لطفا نام سرويس دهنده را وارد يا از ليست انتخاب كنيد";
    this.txtProvider.UseSystemPasswordChar = false;
    this.txtProvider.WatermarkText = "";
    this.txtProvider.WriteType = Enum_WriteType.Defualt;
    this.txtDatabase.Alighment = HorizontalAlignment.Right;
    this.txtDatabase.BackColor = Color.Transparent;
    inputButtonSettings2.DisplayPosition = 1;
    inputButtonSettings2.Enabled = false;
    this.txtDatabase.Button = inputButtonSettings2;
    this.txtDatabase.ButtonDropDownEnable = true;
    this.txtDatabase.ControlType = Enum_ControlType.ComboBox;
    this.txtDatabase.DefaultLanguge = Enum_Languge.English;
    this.txtDatabase.Enabled = false;
    this.txtDatabase.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtDatabase.InputValidation = Enum_InputValidation.All;
    this.txtDatabase.LabelText = "نام پايگاه داده";
    InputBox txtDatabase1 = this.txtDatabase;
    point1 = new Point(21, 102);
    Point point3 = point1;
    txtDatabase1.Location = point3;
    this.txtDatabase.MaxLenght = 0;
    this.txtDatabase.MinLenght = 0;
    this.txtDatabase.Multiline = false;
    this.txtDatabase.Name = "txtDatabase";
    this.txtDatabase.RangeDown = "";
    this.txtDatabase.RangeUp = "";
    this.txtDatabase.RequiredField = true;
    InputBox txtDatabase2 = this.txtDatabase;
    size1 = new Size(261, 24);
    Size size3 = size1;
    txtDatabase2.Size = size3;
    this.txtDatabase.TabIndex = 3;
    this.txtDatabase.ToolTipText = "نام پايگاه داده را در اين قسمت وارد يا از ليست انتخاب كنيد";
    this.txtDatabase.UseSystemPasswordChar = false;
    this.txtDatabase.WatermarkText = "";
    this.txtDatabase.WriteType = Enum_WriteType.Defualt;
    this.buttCancel.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttCancel.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttCancel.Image = (Image) componentResourceManager.GetObject("buttCancel.Image");
    this.buttCancel.ImageAlign = ContentAlignment.MiddleRight;
    ButtonMps buttCancel1 = this.buttCancel;
    point1 = new Point(95, 149);
    Point point4 = point1;
    buttCancel1.Location = point4;
    this.buttCancel.Name = "buttCancel";
    this.buttCancel.RightToLeft = RightToLeft.Yes;
    this.buttCancel.ShortcutKeys = "Esc";
    ButtonMps buttCancel2 = this.buttCancel;
    size1 = new Size(68, 25);
    Size size4 = size1;
    buttCancel2.Size = size4;
    this.buttCancel.TabIndex = 5;
    this.buttCancel.Text = "انصراف";
    this.buttCancel.TextAlign = ContentAlignment.TopLeft;
    this.buttCancel.TooltipText = "جهت انصراف از ثبت اطلاعات اين دكمه را فشار دهيد";
    this.buttCancel.UseVisualStyleBackColor = false;
    this.txtPassword.Alighment = HorizontalAlignment.Center;
    this.txtPassword.BackColor = Color.Transparent;
    inputButtonSettings3.DisplayPosition = 1;
    inputButtonSettings3.Enabled = false;
    this.txtPassword.Button = inputButtonSettings3;
    this.txtPassword.ButtonDropDownEnable = true;
    this.txtPassword.ControlType = Enum_ControlType.TextBox;
    this.txtPassword.DefaultLanguge = Enum_Languge.English;
    this.txtPassword.Enabled = false;
    this.txtPassword.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtPassword.InputValidation = Enum_InputValidation.All;
    this.txtPassword.LabelText = "كلمه عبور پايگاه داده";
    InputBox txtPassword1 = this.txtPassword;
    point1 = new Point(21, 72);
    Point point5 = point1;
    txtPassword1.Location = point5;
    this.txtPassword.MaxLenght = 0;
    this.txtPassword.MinLenght = 0;
    this.txtPassword.Multiline = false;
    this.txtPassword.Name = "txtPassword";
    this.txtPassword.RangeDown = "";
    this.txtPassword.RangeUp = "";
    this.txtPassword.RequiredField = false;
    InputBox txtPassword2 = this.txtPassword;
    size1 = new Size(293, 24);
    Size size5 = size1;
    txtPassword2.Size = size5;
    this.txtPassword.TabIndex = 2;
    this.txtPassword.ToolTipText = "كلمه عبور پايگاه داده را در اين قسمت وارد نمائيد";
    this.txtPassword.UseSystemPasswordChar = true;
    this.txtPassword.WatermarkText = "";
    this.txtPassword.WriteType = Enum_WriteType.Defualt;
    this.buttAdd.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttAdd.Enabled = false;
    this.buttAdd.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttAdd.Image = (Image) componentResourceManager.GetObject("buttAdd.Image");
    this.buttAdd.ImageAlign = ContentAlignment.MiddleRight;
    ButtonMps buttAdd1 = this.buttAdd;
    point1 = new Point(169, 149);
    Point point6 = point1;
    buttAdd1.Location = point6;
    this.buttAdd.Name = "buttAdd";
    this.buttAdd.RightToLeft = RightToLeft.Yes;
    this.buttAdd.ShortcutKeys = "F10";
    ButtonMps buttAdd2 = this.buttAdd;
    size1 = new Size(68, 25);
    Size size6 = size1;
    buttAdd2.Size = size6;
    this.buttAdd.TabIndex = 4;
    this.buttAdd.Text = "ثبت";
    this.buttAdd.TextAlign = ContentAlignment.TopLeft;
    this.buttAdd.TooltipText = "جهت ثبت اطلاعات اين دكمه را فشار دهيد";
    this.buttAdd.UseVisualStyleBackColor = false;
    this.txtUser.Alighment = HorizontalAlignment.Center;
    this.txtUser.BackColor = Color.Transparent;
    inputButtonSettings4.DisplayPosition = 1;
    inputButtonSettings4.Enabled = false;
    this.txtUser.Button = inputButtonSettings4;
    this.txtUser.ButtonDropDownEnable = true;
    this.txtUser.ControlType = Enum_ControlType.TextBox;
    this.txtUser.DefaultLanguge = Enum_Languge.English;
    this.txtUser.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.txtUser.InputValidation = Enum_InputValidation.All;
    this.txtUser.LabelText = "كاربر پايگاه داده";
    InputBox txtUser1 = this.txtUser;
    point1 = new Point(95, 42);
    Point point7 = point1;
    txtUser1.Location = point7;
    this.txtUser.MaxLenght = 0;
    this.txtUser.MinLenght = 0;
    this.txtUser.Multiline = false;
    this.txtUser.Name = "txtUser";
    this.txtUser.RangeDown = "";
    this.txtUser.RangeUp = "";
    this.txtUser.RequiredField = false;
    InputBox txtUser2 = this.txtUser;
    size1 = new Size(194, 24);
    Size size7 = size1;
    txtUser2.Size = size7;
    this.txtUser.TabIndex = 1;
    this.txtUser.ToolTipText = "نام كاربر پايگاه داده را در اين قسمت وارد نمائيد";
    this.txtUser.UseSystemPasswordChar = false;
    this.txtUser.WatermarkText = "";
    this.txtUser.WriteType = Enum_WriteType.Defualt;
    this.buttTest.BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.buttTest.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.buttTest.Image = (Image) componentResourceManager.GetObject("buttTest.Image");
    this.buttTest.ImageAlign = ContentAlignment.MiddleRight;
    ButtonMps buttTest1 = this.buttTest;
    point1 = new Point(21, 149);
    Point point8 = point1;
    buttTest1.Location = point8;
    this.buttTest.Name = "buttTest";
    this.buttTest.RightToLeft = RightToLeft.Yes;
    this.buttTest.ShortcutKeys = "Ctrl + T";
    ButtonMps buttTest2 = this.buttTest;
    size1 = new Size(68, 25);
    Size size8 = size1;
    buttTest2.Size = size8;
    this.buttTest.TabIndex = 6;
    this.buttTest.Text = "امتحان";
    this.buttTest.TextAlign = ContentAlignment.TopLeft;
    this.buttTest.TooltipText = "جهت اطمينان از صحت اطلاعات وارد شده اين دكمه را فشار دهيد";
    this.buttTest.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Snow;
    size1 = new Size(328, 209);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtProvider);
    this.Controls.Add((Control) this.txtDatabase);
    this.Controls.Add((Control) this.buttCancel);
    this.Controls.Add((Control) this.txtPassword);
    this.Controls.Add((Control) this.buttAdd);
    this.Controls.Add((Control) this.txtUser);
    this.Controls.Add((Control) this.buttTest);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmConnectionStringSetting);
    this.RightToLeft = RightToLeft.Yes;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "تنظيمات اتصال به پايگاه داده";
    this.ResumeLayout(false);
  }

  internal virtual InputBox txtDatabase
  {
    [DebuggerNonUserCode] get => this._txtDatabase;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.CheckForEnablingAdd);
      InputBox.TextChangedEventHandler changedEventHandler1 = new InputBox.TextChangedEventHandler(this.SetDependsEnableTrue);
      InputBox.DropDownChangedEventHandler changedEventHandler2 = new InputBox.DropDownChangedEventHandler(this.DropDownChanged);
      if (this._txtDatabase != null)
      {
        this._txtDatabase.IsValidChange -= changeEventHandler;
        this._txtDatabase.TextChanged -= changedEventHandler1;
        this._txtDatabase.DropDownChanged -= changedEventHandler2;
      }
      this._txtDatabase = value;
      if (this._txtDatabase == null)
        return;
      this._txtDatabase.IsValidChange += changeEventHandler;
      this._txtDatabase.TextChanged += changedEventHandler1;
      this._txtDatabase.DropDownChanged += changedEventHandler2;
    }
  }

  internal virtual InputBox txtProvider
  {
    [DebuggerNonUserCode] get => this._txtProvider;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.CheckForEnablingAdd);
      InputBox.TextChangedEventHandler changedEventHandler1 = new InputBox.TextChangedEventHandler(this.SetDependsEnableTrue);
      InputBox.ButtonClickEventHandler clickEventHandler = new InputBox.ButtonClickEventHandler(this.ButtonsClick);
      InputBox.WhenSelectFromListEventHandler listEventHandler = new InputBox.WhenSelectFromListEventHandler(this.DropDownSelected);
      InputBox.DropDownChangedEventHandler changedEventHandler2 = new InputBox.DropDownChangedEventHandler(this.DropDownChanged);
      if (this._txtProvider != null)
      {
        this._txtProvider.IsValidChange -= changeEventHandler;
        this._txtProvider.TextChanged -= changedEventHandler1;
        this._txtProvider.ButtonClick -= clickEventHandler;
        this._txtProvider.WhenSelectFromList -= listEventHandler;
        this._txtProvider.DropDownChanged -= changedEventHandler2;
      }
      this._txtProvider = value;
      if (this._txtProvider == null)
        return;
      this._txtProvider.IsValidChange += changeEventHandler;
      this._txtProvider.TextChanged += changedEventHandler1;
      this._txtProvider.ButtonClick += clickEventHandler;
      this._txtProvider.WhenSelectFromList += listEventHandler;
      this._txtProvider.DropDownChanged += changedEventHandler2;
    }
  }

  internal virtual ButtonMps buttAdd
  {
    [DebuggerNonUserCode] get => this._buttAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ButtonsClick);
      if (this._buttAdd != null)
        this._buttAdd.Click -= eventHandler;
      this._buttAdd = value;
      if (this._buttAdd == null)
        return;
      this._buttAdd.Click += eventHandler;
    }
  }

  internal virtual InputBox txtPassword
  {
    [DebuggerNonUserCode] get => this._txtPassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.CheckForEnablingAdd);
      InputBox.TextChangedEventHandler changedEventHandler = new InputBox.TextChangedEventHandler(this.SetDependsEnableTrue);
      if (this._txtPassword != null)
      {
        this._txtPassword.IsValidChange -= changeEventHandler;
        this._txtPassword.TextChanged -= changedEventHandler;
      }
      this._txtPassword = value;
      if (this._txtPassword == null)
        return;
      this._txtPassword.IsValidChange += changeEventHandler;
      this._txtPassword.TextChanged += changedEventHandler;
    }
  }

  internal virtual ButtonMps buttCancel
  {
    [DebuggerNonUserCode] get => this._buttCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ButtonsClick);
      if (this._buttCancel != null)
        this._buttCancel.Click -= eventHandler;
      this._buttCancel = value;
      if (this._buttCancel == null)
        return;
      this._buttCancel.Click += eventHandler;
    }
  }

  internal virtual InputBox txtUser
  {
    [DebuggerNonUserCode] get => this._txtUser;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InputBox.IsValidChangeEventHandler changeEventHandler = new InputBox.IsValidChangeEventHandler(this.CheckForEnablingAdd);
      InputBox.TextChangedEventHandler changedEventHandler = new InputBox.TextChangedEventHandler(this.SetDependsEnableTrue);
      if (this._txtUser != null)
      {
        this._txtUser.IsValidChange -= changeEventHandler;
        this._txtUser.TextChanged -= changedEventHandler;
      }
      this._txtUser = value;
      if (this._txtUser == null)
        return;
      this._txtUser.IsValidChange += changeEventHandler;
      this._txtUser.TextChanged += changedEventHandler;
    }
  }

  internal virtual ButtonMps buttTest
  {
    [DebuggerNonUserCode] get => this._buttTest;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ButtonsClick);
      if (this._buttTest != null)
        this._buttTest.Click -= eventHandler;
      this._buttTest = value;
      if (this._buttTest == null)
        return;
      this._buttTest.Click += eventHandler;
    }
  }

  private void LoadInfo()
  {
    try
    {
      cIsolateInfo cIsolateInfo = new cIsolateInfo();
      cIsolateInfo.Load();
      SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
      connectionStringBuilder.ConnectionString = cIsolateInfo.ConnectionString;
      this.txtProvider.Text = connectionStringBuilder.DataSource;
      this.txtUser.Text = connectionStringBuilder.UserID;
      this.txtPassword.Text = connectionStringBuilder.Password;
      this.txtDatabase.Text = connectionStringBuilder.InitialCatalog;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ButtonsClick(object sender, EventArgs e)
  {
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttAdd", false))
      this.AddInfo();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "buttCancel", false))
      this.UnloadMe();
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "txtProvider", false))
    {
      this.SearchForAvailableServers();
    }
    else
    {
      if (!Operators.ConditionalCompareObjectEqual(Left, (object) "buttTest", false))
        return;
      this.TestConnection();
    }
  }

  private void ShortcutKeys(object sender, KeyEventArgs e)
  {
    Keys keyCode = e.KeyCode;
    switch (keyCode)
    {
      case Keys.Escape:
        this.UnloadMe();
        break;
      case Keys.F5:
        this.SearchForAvailableServers();
        break;
      case Keys.F10:
        this.AddInfo();
        break;
      default:
        if (keyCode != (Keys) (-(e.Control ? 1 : 0) & 84))
          break;
        this.TestConnection();
        break;
    }
  }

  private void AddInfo()
  {
    if (!this.buttAdd.Enabled)
      return;
    this.buttAdd.Enabled = false;
    SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
    connectionStringBuilder.DataSource = this.txtProvider.Text;
    connectionStringBuilder.InitialCatalog = this.txtDatabase.Text;
    if (Operators.CompareString(this.txtUser.Text, "", false) == 0)
    {
      connectionStringBuilder.IntegratedSecurity = true;
    }
    else
    {
      connectionStringBuilder.UserID = this.txtUser.Text;
      connectionStringBuilder.Password = this.txtPassword.Text;
    }
    new cIsolateInfo()
    {
      ConnectionString = connectionStringBuilder.ConnectionString
    }.Save();
    this.UnloadMe();
  }

  private void UnloadMe() => this.Dispose();

  private void DropDownChanged(object sender, bool State)
  {
    if (!State)
      return;
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Operators.ConditionalCompareObjectEqual(Left, (object) "txtProvider", false))
    {
      if (this.txtProvider.ItemCount == 0)
        this.SearchForAvailableServers();
    }
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "txtDatabase", false) && this.txtDatabase.ItemCount == 0)
      this.SearchForAvailableDatabase();
  }

  private void DropDownSelected(object sender)
  {
    this.txtDatabase.ClearItem();
    this.txtDatabase.Text = "";
  }

  private void SearchForAvailableServers()
  {
    if (!this.txtProvider.Button.Enabled)
      return;
    this.txtProvider.Cursor = Cursors.WaitCursor;
    this.txtProvider.Button.Enabled = false;
    this.txtProvider.ButtonDropDownEnable = false;
    this.txtProvider.ClearItem();
    this.ThreadSearchProvider = new Thread(new ThreadStart(new cInputBoxProvider(this.txtProvider).StartLoading));
    this.ThreadSearchProvider.Start();
  }

  private void SearchForAvailableDatabase()
  {
    if (!this.txtDatabase.ButtonDropDownEnable)
      return;
    this.txtDatabase.Cursor = Cursors.WaitCursor;
    this.txtDatabase.ButtonDropDownEnable = false;
    this.txtDatabase.ClearItem();
    cConnectionString connectionString = new cConnectionString();
    connectionString.Provider = this.txtProvider.Text;
    connectionString.Username = this.txtUser.Text;
    connectionString.Password = this.txtPassword.Text;
    if (connectionString.GetDatabaseList())
    {
      this.txtDatabase.AddItem(connectionString.DatabaseTable, "Name");
      this.txtDatabase.OpenDropDown();
    }
    this.txtDatabase.Cursor = Cursors.Default;
    this.txtDatabase.ButtonDropDownEnable = true;
  }

  private void TestConnection()
  {
    this.buttTest.Enabled = false;
    this.Cursor = Cursors.WaitCursor;
    if (new cConnectionString()
    {
      Provider = this.txtProvider.Text,
      Database = this.txtDatabase.Text,
      Username = this.txtUser.Text,
      Password = this.txtPassword.Text
    }.CheckConnectionString())
    {
      int num1 = (int) MessageBox.Show("اتصال با پايگاه داده برقرار ميباشد", "تاييد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      int num2 = (int) MessageBox.Show("ارتباط با پايگاه داده برقرار نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    this.Cursor = Cursors.Default;
    this.buttTest.Enabled = true;
  }

  private void SetDependsEnableTrue(object sender)
  {
    object Left = NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
    if (Operators.ConditionalCompareObjectEqual(Left, (object) "txtProvider", false))
    {
      if (Operators.CompareString(this.txtProvider.Text, "", false) == 0)
      {
        this.txtDatabase.Enabled = false;
        this.txtUser.Text = "";
        this.txtUser.Enabled = false;
        this.txtPassword.Text = "";
        this.txtPassword.Enabled = false;
      }
      else
      {
        this.txtDatabase.Enabled = true;
        this.txtUser.Enabled = true;
        if (Operators.CompareString(this.txtUser.Text, "", false) != 0)
          this.txtPassword.Enabled = true;
      }
      this.txtDatabase.ClearItem();
      this.txtDatabase.Text = "";
    }
    else if (Operators.ConditionalCompareObjectEqual(Left, (object) "txtUser", false))
    {
      if (Operators.CompareString(this.txtUser.Text, "", false) == 0)
      {
        this.txtPassword.Text = "";
        this.txtPassword.Enabled = false;
      }
      else
        this.txtPassword.Enabled = true;
      this.txtDatabase.ClearItem();
      this.txtDatabase.Text = "";
    }
    else
    {
      if (!Operators.ConditionalCompareObjectEqual(Left, (object) "txtPassword", false))
        return;
      this.txtDatabase.ClearItem();
      this.txtDatabase.Text = "";
    }
  }

  private void CheckForEnablingAdd()
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
}
