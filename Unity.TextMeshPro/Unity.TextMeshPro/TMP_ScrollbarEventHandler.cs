using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	// Token: 0x0200004D RID: 77
	public class TMP_ScrollbarEventHandler : MonoBehaviour
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x00025A40 File Offset: 0x00023C40
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ScrollbarEventHandler()
		{
			Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ScrollbarEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr);
			TMP_ScrollbarEventHandler.NativeFieldInfoPtr_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr, "isSelected");
			TMP_ScrollbarEventHandler.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr, 100664157);
			TMP_ScrollbarEventHandler.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr, 100664158);
			TMP_ScrollbarEventHandler.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr, 100664159);
			TMP_ScrollbarEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr, 100664160);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00025AD4 File Offset: 0x00023CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143914, XrefRangeEnd = 143920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ScrollbarEventHandler.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00025B18 File Offset: 0x00023D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143920, XrefRangeEnd = 143926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ScrollbarEventHandler.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00025B5C File Offset: 0x00023D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143926, XrefRangeEnd = 143932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ScrollbarEventHandler.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00025BA0 File Offset: 0x00023DA0
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ScrollbarEventHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ScrollbarEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ScrollbarEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00005DB6 File Offset: 0x00003FB6
		public TMP_ScrollbarEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00025BDC File Offset: 0x00023DDC
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00005DBF File Offset: 0x00003FBF
		public unsafe bool isSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ScrollbarEventHandler.NativeFieldInfoPtr_isSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ScrollbarEventHandler.NativeFieldInfoPtr_isSelected)) = value;
			}
		}

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_isSelected;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
