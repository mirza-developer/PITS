// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.LoadWithThread.cInputBoxProvider
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using Microsoft.VisualBasic.CompilerServices;
using MPS.NET_Controls;
using PITS.Admin_BussinessLayer;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer.LoadWithThread;

public class cInputBoxProvider
{
  private InputBox PrInputbox;

  public cInputBoxProvider(InputBox InputBox)
  {
    this.PrInputbox = new InputBox();
    this.PrInputbox = InputBox;
  }

  public void StartLoading()
  {
    ArrayList arrayList1 = new ArrayList((ICollection) new cConnectionString().GetServerList());
    if (this.PrInputbox.InvokeRequired)
    {
      this.PrInputbox.Invoke((Delegate) new cInputBoxProvider.MyDelegate(this.StartLoading), new object[0]);
    }
    else
    {
      int count = arrayList1.Count;
      int num = 1;
      while (num <= count)
      {
        InputBox prInputbox = this.PrInputbox;
        object[] objArray1 = new object[2];
        object[] objArray2 = objArray1;
        ArrayList arrayList2 = arrayList1;
        ArrayList arrayList3 = arrayList2;
        int index1 = checked (num - 1);
        int index2 = index1;
        object objectValue = RuntimeHelpers.GetObjectValue(arrayList3[index2]);
        objArray2[0] = objectValue;
        objArray1[1] = (object) num.ToString();
        object[] objArray3 = objArray1;
        object[] Arguments = objArray3;
        bool[] flagArray = new bool[2]{ true, false };
        bool[] CopyBack = flagArray;
        NewLateBinding.LateCall((object) prInputbox, (Type) null, "AddItem", Arguments, (string[]) null, (Type[]) null, CopyBack, true);
        if (flagArray[0])
          arrayList2[index1] = RuntimeHelpers.GetObjectValue(objArray3[0]);
        checked { ++num; }
      }
      this.PrInputbox.Cursor = Cursors.Default;
      this.PrInputbox.Button.Enabled = true;
      this.PrInputbox.ButtonDropDownEnable = true;
      this.PrInputbox.OpenDropDown();
    }
  }

  private delegate void MyDelegate();
}
