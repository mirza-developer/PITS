// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.mPublicModule
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace PITS.Admin_BussinessLayer;

[StandardModule]
public sealed class mPublicModule
{
  [AccessedThroughProperty("Cnn")]
  private static SqlConnection _Cnn;
  public static int CnnCounter = 0;
  public static string SoftwareId;
  public static string SoftwareVersion;
  public static string SoftwareCompanyName;
  public static string InitialDirectory = "c:\\";

  public static SqlConnection Cnn
  {
    [DebuggerNonUserCode] get => mPublicModule._Cnn;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      mPublicModule._Cnn = value;
    }
  }
}
