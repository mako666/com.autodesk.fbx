//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.11
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FbxSdk {

public class FbxImplementationFilter : FbxObjectFilter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxImplementationFilter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxImplementationFilter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxImplementationFilter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxImplementationFilter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxImplementationFilter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static string sCHR_ANY_SHADING_API {
    set {
      examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_API_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_API_get();
      return ret;
    } 
  }

  public static string sCHR_ANY_SHADING_API_VERSION {
    set {
      examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_API_VERSION_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_API_VERSION_get();
      return ret;
    } 
  }

  public static string sCHR_ANY_SHADING_LANGUAGE {
    set {
      examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_LANGUAGE_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_LANGUAGE_get();
      return ret;
    } 
  }

  public static string sCHR_ANY_SHADING_LANGUAGE_VERSION {
    set {
      examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_LANGUAGE_VERSION_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxImplementationFilter_sCHR_ANY_SHADING_LANGUAGE_VERSION_get();
      return ret;
    } 
  }

  public FbxImplementationFilter(string pShadingAPI, string pShadingAPIVersion, string pShadingLanguage, string pShadingLanguageVersion) : this(examplePINVOKE.new_FbxImplementationFilter__SWIG_0(pShadingAPI, pShadingAPIVersion, pShadingLanguage, pShadingLanguageVersion), true) {
  }

  public FbxImplementationFilter(string pShadingAPI, string pShadingAPIVersion, string pShadingLanguage) : this(examplePINVOKE.new_FbxImplementationFilter__SWIG_1(pShadingAPI, pShadingAPIVersion, pShadingLanguage), true) {
  }

  public FbxImplementationFilter(string pShadingAPI, string pShadingAPIVersion) : this(examplePINVOKE.new_FbxImplementationFilter__SWIG_2(pShadingAPI, pShadingAPIVersion), true) {
  }

  public FbxImplementationFilter(string pShadingAPI) : this(examplePINVOKE.new_FbxImplementationFilter__SWIG_3(pShadingAPI), true) {
  }

  public FbxImplementationFilter() : this(examplePINVOKE.new_FbxImplementationFilter__SWIG_4(), true) {
  }

  public override bool Match(FbxObject pObjectPtr) {
    bool ret = examplePINVOKE.FbxImplementationFilter_Match(swigCPtr, FbxObject.getCPtr(pObjectPtr));
    return ret;
  }

  public FbxString mShadingAPI {
    set {
      examplePINVOKE.FbxImplementationFilter_mShadingAPI_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxImplementationFilter_mShadingAPI_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mShadingAPIVersion {
    set {
      examplePINVOKE.FbxImplementationFilter_mShadingAPIVersion_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxImplementationFilter_mShadingAPIVersion_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mShadingLanguage {
    set {
      examplePINVOKE.FbxImplementationFilter_mShadingLanguage_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxImplementationFilter_mShadingLanguage_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mShadingLanguageVersion {
    set {
      examplePINVOKE.FbxImplementationFilter_mShadingLanguageVersion_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxImplementationFilter_mShadingLanguageVersion_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public static bool IsShadingObject(FbxObject pObject) {
    bool ret = examplePINVOKE.FbxImplementationFilter_IsShadingObject(FbxObject.getCPtr(pObject));
    return ret;
  }

  public static FbxCriteria Criteria() {
    FbxCriteria ret = new FbxCriteria(examplePINVOKE.FbxImplementationFilter_Criteria(), true);
    return ret;
  }

}

}