using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000061 RID: 97
	[Serializable]
	public class XmlException : SystemException
	{
		// Token: 0x060007BE RID: 1982 RVA: 0x0002A800 File Offset: 0x00028A00
		// Note: this type is marked as 'beforefieldinit'.
		static XmlException()
		{
			Il2CppClassPointerStore<XmlException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlException>.NativeClassPtr);
			XmlException.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "res");
			XmlException.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "args");
			XmlException.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "lineNumber");
			XmlException.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "linePosition");
			XmlException.NativeFieldInfoPtr_sourceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "sourceUri");
			XmlException.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "message");
			XmlException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664576);
			XmlException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664577);
			XmlException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664578);
			XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664579);
			XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664580);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664581);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664582);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664583);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664584);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664585);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664586);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664587);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664588);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664589);
			XmlException.NativeMethodInfoPtr_FormatUserMessage_Private_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664590);
			XmlException.NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664591);
			XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664592);
			XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664593);
			XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664594);
			XmlException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664595);
			XmlException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664596);
			XmlException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664597);
			XmlException.NativeMethodInfoPtr_get_ResString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100664598);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0002AA74 File Offset: 0x00028C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20633, XrefRangeEnd = 20684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0002AAD8 File Offset: 0x00028CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20684, XrefRangeEnd = 20706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0002AB3C File Offset: 0x00028D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20706, XrefRangeEnd = 20707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0002AB78 File Offset: 0x00028D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20707, XrefRangeEnd = 20708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0002ABC4 File Offset: 0x00028DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20708, XrefRangeEnd = 20709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string message, Exception innerException, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0002AC40 File Offset: 0x00028E40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20731, RefRangeEnd = 20735, XrefRangeStart = 20709, XrefRangeEnd = 20731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002ACCC File Offset: 0x00028ECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20737, RefRangeEnd = 20740, XrefRangeStart = 20735, XrefRangeEnd = 20737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0002AD2C File Offset: 0x00028F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20746, RefRangeEnd = 20748, XrefRangeStart = 20740, XrefRangeEnd = 20746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0002AD8C File Offset: 0x00028F8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20754, RefRangeEnd = 20756, XrefRangeStart = 20748, XrefRangeEnd = 20754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0002ADFC File Offset: 0x00028FFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 20761, RefRangeEnd = 20766, XrefRangeStart = 20756, XrefRangeEnd = 20761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0002AE88 File Offset: 0x00029088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20766, XrefRangeEnd = 20767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0002AF04 File Offset: 0x00029104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20768, RefRangeEnd = 20770, XrefRangeStart = 20767, XrefRangeEnd = 20768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0002AF90 File Offset: 0x00029190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20770, XrefRangeEnd = 20771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, Exception innerException, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0002B01C File Offset: 0x0002921C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 20773, RefRangeEnd = 20781, XrefRangeStart = 20771, XrefRangeEnd = 20773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, Exception innerException, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0002B0BC File Offset: 0x000292BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20781, XrefRangeEnd = 20784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUserMessage(string message, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_FormatUserMessage_Private_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0002B114 File Offset: 0x00029314
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 20807, RefRangeEnd = 20813, XrefRangeStart = 20784, XrefRangeEnd = 20807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateMessage(string res, Il2CppStringArray args, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0002B180 File Offset: 0x00029380
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20818, RefRangeEnd = 20822, XrefRangeStart = 20813, XrefRangeEnd = 20818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray BuildCharExceptionArgs(string data, int invCharIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0002B1D4 File Offset: 0x000293D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20829, RefRangeEnd = 20833, XrefRangeStart = 20822, XrefRangeEnd = 20829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray BuildCharExceptionArgs(Il2CppStructArray<char> data, int length, int invCharIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0002B234 File Offset: 0x00029434
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 20871, RefRangeEnd = 20876, XrefRangeStart = 20833, XrefRangeEnd = 20871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray BuildCharExceptionArgs(char invChar, char nextChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0002B284 File Offset: 0x00029484
		public unsafe int LineNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20876, RefRangeEnd = 20877, XrefRangeStart = 20876, XrefRangeEnd = 20876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0002B2C0 File Offset: 0x000294C0
		public unsafe int LinePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20877, RefRangeEnd = 20878, XrefRangeStart = 20877, XrefRangeEnd = 20877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0002B2FC File Offset: 0x000294FC
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20878, XrefRangeEnd = 20879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0002B340 File Offset: 0x00029540
		public unsafe string ResString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_get_ResString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00004726 File Offset: 0x00002926
		public XmlException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0002B378 File Offset: 0x00029578
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x0000472F File Offset: 0x0000292F
		public unsafe string res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_res);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_res), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0002B3A0 File Offset: 0x000295A0
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x0000474E File Offset: 0x0000294E
		public unsafe Il2CppStringArray args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0002B3D0 File Offset: 0x000295D0
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0000476D File Offset: 0x0000296D
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002B3F8 File Offset: 0x000295F8
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00004788 File Offset: 0x00002988
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x0002B420 File Offset: 0x00029620
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x000047A3 File Offset: 0x000029A3
		public unsafe string sourceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_sourceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_sourceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0002B448 File Offset: 0x00029648
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x000047C2 File Offset: 0x000029C2
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_sourceUri;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_Int32_Int32_String_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_String_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_String_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_String_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_FormatUserMessage_Private_Static_String_String_Int32_Int32_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_String_Int32_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Char_Char_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_get_ResString_Internal_get_String_0;
	}
}
