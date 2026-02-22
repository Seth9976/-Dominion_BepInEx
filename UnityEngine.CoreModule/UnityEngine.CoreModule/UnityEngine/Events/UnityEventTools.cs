using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020000F9 RID: 249
	public class UnityEventTools : Object
	{
		// Token: 0x06001539 RID: 5433 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventTools()
		{
			Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr);
			UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr, 100664847);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00050AD8 File Offset: 0x0004ECD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 79919, RefRangeEnd = 79925, XrefRangeStart = 79888, XrefRangeEnd = 79919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TidyAssemblyTypeName(string assemblyTypeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0000C311 File Offset: 0x0000A511
		public UnityEventTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0;
	}
}
