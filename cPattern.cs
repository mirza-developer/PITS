// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cPattern
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

public class cPattern : cIUDS
{
  private string PrPrivateId;
  private string PrToDigit;
  private string PrPrice;
  private SqlParameter pPrivateId;
  private SqlParameter pToDigit;
  private SqlParameter pPrice;

  [DebuggerNonUserCode]
  public cPattern()
  {
  }

  public string PrivateId
  {
    get => this.PrPrivateId;
    set => this.PrPrivateId = value;
  }

  public string ToDigit
  {
    get => this.PrToDigit;
    set => this.PrToDigit = value;
  }

  public string Price
  {
    get => this.PrPrice;
    set
    {
      string[] source = value.Split(',');
      string str = "";
      int num = checked (((IEnumerable<string>) source).Count<string>() - 1);
      int index = 0;
      while (index <= num)
      {
        str += source[index];
        checked { ++index; }
      }
      this.PrPrice = str;
    }
  }

  public override bool Edit() => base.Edit();

  protected override void BuiltSqlCommand(Enum_ProcedureName ProcedureName)
  {
    switch (ProcedureName)
    {
      case Enum_ProcedureName.SELECT:
        this.SqlStr = "select * from [dbo].[FUN_tblPattern_Load](@PrivateId) ORDER BY fldPrivateId ASC";
        this.Cmd.Parameters.Add(this.pPrivateId);
        break;
      case Enum_ProcedureName.ADD:
        this.SqlStr = "[dbo].[SP_tblPattern_INSERT]";
        this.Cmd.Parameters.Add(this.pPrivateId);
        this.Cmd.Parameters.Add(this.pToDigit);
        this.Cmd.Parameters.Add(this.pPrice);
        break;
      case Enum_ProcedureName.UPDATE:
        this.SqlStr = "[dbo].[SP_tblPattern_UPDATE]";
        this.Cmd.Parameters.Add(this.pPrivateId);
        this.Cmd.Parameters.Add(this.pToDigit);
        this.Cmd.Parameters.Add(this.pPrice);
        break;
      case Enum_ProcedureName.DELETE:
        this.SqlStr = "[dbo].[SP_tblPattern_DELETE]";
        break;
      case Enum_ProcedureName.LOADRECORD:
        this.SqlStr = "SELECT * FROM [dbo].[FUN_tblPattern_LoadRecord](@Identity)";
        break;
    }
  }

  protected override void BuiltSqlParameter()
  {
    this.pPrivateId = new SqlParameter("@PrivateId", SqlDbType.VarChar)
    {
      Value = (object) this.PrPrivateId
    };
    this.pToDigit = new SqlParameter("@ToDigit", SqlDbType.VarChar)
    {
      Value = (object) this.PrToDigit
    };
    this.pPrice = new SqlParameter("@Price", SqlDbType.VarChar)
    {
      Value = (object) this.PrPrice
    };
  }

  public bool GetPattern()
  {
    bool pattern;
    if (!this.Connections())
    {
      pattern = false;
    }
    else
    {
      this.Cmd.Parameters.Clear();
      try
      {
        this.Cmd.Parameters.Add("@ToDigit", SqlDbType.VarChar).Value = (object) this.PrToDigit;
        this.Cmd.CommandText = "select * from [dbo].[FUN_tblPattern_Select_Pattern](@ToDigit) order by fldPrivateId ASC";
        this.Cmd.CommandType = CommandType.Text;
        this.Cmd.Connection = mPublicModule.Cnn;
        new SqlDataAdapter() { SelectCommand = this.Cmd }.Fill(this.PrResaultTable);
        this.PrIdentity = Conversions.ToString(this.PrResaultTable.Rows[0][0]);
        this.PrPrice = Conversions.ToString(this.PrResaultTable.Rows[0][1]);
        this.PrPrivateId = Conversions.ToString(this.PrResaultTable.Rows[0][2]);
        this.PrErrorDescription = "";
        this.PrErrorMessage = "";
        pattern = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.PrErrorMessage = "مشكلي در بارگزاري اطلاعات بوجود آمده است";
        this.PrErrorDescription = exception.Message;
        pattern = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Connection.Close();
      }
    }
    return pattern;
  }
}
