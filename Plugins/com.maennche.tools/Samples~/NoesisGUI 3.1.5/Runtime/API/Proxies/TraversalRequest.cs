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

public class TraversalRequest : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TraversalRequest(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TraversalRequest obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TraversalRequest() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_TraversalRequest(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public FocusNavigationDirection FocusNavigationDirection {
    get {
      FocusNavigationDirection ret = (FocusNavigationDirection)NoesisGUI_PINVOKE.TraversalRequest_FocusNavigationDirection_get(swigCPtr);
      return ret;
    } 
  }

  public bool Wrapped {
    set {
      NoesisGUI_PINVOKE.TraversalRequest_Wrapped_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.TraversalRequest_Wrapped_get(swigCPtr);
      return ret;
    } 
  }

  public TraversalRequest(FocusNavigationDirection direction) : this(NoesisGUI_PINVOKE.new_TraversalRequest((int)direction), true) {
  }

}

}

