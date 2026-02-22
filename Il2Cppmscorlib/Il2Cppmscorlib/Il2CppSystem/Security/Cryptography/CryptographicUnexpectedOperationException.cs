using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002DC RID: 732
	[Serializable]
	public class CryptographicUnexpectedOperationException : CryptographicException
	{
		// Token: 0x0600305C RID: 12380 RVA: 0x000F1ACC File Offset: 0x000EFCCC
		// Note: this type is marked as 'beforefieldinit'.
		static CryptographicUnexpectedOperationException()
		{
			Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptographicUnexpectedOperationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr);
			CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr, 100670916);
			CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr, 100670917);
			CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr, 100670918);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x000F1B38 File Offset: 0x000EFD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338900, XrefRangeEnd = 338906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicUnexpectedOperationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000F1B74 File Offset: 0x000EFD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338906, XrefRangeEnd = 338909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicUnexpectedOperationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x000F1BC0 File Offset: 0x000EFDC0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x00011152 File Offset: 0x0000F352
		public CryptographicUnexpectedOperationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
