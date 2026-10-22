// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cConnectionString
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public class cConnectionString
{
  private string PrConnectionString;
  private string PrProvider;
  private string PrUsername;
  private string PrPassword;
  private string PrDatabase;
  private string PrErrorMessage;
  private DataTable PrDatabaseTable;

  public cConnectionString()
  {
    this.PrConnectionString = "";
    this.PrProvider = "";
    this.PrUsername = "";
    this.PrPassword = "";
    this.PrDatabase = "";
    this.PrErrorMessage = "";
    this.PrDatabaseTable = new DataTable();
  }

  public string Provider
  {
    get => this.PrProvider;
    set => this.PrProvider = value;
  }

  public string Username
  {
    get => this.PrUsername;
    set => this.PrUsername = value;
  }

  public string Password
  {
    get => this.PrPassword;
    set => this.PrPassword = value;
  }

  public string Database
  {
    get => this.PrDatabase;
    set => this.PrDatabase = value;
  }

  public string ConnectionString
  {
    get
    {
      SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PrProvider, "", false) != 0)
        connectionStringBuilder.DataSource = this.PrProvider;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PrDatabase, "", false) != 0)
        connectionStringBuilder.InitialCatalog = this.PrDatabase;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PrUsername, "", false) != 0)
      {
        connectionStringBuilder.UserID = this.PrUsername;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PrPassword, "", false) != 0)
          connectionStringBuilder.Password = this.PrPassword;
        connectionStringBuilder.IntegratedSecurity = false;
      }
      else
        connectionStringBuilder.IntegratedSecurity = true;
      this.PrConnectionString = connectionStringBuilder.ConnectionString;
      return this.PrConnectionString;
    }
    set
    {
      SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
      this.PrConnectionString = value;
      connectionStringBuilder.ConnectionString = this.PrConnectionString;
      this.PrProvider = connectionStringBuilder.DataSource;
      this.PrDatabase = connectionStringBuilder.InitialCatalog;
      if (!connectionStringBuilder.IntegratedSecurity)
      {
        this.PrUsername = connectionStringBuilder.UserID;
        this.PrPassword = connectionStringBuilder.Password;
      }
      else
      {
        this.PrUsername = "";
        this.PrPassword = "";
      }
    }
  }

  public string ErrorMessage
  {
    get => this.PrErrorMessage;
    set => this.PrErrorMessage = value;
  }

  public DataTable DatabaseTable => this.PrDatabaseTable;

  public bool CheckConnectionString()
  {
    bool flag;
    try
    {
      SqlConnection sqlConnection = new SqlConnection(this.ConnectionString);
      sqlConnection.Open();
      sqlConnection.Close();
      this.PrErrorMessage = "";
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.PrErrorMessage = ex.Message;
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public ArrayList GetServerList()
  {
    DataTable dataSources = SqlDataSourceEnumerator.Instance.GetDataSources();
    ArrayList serverList = new ArrayList();
    int num = checked (dataSources.Rows.Count - 1);
    int index = 0;
    while (index <= num)
    {
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataSources.Rows[index][1])))
        serverList.Add(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(dataSources.Rows[index][0], (object) "\\"), dataSources.Rows[index][1]));
      else
        serverList.Add(RuntimeHelpers.GetObjectValue(dataSources.Rows[index][0]));
      checked { ++index; }
    }
    return serverList;
  }

  public bool GetDatabaseList()
  {
    SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PrProvider, "", false) != 0)
      connectionStringBuilder.DataSource = this.PrProvider;
    connectionStringBuilder.InitialCatalog = "master";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PrUsername, "", false) != 0)
    {
      connectionStringBuilder.UserID = this.PrUsername;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.PrPassword, "", false) != 0)
        connectionStringBuilder.Password = this.PrPassword;
      connectionStringBuilder.IntegratedSecurity = false;
    }
    else
      connectionStringBuilder.IntegratedSecurity = true;
    bool databaseList;
    try
    {
      new SqlDataAdapter("select name from sys.databases", connectionStringBuilder.ConnectionString).Fill(this.PrDatabaseTable);
      this.PrErrorMessage = "";
      databaseList = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.PrErrorMessage = ex.Message;
      databaseList = false;
      ProjectData.ClearProjectError();
    }
    return databaseList;
  }
}
