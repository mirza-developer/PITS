// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cPeriodUse
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

public class cPeriodUse : cIUDS
{
  private string PrPeriod;
  private string PrNumber;
  private string PrStartDate;
  private string PrEndDate;
  private string PrReader;
  private SqlParameter pPeriod;
  private SqlParameter pNumber;
  private SqlParameter pStartDate;
  private SqlParameter pEndDate;
  private SqlParameter pReader;

  [DebuggerNonUserCode]
  public cPeriodUse()
  {
  }

  public string Number
  {
    get => this.PrNumber;
    set => this.PrNumber = value;
  }

  public string StartDate
  {
    get => this.PrStartDate;
    set => this.PrStartDate = value;
  }

  public string EndDate
  {
    get => this.PrEndDate;
    set => this.PrEndDate = value;
  }

  public string Period
  {
    get => this.PrPeriod;
    set => this.PrPeriod = value;
  }

  public string Reader
  {
    get => this.PrReader;
    set => this.PrReader = value;
  }

  protected override void BuiltSqlCommand(Enum_ProcedureName ProcedureName)
  {
    switch (ProcedureName)
    {
      case Enum_ProcedureName.SELECT:
        this.SqlStr = "select * from [dbo].[FUN_tblPeriodUse_Load](@PrivateId,@Reader) ORDER BY fldPrivateId desc";
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pReader);
        break;
      case Enum_ProcedureName.ADD:
        this.SqlStr = "[dbo].[SP_tblPeriodUse_INSERT]";
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pStartDate);
        this.Cmd.Parameters.Add(this.pEndDate);
        this.Cmd.Parameters.Add(this.pPeriod);
        this.Cmd.Parameters.Add(this.pReader);
        break;
      case Enum_ProcedureName.UPDATE:
        this.SqlStr = "[dbo].[SP_tblPeriodUse_UPDATE]";
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pStartDate);
        this.Cmd.Parameters.Add(this.pEndDate);
        this.Cmd.Parameters.Add(this.pPeriod);
        this.Cmd.Parameters.Add(this.pReader);
        break;
      case Enum_ProcedureName.DELETE:
        this.SqlStr = "[dbo].[SP_tblPeriodUse_DELETE]";
        break;
      case Enum_ProcedureName.LOADRECORD:
        this.SqlStr = "SELECT * FROM [dbo].[FUN_tblPeriodUse_LoadRecord](@Identity)";
        break;
    }
  }

  protected override void BuiltSqlParameter()
  {
    this.pNumber = new SqlParameter("@PrivateId", SqlDbType.VarChar)
    {
      Value = (object) this.PrNumber
    };
    this.pStartDate = new SqlParameter("@StartDate", SqlDbType.VarChar, 10)
    {
      Value = (object) this.PrStartDate
    };
    this.pEndDate = new SqlParameter("@EndDate", SqlDbType.VarChar, 10)
    {
      Value = (object) this.PrEndDate
    };
    this.pPeriod = new SqlParameter("@Period", SqlDbType.VarChar, 3)
    {
      Value = (object) this.PrPeriod
    };
    this.pReader = new SqlParameter("@Reader", SqlDbType.NVarChar, 50)
    {
      Value = (object) this.PrReader
    };
  }

  public bool GetPeriod()
  {
    bool period;
    if (!this.Connections())
    {
      period = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      try
      {
        this.Cmd.Parameters.Add("@PrivateId", SqlDbType.VarChar).Value = (object) this.PrNumber;
        this.Cmd.CommandText = "select * from [dbo].[FUN_tblPeriodUse_Select_Period](@PrivateId)";
        this.Cmd.CommandType = CommandType.Text;
        this.Cmd.Connection = mPublicModule.Cnn;
        new SqlDataAdapter() { SelectCommand = this.Cmd }.Fill(this.PrResaultTable);
        this.PrPeriod = Conversions.ToString(this.PrResaultTable.Rows[0][0]);
        this.PrErrorDescription = "";
        this.PrErrorMessage = "";
        period = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.PrErrorMessage = "مشكلي در بارگزاري اطلاعات بوجود آمده است";
        this.PrErrorDescription = exception.Message;
        period = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return period;
  }

  public bool CheckForLock()
  {
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      try
      {
        this.Cmd.Parameters.Add("@PeriodUseId", SqlDbType.VarChar).Value = (object) this.PrIdentity;
        this.Cmd.CommandText = "select * from [dbo].[FUN_tblPeriodUse_CheckLock](@PeriodUseId)";
        this.Cmd.CommandType = CommandType.Text;
        this.Cmd.Connection = mPublicModule.Cnn;
        new SqlDataAdapter() { SelectCommand = this.Cmd }.Fill(this.PrResaultTable);
        if (this.PrResaultTable.Rows.Count == 0)
        {
          this.PrErrorDescription = "";
          this.PrErrorMessage = "";
          flag = true;
        }
        else
        {
          this.PrErrorMessage = "براي اين دوره ، ميزان مصرف وارد شده است . شما مجاز به ويرايش نميباشيد";
          flag = false;
        }
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
}
