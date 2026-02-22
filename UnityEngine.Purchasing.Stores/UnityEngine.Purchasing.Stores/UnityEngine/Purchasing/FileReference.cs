using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007B RID: 123
	public class FileReference : Object
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x00015B58 File Offset: 0x00013D58
		// Note: this type is marked as 'beforefieldinit'.
		static FileReference()
		{
			Il2CppClassPointerStore<FileReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FileReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileReference>.NativeClassPtr);
			FileReference.NativeFieldInfoPtr_m_FilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileReference>.NativeClassPtr, "m_FilePath");
			FileReference.NativeFieldInfoPtr_m_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileReference>.NativeClassPtr, "m_Logger");
			FileReference.NativeMethodInfoPtr_CreateInstance_Internal_Static_FileReference_String_ILogger_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileReference>.NativeClassPtr, 100663878);
			FileReference.NativeMethodInfoPtr__ctor_Internal_Void_String_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileReference>.NativeClassPtr, 100663879);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00015BD8 File Offset: 0x00013DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156380, RefRangeEnd = 156381, XrefRangeStart = 156358, XrefRangeEnd = 156380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileReference CreateInstance(string filename, ILogger logger, IUtil util)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileReference.NativeMethodInfoPtr_CreateInstance_Internal_Static_FileReference_String_ILogger_IUtil_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileReference>(intPtr3) : null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00015C40 File Offset: 0x00013E40
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileReference(string filePath, ILogger logger)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileReference>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileReference.NativeMethodInfoPtr__ctor_Internal_Void_String_ILogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000047EB File Offset: 0x000029EB
		public FileReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00015CA0 File Offset: 0x00013EA0
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x000047F4 File Offset: 0x000029F4
		public unsafe string m_FilePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileReference.NativeFieldInfoPtr_m_FilePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileReference.NativeFieldInfoPtr_m_FilePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00015CC8 File Offset: 0x00013EC8
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004813 File Offset: 0x00002A13
		public unsafe ILogger m_Logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileReference.NativeFieldInfoPtr_m_Logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileReference.NativeFieldInfoPtr_m_Logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_m_FilePath;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr_m_Logger;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Internal_Static_FileReference_String_ILogger_IUtil_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_ILogger_0;
	}
}
