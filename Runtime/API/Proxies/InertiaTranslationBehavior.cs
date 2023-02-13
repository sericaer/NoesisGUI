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

public class InertiaTranslationBehavior : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InertiaTranslationBehavior(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(InertiaTranslationBehavior obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~InertiaTranslationBehavior() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_InertiaTranslationBehavior(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public float DesiredDeceleration {
    set {
      NoesisGUI_PINVOKE.InertiaTranslationBehavior_DesiredDeceleration_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.InertiaTranslationBehavior_DesiredDeceleration_get(swigCPtr);
      return ret;
    } 
  }

  public float DesiredDisplacement {
    set {
      NoesisGUI_PINVOKE.InertiaTranslationBehavior_DesiredDisplacement_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.InertiaTranslationBehavior_DesiredDisplacement_get(swigCPtr);
      return ret;
    } 
  }

  public InertiaTranslationBehavior() : this(NoesisGUI_PINVOKE.new_InertiaTranslationBehavior(), true) {
  }

}

}

