// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.cConvert
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

#nullable disable
namespace PITS.Town_PresentationLayer;

public class cConvert
{
  [DebuggerNonUserCode]
  public cConvert()
  {
  }

  public static string ShamsiToMiladi(string ShamsiDate)
  {
    int int32_1 = Convert.ToInt32(ShamsiDate.Substring(8, 2));
    int int32_2 = Convert.ToInt32(ShamsiDate.Substring(5, 2));
    return new PersianCalendar().ToDateTime(Convert.ToInt32(ShamsiDate.Substring(0, 4)), int32_2, int32_1, 0, 0, 0, 0).ToString().Substring(0, 10);
  }

  public static string CurrencyToDigit(string CurrencyValue)
  {
    if (Operators.CompareString(CurrencyValue, "", false) == 0)
      return "0";
    string[] source = CurrencyValue.Split(',');
    string digit = "";
    int num = checked (((IEnumerable<string>) source).Count<string>() - 1);
    int index = 0;
    while (index <= num)
    {
      digit += source[index];
      checked { ++index; }
    }
    return digit;
  }
}
