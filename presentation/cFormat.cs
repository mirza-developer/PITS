// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.cFormat
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;

#nullable disable
namespace PITS.Town_PresentationLayer;

public class cFormat
{
  [DebuggerNonUserCode]
  public cFormat()
  {
  }

  public static string Currency(string Value)
  {
    string str1 = "";
    Collection collection = new Collection();
    int length = Value.Length;
    while (length >= 1)
    {
      if (str1.Length == 3)
      {
        collection.Add((object) str1, (string) null, (object) null, (object) null);
        str1 = Strings.Mid(Value, length, 1);
      }
      else
        str1 = Strings.Mid(Value, length, 1) + str1;
      checked { length += -1; }
    }
    collection.Add((object) str1, (string) null, (object) null, (object) null);
    string str2 = "";
    int count = collection.Count;
    while (count >= 1)
    {
      str2 = count != collection.Count ? Conversions.ToString(Operators.ConcatenateObject((object) (str2 + ","), collection[count])) : Conversions.ToString(collection[count]);
      checked { count += -1; }
    }
    return str2;
  }
}
