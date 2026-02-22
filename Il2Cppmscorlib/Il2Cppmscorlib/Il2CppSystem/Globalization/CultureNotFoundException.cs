using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022B RID: 555
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		// Token: 0x060024B8 RID: 9400 RVA: 0x000C5EC0 File Offset: 0x000C40C0
		// Note: this type is marked as 'beforefieldinit'.
		static CultureNotFoundException()
		{
			Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr);
			CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, "m_invalidCultureName");
			CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, "m_invalidCultureId");
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669354);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669355);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669356);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669357);
			CultureNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669358);
			CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669359);
			CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669360);
			CultureNotFoundException.NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669361);
			CultureNotFoundException.NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669362);
			CultureNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100669363);
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x000C5FE0 File Offset: 0x000C41E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325117, XrefRangeEnd = 325121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x000C601C File Offset: 0x000C421C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325121, XrefRangeEnd = 325122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(string paramName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000C607C File Offset: 0x000C427C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325122, XrefRangeEnd = 325123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(string paramName, string invalidCultureName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(invalidCultureName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000C60EC File Offset: 0x000C42EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325123, XrefRangeEnd = 325144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x000C6150 File Offset: 0x000C4350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325144, XrefRangeEnd = 325163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000C61B4 File Offset: 0x000C43B4
		public unsafe virtual Nullable<int> InvalidCultureId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000C61F8 File Offset: 0x000C43F8
		public unsafe virtual string InvalidCultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x000C623C File Offset: 0x000C443C
		public unsafe static string DefaultMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325163, XrefRangeEnd = 325166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000C6268 File Offset: 0x000C4468
		public unsafe string FormatedInvalidCultureId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325166, XrefRangeEnd = 325171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000C62A0 File Offset: 0x000C44A0
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325171, XrefRangeEnd = 325197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		public CultureNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000C62E4 File Offset: 0x000C44E4
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0000C705 File Offset: 0x0000A905
		public unsafe string m_invalidCultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000C630C File Offset: 0x000C450C
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000C724 File Offset: 0x0000A924
		public Nullable<int> m_invalidCultureId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureId);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr_m_invalidCultureId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeFieldInfoPtr_m_invalidCultureName;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeFieldInfoPtr_m_invalidCultureId;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
