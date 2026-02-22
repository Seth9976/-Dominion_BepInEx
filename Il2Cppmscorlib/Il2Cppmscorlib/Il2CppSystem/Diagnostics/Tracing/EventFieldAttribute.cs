using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C9 RID: 1225
	public class EventFieldAttribute : Attribute
	{
		// Token: 0x060047F3 RID: 18419 RVA: 0x0014A134 File Offset: 0x00148334
		// Note: this type is marked as 'beforefieldinit'.
		static EventFieldAttribute()
		{
			Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr);
			EventFieldAttribute.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, "<Tags>k__BackingField");
			EventFieldAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, "<Name>k__BackingField");
			EventFieldAttribute.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, "<Format>k__BackingField");
			EventFieldAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventFieldTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, 100673943);
			EventFieldAttribute.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, 100673944);
			EventFieldAttribute.NativeMethodInfoPtr_get_Format_Public_get_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFieldAttribute>.NativeClassPtr, 100673945);
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x0014A1DC File Offset: 0x001483DC
		public unsafe EventFieldTags Tags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFieldAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventFieldTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x0014A218 File Offset: 0x00148418
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFieldAttribute.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x0014A250 File Offset: 0x00148450
		public unsafe EventFieldFormat Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventFieldAttribute.NativeMethodInfoPtr_get_Format_Public_get_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x0001B3B6 File Offset: 0x000195B6
		public EventFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x060047F8 RID: 18424 RVA: 0x0014A28C File Offset: 0x0014848C
		// (set) Token: 0x060047F9 RID: 18425 RVA: 0x0001B3BF File Offset: 0x000195BF
		public unsafe EventFieldTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x060047FA RID: 18426 RVA: 0x0014A2B4 File Offset: 0x001484B4
		// (set) Token: 0x060047FB RID: 18427 RVA: 0x0001B3DA File Offset: 0x000195DA
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x0014A2DC File Offset: 0x001484DC
		// (set) Token: 0x060047FD RID: 18429 RVA: 0x0001B3F9 File Offset: 0x000195F9
		public unsafe EventFieldFormat _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Format_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventFieldAttribute.NativeFieldInfoPtr__Format_k__BackingField)) = value;
			}
		}

		// Token: 0x04003A35 RID: 14901
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003A36 RID: 14902
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003A37 RID: 14903
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x04003A38 RID: 14904
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_EventFieldTags_0;

		// Token: 0x04003A39 RID: 14905
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04003A3A RID: 14906
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_EventFieldFormat_0;
	}
}
