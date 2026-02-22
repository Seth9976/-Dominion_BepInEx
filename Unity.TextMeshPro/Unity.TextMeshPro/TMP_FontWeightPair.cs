using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000032 RID: 50
	[Serializable]
	public sealed class TMP_FontWeightPair : ValueType
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontWeightPair()
		{
			Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontWeightPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr);
			TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "regularTypeface");
			TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "italicTypeface");
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004C95 File Offset: 0x00002E95
		public TMP_FontWeightPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00004C9E File Offset: 0x00002E9E
		public TMP_FontWeightPair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr))
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001B908 File Offset: 0x00019B08
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00004CB0 File Offset: 0x00002EB0
		public unsafe TMP_FontAsset regularTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0001B938 File Offset: 0x00019B38
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00004CCF File Offset: 0x00002ECF
		public unsafe TMP_FontAsset italicTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_regularTypeface;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_italicTypeface;
	}
}
