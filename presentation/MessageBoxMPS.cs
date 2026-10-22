// Decompiled with JetBrains decompiler
// Type: PITS.Town_PresentationLayer.MessageBoxMPS
// Assembly: PITS.Town_PresentationLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 086B9F89-B27A-4DB9-8C3A-9FC035738ADD
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.exe
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Town_PresentationLayer.xml

using PITS.Admin_BussinessLayer.Enumaration;
using System.Diagnostics;
using System.Windows.Forms;

#nullable disable
namespace PITS.Town_PresentationLayer;

public class MessageBoxMPS
{
  [DebuggerNonUserCode]
  public MessageBoxMPS()
  {
  }

  public static Enum_MsgboxResualt show(
    Form Parent,
    string BodyText,
    Enum_MsgboxTitle Title,
    Enum_MsgboxButton ButtonType,
    Enum_MsgboxDefualButton DefaultButton,
    string Details = "")
  {
    frmMessageBox frmMessageBox = new frmMessageBox(Parent, BodyText, (int) Title, (int) ButtonType, (int) DefaultButton, Details);
    int num = (int) frmMessageBox.ShowDialog();
    return (Enum_MsgboxResualt) frmMessageBox.Resault;
  }
}
