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

public class Track : FrameworkElement {
  internal new static Track CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Track(cPtr, cMemoryOwn);
  }

  internal Track(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Track obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Track() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Track)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Track();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public float ValueFromDistance(float horizontal, float vertical) {
    float ret = NoesisGUI_PINVOKE.Track_ValueFromDistance(swigCPtr, horizontal, vertical);
    return ret;
  }

  public float ValueFromPoint(Point point) {
    float ret = NoesisGUI_PINVOKE.Track_ValueFromPoint(swigCPtr, ref point);
    return ret;
  }

  public static DependencyProperty IsDirectionReversedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_IsDirectionReversedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MaximumProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_MaximumProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MinimumProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_MinimumProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty OrientationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_OrientationProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ValueProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_ValueProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ViewportSizeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_ViewportSizeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public RepeatButton DecreaseRepeatButton {
    set {
      NoesisGUI_PINVOKE.Track_DecreaseRepeatButton_set(swigCPtr, RepeatButton.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_DecreaseRepeatButton_get(swigCPtr);
      return (RepeatButton)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public RepeatButton IncreaseRepeatButton {
    set {
      NoesisGUI_PINVOKE.Track_IncreaseRepeatButton_set(swigCPtr, RepeatButton.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_IncreaseRepeatButton_get(swigCPtr);
      return (RepeatButton)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsDirectionReversed {
    set {
      NoesisGUI_PINVOKE.Track_IsDirectionReversed_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Track_IsDirectionReversed_get(swigCPtr);
      return ret;
    } 
  }

  public float Maximum {
    set {
      NoesisGUI_PINVOKE.Track_Maximum_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Track_Maximum_get(swigCPtr);
      return ret;
    } 
  }

  public float Minimum {
    set {
      NoesisGUI_PINVOKE.Track_Minimum_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Track_Minimum_get(swigCPtr);
      return ret;
    } 
  }

  public Orientation Orientation {
    set {
      NoesisGUI_PINVOKE.Track_Orientation_set(swigCPtr, (int)value);
    } 
    get {
      Orientation ret = (Orientation)NoesisGUI_PINVOKE.Track_Orientation_get(swigCPtr);
      return ret;
    } 
  }

  public Thumb Thumb {
    set {
      NoesisGUI_PINVOKE.Track_Thumb_set(swigCPtr, Thumb.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Track_Thumb_get(swigCPtr);
      return (Thumb)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float Value {
    set {
      NoesisGUI_PINVOKE.Track_Value_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Track_Value_get(swigCPtr);
      return ret;
    } 
  }

  public float ViewportSize {
    set {
      NoesisGUI_PINVOKE.Track_ViewportSize_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Track_ViewportSize_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Track(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

