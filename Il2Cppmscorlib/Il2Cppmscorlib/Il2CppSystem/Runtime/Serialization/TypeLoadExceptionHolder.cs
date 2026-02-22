using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033A RID: 826
	public class TypeLoadExceptionHolder : Object
	{
		// Token: 0x06003560 RID: 13664 RVA: 0x001046A4 File Offset: 0x001028A4
		// Note: this type is marked as 'beforefieldinit'.
		static TypeLoadExceptionHolder()
		{
			Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "TypeLoadExceptionHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr);
			TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, "m_typeName");
			TypeLoadExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, 100671551);
			TypeLoadExceptionHolder.NativeMethodInfoPtr_get_TypeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr, 100671552);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00104710 File Offset: 0x00102910
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadExceptionHolder(string typeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadExceptionHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x0010475C File Offset: 0x0010295C
		public unsafe string TypeName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadExceptionHolder.NativeMethodInfoPtr_get_TypeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00013160 File Offset: 0x00011360
		public TypeLoadExceptionHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x00104794 File Offset: 0x00102994
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x00013169 File Offset: 0x00011369
		public unsafe string m_typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadExceptionHolder.NativeFieldInfoPtr_m_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002D23 RID: 11555
		private static readonly IntPtr NativeFieldInfoPtr_m_typeName;

		// Token: 0x04002D24 RID: 11556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002D25 RID: 11557
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Internal_get_String_0;
	}
}
