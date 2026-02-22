using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000079 RID: 121
	public class FakeTransactionHistoryExtensions : Object
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00004785 File Offset: 0x00002985
		// Note: this type is marked as 'beforefieldinit'.
		static FakeTransactionHistoryExtensions()
		{
			Il2CppClassPointerStore<FakeTransactionHistoryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeTransactionHistoryExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeTransactionHistoryExtensions>.NativeClassPtr);
			FakeTransactionHistoryExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTransactionHistoryExtensions>.NativeClassPtr, 100663877);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00015B1C File Offset: 0x00013D1C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeTransactionHistoryExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeTransactionHistoryExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeTransactionHistoryExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000047BE File Offset: 0x000029BE
		public FakeTransactionHistoryExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
