// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.I_IUDS
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using System.Data;

#nullable disable
namespace PITS.Admin_BussinessLayer;

public interface I_IUDS
{
  int Identity { get; set; }

  string ErrorMessage { get; }

  string ErrorDescription { get; }

  DataTable ResaultTable { get; }

  bool Load();

  bool LoadRecord();

  bool Add();

  bool Edit();

  bool Delete();

  void BuiltSqlParameter();

  void BuiltSqlCommand(Enum_ProcedureName ProcedureName);
}
