using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200010C RID: 268
	public class AssemblyLoadEventArgs : EventArgs
	{
		// Token: 0x060013DC RID: 5084 RVA: 0x0007D344 File Offset: 0x0007B544
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoadEventArgs()
		{
			Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AssemblyLoadEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr);
			AssemblyLoadEventArgs.NativeFieldInfoPtr_m_loadedAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, "m_loadedAssembly");
			AssemblyLoadEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, 100666705);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0007D39C File Offset: 0x0007B59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304573, XrefRangeEnd = 304577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyLoadEventArgs(Assembly loadedAssembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedAssembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyLoadEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00006F0E File Offset: 0x0000510E
		public AssemblyLoadEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0007D3E8 File Offset: 0x0007B5E8
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00006F17 File Offset: 0x00005117
		public unsafe Assembly m_loadedAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyLoadEventArgs.NativeFieldInfoPtr_m_loadedAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyLoadEventArgs.NativeFieldInfoPtr_m_loadedAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_m_loadedAssembly;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;
	}
}
