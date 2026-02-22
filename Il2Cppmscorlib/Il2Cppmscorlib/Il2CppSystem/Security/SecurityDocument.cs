using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002BB RID: 699
	[Serializable]
	public sealed class SecurityDocument : Object
	{
		// Token: 0x06002EDB RID: 11995 RVA: 0x000EC7F0 File Offset: 0x000EA9F0
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityDocument()
		{
			Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr);
			SecurityDocument.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, "m_data");
			SecurityDocument.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670728);
			SecurityDocument.NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670729);
			SecurityDocument.NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670730);
			SecurityDocument.NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670731);
			SecurityDocument.NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670732);
			SecurityDocument.NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670733);
			SecurityDocument.NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670734);
			SecurityDocument.NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670735);
			SecurityDocument.NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670736);
			SecurityDocument.NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100670737);
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000EC8FC File Offset: 0x000EAAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337294, RefRangeEnd = 337295, XrefRangeStart = 337290, XrefRangeEnd = 337294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityDocument(int numData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000EC944 File Offset: 0x000EAB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337295, XrefRangeEnd = 337299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuaranteeSize(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000EC984 File Offset: 0x000EAB84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 337306, RefRangeEnd = 337309, XrefRangeStart = 337299, XrefRangeEnd = 337306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string str, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x000EC9D4 File Offset: 0x000EABD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337320, RefRangeEnd = 337322, XrefRangeStart = 337309, XrefRangeEnd = 337320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendString(string str, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000ECA24 File Offset: 0x000EAC24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 337322, RefRangeEnd = 337329, XrefRangeStart = 337322, XrefRangeEnd = 337322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EncodedStringSize(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000ECA68 File Offset: 0x000EAC68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 337347, RefRangeEnd = 337351, XrefRangeStart = 337329, XrefRangeEnd = 337347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(ref int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000ECABC File Offset: 0x000EACBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 337355, RefRangeEnd = 337358, XrefRangeStart = 337351, XrefRangeEnd = 337355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToken(byte b, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x000ECB08 File Offset: 0x000EAD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337359, RefRangeEnd = 337360, XrefRangeStart = 337358, XrefRangeEnd = 337359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetRootElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x000ECB48 File Offset: 0x000EAD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337360, XrefRangeEnd = 337361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetElement(int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x000ECBA4 File Offset: 0x000EADA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 337374, RefRangeEnd = 337377, XrefRangeStart = 337361, XrefRangeEnd = 337374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement InternalGetElement(ref int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x000105EA File Offset: 0x0000E7EA
		public SecurityDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x000ECC00 File Offset: 0x000EAE00
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x000105F3 File Offset: 0x0000E7F3
		public unsafe Il2CppStructArray<byte> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityDocument.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityDocument.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0;

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0;
	}
}
