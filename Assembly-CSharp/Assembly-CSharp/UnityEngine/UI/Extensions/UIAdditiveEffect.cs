using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000120 RID: 288
	public class UIAdditiveEffect : MonoBehaviour
	{
		// Token: 0x060020A2 RID: 8354 RVA: 0x0007D530 File Offset: 0x0007B730
		// Note: this type is marked as 'beforefieldinit'.
		static UIAdditiveEffect()
		{
			Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UIAdditiveEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr);
			UIAdditiveEffect.NativeFieldInfoPtr_mGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr, "mGraphic");
			UIAdditiveEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr, 100665957);
			UIAdditiveEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr, 100665958);
			UIAdditiveEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr, 100665959);
			UIAdditiveEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr, 100665960);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0007D5C4 File Offset: 0x0007B7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257769, XrefRangeEnd = 257770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAdditiveEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0007D5F8 File Offset: 0x0007B7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257797, RefRangeEnd = 257799, XrefRangeStart = 257770, XrefRangeEnd = 257797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAdditiveEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0007D62C File Offset: 0x0007B82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAdditiveEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0007D660 File Offset: 0x0007B860
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIAdditiveEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIAdditiveEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAdditiveEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00014400 File Offset: 0x00012600
		public UIAdditiveEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0007D69C File Offset: 0x0007B89C
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x00014409 File Offset: 0x00012609
		public unsafe MaskableGraphic mGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIAdditiveEffect.NativeFieldInfoPtr_mGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIAdditiveEffect.NativeFieldInfoPtr_mGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeFieldInfoPtr_mGraphic;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
