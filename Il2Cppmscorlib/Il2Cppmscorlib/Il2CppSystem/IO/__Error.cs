using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F4 RID: 500
	public static class __Error : Object
	{
		// Token: 0x06001FF2 RID: 8178 RVA: 0x000B21C4 File Offset: 0x000B03C4
		// Note: this type is marked as 'beforefieldinit'.
		static __Error()
		{
			Il2CppClassPointerStore<__Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "__Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Error>.NativeClassPtr);
			__Error.NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668612);
			__Error.NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668613);
			__Error.NativeMethodInfoPtr_StreamIsClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668614);
			__Error.NativeMethodInfoPtr_MemoryStreamNotExpandable_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668615);
			__Error.NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668616);
			__Error.NativeMethodInfoPtr_ReadNotSupported_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668617);
			__Error.NativeMethodInfoPtr_WrongAsyncResult_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668618);
			__Error.NativeMethodInfoPtr_EndReadCalledTwice_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668619);
			__Error.NativeMethodInfoPtr_EndWriteCalledTwice_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668620);
			__Error.NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668621);
			__Error.NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668622);
			__Error.NativeMethodInfoPtr_WriteNotSupported_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668623);
			__Error.NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668624);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x000B22F8 File Offset: 0x000B04F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 319758, RefRangeEnd = 319764, XrefRangeStart = 319751, XrefRangeEnd = 319758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndOfFile()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000B2320 File Offset: 0x000B0520
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 319771, RefRangeEnd = 319778, XrefRangeStart = 319764, XrefRangeEnd = 319771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FileNotOpen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000B2348 File Offset: 0x000B0548
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 319785, RefRangeEnd = 319808, XrefRangeStart = 319778, XrefRangeEnd = 319785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StreamIsClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_StreamIsClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000B2370 File Offset: 0x000B0570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319815, RefRangeEnd = 319816, XrefRangeStart = 319808, XrefRangeEnd = 319815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemoryStreamNotExpandable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_MemoryStreamNotExpandable_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000B2398 File Offset: 0x000B0598
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 319823, RefRangeEnd = 319834, XrefRangeStart = 319816, XrefRangeEnd = 319823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReaderClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000B23C0 File Offset: 0x000B05C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 319841, RefRangeEnd = 319845, XrefRangeStart = 319834, XrefRangeEnd = 319841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadNotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_ReadNotSupported_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000B23E8 File Offset: 0x000B05E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319852, RefRangeEnd = 319854, XrefRangeStart = 319845, XrefRangeEnd = 319852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WrongAsyncResult()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WrongAsyncResult_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000B2410 File Offset: 0x000B0610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319861, RefRangeEnd = 319862, XrefRangeStart = 319854, XrefRangeEnd = 319861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndReadCalledTwice()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_EndReadCalledTwice_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000B2438 File Offset: 0x000B0638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319869, RefRangeEnd = 319870, XrefRangeStart = 319862, XrefRangeEnd = 319869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndWriteCalledTwice()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_EndWriteCalledTwice_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000B2460 File Offset: 0x000B0660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319883, RefRangeEnd = 319885, XrefRangeStart = 319870, XrefRangeEnd = 319883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDisplayablePath(string path, bool isInvalidPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInvalidPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000B24AC File Offset: 0x000B06AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320030, RefRangeEnd = 320032, XrefRangeStart = 319885, XrefRangeEnd = 320030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WinIOError(int errorCode, string maybeFullPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(maybeFullPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000B24F0 File Offset: 0x000B06F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320039, RefRangeEnd = 320046, XrefRangeStart = 320032, XrefRangeEnd = 320039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteNotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WriteNotSupported_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000B2518 File Offset: 0x000B0718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320053, RefRangeEnd = 320054, XrefRangeStart = 320046, XrefRangeEnd = 320053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriterClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0000AD50 File Offset: 0x00008F50
		public __Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_StreamIsClosed_Internal_Static_Void_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_MemoryStreamNotExpandable_Internal_Static_Void_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_ReadNotSupported_Internal_Static_Void_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_WrongAsyncResult_Internal_Static_Void_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr_EndReadCalledTwice_Internal_Static_Void_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_EndWriteCalledTwice_Internal_Static_Void_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_WriteNotSupported_Internal_Static_Void_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0;
	}
}
