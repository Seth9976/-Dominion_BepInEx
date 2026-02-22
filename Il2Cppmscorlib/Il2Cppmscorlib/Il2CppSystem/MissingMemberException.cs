using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000CC RID: 204
	[Serializable]
	public class MissingMemberException : MemberAccessException
	{
		// Token: 0x06000DCD RID: 3533 RVA: 0x00060BFC File Offset: 0x0005EDFC
		// Note: this type is marked as 'beforefieldinit'.
		static MissingMemberException()
		{
			Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MissingMemberException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr);
			MissingMemberException.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, "ClassName");
			MissingMemberException.NativeFieldInfoPtr_MemberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, "MemberName");
			MissingMemberException.NativeFieldInfoPtr_Signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, "Signature");
			MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100665623);
			MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100665624);
			MissingMemberException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100665625);
			MissingMemberException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100665626);
			MissingMemberException.NativeMethodInfoPtr_FormatSignature_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100665627);
			MissingMemberException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100665628);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00060CE0 File Offset: 0x0005EEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288428, XrefRangeEnd = 288433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMemberException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00060D1C File Offset: 0x0005EF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288433, XrefRangeEnd = 288435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMemberException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00060D68 File Offset: 0x0005EF68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288454, RefRangeEnd = 288456, XrefRangeStart = 288435, XrefRangeEnd = 288454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMemberException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00060DCC File Offset: 0x0005EFCC
		public unsafe override string Message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288479, RefRangeEnd = 288480, XrefRangeStart = 288456, XrefRangeEnd = 288479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissingMemberException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00060E10 File Offset: 0x0005F010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSignature(Il2CppStructArray<byte> signature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(signature);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr_FormatSignature_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00060E4C File Offset: 0x0005F04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288480, XrefRangeEnd = 288501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissingMemberException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000058FC File Offset: 0x00003AFC
		public MissingMemberException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00060EB0 File Offset: 0x0005F0B0
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00005905 File Offset: 0x00003B05
		public unsafe string ClassName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_ClassName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_ClassName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00060ED8 File Offset: 0x0005F0D8
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x00005924 File Offset: 0x00003B24
		public unsafe string MemberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_MemberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_MemberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00060F00 File Offset: 0x0005F100
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00005943 File Offset: 0x00003B43
		public unsafe Il2CppStructArray<byte> Signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_Signature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_Signature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_MemberName;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_Signature;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_FormatSignature_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
