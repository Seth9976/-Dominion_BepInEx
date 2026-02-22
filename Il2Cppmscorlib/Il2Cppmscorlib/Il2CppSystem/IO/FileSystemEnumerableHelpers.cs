using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32;

namespace Il2CppSystem.IO
{
	// Token: 0x02000204 RID: 516
	public static class FileSystemEnumerableHelpers : Object
	{
		// Token: 0x060020FF RID: 8447 RVA: 0x000B682C File Offset: 0x000B4A2C
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerableHelpers()
		{
			Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemEnumerableHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr);
			FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsDir_Internal_Static_Boolean_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr, 100668765);
			FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsFile_Internal_Static_Boolean_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr, 100668766);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000B6884 File Offset: 0x000B4A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320903, RefRangeEnd = 320904, XrefRangeStart = 320897, XrefRangeEnd = 320903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDir(Win32Native.WIN32_FIND_DATA data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsDir_Internal_Static_Boolean_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000B68C8 File Offset: 0x000B4AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320904, RefRangeEnd = 320905, XrefRangeStart = 320904, XrefRangeEnd = 320904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFile(Win32Native.WIN32_FIND_DATA data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsFile_Internal_Static_Boolean_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0000B2EA File Offset: 0x000094EA
		public FileSystemEnumerableHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_IsDir_Internal_Static_Boolean_WIN32_FIND_DATA_0;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_IsFile_Internal_Static_Boolean_WIN32_FIND_DATA_0;
	}
}
