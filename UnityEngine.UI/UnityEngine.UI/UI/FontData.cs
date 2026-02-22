using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class FontData : Object
	{
		// Token: 0x0600010B RID: 267 RVA: 0x0000AF64 File Offset: 0x00009164
		// Note: this type is marked as 'beforefieldinit'.
		static FontData()
		{
			Il2CppClassPointerStore<FontData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "FontData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontData>.NativeClassPtr);
			FontData.NativeFieldInfoPtr_m_Font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_Font");
			FontData.NativeFieldInfoPtr_m_FontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_FontSize");
			FontData.NativeFieldInfoPtr_m_FontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_FontStyle");
			FontData.NativeFieldInfoPtr_m_BestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_BestFit");
			FontData.NativeFieldInfoPtr_m_MinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_MinSize");
			FontData.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_MaxSize");
			FontData.NativeFieldInfoPtr_m_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_Alignment");
			FontData.NativeFieldInfoPtr_m_AlignByGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_AlignByGeometry");
			FontData.NativeFieldInfoPtr_m_RichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_RichText");
			FontData.NativeFieldInfoPtr_m_HorizontalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_HorizontalOverflow");
			FontData.NativeFieldInfoPtr_m_VerticalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_VerticalOverflow");
			FontData.NativeFieldInfoPtr_m_LineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_LineSpacing");
			FontData.NativeMethodInfoPtr_get_defaultFontData_Public_Static_get_FontData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663443);
			FontData.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663444);
			FontData.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663445);
			FontData.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663446);
			FontData.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663447);
			FontData.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663448);
			FontData.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663449);
			FontData.NativeMethodInfoPtr_get_bestFit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663450);
			FontData.NativeMethodInfoPtr_set_bestFit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663451);
			FontData.NativeMethodInfoPtr_get_minSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663452);
			FontData.NativeMethodInfoPtr_set_minSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663453);
			FontData.NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663454);
			FontData.NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663455);
			FontData.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663456);
			FontData.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663457);
			FontData.NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663458);
			FontData.NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663459);
			FontData.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663460);
			FontData.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663461);
			FontData.NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663462);
			FontData.NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663463);
			FontData.NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663464);
			FontData.NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663465);
			FontData.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663466);
			FontData.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663467);
			FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663468);
			FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663469);
			FontData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663470);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000B2B4 File Offset: 0x000094B4
		public unsafe static FontData defaultFontData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110262, RefRangeEnd = 110263, XrefRangeStart = 110258, XrefRangeEnd = 110262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_defaultFontData_Public_Static_get_FontData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontData>(intPtr3) : null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000B2E8 File Offset: 0x000094E8
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000B328 File Offset: 0x00009528
		public unsafe Font font
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000B36C File Offset: 0x0000956C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000B3A8 File Offset: 0x000095A8
		public unsafe int fontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000B3E8 File Offset: 0x000095E8
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000B424 File Offset: 0x00009624
		public unsafe FontStyle fontStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000B464 File Offset: 0x00009664
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000B4A0 File Offset: 0x000096A0
		public unsafe bool bestFit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_bestFit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_bestFit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000B4E0 File Offset: 0x000096E0
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000B51C File Offset: 0x0000971C
		public unsafe int minSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_minSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_minSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000B55C File Offset: 0x0000975C
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000B598 File Offset: 0x00009798
		public unsafe int maxSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000B5D8 File Offset: 0x000097D8
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000B614 File Offset: 0x00009814
		public unsafe TextAnchor alignment
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12780, RefRangeEnd = 12781, XrefRangeStart = 12780, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000B654 File Offset: 0x00009854
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000B690 File Offset: 0x00009890
		public unsafe bool alignByGeometry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000B6D0 File Offset: 0x000098D0
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000B70C File Offset: 0x0000990C
		public unsafe bool richText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000B74C File Offset: 0x0000994C
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000B788 File Offset: 0x00009988
		public unsafe HorizontalWrapMode horizontalOverflow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000B7C8 File Offset: 0x000099C8
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000B804 File Offset: 0x00009A04
		public unsafe VerticalWrapMode verticalOverflow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000B844 File Offset: 0x00009A44
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000B880 File Offset: 0x00009A80
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88931, RefRangeEnd = 88932, XrefRangeStart = 88931, XrefRangeEnd = 88932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110263, XrefRangeEnd = 110266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B928 File Offset: 0x00009B28
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000025ED File Offset: 0x000007ED
		public FontData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000B964 File Offset: 0x00009B64
		// (set) Token: 0x0600012A RID: 298 RVA: 0x000025F6 File Offset: 0x000007F6
		public unsafe Font m_Font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000B994 File Offset: 0x00009B94
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002615 File Offset: 0x00000815
		public unsafe int m_FontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontSize)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000B9BC File Offset: 0x00009BBC
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002630 File Offset: 0x00000830
		public unsafe FontStyle m_FontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontStyle)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000264B File Offset: 0x0000084B
		public unsafe bool m_BestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_BestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_BestFit)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000BA0C File Offset: 0x00009C0C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002666 File Offset: 0x00000866
		public unsafe int m_MinSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MinSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MinSize)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000BA34 File Offset: 0x00009C34
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002681 File Offset: 0x00000881
		public unsafe int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000BA5C File Offset: 0x00009C5C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000269C File Offset: 0x0000089C
		public unsafe TextAnchor m_Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Alignment)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000BA84 File Offset: 0x00009C84
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000026B7 File Offset: 0x000008B7
		public unsafe bool m_AlignByGeometry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_AlignByGeometry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_AlignByGeometry)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000BAAC File Offset: 0x00009CAC
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000026D2 File Offset: 0x000008D2
		public unsafe bool m_RichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_RichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_RichText)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000026ED File Offset: 0x000008ED
		public unsafe HorizontalWrapMode m_HorizontalOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_HorizontalOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_HorizontalOverflow)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000BAFC File Offset: 0x00009CFC
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002708 File Offset: 0x00000908
		public unsafe VerticalWrapMode m_VerticalOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_VerticalOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_VerticalOverflow)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000BB24 File Offset: 0x00009D24
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002723 File Offset: 0x00000923
		public unsafe float m_LineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_LineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_LineSpacing)) = value;
			}
		}

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_m_Font;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_m_FontSize;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_m_FontStyle;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_m_BestFit;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_m_MinSize;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_m_Alignment;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_m_AlignByGeometry;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_m_RichText;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalOverflow;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalOverflow;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_m_LineSpacing;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontData_Public_Static_get_FontData_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_bestFit_Public_get_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_set_bestFit_Public_set_Void_Boolean_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_get_minSize_Public_get_Int32_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_set_minSize_Public_set_Void_Int32_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
