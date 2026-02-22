using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000190 RID: 400
	public sealed class AssemblyCompanyAttribute : Attribute
	{
		// Token: 0x06001B6F RID: 7023 RVA: 0x0009DB00 File Offset: 0x0009BD00
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyCompanyAttribute()
		{
			Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyCompanyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr);
			AssemblyCompanyAttribute.NativeFieldInfoPtr_m_company = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr, "m_company");
			AssemblyCompanyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr, 100667902);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0009DB58 File Offset: 0x0009BD58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyCompanyAttribute(string company)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(company);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyCompanyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0000973F File Offset: 0x0000793F
		public AssemblyCompanyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0009DBA4 File Offset: 0x0009BDA4
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x00009748 File Offset: 0x00007948
		public unsafe string m_company
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCompanyAttribute.NativeFieldInfoPtr_m_company);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCompanyAttribute.NativeFieldInfoPtr_m_company), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeFieldInfoPtr_m_company;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
