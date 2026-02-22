using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace TMPro
{
	// Token: 0x02000054 RID: 84
	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement
	{
		// Token: 0x060009A8 RID: 2472 RVA: 0x000293F8 File Offset: 0x000275F8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteCharacter()
		{
			Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr);
			TMP_SpriteCharacter.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, "m_Name");
			TMP_SpriteCharacter.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, "m_HashCode");
			TMP_SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664254);
			TMP_SpriteCharacter.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664255);
			TMP_SpriteCharacter.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664256);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664257);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664258);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteAsset_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664259);
			TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr, 100664260);
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000294DC File Offset: 0x000276DC
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00029514 File Offset: 0x00027714
		public unsafe string name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145425, RefRangeEnd = 145426, XrefRangeStart = 145420, XrefRangeEnd = 145425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00029558 File Offset: 0x00027758
		public unsafe int hashCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00029594 File Offset: 0x00027794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145426, XrefRangeEnd = 145427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000295D0 File Offset: 0x000277D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145427, XrefRangeEnd = 145429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0002962C File Offset: 0x0002782C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145429, XrefRangeEnd = 145431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteAsset_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00029698 File Offset: 0x00027898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145431, XrefRangeEnd = 145432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteCharacter(uint unicode, uint glyphIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteCharacter.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000067D9 File Offset: 0x000049D9
		public TMP_SpriteCharacter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000296F0 File Offset: 0x000278F0
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000067E2 File Offset: 0x000049E2
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00029718 File Offset: 0x00027918
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00006801 File Offset: 0x00004A01
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteCharacter.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteGlyph_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_SpriteAsset_TMP_SpriteGlyph_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0;
	}
}
