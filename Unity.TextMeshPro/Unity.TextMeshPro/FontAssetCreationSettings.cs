using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	public sealed class FontAssetCreationSettings : ValueType
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x0001B3D4 File Offset: 0x000195D4
		// Note: this type is marked as 'beforefieldinit'.
		static FontAssetCreationSettings()
		{
			Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FontAssetCreationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr);
			FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "sourceFontFileName");
			FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "sourceFontFileGUID");
			FontAssetCreationSettings.NativeFieldInfoPtr_pointSizeSamplingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "pointSizeSamplingMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "pointSize");
			FontAssetCreationSettings.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "padding");
			FontAssetCreationSettings.NativeFieldInfoPtr_packingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "packingMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_atlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "atlasWidth");
			FontAssetCreationSettings.NativeFieldInfoPtr_atlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "atlasHeight");
			FontAssetCreationSettings.NativeFieldInfoPtr_characterSetSelectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "characterSetSelectionMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_characterSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "characterSequence");
			FontAssetCreationSettings.NativeFieldInfoPtr_referencedFontAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "referencedFontAssetGUID");
			FontAssetCreationSettings.NativeFieldInfoPtr_referencedTextAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "referencedTextAssetGUID");
			FontAssetCreationSettings.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "fontStyle");
			FontAssetCreationSettings.NativeFieldInfoPtr_fontStyleModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "fontStyleModifier");
			FontAssetCreationSettings.NativeFieldInfoPtr_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "renderMode");
			FontAssetCreationSettings.NativeFieldInfoPtr_includeFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "includeFontFeatures");
			FontAssetCreationSettings.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, 100663810);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001B558 File Offset: 0x00019758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140469, XrefRangeEnd = 140473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFontFileGUID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSizeSamplingMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterSelectionMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(characterSet);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAssetCreationSettings.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00004AB6 File Offset: 0x00002CB6
		public FontAssetCreationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00004ABF File Offset: 0x00002CBF
		public FontAssetCreationSettings()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr))
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001B630 File Offset: 0x00019830
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00004AD1 File Offset: 0x00002CD1
		public unsafe string sourceFontFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001B658 File Offset: 0x00019858
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public unsafe string sourceFontFileGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_sourceFontFileGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0001B680 File Offset: 0x00019880
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00004B0F File Offset: 0x00002D0F
		public unsafe int pointSizeSamplingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSizeSamplingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSizeSamplingMode)) = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001B6A8 File Offset: 0x000198A8
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00004B2A File Offset: 0x00002D2A
		public unsafe int pointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_pointSize)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001B6D0 File Offset: 0x000198D0
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00004B45 File Offset: 0x00002D45
		public unsafe int padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_padding)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001B6F8 File Offset: 0x000198F8
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00004B60 File Offset: 0x00002D60
		public unsafe int packingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_packingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_packingMode)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0001B720 File Offset: 0x00019920
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00004B7B File Offset: 0x00002D7B
		public unsafe int atlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasWidth)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001B748 File Offset: 0x00019948
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00004B96 File Offset: 0x00002D96
		public unsafe int atlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_atlasHeight)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001B770 File Offset: 0x00019970
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00004BB1 File Offset: 0x00002DB1
		public unsafe int characterSetSelectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSetSelectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSetSelectionMode)) = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001B798 File Offset: 0x00019998
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00004BCC File Offset: 0x00002DCC
		public unsafe string characterSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSequence);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_characterSequence), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001B7C0 File Offset: 0x000199C0
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00004BEB File Offset: 0x00002DEB
		public unsafe string referencedFontAssetGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedFontAssetGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedFontAssetGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001B7E8 File Offset: 0x000199E8
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00004C0A File Offset: 0x00002E0A
		public unsafe string referencedTextAssetGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedTextAssetGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_referencedTextAssetGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001B810 File Offset: 0x00019A10
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00004C29 File Offset: 0x00002E29
		public unsafe int fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyle)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0001B838 File Offset: 0x00019A38
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x00004C44 File Offset: 0x00002E44
		public unsafe float fontStyleModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyleModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_fontStyleModifier)) = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0001B860 File Offset: 0x00019A60
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00004C5F File Offset: 0x00002E5F
		public unsafe int renderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_renderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_renderMode)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0001B888 File Offset: 0x00019A88
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00004C7A File Offset: 0x00002E7A
		public unsafe bool includeFontFeatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_includeFontFeatures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationSettings.NativeFieldInfoPtr_includeFontFeatures)) = value;
			}
		}

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_sourceFontFileName;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_sourceFontFileGUID;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_pointSizeSamplingMode;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_pointSize;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_packingMode;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_atlasWidth;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_atlasHeight;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_characterSetSelectionMode;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_characterSequence;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_referencedFontAssetGUID;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_referencedTextAssetGUID;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_fontStyleModifier;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_renderMode;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_includeFontFeatures;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0;
	}
}
