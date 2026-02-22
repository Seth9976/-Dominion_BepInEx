using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001D RID: 29
	public sealed class GUIScrollGroup : GUILayoutGroup
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x00012FF8 File Offset: 0x000111F8
		// Note: this type is marked as 'beforefieldinit'.
		static GUIScrollGroup()
		{
			Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIScrollGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr);
			GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinWidth");
			GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxWidth");
			GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinHeight");
			GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxHeight");
			GUIScrollGroup.NativeFieldInfoPtr_clientWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientWidth");
			GUIScrollGroup.NativeFieldInfoPtr_clientHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientHeight");
			GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowHorizontalScroll");
			GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowVerticalScroll");
			GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsHorizontalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsVerticalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "horizontalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "verticalScrollbar");
			GUIScrollGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663694);
			GUIScrollGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663695);
			GUIScrollGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663696);
			GUIScrollGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663697);
			GUIScrollGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663698);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001317C File Offset: 0x0001137C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88237, XrefRangeEnd = 88241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIScrollGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000131B8 File Offset: 0x000113B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88241, XrefRangeEnd = 88242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000131EC File Offset: 0x000113EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88242, XrefRangeEnd = 88252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHorizontal(float x, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00013238 File Offset: 0x00011438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88252, XrefRangeEnd = 88257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001326C File Offset: 0x0001146C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88257, XrefRangeEnd = 88263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVertical(float y, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000415E File Offset: 0x0000235E
		public GUIScrollGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x000132B8 File Offset: 0x000114B8
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00004167 File Offset: 0x00002367
		public unsafe float calcMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth)) = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000132E0 File Offset: 0x000114E0
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00004182 File Offset: 0x00002382
		public unsafe float calcMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00013308 File Offset: 0x00011508
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0000419D File Offset: 0x0000239D
		public unsafe float calcMinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00013330 File Offset: 0x00011530
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x000041B8 File Offset: 0x000023B8
		public unsafe float calcMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00013358 File Offset: 0x00011558
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x000041D3 File Offset: 0x000023D3
		public unsafe float clientWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientWidth)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00013380 File Offset: 0x00011580
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x000041EE File Offset: 0x000023EE
		public unsafe float clientHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientHeight)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000133A8 File Offset: 0x000115A8
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004209 File Offset: 0x00002409
		public unsafe bool allowHorizontalScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000133D0 File Offset: 0x000115D0
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004224 File Offset: 0x00002424
		public unsafe bool allowVerticalScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000133F8 File Offset: 0x000115F8
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0000423F File Offset: 0x0000243F
		public unsafe bool needsHorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00013420 File Offset: 0x00011620
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x0000425A File Offset: 0x0000245A
		public unsafe bool needsVerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00013448 File Offset: 0x00011648
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004275 File Offset: 0x00002475
		public unsafe GUIStyle horizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00013478 File Offset: 0x00011678
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00004294 File Offset: 0x00002494
		public unsafe GUIStyle verticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr_calcMinWidth;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr_calcMaxWidth;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_calcMinHeight;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_calcMaxHeight;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr_clientWidth;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr_clientHeight;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr_allowHorizontalScroll;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_allowVerticalScroll;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_needsHorizontalScrollbar;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_needsVerticalScrollbar;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_horizontalScrollbar;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_verticalScrollbar;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0;
	}
}
