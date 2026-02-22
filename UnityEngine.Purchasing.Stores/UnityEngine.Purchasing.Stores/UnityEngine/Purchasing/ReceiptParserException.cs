using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000077 RID: 119
	public class ReceiptParserException : Exception
	{
		// Token: 0x060004D1 RID: 1233 RVA: 0x00004701 File Offset: 0x00002901
		// Note: this type is marked as 'beforefieldinit'.
		static ReceiptParserException()
		{
			Il2CppClassPointerStore<ReceiptParserException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ReceiptParserException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiptParserException>.NativeClassPtr);
			ReceiptParserException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiptParserException>.NativeClassPtr, 100663875);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00015AA4 File Offset: 0x00013CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156354, XrefRangeEnd = 156358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReceiptParserException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceiptParserException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceiptParserException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000473A File Offset: 0x0000293A
		public ReceiptParserException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
