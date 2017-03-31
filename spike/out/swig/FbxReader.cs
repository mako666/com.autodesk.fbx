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

public class FbxReader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxReader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxReader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxReader() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxReader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void GetVersion(SWIGTYPE_p_int pMajor, SWIGTYPE_p_int pMinor, SWIGTYPE_p_int pRevision) {
    examplePINVOKE.FbxReader_GetVersion(swigCPtr, SWIGTYPE_p_int.getCPtr(pMajor), SWIGTYPE_p_int.getCPtr(pMinor), SWIGTYPE_p_int.getCPtr(pRevision));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool FileOpen(string pFileName) {
    bool ret = examplePINVOKE.FbxReader_FileOpen__SWIG_0(swigCPtr, pFileName);
    return ret;
  }

  public virtual bool FileOpen(FbxStream pStream, SWIGTYPE_p_void pStreamData) {
    bool ret = examplePINVOKE.FbxReader_FileOpen__SWIG_1(swigCPtr, FbxStream.getCPtr(pStream), SWIGTYPE_p_void.getCPtr(pStreamData));
    return ret;
  }

  public virtual bool FileClose() {
    bool ret = examplePINVOKE.FbxReader_FileClose(swigCPtr);
    return ret;
  }

  public virtual bool IsFileOpen() {
    bool ret = examplePINVOKE.FbxReader_IsFileOpen(swigCPtr);
    return ret;
  }

  public virtual bool GetReadOptions(bool pParseFileAsNeeded) {
    bool ret = examplePINVOKE.FbxReader_GetReadOptions__SWIG_0(swigCPtr, pParseFileAsNeeded);
    return ret;
  }

  public virtual bool GetReadOptions() {
    bool ret = examplePINVOKE.FbxReader_GetReadOptions__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual bool Read(FbxDocument pDocument) {
    bool ret = examplePINVOKE.FbxReader_Read(swigCPtr, FbxDocument.getCPtr(pDocument));
    return ret;
  }

  public virtual void PluginReadParameters(FbxObject pParams) {
    examplePINVOKE.FbxReader_PluginReadParameters(swigCPtr, FbxObject.getCPtr(pParams));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool FileOpen(string pFileName, FbxReader.EFileOpenSpecialFlags arg1) {
    bool ret = examplePINVOKE.FbxReader_FileOpen__SWIG_2(swigCPtr, pFileName, (int)arg1);
    return ret;
  }

  public virtual bool GetAxisInfo(FbxAxisSystem arg0, FbxSystemUnit arg1) {
    bool ret = examplePINVOKE.FbxReader_GetAxisInfo(swigCPtr, FbxAxisSystem.getCPtr(arg0), FbxSystemUnit.getCPtr(arg1));
    return ret;
  }

  public virtual bool GetStatistics(FbxStatistics arg0) {
    bool ret = examplePINVOKE.FbxReader_GetStatistics(swigCPtr, FbxStatistics.getCPtr(arg0));
    return ret;
  }

  public virtual bool GetFrameRate(SWIGTYPE_p_FbxTime__EMode pTimeMode) {
    bool ret = examplePINVOKE.FbxReader_GetFrameRate(swigCPtr, SWIGTYPE_p_FbxTime__EMode.getCPtr(pTimeMode));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FbxDocumentInfo GetSceneInfo() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxReader_GetSceneInfo(swigCPtr);
    FbxDocumentInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocumentInfo(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_FbxArrayT_FbxTakeInfo_p_t GetTakeInfo() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxReader_GetTakeInfo(swigCPtr);
    SWIGTYPE_p_FbxArrayT_FbxTakeInfo_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxArrayT_FbxTakeInfo_p_t(cPtr, false);
    return ret;
  }

  public virtual bool GetDefaultRenderResolution(FbxString pCamName, FbxString pResolutionMode, SWIGTYPE_p_double pW, SWIGTYPE_p_double pH) {
    bool ret = examplePINVOKE.FbxReader_GetDefaultRenderResolution(swigCPtr, FbxString.getCPtr(pCamName), FbxString.getCPtr(pResolutionMode), SWIGTYPE_p_double.getCPtr(pW), SWIGTYPE_p_double.getCPtr(pH));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsGenuine() {
    bool ret = examplePINVOKE.FbxReader_IsGenuine(swigCPtr);
    return ret;
  }

  public virtual FbxIOSettings GetIOSettings() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxReader_GetIOSettings(swigCPtr);
    FbxIOSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOSettings(cPtr, false);
    return ret;
  }

  public virtual void SetIOSettings(FbxIOSettings pIOSettings) {
    examplePINVOKE.FbxReader_SetIOSettings(swigCPtr, FbxIOSettings.getCPtr(pIOSettings));
  }

  public virtual void SetProgressHandler(FbxProgress arg0) {
    examplePINVOKE.FbxReader_SetProgressHandler(swigCPtr, FbxProgress.getCPtr(arg0));
  }

  public virtual void SetEmbeddingExtractionFolder(string arg0) {
    examplePINVOKE.FbxReader_SetEmbeddingExtractionFolder(swigCPtr, arg0);
  }

  public virtual bool SupportsStreams() {
    bool ret = examplePINVOKE.FbxReader_SupportsStreams(swigCPtr);
    return ret;
  }

  public virtual bool FileOpen(FbxFile pFile) {
    bool ret = examplePINVOKE.FbxReader_FileOpen__SWIG_3(swigCPtr, FbxFile.getCPtr(pFile));
    return ret;
  }

  public FbxStatus GetStatus() {
    FbxStatus ret = new FbxStatus(examplePINVOKE.FbxReader_GetStatus(swigCPtr), false);
    return ret;
  }

  public enum EInfoRequest {
    eInfoExtension,
    eInfoDescriptions,
    eReserved1 = 0xFBFB
  }

  public enum EFileOpenSpecialFlags {
    eParseForGlobalSettings = 1,
    eParseForStatistics = 2
  }

}

}