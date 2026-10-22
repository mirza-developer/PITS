// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cIUDS
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public abstract class cIUDS : I_IUDS
{
  protected string PrErrorMessage;
  protected string PrErrorDescription;
  protected string SqlStr;
  protected string PrIdentity;
  protected MemoryStream PrPicture;
  protected cConnection Connection;
  protected SqlCommand Cmd;
  protected DataTable PrResaultTable;
  protected SqlParameter pErrorMessage;
  protected SqlParameter pIdentity;

  protected cIUDS()
  {
    this.Connection = new cConnection();
    this.Cmd = new SqlCommand();
    this.PrResaultTable = new DataTable();
    this.pErrorMessage = new SqlParameter("@ErrorMessage", SqlDbType.VarChar, 2000, Conversions.ToString(2))
    {
      Value = (object) ""
    };
    this.pIdentity = new SqlParameter("@Identity", SqlDbType.BigInt);
  }

  public int Identity
  {
    get => Conversions.ToInteger(this.PrIdentity);
    set
    {
      this.PrIdentity = Conversions.ToString(value);
      this.pIdentity.Value = (object) this.PrIdentity;
    }
  }

  public string ErrorMessage => this.PrErrorMessage;

  public string ErrorDescription => this.PrErrorDescription;

  public DataTable ResaultTable => this.PrResaultTable;

  public bool Load()
  {
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      this.BuiltSqlParameter();
      this.BuiltSqlCommand(Enum_ProcedureName.SELECT);
      try
      {
        this.Cmd.CommandText = this.SqlStr;
        this.Cmd.CommandType = CommandType.Text;
        this.Cmd.Connection = mPublicModule.Cnn;
        new SqlDataAdapter() { SelectCommand = this.Cmd }.Fill(this.PrResaultTable);
        this.PrErrorDescription = "";
        this.PrErrorMessage = "";
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.PrErrorMessage = "مشكلي در بارگزاري اطلاعات بوجود آمده است";
        this.PrErrorDescription = exception.Message;
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return flag;
  }

  public bool LoadRecord()
  {
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      this.BuiltSqlCommand(Enum_ProcedureName.LOADRECORD);
      try
      {
        this.Cmd.Parameters.Add(this.pIdentity);
        this.Cmd.CommandText = this.SqlStr;
        this.Cmd.CommandType = CommandType.Text;
        this.Cmd.Connection = mPublicModule.Cnn;
        new SqlDataAdapter() { SelectCommand = this.Cmd }.Fill(this.PrResaultTable);
        this.PrErrorDescription = "";
        this.PrErrorMessage = "";
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.PrErrorMessage = "مشكلي در بارگزاري اطلاعات بوجود آمده است";
        this.PrErrorDescription = exception.Message;
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return flag;
  }

  public bool Add()
  {
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      this.BuiltSqlParameter();
      this.BuiltSqlCommand(Enum_ProcedureName.ADD);
      try
      {
        this.Cmd.Parameters.Add(this.pErrorMessage);
        this.Cmd.CommandText = this.SqlStr;
        this.Cmd.CommandType = CommandType.StoredProcedure;
        this.Cmd.Connection = mPublicModule.Cnn;
        this.PrIdentity = Conversions.ToString(this.Cmd.ExecuteScalar());
        this.PrErrorMessage = "";
        this.PrErrorDescription = "";
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.PrErrorDescription = ex.Message;
        this.PrErrorMessage = "خطايي در ثبت اطلاعات بوجود آمده است";
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return flag;
  }

  public virtual bool Edit()
  {
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      this.BuiltSqlParameter();
      this.BuiltSqlCommand(Enum_ProcedureName.UPDATE);
      try
      {
        this.Cmd.Parameters.Add(this.pIdentity);
        this.Cmd.Parameters.Add(this.pErrorMessage);
        this.Cmd.CommandText = this.SqlStr;
        this.Cmd.CommandType = CommandType.StoredProcedure;
        this.Cmd.Connection = mPublicModule.Cnn;
        this.Cmd.ExecuteNonQuery();
        this.PrErrorMessage = "";
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.PrErrorMessage = "مشكلي در ويرايش اطلاعات بوجود آمده است";
        this.PrErrorDescription = exception.Message;
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return flag;
  }

  public bool delete()
  {
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      this.BuiltSqlCommand(Enum_ProcedureName.DELETE);
      try
      {
        this.Cmd.Parameters.Add(this.pIdentity);
        this.Cmd.Parameters.Add(this.pErrorMessage);
        this.Cmd.CommandText = this.SqlStr;
        this.Cmd.CommandType = CommandType.StoredProcedure;
        this.Cmd.Connection = mPublicModule.Cnn;
        this.Cmd.ExecuteNonQuery();
        this.PrErrorMessage = "";
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.PrErrorMessage = exception.Message;
        this.PrErrorDescription = exception.Message;
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return flag;
  }

  protected bool Connections()
  {
    if (this.Connection.Open())
      return true;
    this.PrErrorMessage = "ارتباط با پايگاه داده برقرار نميباشد";
    this.Connection.Close();
    return false;
  }

  abstract void I_IUDS.BuiltSqlParameter();

  abstract void I_IUDS.BuiltSqlCommand(Enum_ProcedureName ProcedureName);
}
