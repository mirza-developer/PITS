// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cEnter
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

public class cEnter
{
  private string PrErrorDescription;
  private string PrErrorMessage;
  private string PrAppPath;
  private string sysIP;
  private string sysHostName;
  private string sysDomainUser;
  private int PrErrNumber;

  [DebuggerNonUserCode]
  public cEnter()
  {
  }

  public string ErrorMessage => this.PrErrorMessage;

  public int ErrorNumber => this.PrErrNumber;

  public string ErrorDescription => this.PrErrorDescription;

  public bool CheckDatabaseVersion()
  {
    bool flag;
    try
    {
      SqlDataReader sqlDataReader = new SqlCommand("select * from [dbo].[FUN_CheckPITSsetting]()", mPublicModule.Cnn)
      {
        CommandType = CommandType.Text
      }.ExecuteReader();
      if (!sqlDataReader.HasRows)
      {
        this.PrErrorMessage = "عدم دسترسي به اطلاعات پايه نرم افزار . لطفا با سرپرست نرم افزار تماس بگيريد";
        this.PrErrorDescription = "";
        flag = false;
      }
      else
      {
        sqlDataReader.Read();
        mPublicModule.SoftwareVersion = Conversions.ToString(sqlDataReader["fldVersion"]);
        mPublicModule.SoftwareCompanyName = Conversions.ToString(sqlDataReader["fldComponyName"]);
        this.PrErrorMessage = "";
        sqlDataReader.Close();
        flag = true;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      this.PrErrorMessage = "خطايي ناشناخته در دسترسي به اطلاعات پايه نرم افزار رخ داده است . لطفا با سرپرست نرم افزار تماس بگيريد";
      this.PrErrorDescription = exception.Message;
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public bool CheckForUserInfo(string Password)
  {
    SqlDataReader sqlDataReader = new SqlCommand("select * from [dbo].[tblUsers]", mPublicModule.Cnn)
    {
      CommandType = CommandType.Text
    }.ExecuteReader();
    sqlDataReader.Read();
    Password = Conversions.ToString(checked (Password.GetHashCode() + 1));
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual((object) Password, sqlDataReader["fldPassword"], false))
    {
      this.PrErrorMessage = "كلمه عبور وارد شده اشتباه ميباشد";
      this.PrErrNumber = 2;
      return false;
    }
    sqlDataReader.Close();
    return true;
  }
}
