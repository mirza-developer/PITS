// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cConnection
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public class cConnection
{
  private string PrErrorMessage;

  [DebuggerNonUserCode]
  public cConnection()
  {
  }

  public object ErrorMessage => (object) this.PrErrorMessage;

  public bool SetConnectionString()
  {
    cIsolateInfo cIsolateInfo = new cIsolateInfo();
    cIsolateInfo.Load();
    cConnectionString connectionString = new cConnectionString();
    connectionString.ConnectionString = cIsolateInfo.ConnectionString;
    if (!connectionString.CheckConnectionString())
    {
      this.PrErrorMessage = connectionString.ErrorMessage;
      return false;
    }
    mPublicModule.Cnn = new SqlConnection(cIsolateInfo.ConnectionString);
    this.PrErrorMessage = "";
    return true;
  }

  public bool Open()
  {
    bool flag;
    try
    {
      if (mPublicModule.Cnn.State == ConnectionState.Open)
      {
        checked { ++mPublicModule.CnnCounter; }
        this.PrErrorMessage = "";
        flag = true;
      }
      else
      {
        mPublicModule.Cnn.Open();
        checked { ++mPublicModule.CnnCounter; }
        this.PrErrorMessage = "";
        flag = true;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.PrErrorMessage = ex.Message;
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public bool Close()
  {
    bool flag;
    try
    {
      if (mPublicModule.CnnCounter != 0)
        checked { --mPublicModule.CnnCounter; }
      if (mPublicModule.CnnCounter == 0 & mPublicModule.Cnn.State == ConnectionState.Open)
        mPublicModule.Cnn.Close();
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.PrErrorMessage = ex.Message;
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }
}
