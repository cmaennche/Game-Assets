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
using System.Windows.Input;

namespace Noesis
{

public class MouseBinding : InputBinding {
  internal new static MouseBinding CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new MouseBinding(cPtr, cMemoryOwn);
  }

  internal MouseBinding(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(MouseBinding obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public MouseBinding(ICommand command, MouseGesture gesture)
    : this(CreateMouseBinding(command, gesture), true) {
  }

  public MouseBinding(ICommand command, MouseAction action, ModifierKeys modifiers)
    : this(CreateMouseBinding(command, new MouseGesture(action, modifiers)), true) {
  }

  internal static MouseAction ParseMouseAction(string source) {
    return (MouseAction)MouseBinding.ParseMouseActionHelper(source);
  }

  internal static MouseGesture ParseMouseGesture(string source) {
    IntPtr cPtr = MouseBinding.ParseMouseGestureHelper(source);
    return (MouseGesture)Noesis.Extend.GetProxy(cPtr, true);
  }

  public MouseBinding() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_MouseBinding();
  }

  public static DependencyProperty MouseActionProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.MouseBinding_MouseActionProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ModifiersProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.MouseBinding_ModifiersProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public MouseAction MouseAction {
    set {
      NoesisGUI_PINVOKE.MouseBinding_MouseAction_set(swigCPtr, (int)value);
    } 
    get {
      MouseAction ret = (MouseAction)NoesisGUI_PINVOKE.MouseBinding_MouseAction_get(swigCPtr);
      return ret;
    } 
  }

  public ModifierKeys Modifiers {
    set {
      NoesisGUI_PINVOKE.MouseBinding_Modifiers_set(swigCPtr, (int)value);
    } 
    get {
      ModifierKeys ret = (ModifierKeys)NoesisGUI_PINVOKE.MouseBinding_Modifiers_get(swigCPtr);
      return ret;
    } 
  }

  private static IntPtr CreateMouseBinding(object command, MouseGesture gesture) {
    IntPtr ret = NoesisGUI_PINVOKE.MouseBinding_CreateMouseBinding(Noesis.Extend.GetInstanceHandle(command), MouseGesture.getCPtr(gesture));
    return ret;
  }

  private static uint ParseMouseActionHelper(string str) {
    uint ret = NoesisGUI_PINVOKE.MouseBinding_ParseMouseActionHelper(str != null ? str : string.Empty);
    return ret;
  }

  private static IntPtr ParseMouseGestureHelper(string str) {
    IntPtr ret = NoesisGUI_PINVOKE.MouseBinding_ParseMouseGestureHelper(str != null ? str : string.Empty);
    return ret;
  }

}

}
