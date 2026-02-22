using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200001D RID: 29
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x00016480 File Offset: 0x00014680
		// Note: this type is marked as 'beforefieldinit'.
		static HorizontalLayoutGroup()
		{
			Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "HorizontalLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr);
			HorizontalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr, 100663878);
			HorizontalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr, 100663879);
			HorizontalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr, 100663880);
			HorizontalLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr, 100663881);
			HorizontalLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr, 100663882);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00016514 File Offset: 0x00014714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114662, RefRangeEnd = 114663, XrefRangeStart = 114645, XrefRangeEnd = 114662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HorizontalLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00016550 File Offset: 0x00014750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114663, XrefRangeEnd = 114665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HorizontalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001658C File Offset: 0x0001478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114665, XrefRangeEnd = 114666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HorizontalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000165C8 File Offset: 0x000147C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114666, XrefRangeEnd = 114667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HorizontalLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00016604 File Offset: 0x00014804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114667, XrefRangeEnd = 114668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HorizontalLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003663 File Offset: 0x00001863
		public HorizontalLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;
	}
}
