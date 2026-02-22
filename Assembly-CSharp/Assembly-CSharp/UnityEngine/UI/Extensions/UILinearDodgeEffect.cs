using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000122 RID: 290
	public class UILinearDodgeEffect : MonoBehaviour
	{
		// Token: 0x060020BE RID: 8382 RVA: 0x0007DA44 File Offset: 0x0007BC44
		// Note: this type is marked as 'beforefieldinit'.
		static UILinearDodgeEffect()
		{
			Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UILinearDodgeEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr);
			UILinearDodgeEffect.NativeFieldInfoPtr_mGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr, "mGraphic");
			UILinearDodgeEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr, 100665967);
			UILinearDodgeEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr, 100665968);
			UILinearDodgeEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr, 100665969);
			UILinearDodgeEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr, 100665970);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0007DAD8 File Offset: 0x0007BCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257847, XrefRangeEnd = 257848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILinearDodgeEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0007DB0C File Offset: 0x0007BD0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257875, RefRangeEnd = 257877, XrefRangeStart = 257848, XrefRangeEnd = 257875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILinearDodgeEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0007DB40 File Offset: 0x0007BD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILinearDodgeEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0007DB74 File Offset: 0x0007BD74
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UILinearDodgeEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILinearDodgeEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILinearDodgeEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000144DB File Offset: 0x000126DB
		public UILinearDodgeEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0007DBB0 File Offset: 0x0007BDB0
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x000144E4 File Offset: 0x000126E4
		public unsafe MaskableGraphic mGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILinearDodgeEffect.NativeFieldInfoPtr_mGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILinearDodgeEffect.NativeFieldInfoPtr_mGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeFieldInfoPtr_mGraphic;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
