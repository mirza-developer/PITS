// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.cIsolateInfo
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using System;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public class cIsolateInfo
{
  private string PrCompanyName;
  private string PrConnectionString;
  private string PrSoftwareId;

  [DebuggerNonUserCode]
  public cIsolateInfo()
  {
  }

  public string CompanyName
  {
    get => this.PrCompanyName;
    set => this.PrCompanyName = value;
  }

  public string ConnectionString
  {
    get => this.PrConnectionString;
    set => this.PrConnectionString = value;
  }

  public void Load()
  {
    IsolatedStorageFileStream storageFileStream = new IsolatedStorageFileStream("IsolateInfo.pin", FileMode.OpenOrCreate, IsolatedStorageFile.GetMachineStoreForAssembly());
    byte[] numArray = new byte[checked ((int) storageFileStream.Length + 1)];
    storageFileStream.Read(numArray, 0, checked ((int) storageFileStream.Length));
    storageFileStream.Close();
    string[] strArray = Encoding.ASCII.GetString(numArray).Split('|');
    if (strArray[0].Length < 2)
    {
      mPublicModule.SoftwareId = new Random().NextDouble().ToString().Split('.')[1];
      new cIsolateInfo()
      {
        CompanyName = "",
        ConnectionString = ""
      }.Save();
    }
    else
    {
      mPublicModule.SoftwareId = strArray[0];
      this.PrCompanyName = strArray[1];
      this.PrConnectionString = strArray[2];
    }
  }

  public void Save()
  {
    if (this.PrCompanyName == null | this.PrConnectionString == null)
    {
      cIsolateInfo cIsolateInfo = new cIsolateInfo();
      cIsolateInfo.Load();
      if (this.PrCompanyName == null)
        this.PrCompanyName = cIsolateInfo.CompanyName;
      if (this.PrConnectionString == null)
        this.PrConnectionString = cIsolateInfo.ConnectionString;
    }
    string s = $"{mPublicModule.SoftwareId}|{this.PrCompanyName}|{this.PrConnectionString}";
    IsolatedStorageFile storeForAssembly = IsolatedStorageFile.GetMachineStoreForAssembly();
    storeForAssembly.CreateDirectory("PITS");
    IsolatedStorageFileStream storageFileStream = new IsolatedStorageFileStream("IsolateInfo.pin", FileMode.Create, storeForAssembly);
    byte[] bytes = Encoding.ASCII.GetBytes(s);
    storageFileStream.Write(bytes, 0, bytes.Length);
    storageFileStream.Flush();
    storageFileStream.Close();
  }
}
