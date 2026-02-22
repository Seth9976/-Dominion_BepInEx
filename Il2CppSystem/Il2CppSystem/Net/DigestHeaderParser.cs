using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000102 RID: 258
	public class DigestHeaderParser : Object
	{
		// Token: 0x06000F02 RID: 3842 RVA: 0x00048B5C File Offset: 0x00046D5C
		// Note: this type is marked as 'beforefieldinit'.
		static DigestHeaderParser()
		{
			Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "DigestHeaderParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr);
			DigestHeaderParser.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "header");
			DigestHeaderParser.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "length");
			DigestHeaderParser.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "pos");
			DigestHeaderParser.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "keywords");
			DigestHeaderParser.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "values");
			DigestHeaderParser.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665389);
			DigestHeaderParser.NativeMethodInfoPtr_get_Realm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665390);
			DigestHeaderParser.NativeMethodInfoPtr_get_Opaque_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665391);
			DigestHeaderParser.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665392);
			DigestHeaderParser.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665393);
			DigestHeaderParser.NativeMethodInfoPtr_get_QOP_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665394);
			DigestHeaderParser.NativeMethodInfoPtr_Parse_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665395);
			DigestHeaderParser.NativeMethodInfoPtr_SkipWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665396);
			DigestHeaderParser.NativeMethodInfoPtr_GetKey_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665397);
			DigestHeaderParser.NativeMethodInfoPtr_GetKeywordAndValue_Private_Boolean_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100665398);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00048CB8 File Offset: 0x00046EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49751, XrefRangeEnd = 49760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigestHeaderParser(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00048D04 File Offset: 0x00046F04
		public unsafe string Realm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49760, RefRangeEnd = 49761, XrefRangeStart = 49760, XrefRangeEnd = 49760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Realm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00048D3C File Offset: 0x00046F3C
		public unsafe string Opaque
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49761, RefRangeEnd = 49762, XrefRangeStart = 49761, XrefRangeEnd = 49761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Opaque_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00048D74 File Offset: 0x00046F74
		public unsafe string Nonce
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49762, RefRangeEnd = 49763, XrefRangeStart = 49762, XrefRangeEnd = 49762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00048DAC File Offset: 0x00046FAC
		public unsafe string Algorithm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49763, RefRangeEnd = 49764, XrefRangeStart = 49763, XrefRangeEnd = 49763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00048DE4 File Offset: 0x00046FE4
		public unsafe string QOP
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 49764, RefRangeEnd = 49766, XrefRangeStart = 49764, XrefRangeEnd = 49764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_QOP_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00048E1C File Offset: 0x0004701C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49781, RefRangeEnd = 49782, XrefRangeStart = 49766, XrefRangeEnd = 49781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_Parse_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00048E58 File Offset: 0x00047058
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 49783, RefRangeEnd = 49786, XrefRangeStart = 49782, XrefRangeEnd = 49783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_SkipWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00048E8C File Offset: 0x0004708C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49786, XrefRangeEnd = 49792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_GetKey_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00048EC4 File Offset: 0x000470C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49798, RefRangeEnd = 49799, XrefRangeStart = 49792, XrefRangeEnd = 49798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeywordAndValue(out string key, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_GetKeywordAndValue_Private_Boolean_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			key = IL2CPP.Il2CppStringToManaged(intPtr);
			value = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00007EE9 File Offset: 0x000060E9
		public DigestHeaderParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00048F38 File Offset: 0x00047138
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00007EF2 File Offset: 0x000060F2
		public unsafe string header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_header);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_header), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00048F60 File Offset: 0x00047160
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00007F11 File Offset: 0x00006111
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00048F88 File Offset: 0x00047188
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00007F2C File Offset: 0x0000612C
		public unsafe int pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00048FB0 File Offset: 0x000471B0
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x00007F47 File Offset: 0x00006147
		public unsafe static Il2CppStringArray keywords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DigestHeaderParser.NativeFieldInfoPtr_keywords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigestHeaderParser.NativeFieldInfoPtr_keywords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00048FD8 File Offset: 0x000471D8
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00007F59 File Offset: 0x00006159
		public unsafe Il2CppStringArray values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_get_Realm_Public_get_String_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_get_Opaque_Public_get_String_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_get_QOP_Public_get_String_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespace_Private_Void_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Private_String_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_GetKeywordAndValue_Private_Boolean_byref_String_byref_String_0;
	}
}
