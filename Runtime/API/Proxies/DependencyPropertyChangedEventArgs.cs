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

public class DependencyPropertyChangedEventArgs : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DependencyPropertyChangedEventArgs(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DependencyPropertyChangedEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DependencyPropertyChangedEventArgs() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_DependencyPropertyChangedEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  internal static void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    DependencyPropertyChangedEventHandler handler_ = (DependencyPropertyChangedEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new DependencyPropertyChangedEventArgs(args, false));
    }
  }

  public object NewValue {
    get {
      IntPtr cPtr = GetNewValueHelper();
      return GetValueHelper(Noesis.Extend.GetProxy(cPtr, true));
    }
  }

  public object OldValue {
    get {
      IntPtr cPtr = GetOldValueHelper();
      return GetValueHelper(Noesis.Extend.GetProxy(cPtr, true));
    }
  }

  public Noesis.DependencyProperty Property {
    get {
      return GetPropertyHelper();
    }
  }

  private object GetValueHelper(object value) {
    Type type = Property.PropertyType;
    if (type.GetTypeInfo().IsEnum) {
      return Enum.ToObject(type, (int)value);
    }
    else {
      return value;
    }
  }

  private IntPtr GetNewValueHelper() {
    IntPtr ret = NoesisGUI_PINVOKE.DependencyPropertyChangedEventArgs_GetNewValueHelper(swigCPtr);
    return ret;
  }

  private IntPtr GetOldValueHelper() {
    IntPtr ret = NoesisGUI_PINVOKE.DependencyPropertyChangedEventArgs_GetOldValueHelper(swigCPtr);
    return ret;
  }

  private DependencyProperty GetPropertyHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.DependencyPropertyChangedEventArgs_GetPropertyHelper(swigCPtr);
    return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
  }

}

}

