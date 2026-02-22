using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000247 RID: 583
	[Serializable]
	public class SortKey : Object
	{
		// Token: 0x060027BE RID: 10174 RVA: 0x000D1A78 File Offset: 0x000CFC78
		// Note: this type is marked as 'beforefieldinit'.
		static SortKey()
		{
			Il2CppClassPointerStore<SortKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "SortKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortKey>.NativeClassPtr);
			SortKey.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "source");
			SortKey.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "key");
			SortKey.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "options");
			SortKey.NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "lcid");
			SortKey.NativeMethodInfoPtr_Compare_Public_Static_Int32_SortKey_SortKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669742);
			SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669743);
			SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Il2CppStructArray_1_Byte_CompareOptions_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669744);
			SortKey.NativeMethodInfoPtr_get_OriginalString_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669745);
			SortKey.NativeMethodInfoPtr_get_KeyData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669746);
			SortKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669747);
			SortKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669748);
			SortKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669749);
			SortKey.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100669750);
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000D1BAC File Offset: 0x000CFDAC
		[CallerCount(0)]
		public unsafe static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortkey1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortkey2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr_Compare_Public_Static_Int32_SortKey_SortKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000D1C00 File Offset: 0x000CFE00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328187, RefRangeEnd = 328190, XrefRangeStart = 328186, XrefRangeEnd = 328187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey(int lcid, string source, CompareOptions opt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000D1C68 File Offset: 0x000CFE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328190, XrefRangeEnd = 328191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey(int lcid, string source, Il2CppStructArray<byte> buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1Length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv2Length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv3Length;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kanaSmallLength;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref markTypeLength;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref katakanaLength;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kanaWidthLength;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref identLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Il2CppStructArray_1_Byte_CompareOptions_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000D1D58 File Offset: 0x000CFF58
		public unsafe virtual string OriginalString
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_get_OriginalString_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000D1D9C File Offset: 0x000CFF9C
		public unsafe virtual Il2CppStructArray<byte> KeyData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_get_KeyData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000D1DE8 File Offset: 0x000CFFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328191, XrefRangeEnd = 328193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000D1E40 File Offset: 0x000D0040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328193, XrefRangeEnd = 328194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000D1E88 File Offset: 0x000D0088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328194, XrefRangeEnd = 328218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000D1ECC File Offset: 0x000D00CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328218, XrefRangeEnd = 328221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKey>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0000DA1B File Offset: 0x0000BC1B
		public SortKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x000D1F08 File Offset: 0x000D0108
		// (set) Token: 0x060027CA RID: 10186 RVA: 0x0000DA24 File Offset: 0x0000BC24
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x000D1F30 File Offset: 0x000D0130
		// (set) Token: 0x060027CC RID: 10188 RVA: 0x0000DA43 File Offset: 0x0000BC43
		public unsafe Il2CppStructArray<byte> key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x000D1F60 File Offset: 0x000D0160
		// (set) Token: 0x060027CE RID: 10190 RVA: 0x0000DA62 File Offset: 0x0000BC62
		public unsafe CompareOptions options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_options)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x000D1F88 File Offset: 0x000D0188
		// (set) Token: 0x060027D0 RID: 10192 RVA: 0x0000DA7D File Offset: 0x0000BC7D
		public unsafe int lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_lcid)) = value;
			}
		}

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeFieldInfoPtr_lcid;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_SortKey_SortKey_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_CompareOptions_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Il2CppStructArray_1_Byte_CompareOptions_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalString_Public_Virtual_New_get_String_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
