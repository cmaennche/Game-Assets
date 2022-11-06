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

public class Pen : Animatable {
  internal new static Pen CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Pen(cPtr, cMemoryOwn);
  }

  internal Pen(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Pen obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Pen() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Pen();
  }

  public static DependencyProperty BrushProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_BrushProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty DashCapProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_DashCapProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty DashStyleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_DashStyleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty EndLineCapProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_EndLineCapProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty LineJoinProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_LineJoinProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MiterLimitProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_MiterLimitProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StartLineCapProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_StartLineCapProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ThicknessProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_ThicknessProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TrimStartProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_TrimStartProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TrimEndProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_TrimEndProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TrimOffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_TrimOffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Brush Brush {
    set {
      NoesisGUI_PINVOKE.Pen_Brush_set(swigCPtr, Brush.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_Brush_get(swigCPtr);
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public PenLineCap DashCap {
    set {
      NoesisGUI_PINVOKE.Pen_DashCap_set(swigCPtr, (int)value);
    } 
    get {
      PenLineCap ret = (PenLineCap)NoesisGUI_PINVOKE.Pen_DashCap_get(swigCPtr);
      return ret;
    } 
  }

  public DashStyle DashStyle {
    set {
      NoesisGUI_PINVOKE.Pen_DashStyle_set(swigCPtr, DashStyle.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Pen_DashStyle_get(swigCPtr);
      return (DashStyle)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public PenLineCap EndLineCap {
    set {
      NoesisGUI_PINVOKE.Pen_EndLineCap_set(swigCPtr, (int)value);
    } 
    get {
      PenLineCap ret = (PenLineCap)NoesisGUI_PINVOKE.Pen_EndLineCap_get(swigCPtr);
      return ret;
    } 
  }

  public PenLineJoin LineJoin {
    set {
      NoesisGUI_PINVOKE.Pen_LineJoin_set(swigCPtr, (int)value);
    } 
    get {
      PenLineJoin ret = (PenLineJoin)NoesisGUI_PINVOKE.Pen_LineJoin_get(swigCPtr);
      return ret;
    } 
  }

  public float MiterLimit {
    set {
      NoesisGUI_PINVOKE.Pen_MiterLimit_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Pen_MiterLimit_get(swigCPtr);
      return ret;
    } 
  }

  public PenLineCap StartLineCap {
    set {
      NoesisGUI_PINVOKE.Pen_StartLineCap_set(swigCPtr, (int)value);
    } 
    get {
      PenLineCap ret = (PenLineCap)NoesisGUI_PINVOKE.Pen_StartLineCap_get(swigCPtr);
      return ret;
    } 
  }

  public float Thickness {
    set {
      NoesisGUI_PINVOKE.Pen_Thickness_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Pen_Thickness_get(swigCPtr);
      return ret;
    } 
  }

  public float TrimStart {
    set {
      NoesisGUI_PINVOKE.Pen_TrimStart_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Pen_TrimStart_get(swigCPtr);
      return ret;
    } 
  }

  public float TrimEnd {
    set {
      NoesisGUI_PINVOKE.Pen_TrimEnd_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Pen_TrimEnd_get(swigCPtr);
      return ret;
    } 
  }

  public float TrimOffset {
    set {
      NoesisGUI_PINVOKE.Pen_TrimOffset_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Pen_TrimOffset_get(swigCPtr);
      return ret;
    } 
  }

}

}

