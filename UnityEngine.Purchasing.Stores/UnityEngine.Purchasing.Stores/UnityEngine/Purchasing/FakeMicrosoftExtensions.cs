using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007D RID: 125
	public class FakeMicrosoftExtensions : Object
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x00004874 File Offset: 0x00002A74
		// Note: this type is marked as 'beforefieldinit'.
		static FakeMicrosoftExtensions()
		{
			Il2CppClassPointerStore<FakeMicrosoftExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeMicrosoftExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeMicrosoftExtensions>.NativeClassPtr);
			FakeMicrosoftExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeMicrosoftExtensions>.NativeClassPtr, 100663881);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00015D50 File Offset: 0x00013F50
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeMicrosoftExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeMicrosoftExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeMicrosoftExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000048AD File Offset: 0x00002AAD
		public FakeMicrosoftExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
