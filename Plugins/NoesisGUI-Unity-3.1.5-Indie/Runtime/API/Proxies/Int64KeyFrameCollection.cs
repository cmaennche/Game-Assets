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

public class Int64KeyFrameCollection : FreezableCollection<Int64KeyFrame> {
  internal new static Int64KeyFrameCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Int64KeyFrameCollection(cPtr, cMemoryOwn);
  }

  internal Int64KeyFrameCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Int64KeyFrameCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Int64KeyFrameCollection() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Int64KeyFrameCollection();
  }

}

}

