using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000213 RID: 531
	public static class File : Object
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x000BD4B4 File Offset: 0x000BB6B4
		// Note: this type is marked as 'beforefieldinit'.
		static File()
		{
			Il2CppClassPointerStore<File>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "File");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<File>.NativeClassPtr);
			File.NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669087);
			File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669088);
			File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669089);
			File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669090);
			File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669091);
			File.NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669092);
			File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669093);
			File.NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669094);
			File.NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669095);
			File.NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669096);
			File.NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669097);
			File.NativeMethodInfoPtr_ReadAllLines_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669098);
			File.NativeMethodInfoPtr_ReadAllLines_Private_Static_Il2CppStringArray_StreamReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669099);
			File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669100);
			File.NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669101);
			File.NativeMethodInfoPtr_WriteAllLines_Public_Static_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669102);
			File.NativeMethodInfoPtr_WriteAllLines_Private_Static_Void_StreamWriter_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669103);
			File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669104);
			File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669105);
			File.NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_MonoIOStat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669106);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000BD674 File Offset: 0x000BB874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322558, RefRangeEnd = 322560, XrefRangeStart = 322527, XrefRangeEnd = 322558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destFileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overwrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000BD6CC File Offset: 0x000BB8CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322564, RefRangeEnd = 322567, XrefRangeStart = 322560, XrefRangeEnd = 322564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Create(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
			}
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000BD710 File Offset: 0x000BB910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322567, XrefRangeEnd = 322571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Create(string path, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000BD764 File Offset: 0x000BB964
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 322588, RefRangeEnd = 322598, XrefRangeStart = 322571, XrefRangeEnd = 322588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000BD79C File Offset: 0x000BB99C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 322609, RefRangeEnd = 322641, XrefRangeStart = 322598, XrefRangeEnd = 322609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000BD7E0 File Offset: 0x000BB9E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322650, RefRangeEnd = 322652, XrefRangeStart = 322641, XrefRangeEnd = 322650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAttributes GetAttributes(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000BD824 File Offset: 0x000BBA24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322656, RefRangeEnd = 322660, XrefRangeStart = 322652, XrefRangeEnd = 322656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Open(string path, FileMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000BD878 File Offset: 0x000BBA78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322664, RefRangeEnd = 322668, XrefRangeStart = 322660, XrefRangeEnd = 322664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream OpenRead(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
			}
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000BD8BC File Offset: 0x000BBABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322672, RefRangeEnd = 322673, XrefRangeStart = 322668, XrefRangeEnd = 322672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StreamReader OpenText(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr3) : null;
			}
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000BD900 File Offset: 0x000BBB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322677, RefRangeEnd = 322678, XrefRangeStart = 322673, XrefRangeEnd = 322677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream OpenWrite(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
			}
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000BD944 File Offset: 0x000BBB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322691, RefRangeEnd = 322692, XrefRangeStart = 322678, XrefRangeEnd = 322691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ReadAllBytes(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000BD988 File Offset: 0x000BBB88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322714, RefRangeEnd = 322715, XrefRangeStart = 322692, XrefRangeEnd = 322714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ReadAllLines(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllLines_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000BD9CC File Offset: 0x000BBBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322715, XrefRangeEnd = 322730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ReadAllLines(StreamReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllLines_Private_Static_Il2CppStringArray_StreamReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000BDA10 File Offset: 0x000BBC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322738, RefRangeEnd = 322739, XrefRangeStart = 322730, XrefRangeEnd = 322738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadAllText(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000BDA4C File Offset: 0x000BBC4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322747, RefRangeEnd = 322749, XrefRangeStart = 322739, XrefRangeEnd = 322747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllBytes(string path, Il2CppStructArray<byte> bytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000BDA94 File Offset: 0x000BBC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322758, RefRangeEnd = 322759, XrefRangeStart = 322749, XrefRangeEnd = 322758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllLines(string path, Il2CppStringArray contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllLines_Public_Static_Void_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000BDADC File Offset: 0x000BBCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322759, XrefRangeEnd = 322760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllLines(StreamWriter writer, Il2CppStringArray contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllLines_Private_Static_Void_StreamWriter_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000BDB24 File Offset: 0x000BBD24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322765, RefRangeEnd = 322769, XrefRangeStart = 322760, XrefRangeEnd = 322765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllText(string path, string contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000BDB6C File Offset: 0x000BBD6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322777, RefRangeEnd = 322778, XrefRangeStart = 322769, XrefRangeEnd = 322777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllText(string path, string contents, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x000BDBC8 File Offset: 0x000BBDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322778, XrefRangeEnd = 322782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryagain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnErrorOnNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_MonoIOStat_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0000BB98 File Offset: 0x00009D98
		public File(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_Boolean_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FileStream_String_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FileStream_String_Int32_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllLines_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllLines_Private_Static_Il2CppStringArray_StreamReader_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLines_Public_Static_Void_String_Il2CppStringArray_0;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLines_Private_Static_Void_StreamWriter_Il2CppStringArray_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_Encoding_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_MonoIOStat_Boolean_Boolean_0;
	}
}
