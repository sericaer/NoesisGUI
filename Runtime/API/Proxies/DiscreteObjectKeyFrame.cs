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

public class DiscreteObjectKeyFrame : ObjectKeyFrame {
  internal new static DiscreteObjectKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new DiscreteObjectKeyFrame(cPtr, cMemoryOwn);
  }

  internal DiscreteObjectKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(DiscreteObjectKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public DiscreteObjectKeyFrame() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_DiscreteObjectKeyFrame();
  }

}

}

