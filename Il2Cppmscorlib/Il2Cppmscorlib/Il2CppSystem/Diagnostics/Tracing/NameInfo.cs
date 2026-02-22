using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D0 RID: 1232
	public sealed class NameInfo : ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo>
	{
		// Token: 0x06004839 RID: 18489 RVA: 0x0014B1B4 File Offset: 0x001493B4
		// Note: this type is marked as 'beforefieldinit'.
		static NameInfo()
		{
			Il2CppClassPointerStore<NameInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "NameInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameInfo>.NativeClassPtr);
			NameInfo.NativeFieldInfoPtr_lastIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "lastIdentity");
			NameInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "name");
			NameInfo.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "tags");
			NameInfo.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "identity");
			NameInfo.NativeFieldInfoPtr_nameMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "nameMetadata");
			NameInfo.NativeMethodInfoPtr_ReserveEventIDsBelow_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100673979);
			NameInfo.NativeMethodInfoPtr__ctor_Public_Void_String_EventTags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100673980);
			NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100673981);
			NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_String_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100673982);
			NameInfo.NativeMethodInfoPtr_Compare_Private_Int32_String_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100673983);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x0014B2AC File Offset: 0x001494AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366274, XrefRangeEnd = 366284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReserveEventIDsBelow(int eventId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_ReserveEventIDsBelow_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x0014B2E0 File Offset: 0x001494E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366298, RefRangeEnd = 366299, XrefRangeStart = 366284, XrefRangeEnd = 366298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo(string name, EventTags tags, int typeMetadataSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeMetadataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr__ctor_Public_Void_String_EventTags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x0014B348 File Offset: 0x00149548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366299, XrefRangeEnd = 366301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(NameInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x0014B398 File Offset: 0x00149598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366301, XrefRangeEnd = 366304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(KeyValuePair<string, EventTags> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_String_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x0014B3EC File Offset: 0x001495EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366312, RefRangeEnd = 366314, XrefRangeStart = 366304, XrefRangeEnd = 366312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string otherName, EventTags otherTags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(otherName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref otherTags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Compare_Private_Int32_String_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x0001B5B0 File Offset: 0x000197B0
		public NameInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x0014B448 File Offset: 0x00149648
		// (set) Token: 0x06004841 RID: 18497 RVA: 0x0001B5B9 File Offset: 0x000197B9
		public unsafe static int lastIdentity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NameInfo.NativeFieldInfoPtr_lastIdentity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameInfo.NativeFieldInfoPtr_lastIdentity, (void*)(&value));
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x0014B464 File Offset: 0x00149664
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x0001B5C7 File Offset: 0x000197C7
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x0014B48C File Offset: 0x0014968C
		// (set) Token: 0x06004845 RID: 18501 RVA: 0x0001B5E6 File Offset: 0x000197E6
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x0014B4B4 File Offset: 0x001496B4
		// (set) Token: 0x06004847 RID: 18503 RVA: 0x0001B601 File Offset: 0x00019801
		public unsafe int identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_identity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_identity)) = value;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06004848 RID: 18504 RVA: 0x0014B4DC File Offset: 0x001496DC
		// (set) Token: 0x06004849 RID: 18505 RVA: 0x0001B61C File Offset: 0x0001981C
		public unsafe Il2CppStructArray<byte> nameMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_nameMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_nameMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A75 RID: 14965
		private static readonly IntPtr NativeFieldInfoPtr_lastIdentity;

		// Token: 0x04003A76 RID: 14966
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003A77 RID: 14967
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003A78 RID: 14968
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04003A79 RID: 14969
		private static readonly IntPtr NativeFieldInfoPtr_nameMetadata;

		// Token: 0x04003A7A RID: 14970
		private static readonly IntPtr NativeMethodInfoPtr_ReserveEventIDsBelow_Internal_Static_Void_Int32_0;

		// Token: 0x04003A7B RID: 14971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EventTags_Int32_0;

		// Token: 0x04003A7C RID: 14972
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_NameInfo_0;

		// Token: 0x04003A7D RID: 14973
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_String_EventTags_0;

		// Token: 0x04003A7E RID: 14974
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Int32_String_EventTags_0;
	}
}
