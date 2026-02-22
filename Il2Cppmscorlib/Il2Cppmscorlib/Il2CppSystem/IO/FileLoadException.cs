using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FC RID: 508
	[Serializable]
	public class FileLoadException : IOException
	{
		// Token: 0x0600208C RID: 8332 RVA: 0x000B4C24 File Offset: 0x000B2E24
		// Note: this type is marked as 'beforefieldinit'.
		static FileLoadException()
		{
			Il2CppClassPointerStore<FileLoadException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileLoadException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr);
			FileLoadException.NativeFieldInfoPtr__fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, "_fileName");
			FileLoadException.NativeFieldInfoPtr__fusionLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, "_fusionLog");
			FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668714);
			FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668715);
			FileLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668716);
			FileLoadException.NativeMethodInfoPtr_SetMessageField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668717);
			FileLoadException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668718);
			FileLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668719);
			FileLoadException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668720);
			FileLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668721);
			FileLoadException.NativeMethodInfoPtr_FormatFileLoadExceptionMessage_Internal_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100668722);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000B4D30 File Offset: 0x000B2F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320554, XrefRangeEnd = 320558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileLoadException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000B4D6C File Offset: 0x000B2F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320558, XrefRangeEnd = 320559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileLoadException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x000B4DB8 File Offset: 0x000B2FB8
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320559, XrefRangeEnd = 320560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x000B4DFC File Offset: 0x000B2FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320560, XrefRangeEnd = 320561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessageField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr_SetMessageField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000B4E30 File Offset: 0x000B3030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320561, XrefRangeEnd = 320587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileLoadException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000B4E74 File Offset: 0x000B3074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320587, XrefRangeEnd = 320595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileLoadException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x000B4ED8 File Offset: 0x000B30D8
		public unsafe string FusionLog
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x000B4F10 File Offset: 0x000B3110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320595, XrefRangeEnd = 320613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x000B4F74 File Offset: 0x000B3174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320620, RefRangeEnd = 320622, XrefRangeStart = 320613, XrefRangeEnd = 320620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr_FormatFileLoadExceptionMessage_Internal_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x0000AFC0 File Offset: 0x000091C0
		public FileLoadException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x000B4FC0 File Offset: 0x000B31C0
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x0000AFC9 File Offset: 0x000091C9
		public unsafe string _fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x000B4FE8 File Offset: 0x000B31E8
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0000AFE8 File Offset: 0x000091E8
		public unsafe string _fusionLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__fusionLog);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__fusionLog), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeFieldInfoPtr__fileName;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeFieldInfoPtr__fusionLog;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageField_Private_Void_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_get_FusionLog_Public_get_String_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_FormatFileLoadExceptionMessage_Internal_Static_String_String_Int32_0;
	}
}
