// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cPassword
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public class cPassword
{
  private cConnection Connection;
  private string PrPassword;
  private string PrErrorMessage;

  public cPassword() => this.Connection = new cConnection();

  public string Password
  {
    set => this.PrPassword = value;
  }

  public string ErrorMessage => this.PrErrorMessage;

  private bool Connections()
  {
    if (this.Connection.Open())
      return true;
    this.PrErrorMessage = "ارتباط با پايگاه داده برقرار نميباشد";
    this.Connection.Close();
    return false;
  }

  public bool ChangePassword()
  {
    SqlCommand sqlCommand = new SqlCommand($"Update dbo.tblUsers set fldPassword ='{Conversions.ToString(checked (this.PrPassword.GetHashCode() + 1))}'", mPublicModule.Cnn);
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      try
      {
        sqlCommand.ExecuteNonQuery();
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.PrErrorMessage = ex.Message;
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

  public bool CheckPassword()
  {
    SqlCommand sqlCommand = new SqlCommand("select * from [dbo].[tblUsers]", mPublicModule.Cnn);
    sqlCommand.CommandType = CommandType.Text;
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      try
      {
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        sqlDataReader.Read();
        this.PrPassword = Conversions.ToString(checked (this.PrPassword.GetHashCode() + 1));
        flag = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual((object) this.PrPassword, sqlDataReader["fldPassword"], false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.PrErrorMessage = ex.Message;
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
