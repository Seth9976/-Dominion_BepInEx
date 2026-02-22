using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000104 RID: 260
	public class CLRConfig : Object
	{
		// Token: 0x06001359 RID: 4953 RVA: 0x00006B00 File Offset: 0x00004D00
		// Note: this type is marked as 'beforefieldinit'.
		static CLRConfig()
		{
			Il2CppClassPointerStore<CLRConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CLRConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLRConfig>.NativeClassPtr);
			CLRConfig.NativeMethodInfoPtr_CheckThrowUnobservedTaskExceptions_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLRConfig>.NativeClassPtr, 100666651);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0007B964 File Offset: 0x00079B64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckThrowUnobservedTaskExceptions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CLRConfig.NativeMethodInfoPtr_CheckThrowUnobservedTaskExceptions_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00006B39 File Offset: 0x00004D39
		public CLRConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_CheckThrowUnobservedTaskExceptions_Internal_Static_Boolean_0;
	}
}
