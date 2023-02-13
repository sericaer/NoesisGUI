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

public class Button : ButtonBase {
  internal new static Button CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Button(cPtr, cMemoryOwn);
  }

  internal Button(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Button obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Button() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Button)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Button();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsCancelProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Button_IsCancelProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsDefaultProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Button_IsDefaultProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsDefaultedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Button_IsDefaultedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsCancel {
    set {
      NoesisGUI_PINVOKE.Button_IsCancel_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Button_IsCancel_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsDefault {
    set {
      NoesisGUI_PINVOKE.Button_IsDefault_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Button_IsDefault_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsDefaulted {
    get {
      bool ret = NoesisGUI_PINVOKE.Button_IsDefaulted_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Button(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

