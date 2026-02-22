using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FB RID: 507
	[Serializable]
	public sealed class FileInfo : FileSystemInfo
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x000B4898 File Offset: 0x000B2A98
		// Note: this type is marked as 'beforefieldinit'.
		static FileInfo()
		{
			Il2CppClassPointerStore<FileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileInfo>.NativeClassPtr);
			FileInfo.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, "_name");
			FileInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668705);
			FileInfo.NativeMethodInfoPtr_Init_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668706);
			FileInfo.NativeMethodInfoPtr_GetDisplayPath_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668707);
			FileInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668708);
			FileInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668709);
			FileInfo.NativeMethodInfoPtr_get_DirectoryName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668710);
			FileInfo.NativeMethodInfoPtr_get_Directory_Public_get_DirectoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668711);
			FileInfo.NativeMethodInfoPtr_get_Exists_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668712);
			FileInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileInfo>.NativeClassPtr, 100668713);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000B4990 File Offset: 0x000B2B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320512, RefRangeEnd = 320513, XrefRangeStart = 320504, XrefRangeEnd = 320512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileInfo(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000B49DC File Offset: 0x000B2BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320513, XrefRangeEnd = 320518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string fileName, bool checkHost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_Init_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000B4A2C File Offset: 0x000B2C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayPath(string originalPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_GetDisplayPath_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x000B4A74 File Offset: 0x000B2C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320518, XrefRangeEnd = 320535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x000B4AD8 File Offset: 0x000B2CD8
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x000B4B10 File Offset: 0x000B2D10
		public unsafe string DirectoryName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320535, XrefRangeEnd = 320539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_get_DirectoryName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x000B4B48 File Offset: 0x000B2D48
		public unsafe DirectoryInfo Directory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 320547, RefRangeEnd = 320548, XrefRangeStart = 320539, XrefRangeEnd = 320547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_get_Directory_Public_get_DirectoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x000B4B88 File Offset: 0x000B2D88
		public unsafe override bool Exists
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320548, XrefRangeEnd = 320554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_get_Exists_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000B4BC4 File Offset: 0x000B2DC4
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x0000AF98 File Offset: 0x00009198
		public FileInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x000B4BFC File Offset: 0x000B2DFC
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x0000AFA1 File Offset: 0x000091A1
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileInfo.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileInfo.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Boolean_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayPath_Private_String_String_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectoryName_Public_get_String_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_get_Directory_Public_get_DirectoryInfo_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_get_Exists_Public_Virtual_get_Boolean_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
