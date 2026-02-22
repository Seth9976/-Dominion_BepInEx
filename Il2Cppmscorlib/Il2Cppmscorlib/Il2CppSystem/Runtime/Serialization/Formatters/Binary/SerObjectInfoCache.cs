using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037C RID: 892
	public sealed class SerObjectInfoCache : Object
	{
		// Token: 0x06003918 RID: 14616 RVA: 0x00110FF0 File Offset: 0x0010F1F0
		// Note: this type is marked as 'beforefieldinit'.
		static SerObjectInfoCache()
		{
			Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerObjectInfoCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr);
			SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "fullTypeName");
			SerObjectInfoCache.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "assemblyString");
			SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "hasTypeForwardedFrom");
			SerObjectInfoCache.NativeFieldInfoPtr_memberInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberInfos");
			SerObjectInfoCache.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberNames");
			SerObjectInfoCache.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberTypes");
			SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, 100671883);
			SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, 100671884);
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x001110C0 File Offset: 0x0010F2C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 52975, RefRangeEnd = 52980, XrefRangeStart = 52975, XrefRangeEnd = 52980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x0011112C File Offset: 0x0010F32C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 346458, RefRangeEnd = 346464, XrefRangeStart = 346453, XrefRangeEnd = 346458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoCache(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00015028 File Offset: 0x00013228
		public SerObjectInfoCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x00111178 File Offset: 0x0010F378
		// (set) Token: 0x0600391D RID: 14621 RVA: 0x00015031 File Offset: 0x00013231
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x001111A0 File Offset: 0x0010F3A0
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x00015050 File Offset: 0x00013250
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x001111C8 File Offset: 0x0010F3C8
		// (set) Token: 0x06003921 RID: 14625 RVA: 0x0001506F File Offset: 0x0001326F
		public unsafe bool hasTypeForwardedFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom)) = value;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x001111F0 File Offset: 0x0010F3F0
		// (set) Token: 0x06003923 RID: 14627 RVA: 0x0001508A File Offset: 0x0001328A
		public unsafe Il2CppReferenceArray<MemberInfo> memberInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x00111220 File Offset: 0x0010F420
		// (set) Token: 0x06003925 RID: 14629 RVA: 0x000150A9 File Offset: 0x000132A9
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x00111250 File Offset: 0x0010F450
		// (set) Token: 0x06003927 RID: 14631 RVA: 0x000150C8 File Offset: 0x000132C8
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003000 RID: 12288
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x04003001 RID: 12289
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04003002 RID: 12290
		private static readonly IntPtr NativeFieldInfoPtr_hasTypeForwardedFrom;

		// Token: 0x04003003 RID: 12291
		private static readonly IntPtr NativeFieldInfoPtr_memberInfos;

		// Token: 0x04003004 RID: 12292
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04003005 RID: 12293
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04003006 RID: 12294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0;

		// Token: 0x04003007 RID: 12295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;
	}
}
