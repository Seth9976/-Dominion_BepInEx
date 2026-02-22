using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000039 RID: 57
	public class Text : MaskableGraphic
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x000232E4 File Offset: 0x000214E4
		// Note: this type is marked as 'beforefieldinit'.
		static Text()
		{
			Il2CppClassPointerStore<Text>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Text");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Text>.NativeClassPtr);
			Text.NativeFieldInfoPtr_m_FontData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, "m_FontData");
			Text.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, "m_Text");
			Text.NativeFieldInfoPtr_m_TextCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, "m_TextCache");
			Text.NativeFieldInfoPtr_m_TextCacheForLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, "m_TextCacheForLayout");
			Text.NativeFieldInfoPtr_s_DefaultText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, "s_DefaultText");
			Text.NativeFieldInfoPtr_m_DisableFontTextureRebuiltCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, "m_DisableFontTextureRebuiltCallback");
			Text.NativeFieldInfoPtr_m_TempVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, "m_TempVerts");
			Text.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664361);
			Text.NativeMethodInfoPtr_get_cachedTextGenerator_Public_get_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664362);
			Text.NativeMethodInfoPtr_get_cachedTextGeneratorForLayout_Public_get_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664363);
			Text.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664364);
			Text.NativeMethodInfoPtr_FontTextureChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664365);
			Text.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664366);
			Text.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664367);
			Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664368);
			Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664369);
			Text.NativeMethodInfoPtr_get_supportRichText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664370);
			Text.NativeMethodInfoPtr_set_supportRichText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664371);
			Text.NativeMethodInfoPtr_get_resizeTextForBestFit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664372);
			Text.NativeMethodInfoPtr_set_resizeTextForBestFit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664373);
			Text.NativeMethodInfoPtr_get_resizeTextMinSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664374);
			Text.NativeMethodInfoPtr_set_resizeTextMinSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664375);
			Text.NativeMethodInfoPtr_get_resizeTextMaxSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664376);
			Text.NativeMethodInfoPtr_set_resizeTextMaxSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664377);
			Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664378);
			Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664379);
			Text.NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664380);
			Text.NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664381);
			Text.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664382);
			Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664383);
			Text.NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664384);
			Text.NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664385);
			Text.NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664386);
			Text.NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664387);
			Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664388);
			Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664389);
			Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664390);
			Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664391);
			Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664392);
			Text.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664393);
			Text.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664394);
			Text.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664395);
			Text.NativeMethodInfoPtr_AssignDefaultFont_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664396);
			Text.NativeMethodInfoPtr_GetGenerationSettings_Public_TextGenerationSettings_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664397);
			Text.NativeMethodInfoPtr_GetTextAnchorPivot_Public_Static_Vector2_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664398);
			Text.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664399);
			Text.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664400);
			Text.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664401);
			Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664402);
			Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664403);
			Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664404);
			Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664405);
			Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664406);
			Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664407);
			Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100664408);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00023760 File Offset: 0x00021960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118807, XrefRangeEnd = 118814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Text()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Text>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0002379C File Offset: 0x0002199C
		public unsafe TextGenerator cachedTextGenerator
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 118820, RefRangeEnd = 118829, XrefRangeStart = 118814, XrefRangeEnd = 118820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_cachedTextGenerator_Public_get_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000237DC File Offset: 0x000219DC
		public unsafe TextGenerator cachedTextGeneratorForLayout
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 118833, RefRangeEnd = 118835, XrefRangeStart = 118829, XrefRangeEnd = 118833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_cachedTextGeneratorForLayout_Public_get_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0002381C File Offset: 0x00021A1C
		public unsafe override Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118835, XrefRangeEnd = 118857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00023868 File Offset: 0x00021A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118870, RefRangeEnd = 118871, XrefRangeStart = 118857, XrefRangeEnd = 118870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FontTextureChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_FontTextureChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0002389C File Offset: 0x00021A9C
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x000238DC File Offset: 0x00021ADC
		public unsafe Font font
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 118871, RefRangeEnd = 118880, XrefRangeStart = 118871, XrefRangeEnd = 118871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118880, XrefRangeEnd = 118893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00023920 File Offset: 0x00021B20
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00023964 File Offset: 0x00021B64
		public unsafe virtual string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118893, XrefRangeEnd = 118898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x000239B4 File Offset: 0x00021BB4
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x000239F0 File Offset: 0x00021BF0
		public unsafe bool supportRichText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_supportRichText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118898, RefRangeEnd = 118899, XrefRangeStart = 118898, XrefRangeEnd = 118898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_supportRichText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00023A30 File Offset: 0x00021C30
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00023A6C File Offset: 0x00021C6C
		public unsafe bool resizeTextForBestFit
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 118899, RefRangeEnd = 118901, XrefRangeStart = 118899, XrefRangeEnd = 118899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_resizeTextForBestFit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_resizeTextForBestFit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00023AAC File Offset: 0x00021CAC
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00023AE8 File Offset: 0x00021CE8
		public unsafe int resizeTextMinSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_resizeTextMinSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_resizeTextMinSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00023B28 File Offset: 0x00021D28
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00023B64 File Offset: 0x00021D64
		public unsafe int resizeTextMaxSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 118901, RefRangeEnd = 118903, XrefRangeStart = 118901, XrefRangeEnd = 118901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_resizeTextMaxSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_resizeTextMaxSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00023BA4 File Offset: 0x00021DA4
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00023BE0 File Offset: 0x00021DE0
		public unsafe TextAnchor alignment
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118903, RefRangeEnd = 118904, XrefRangeStart = 118903, XrefRangeEnd = 118903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 118904, RefRangeEnd = 118907, XrefRangeStart = 118904, XrefRangeEnd = 118904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00023C20 File Offset: 0x00021E20
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00023C5C File Offset: 0x00021E5C
		public unsafe bool alignByGeometry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00023C9C File Offset: 0x00021E9C
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00023CD8 File Offset: 0x00021ED8
		public unsafe int fontSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118907, RefRangeEnd = 118908, XrefRangeStart = 118907, XrefRangeEnd = 118907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00023D18 File Offset: 0x00021F18
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00023D54 File Offset: 0x00021F54
		public unsafe HorizontalWrapMode horizontalOverflow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118908, RefRangeEnd = 118909, XrefRangeStart = 118908, XrefRangeEnd = 118908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00023D94 File Offset: 0x00021F94
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00023DD0 File Offset: 0x00021FD0
		public unsafe VerticalWrapMode verticalOverflow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00023E10 File Offset: 0x00022010
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00023E4C File Offset: 0x0002204C
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00023E8C File Offset: 0x0002208C
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00023EC8 File Offset: 0x000220C8
		public unsafe FontStyle fontStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118909, RefRangeEnd = 118910, XrefRangeStart = 118909, XrefRangeEnd = 118909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00023F08 File Offset: 0x00022108
		public unsafe float pixelsPerUnit
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 118921, RefRangeEnd = 118936, XrefRangeStart = 118910, XrefRangeEnd = 118921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00023F44 File Offset: 0x00022144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118936, XrefRangeEnd = 118944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00023F80 File Offset: 0x00022180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118944, XrefRangeEnd = 118949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00023FBC File Offset: 0x000221BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118949, XrefRangeEnd = 118954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00023FF8 File Offset: 0x000221F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 118972, RefRangeEnd = 118979, XrefRangeStart = 118954, XrefRangeEnd = 118972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDefaultFont()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_AssignDefaultFont_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0002402C File Offset: 0x0002222C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 118987, RefRangeEnd = 118993, XrefRangeStart = 118979, XrefRangeEnd = 118987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref extents;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_GetGenerationSettings_Public_TextGenerationSettings_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TextGenerationSettings(intPtr);
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00024070 File Offset: 0x00022270
		[CallerCount(0)]
		public unsafe static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_GetTextAnchorPivot_Public_Static_Vector2_TextAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000240B0 File Offset: 0x000222B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118993, XrefRangeEnd = 119027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPopulateMesh(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00024100 File Offset: 0x00022300
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0002413C File Offset: 0x0002233C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00024178 File Offset: 0x00022378
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000241C0 File Offset: 0x000223C0
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119027, XrefRangeEnd = 119036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00024208 File Offset: 0x00022408
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00024250 File Offset: 0x00022450
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00024298 File Offset: 0x00022498
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119036, XrefRangeEnd = 119046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000242E0 File Offset: 0x000224E0
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00024328 File Offset: 0x00022528
		public unsafe virtual int layoutPriority
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00004885 File Offset: 0x00002A85
		public Text(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00024370 File Offset: 0x00022570
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x0000488E File Offset: 0x00002A8E
		public unsafe FontData m_FontData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_FontData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_FontData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000243A0 File Offset: 0x000225A0
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x000048AD File Offset: 0x00002AAD
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000243C8 File Offset: 0x000225C8
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x000048CC File Offset: 0x00002ACC
		public unsafe TextGenerator m_TextCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_TextCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_TextCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000243F8 File Offset: 0x000225F8
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x000048EB File Offset: 0x00002AEB
		public unsafe TextGenerator m_TextCacheForLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_TextCacheForLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_TextCacheForLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00024428 File Offset: 0x00022628
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x0000490A File Offset: 0x00002B0A
		public unsafe static Material s_DefaultText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Text.NativeFieldInfoPtr_s_DefaultText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Text.NativeFieldInfoPtr_s_DefaultText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00024450 File Offset: 0x00022650
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x0000491C File Offset: 0x00002B1C
		public unsafe bool m_DisableFontTextureRebuiltCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_DisableFontTextureRebuiltCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_DisableFontTextureRebuiltCallback)) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00024478 File Offset: 0x00022678
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00004937 File Offset: 0x00002B37
		public unsafe Il2CppStructArray<UIVertex> m_TempVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_TempVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UIVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text.NativeFieldInfoPtr_m_TempVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_m_FontData;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_m_TextCache;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr_m_TextCacheForLayout;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultText;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_m_DisableFontTextureRebuiltCallback;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_m_TempVerts;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_get_cachedTextGenerator_Public_get_TextGenerator_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_get_cachedTextGeneratorForLayout_Public_get_TextGenerator_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_FontTextureChanged_Public_Void_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_get_supportRichText_Public_get_Boolean_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_set_supportRichText_Public_set_Void_Boolean_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_get_resizeTextForBestFit_Public_get_Boolean_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_set_resizeTextForBestFit_Public_set_Void_Boolean_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_get_resizeTextMinSize_Public_get_Int32_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_set_resizeTextMinSize_Public_set_Void_Int32_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_get_resizeTextMaxSize_Public_get_Int32_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_set_resizeTextMaxSize_Public_set_Void_Int32_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_AssignDefaultFont_Internal_Void_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_GetGenerationSettings_Public_TextGenerationSettings_Vector2_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_GetTextAnchorPivot_Public_Static_Vector2_TextAnchor_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;
	}
}
