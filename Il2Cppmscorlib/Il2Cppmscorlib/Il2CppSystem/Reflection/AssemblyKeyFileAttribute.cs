using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000197 RID: 407
	public sealed class AssemblyKeyFileAttribute : Attribute
	{
		// Token: 0x06001B92 RID: 7058 RVA: 0x0009E094 File Offset: 0x0009C294
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyKeyFileAttribute()
		{
			Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyKeyFileAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr);
			AssemblyKeyFileAttribute.NativeFieldInfoPtr_m_keyFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr, "m_keyFile");
			AssemblyKeyFileAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr, 100667909);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0009E0EC File Offset: 0x0009C2EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyKeyFileAttribute(string keyFile)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyKeyFileAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00009857 File Offset: 0x00007A57
		public AssemblyKeyFileAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0009E138 File Offset: 0x0009C338
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x00009860 File Offset: 0x00007A60
		public unsafe string m_keyFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyKeyFileAttribute.NativeFieldInfoPtr_m_keyFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyKeyFileAttribute.NativeFieldInfoPtr_m_keyFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeFieldInfoPtr_m_keyFile;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
