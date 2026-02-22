using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000017 RID: 23
	public sealed class TMP_WordInfo : ValueType
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00011FB8 File Offset: 0x000101B8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_WordInfo()
		{
			Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_WordInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr);
			TMP_WordInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "textComponent");
			TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "firstCharacterIndex");
			TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "lastCharacterIndex");
			TMP_WordInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "characterCount");
			TMP_WordInfo.NativeMethodInfoPtr_GetWord_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, 100663563);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001204C File Offset: 0x0001024C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137436, RefRangeEnd = 137437, XrefRangeStart = 137432, XrefRangeEnd = 137436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_WordInfo.NativeMethodInfoPtr_GetWord_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002E3B File Offset: 0x0000103B
		public TMP_WordInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002E44 File Offset: 0x00001044
		public TMP_WordInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00012088 File Offset: 0x00010288
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002E56 File Offset: 0x00001056
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000120B8 File Offset: 0x000102B8
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002E75 File Offset: 0x00001075
		public unsafe int firstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000120E0 File Offset: 0x000102E0
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002E90 File Offset: 0x00001090
		public unsafe int lastCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00012108 File Offset: 0x00010308
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002EAB File Offset: 0x000010AB
		public unsafe int characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_characterCount)) = value;
			}
		}

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_GetWord_Public_String_0;
	}
}
