using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public sealed class FaceInfo : ValueType
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000033BC File Offset: 0x000015BC
		// Note: this type is marked as 'beforefieldinit'.
		static FaceInfo()
		{
			Il2CppClassPointerStore<FaceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore", "FaceInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr);
			FaceInfo.NativeFieldInfoPtr_m_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_FaceIndex");
			FaceInfo.NativeFieldInfoPtr_m_FamilyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_FamilyName");
			FaceInfo.NativeFieldInfoPtr_m_StyleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StyleName");
			FaceInfo.NativeFieldInfoPtr_m_PointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_PointSize");
			FaceInfo.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_Scale");
			FaceInfo.NativeFieldInfoPtr_m_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_LineHeight");
			FaceInfo.NativeFieldInfoPtr_m_AscentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_AscentLine");
			FaceInfo.NativeFieldInfoPtr_m_CapLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_CapLine");
			FaceInfo.NativeFieldInfoPtr_m_MeanLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_MeanLine");
			FaceInfo.NativeFieldInfoPtr_m_Baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_Baseline");
			FaceInfo.NativeFieldInfoPtr_m_DescentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_DescentLine");
			FaceInfo.NativeFieldInfoPtr_m_SuperscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SuperscriptOffset");
			FaceInfo.NativeFieldInfoPtr_m_SuperscriptSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SuperscriptSize");
			FaceInfo.NativeFieldInfoPtr_m_SubscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SubscriptOffset");
			FaceInfo.NativeFieldInfoPtr_m_SubscriptSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SubscriptSize");
			FaceInfo.NativeFieldInfoPtr_m_UnderlineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnderlineOffset");
			FaceInfo.NativeFieldInfoPtr_m_UnderlineThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnderlineThickness");
			FaceInfo.NativeFieldInfoPtr_m_StrikethroughOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StrikethroughOffset");
			FaceInfo.NativeFieldInfoPtr_m_StrikethroughThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StrikethroughThickness");
			FaceInfo.NativeFieldInfoPtr_m_TabWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_TabWidth");
			FaceInfo.NativeMethodInfoPtr_set_familyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663297);
			FaceInfo.NativeMethodInfoPtr_set_styleName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663298);
			FaceInfo.NativeMethodInfoPtr_get_pointSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663299);
			FaceInfo.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663300);
			FaceInfo.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663301);
			FaceInfo.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663302);
			FaceInfo.NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663303);
			FaceInfo.NativeMethodInfoPtr_set_lineHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663304);
			FaceInfo.NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663305);
			FaceInfo.NativeMethodInfoPtr_set_ascentLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663306);
			FaceInfo.NativeMethodInfoPtr_get_capLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663307);
			FaceInfo.NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663308);
			FaceInfo.NativeMethodInfoPtr_get_meanLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663309);
			FaceInfo.NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663310);
			FaceInfo.NativeMethodInfoPtr_get_baseline_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663311);
			FaceInfo.NativeMethodInfoPtr_set_baseline_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663312);
			FaceInfo.NativeMethodInfoPtr_get_descentLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663313);
			FaceInfo.NativeMethodInfoPtr_set_descentLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663314);
			FaceInfo.NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663315);
			FaceInfo.NativeMethodInfoPtr_set_superscriptOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663316);
			FaceInfo.NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663317);
			FaceInfo.NativeMethodInfoPtr_set_superscriptSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663318);
			FaceInfo.NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663319);
			FaceInfo.NativeMethodInfoPtr_set_subscriptOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663320);
			FaceInfo.NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663321);
			FaceInfo.NativeMethodInfoPtr_set_subscriptSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663322);
			FaceInfo.NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663323);
			FaceInfo.NativeMethodInfoPtr_set_underlineOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663324);
			FaceInfo.NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663325);
			FaceInfo.NativeMethodInfoPtr_set_underlineThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663326);
			FaceInfo.NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663327);
			FaceInfo.NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663328);
			FaceInfo.NativeMethodInfoPtr_set_strikethroughThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663329);
			FaceInfo.NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663330);
			FaceInfo.NativeMethodInfoPtr_set_tabWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663331);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000044C4 File Offset: 0x000026C4
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00003838 File Offset: 0x00001A38
		public unsafe string familyName
		{
			get
			{
				return this.m_FamilyName;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88837, RefRangeEnd = 88838, XrefRangeStart = 88837, XrefRangeEnd = 88837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_familyName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000044DC File Offset: 0x000026DC
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00003880 File Offset: 0x00001A80
		public unsafe string styleName
		{
			get
			{
				return this.m_StyleName;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_styleName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000038C8 File Offset: 0x00001AC8
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000390C File Offset: 0x00001B0C
		public unsafe int pointSize
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 88838, RefRangeEnd = 88870, XrefRangeStart = 88838, XrefRangeEnd = 88838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_pointSize_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00003950 File Offset: 0x00001B50
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00003994 File Offset: 0x00001B94
		public unsafe float scale
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 88870, RefRangeEnd = 88902, XrefRangeStart = 88870, XrefRangeEnd = 88870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88902, RefRangeEnd = 88904, XrefRangeStart = 88902, XrefRangeEnd = 88902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00003A1C File Offset: 0x00001C1C
		public unsafe float lineHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 88904, RefRangeEnd = 88907, XrefRangeStart = 88904, XrefRangeEnd = 88904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88907, RefRangeEnd = 88908, XrefRangeStart = 88907, XrefRangeEnd = 88907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_lineHeight_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00003A60 File Offset: 0x00001C60
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public unsafe float ascentLine
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 79936, RefRangeEnd = 79952, XrefRangeStart = 79936, XrefRangeEnd = 79952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88908, RefRangeEnd = 88909, XrefRangeStart = 88908, XrefRangeEnd = 88908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_ascentLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00003AE8 File Offset: 0x00001CE8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00003B2C File Offset: 0x00001D2C
		public unsafe float capLine
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 88909, RefRangeEnd = 88914, XrefRangeStart = 88909, XrefRangeEnd = 88909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_capLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88914, RefRangeEnd = 88916, XrefRangeStart = 88914, XrefRangeEnd = 88914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00003B70 File Offset: 0x00001D70
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public unsafe float meanLine
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83380, RefRangeEnd = 83382, XrefRangeStart = 83380, XrefRangeEnd = 83382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_meanLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88916, RefRangeEnd = 88918, XrefRangeStart = 88916, XrefRangeEnd = 88916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00003C3C File Offset: 0x00001E3C
		public unsafe float baseline
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 88918, RefRangeEnd = 88924, XrefRangeStart = 88918, XrefRangeEnd = 88918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_baseline_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88924, RefRangeEnd = 88925, XrefRangeStart = 88924, XrefRangeEnd = 88924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_baseline_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00003C80 File Offset: 0x00001E80
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00003CC4 File Offset: 0x00001EC4
		public unsafe float descentLine
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 83384, RefRangeEnd = 83397, XrefRangeStart = 83384, XrefRangeEnd = 83397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_descentLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88925, RefRangeEnd = 88926, XrefRangeStart = 88925, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_descentLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00003D08 File Offset: 0x00001F08
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00003D4C File Offset: 0x00001F4C
		public unsafe float superscriptOffset
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 83397, RefRangeEnd = 83412, XrefRangeStart = 83397, XrefRangeEnd = 83412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 88926, RefRangeEnd = 88931, XrefRangeStart = 88926, XrefRangeEnd = 88926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_superscriptOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003D90 File Offset: 0x00001F90
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public unsafe float superscriptSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83382, RefRangeEnd = 83383, XrefRangeStart = 83382, XrefRangeEnd = 83383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88931, RefRangeEnd = 88932, XrefRangeStart = 88931, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_superscriptSize_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003E18 File Offset: 0x00002018
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00003E5C File Offset: 0x0000205C
		public unsafe float subscriptOffset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83383, RefRangeEnd = 83384, XrefRangeStart = 83383, XrefRangeEnd = 83384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88932, RefRangeEnd = 88933, XrefRangeStart = 88932, XrefRangeEnd = 88932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_subscriptOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003EE4 File Offset: 0x000020E4
		public unsafe float subscriptSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88933, RefRangeEnd = 88934, XrefRangeStart = 88933, XrefRangeEnd = 88933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_subscriptSize_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003F28 File Offset: 0x00002128
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003F6C File Offset: 0x0000216C
		public unsafe float underlineOffset
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88934, RefRangeEnd = 88936, XrefRangeStart = 88934, XrefRangeEnd = 88934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88936, RefRangeEnd = 88937, XrefRangeStart = 88936, XrefRangeEnd = 88936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_underlineOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003FB0 File Offset: 0x000021B0
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003FF4 File Offset: 0x000021F4
		public unsafe float underlineThickness
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88937, RefRangeEnd = 88938, XrefRangeStart = 88937, XrefRangeEnd = 88937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88938, RefRangeEnd = 88939, XrefRangeStart = 88938, XrefRangeEnd = 88938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_underlineThickness_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000407C File Offset: 0x0000227C
		public unsafe float strikethroughOffset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 88939, RefRangeEnd = 88942, XrefRangeStart = 88939, XrefRangeEnd = 88939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88942, RefRangeEnd = 88944, XrefRangeStart = 88942, XrefRangeEnd = 88942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000044F4 File Offset: 0x000026F4
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000040C0 File Offset: 0x000022C0
		public unsafe float strikethroughThickness
		{
			get
			{
				return this.m_StrikethroughThickness;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88944, RefRangeEnd = 88945, XrefRangeStart = 88944, XrefRangeEnd = 88944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_strikethroughThickness_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00004104 File Offset: 0x00002304
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00004148 File Offset: 0x00002348
		public unsafe float tabWidth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 88945, RefRangeEnd = 88948, XrefRangeStart = 88945, XrefRangeEnd = 88945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88948, RefRangeEnd = 88949, XrefRangeStart = 88948, XrefRangeEnd = 88948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceInfo.NativeMethodInfoPtr_set_tabWidth_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		public FaceInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002059 File Offset: 0x00000259
		public FaceInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000418C File Offset: 0x0000238C
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe int m_FaceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FaceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FaceIndex)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000041B4 File Offset: 0x000023B4
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe string m_FamilyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FamilyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_FamilyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000041DC File Offset: 0x000023DC
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe string m_StyleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StyleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StyleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004204 File Offset: 0x00002404
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000020C4 File Offset: 0x000002C4
		public unsafe int m_PointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_PointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_PointSize)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000422C File Offset: 0x0000242C
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000020DF File Offset: 0x000002DF
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004254 File Offset: 0x00002454
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000020FA File Offset: 0x000002FA
		public unsafe float m_LineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_LineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_LineHeight)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000427C File Offset: 0x0000247C
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002115 File Offset: 0x00000315
		public unsafe float m_AscentLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_AscentLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_AscentLine)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000042A4 File Offset: 0x000024A4
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002130 File Offset: 0x00000330
		public unsafe float m_CapLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_CapLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_CapLine)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000042CC File Offset: 0x000024CC
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000214B File Offset: 0x0000034B
		public unsafe float m_MeanLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_MeanLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_MeanLine)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000042F4 File Offset: 0x000024F4
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002166 File Offset: 0x00000366
		public unsafe float m_Baseline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Baseline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_Baseline)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000431C File Offset: 0x0000251C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002181 File Offset: 0x00000381
		public unsafe float m_DescentLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_DescentLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_DescentLine)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00004344 File Offset: 0x00002544
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000219C File Offset: 0x0000039C
		public unsafe float m_SuperscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptOffset)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000436C File Offset: 0x0000256C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021B7 File Offset: 0x000003B7
		public unsafe float m_SuperscriptSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SuperscriptSize)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004394 File Offset: 0x00002594
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000021D2 File Offset: 0x000003D2
		public unsafe float m_SubscriptOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptOffset)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000043BC File Offset: 0x000025BC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000021ED File Offset: 0x000003ED
		public unsafe float m_SubscriptSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_SubscriptSize)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000043E4 File Offset: 0x000025E4
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002208 File Offset: 0x00000408
		public unsafe float m_UnderlineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineOffset)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000440C File Offset: 0x0000260C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002223 File Offset: 0x00000423
		public unsafe float m_UnderlineThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_UnderlineThickness)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00004434 File Offset: 0x00002634
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000223E File Offset: 0x0000043E
		public unsafe float m_StrikethroughOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughOffset)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000445C File Offset: 0x0000265C
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002259 File Offset: 0x00000459
		public unsafe float m_StrikethroughThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_StrikethroughThickness)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00004484 File Offset: 0x00002684
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002274 File Offset: 0x00000474
		public unsafe float m_TabWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_TabWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceInfo.NativeFieldInfoPtr_m_TabWidth)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000044AC File Offset: 0x000026AC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000228F File Offset: 0x0000048F
		public int faceIndex
		{
			get
			{
				return this.m_FaceIndex;
			}
			set
			{
				this.m_FaceIndex = value;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000450C File Offset: 0x0000270C
		public bool Compare(FaceInfo other)
		{
			return this.familyName == other.familyName && this.styleName == other.styleName && this.faceIndex == other.faceIndex && this.pointSize == other.pointSize && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.scale, other.scale) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.lineHeight, other.lineHeight) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.ascentLine, other.ascentLine) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.capLine, other.capLine) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.meanLine, other.meanLine) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.baseline, other.baseline) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.descentLine, other.descentLine) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.superscriptOffset, other.superscriptOffset) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.superscriptSize, other.superscriptSize) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.subscriptOffset, other.subscriptOffset) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.subscriptSize, other.subscriptSize) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.underlineOffset, other.underlineOffset) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.underlineThickness, other.underlineThickness) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.strikethroughOffset, other.strikethroughOffset) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.strikethroughThickness, other.strikethroughThickness) && UnityEngine.TextCore.LowLevel.FontEngineUtilities.Approximately(this.tabWidth, other.tabWidth);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceIndex;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_FamilyName;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleName;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_m_PointSize;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_LineHeight;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_m_AscentLine;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_m_CapLine;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_MeanLine;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_Baseline;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_DescentLine;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_m_SuperscriptOffset;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_m_SuperscriptSize;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_m_SubscriptOffset;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_m_SubscriptSize;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_m_UnderlineOffset;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_UnderlineThickness;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_m_StrikethroughOffset;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_m_StrikethroughThickness;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_m_TabWidth;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_familyName_Public_set_Void_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_styleName_Public_set_Void_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_pointSize_Public_get_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_set_pointSize_Public_set_Void_Int32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_set_lineHeight_Public_set_Void_Single_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_set_ascentLine_Public_set_Void_Single_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_capLine_Public_get_Single_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_meanLine_Public_get_Single_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_baseline_Public_get_Single_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_set_baseline_Public_set_Void_Single_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_descentLine_Public_get_Single_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_set_descentLine_Public_set_Void_Single_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_superscriptOffset_Public_set_Void_Single_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_superscriptSize_Public_set_Void_Single_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_set_subscriptOffset_Public_set_Void_Single_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_set_subscriptSize_Public_set_Void_Single_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_set_underlineOffset_Public_set_Void_Single_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_set_underlineThickness_Public_set_Void_Single_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_set_strikethroughThickness_Public_set_Void_Single_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_set_tabWidth_Public_set_Void_Single_0;
	}
}
