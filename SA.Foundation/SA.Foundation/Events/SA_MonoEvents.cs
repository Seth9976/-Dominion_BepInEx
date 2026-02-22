using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Foundation.Patterns;

namespace SA.Foundation.Events
{
	// Token: 0x02000037 RID: 55
	public static class SA_MonoEvents : Object
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0000A448 File Offset: 0x00008648
		// Note: this type is marked as 'beforefieldinit'.
		static SA_MonoEvents()
		{
			Il2CppClassPointerStore<SA_MonoEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_MonoEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_MonoEvents>.NativeClassPtr);
			SA_MonoEvents.NativeMethodInfoPtr_get_OnApplicationQuit_Public_Static_get_SA_iEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents>.NativeClassPtr, 100663555);
			SA_MonoEvents.NativeMethodInfoPtr_get_OnApplicationFocus_Public_Static_get_SA_iEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents>.NativeClassPtr, 100663556);
			SA_MonoEvents.NativeMethodInfoPtr_get_OnApplicationPause_Public_Static_get_SA_iEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents>.NativeClassPtr, 100663557);
			SA_MonoEvents.NativeMethodInfoPtr_get_OnUpdate_Public_Static_get_SA_iEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents>.NativeClassPtr, 100663558);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000A4C8 File Offset: 0x000086C8
		public unsafe static SA_iEvent OnApplicationQuit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100603, XrefRangeEnd = 100609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.NativeMethodInfoPtr_get_OnApplicationQuit_Public_Static_get_SA_iEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000A4FC File Offset: 0x000086FC
		public unsafe static SA_iEvent<bool> OnApplicationFocus
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100609, XrefRangeEnd = 100615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.NativeMethodInfoPtr_get_OnApplicationFocus_Public_Static_get_SA_iEvent_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000A530 File Offset: 0x00008730
		public unsafe static SA_iEvent<bool> OnApplicationPause
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100615, XrefRangeEnd = 100621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.NativeMethodInfoPtr_get_OnApplicationPause_Public_Static_get_SA_iEvent_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A564 File Offset: 0x00008764
		public unsafe static SA_iEvent OnUpdate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100621, XrefRangeEnd = 100627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.NativeMethodInfoPtr_get_OnUpdate_Public_Static_get_SA_iEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002634 File Offset: 0x00000834
		public SA_MonoEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_OnApplicationQuit_Public_Static_get_SA_iEvent_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_OnApplicationFocus_Public_Static_get_SA_iEvent_1_Boolean_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_OnApplicationPause_Public_Static_get_SA_iEvent_1_Boolean_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_OnUpdate_Public_Static_get_SA_iEvent_0;

		// Token: 0x02000051 RID: 81
		public class SA_MonoEventsListner : SA_Singleton<SA_MonoEvents.SA_MonoEventsListner>
		{
			// Token: 0x060003FA RID: 1018 RVA: 0x000137D4 File Offset: 0x000119D4
			// Note: this type is marked as 'beforefieldinit'.
			static SA_MonoEventsListner()
			{
				Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_MonoEvents>.NativeClassPtr, "SA_MonoEventsListner");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr);
				SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, "m_onApplicationQuit");
				SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, "m_onApplicationFocus");
				SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, "m_onApplicationPause");
				SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, "m_onUpdate");
				SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, 100663894);
				SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, 100663895);
				SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, 100663896);
				SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, 100663897);
				SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr, 100663898);
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x000138B4 File Offset: 0x00011AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100565, XrefRangeEnd = 100570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnApplicationQuit()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x000138F0 File Offset: 0x00011AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100570, XrefRangeEnd = 100574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnApplicationFocus(bool focus)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref focus;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x00013930 File Offset: 0x00011B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100574, XrefRangeEnd = 100578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnApplicationPause(bool pause)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref pause;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00013970 File Offset: 0x00011B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100578, XrefRangeEnd = 100580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x000139A4 File Offset: 0x00011BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100580, XrefRangeEnd = 100603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SA_MonoEventsListner()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_MonoEvents.SA_MonoEventsListner>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MonoEvents.SA_MonoEventsListner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x00003179 File Offset: 0x00001379
			public SA_MonoEventsListner(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x000139E0 File Offset: 0x00011BE0
			// (set) Token: 0x06000402 RID: 1026 RVA: 0x00003182 File Offset: 0x00001382
			public unsafe SA_Event m_onApplicationQuit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationQuit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationQuit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00013A10 File Offset: 0x00011C10
			// (set) Token: 0x06000404 RID: 1028 RVA: 0x000031A1 File Offset: 0x000013A1
			public unsafe SA_Event<bool> m_onApplicationFocus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationFocus);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationFocus), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000405 RID: 1029 RVA: 0x00013A40 File Offset: 0x00011C40
			// (set) Token: 0x06000406 RID: 1030 RVA: 0x000031C0 File Offset: 0x000013C0
			public unsafe SA_Event<bool> m_onApplicationPause
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationPause);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onApplicationPause), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x00013A70 File Offset: 0x00011C70
			// (set) Token: 0x06000408 RID: 1032 RVA: 0x000031DF File Offset: 0x000013DF
			public unsafe SA_Event m_onUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_MonoEvents.SA_MonoEventsListner.NativeFieldInfoPtr_m_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400030C RID: 780
			private static readonly IntPtr NativeFieldInfoPtr_m_onApplicationQuit;

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeFieldInfoPtr_m_onApplicationFocus;

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeFieldInfoPtr_m_onApplicationPause;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeFieldInfoPtr_m_onUpdate;

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_Void_0;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

			// Token: 0x04000313 RID: 787
			private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

			// Token: 0x04000314 RID: 788
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
