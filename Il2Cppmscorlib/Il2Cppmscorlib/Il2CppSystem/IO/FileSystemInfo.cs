using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000205 RID: 517
	[Serializable]
	public class FileSystemInfo : MarshalByRefObject
	{
		// Token: 0x06002103 RID: 8451 RVA: 0x000B690C File Offset: 0x000B4B0C
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemInfo()
		{
			Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr);
			FileSystemInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_data");
			FileSystemInfo.NativeFieldInfoPtr__dataInitialised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_dataInitialised");
			FileSystemInfo.NativeFieldInfoPtr_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "FullPath");
			FileSystemInfo.NativeFieldInfoPtr_OriginalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "OriginalPath");
			FileSystemInfo.NativeFieldInfoPtr__displayPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_displayPath");
			FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668767);
			FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668768);
			FileSystemInfo.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668769);
			FileSystemInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668770);
			FileSystemInfo.NativeMethodInfoPtr_get_Exists_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668771);
			FileSystemInfo.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668772);
			FileSystemInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668773);
			FileSystemInfo.NativeMethodInfoPtr_get_DisplayPath_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668774);
			FileSystemInfo.NativeMethodInfoPtr_set_DisplayPath_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668775);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000B6A54 File Offset: 0x000B4C54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 320908, RefRangeEnd = 320911, XrefRangeStart = 320905, XrefRangeEnd = 320908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000B6A90 File Offset: 0x000B4C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320924, RefRangeEnd = 320925, XrefRangeStart = 320911, XrefRangeEnd = 320924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x000B6AF4 File Offset: 0x000B4CF4
		public unsafe virtual string FullName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x000B6B38 File Offset: 0x000B4D38
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x000B6B7C File Offset: 0x000B4D7C
		public unsafe virtual bool Exists
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_Exists_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000B6BC4 File Offset: 0x000B4DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320929, RefRangeEnd = 320930, XrefRangeStart = 320925, XrefRangeEnd = 320929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000B6BF8 File Offset: 0x000B4DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320930, XrefRangeEnd = 320944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000B6C5C File Offset: 0x000B4E5C
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x000B6C94 File Offset: 0x000B4E94
		public unsafe string DisplayPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_get_DisplayPath_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_set_DisplayPath_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0000B2F3 File Offset: 0x000094F3
		public FileSystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x000B6CD8 File Offset: 0x000B4ED8
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x0000B2FC File Offset: 0x000094FC
		public unsafe MonoIOStat _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__data)) = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x000B6D00 File Offset: 0x000B4F00
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x0000B317 File Offset: 0x00009517
		public unsafe int _dataInitialised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__dataInitialised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__dataInitialised)) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x000B6D28 File Offset: 0x000B4F28
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0000B332 File Offset: 0x00009532
		public unsafe string FullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_FullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_FullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x000B6D50 File Offset: 0x000B4F50
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x0000B351 File Offset: 0x00009551
		public unsafe string OriginalPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_OriginalPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_OriginalPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x000B6D78 File Offset: 0x000B4F78
		// (set) Token: 0x06002117 RID: 8471 RVA: 0x0000B370 File Offset: 0x00009570
		public unsafe string _displayPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__displayPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__displayPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeFieldInfoPtr__dataInitialised;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeFieldInfoPtr_FullPath;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeFieldInfoPtr_OriginalPath;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeFieldInfoPtr__displayPath;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_get_Exists_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayPath_Internal_get_String_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayPath_Internal_set_Void_String_0;
	}
}
