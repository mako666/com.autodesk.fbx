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

public class FbxLight : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxLight(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FbxClassId ClassId {
    set {
      examplePINVOKE.FbxLight_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public virtual FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxLight_GetClassId(swigCPtr), true);
    return ret;
  }

  public static FbxLight Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxLight_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxLight ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLight(cPtr, false);
    return ret;
  }

  public static FbxLight Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxLight_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxLight ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLight(cPtr, false);
    return ret;
  }

  public void SetShadowTexture(FbxTexture pTexture) {
    examplePINVOKE.FbxLight_SetShadowTexture(swigCPtr, FbxTexture.getCPtr(pTexture));
  }

  public FbxTexture GetShadowTexture() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxLight_GetShadowTexture(swigCPtr);
    FbxTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTexture(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxLight__EType_t LightType {
    set {
      examplePINVOKE.FbxLight_LightType_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxLight__EType_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_LightType_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxLight__EType_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxLight__EType_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t CastLight {
    set {
      examplePINVOKE.FbxLight_CastLight_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_CastLight_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t DrawVolumetricLight {
    set {
      examplePINVOKE.FbxLight_DrawVolumetricLight_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_DrawVolumetricLight_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t DrawGroundProjection {
    set {
      examplePINVOKE.FbxLight_DrawGroundProjection_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_DrawGroundProjection_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t DrawFrontFacingVolumetricLight {
    set {
      examplePINVOKE.FbxLight_DrawFrontFacingVolumetricLight_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_DrawFrontFacingVolumetricLight_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Color {
    set {
      examplePINVOKE.FbxLight_Color_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_Color_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t Intensity {
    set {
      examplePINVOKE.FbxLight_Intensity_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_Intensity_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t InnerAngle {
    set {
      examplePINVOKE.FbxLight_InnerAngle_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_InnerAngle_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t OuterAngle {
    set {
      examplePINVOKE.FbxLight_OuterAngle_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_OuterAngle_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t Fog {
    set {
      examplePINVOKE.FbxLight_Fog_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_Fog_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxLight__EDecayType_t DecayType {
    set {
      examplePINVOKE.FbxLight_DecayType_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxLight__EDecayType_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_DecayType_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxLight__EDecayType_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxLight__EDecayType_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t DecayStart {
    set {
      examplePINVOKE.FbxLight_DecayStart_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_DecayStart_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t FileName {
    set {
      examplePINVOKE.FbxLight_FileName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_FileName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t EnableNearAttenuation {
    set {
      examplePINVOKE.FbxLight_EnableNearAttenuation_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_EnableNearAttenuation_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t NearAttenuationStart {
    set {
      examplePINVOKE.FbxLight_NearAttenuationStart_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_NearAttenuationStart_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t NearAttenuationEnd {
    set {
      examplePINVOKE.FbxLight_NearAttenuationEnd_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_NearAttenuationEnd_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t EnableFarAttenuation {
    set {
      examplePINVOKE.FbxLight_EnableFarAttenuation_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_EnableFarAttenuation_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t FarAttenuationStart {
    set {
      examplePINVOKE.FbxLight_FarAttenuationStart_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_FarAttenuationStart_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t FarAttenuationEnd {
    set {
      examplePINVOKE.FbxLight_FarAttenuationEnd_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_FarAttenuationEnd_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t CastShadows {
    set {
      examplePINVOKE.FbxLight_CastShadows_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_CastShadows_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ShadowColor {
    set {
      examplePINVOKE.FbxLight_ShadowColor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_ShadowColor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxLight__EAreaLightShape_t AreaLightShape {
    set {
      examplePINVOKE.FbxLight_AreaLightShape_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxLight__EAreaLightShape_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_AreaLightShape_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxLight__EAreaLightShape_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxLight__EAreaLightShape_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_float_t LeftBarnDoor {
    set {
      examplePINVOKE.FbxLight_LeftBarnDoor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_float_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_LeftBarnDoor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_float_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_float_t RightBarnDoor {
    set {
      examplePINVOKE.FbxLight_RightBarnDoor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_float_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_RightBarnDoor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_float_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_float_t TopBarnDoor {
    set {
      examplePINVOKE.FbxLight_TopBarnDoor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_float_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_TopBarnDoor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_float_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_float_t BottomBarnDoor {
    set {
      examplePINVOKE.FbxLight_BottomBarnDoor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_float_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_BottomBarnDoor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_float_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t EnableBarnDoor {
    set {
      examplePINVOKE.FbxLight_EnableBarnDoor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLight_EnableBarnDoor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public virtual FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)examplePINVOKE.FbxLight_GetAttributeType(swigCPtr);
    return ret;
  }

  public enum EType {
    ePoint,
    eDirectional,
    eSpot,
    eArea,
    eVolume
  }

  public enum EDecayType {
    eNone,
    eLinear,
    eQuadratic,
    eCubic
  }

  public enum EAreaLightShape {
    eRectangle,
    eSphere
  }

}

}