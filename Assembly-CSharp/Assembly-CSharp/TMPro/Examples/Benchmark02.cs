using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x020000FF RID: 255
	public class Benchmark02 : MonoBehaviour
	{
		// Token: 0x06001E74 RID: 7796 RVA: 0x0007769C File Offset: 0x0007589C
		// Note: this type is marked as 'beforefieldinit'.
		static Benchmark02()
		{
			Il2CppClassPointerStore<Benchmark02>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "Benchmark02");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benchmark02>.NativeClassPtr);
			Benchmark02.NativeFieldInfoPtr_SpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark02>.NativeClassPtr, "SpawnType");
			Benchmark02.NativeFieldInfoPtr_NumberOfNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark02>.NativeClassPtr, "NumberOfNPC");
			Benchmark02.NativeFieldInfoPtr_floatingText_Script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark02>.NativeClassPtr, "floatingText_Script");
			Benchmark02.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark02>.NativeClassPtr, 100665811);
			Benchmark02.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark02>.NativeClassPtr, 100665812);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00077730 File Offset: 0x00075930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255678, XrefRangeEnd = 255769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark02.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00077764 File Offset: 0x00075964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255769, XrefRangeEnd = 255770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Benchmark02()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benchmark02>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark02.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00012FD1 File Offset: 0x000111D1
		public Benchmark02(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x000777A0 File Offset: 0x000759A0
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x00012FDA File Offset: 0x000111DA
		public unsafe int SpawnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark02.NativeFieldInfoPtr_SpawnType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark02.NativeFieldInfoPtr_SpawnType)) = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000777C8 File Offset: 0x000759C8
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x00012FF5 File Offset: 0x000111F5
		public unsafe int NumberOfNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark02.NativeFieldInfoPtr_NumberOfNPC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark02.NativeFieldInfoPtr_NumberOfNPC)) = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x000777F0 File Offset: 0x000759F0
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x00013010 File Offset: 0x00011210
		public unsafe TextMeshProFloatingText floatingText_Script
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark02.NativeFieldInfoPtr_floatingText_Script);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProFloatingText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark02.NativeFieldInfoPtr_floatingText_Script), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeFieldInfoPtr_SpawnType;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfNPC;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeFieldInfoPtr_floatingText_Script;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
