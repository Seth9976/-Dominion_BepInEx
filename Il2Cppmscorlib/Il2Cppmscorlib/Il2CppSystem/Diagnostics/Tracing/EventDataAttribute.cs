using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C7 RID: 1223
	public class EventDataAttribute : Attribute
	{
		// Token: 0x060047E2 RID: 18402 RVA: 0x00149E4C File Offset: 0x0014804C
		// Note: this type is marked as 'beforefieldinit'.
		static EventDataAttribute()
		{
			Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventDataAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr);
			EventDataAttribute.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "level");
			EventDataAttribute.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "opcode");
			EventDataAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "<Name>k__BackingField");
			EventDataAttribute.NativeFieldInfoPtr__Keywords_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "<Keywords>k__BackingField");
			EventDataAttribute.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, "<Tags>k__BackingField");
			EventDataAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100673938);
			EventDataAttribute.NativeMethodInfoPtr_get_Level_Internal_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100673939);
			EventDataAttribute.NativeMethodInfoPtr_get_Opcode_Internal_get_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100673940);
			EventDataAttribute.NativeMethodInfoPtr_get_Keywords_Internal_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100673941);
			EventDataAttribute.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDataAttribute>.NativeClassPtr, 100673942);
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x00149F44 File Offset: 0x00148144
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x060047E4 RID: 18404 RVA: 0x00149F7C File Offset: 0x0014817C
		public unsafe EventLevel Level
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Level_Internal_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x00149FB8 File Offset: 0x001481B8
		public unsafe EventOpcode Opcode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Opcode_Internal_get_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x060047E6 RID: 18406 RVA: 0x00149FF4 File Offset: 0x001481F4
		public unsafe EventKeywords Keywords
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Keywords_Internal_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x0014A030 File Offset: 0x00148230
		public unsafe EventTags Tags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDataAttribute.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x0001B322 File Offset: 0x00019522
		public EventDataAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x0014A06C File Offset: 0x0014826C
		// (set) Token: 0x060047EA RID: 18410 RVA: 0x0001B32B File Offset: 0x0001952B
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x0014A094 File Offset: 0x00148294
		// (set) Token: 0x060047EC RID: 18412 RVA: 0x0001B346 File Offset: 0x00019546
		public unsafe EventOpcode opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x0014A0BC File Offset: 0x001482BC
		// (set) Token: 0x060047EE RID: 18414 RVA: 0x0001B361 File Offset: 0x00019561
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x0014A0E4 File Offset: 0x001482E4
		// (set) Token: 0x060047F0 RID: 18416 RVA: 0x0001B380 File Offset: 0x00019580
		public unsafe EventKeywords _Keywords_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Keywords_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Keywords_k__BackingField)) = value;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x0014A10C File Offset: 0x0014830C
		// (set) Token: 0x060047F2 RID: 18418 RVA: 0x0001B39B File Offset: 0x0001959B
		public unsafe EventTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDataAttribute.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x04003A29 RID: 14889
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003A2A RID: 14890
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003A2B RID: 14891
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003A2C RID: 14892
		private static readonly IntPtr NativeFieldInfoPtr__Keywords_k__BackingField;

		// Token: 0x04003A2D RID: 14893
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003A2E RID: 14894
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003A2F RID: 14895
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Internal_get_EventLevel_0;

		// Token: 0x04003A30 RID: 14896
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Internal_get_EventOpcode_0;

		// Token: 0x04003A31 RID: 14897
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Internal_get_EventKeywords_0;

		// Token: 0x04003A32 RID: 14898
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0;
	}
}
