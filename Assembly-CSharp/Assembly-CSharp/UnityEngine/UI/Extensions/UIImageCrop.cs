using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000121 RID: 289
	public class UIImageCrop : MonoBehaviour
	{
		// Token: 0x060020AA RID: 8362 RVA: 0x0007D6CC File Offset: 0x0007B8CC
		// Note: this type is marked as 'beforefieldinit'.
		static UIImageCrop()
		{
			Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UIImageCrop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr);
			UIImageCrop.NativeFieldInfoPtr_mGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, "mGraphic");
			UIImageCrop.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, "mat");
			UIImageCrop.NativeFieldInfoPtr_XCropProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, "XCropProperty");
			UIImageCrop.NativeFieldInfoPtr_YCropProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, "YCropProperty");
			UIImageCrop.NativeFieldInfoPtr_XCrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, "XCrop");
			UIImageCrop.NativeFieldInfoPtr_YCrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, "YCrop");
			UIImageCrop.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, 100665961);
			UIImageCrop.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, 100665962);
			UIImageCrop.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, 100665963);
			UIImageCrop.NativeMethodInfoPtr_SetXCrop_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, 100665964);
			UIImageCrop.NativeMethodInfoPtr_SetYCrop_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, 100665965);
			UIImageCrop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr, 100665966);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0007D7EC File Offset: 0x0007B9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257799, XrefRangeEnd = 257800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageCrop.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0007D820 File Offset: 0x0007BA20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257833, RefRangeEnd = 257835, XrefRangeStart = 257800, XrefRangeEnd = 257833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageCrop.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0007D854 File Offset: 0x0007BA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257835, XrefRangeEnd = 257841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageCrop.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0007D888 File Offset: 0x0007BA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257841, XrefRangeEnd = 257844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetXCrop(float xcrop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xcrop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageCrop.NativeMethodInfoPtr_SetXCrop_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0007D8C8 File Offset: 0x0007BAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257844, XrefRangeEnd = 257847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetYCrop(float ycrop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ycrop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageCrop.NativeMethodInfoPtr_SetYCrop_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0007D908 File Offset: 0x0007BB08
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIImageCrop()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIImageCrop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageCrop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00014428 File Offset: 0x00012628
		public UIImageCrop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0007D944 File Offset: 0x0007BB44
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x00014431 File Offset: 0x00012631
		public unsafe MaskableGraphic mGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_mGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_mGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0007D974 File Offset: 0x0007BB74
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x00014450 File Offset: 0x00012650
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x0001446F File Offset: 0x0001266F
		public unsafe int XCropProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_XCropProperty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_XCropProperty)) = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0007D9CC File Offset: 0x0007BBCC
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x0001448A File Offset: 0x0001268A
		public unsafe int YCropProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_YCropProperty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_YCropProperty)) = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0007D9F4 File Offset: 0x0007BBF4
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x000144A5 File Offset: 0x000126A5
		public unsafe float XCrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_XCrop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_XCrop)) = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0007DA1C File Offset: 0x0007BC1C
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x000144C0 File Offset: 0x000126C0
		public unsafe float YCrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_YCrop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageCrop.NativeFieldInfoPtr_YCrop)) = value;
			}
		}

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeFieldInfoPtr_mGraphic;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeFieldInfoPtr_mat;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeFieldInfoPtr_XCropProperty;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeFieldInfoPtr_YCropProperty;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeFieldInfoPtr_XCrop;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeFieldInfoPtr_YCrop;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_SetXCrop_Public_Void_Single_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_SetYCrop_Public_Void_Single_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
