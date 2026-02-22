using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000028 RID: 40
	public static class NoReflectionHelper : Object
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002D85 File Offset: 0x00000F85
		// Note: this type is marked as 'beforefieldinit'.
		static NoReflectionHelper()
		{
			Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "NoReflectionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr);
			NoReflectionHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr, 100663668);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000192E0 File Offset: 0x000174E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34318, RefRangeEnd = 34319, XrefRangeStart = 34311, XrefRangeEnd = 34318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetInternalValidator(Object provider, Object settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoReflectionHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002DBE File Offset: 0x00000FBE
		public NoReflectionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalValidator_Internal_Static_Object_Object_Object_0;
	}
}
