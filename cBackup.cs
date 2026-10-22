// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cBackup
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

public class cBackup
{
  private cConnection Connection;
  private string PrBrowse;
  private string PrName;
  private string PrErrorMessage;

  public cBackup() => this.Connection = new cConnection();

  public string Browse
  {
    set => this.PrBrowse = value;
  }

  public string Name
  {
    set => this.PrName = value;
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

  public bool GoBackup()
  {
    bool flag;
    if (!this.Connections())
    {
      flag = false;
    }
    else
    {
      try
      {
        SqlCommand sqlCommand = new SqlCommand("[dbo].[SP_Backup]", mPublicModule.Cnn);
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.Add("@Browse", SqlDbType.NVarChar, 4000).Value = (object) this.PrBrowse;
        sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 4000).Value = (object) this.PrName;
        sqlCommand.Parameters.Add(new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
        {
          Direction = ParameterDirection.Output
        });
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
}
