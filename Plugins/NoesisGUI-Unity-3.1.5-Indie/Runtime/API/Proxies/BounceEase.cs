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

public class BounceEase : EasingFunctionBase {
  internal new static BounceEase CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new BounceEase(cPtr, cMemoryOwn);
  }

  internal BounceEase(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(BounceEase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public BounceEase() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_BounceEase();
  }

  public static DependencyProperty BouncesProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.BounceEase_BouncesProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty BouncinessProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.BounceEase_BouncinessProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public int Bounces {
    set {
      NoesisGUI_PINVOKE.BounceEase_Bounces_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.BounceEase_Bounces_get(swigCPtr);
      return ret;
    } 
  }

  public float Bounciness {
    set {
      NoesisGUI_PINVOKE.BounceEase_Bounciness_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.BounceEase_Bounciness_get(swigCPtr);
      return ret;
    } 
  }

}

}
