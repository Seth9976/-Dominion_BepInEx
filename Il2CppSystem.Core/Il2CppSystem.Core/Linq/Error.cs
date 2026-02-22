using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000006 RID: 6
	public static class Error : Object
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00004204 File Offset: 0x00002404
		// Note: this type is marked as 'beforefieldinit'.
		static Error()
		{
			Il2CppClassPointerStore<Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Error>.NativeClassPtr);
			Error.NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663342);
			Error.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663343);
			Error.NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663344);
			Error.NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663345);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004284 File Offset: 0x00002484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 57910, RefRangeEnd = 57913, XrefRangeStart = 57906, XrefRangeEnd = 57910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentNull(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000042C8 File Offset: 0x000024C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57917, RefRangeEnd = 57918, XrefRangeStart = 57913, XrefRangeEnd = 57917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentOutOfRange(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000430C File Offset: 0x0000250C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57918, XrefRangeEnd = 57924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MoreThanOneMatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004340 File Offset: 0x00002540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57924, XrefRangeEnd = 57930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NoElements()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021E7 File Offset: 0x000003E7
		public Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0;
	}
}
