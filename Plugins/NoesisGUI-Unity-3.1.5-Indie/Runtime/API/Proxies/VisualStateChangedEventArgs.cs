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

public class VisualStateChangedEventArgs : EventArgs {
  private HandleRef swigCPtr;

  internal VisualStateChangedEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(VisualStateChangedEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~VisualStateChangedEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_VisualStateChangedEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public VisualState OldState {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateChangedEventArgs_OldState_get(swigCPtr);
      return (VisualState)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public VisualState NewState {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateChangedEventArgs_NewState_get(swigCPtr);
      return (VisualState)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public FrameworkElement Control {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateChangedEventArgs_Control_get(swigCPtr);
      return (FrameworkElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public FrameworkElement StateGroupsRoot {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateChangedEventArgs_StateGroupsRoot_get(swigCPtr);
      return (FrameworkElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

