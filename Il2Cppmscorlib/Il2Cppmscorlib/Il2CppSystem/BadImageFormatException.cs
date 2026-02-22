using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200007F RID: 127
	[Serializable]
	public class BadImageFormatException : SystemException
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x00043A88 File Offset: 0x00041C88
		// Note: this type is marked as 'beforefieldinit'.
		static BadImageFormatException()
		{
			Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "BadImageFormatException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr);
			BadImageFormatException.NativeFieldInfoPtr__fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, "_fileName");
			BadImageFormatException.NativeFieldInfoPtr__fusionLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, "_fusionLog");
			BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664466);
			BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664467);
			BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664468);
			BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664469);
			BadImageFormatException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664470);
			BadImageFormatException.NativeMethodInfoPtr_SetMessageField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664471);
			BadImageFormatException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664472);
			BadImageFormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664473);
			BadImageFormatException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664474);
			BadImageFormatException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr, 100664475);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00043BA8 File Offset: 0x00041DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276450, XrefRangeEnd = 276455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BadImageFormatException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00043BE4 File Offset: 0x00041DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276457, RefRangeEnd = 276458, XrefRangeStart = 276455, XrefRangeEnd = 276457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BadImageFormatException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00043C30 File Offset: 0x00041E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276458, XrefRangeEnd = 276460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BadImageFormatException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00043C90 File Offset: 0x00041E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276460, XrefRangeEnd = 276462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BadImageFormatException(string message, string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadImageFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00043CF0 File Offset: 0x00041EF0
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276462, XrefRangeEnd = 276465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BadImageFormatException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00043D34 File Offset: 0x00041F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276465, XrefRangeEnd = 276468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessageField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadImageFormatException.NativeMethodInfoPtr_SetMessageField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00043D68 File Offset: 0x00041F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276468, XrefRangeEnd = 276494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BadImageFormatException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00043DAC File Offset: 0x00041FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276494, XrefRangeEnd = 276502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BadImageFormatException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BadImageFormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadImageFormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00043E10 File Offset: 0x00042010
		public unsafe string FusionLog
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadImageFormatException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00043E48 File Offset: 0x00042048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276502, XrefRangeEnd = 276520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BadImageFormatException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00004626 File Offset: 0x00002826
		public BadImageFormatException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00043EAC File Offset: 0x000420AC
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x0000462F File Offset: 0x0000282F
		public unsafe string _fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadImageFormatException.NativeFieldInfoPtr__fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadImageFormatException.NativeFieldInfoPtr__fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00043ED4 File Offset: 0x000420D4
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0000464E File Offset: 0x0000284E
		public unsafe string _fusionLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadImageFormatException.NativeFieldInfoPtr__fusionLog);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadImageFormatException.NativeFieldInfoPtr__fusionLog), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr__fileName;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr__fusionLog;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageField_Private_Void_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_get_FusionLog_Public_get_String_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
