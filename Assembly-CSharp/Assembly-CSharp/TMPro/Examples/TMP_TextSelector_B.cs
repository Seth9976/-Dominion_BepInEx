using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro.Examples
{
	// Token: 0x02000111 RID: 273
	public class TMP_TextSelector_B : MonoBehaviour
	{
		// Token: 0x06001FC0 RID: 8128 RVA: 0x0007AB28 File Offset: 0x00078D28
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextSelector_B()
		{
			Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMP_TextSelector_B");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr);
			TMP_TextSelector_B.NativeFieldInfoPtr_TextPopup_Prefab_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "TextPopup_Prefab_01");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_TextPopup_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_TextPopup_RectTransform");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_TextPopup_TMPComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_TextPopup_TMPComponent");
			TMP_TextSelector_B.NativeFieldInfoPtr_k_LinkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "k_LinkText");
			TMP_TextSelector_B.NativeFieldInfoPtr_k_WordText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "k_WordText");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_TextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_TextMeshPro");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_Canvas");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_Camera");
			TMP_TextSelector_B.NativeFieldInfoPtr_isHoveringObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "isHoveringObject");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_selectedWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_selectedWord");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_selectedLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_selectedLink");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_lastIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_lastIndex");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_matrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_matrix");
			TMP_TextSelector_B.NativeFieldInfoPtr_m_cachedMeshInfoVertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, "m_cachedMeshInfoVertexData");
			TMP_TextSelector_B.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665881);
			TMP_TextSelector_B.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665882);
			TMP_TextSelector_B.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665883);
			TMP_TextSelector_B.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665884);
			TMP_TextSelector_B.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665885);
			TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665886);
			TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665887);
			TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665888);
			TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665889);
			TMP_TextSelector_B.NativeMethodInfoPtr_RestoreCachedVertexAttributes_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665890);
			TMP_TextSelector_B.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr, 100665891);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0007AD4C File Offset: 0x00078F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256832, XrefRangeEnd = 256857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0007AD80 File Offset: 0x00078F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256857, XrefRangeEnd = 256873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0007ADB4 File Offset: 0x00078FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256873, XrefRangeEnd = 256889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0007ADE8 File Offset: 0x00078FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256889, XrefRangeEnd = 256894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ON_TEXT_CHANGED(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0007AE2C File Offset: 0x0007902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256894, XrefRangeEnd = 256902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0007AE60 File Offset: 0x00079060
		[CallerCount(0)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0007AEA4 File Offset: 0x000790A4
		[CallerCount(0)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0007AEE8 File Offset: 0x000790E8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0007AF2C File Offset: 0x0007912C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0007AF70 File Offset: 0x00079170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256902, RefRangeEnd = 256903, XrefRangeStart = 256902, XrefRangeEnd = 256902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreCachedVertexAttributes(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr_RestoreCachedVertexAttributes_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0007AFB0 File Offset: 0x000791B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256903, XrefRangeEnd = 256904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextSelector_B()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextSelector_B>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_B.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00013CCC File Offset: 0x00011ECC
		public TMP_TextSelector_B(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0007AFEC File Offset: 0x000791EC
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00013CD5 File Offset: 0x00011ED5
		public unsafe RectTransform TextPopup_Prefab_01
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_TextPopup_Prefab_01);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_TextPopup_Prefab_01), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0007B01C File Offset: 0x0007921C
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00013CF4 File Offset: 0x00011EF4
		public unsafe RectTransform m_TextPopup_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_TextPopup_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_TextPopup_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0007B04C File Offset: 0x0007924C
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00013D13 File Offset: 0x00011F13
		public unsafe TextMeshProUGUI m_TextPopup_TMPComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_TextPopup_TMPComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_TextPopup_TMPComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0007B07C File Offset: 0x0007927C
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x00013D32 File Offset: 0x00011F32
		public unsafe static string k_LinkText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextSelector_B.NativeFieldInfoPtr_k_LinkText, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextSelector_B.NativeFieldInfoPtr_k_LinkText, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0007B09C File Offset: 0x0007929C
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00013D44 File Offset: 0x00011F44
		public unsafe static string k_WordText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextSelector_B.NativeFieldInfoPtr_k_WordText, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextSelector_B.NativeFieldInfoPtr_k_WordText, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0007B0BC File Offset: 0x000792BC
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00013D56 File Offset: 0x00011F56
		public unsafe TextMeshProUGUI m_TextMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_TextMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_TextMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0007B0EC File Offset: 0x000792EC
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00013D75 File Offset: 0x00011F75
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0007B11C File Offset: 0x0007931C
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00013D94 File Offset: 0x00011F94
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0007B14C File Offset: 0x0007934C
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00013DB3 File Offset: 0x00011FB3
		public unsafe bool isHoveringObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_isHoveringObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_isHoveringObject)) = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0007B174 File Offset: 0x00079374
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00013DCE File Offset: 0x00011FCE
		public unsafe int m_selectedWord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_selectedWord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_selectedWord)) = value;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0007B19C File Offset: 0x0007939C
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00013DE9 File Offset: 0x00011FE9
		public unsafe int m_selectedLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_selectedLink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_selectedLink)) = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0007B1C4 File Offset: 0x000793C4
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00013E04 File Offset: 0x00012004
		public unsafe int m_lastIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_lastIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_lastIndex)) = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0007B1EC File Offset: 0x000793EC
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00013E1F File Offset: 0x0001201F
		public unsafe Matrix4x4 m_matrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_matrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_matrix)) = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0007B214 File Offset: 0x00079414
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00013E3A File Offset: 0x0001203A
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> m_cachedMeshInfoVertexData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_cachedMeshInfoVertexData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_B.NativeFieldInfoPtr_m_cachedMeshInfoVertexData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeFieldInfoPtr_TextPopup_Prefab_01;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeFieldInfoPtr_m_TextPopup_RectTransform;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeFieldInfoPtr_m_TextPopup_TMPComponent;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_k_LinkText;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeFieldInfoPtr_k_WordText;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr_m_TextMeshPro;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeFieldInfoPtr_isHoveringObject;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeFieldInfoPtr_m_selectedWord;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr_m_selectedLink;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr_m_lastIndex;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr_m_matrix;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeFieldInfoPtr_m_cachedMeshInfoVertexData;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_RestoreCachedVertexAttributes_Private_Void_Int32_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
