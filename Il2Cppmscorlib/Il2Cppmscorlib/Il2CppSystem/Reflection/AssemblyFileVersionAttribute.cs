using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000196 RID: 406
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x0009DFC8 File Offset: 0x0009C1C8
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyFileVersionAttribute()
		{
			Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyFileVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr);
			AssemblyFileVersionAttribute.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, "_version");
			AssemblyFileVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, 100667908);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0009E020 File Offset: 0x0009C220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316821, XrefRangeEnd = 316822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyFileVersionAttribute(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFileVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0000982F File Offset: 0x00007A2F
		public AssemblyFileVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0009E06C File Offset: 0x0009C26C
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x00009838 File Offset: 0x00007A38
		public unsafe string _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFileVersionAttribute.NativeFieldInfoPtr__version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFileVersionAttribute.NativeFieldInfoPtr__version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
