// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cHome
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public class cHome : cIUDS
{
  private string PrRent;
  private string PrNumber;
  private string PrBlock;
  private string PrTel;
  private string PrName;
  private string PrMobile;
  private string PrName1;
  private string PrMobile1;
  private SqlParameter pNumber;
  private SqlParameter pBlockNumber;
  private SqlParameter pTel;
  private SqlParameter pName;
  private SqlParameter pMobile;
  private SqlParameter pName1;
  private SqlParameter pMobile1;
  private SqlParameter pRent;

  [DebuggerNonUserCode]
  public cHome()
  {
  }

  public string Number
  {
    get => this.PrNumber;
    set => this.PrNumber = value;
  }

  public string Block
  {
    get => this.PrBlock;
    set => this.PrBlock = value;
  }

  public string Tel
  {
    get => this.PrTel;
    set => this.PrTel = value;
  }

  public string Name
  {
    get => this.PrName;
    set => this.PrName = value;
  }

  public string Mobile
  {
    get => this.PrMobile;
    set => this.PrMobile = value;
  }

  public string Rent
  {
    get => this.PrRent;
    set => this.PrRent = value;
  }

  public string Name1
  {
    get => this.PrName1;
    set => this.PrName1 = value;
  }

  public string Mobile1
  {
    get => this.PrMobile1;
    set => this.PrMobile1 = value;
  }

  protected override void BuiltSqlCommand(Enum_ProcedureName ProcedureName)
  {
    switch (ProcedureName)
    {
      case Enum_ProcedureName.SELECT:
        this.SqlStr = "select * from [dbo].[FUN_tblHome_Load](@Number,@BlockNumber,@Name,@Name1,@Rent) ORDER BY fldNumber desc";
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pBlockNumber);
        this.Cmd.Parameters.Add(this.pName);
        this.Cmd.Parameters.Add(this.pRent);
        this.Cmd.Parameters.Add(this.pName1);
        break;
      case Enum_ProcedureName.ADD:
        this.SqlStr = "[dbo].[SP_tblHome_INSERT]";
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pBlockNumber);
        this.Cmd.Parameters.Add(this.pTel);
        this.Cmd.Parameters.Add(this.pName);
        this.Cmd.Parameters.Add(this.pMobile);
        this.Cmd.Parameters.Add(this.pRent);
        this.Cmd.Parameters.Add(this.pName1);
        this.Cmd.Parameters.Add(this.pMobile1);
        break;
      case Enum_ProcedureName.UPDATE:
        this.SqlStr = "[dbo].[SP_tblHome_UPDATE]";
        this.Cmd.Parameters.Add(this.pNumber);
        this.Cmd.Parameters.Add(this.pBlockNumber);
        this.Cmd.Parameters.Add(this.pTel);
        this.Cmd.Parameters.Add(this.pName);
        this.Cmd.Parameters.Add(this.pMobile);
        this.Cmd.Parameters.Add(this.pRent);
        this.Cmd.Parameters.Add(this.pName1);
        this.Cmd.Parameters.Add(this.pMobile1);
        break;
      case Enum_ProcedureName.DELETE:
        this.SqlStr = "[dbo].[SP_tblHome_DELETE]";
        break;
      case Enum_ProcedureName.LOADRECORD:
        this.SqlStr = "SELECT * FROM [dbo].[FUN_tblHome_LoadRecord](@Identity)";
        break;
    }
  }

  protected override void BuiltSqlParameter()
  {
    this.pNumber = new SqlParameter("@Number", SqlDbType.VarChar)
    {
      Value = (object) this.PrNumber
    };
    this.pBlockNumber = new SqlParameter("@BlockNumber", SqlDbType.VarChar)
    {
      Value = (object) this.PrBlock
    };
    this.pTel = new SqlParameter("@Tel", SqlDbType.VarChar, 8)
    {
      Value = (object) this.PrTel
    };
    this.pName = new SqlParameter("@Name", SqlDbType.NVarChar, 50)
    {
      Value = (object) this.PrName
    };
    this.pMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 11)
    {
      Value = (object) this.PrMobile
    };
    this.pRent = new SqlParameter("@Rent", SqlDbType.VarChar)
    {
      Value = (object) this.PrRent
    };
    this.pName1 = new SqlParameter("@Name1", SqlDbType.NVarChar, 50)
    {
      Value = (object) this.PrName1
    };
    this.pMobile1 = new SqlParameter("@Mobile1", SqlDbType.VarChar, 11)
    {
      Value = (object) this.PrMobile1
    };
  }
}
