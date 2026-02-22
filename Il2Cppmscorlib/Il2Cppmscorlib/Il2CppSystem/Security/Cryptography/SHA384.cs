using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000304 RID: 772
	public class SHA384 : HashAlgorithm
	{
		// Token: 0x0600326B RID: 12907 RVA: 0x000F92F0 File Offset: 0x000F74F0
		// Note: this type is marked as 'beforefieldinit'.
		static SHA384()
		{
			Il2CppClassPointerStore<SHA384>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA384");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA384>.NativeClassPtr);
			SHA384.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384>.NativeClassPtr, 100671159);
			SHA384.NativeMethodInfoPtr_Create_Public_Static_SHA384_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384>.NativeClassPtr, 100671160);
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000F9348 File Offset: 0x000F7548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340739, XrefRangeEnd = 340740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA384()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA384>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000F9384 File Offset: 0x000F7584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340754, RefRangeEnd = 340755, XrefRangeStart = 340740, XrefRangeEnd = 340754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA384 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384.NativeMethodInfoPtr_Create_Public_Static_SHA384_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA384>(intPtr3) : null;
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00011EC5 File Offset: 0x000100C5
		public SHA384(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA384_0;
	}
}
