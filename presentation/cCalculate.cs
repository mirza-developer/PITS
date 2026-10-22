// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.cCalculate
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;

#nullable disable
namespace PITS.Town_PresentationLayer;

public class cCalculate
{
  [DebuggerNonUserCode]
  public cCalculate()
  {
  }

  public static string DeffDate(string Date1, string Date2)
  {
    Date1 = cConvert.ShamsiToMiladi(Date1);
    Date2 = cConvert.ShamsiToMiladi(Date2);
    return Conversions.ToString(DateAndTime.DateDiff("d", (object) Date1, (object) Date2));
  }

  public static string AverageForMonth(string MasrafeDore, string ModateDore)
  {
    return Conversions.ToString(Conversion.Val(MasrafeDore) / Conversion.Val(ModateDore) * 30.0);
  }
}
