using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000123 RID: 291
	public class UIMultiplyEffect : MonoBehaviour
	{
		// Token: 0x060020C6 RID: 8390 RVA: 0x0007DBE0 File Offset: 0x0007BDE0
		// Note: this type is marked as 'beforefieldinit'.
		static UIMultiplyEffect()
		{
			Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UIMultiplyEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr);
			UIMultiplyEffect.NativeFieldInfoPtr_mGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr, "mGraphic");
			UIMultiplyEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr, 100665971);
			UIMultiplyEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr, 100665972);
			UIMultiplyEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr, 100665973);
			UIMultiplyEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr, 100665974);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x0007DC74 File Offset: 0x0007BE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257877, XrefRangeEnd = 257878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMultiplyEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0007DCA8 File Offset: 0x0007BEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257905, RefRangeEnd = 257907, XrefRangeStart = 257878, XrefRangeEnd = 257905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMultiplyEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0007DCDC File Offset: 0x0007BEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMultiplyEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x0007DD10 File Offset: 0x0007BF10
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIMultiplyEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIMultiplyEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMultiplyEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00014503 File Offset: 0x00012703
		public UIMultiplyEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0007DD4C File Offset: 0x0007BF4C
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x0001450C File Offset: 0x0001270C
		public unsafe MaskableGraphic mGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMultiplyEffect.NativeFieldInfoPtr_mGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMultiplyEffect.NativeFieldInfoPtr_mGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeFieldInfoPtr_mGraphic;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
