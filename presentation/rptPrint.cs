// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.rptPrint
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace PITS.Town_PresentationLayer;

public class rptPrint : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static rptPrint()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (rptPrint.__ENCList)
    {
      if (rptPrint.__ENCList.Count == rptPrint.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (rptPrint.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (rptPrint.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              rptPrint.__ENCList[index1] = rptPrint.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        rptPrint.__ENCList.RemoveRange(index1, checked (rptPrint.__ENCList.Count - index1));
        rptPrint.__ENCList.Capacity = rptPrint.__ENCList.Count;
      }
      rptPrint.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public rptPrint() => rptPrint.__ENCAddToList((object) this);

  public virtual string ResourceName
  {
    get => "rptPrint.rpt";
    set
    {
    }
  }

  public virtual bool NewGenerator
  {
    get => true;
    set
    {
    }
  }

  public virtual string FullResourceName
  {
    get => "PITS.Town_PresentationLayer.rptPrint.rpt";
    set
    {
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section1 => ((ReportDocument) this).ReportDefinition.Sections[0];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section2 => ((ReportDocument) this).ReportDefinition.Sections[1];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section3 => ((ReportDocument) this).ReportDefinition.Sections[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section4 => ((ReportDocument) this).ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => ((ReportDocument) this).ReportDefinition.Sections[4];
}
