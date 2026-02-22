using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000206 RID: 518
	[Serializable]
	public class IOException : SystemException
	{
		// Token: 0x06002118 RID: 8472 RVA: 0x000B6DA0 File Offset: 0x000B4FA0
		// Note: this type is marked as 'beforefieldinit'.
		static IOException()
		{
			Il2CppClassPointerStore<IOException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "IOException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOException>.NativeClassPtr);
			IOException.NativeFieldInfoPtr__maybeFullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOException>.NativeClassPtr, "_maybeFullPath");
			IOException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668776);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668777);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668778);
			IOException.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668779);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668780);
			IOException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100668781);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000B6E5C File Offset: 0x000B505C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320944, XrefRangeEnd = 320949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000B6E98 File Offset: 0x000B5098
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 320951, RefRangeEnd = 320973, XrefRangeStart = 320949, XrefRangeEnd = 320951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000B6EE4 File Offset: 0x000B50E4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 320975, RefRangeEnd = 320988, XrefRangeStart = 320973, XrefRangeEnd = 320975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, int hresult)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000B6F40 File Offset: 0x000B5140
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 320990, RefRangeEnd = 320996, XrefRangeStart = 320988, XrefRangeEnd = 320990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, int hresult, string maybeFullPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(maybeFullPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000B6FAC File Offset: 0x000B51AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320996, XrefRangeEnd = 320998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000B700C File Offset: 0x000B520C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0000B38F File Offset: 0x0000958F
		public IOException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000B7070 File Offset: 0x000B5270
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0000B398 File Offset: 0x00009598
		public unsafe string _maybeFullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOException.NativeFieldInfoPtr__maybeFullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOException.NativeFieldInfoPtr__maybeFullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeFieldInfoPtr__maybeFullPath;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_String_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
