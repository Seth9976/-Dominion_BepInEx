using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200013F RID: 319
	public class TypeNames : Object
	{
		// Token: 0x060016A7 RID: 5799 RVA: 0x00007FAB File Offset: 0x000061AB
		// Note: this type is marked as 'beforefieldinit'.
		static TypeNames()
		{
			Il2CppClassPointerStore<TypeNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNames>.NativeClassPtr);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00007FD0 File Offset: 0x000061D0
		public TypeNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020005AF RID: 1455
		public class ATypeName : Object
		{
			// Token: 0x06005005 RID: 20485 RVA: 0x00166F4C File Offset: 0x0016514C
			// Note: this type is marked as 'beforefieldinit'.
			static ATypeName()
			{
				Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeNames>.NativeClassPtr, "ATypeName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr);
				TypeNames.ATypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667096);
				TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667097);
				TypeNames.ATypeName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667098);
				TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667099);
				TypeNames.ATypeName.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667100);
			}

			// Token: 0x17001466 RID: 5222
			// (get) Token: 0x06005006 RID: 20486 RVA: 0x00166FDC File Offset: 0x001651DC
			public unsafe virtual string DisplayName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005007 RID: 20487 RVA: 0x00167020 File Offset: 0x00165220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309164, XrefRangeEnd = 309165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Equals(TypeName other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005008 RID: 20488 RVA: 0x00167070 File Offset: 0x00165270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309165, XrefRangeEnd = 309166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005009 RID: 20489 RVA: 0x001670B8 File Offset: 0x001652B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309166, XrefRangeEnd = 309170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600500A RID: 20490 RVA: 0x00167110 File Offset: 0x00165310
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ATypeName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNames.ATypeName.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600500B RID: 20491 RVA: 0x0001E717 File Offset: 0x0001C917
			public ATypeName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004113 RID: 16659
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x04004114 RID: 16660
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0;

			// Token: 0x04004115 RID: 16661
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04004116 RID: 16662
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004117 RID: 16663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}
	}
}
