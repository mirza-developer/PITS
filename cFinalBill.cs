// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cFinalBill
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

public class cFinalBill : cIUDS
{
  private string PrDescription;
  private string PrUseId;
  private string PrPeriodUseId;
  private string PrBillId;
  private string PrNumber;
  private string PrBlockNumber;
  private string PrName;
  private SqlParameter pDescription;
  private SqlParameter pUseId;
  private SqlParameter pPeriodUseId;
  private SqlParameter pBillId;
  private SqlParameter pNumber;
  private SqlParameter pBlockNumber;
  private SqlParameter pName;

  [DebuggerNonUserCode]
  public cFinalBill()
  {
  }

  public string UseId
  {
    set => this.PrUseId = value;
  }

  public string PeriodUseId
  {
    get => this.PrPeriodUseId;
    set => this.PrPeriodUseId = value;
  }

  public string BillId
  {
    get => this.PrBillId;
    set => this.PrBillId = value;
  }

  public string Description
  {
    get => this.PrDescription;
    set => this.PrDescription = value;
  }

  public string Number
  {
    set => this.PrNumber = value;
  }

  public string Name
  {
    set => this.PrName = value;
  }

  public string BlockNumber
  {
    set => this.PrBlockNumber = value;
  }

  protected override void BuiltSqlCommand(Enum_ProcedureName ProcedureName)
  {
    switch (ProcedureName)
    {
      case Enum_ProcedureName.SELECT:
        this.SqlStr = "select * from [dbo].[FUN_tblFinalBill_Load](@PrivateIdPeriodUse,@PrivateIdBill,@PrivateIdUse,@Number,@BlockNumber,@Name) ORDER BY fldNumber ASC";
        this.Cmd.Parameters.Add(this.pName);
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pBlockNumber);
        this.Cmd.Parameters.Add(this.pUseId);
        this.Cmd.Parameters.Add(this.pPeriodUseId);
        this.Cmd.Parameters.Add(this.pBillId);
        break;
      case Enum_ProcedureName.ADD:
        this.SqlStr = "[dbo].[SP_tblFinalBill_INSERT]";
        this.Cmd.Parameters.Add(this.pPeriodUseId);
        this.Cmd.Parameters.Add(this.pBillId);
        this.Cmd.Parameters.Add(this.pDescription);
        break;
      case Enum_ProcedureName.DELETE:
        this.SqlStr = "[dbo].[SP_tblFinalBill_DELETE]";
        this.pBillId = new SqlParameter("@BillId", SqlDbType.VarChar)
        {
          Value = (object) this.PrBillId
        };
        this.Cmd.Parameters.Add(this.pBillId);
        break;
      case Enum_ProcedureName.LOADRECORD:
        this.SqlStr = "SELECT * FROM [dbo].[FUN_tblFinalBill_LoadRecord](@Identity)";
        break;
    }
  }

  protected override void BuiltSqlParameter()
  {
    this.pUseId = new SqlParameter("@PrivateIdUse", SqlDbType.VarChar)
    {
      Value = (object) this.PrUseId
    };
    this.pPeriodUseId = new SqlParameter("@PrivateIdPeriodUse", SqlDbType.VarChar)
    {
      Value = (object) this.PrPeriodUseId
    };
    this.pBillId = new SqlParameter("@PrivateIdBill", SqlDbType.VarChar)
    {
      Value = (object) this.PrBillId
    };
    this.pName = new SqlParameter("@Name", SqlDbType.NVarChar, 50)
    {
      Value = (object) this.PrName
    };
    this.pNumber = new SqlParameter("@Number", SqlDbType.VarChar)
    {
      Value = (object) this.PrNumber
    };
    this.pBlockNumber = new SqlParameter("@BlockNumber", SqlDbType.VarChar)
    {
      Value = (object) this.PrBlockNumber
    };
    this.pDescription = new SqlParameter("@Description", SqlDbType.VarChar)
    {
      Value = (object) this.PrDescription
    };
  }

  public bool LoadReport()
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
      try
      {
        this.SqlStr = "select * from [dbo].[FUN_tblFinalBill_LoadReport](@PrivateIdPeriodUse,@PrivateIdBill,@PrivateIdUse,@Number,@BlockNumber,@Name) ORDER BY fldNumber ASC";
        this.Cmd.Parameters.Add(this.pName);
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pBlockNumber);
        this.Cmd.Parameters.Add(this.pUseId);
        this.Cmd.Parameters.Add(this.pPeriodUseId);
        this.Cmd.Parameters.Add(this.pBillId);
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
}
