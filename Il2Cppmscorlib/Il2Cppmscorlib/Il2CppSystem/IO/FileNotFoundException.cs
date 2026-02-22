using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class FileNotFoundException : IOException
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x000B5010 File Offset: 0x000B3210
		// Note: this type is marked as 'beforefieldinit'.
		static FileNotFoundException()
		{
			Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr);
			FileNotFoundException.NativeFieldInfoPtr__fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, "_fileName");
			FileNotFoundException.NativeFieldInfoPtr__fusionLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, "_fusionLog");
			FileNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668723);
			FileNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668724);
			FileNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668725);
			FileNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668726);
			FileNotFoundException.NativeMethodInfoPtr_SetMessageField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668727);
			FileNotFoundException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668728);
			FileNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668729);
			FileNotFoundException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668730);
			FileNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr, 100668731);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000B511C File Offset: 0x000B331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320622, XrefRangeEnd = 320626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000B5158 File Offset: 0x000B3358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320627, RefRangeEnd = 320628, XrefRangeStart = 320626, XrefRangeEnd = 320627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000B51A4 File Offset: 0x000B33A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320629, RefRangeEnd = 320631, XrefRangeStart = 320628, XrefRangeEnd = 320629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileNotFoundException(string message, string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000B5204 File Offset: 0x000B3404
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320631, XrefRangeEnd = 320634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x000B5248 File Offset: 0x000B3448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320634, XrefRangeEnd = 320637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessageField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileNotFoundException.NativeMethodInfoPtr_SetMessageField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x000B527C File Offset: 0x000B347C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320637, XrefRangeEnd = 320663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileNotFoundException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000B52C0 File Offset: 0x000B34C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320663, XrefRangeEnd = 320671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000B5324 File Offset: 0x000B3524
		public unsafe string FusionLog
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileNotFoundException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000B535C File Offset: 0x000B355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320671, XrefRangeEnd = 320689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0000B007 File Offset: 0x00009207
		public FileNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x000B53C0 File Offset: 0x000B35C0
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x0000B010 File Offset: 0x00009210
		public unsafe string _fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileNotFoundException.NativeFieldInfoPtr__fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileNotFoundException.NativeFieldInfoPtr__fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000B53E8 File Offset: 0x000B35E8
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x0000B02F File Offset: 0x0000922F
		public unsafe string _fusionLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileNotFoundException.NativeFieldInfoPtr__fusionLog);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileNotFoundException.NativeFieldInfoPtr__fusionLog), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeFieldInfoPtr__fileName;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeFieldInfoPtr__fusionLog;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageField_Private_Void_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_get_FusionLog_Public_get_String_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
