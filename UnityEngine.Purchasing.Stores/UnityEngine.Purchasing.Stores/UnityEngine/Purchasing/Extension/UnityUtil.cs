using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000081 RID: 129
	public class UnityUtil : MonoBehaviour
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x000161E4 File Offset: 0x000143E4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityUtil()
		{
			Il2CppClassPointerStore<UnityUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Extension", "UnityUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr);
			UnityUtil.NativeFieldInfoPtr_s_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, "s_Callbacks");
			UnityUtil.NativeFieldInfoPtr_s_CallbacksPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, "s_CallbacksPending");
			UnityUtil.NativeFieldInfoPtr_s_PcControlledPlatforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, "s_PcControlledPlatforms");
			UnityUtil.NativeFieldInfoPtr_pauseListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, "pauseListeners");
			UnityUtil.NativeMethodInfoPtr_GetAnyComponentsOfType_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663893);
			UnityUtil.NativeMethodInfoPtr_get_currentTime_Public_Virtual_Final_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663894);
			UnityUtil.NativeMethodInfoPtr_get_persistentDataPath_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663895);
			UnityUtil.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663896);
			UnityUtil.NativeMethodInfoPtr_get_unityVersion_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663897);
			UnityUtil.NativeMethodInfoPtr_get_cloudProjectId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663898);
			UnityUtil.NativeMethodInfoPtr_get_userId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663899);
			UnityUtil.NativeMethodInfoPtr_get_gameVersion_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663900);
			UnityUtil.NativeMethodInfoPtr_get_sessionId_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663901);
			UnityUtil.NativeMethodInfoPtr_get_platform_Public_Virtual_Final_New_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663902);
			UnityUtil.NativeMethodInfoPtr_get_isEditor_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663903);
			UnityUtil.NativeMethodInfoPtr_get_deviceModel_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663904);
			UnityUtil.NativeMethodInfoPtr_get_deviceName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663905);
			UnityUtil.NativeMethodInfoPtr_get_deviceType_Public_Virtual_Final_New_get_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663906);
			UnityUtil.NativeMethodInfoPtr_get_operatingSystem_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663907);
			UnityUtil.NativeMethodInfoPtr_get_screenWidth_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663908);
			UnityUtil.NativeMethodInfoPtr_get_screenHeight_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663909);
			UnityUtil.NativeMethodInfoPtr_get_screenDpi_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663910);
			UnityUtil.NativeMethodInfoPtr_get_screenOrientation_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663911);
			UnityUtil.NativeMethodInfoPtr_Uniject_IUtil_InitiateCoroutine_Private_Virtual_Final_New_Object_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663912);
			UnityUtil.NativeMethodInfoPtr_Uniject_IUtil_InitiateCoroutine_Private_Virtual_Final_New_Void_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663913);
			UnityUtil.NativeMethodInfoPtr_RunOnMainThread_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663914);
			UnityUtil.NativeMethodInfoPtr_GetWaitForSeconds_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663915);
			UnityUtil.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663916);
			UnityUtil.NativeMethodInfoPtr_FindInstanceOfType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663917);
			UnityUtil.NativeMethodInfoPtr_LoadResourceInstanceOfType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663918);
			UnityUtil.NativeMethodInfoPtr_PcPlatform_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663919);
			UnityUtil.NativeMethodInfoPtr_DelayedCoroutine_Private_IEnumerator_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663920);
			UnityUtil.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663921);
			UnityUtil.NativeMethodInfoPtr_AddPauseListener_Public_Virtual_Final_New_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663922);
			UnityUtil.NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663923);
			UnityUtil.NativeMethodInfoPtr_IsClassOrSubclass_Public_Virtual_Final_New_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663924);
			UnityUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100663925);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000164F8 File Offset: 0x000146F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156558, XrefRangeEnd = 156592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppArrayBase<T> GetAnyComponentsOfType<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.MethodInfoStoreGeneric_GetAnyComponentsOfType_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00016530 File Offset: 0x00014730
		public unsafe virtual DateTime currentTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156592, XrefRangeEnd = 156596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_currentTime_Public_Virtual_Final_New_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0001656C File Offset: 0x0001476C
		public unsafe virtual string persistentDataPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156596, XrefRangeEnd = 156597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_persistentDataPath_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000165A4 File Offset: 0x000147A4
		public unsafe virtual string deviceUniqueIdentifier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 156598, RefRangeEnd = 156599, XrefRangeStart = 156597, XrefRangeEnd = 156598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000165DC File Offset: 0x000147DC
		public unsafe virtual string unityVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156599, XrefRangeEnd = 156600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_unityVersion_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00016614 File Offset: 0x00014814
		public unsafe virtual string cloudProjectId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156600, XrefRangeEnd = 156601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_cloudProjectId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001664C File Offset: 0x0001484C
		public unsafe virtual string userId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156601, XrefRangeEnd = 156606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_userId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00016684 File Offset: 0x00014884
		public unsafe virtual string gameVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156606, XrefRangeEnd = 156607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_gameVersion_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000166BC File Offset: 0x000148BC
		public unsafe virtual ulong sessionId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156607, XrefRangeEnd = 156613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_sessionId_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x000166F8 File Offset: 0x000148F8
		public unsafe virtual RuntimePlatform platform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156613, XrefRangeEnd = 156614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_platform_Public_Virtual_Final_New_get_RuntimePlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00016734 File Offset: 0x00014934
		public unsafe virtual bool isEditor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156614, XrefRangeEnd = 156615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_isEditor_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00016770 File Offset: 0x00014970
		public unsafe virtual string deviceModel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156615, XrefRangeEnd = 156616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_deviceModel_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000167A8 File Offset: 0x000149A8
		public unsafe virtual string deviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156616, XrefRangeEnd = 156617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_deviceName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x000167E0 File Offset: 0x000149E0
		public unsafe virtual DeviceType deviceType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156617, XrefRangeEnd = 156618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_deviceType_Public_Virtual_Final_New_get_DeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001681C File Offset: 0x00014A1C
		public unsafe virtual string operatingSystem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156618, XrefRangeEnd = 156619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_operatingSystem_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00016854 File Offset: 0x00014A54
		public unsafe virtual int screenWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156619, XrefRangeEnd = 156620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_screenWidth_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00016890 File Offset: 0x00014A90
		public unsafe virtual int screenHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156620, XrefRangeEnd = 156621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_screenHeight_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000168CC File Offset: 0x00014ACC
		public unsafe virtual float screenDpi
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156621, XrefRangeEnd = 156622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_screenDpi_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00016908 File Offset: 0x00014B08
		public unsafe virtual string screenOrientation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156622, XrefRangeEnd = 156627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_get_screenOrientation_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00016940 File Offset: 0x00014B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107617, RefRangeEnd = 107618, XrefRangeStart = 107617, XrefRangeEnd = 107618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Uniject_IUtil_InitiateCoroutine(IEnumerator start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_Uniject_IUtil_InitiateCoroutine_Private_Virtual_Final_New_Object_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00016990 File Offset: 0x00014B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156627, XrefRangeEnd = 156631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Uniject_IUtil_InitiateCoroutine(IEnumerator start, int delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_Uniject_IUtil_InitiateCoroutine_Private_Virtual_Final_New_Void_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000169E0 File Offset: 0x00014BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156631, XrefRangeEnd = 156646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RunOnMainThread(Action runnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_RunOnMainThread_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00016A24 File Offset: 0x00014C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156646, XrefRangeEnd = 156650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetWaitForSeconds(int seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_GetWaitForSeconds_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00016A70 File Offset: 0x00014C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156650, XrefRangeEnd = 156655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00016AA4 File Offset: 0x00014CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156655, XrefRangeEnd = 156664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindInstanceOfType<T>() where T : MonoBehaviour
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.MethodInfoStoreGeneric_FindInstanceOfType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00016AD4 File Offset: 0x00014CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156664, XrefRangeEnd = 156681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T LoadResourceInstanceOfType<T>() where T : MonoBehaviour
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.MethodInfoStoreGeneric_LoadResourceInstanceOfType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00016B04 File Offset: 0x00014D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156681, XrefRangeEnd = 156690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PcPlatform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_PcPlatform_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00016B34 File Offset: 0x00014D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156690, XrefRangeEnd = 156694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_DelayedCoroutine_Private_IEnumerator_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00016B94 File Offset: 0x00014D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156694, XrefRangeEnd = 156727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00016BC8 File Offset: 0x00014DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156727, XrefRangeEnd = 156731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddPauseListener(Action<bool> runnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_AddPauseListener_Public_Virtual_Final_New_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00016C0C File Offset: 0x00014E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156731, XrefRangeEnd = 156748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationPause(bool paused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paused;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00016C4C File Offset: 0x00014E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156748, XrefRangeEnd = 156749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(potentialBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(potentialDescendant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr_IsClassOrSubclass_Public_Virtual_Final_New_Boolean_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00016CAC File Offset: 0x00014EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156749, XrefRangeEnd = 156756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000499E File Offset: 0x00002B9E
		public UnityUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00016CE8 File Offset: 0x00014EE8
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x000049A7 File Offset: 0x00002BA7
		public unsafe static List<Action> s_Callbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityUtil.NativeFieldInfoPtr_s_Callbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityUtil.NativeFieldInfoPtr_s_Callbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00016D10 File Offset: 0x00014F10
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x000049B9 File Offset: 0x00002BB9
		public unsafe static bool s_CallbacksPending
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UnityUtil.NativeFieldInfoPtr_s_CallbacksPending, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityUtil.NativeFieldInfoPtr_s_CallbacksPending, (void*)(&value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00016D2C File Offset: 0x00014F2C
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x000049C7 File Offset: 0x00002BC7
		public unsafe static List<RuntimePlatform> s_PcControlledPlatforms
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityUtil.NativeFieldInfoPtr_s_PcControlledPlatforms, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityUtil.NativeFieldInfoPtr_s_PcControlledPlatforms, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00016D54 File Offset: 0x00014F54
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x000049D9 File Offset: 0x00002BD9
		public unsafe List<Action<bool>> pauseListeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil.NativeFieldInfoPtr_pauseListeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil.NativeFieldInfoPtr_pauseListeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_s_Callbacks;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_s_CallbacksPending;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_s_PcControlledPlatforms;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_pauseListeners;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyComponentsOfType_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTime_Public_Virtual_Final_New_get_DateTime_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_get_unityVersion_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_get_cloudProjectId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_get_userId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_get_gameVersion_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_get_sessionId_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Virtual_Final_New_get_RuntimePlatform_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditor_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceModel_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceType_Public_Virtual_Final_New_get_DeviceType_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystem_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_get_screenWidth_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_get_screenHeight_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_get_screenDpi_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_get_screenOrientation_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_Uniject_IUtil_InitiateCoroutine_Private_Virtual_Final_New_Object_IEnumerator_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_Uniject_IUtil_InitiateCoroutine_Private_Virtual_Final_New_Void_IEnumerator_Int32_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_RunOnMainThread_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_GetWaitForSeconds_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_FindInstanceOfType_Public_Static_T_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceInstanceOfType_Public_Static_T_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_PcPlatform_Public_Static_Boolean_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_DelayedCoroutine_Private_IEnumerator_IEnumerator_Int32_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_AddPauseListener_Public_Virtual_Final_New_Void_Action_1_Boolean_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_IsClassOrSubclass_Public_Virtual_Final_New_Boolean_Type_Type_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C5 RID: 197
		[ObfuscatedName("UnityEngine.Purchasing.Extension.UnityUtil+<DelayedCoroutine>d__48")]
		public sealed class _DelayedCoroutine_d__48 : Object
		{
			// Token: 0x06000725 RID: 1829 RVA: 0x0001CDAC File Offset: 0x0001AFAC
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedCoroutine_d__48()
			{
				Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, "<DelayedCoroutine>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr);
				UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, "<>1__state");
				UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, "<>2__current");
				UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, "delay");
				UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, "<>4__this");
				UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, "coroutine");
				UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, 100663927);
				UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, 100663928);
				UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, 100663929);
				UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, 100663930);
				UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, 100663931);
				UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr, 100663932);
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedCoroutine_d__48(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUtil._DelayedCoroutine_d__48>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000727 RID: 1831 RVA: 0x0001CEFC File Offset: 0x0001B0FC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x0001CF30 File Offset: 0x0001B130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156549, XrefRangeEnd = 156553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001CF6C File Offset: 0x0001B16C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x0001CFAC File Offset: 0x0001B1AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156553, XrefRangeEnd = 156558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x0600072B RID: 1835 RVA: 0x0001CFE0 File Offset: 0x0001B1E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUtil._DelayedCoroutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600072C RID: 1836 RVA: 0x00005996 File Offset: 0x00003B96
			public _DelayedCoroutine_d__48(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x0600072D RID: 1837 RVA: 0x0001D020 File Offset: 0x0001B220
			// (set) Token: 0x0600072E RID: 1838 RVA: 0x0000599F File Offset: 0x00003B9F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001D048 File Offset: 0x0001B248
			// (set) Token: 0x06000730 RID: 1840 RVA: 0x000059BA File Offset: 0x00003BBA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x06000731 RID: 1841 RVA: 0x0001D078 File Offset: 0x0001B278
			// (set) Token: 0x06000732 RID: 1842 RVA: 0x000059D9 File Offset: 0x00003BD9
			public unsafe int delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000733 RID: 1843 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
			// (set) Token: 0x06000734 RID: 1844 RVA: 0x000059F4 File Offset: 0x00003BF4
			public unsafe UnityUtil __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityUtil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000735 RID: 1845 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
			// (set) Token: 0x06000736 RID: 1846 RVA: 0x00005A13 File Offset: 0x00003C13
			public unsafe IEnumerator coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUtil._DelayedCoroutine_d__48.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004A2 RID: 1186
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040004A3 RID: 1187
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040004A4 RID: 1188
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x040004A7 RID: 1191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040004A8 RID: 1192
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040004A9 RID: 1193
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040004AA RID: 1194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040004AB RID: 1195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040004AC RID: 1196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000C6 RID: 198
		private sealed class MethodInfoStoreGeneric_GetAnyComponentsOfType_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x040004AD RID: 1197
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnityUtil.NativeMethodInfoPtr_GetAnyComponentsOfType_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<UnityUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C7 RID: 199
		private sealed class MethodInfoStoreGeneric_FindInstanceOfType_Public_Static_T_0<T>
		{
			// Token: 0x040004AE RID: 1198
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnityUtil.NativeMethodInfoPtr_FindInstanceOfType_Public_Static_T_0, Il2CppClassPointerStore<UnityUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C8 RID: 200
		private sealed class MethodInfoStoreGeneric_LoadResourceInstanceOfType_Public_Static_T_0<T>
		{
			// Token: 0x040004AF RID: 1199
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnityUtil.NativeMethodInfoPtr_LoadResourceInstanceOfType_Public_Static_T_0, Il2CppClassPointerStore<UnityUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
