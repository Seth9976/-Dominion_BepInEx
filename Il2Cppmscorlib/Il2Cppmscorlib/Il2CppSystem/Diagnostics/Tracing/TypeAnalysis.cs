using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050C RID: 1292
	public sealed class TypeAnalysis : Object
	{
		// Token: 0x06004A9C RID: 19100 RVA: 0x00155D14 File Offset: 0x00153F14
		// Note: this type is marked as 'beforefieldinit'.
		static TypeAnalysis()
		{
			Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TypeAnalysis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr);
			TypeAnalysis.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "properties");
			TypeAnalysis.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "name");
			TypeAnalysis.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "keywords");
			TypeAnalysis.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "level");
			TypeAnalysis.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "opcode");
			TypeAnalysis.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, "tags");
			TypeAnalysis.NativeMethodInfoPtr__ctor_Public_Void_Type_EventDataAttribute_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr, 100674351);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00155DD0 File Offset: 0x00153FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372540, RefRangeEnd = 372542, XrefRangeStart = 372464, XrefRangeEnd = 372540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeAnalysis(Type dataType, EventDataAttribute eventAttrib, List<Type> recursionCheck)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeAnalysis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttrib);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeAnalysis.NativeMethodInfoPtr__ctor_Public_Void_Type_EventDataAttribute_List_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x0001BFC7 File Offset: 0x0001A1C7
		public TypeAnalysis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06004A9F RID: 19103 RVA: 0x00155E40 File Offset: 0x00154040
		// (set) Token: 0x06004AA0 RID: 19104 RVA: 0x0001BFD0 File Offset: 0x0001A1D0
		public unsafe Il2CppReferenceArray<PropertyAnalysis> properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyAnalysis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x00155E70 File Offset: 0x00154070
		// (set) Token: 0x06004AA2 RID: 19106 RVA: 0x0001BFEF File Offset: 0x0001A1EF
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x00155E98 File Offset: 0x00154098
		// (set) Token: 0x06004AA4 RID: 19108 RVA: 0x0001C00E File Offset: 0x0001A20E
		public unsafe EventKeywords keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_keywords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_keywords)) = value;
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x00155EC0 File Offset: 0x001540C0
		// (set) Token: 0x06004AA6 RID: 19110 RVA: 0x0001C029 File Offset: 0x0001A229
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x00155EE8 File Offset: 0x001540E8
		// (set) Token: 0x06004AA8 RID: 19112 RVA: 0x0001C044 File Offset: 0x0001A244
		public unsafe EventOpcode opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06004AA9 RID: 19113 RVA: 0x00155F10 File Offset: 0x00154110
		// (set) Token: 0x06004AAA RID: 19114 RVA: 0x0001C05F File Offset: 0x0001A25F
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeAnalysis.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x04003C3E RID: 15422
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x04003C3F RID: 15423
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003C40 RID: 15424
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003C41 RID: 15425
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003C42 RID: 15426
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003C43 RID: 15427
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003C44 RID: 15428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_EventDataAttribute_List_1_Type_0;
	}
}
