using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000078 RID: 120
	public class InvalidProductTypeException : ReceiptParserException
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x00004743 File Offset: 0x00002943
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidProductTypeException()
		{
			Il2CppClassPointerStore<InvalidProductTypeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "InvalidProductTypeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidProductTypeException>.NativeClassPtr);
			InvalidProductTypeException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidProductTypeException>.NativeClassPtr, 100663876);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00015AE0 File Offset: 0x00013CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidProductTypeException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidProductTypeException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidProductTypeException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000477C File Offset: 0x0000297C
		public InvalidProductTypeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
