using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F0 RID: 240
	[Serializable]
	public class XmlSchemaException : SystemException
	{
		// Token: 0x06000E96 RID: 3734 RVA: 0x00044C10 File Offset: 0x00042E10
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaException()
		{
			Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr);
			XmlSchemaException.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, "res");
			XmlSchemaException.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, "args");
			XmlSchemaException.NativeFieldInfoPtr_sourceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, "sourceUri");
			XmlSchemaException.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, "lineNumber");
			XmlSchemaException.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, "linePosition");
			XmlSchemaException.NativeFieldInfoPtr_sourceSchemaObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, "sourceSchemaObject");
			XmlSchemaException.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, "message");
			XmlSchemaException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665429);
			XmlSchemaException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665430);
			XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665431);
			XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665432);
			XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665433);
			XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665434);
			XmlSchemaException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665435);
			XmlSchemaException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665436);
			XmlSchemaException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_String_Int32_Int32_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665437);
			XmlSchemaException.NativeMethodInfoPtr_CreateMessage_Internal_Static_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665438);
			XmlSchemaException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr, 100665439);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00044DA8 File Offset: 0x00042FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24639, XrefRangeEnd = 24690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00044E0C File Offset: 0x0004300C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24690, XrefRangeEnd = 24712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00044E70 File Offset: 0x00043070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24712, XrefRangeEnd = 24720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00044EAC File Offset: 0x000430AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24720, XrefRangeEnd = 24721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00044EF8 File Offset: 0x000430F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24721, XrefRangeEnd = 24722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00044F58 File Offset: 0x00043158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24732, RefRangeEnd = 24734, XrefRangeStart = 24722, XrefRangeEnd = 24732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00044FD4 File Offset: 0x000431D4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 24740, RefRangeEnd = 24758, XrefRangeStart = 24734, XrefRangeEnd = 24740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException(string res, string arg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00045034 File Offset: 0x00043234
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 24764, RefRangeEnd = 24768, XrefRangeStart = 24758, XrefRangeEnd = 24764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000450C0 File Offset: 0x000432C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24768, XrefRangeEnd = 24770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaException(string res, Il2CppStringArray args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_String_Int32_Int32_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00045174 File Offset: 0x00043374
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24775, RefRangeEnd = 24781, XrefRangeStart = 24770, XrefRangeEnd = 24775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateMessage(string res, Il2CppStringArray args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaException.NativeMethodInfoPtr_CreateMessage_Internal_Static_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x000451C4 File Offset: 0x000433C4
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24781, XrefRangeEnd = 24782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00006E3C File Offset: 0x0000503C
		public XmlSchemaException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00045208 File Offset: 0x00043408
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00006E45 File Offset: 0x00005045
		public unsafe string res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_res);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_res), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00045230 File Offset: 0x00043430
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00006E64 File Offset: 0x00005064
		public unsafe Il2CppStringArray args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00045260 File Offset: 0x00043460
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00006E83 File Offset: 0x00005083
		public unsafe string sourceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_sourceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_sourceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00045288 File Offset: 0x00043488
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00006EA2 File Offset: 0x000050A2
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000452B0 File Offset: 0x000434B0
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00006EBD File Offset: 0x000050BD
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x000452D8 File Offset: 0x000434D8
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00006ED8 File Offset: 0x000050D8
		public unsafe XmlSchemaObject sourceSchemaObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_sourceSchemaObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_sourceSchemaObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00045308 File Offset: 0x00043508
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00006EF7 File Offset: 0x000050F7
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaException.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_sourceUri;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_sourceSchemaObject;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_Int32_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_String_Int32_Int32_XmlSchemaObject_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessage_Internal_Static_String_String_Il2CppStringArray_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
