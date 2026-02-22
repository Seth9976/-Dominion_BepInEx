using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000008 RID: 8
	public sealed class TMP_MaterialReference : ValueType
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000B28C File Offset: 0x0000948C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MaterialReference()
		{
			Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MaterialReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr);
			TMP_MaterialReference.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr, "material");
			TMP_MaterialReference.NativeFieldInfoPtr_referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr, "referenceCount");
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000223B File Offset: 0x0000043B
		public TMP_MaterialReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002244 File Offset: 0x00000444
		public TMP_MaterialReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialReference>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000B2E4 File Offset: 0x000094E4
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002256 File Offset: 0x00000456
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000B314 File Offset: 0x00009514
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002275 File Offset: 0x00000475
		public unsafe int referenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_referenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialReference.NativeFieldInfoPtr_referenceCount)) = value;
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_referenceCount;
	}
}
