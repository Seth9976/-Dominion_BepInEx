using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Security
{
	// Token: 0x02000002 RID: 2
	public class AppleReceiptParser : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000205C File Offset: 0x0000025C
		// Note: this type is marked as 'beforefieldinit'.
		static AppleReceiptParser()
		{
			Il2CppClassPointerStore<AppleReceiptParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.SecurityStub.dll", "UnityEngine.Purchasing.Security", "AppleReceiptParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleReceiptParser>.NativeClassPtr);
			AppleReceiptParser.NativeMethodInfoPtr_Parse_Public_AppleReceipt_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleReceiptParser>.NativeClassPtr, 100663297);
			AppleReceiptParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleReceiptParser>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020B4 File Offset: 0x000002B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131443, RefRangeEnd = 131444, XrefRangeStart = 131438, XrefRangeEnd = 131443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleReceipt Parse(Il2CppStructArray<byte> receiptData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(receiptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleReceiptParser.NativeMethodInfoPtr_Parse_Public_AppleReceipt_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppleReceipt>(intPtr3) : null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002104 File Offset: 0x00000304
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleReceiptParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleReceiptParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleReceiptParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public AppleReceiptParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_AppleReceipt_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
