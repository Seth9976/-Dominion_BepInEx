using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018E RID: 398
	public sealed class AssemblyTrademarkAttribute : Attribute
	{
		// Token: 0x06001B65 RID: 7013 RVA: 0x0009D968 File Offset: 0x0009BB68
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyTrademarkAttribute()
		{
			Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyTrademarkAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr);
			AssemblyTrademarkAttribute.NativeFieldInfoPtr_m_trademark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr, "m_trademark");
			AssemblyTrademarkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr, 100667900);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0009D9C0 File Offset: 0x0009BBC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyTrademarkAttribute(string trademark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(trademark);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyTrademarkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000096EF File Offset: 0x000078EF
		public AssemblyTrademarkAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0009DA0C File Offset: 0x0009BC0C
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x000096F8 File Offset: 0x000078F8
		public unsafe string m_trademark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTrademarkAttribute.NativeFieldInfoPtr_m_trademark);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTrademarkAttribute.NativeFieldInfoPtr_m_trademark), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeFieldInfoPtr_m_trademark;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
