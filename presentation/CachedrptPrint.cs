// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.CachedrptPrint
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace PITS.Town_PresentationLayer;

[ToolboxBitmap(typeof (ExportOptions), "report.bmp")]
public class CachedrptPrint : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedrptPrint()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedrptPrint.__ENCList)
    {
      if (CachedrptPrint.__ENCList.Count == CachedrptPrint.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedrptPrint.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedrptPrint.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedrptPrint.__ENCList[index1] = CachedrptPrint.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedrptPrint.__ENCList.RemoveRange(index1, checked (CachedrptPrint.__ENCList.Count - index1));
        CachedrptPrint.__ENCList.Capacity = CachedrptPrint.__ENCList.Count;
      }
      CachedrptPrint.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedrptPrint() => CachedrptPrint.__ENCAddToList((object) this);

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public virtual bool IsCacheable
  {
    get => true;
    set
    {
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public virtual bool ShareDBLogonInfo
  {
    get => false;
    set
    {
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual TimeSpan CacheTimeOut
  {
    get => CachedReportConstants.DEFAULT_TIMEOUT;
    set
    {
    }
  }

  public virtual ReportDocument CreateReport()
  {
    rptPrint report = new rptPrint();
    ((ReportDocument) report).Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
