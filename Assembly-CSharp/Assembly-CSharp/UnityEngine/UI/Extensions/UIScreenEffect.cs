using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000124 RID: 292
	public class UIScreenEffect : MonoBehaviour
	{
		// Token: 0x060020CE RID: 8398 RVA: 0x0007DD7C File Offset: 0x0007BF7C
		// Note: this type is marked as 'beforefieldinit'.
		static UIScreenEffect()
		{
			Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UIScreenEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr);
			UIScreenEffect.NativeFieldInfoPtr_mGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr, "mGraphic");
			UIScreenEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr, 100665975);
			UIScreenEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr, 100665976);
			UIScreenEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr, 100665977);
			UIScreenEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr, 100665978);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x0007DE10 File Offset: 0x0007C010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257907, XrefRangeEnd = 257908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x0007DE44 File Offset: 0x0007C044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257935, RefRangeEnd = 257937, XrefRangeStart = 257908, XrefRangeEnd = 257935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x0007DE78 File Offset: 0x0007C078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0007DEAC File Offset: 0x0007C0AC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScreenEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreenEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0001452B File Offset: 0x0001272B
		public UIScreenEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0007DEE8 File Offset: 0x0007C0E8
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00014534 File Offset: 0x00012734
		public unsafe MaskableGraphic mGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenEffect.NativeFieldInfoPtr_mGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenEffect.NativeFieldInfoPtr_mGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeFieldInfoPtr_mGraphic;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
