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

public class PointAnimationUsingKeyFrames : AnimationTimeline {
  internal new static PointAnimationUsingKeyFrames CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PointAnimationUsingKeyFrames(cPtr, cMemoryOwn);
  }

  internal PointAnimationUsingKeyFrames(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PointAnimationUsingKeyFrames obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public PointAnimationUsingKeyFrames() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_PointAnimationUsingKeyFrames();
  }

  public PointKeyFrameCollection KeyFrames {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PointAnimationUsingKeyFrames_KeyFrames_get(swigCPtr);
      return (PointKeyFrameCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

