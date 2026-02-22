using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037D RID: 893
	public sealed class TypeInformation : Object
	{
		// Token: 0x06003928 RID: 14632 RVA: 0x00111280 File Offset: 0x0010F480
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInformation()
		{
			Il2CppClassPointerStore<TypeInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "TypeInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr);
			TypeInformation.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "fullTypeName");
			TypeInformation.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "assemblyString");
			TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "hasTypeForwardedFrom");
			TypeInformation.NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671885);
			TypeInformation.NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671886);
			TypeInformation.NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671887);
			TypeInformation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671888);
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x0011133C File Offset: 0x0010F53C
		public unsafe string FullTypeName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x00111374 File Offset: 0x0010F574
		public unsafe string AssemblyString
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x001113AC File Offset: 0x0010F5AC
		public unsafe bool HasTypeForwardedFrom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x001113E8 File Offset: 0x0010F5E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 52975, RefRangeEnd = 52980, XrefRangeStart = 52975, XrefRangeEnd = 52980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x000150E7 File Offset: 0x000132E7
		public TypeInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x00111454 File Offset: 0x0010F654
		// (set) Token: 0x0600392F RID: 14639 RVA: 0x000150F0 File Offset: 0x000132F0
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x0011147C File Offset: 0x0010F67C
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x0001510F File Offset: 0x0001330F
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x001114A4 File Offset: 0x0010F6A4
		// (set) Token: 0x06003933 RID: 14643 RVA: 0x0001512E File Offset: 0x0001332E
		public unsafe bool hasTypeForwardedFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom)) = value;
			}
		}

		// Token: 0x04003008 RID: 12296
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x04003009 RID: 12297
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x0400300A RID: 12298
		private static readonly IntPtr NativeFieldInfoPtr_hasTypeForwardedFrom;

		// Token: 0x0400300B RID: 12299
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0;

		// Token: 0x0400300C RID: 12300
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0;

		// Token: 0x0400300D RID: 12301
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0;

		// Token: 0x0400300E RID: 12302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0;
	}
}
