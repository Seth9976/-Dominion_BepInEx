using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x02000032 RID: 50
public class GooglePlayEvents : Singleton<GooglePlayEvents>
{
	// Token: 0x060004B9 RID: 1209 RVA: 0x00026AB4 File Offset: 0x00024CB4
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayEvents()
	{
		Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr);
		GooglePlayEvents.NativeFieldInfoPtr_OnEventsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, "OnEventsLoaded");
		GooglePlayEvents.NativeFieldInfoPtr__Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, "_Events");
		GooglePlayEvents.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, 100663847);
		GooglePlayEvents.NativeMethodInfoPtr_LoadEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, 100663848);
		GooglePlayEvents.NativeMethodInfoPtr_SumbitEvent_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, 100663849);
		GooglePlayEvents.NativeMethodInfoPtr_SumbitEvent_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, 100663850);
		GooglePlayEvents.NativeMethodInfoPtr_get_Events_Public_get_List_1_GP_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, 100663851);
		GooglePlayEvents.NativeMethodInfoPtr_OnGPEventsLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, 100663852);
		GooglePlayEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, 100663853);
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00026B98 File Offset: 0x00024D98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164108, XrefRangeEnd = 164113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00026BCC File Offset: 0x00024DCC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164122, RefRangeEnd = 164123, XrefRangeStart = 164113, XrefRangeEnd = 164122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.NativeMethodInfoPtr_LoadEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00026C00 File Offset: 0x00024E00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164132, RefRangeEnd = 164133, XrefRangeStart = 164123, XrefRangeEnd = 164132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SumbitEvent(string eventId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(eventId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.NativeMethodInfoPtr_SumbitEvent_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00026C44 File Offset: 0x00024E44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164133, XrefRangeEnd = 164142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SumbitEvent(string eventId, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(eventId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.NativeMethodInfoPtr_SumbitEvent_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x060004BE RID: 1214 RVA: 0x00026C94 File Offset: 0x00024E94
	public unsafe List<GP_Event> Events
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.NativeMethodInfoPtr_get_Events_Public_get_List_1_GP_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GP_Event>>(intPtr3) : null;
		}
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00026CD4 File Offset: 0x00024ED4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164142, XrefRangeEnd = 164186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGPEventsLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.NativeMethodInfoPtr_OnGPEventsLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00026D18 File Offset: 0x00024F18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164186, XrefRangeEnd = 164214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayEvents()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00003FC2 File Offset: 0x000021C2
	public GooglePlayEvents(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00026D54 File Offset: 0x00024F54
	// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00003FCB File Offset: 0x000021CB
	public unsafe Action<GooglePlayResult> OnEventsLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayEvents.NativeFieldInfoPtr_OnEventsLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayEvents.NativeFieldInfoPtr_OnEventsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00026D84 File Offset: 0x00024F84
	// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00003FEA File Offset: 0x000021EA
	public unsafe List<GP_Event> _Events
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayEvents.NativeFieldInfoPtr__Events);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GP_Event>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayEvents.NativeFieldInfoPtr__Events), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000387 RID: 903
	private static readonly IntPtr NativeFieldInfoPtr_OnEventsLoaded;

	// Token: 0x04000388 RID: 904
	private static readonly IntPtr NativeFieldInfoPtr__Events;

	// Token: 0x04000389 RID: 905
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400038A RID: 906
	private static readonly IntPtr NativeMethodInfoPtr_LoadEvents_Public_Void_0;

	// Token: 0x0400038B RID: 907
	private static readonly IntPtr NativeMethodInfoPtr_SumbitEvent_Public_Void_String_0;

	// Token: 0x0400038C RID: 908
	private static readonly IntPtr NativeMethodInfoPtr_SumbitEvent_Public_Void_String_Int32_0;

	// Token: 0x0400038D RID: 909
	private static readonly IntPtr NativeMethodInfoPtr_get_Events_Public_get_List_1_GP_Event_0;

	// Token: 0x0400038E RID: 910
	private static readonly IntPtr NativeMethodInfoPtr_OnGPEventsLoaded_Private_Void_String_0;

	// Token: 0x0400038F RID: 911
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200036F RID: 879
	[ObfuscatedName("GooglePlayEvents+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x060034A4 RID: 13476 RVA: 0x000D97F8 File Offset: 0x000D79F8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayEvents.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayEvents>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayEvents.__c>.NativeClassPtr);
			GooglePlayEvents.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayEvents.__c>.NativeClassPtr, "<>9");
			GooglePlayEvents.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayEvents.__c>.NativeClassPtr, "<>9__9_0");
			GooglePlayEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents.__c>.NativeClassPtr, 100669993);
			GooglePlayEvents.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayEvents.__c>.NativeClassPtr, 100669994);
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000D9874 File Offset: 0x000D7A74
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayEvents.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000D98B0 File Offset: 0x000D7AB0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__9_0(GooglePlayResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayEvents.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00014895 File Offset: 0x00012A95
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x000D98F4 File Offset: 0x000D7AF4
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x0001489E File Offset: 0x00012A9E
		public unsafe static GooglePlayEvents.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayEvents.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayEvents.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayEvents.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x000D991C File Offset: 0x000D7B1C
		// (set) Token: 0x060034AB RID: 13483 RVA: 0x000148B0 File Offset: 0x00012AB0
		public unsafe static Action<GooglePlayResult> __9__9_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayEvents.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayEvents.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_GooglePlayResult_0;
	}
}
