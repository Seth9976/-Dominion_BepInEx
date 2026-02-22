using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FE RID: 510
	public static class FileSystemEnumerableFactory : Object
	{
		// Token: 0x060020AA RID: 8362 RVA: 0x0000B04E File Offset: 0x0000924E
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerableFactory()
		{
			Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemEnumerableFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_CreateFileNameIterator_Internal_Static_IEnumerable_1_String_String_String_String_Boolean_Boolean_SearchOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100668732);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000B5410 File Offset: 0x000B3610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320699, RefRangeEnd = 320700, XrefRangeStart = 320689, XrefRangeEnd = 320699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> CreateFileNameIterator(string path, string originalUserPath, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalUserPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFiles;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDirs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_CreateFileNameIterator_Internal_Static_IEnumerable_1_String_String_String_String_Boolean_Boolean_SearchOption_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0000B087 File Offset: 0x00009287
		public FileSystemEnumerableFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_CreateFileNameIterator_Internal_Static_IEnumerable_1_String_String_String_String_Boolean_Boolean_SearchOption_Boolean_0;
	}
}
