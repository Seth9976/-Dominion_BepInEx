using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

namespace SA.Fitness
{
	// Token: 0x0200032B RID: 811
	public sealed class Sensors : Singleton<Sensors>
	{
		// Token: 0x06002FC8 RID: 12232 RVA: 0x000CBE1C File Offset: 0x000CA01C
		// Note: this type is marked as 'beforefieldinit'.
		static Sensors()
		{
			Il2CppClassPointerStore<Sensors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Sensors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sensors>.NativeClassPtr);
			Sensors.NativeFieldInfoPtr_requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensors>.NativeClassPtr, "requests");
			Sensors.NativeFieldInfoPtr_listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensors>.NativeClassPtr, "listeners");
			Sensors.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669624);
			Sensors.NativeMethodInfoPtr_RequestSensors_Public_Void_SensorRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669625);
			Sensors.NativeMethodInfoPtr_RegisterSensorListener_Public_Void_SensorListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669626);
			Sensors.NativeMethodInfoPtr_SensorsRequestResultHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669627);
			Sensors.NativeMethodInfoPtr_SensorListenerRegisterSuccessHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669628);
			Sensors.NativeMethodInfoPtr_SensorListenerRegisterFailHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669629);
			Sensors.NativeMethodInfoPtr_SensorListenerDataPointHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669630);
			Sensors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensors>.NativeClassPtr, 100669631);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x000CBF14 File Offset: 0x000CA114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221059, XrefRangeEnd = 221064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x000CBF48 File Offset: 0x000CA148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221099, RefRangeEnd = 221100, XrefRangeStart = 221064, XrefRangeEnd = 221099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestSensors(SensorRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr_RequestSensors_Public_Void_SensorRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x000CBF8C File Offset: 0x000CA18C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221124, RefRangeEnd = 221125, XrefRangeStart = 221100, XrefRangeEnd = 221124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSensorListener(SensorListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr_RegisterSensorListener_Public_Void_SensorListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x000CBFD0 File Offset: 0x000CA1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221125, XrefRangeEnd = 221144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SensorsRequestResultHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr_SensorsRequestResultHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x000CC014 File Offset: 0x000CA214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221144, XrefRangeEnd = 221154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SensorListenerRegisterSuccessHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr_SensorListenerRegisterSuccessHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x000CC058 File Offset: 0x000CA258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221154, XrefRangeEnd = 221164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SensorListenerRegisterFailHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr_SensorListenerRegisterFailHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x000CC09C File Offset: 0x000CA29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221164, XrefRangeEnd = 221188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SensorListenerDataPointHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr_SensorListenerDataPointHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000CC0E0 File Offset: 0x000CA2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221188, XrefRangeEnd = 221206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sensors()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sensors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000123C6 File Offset: 0x000105C6
		public Sensors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x000CC11C File Offset: 0x000CA31C
		// (set) Token: 0x06002FD3 RID: 12243 RVA: 0x000123CF File Offset: 0x000105CF
		public unsafe Dictionary<int, SensorRequest> requests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensors.NativeFieldInfoPtr_requests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SensorRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensors.NativeFieldInfoPtr_requests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x000CC14C File Offset: 0x000CA34C
		// (set) Token: 0x06002FD5 RID: 12245 RVA: 0x000123EE File Offset: 0x000105EE
		public unsafe Dictionary<int, SensorListener> listeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensors.NativeFieldInfoPtr_listeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SensorListener>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensors.NativeFieldInfoPtr_listeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeFieldInfoPtr_requests;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeFieldInfoPtr_listeners;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeMethodInfoPtr_RequestSensors_Public_Void_SensorRequest_0;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSensorListener_Public_Void_SensorListener_0;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeMethodInfoPtr_SensorsRequestResultHandler_Private_Void_String_0;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeMethodInfoPtr_SensorListenerRegisterSuccessHandler_Private_Void_String_0;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeMethodInfoPtr_SensorListenerRegisterFailHandler_Private_Void_String_0;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeMethodInfoPtr_SensorListenerDataPointHandler_Private_Void_String_0;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
