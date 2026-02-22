using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A2 RID: 930
	public class TypeEntry : Object
	{
		// Token: 0x06003CA3 RID: 15523 RVA: 0x0011D54C File Offset: 0x0011B74C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeEntry()
		{
			Il2CppClassPointerStore<TypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "TypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr);
			TypeEntry.NativeFieldInfoPtr_assembly_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, "assembly_name");
			TypeEntry.NativeFieldInfoPtr_type_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, "type_name");
			TypeEntry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672242);
			TypeEntry.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672243);
			TypeEntry.NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672244);
			TypeEntry.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672245);
			TypeEntry.NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr, 100672246);
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x0011D608 File Offset: 0x0011B808
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x0011D644 File Offset: 0x0011B844
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x0011D67C File Offset: 0x0011B87C
		public unsafe string AssemblyName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x0011D6C0 File Offset: 0x0011B8C0
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x0011D6F8 File Offset: 0x0011B8F8
		public unsafe string TypeName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeEntry.NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x00016CE2 File Offset: 0x00014EE2
		public TypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06003CAA RID: 15530 RVA: 0x0011D73C File Offset: 0x0011B93C
		// (set) Token: 0x06003CAB RID: 15531 RVA: 0x00016CEB File Offset: 0x00014EEB
		public unsafe string assembly_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_assembly_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_assembly_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x0011D764 File Offset: 0x0011B964
		// (set) Token: 0x06003CAD RID: 15533 RVA: 0x00016D0A File Offset: 0x00014F0A
		public unsafe string type_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_type_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeEntry.NativeFieldInfoPtr_type_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeFieldInfoPtr_assembly_name;

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeFieldInfoPtr_type_name;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_set_AssemblyName_Public_set_Void_String_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeName_Public_set_Void_String_0;
	}
}
