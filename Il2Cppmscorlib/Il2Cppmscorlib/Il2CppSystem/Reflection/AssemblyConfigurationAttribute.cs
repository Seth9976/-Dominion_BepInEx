using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000193 RID: 403
	public sealed class AssemblyConfigurationAttribute : Attribute
	{
		// Token: 0x06001B7E RID: 7038 RVA: 0x0009DD64 File Offset: 0x0009BF64
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyConfigurationAttribute()
		{
			Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyConfigurationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr);
			AssemblyConfigurationAttribute.NativeFieldInfoPtr_m_configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr, "m_configuration");
			AssemblyConfigurationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr, 100667905);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0009DDBC File Offset: 0x0009BFBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyConfigurationAttribute(string configuration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(configuration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyConfigurationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000097B7 File Offset: 0x000079B7
		public AssemblyConfigurationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0009DE08 File Offset: 0x0009C008
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x000097C0 File Offset: 0x000079C0
		public unsafe string m_configuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyConfigurationAttribute.NativeFieldInfoPtr_m_configuration);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyConfigurationAttribute.NativeFieldInfoPtr_m_configuration), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr_m_configuration;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
