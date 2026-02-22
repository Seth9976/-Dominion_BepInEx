using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000518 RID: 1304
	public sealed class EventSourceAttribute : Attribute
	{
		// Token: 0x06004B61 RID: 19297 RVA: 0x00158880 File Offset: 0x00156A80
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceAttribute()
		{
			Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr);
			EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<Name>k__BackingField");
			EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<Guid>k__BackingField");
			EventSourceAttribute.NativeFieldInfoPtr__LocalizationResources_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<LocalizationResources>k__BackingField");
			EventSourceAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674443);
			EventSourceAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674444);
			EventSourceAttribute.NativeMethodInfoPtr_get_Guid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674445);
			EventSourceAttribute.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674446);
			EventSourceAttribute.NativeMethodInfoPtr_get_LocalizationResources_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674447);
			EventSourceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674448);
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x00158964 File Offset: 0x00156B64
		// (set) Token: 0x06004B63 RID: 19299 RVA: 0x0015899C File Offset: 0x00156B9C
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x001589E0 File Offset: 0x00156BE0
		// (set) Token: 0x06004B65 RID: 19301 RVA: 0x00158A18 File Offset: 0x00156C18
		public unsafe string Guid
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_get_Guid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x00158A5C File Offset: 0x00156C5C
		public unsafe string LocalizationResources
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_get_LocalizationResources_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00158A94 File Offset: 0x00156C94
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x0001C588 File Offset: 0x0001A788
		public EventSourceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06004B69 RID: 19305 RVA: 0x00158AD0 File Offset: 0x00156CD0
		// (set) Token: 0x06004B6A RID: 19306 RVA: 0x0001C591 File Offset: 0x0001A791
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06004B6B RID: 19307 RVA: 0x00158AF8 File Offset: 0x00156CF8
		// (set) Token: 0x06004B6C RID: 19308 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		public unsafe string _Guid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x00158B20 File Offset: 0x00156D20
		// (set) Token: 0x06004B6E RID: 19310 RVA: 0x0001C5CF File Offset: 0x0001A7CF
		public unsafe string _LocalizationResources_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__LocalizationResources_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__LocalizationResources_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeFieldInfoPtr__Guid_k__BackingField;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeFieldInfoPtr__LocalizationResources_k__BackingField;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_get_String_0;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalizationResources_Public_get_String_0;

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
