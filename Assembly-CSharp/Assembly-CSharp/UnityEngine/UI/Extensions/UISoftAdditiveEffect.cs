using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000125 RID: 293
	public class UISoftAdditiveEffect : MonoBehaviour
	{
		// Token: 0x060020D6 RID: 8406 RVA: 0x0007DF18 File Offset: 0x0007C118
		// Note: this type is marked as 'beforefieldinit'.
		static UISoftAdditiveEffect()
		{
			Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UISoftAdditiveEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr);
			UISoftAdditiveEffect.NativeFieldInfoPtr_mGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr, "mGraphic");
			UISoftAdditiveEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr, 100665979);
			UISoftAdditiveEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr, 100665980);
			UISoftAdditiveEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr, 100665981);
			UISoftAdditiveEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr, 100665982);
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0007DFAC File Offset: 0x0007C1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257937, XrefRangeEnd = 257938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISoftAdditiveEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0007DFE0 File Offset: 0x0007C1E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257965, RefRangeEnd = 257967, XrefRangeStart = 257938, XrefRangeEnd = 257965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISoftAdditiveEffect.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0007E014 File Offset: 0x0007C214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISoftAdditiveEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0007E048 File Offset: 0x0007C248
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISoftAdditiveEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISoftAdditiveEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISoftAdditiveEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00014553 File Offset: 0x00012753
		public UISoftAdditiveEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0007E084 File Offset: 0x0007C284
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0001455C File Offset: 0x0001275C
		public unsafe MaskableGraphic mGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISoftAdditiveEffect.NativeFieldInfoPtr_mGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISoftAdditiveEffect.NativeFieldInfoPtr_mGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeFieldInfoPtr_mGraphic;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
