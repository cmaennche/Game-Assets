//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;

namespace Noesis
{

public static class Fonts {
  public static ICollection<Typeface> GetTypefaces(Stream stream) {
    TypefacesInfo info = new TypefacesInfo { Typefaces = new List<Typeface>() };
    uint id = _getTypefacesId++;
    _getTypefacesCallbacks.Add(id, info);
    Fonts_GetTypefaces(Noesis.Extend.GetInstanceHandle(stream), id, _getTypefaces);
    _getTypefacesCallbacks.Remove(id);
    return info.Typefaces;
  }

  #region GetTypefaces callback
  private delegate void Callback_GetTypefaces(uint id, Typeface typeface);
  private static Callback_GetTypefaces _getTypefaces = OnGetTypefaces;

  [MonoPInvokeCallback(typeof(Callback_GetTypefaces))]
  private static void OnGetTypefaces(uint id, Typeface typeface) {
    try {
      TypefacesInfo info = _getTypefacesCallbacks[id];
      info.Typefaces.Add(typeface);
    }
    catch (Exception e) {
      Noesis.Error.UnhandledException(e);
    }
  }

  private struct TypefacesInfo
  {
    public List<Typeface> Typefaces;
  }

  private static uint _getTypefacesId = 0;
  private static Dictionary<uint, TypefacesInfo> _getTypefacesCallbacks =
    new Dictionary<uint, TypefacesInfo>();

  [DllImport(Library.Name)]
  private static extern void Fonts_GetTypefaces(HandleRef stream, uint id, Callback_GetTypefaces callback);

  #endregion

}

}

