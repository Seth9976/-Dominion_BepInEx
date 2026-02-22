using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000508 RID: 1288
	public class TraceLoggingEventTypes : Object
	{
		// Token: 0x06004A3D RID: 19005 RVA: 0x001546D0 File Offset: 0x001528D0
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingEventTypes()
		{
			Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingEventTypes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr);
			TraceLoggingEventTypes.NativeFieldInfoPtr_typeInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "typeInfos");
			TraceLoggingEventTypes.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "name");
			TraceLoggingEventTypes.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "tags");
			TraceLoggingEventTypes.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "level");
			TraceLoggingEventTypes.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "opcode");
			TraceLoggingEventTypes.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "keywords");
			TraceLoggingEventTypes.NativeFieldInfoPtr_typeMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "typeMetadata");
			TraceLoggingEventTypes.NativeFieldInfoPtr_scratchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "scratchSize");
			TraceLoggingEventTypes.NativeFieldInfoPtr_dataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "dataCount");
			TraceLoggingEventTypes.NativeFieldInfoPtr_pinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "pinCount");
			TraceLoggingEventTypes.NativeFieldInfoPtr_nameInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, "nameInfos");
			TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674303);
			TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674304);
			TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Private_Void_EventTags_String_Il2CppReferenceArray_1_TraceLoggingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674305);
			TraceLoggingEventTypes.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674306);
			TraceLoggingEventTypes.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674307);
			TraceLoggingEventTypes.NativeMethodInfoPtr_GetNameInfo_Internal_NameInfo_String_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674308);
			TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674309);
			TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Static_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr, 100674310);
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x0015487C File Offset: 0x00152A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371949, XrefRangeEnd = 371951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingEventTypes(string name, EventTags tags, [Optional] Il2CppReferenceArray<Type> types)
		{
			if (types == null)
			{
				types = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x001548F4 File Offset: 0x00152AF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371970, RefRangeEnd = 371973, XrefRangeStart = 371951, XrefRangeEnd = 371970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingEventTypes(string name, EventTags tags, Il2CppReferenceArray<ParameterInfo> paramInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00154960 File Offset: 0x00152B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371989, RefRangeEnd = 371990, XrefRangeStart = 371973, XrefRangeEnd = 371989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingEventTypes(EventTags tags, string defaultName, Il2CppReferenceArray<TraceLoggingTypeInfo> typeInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingEventTypes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr__ctor_Private_Void_EventTags_String_Il2CppReferenceArray_1_TraceLoggingTypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x001549CC File Offset: 0x00152BCC
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06004A42 RID: 19010 RVA: 0x00154A04 File Offset: 0x00152C04
		public unsafe EventTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00154A40 File Offset: 0x00152C40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372003, RefRangeEnd = 372006, XrefRangeStart = 371990, XrefRangeEnd = 372003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo GetNameInfo(string name, EventTags tags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_GetNameInfo_Internal_NameInfo_String_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00154AA0 File Offset: 0x00152CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372021, RefRangeEnd = 372022, XrefRangeStart = 372006, XrefRangeEnd = 372021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TraceLoggingTypeInfo> MakeArray(Il2CppReferenceArray<ParameterInfo> paramInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramInfos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TraceLoggingTypeInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00154AF0 File Offset: 0x00152CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372037, RefRangeEnd = 372038, XrefRangeStart = 372022, XrefRangeEnd = 372037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TraceLoggingTypeInfo> MakeArray(Il2CppReferenceArray<Type> types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingEventTypes.NativeMethodInfoPtr_MakeArray_Private_Static_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TraceLoggingTypeInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x0001BD1B File Offset: 0x00019F1B
		public TraceLoggingEventTypes(string name, EventTags tags, params Type[] types)
			: this(name, tags, new Il2CppReferenceArray<Type>(types))
		{
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0001BD2B File Offset: 0x00019F2B
		public TraceLoggingEventTypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06004A48 RID: 19016 RVA: 0x00154B34 File Offset: 0x00152D34
		// (set) Token: 0x06004A49 RID: 19017 RVA: 0x0001BD34 File Offset: 0x00019F34
		public unsafe Il2CppReferenceArray<TraceLoggingTypeInfo> typeInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TraceLoggingTypeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06004A4A RID: 19018 RVA: 0x00154B64 File Offset: 0x00152D64
		// (set) Token: 0x06004A4B RID: 19019 RVA: 0x0001BD53 File Offset: 0x00019F53
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x00154B8C File Offset: 0x00152D8C
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x0001BD72 File Offset: 0x00019F72
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x00154BB4 File Offset: 0x00152DB4
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x0001BD8D File Offset: 0x00019F8D
		public unsafe byte level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x00154BDC File Offset: 0x00152DDC
		// (set) Token: 0x06004A51 RID: 19025 RVA: 0x0001BDA8 File Offset: 0x00019FA8
		public unsafe byte opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x00154C04 File Offset: 0x00152E04
		// (set) Token: 0x06004A53 RID: 19027 RVA: 0x0001BDC3 File Offset: 0x00019FC3
		public unsafe EventKeywords keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_keywords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_keywords)) = value;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x00154C2C File Offset: 0x00152E2C
		// (set) Token: 0x06004A55 RID: 19029 RVA: 0x0001BDDE File Offset: 0x00019FDE
		public unsafe Il2CppStructArray<byte> typeMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_typeMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x00154C5C File Offset: 0x00152E5C
		// (set) Token: 0x06004A57 RID: 19031 RVA: 0x0001BDFD File Offset: 0x00019FFD
		public unsafe int scratchSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_scratchSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_scratchSize)) = value;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06004A58 RID: 19032 RVA: 0x00154C84 File Offset: 0x00152E84
		// (set) Token: 0x06004A59 RID: 19033 RVA: 0x0001BE18 File Offset: 0x0001A018
		public unsafe int dataCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_dataCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_dataCount)) = value;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06004A5A RID: 19034 RVA: 0x00154CAC File Offset: 0x00152EAC
		// (set) Token: 0x06004A5B RID: 19035 RVA: 0x0001BE33 File Offset: 0x0001A033
		public unsafe int pinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_pinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_pinCount)) = value;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06004A5C RID: 19036 RVA: 0x00154CD4 File Offset: 0x00152ED4
		// (set) Token: 0x06004A5D RID: 19037 RVA: 0x0001BE4E File Offset: 0x0001A04E
		public ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo> nameInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_nameInfos);
				return new ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingEventTypes.NativeFieldInfoPtr_nameInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003BFE RID: 15358
		private static readonly IntPtr NativeFieldInfoPtr_typeInfos;

		// Token: 0x04003BFF RID: 15359
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003C00 RID: 15360
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003C01 RID: 15361
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003C02 RID: 15362
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003C03 RID: 15363
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003C04 RID: 15364
		private static readonly IntPtr NativeFieldInfoPtr_typeMetadata;

		// Token: 0x04003C05 RID: 15365
		private static readonly IntPtr NativeFieldInfoPtr_scratchSize;

		// Token: 0x04003C06 RID: 15366
		private static readonly IntPtr NativeFieldInfoPtr_dataCount;

		// Token: 0x04003C07 RID: 15367
		private static readonly IntPtr NativeFieldInfoPtr_pinCount;

		// Token: 0x04003C08 RID: 15368
		private static readonly IntPtr NativeFieldInfoPtr_nameInfos;

		// Token: 0x04003C09 RID: 15369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003C0A RID: 15370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_EventTags_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003C0B RID: 15371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_EventTags_String_Il2CppReferenceArray_1_TraceLoggingTypeInfo_0;

		// Token: 0x04003C0C RID: 15372
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04003C0D RID: 15373
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Internal_get_EventTags_0;

		// Token: 0x04003C0E RID: 15374
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Internal_NameInfo_String_EventTags_0;

		// Token: 0x04003C0F RID: 15375
		private static readonly IntPtr NativeMethodInfoPtr_MakeArray_Private_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003C10 RID: 15376
		private static readonly IntPtr NativeMethodInfoPtr_MakeArray_Private_Static_Il2CppReferenceArray_1_TraceLoggingTypeInfo_Il2CppReferenceArray_1_Type_0;
	}
}
