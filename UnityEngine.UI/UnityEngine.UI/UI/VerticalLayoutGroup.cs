using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000028 RID: 40
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x060004CE RID: 1230 RVA: 0x000199D4 File Offset: 0x00017BD4
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalLayoutGroup()
		{
			Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "VerticalLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr);
			VerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr, 100664008);
			VerticalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr, 100664009);
			VerticalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr, 100664010);
			VerticalLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr, 100664011);
			VerticalLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr, 100664012);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00019A68 File Offset: 0x00017C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115832, XrefRangeEnd = 115833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00019AA4 File Offset: 0x00017CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115833, XrefRangeEnd = 115835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00019AE0 File Offset: 0x00017CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115835, XrefRangeEnd = 115836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00019B1C File Offset: 0x00017D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115836, XrefRangeEnd = 115837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00019B58 File Offset: 0x00017D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115837, XrefRangeEnd = 115838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00003A0B File Offset: 0x00001C0B
		public VerticalLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;
	}
}
