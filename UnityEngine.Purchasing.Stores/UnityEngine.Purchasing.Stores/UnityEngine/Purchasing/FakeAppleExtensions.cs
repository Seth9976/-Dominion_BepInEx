using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004B RID: 75
	public class FakeAppleExtensions : Object
	{
		// Token: 0x06000278 RID: 632 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		// Note: this type is marked as 'beforefieldinit'.
		static FakeAppleExtensions()
		{
			Il2CppClassPointerStore<FakeAppleExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeAppleExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeAppleExtensions>.NativeClassPtr);
			FakeAppleExtensions.NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeAppleExtensions>.NativeClassPtr, 100663620);
			FakeAppleExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeAppleExtensions>.NativeClassPtr, 100663621);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000E204 File Offset: 0x0000C404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153439, XrefRangeEnd = 153443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RestoreTransactions(Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeAppleExtensions.NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000E248 File Offset: 0x0000C448
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeAppleExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeAppleExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeAppleExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000032EB File Offset: 0x000014EB
		public FakeAppleExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_Action_1_Boolean_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
