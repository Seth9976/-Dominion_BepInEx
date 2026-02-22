using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000051 RID: 81
	[Serializable]
	public class TMP_Sprite : TMP_TextElement_Legacy
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x00028184 File Offset: 0x00026384
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Sprite()
		{
			Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Sprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr);
			TMP_Sprite.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "name");
			TMP_Sprite.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "hashCode");
			TMP_Sprite.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "unicode");
			TMP_Sprite.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "pivot");
			TMP_Sprite.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "sprite");
			TMP_Sprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, 100664219);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002822C File Offset: 0x0002642C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Sprite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Sprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00006560 File Offset: 0x00004760
		public TMP_Sprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00028268 File Offset: 0x00026468
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00006569 File Offset: 0x00004769
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00028290 File Offset: 0x00026490
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00006588 File Offset: 0x00004788
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x000282B8 File Offset: 0x000264B8
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x000065A3 File Offset: 0x000047A3
		public unsafe int unicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_unicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_unicode)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000282E0 File Offset: 0x000264E0
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x000065BE File Offset: 0x000047BE
		public unsafe Vector2 pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_pivot)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00028308 File Offset: 0x00026508
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x000065D9 File Offset: 0x000047D9
		public unsafe Sprite sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_unicode;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
