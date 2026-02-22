using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class FaceInfo_Legacy : Object
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x0001AD90 File Offset: 0x00018F90
		// Note: this type is marked as 'beforefieldinit'.
		static FaceInfo_Legacy()
		{
			Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FaceInfo_Legacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr);
			FaceInfo_Legacy.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Name");
			FaceInfo_Legacy.NativeFieldInfoPtr_PointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "PointSize");
			FaceInfo_Legacy.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Scale");
			FaceInfo_Legacy.NativeFieldInfoPtr_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CharacterCount");
			FaceInfo_Legacy.NativeFieldInfoPtr_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "LineHeight");
			FaceInfo_Legacy.NativeFieldInfoPtr_Baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Baseline");
			FaceInfo_Legacy.NativeFieldInfoPtr_Ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Ascender");
			FaceInfo_Legacy.NativeFieldInfoPtr_CapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CapHeight");
			FaceInfo_Legacy.NativeFieldInfoPtr_Descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Descender");
			FaceInfo_Legacy.NativeFieldInfoPtr_CenterLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CenterLine");
			FaceInfo_Legacy.NativeFieldInfoPtr_SuperscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SuperscriptOffset");
			FaceInfo_Legacy.NativeFieldInfoPtr_SubscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SubscriptOffset");
			FaceInfo_Legacy.NativeFieldInfoPtr_SubSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SubSize");
			FaceInfo_Legacy.NativeFieldInfoPtr_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Underline");
			FaceInfo_Legacy.NativeFieldInfoPtr_UnderlineThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "UnderlineThickness");
			FaceInfo_Legacy.NativeFieldInfoPtr_strikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "strikethrough");
			FaceInfo_Legacy.NativeFieldInfoPtr_strikethroughThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "strikethroughThickness");
			FaceInfo_Legacy.NativeFieldInfoPtr_TabWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "TabWidth");
			FaceInfo_Legacy.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Padding");
			FaceInfo_Legacy.NativeFieldInfoPtr_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "AtlasWidth");
			FaceInfo_Legacy.NativeFieldInfoPtr_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "AtlasHeight");
			FaceInfo_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, 100663807);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001AF78 File Offset: 0x00019178
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceInfo_Legacy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00004869 File Offset: 0x00002A69
		public FaceInfo_Legacy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001AFB4 File Offset: 0x000191B4
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00004872 File Offset: 0x00002A72
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001AFDC File Offset: 0x000191DC
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00004891 File Offset: 0x00002A91
		public unsafe float PointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_PointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_PointSize)) = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001B004 File Offset: 0x00019204
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x000048AC File Offset: 0x00002AAC
		public unsafe float Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Scale)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001B02C File Offset: 0x0001922C
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x000048C7 File Offset: 0x00002AC7
		public unsafe int CharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CharacterCount)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0001B054 File Offset: 0x00019254
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x000048E2 File Offset: 0x00002AE2
		public unsafe float LineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_LineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_LineHeight)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001B07C File Offset: 0x0001927C
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x000048FD File Offset: 0x00002AFD
		public unsafe float Baseline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Baseline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Baseline)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0001B0A4 File Offset: 0x000192A4
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00004918 File Offset: 0x00002B18
		public unsafe float Ascender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Ascender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Ascender)) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0001B0CC File Offset: 0x000192CC
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00004933 File Offset: 0x00002B33
		public unsafe float CapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CapHeight)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001B0F4 File Offset: 0x000192F4
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x0000494E File Offset: 0x00002B4E
		public unsafe float Descender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Descender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Descender)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001B11C File Offset: 0x0001931C
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00004969 File Offset: 0x00002B69
		public unsafe float CenterLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CenterLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_CenterLine)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001B144 File Offset: 0x00019344
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00004984 File Offset: 0x00002B84
		public unsafe float SuperscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SuperscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SuperscriptOffset)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001B16C File Offset: 0x0001936C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x0000499F File Offset: 0x00002B9F
		public unsafe float SubscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubscriptOffset)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001B194 File Offset: 0x00019394
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x000049BA File Offset: 0x00002BBA
		public unsafe float SubSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_SubSize)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0001B1BC File Offset: 0x000193BC
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x000049D5 File Offset: 0x00002BD5
		public unsafe float Underline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Underline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Underline)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0001B1E4 File Offset: 0x000193E4
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x000049F0 File Offset: 0x00002BF0
		public unsafe float UnderlineThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_UnderlineThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_UnderlineThickness)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0001B20C File Offset: 0x0001940C
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00004A0B File Offset: 0x00002C0B
		public unsafe float strikethrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethrough);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethrough)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0001B234 File Offset: 0x00019434
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00004A26 File Offset: 0x00002C26
		public unsafe float strikethroughThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethroughThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_strikethroughThickness)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0001B25C File Offset: 0x0001945C
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00004A41 File Offset: 0x00002C41
		public unsafe float TabWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_TabWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_TabWidth)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0001B284 File Offset: 0x00019484
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00004A5C File Offset: 0x00002C5C
		public unsafe float Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0001B2AC File Offset: 0x000194AC
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00004A77 File Offset: 0x00002C77
		public unsafe float AtlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasWidth)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0001B2D4 File Offset: 0x000194D4
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00004A92 File Offset: 0x00002C92
		public unsafe float AtlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo_Legacy.NativeFieldInfoPtr_AtlasHeight)) = value;
			}
		}

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_PointSize;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_CharacterCount;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_LineHeight;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_Baseline;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_Ascender;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_CapHeight;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_Descender;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_CenterLine;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_SuperscriptOffset;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_SubscriptOffset;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_SubSize;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_Underline;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_UnderlineThickness;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_strikethrough;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughThickness;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_TabWidth;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_AtlasWidth;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_AtlasHeight;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
