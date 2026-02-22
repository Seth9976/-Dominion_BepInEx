using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000191 RID: 401
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		// Token: 0x06001B74 RID: 7028 RVA: 0x0009DBCC File Offset: 0x0009BDCC
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDescriptionAttribute()
		{
			Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDescriptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr);
			AssemblyDescriptionAttribute.NativeFieldInfoPtr_m_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr, "m_description");
			AssemblyDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr, 100667903);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0009DC24 File Offset: 0x0009BE24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDescriptionAttribute(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00009767 File Offset: 0x00007967
		public AssemblyDescriptionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0009DC70 File Offset: 0x0009BE70
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x00009770 File Offset: 0x00007970
		public unsafe string m_description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDescriptionAttribute.NativeFieldInfoPtr_m_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDescriptionAttribute.NativeFieldInfoPtr_m_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr_m_description;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
