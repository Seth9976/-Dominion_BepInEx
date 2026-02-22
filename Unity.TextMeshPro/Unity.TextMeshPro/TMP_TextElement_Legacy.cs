using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public class TMP_TextElement_Legacy : Object
	{
		// Token: 0x06000D8C RID: 3468 RVA: 0x00037420 File Offset: 0x00035620
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextElement_Legacy()
		{
			Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextElement_Legacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr);
			TMP_TextElement_Legacy.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "id");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "x");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "y");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "width");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "height");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "xOffset");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "yOffset");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "xAdvance");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "scale");
			TMP_TextElement_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, 100664681);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00037518 File Offset: 0x00035718
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextElement_Legacy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00008686 File Offset: 0x00006886
		public TMP_TextElement_Legacy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00037554 File Offset: 0x00035754
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x0000868F File Offset: 0x0000688F
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0003757C File Offset: 0x0003577C
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x000086AA File Offset: 0x000068AA
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x000375A4 File Offset: 0x000357A4
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x000086C5 File Offset: 0x000068C5
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x000375CC File Offset: 0x000357CC
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x000086E0 File Offset: 0x000068E0
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x000375F4 File Offset: 0x000357F4
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x000086FB File Offset: 0x000068FB
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0003761C File Offset: 0x0003581C
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00008716 File Offset: 0x00006916
		public unsafe float xOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xOffset)) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00037644 File Offset: 0x00035844
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00008731 File Offset: 0x00006931
		public unsafe float yOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_yOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_yOffset)) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0003766C File Offset: 0x0003586C
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0000874C File Offset: 0x0000694C
		public unsafe float xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xAdvance)) = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00037694 File Offset: 0x00035894
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00008767 File Offset: 0x00006967
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_xOffset;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_yOffset;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
