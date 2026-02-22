using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000194 RID: 404
	public sealed class AssemblyDefaultAliasAttribute : Attribute
	{
		// Token: 0x06001B83 RID: 7043 RVA: 0x0009DE30 File Offset: 0x0009C030
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDefaultAliasAttribute()
		{
			Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDefaultAliasAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr);
			AssemblyDefaultAliasAttribute.NativeFieldInfoPtr_m_defaultAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr, "m_defaultAlias");
			AssemblyDefaultAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr, 100667906);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0009DE88 File Offset: 0x0009C088
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDefaultAliasAttribute(string defaultAlias)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultAlias);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDefaultAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000097DF File Offset: 0x000079DF
		public AssemblyDefaultAliasAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0009DED4 File Offset: 0x0009C0D4
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x000097E8 File Offset: 0x000079E8
		public unsafe string m_defaultAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDefaultAliasAttribute.NativeFieldInfoPtr_m_defaultAlias);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDefaultAliasAttribute.NativeFieldInfoPtr_m_defaultAlias), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAlias;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
