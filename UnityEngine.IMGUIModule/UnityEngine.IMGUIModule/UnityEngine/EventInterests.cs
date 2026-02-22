using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[StructLayout(2)]
	public struct EventInterests
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00005DE4 File Offset: 0x00003FE4
		// Note: this type is marked as 'beforefieldinit'.
		static EventInterests()
		{
			Il2CppClassPointerStore<EventInterests>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "EventInterests");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInterests>.NativeClassPtr);
			EventInterests.NativeFieldInfoPtr__wantsMouseMove_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsMouseMove>k__BackingField");
			EventInterests.NativeFieldInfoPtr__wantsMouseEnterLeaveWindow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsMouseEnterLeaveWindow>k__BackingField");
			EventInterests.NativeFieldInfoPtr__wantsLessLayoutEvents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsLessLayoutEvents>k__BackingField");
			EventInterests.NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663344);
			EventInterests.NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663345);
			EventInterests.NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663346);
			EventInterests.NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663347);
			EventInterests.NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663348);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00005EB4 File Offset: 0x000040B4
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002222 File Offset: 0x00000422
		public unsafe bool wantsMouseMove
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._wantsMouseMove_k__BackingField = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00005EE4 File Offset: 0x000040E4
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000222B File Offset: 0x0000042B
		public unsafe bool wantsMouseEnterLeaveWindow
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._wantsMouseEnterLeaveWindow_k__BackingField = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00005F14 File Offset: 0x00004114
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002234 File Offset: 0x00000434
		public unsafe bool wantsLessLayoutEvents
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._wantsLessLayoutEvents_k__BackingField = value;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005F44 File Offset: 0x00004144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84524, RefRangeEnd = 84525, XrefRangeStart = 84524, XrefRangeEnd = 84524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WantsEvent(EventType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005F84 File Offset: 0x00004184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84525, RefRangeEnd = 84526, XrefRangeStart = 84525, XrefRangeEnd = 84525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WantsLayoutPass(EventType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002210 File Offset: 0x00000410
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, ref this));
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__wantsMouseMove_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr__wantsMouseEnterLeaveWindow_k__BackingField;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr__wantsLessLayoutEvents_k__BackingField;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0;

		// Token: 0x0400007A RID: 122
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool _wantsMouseMove_k__BackingField;

		// Token: 0x0400007B RID: 123
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool _wantsMouseEnterLeaveWindow_k__BackingField;

		// Token: 0x0400007C RID: 124
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool _wantsLessLayoutEvents_k__BackingField;
	}
}
