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

public class TransformGroup : Transform {
  internal new static TransformGroup CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TransformGroup(cPtr, cMemoryOwn);
  }

  internal TransformGroup(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TransformGroup obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public TransformGroup() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_TransformGroup();
  }

  public static DependencyProperty ChildrenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TransformGroup_ChildrenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public TransformCollection Children {
    set {
      NoesisGUI_PINVOKE.TransformGroup_Children_set(swigCPtr, TransformCollection.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TransformGroup_Children_get(swigCPtr);
      return (TransformCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

