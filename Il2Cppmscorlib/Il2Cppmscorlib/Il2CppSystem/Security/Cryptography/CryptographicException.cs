using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002DB RID: 731
	[Serializable]
	public class CryptographicException : SystemException
	{
		// Token: 0x06003055 RID: 12373 RVA: 0x000F188C File Offset: 0x000EFA8C
		// Note: this type is marked as 'beforefieldinit'.
		static CryptographicException()
		{
			Il2CppClassPointerStore<CryptographicException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptographicException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100670911);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100670912);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100670913);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100670914);
			CryptographicException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100670915);
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x000F1920 File Offset: 0x000EFB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338866, XrefRangeEnd = 338871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x000F195C File Offset: 0x000EFB5C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 338873, RefRangeEnd = 338885, XrefRangeStart = 338871, XrefRangeEnd = 338873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x000F19A8 File Offset: 0x000EFBA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 338894, RefRangeEnd = 338898, XrefRangeStart = 338885, XrefRangeEnd = 338894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(string format, string insert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(insert);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x000F1A08 File Offset: 0x000EFC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338898, XrefRangeEnd = 338900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x000F1A68 File Offset: 0x000EFC68
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x00011149 File Offset: 0x0000F349
		public CryptographicException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029A4 RID: 10660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
