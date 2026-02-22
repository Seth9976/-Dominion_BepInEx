using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000195 RID: 405
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		// Token: 0x06001B88 RID: 7048 RVA: 0x0009DEFC File Offset: 0x0009C0FC
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyInformationalVersionAttribute()
		{
			Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyInformationalVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr);
			AssemblyInformationalVersionAttribute.NativeFieldInfoPtr_m_informationalVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr, "m_informationalVersion");
			AssemblyInformationalVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr, 100667907);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0009DF54 File Offset: 0x0009C154
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyInformationalVersionAttribute(string informationalVersion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(informationalVersion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyInformationalVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00009807 File Offset: 0x00007A07
		public AssemblyInformationalVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0009DFA0 File Offset: 0x0009C1A0
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x00009810 File Offset: 0x00007A10
		public unsafe string m_informationalVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyInformationalVersionAttribute.NativeFieldInfoPtr_m_informationalVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyInformationalVersionAttribute.NativeFieldInfoPtr_m_informationalVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeFieldInfoPtr_m_informationalVersion;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
