using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	// Token: 0x0200000B RID: 11
	public class TextContainer : UIBehaviour
	{
		// Token: 0x0600006E RID: 110 RVA: 0x0000B800 File Offset: 0x00009A00
		// Note: this type is marked as 'beforefieldinit'.
		static TextContainer()
		{
			Il2CppClassPointerStore<TextContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TextContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextContainer>.NativeClassPtr);
			TextContainer.NativeFieldInfoPtr_m_hasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_hasChanged");
			TextContainer.NativeFieldInfoPtr_m_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_pivot");
			TextContainer.NativeFieldInfoPtr_m_anchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_anchorPosition");
			TextContainer.NativeFieldInfoPtr_m_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_rect");
			TextContainer.NativeFieldInfoPtr_m_isDefaultWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isDefaultWidth");
			TextContainer.NativeFieldInfoPtr_m_isDefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isDefaultHeight");
			TextContainer.NativeFieldInfoPtr_m_isAutoFitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isAutoFitting");
			TextContainer.NativeFieldInfoPtr_m_corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_corners");
			TextContainer.NativeFieldInfoPtr_m_worldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_worldCorners");
			TextContainer.NativeFieldInfoPtr_m_margins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_margins");
			TextContainer.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_rectTransform");
			TextContainer.NativeFieldInfoPtr_k_defaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "k_defaultSize");
			TextContainer.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_textMeshPro");
			TextContainer.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663340);
			TextContainer.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663341);
			TextContainer.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663342);
			TextContainer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663343);
			TextContainer.NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663344);
			TextContainer.NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663345);
			TextContainer.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663346);
			TextContainer.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663347);
			TextContainer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663348);
			TextContainer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663349);
			TextContainer.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663350);
			TextContainer.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663351);
			TextContainer.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663352);
			TextContainer.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663353);
			TextContainer.NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663354);
			TextContainer.NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663355);
			TextContainer.NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663356);
			TextContainer.NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663357);
			TextContainer.NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663358);
			TextContainer.NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663359);
			TextContainer.NativeMethodInfoPtr_get_margins_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663360);
			TextContainer.NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663361);
			TextContainer.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663362);
			TextContainer.NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663363);
			TextContainer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663364);
			TextContainer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663365);
			TextContainer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663366);
			TextContainer.NativeMethodInfoPtr_OnContainerChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663367);
			TextContainer.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663368);
			TextContainer.NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663369);
			TextContainer.NativeMethodInfoPtr_UpdateCorners_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663370);
			TextContainer.NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663371);
			TextContainer.NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663372);
			TextContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663373);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000BBDC File Offset: 0x00009DDC
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000BC18 File Offset: 0x00009E18
		public unsafe bool hasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000BC58 File Offset: 0x00009E58
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000BC94 File Offset: 0x00009E94
		public unsafe Vector2 pivot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 132165, RefRangeEnd = 132166, XrefRangeStart = 132156, XrefRangeEnd = 132165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000BD10 File Offset: 0x00009F10
		public unsafe TextContainerAnchors anchorPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 132176, RefRangeEnd = 132180, XrefRangeStart = 132166, XrefRangeEnd = 132176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000BD50 File Offset: 0x00009F50
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000BD8C File Offset: 0x00009F8C
		public unsafe Rect rect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132180, XrefRangeEnd = 132182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000BDCC File Offset: 0x00009FCC
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000BE08 File Offset: 0x0000A008
		public unsafe Vector2 size
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132182, XrefRangeEnd = 132184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132184, XrefRangeEnd = 132188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000BE48 File Offset: 0x0000A048
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000BE84 File Offset: 0x0000A084
		public unsafe float width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132188, XrefRangeEnd = 132189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132189, XrefRangeEnd = 132192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000BF00 File Offset: 0x0000A100
		public unsafe float height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132192, XrefRangeEnd = 132193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132193, XrefRangeEnd = 132196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000BF40 File Offset: 0x0000A140
		public unsafe bool isDefaultWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000BF7C File Offset: 0x0000A17C
		public unsafe bool isDefaultHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		public unsafe bool isAutoFitting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000C034 File Offset: 0x0000A234
		public unsafe Il2CppStructArray<Vector3> corners
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000C074 File Offset: 0x0000A274
		public unsafe Il2CppStructArray<Vector3> worldCorners
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public unsafe Vector4 margins
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_margins_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132196, XrefRangeEnd = 132197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000C130 File Offset: 0x0000A330
		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132197, XrefRangeEnd = 132204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000C170 File Offset: 0x0000A370
		public unsafe TextMeshPro textMeshPro
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132204, XrefRangeEnd = 132211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr3) : null;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132211, XrefRangeEnd = 132223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C1EC File Offset: 0x0000A3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132223, XrefRangeEnd = 132224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C228 File Offset: 0x0000A428
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000C264 File Offset: 0x0000A464
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 132243, RefRangeEnd = 132253, XrefRangeStart = 132224, XrefRangeEnd = 132243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnContainerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_OnContainerChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000C298 File Offset: 0x0000A498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132253, XrefRangeEnd = 132282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 132285, RefRangeEnd = 132289, XrefRangeStart = 132282, XrefRangeEnd = 132285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRect(Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000C314 File Offset: 0x0000A514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132302, RefRangeEnd = 132303, XrefRangeStart = 132289, XrefRangeEnd = 132302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_UpdateCorners_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000C348 File Offset: 0x0000A548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132303, XrefRangeEnd = 132306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPivot(TextContainerAnchors anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000C394 File Offset: 0x0000A594
		[CallerCount(0)]
		public unsafe TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pivot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000C3E0 File Offset: 0x0000A5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132306, XrefRangeEnd = 132312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000023AE File Offset: 0x000005AE
		public TextContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000C41C File Offset: 0x0000A61C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe bool m_hasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_hasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_hasChanged)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000C444 File Offset: 0x0000A644
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000023D2 File Offset: 0x000005D2
		public unsafe Vector2 m_pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_pivot)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000C46C File Offset: 0x0000A66C
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000023ED File Offset: 0x000005ED
		public unsafe TextContainerAnchors m_anchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_anchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_anchorPosition)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000C494 File Offset: 0x0000A694
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002408 File Offset: 0x00000608
		public unsafe Rect m_rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rect)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002423 File Offset: 0x00000623
		public unsafe bool m_isDefaultWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultWidth)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000243E File Offset: 0x0000063E
		public unsafe bool m_isDefaultHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultHeight)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000C50C File Offset: 0x0000A70C
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002459 File Offset: 0x00000659
		public unsafe bool m_isAutoFitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isAutoFitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isAutoFitting)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000C534 File Offset: 0x0000A734
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002474 File Offset: 0x00000674
		public unsafe Il2CppStructArray<Vector3> m_corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000C564 File Offset: 0x0000A764
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002493 File Offset: 0x00000693
		public unsafe Il2CppStructArray<Vector3> m_worldCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_worldCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_worldCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000C594 File Offset: 0x0000A794
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000024B2 File Offset: 0x000006B2
		public unsafe Vector4 m_margins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_margins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_margins)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000024CD File Offset: 0x000006CD
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000C5EC File Offset: 0x0000A7EC
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000024EC File Offset: 0x000006EC
		public unsafe static Vector2 k_defaultSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TextContainer.NativeFieldInfoPtr_k_defaultSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextContainer.NativeFieldInfoPtr_k_defaultSize, (void*)(&value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000C608 File Offset: 0x0000A808
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000024FA File Offset: 0x000006FA
		public unsafe TextMeshPro m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_m_hasChanged;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_m_pivot;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_m_anchorPosition;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_m_rect;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultWidth;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultHeight;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_m_isAutoFitting;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_m_corners;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_m_worldCorners;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_m_margins;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_k_defaultSize;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_margins_Public_get_Vector4_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_OnContainerChanged_Private_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCorners_Private_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
