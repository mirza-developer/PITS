// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.My.MyProject
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer.My;

[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
  private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

  [DebuggerNonUserCode]
  static MyProject()
  {
  }

  [HelpKeyword("My.Computer")]
  internal static MyComputer Computer
  {
    [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Application")]
  internal static MyApplication Application
  {
    [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
  }

  [HelpKeyword("My.User")]
  internal static User User
  {
    [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Forms")]
  internal static MyProject.MyForms Forms
  {
    [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
  }

  [HelpKeyword("My.WebServices")]
  internal static MyProject.MyWebServices WebServices
  {
    [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
  }

  [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class MyForms
  {
    public cfrmData m_cfrmData;
    public cfrmMain m_cfrmMain;
    public frmAbout m_frmAbout;
    public frmBackUp m_frmBackUp;
    public frmBillData m_frmBillData;
    public frmBillMain m_frmBillMain;
    public frmConnectionStringSetting m_frmConnectionStringSetting;
    public frmEnter m_frmEnter;
    public frmFinalBill m_frmFinalBill;
    public frmFinalBillData m_frmFinalBillData;
    public frmHomeData m_frmHomeData;
    public frmHomeMain m_frmHomeMain;
    public frmMain m_frmMain;
    public frmPassword m_frmPassword;
    public frmPatternData m_frmPatternData;
    public frmPatternMain m_frmPatternMain;
    public frmPeriodUseData m_frmPeriodUseData;
    public frmPeriodUseMain m_frmPeriodUseMain;
    public frmPrint m_frmPrint;
    public frmUseData m_frmUseData;
    public frmUseMain m_frmUseMain;
    [ThreadStatic]
    private static Hashtable m_FormBeingCreated;

    public cfrmData cfrmData
    {
      [DebuggerNonUserCode] get
      {
        this.m_cfrmData = MyProject.MyForms.Create__Instance__<cfrmData>(this.m_cfrmData);
        return this.m_cfrmData;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_cfrmData)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<cfrmData>(ref this.m_cfrmData);
      }
    }

    public cfrmMain cfrmMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_cfrmMain = MyProject.MyForms.Create__Instance__<cfrmMain>(this.m_cfrmMain);
        return this.m_cfrmMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_cfrmMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<cfrmMain>(ref this.m_cfrmMain);
      }
    }

    public frmAbout frmAbout
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAbout = MyProject.MyForms.Create__Instance__<frmAbout>(this.m_frmAbout);
        return this.m_frmAbout;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAbout)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAbout>(ref this.m_frmAbout);
      }
    }

    public frmBackUp frmBackUp
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBackUp = MyProject.MyForms.Create__Instance__<frmBackUp>(this.m_frmBackUp);
        return this.m_frmBackUp;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBackUp)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBackUp>(ref this.m_frmBackUp);
      }
    }

    public frmBillData frmBillData
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBillData = MyProject.MyForms.Create__Instance__<frmBillData>(this.m_frmBillData);
        return this.m_frmBillData;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBillData)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBillData>(ref this.m_frmBillData);
      }
    }

    public frmBillMain frmBillMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBillMain = MyProject.MyForms.Create__Instance__<frmBillMain>(this.m_frmBillMain);
        return this.m_frmBillMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBillMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBillMain>(ref this.m_frmBillMain);
      }
    }

    public frmConnectionStringSetting frmConnectionStringSetting
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmConnectionStringSetting = MyProject.MyForms.Create__Instance__<frmConnectionStringSetting>(this.m_frmConnectionStringSetting);
        return this.m_frmConnectionStringSetting;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmConnectionStringSetting)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmConnectionStringSetting>(ref this.m_frmConnectionStringSetting);
      }
    }

    public frmEnter frmEnter
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmEnter = MyProject.MyForms.Create__Instance__<frmEnter>(this.m_frmEnter);
        return this.m_frmEnter;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmEnter)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmEnter>(ref this.m_frmEnter);
      }
    }

    public frmFinalBill frmFinalBill
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmFinalBill = MyProject.MyForms.Create__Instance__<frmFinalBill>(this.m_frmFinalBill);
        return this.m_frmFinalBill;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmFinalBill)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmFinalBill>(ref this.m_frmFinalBill);
      }
    }

    public frmFinalBillData frmFinalBillData
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmFinalBillData = MyProject.MyForms.Create__Instance__<frmFinalBillData>(this.m_frmFinalBillData);
        return this.m_frmFinalBillData;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmFinalBillData)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmFinalBillData>(ref this.m_frmFinalBillData);
      }
    }

    public frmHomeData frmHomeData
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmHomeData = MyProject.MyForms.Create__Instance__<frmHomeData>(this.m_frmHomeData);
        return this.m_frmHomeData;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmHomeData)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmHomeData>(ref this.m_frmHomeData);
      }
    }

    public frmHomeMain frmHomeMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmHomeMain = MyProject.MyForms.Create__Instance__<frmHomeMain>(this.m_frmHomeMain);
        return this.m_frmHomeMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmHomeMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmHomeMain>(ref this.m_frmHomeMain);
      }
    }

    public frmMain frmMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMain = MyProject.MyForms.Create__Instance__<frmMain>(this.m_frmMain);
        return this.m_frmMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMain>(ref this.m_frmMain);
      }
    }

    public frmPassword frmPassword
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPassword = MyProject.MyForms.Create__Instance__<frmPassword>(this.m_frmPassword);
        return this.m_frmPassword;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPassword)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPassword>(ref this.m_frmPassword);
      }
    }

    public frmPatternData frmPatternData
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPatternData = MyProject.MyForms.Create__Instance__<frmPatternData>(this.m_frmPatternData);
        return this.m_frmPatternData;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPatternData)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPatternData>(ref this.m_frmPatternData);
      }
    }

    public frmPatternMain frmPatternMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPatternMain = MyProject.MyForms.Create__Instance__<frmPatternMain>(this.m_frmPatternMain);
        return this.m_frmPatternMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPatternMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPatternMain>(ref this.m_frmPatternMain);
      }
    }

    public frmPeriodUseData frmPeriodUseData
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPeriodUseData = MyProject.MyForms.Create__Instance__<frmPeriodUseData>(this.m_frmPeriodUseData);
        return this.m_frmPeriodUseData;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPeriodUseData)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPeriodUseData>(ref this.m_frmPeriodUseData);
      }
    }

    public frmPeriodUseMain frmPeriodUseMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPeriodUseMain = MyProject.MyForms.Create__Instance__<frmPeriodUseMain>(this.m_frmPeriodUseMain);
        return this.m_frmPeriodUseMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPeriodUseMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPeriodUseMain>(ref this.m_frmPeriodUseMain);
      }
    }

    public frmPrint frmPrint
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPrint = MyProject.MyForms.Create__Instance__<frmPrint>(this.m_frmPrint);
        return this.m_frmPrint;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPrint)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPrint>(ref this.m_frmPrint);
      }
    }

    public frmUseData frmUseData
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmUseData = MyProject.MyForms.Create__Instance__<frmUseData>(this.m_frmUseData);
        return this.m_frmUseData;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmUseData)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmUseData>(ref this.m_frmUseData);
      }
    }

    public frmUseMain frmUseMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmUseMain = MyProject.MyForms.Create__Instance__<frmUseMain>(this.m_frmUseMain);
        return this.m_frmUseMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmUseMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmUseMain>(ref this.m_frmUseMain);
      }
    }

    [DebuggerHidden]
    private static T Create__Instance__<T>(T Instance) where T : Form, new()
    {
      if ((object) Instance != null && !Instance.IsDisposed)
        return Instance;
      if (MyProject.MyForms.m_FormBeingCreated != null)
      {
        if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
      }
      else
        MyProject.MyForms.m_FormBeingCreated = new Hashtable();
      MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
      try
      {
        return new T();
      }
      catch (TargetInvocationException ex) when (
      {
        // ISSUE: unable to correctly present filter
        ProjectData.SetProjectError((Exception) ex);
        if (ex.InnerException != null)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
      }
      finally
      {
        MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
      }
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) where T : Form
    {
      instance.Dispose();
      instance = default (T);
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MyForms()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal new Type GetType() => typeof (MyProject.MyForms);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();
  }

  [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class MyWebServices
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    internal new Type GetType() => typeof (MyProject.MyWebServices);

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();

    [DebuggerHidden]
    private static T Create__Instance__<T>(T instance) where T : new()
    {
      return (object) instance == null ? new T() : instance;
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MyWebServices()
    {
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [ComVisible(false)]
  internal sealed class ThreadSafeObjectProvider<T> where T : new()
  {
    internal T GetInstance
    {
      [DebuggerHidden] get
      {
        if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
          MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
        return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
      }
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ThreadSafeObjectProvider()
    {
    }
  }
}
