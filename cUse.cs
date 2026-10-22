// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cUse
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

public class cUse : cIUDS
{
  private string PrBlockNumber;
  private string PrPatternId;
  private string PrLastDigitHot;
  private string PrNewDigitHot;
  private string PrLastDigitCold;
  private string PrNewDigitCold;
  private string PrName;
  private string PrPrivateId;
  private string PrNumber;
  private SqlParameter pBlockNumber;
  private SqlParameter pPatternId;
  private SqlParameter pLastDigitHot;
  private SqlParameter pNewDigitHot;
  private SqlParameter pLastDigitCold;
  private SqlParameter pNewDigitCold;
  private SqlParameter pName;
  private SqlParameter pPrivateId;
  private SqlParameter pNumber;

  [DebuggerNonUserCode]
  public cUse()
  {
  }

  public string PrivateId
  {
    get => this.PrPrivateId;
    set => this.PrPrivateId = value;
  }

  public string Number
  {
    get => this.PrNumber;
    set => this.PrNumber = value;
  }

  public string LastDigitCold
  {
    get => this.PrLastDigitCold;
    set => this.PrLastDigitCold = value;
  }

  public string NewDigitCold
  {
    get => this.PrNewDigitCold;
    set => this.PrNewDigitCold = value;
  }

  public string LastDigitHot
  {
    get => this.PrLastDigitHot;
    set => this.PrLastDigitHot = value;
  }

  public string NewDigitHot
  {
    get => this.PrNewDigitHot;
    set => this.PrNewDigitHot = value;
  }

  public string Name
  {
    set => this.PrName = value;
  }

  public string BlockNumber
  {
    set => this.PrBlockNumber = value;
  }

  public string PatternId
  {
    get => this.PrPatternId;
    set => this.PrPatternId = value;
  }

  protected override void BuiltSqlCommand(Enum_ProcedureName ProcedureName)
  {
    switch (ProcedureName)
    {
      case Enum_ProcedureName.SELECT:
        this.SqlStr = "select * from [dbo].[FUN_tblUse_Load](@PrivateId,@Number,@Name,@BlockNumber) ORDER BY fldUseId desc";
        this.Cmd.Parameters.Add(this.pName);
        this.Cmd.Parameters.Add(this.pPrivateId);
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pBlockNumber);
        break;
      case Enum_ProcedureName.ADD:
        this.SqlStr = "[dbo].[SP_tblUse_INSERT]";
        this.Cmd.Parameters.Add(this.pPrivateId);
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pLastDigitHot);
        this.Cmd.Parameters.Add(this.pNewDigitHot);
        this.Cmd.Parameters.Add(this.pLastDigitCold);
        this.Cmd.Parameters.Add(this.pNewDigitCold);
        this.Cmd.Parameters.Add(this.pPatternId);
        break;
      case Enum_ProcedureName.UPDATE:
        this.SqlStr = "[dbo].[SP_tblUse_UPDATE]";
        this.Cmd.Parameters.Add(this.pPrivateId);
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pLastDigitHot);
        this.Cmd.Parameters.Add(this.pNewDigitHot);
        this.Cmd.Parameters.Add(this.pLastDigitCold);
        this.Cmd.Parameters.Add(this.pNewDigitCold);
        this.Cmd.Parameters.Add(this.pPatternId);
        break;
      case Enum_ProcedureName.DELETE:
        this.SqlStr = "[dbo].[SP_tblUse_DELETE]";
        break;
      case Enum_ProcedureName.LOADRECORD:
        this.SqlStr = "SELECT * FROM [dbo].[FUN_tblUse_LoadRecord](@Identity)";
        break;
    }
  }

  protected override void BuiltSqlParameter()
  {
    this.pLastDigitCold = new SqlParameter("@LastDigitCold", SqlDbType.VarChar)
    {
      Value = (object) this.PrLastDigitCold
    };
    this.pNewDigitCold = new SqlParameter("@NewDigitCold", SqlDbType.VarChar)
    {
      Value = (object) this.PrNewDigitCold
    };
    this.pLastDigitHot = new SqlParameter("@LastDigitHot", SqlDbType.VarChar)
    {
      Value = (object) this.PrLastDigitHot
    };
    this.pNewDigitHot = new SqlParameter("@NewDigitHot", SqlDbType.VarChar)
    {
      Value = (object) this.PrNewDigitHot
    };
    this.pPrivateId = new SqlParameter("@PrivateId", SqlDbType.VarChar)
    {
      Value = (object) this.PrPrivateId
    };
    this.pName = new SqlParameter("@Name", SqlDbType.NVarChar, 50)
    {
      Value = (object) this.PrName
    };
    this.pNumber = new SqlParameter("@Number", SqlDbType.VarChar)
    {
      Value = (object) this.PrNumber
    };
    this.pPatternId = new SqlParameter("@PatternId", SqlDbType.VarChar)
    {
      Value = (object) this.PrPatternId
    };
    this.pBlockNumber = new SqlParameter("@BlockNumber", SqlDbType.VarChar)
    {
      Value = (object) this.PrBlockNumber
    };
  }

  public bool GetLastUse()
  {
    bool lastUse;
    if (!this.Connections())
    {
      lastUse = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      try
      {
        this.Cmd.Parameters.Add("@Number", SqlDbType.VarChar).Value = (object) this.PrNumber;
        this.Cmd.CommandText = "[dbo].[SP_tblUse_LastUse]";
        this.Cmd.CommandType = CommandType.StoredProcedure;
        this.Cmd.Connection = mPublicModule.Cnn;
        new SqlDataAdapter() { SelectCommand = this.Cmd }.Fill(this.PrResaultTable);
        if (this.PrResaultTable.Rows.Count != 0)
        {
          this.PrLastDigitCold = Conversions.ToString(this.PrResaultTable.Rows[0][0]);
          this.PrLastDigitHot = Conversions.ToString(this.PrResaultTable.Rows[0][1]);
        }
        else
        {
          this.PrLastDigitCold = "";
          this.PrLastDigitHot = "";
        }
        this.PrErrorDescription = "";
        this.PrErrorMessage = "";
        lastUse = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.PrErrorMessage = "مشكلي در بارگزاري اطلاعات بوجود آمده است";
        this.PrErrorDescription = exception.Message;
        lastUse = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return lastUse;
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
        this.Cmd.Parameters.Add("@UseId", SqlDbType.VarChar).Value = (object) this.PrIdentity;
        this.Cmd.CommandText = "select * from [dbo].[FUN_tblUse_CheckLock](@UseId)";
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
