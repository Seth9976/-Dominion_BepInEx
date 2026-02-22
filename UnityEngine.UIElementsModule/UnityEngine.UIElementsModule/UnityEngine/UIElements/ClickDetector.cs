using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000006 RID: 6
	public class ClickDetector : Object
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000CEC0 File Offset: 0x0000B0C0
		// Note: this type is marked as 'beforefieldinit'.
		static ClickDetector()
		{
			Il2CppClassPointerStore<ClickDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ClickDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr);
			ClickDetector.NativeFieldInfoPtr_m_ClickStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, "m_ClickStatus");
			ClickDetector.NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, "<s_DoubleClickTime>k__BackingField");
			ClickDetector.NativeMethodInfoPtr_get_s_DoubleClickTime_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663299);
			ClickDetector.NativeMethodInfoPtr_StartClickTracking_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663300);
			ClickDetector.NativeMethodInfoPtr_SendClickEvent_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663301);
			ClickDetector.NativeMethodInfoPtr_CancelClickTracking_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663302);
			ClickDetector.NativeMethodInfoPtr_ProcessEvent_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663303);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000CF7C File Offset: 0x0000B17C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000222B File Offset: 0x0000042B
		public unsafe static int s_DoubleClickTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90900, XrefRangeEnd = 90904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_get_s_DoubleClickTime_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				ClickDetector._s_DoubleClickTime_k__BackingField = value;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90904, XrefRangeEnd = 90927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartClickTracking(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_StartClickTracking_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90957, RefRangeEnd = 90958, XrefRangeStart = 90927, XrefRangeEnd = 90957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClickEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_SendClickEvent_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000D034 File Offset: 0x0000B234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90958, XrefRangeEnd = 90966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelClickTracking(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_CancelClickTracking_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000D078 File Offset: 0x0000B278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91005, RefRangeEnd = 91006, XrefRangeStart = 90966, XrefRangeEnd = 91005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_ProcessEvent_Public_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021F5 File Offset: 0x000003F5
		public ClickDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000021FE File Offset: 0x000003FE
		public unsafe List<ClickDetector.ButtonClickStatus> m_ClickStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.NativeFieldInfoPtr_m_ClickStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClickDetector.ButtonClickStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.NativeFieldInfoPtr_m_ClickStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000D0EC File Offset: 0x0000B2EC
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000221D File Offset: 0x0000041D
		public unsafe static int _s_DoubleClickTime_k__BackingField
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClickDetector.NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClickDetector.NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_m_ClickStatus;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_s_DoubleClickTime_Internal_Static_get_Int32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_StartClickTracking_Private_Void_EventBase_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_SendClickEvent_Private_Void_EventBase_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_CancelClickTracking_Private_Void_EventBase_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Void_EventBase_0;

		// Token: 0x020001E8 RID: 488
		public class ButtonClickStatus : Object
		{
			// Token: 0x0600132D RID: 4909 RVA: 0x0003AC7C File Offset: 0x00038E7C
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonClickStatus()
			{
				Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, "ButtonClickStatus");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr);
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_Target");
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_PointerDownPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_PointerDownPosition");
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_LastPointerDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_LastPointerDownTime");
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_ClickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_ClickCount");
				ClickDetector.ButtonClickStatus.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, 100663305);
			}

			// Token: 0x0600132E RID: 4910 RVA: 0x0003AD0C File Offset: 0x00038F0C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90898, RefRangeEnd = 90900, XrefRangeStart = 90897, XrefRangeEnd = 90898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.ButtonClickStatus.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600132F RID: 4911 RVA: 0x0000C5BB File Offset: 0x0000A7BB
			public ButtonClickStatus(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06001330 RID: 4912 RVA: 0x0003AD40 File Offset: 0x00038F40
			// (set) Token: 0x06001331 RID: 4913 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
			public unsafe VisualElement m_Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_Target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06001332 RID: 4914 RVA: 0x0003AD70 File Offset: 0x00038F70
			// (set) Token: 0x06001333 RID: 4915 RVA: 0x0000C5E3 File Offset: 0x0000A7E3
			public unsafe Vector3 m_PointerDownPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_PointerDownPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_PointerDownPosition)) = value;
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x06001334 RID: 4916 RVA: 0x0003AD98 File Offset: 0x00038F98
			// (set) Token: 0x06001335 RID: 4917 RVA: 0x0000C5FE File Offset: 0x0000A7FE
			public unsafe long m_LastPointerDownTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_LastPointerDownTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_LastPointerDownTime)) = value;
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x06001336 RID: 4918 RVA: 0x0003ADC0 File Offset: 0x00038FC0
			// (set) Token: 0x06001337 RID: 4919 RVA: 0x0000C619 File Offset: 0x0000A819
			public unsafe int m_ClickCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_ClickCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_ClickCount)) = value;
				}
			}

			// Token: 0x0400084F RID: 2127
			private static readonly IntPtr NativeFieldInfoPtr_m_Target;

			// Token: 0x04000850 RID: 2128
			private static readonly IntPtr NativeFieldInfoPtr_m_PointerDownPosition;

			// Token: 0x04000851 RID: 2129
			private static readonly IntPtr NativeFieldInfoPtr_m_LastPointerDownTime;

			// Token: 0x04000852 RID: 2130
			private static readonly IntPtr NativeFieldInfoPtr_m_ClickCount;

			// Token: 0x04000853 RID: 2131
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
		}
	}
}
