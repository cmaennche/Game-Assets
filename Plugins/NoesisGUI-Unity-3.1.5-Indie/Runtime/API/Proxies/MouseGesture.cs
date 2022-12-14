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

[System.ComponentModel.TypeConverter(typeof(MouseGestureConverter))]
public class MouseGesture : InputGesture {
  internal new static MouseGesture CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new MouseGesture(cPtr, cMemoryOwn);
  }

  internal MouseGesture(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(MouseGesture obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public MouseGesture() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_MouseGesture__SWIG_0();
  }

  public MouseGesture(MouseAction key, ModifierKeys modifiers) : this(NoesisGUI_PINVOKE.new_MouseGesture__SWIG_1((int)key, (int)modifiers), true) {
  }

  public MouseGesture(MouseAction key) : this(NoesisGUI_PINVOKE.new_MouseGesture__SWIG_2((int)key), true) {
  }

  public MouseAction MouseAction {
    get {
      MouseAction ret = (MouseAction)NoesisGUI_PINVOKE.MouseGesture_MouseAction_get(swigCPtr);
      return ret;
    } 
  }

  public ModifierKeys Modifiers {
    get {
      ModifierKeys ret = (ModifierKeys)NoesisGUI_PINVOKE.MouseGesture_Modifiers_get(swigCPtr);
      return ret;
    } 
  }

}

}

