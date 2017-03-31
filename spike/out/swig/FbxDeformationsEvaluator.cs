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

public class FbxDeformationsEvaluator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxDeformationsEvaluator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxDeformationsEvaluator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxDeformationsEvaluator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxDeformationsEvaluator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool Init(FbxNode pNode, FbxMesh pMesh) {
    bool ret = examplePINVOKE.FbxDeformationsEvaluator_Init(swigCPtr, FbxNode.getCPtr(pNode), FbxMesh.getCPtr(pMesh));
    return ret;
  }

  public bool ComputeShapeDeformation(FbxVector4 pVertexArray, FbxTime pTime) {
    bool ret = examplePINVOKE.FbxDeformationsEvaluator_ComputeShapeDeformation(swigCPtr, FbxVector4.getCPtr(pVertexArray), FbxTime.getCPtr(pTime));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkinDeformation(FbxVector4 pVertexArray, FbxTime pTime, FbxAMatrix pGX, FbxPose pPose) {
    bool ret = examplePINVOKE.FbxDeformationsEvaluator_ComputeSkinDeformation__SWIG_0(swigCPtr, FbxVector4.getCPtr(pVertexArray), FbxTime.getCPtr(pTime), FbxAMatrix.getCPtr(pGX), FbxPose.getCPtr(pPose));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkinDeformation(FbxVector4 pVertexArray, FbxTime pTime, FbxAMatrix pGX) {
    bool ret = examplePINVOKE.FbxDeformationsEvaluator_ComputeSkinDeformation__SWIG_1(swigCPtr, FbxVector4.getCPtr(pVertexArray), FbxTime.getCPtr(pTime), FbxAMatrix.getCPtr(pGX));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkinDeformation(FbxVector4 pVertexArray, FbxTime pTime) {
    bool ret = examplePINVOKE.FbxDeformationsEvaluator_ComputeSkinDeformation__SWIG_2(swigCPtr, FbxVector4.getCPtr(pVertexArray), FbxTime.getCPtr(pTime));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDeformationsEvaluator() : this(examplePINVOKE.new_FbxDeformationsEvaluator(), true) {
  }

}

}