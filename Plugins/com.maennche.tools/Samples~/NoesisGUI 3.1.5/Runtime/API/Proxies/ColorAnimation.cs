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

namespace Noesis
{

public class ColorAnimation : BaseAnimation {
  internal new static ColorAnimation CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ColorAnimation(cPtr, cMemoryOwn);
  }

  internal ColorAnimation(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ColorAnimation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public static DependencyProperty ByProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ColorAnimation_ByProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FromProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ColorAnimation_FromProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ToProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ColorAnimation_ToProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Nullable<Color> From {
    set {
      NullableColor tempvalue = value;
      NoesisGUI_PINVOKE.ColorAnimation_From_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.ColorAnimation_From_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableColor>(ret);
      }
      else {
        return new Nullable<Color>();
      }
    }

  }

  public Nullable<Color> To {
    set {
      NullableColor tempvalue = value;
      NoesisGUI_PINVOKE.ColorAnimation_To_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.ColorAnimation_To_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableColor>(ret);
      }
      else {
        return new Nullable<Color>();
      }
    }

  }

  public Nullable<Color> By {
    set {
      NullableColor tempvalue = value;
      NoesisGUI_PINVOKE.ColorAnimation_By_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.ColorAnimation_By_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableColor>(ret);
      }
      else {
        return new Nullable<Color>();
      }
    }

  }

  public ColorAnimation() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_ColorAnimation();
  }

}

}

