using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000016 RID: 22
	public sealed class TMP_LinkInfo : ValueType
	{
		// Token: 0x06000239 RID: 569 RVA: 0x00011CBC File Offset: 0x0000FEBC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_LinkInfo()
		{
			Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_LinkInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr);
			TMP_LinkInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "textComponent");
			TMP_LinkInfo.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "hashCode");
			TMP_LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkIdFirstCharacterIndex");
			TMP_LinkInfo.NativeFieldInfoPtr_linkIdLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkIdLength");
			TMP_LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkTextfirstCharacterIndex");
			TMP_LinkInfo.NativeFieldInfoPtr_linkTextLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkTextLength");
			TMP_LinkInfo.NativeFieldInfoPtr_linkID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkID");
			TMP_LinkInfo.NativeMethodInfoPtr_SetLinkID_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, 100663560);
			TMP_LinkInfo.NativeMethodInfoPtr_GetLinkText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, 100663561);
			TMP_LinkInfo.NativeMethodInfoPtr_GetLinkID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, 100663562);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00011DB4 File Offset: 0x0000FFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137414, XrefRangeEnd = 137417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLinkID(Il2CppStructArray<char> text, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_LinkInfo.NativeMethodInfoPtr_SetLinkID_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00011E18 File Offset: 0x00010018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137421, RefRangeEnd = 137423, XrefRangeStart = 137417, XrefRangeEnd = 137421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLinkText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_LinkInfo.NativeMethodInfoPtr_GetLinkText_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00011E54 File Offset: 0x00010054
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137429, RefRangeEnd = 137432, XrefRangeStart = 137423, XrefRangeEnd = 137429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLinkID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_LinkInfo.NativeMethodInfoPtr_GetLinkID_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002D5B File Offset: 0x00000F5B
		public TMP_LinkInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002D64 File Offset: 0x00000F64
		public TMP_LinkInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00011E90 File Offset: 0x00010090
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002D76 File Offset: 0x00000F76
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00011EC0 File Offset: 0x000100C0
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002D95 File Offset: 0x00000F95
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00011EE8 File Offset: 0x000100E8
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002DB0 File Offset: 0x00000FB0
		public unsafe int linkIdFirstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00011F10 File Offset: 0x00010110
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002DCB File Offset: 0x00000FCB
		public unsafe int linkIdLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdLength)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00011F38 File Offset: 0x00010138
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002DE6 File Offset: 0x00000FE6
		public unsafe int linkTextfirstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00011F60 File Offset: 0x00010160
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002E01 File Offset: 0x00001001
		public unsafe int linkTextLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextLength)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00011F88 File Offset: 0x00010188
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002E1C File Offset: 0x0000101C
		public unsafe Il2CppStructArray<char> linkID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_linkIdFirstCharacterIndex;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_linkIdLength;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_linkTextfirstCharacterIndex;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_linkTextLength;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_linkID;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_SetLinkID_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkText_Public_String_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkID_Public_String_0;
	}
}
