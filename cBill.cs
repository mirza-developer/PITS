// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cBill
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public class cBill : cIUDS
{
  private string PrPrivateId;
  private string PrStartDate;
  private string PrLastDate;
  private string PrPeriod;
  private string PrUse;
  private string PrTax;
  private string PrPrice;
  private SqlParameter pPrivateId;
  private SqlParameter pStartDate;
  private SqlParameter pLastDate;
  private SqlParameter pPeriod;
  private SqlParameter pUse;
  private SqlParameter pTax;
  private SqlParameter pPrice;

  [DebuggerNonUserCode]
  public cBill()
  {
  }

  public string PrivateId
  {
    get => this.PrPrivateId;
    set => this.PrPrivateId = value;
  }

  public string StartDate
  {
    get => this.PrStartDate;
    set => this.PrStartDate = value;
  }

  public string LastDate
  {
    get => this.PrLastDate;
    set => this.PrLastDate = value;
  }

  public string Period
  {
    get => this.PrPeriod;
    set => this.PrPeriod = value;
  }

  public string Use
  {
    get => this.PrUse;
    set => this.PrUse = value;
  }

  public string Tax
  {
    get => this.PrTax;
    set
    {
      value.Split(',');
      this.PrTax = this.SetCurrency(value);
    }
  }

  public string Price
  {
    get => this.PrPrice;
    set => this.PrPrice = this.SetCurrency(value);
  }

  private string SetCurrency(string Value)
  {
    string[] source = Value.Split(',');
    string str = "";
    int num = checked (((IEnumerable<string>) source).Count<string>() - 1);
    int index = 0;
    while (index <= num)
    {
      str += source[index];
      checked { ++index; }
    }
    return str;
  }

  protected override void BuiltSqlCommand(Enum_ProcedureName ProcedureName)
  {
    switch (ProcedureName)
    {
      case Enum_ProcedureName.SELECT:
        this.SqlStr = "select * from [dbo].[FUN_tblBill_Load](@PrivateId) ORDER BY fldPrivateId desc";
        this.Cmd.Parameters.Add(this.pPrivateId);
        break;
      case Enum_ProcedureName.ADD:
        this.SqlStr = "[dbo].[SP_tblBill_INSERT]";
        this.Cmd.Parameters.Add(this.pPrivateId);
        this.Cmd.Parameters.Add(this.pStartDate);
        this.Cmd.Parameters.Add(this.pLastDate);
        this.Cmd.Parameters.Add(this.pPeriod);
        this.Cmd.Parameters.Add(this.pUse);
        this.Cmd.Parameters.Add(this.pTax);
        this.Cmd.Parameters.Add(this.pPrice);
        break;
      case Enum_ProcedureName.UPDATE:
        this.SqlStr = "[dbo].[SP_tblBill_UPDATE]";
        this.Cmd.Parameters.Add(this.pPrivateId);
        this.Cmd.Parameters.Add(this.pStartDate);
        this.Cmd.Parameters.Add(this.pLastDate);
        this.Cmd.Parameters.Add(this.pPeriod);
        this.Cmd.Parameters.Add(this.pUse);
        this.Cmd.Parameters.Add(this.pTax);
        this.Cmd.Parameters.Add(this.pPrice);
        break;
      case Enum_ProcedureName.DELETE:
        this.SqlStr = "[dbo].[SP_tblBill_DELETE]";
        break;
      case Enum_ProcedureName.LOADRECORD:
        this.SqlStr = "SELECT * FROM [dbo].[FUN_tblBill_LoadRecord](@Identity)";
        break;
    }
  }

  protected override void BuiltSqlParameter()
  {
    this.pPrivateId = new SqlParameter("@PrivateId", SqlDbType.VarChar)
    {
      Value = (object) this.PrPrivateId
    };
    this.pStartDate = new SqlParameter("@StartDate", SqlDbType.VarChar)
    {
      Value = (object) this.PrStartDate
    };
    this.pLastDate = new SqlParameter("@EndDate", SqlDbType.VarChar)
    {
      Value = (object) this.PrLastDate
    };
    this.pPeriod = new SqlParameter("@Period", SqlDbType.VarChar)
    {
      Value = (object) this.PrPeriod
    };
    this.pUse = new SqlParameter("@Use", SqlDbType.VarChar)
    {
      Value = (object) this.PrUse
    };
    this.pTax = new SqlParameter("@Tax", SqlDbType.VarChar)
    {
      Value = (object) this.PrTax
    };
    this.pPrice = new SqlParameter("@Price", SqlDbType.VarChar)
    {
      Value = (object) this.PrPrice
    };
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
        this.Cmd.Parameters.Add("@BillId", SqlDbType.VarChar).Value = (object) this.PrIdentity;
        this.Cmd.CommandText = "select * from [dbo].[FUN_tblBill_CheckLock](@BillId)";
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
          this.PrErrorMessage = "براي اين دوره ، قبض آب صادر شده است . شما مجاز به ويرايش نميباشيد";
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
