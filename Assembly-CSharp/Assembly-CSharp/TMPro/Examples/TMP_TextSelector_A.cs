using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro.Examples
{
	// Token: 0x02000110 RID: 272
	public class TMP_TextSelector_A : MonoBehaviour
	{
		// Token: 0x06001FAD RID: 8109 RVA: 0x0007A7F0 File Offset: 0x000789F0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextSelector_A()
		{
			Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMP_TextSelector_A");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr);
			TMP_TextSelector_A.NativeFieldInfoPtr_m_TextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, "m_TextMeshPro");
			TMP_TextSelector_A.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, "m_Camera");
			TMP_TextSelector_A.NativeFieldInfoPtr_m_isHoveringObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, "m_isHoveringObject");
			TMP_TextSelector_A.NativeFieldInfoPtr_m_selectedLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, "m_selectedLink");
			TMP_TextSelector_A.NativeFieldInfoPtr_m_lastCharIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, "m_lastCharIndex");
			TMP_TextSelector_A.NativeFieldInfoPtr_m_lastWordIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, "m_lastWordIndex");
			TMP_TextSelector_A.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, 100665876);
			TMP_TextSelector_A.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, 100665877);
			TMP_TextSelector_A.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, 100665878);
			TMP_TextSelector_A.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, 100665879);
			TMP_TextSelector_A.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr, 100665880);
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0007A8FC File Offset: 0x00078AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256737, XrefRangeEnd = 256743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_A.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0007A930 File Offset: 0x00078B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256743, XrefRangeEnd = 256819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_A.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0007A964 File Offset: 0x00078B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256819, XrefRangeEnd = 256825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_A.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0007A9A8 File Offset: 0x00078BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256825, XrefRangeEnd = 256831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_A.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0007A9EC File Offset: 0x00078BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256831, XrefRangeEnd = 256832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextSelector_A()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextSelector_A>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextSelector_A.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00013C19 File Offset: 0x00011E19
		public TMP_TextSelector_A(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0007AA28 File Offset: 0x00078C28
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00013C22 File Offset: 0x00011E22
		public unsafe TextMeshPro m_TextMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_TextMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_TextMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x0007AA58 File Offset: 0x00078C58
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00013C41 File Offset: 0x00011E41
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0007AA88 File Offset: 0x00078C88
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00013C60 File Offset: 0x00011E60
		public unsafe bool m_isHoveringObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_isHoveringObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_isHoveringObject)) = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x0007AAB0 File Offset: 0x00078CB0
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00013C7B File Offset: 0x00011E7B
		public unsafe int m_selectedLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_selectedLink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_selectedLink)) = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0007AAD8 File Offset: 0x00078CD8
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00013C96 File Offset: 0x00011E96
		public unsafe int m_lastCharIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_lastCharIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_lastCharIndex)) = value;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0007AB00 File Offset: 0x00078D00
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00013CB1 File Offset: 0x00011EB1
		public unsafe int m_lastWordIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_lastWordIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextSelector_A.NativeFieldInfoPtr_m_lastWordIndex)) = value;
			}
		}

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_m_TextMeshPro;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_m_isHoveringObject;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_m_selectedLink;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeFieldInfoPtr_m_lastCharIndex;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeFieldInfoPtr_m_lastWordIndex;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
