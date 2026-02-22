using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018F RID: 399
	public sealed class AssemblyProductAttribute : Attribute
	{
		// Token: 0x06001B6A RID: 7018 RVA: 0x0009DA34 File Offset: 0x0009BC34
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyProductAttribute()
		{
			Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyProductAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr);
			AssemblyProductAttribute.NativeFieldInfoPtr_m_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, "m_product");
			AssemblyProductAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, 100667901);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0009DA8C File Offset: 0x0009BC8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyProductAttribute(string product)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyProductAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00009717 File Offset: 0x00007917
		public AssemblyProductAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x00009720 File Offset: 0x00007920
		public unsafe string m_product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyProductAttribute.NativeFieldInfoPtr_m_product);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyProductAttribute.NativeFieldInfoPtr_m_product), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeFieldInfoPtr_m_product;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
