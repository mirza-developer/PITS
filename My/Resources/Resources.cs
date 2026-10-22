// Decompiled with JetBrains decompiler
// Type: PITS.Admin_BussinessLayer.My.Resources.Resources
// Assembly: PITS.Admin_BussinessLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 541266A9-52BB-4CE1-A44B-AF9C97FB0423
// Assembly location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.DLL
// XML documentation location: C:\Users\Software-Lead\Desktop\PITS.Town_Installation\PITS.Town_Installation\PITS.Admin_BussinessLayer.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace PITS.Admin_BussinessLayer.My.Resources;

/// <summary>A strongly-typed resource class, for looking up localized strings, etc.</summary>
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[HideModuleName]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  /// <summary>Returns the cached ResourceManager instance used by this class.</summary>
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) PITS.Admin_BussinessLayer.My.Resources.Resources.resourceMan, (object) null))
        PITS.Admin_BussinessLayer.My.Resources.Resources.resourceMan = new ResourceManager("PITS.Admin_BussinessLayer.Resources", typeof (PITS.Admin_BussinessLayer.My.Resources.Resources).Assembly);
      return PITS.Admin_BussinessLayer.My.Resources.Resources.resourceMan;
    }
  }

  /// <summary>
  ///   Overrides the current thread's CurrentUICulture property for all
  ///   resource lookups using this strongly typed resource class.
  /// </summary>
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => PITS.Admin_BussinessLayer.My.Resources.Resources.resourceCulture;
    set => PITS.Admin_BussinessLayer.My.Resources.Resources.resourceCulture = value;
  }
}
