using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F3 RID: 755
	public class MD5 : HashAlgorithm
	{
		// Token: 0x06003168 RID: 12648 RVA: 0x000F5920 File Offset: 0x000F3B20
		// Note: this type is marked as 'beforefieldinit'.
		static MD5()
		{
			Il2CppClassPointerStore<MD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MD5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5>.NativeClassPtr);
			MD5.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100671046);
			MD5.NativeMethodInfoPtr_Create_Public_Static_MD5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100671047);
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x000F5978 File Offset: 0x000F3B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD5>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x000F59B4 File Offset: 0x000F3BB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 339902, RefRangeEnd = 339906, XrefRangeStart = 339890, XrefRangeEnd = 339902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD5 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5.NativeMethodInfoPtr_Create_Public_Static_MD5_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD5>(intPtr3) : null;
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000117F7 File Offset: 0x0000F9F7
		public MD5(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD5_0;
	}
}
