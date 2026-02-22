using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000043 RID: 67
public class TutorialPanelLayout : global::Il2CppSystem.Object
{
	// Token: 0x06000B8A RID: 2954 RVA: 0x0003BC04 File Offset: 0x00039E04
	// Note: this type is marked as 'beforefieldinit'.
	static TutorialPanelLayout()
	{
		Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TutorialPanelLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr);
		TutorialPanelLayout.NativeFieldInfoPtr_m_AnchorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr, "m_AnchorMin");
		TutorialPanelLayout.NativeFieldInfoPtr_m_AnchorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr, "m_AnchorMax");
		TutorialPanelLayout.NativeFieldInfoPtr_m_AnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr, "m_AnchoredPosition");
		TutorialPanelLayout.NativeFieldInfoPtr_m_SizeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr, "m_SizeDelta");
		TutorialPanelLayout.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr, 100664090);
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x0003BC98 File Offset: 0x00039E98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237512, XrefRangeEnd = 237513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialPanelLayout(float anchorMinX, float anchorMinY, float anchorMaxX, float anchorMaxY, float anchoredPositionX, float anchoredPositionY, float sizeDeltaX, float sizeDeltaY)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPanelLayout>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref anchorMinX;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorMinY;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorMaxX;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorMaxY;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchoredPositionX;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchoredPositionY;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeDeltaX;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeDeltaY;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPanelLayout.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x000090EA File Offset: 0x000072EA
	public TutorialPanelLayout(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0003BD44 File Offset: 0x00039F44
	// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000090F3 File Offset: 0x000072F3
	public unsafe Vector2 m_AnchorMin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_AnchorMin);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_AnchorMin)) = value;
		}
	}

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0003BD6C File Offset: 0x00039F6C
	// (set) Token: 0x06000B90 RID: 2960 RVA: 0x0000910E File Offset: 0x0000730E
	public unsafe Vector2 m_AnchorMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_AnchorMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_AnchorMax)) = value;
		}
	}

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0003BD94 File Offset: 0x00039F94
	// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00009129 File Offset: 0x00007329
	public unsafe Vector2 m_AnchoredPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_AnchoredPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_AnchoredPosition)) = value;
		}
	}

	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0003BDBC File Offset: 0x00039FBC
	// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00009144 File Offset: 0x00007344
	public unsafe Vector2 m_SizeDelta
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_SizeDelta);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPanelLayout.NativeFieldInfoPtr_m_SizeDelta)) = value;
		}
	}

	// Token: 0x04000730 RID: 1840
	private static readonly IntPtr NativeFieldInfoPtr_m_AnchorMin;

	// Token: 0x04000731 RID: 1841
	private static readonly IntPtr NativeFieldInfoPtr_m_AnchorMax;

	// Token: 0x04000732 RID: 1842
	private static readonly IntPtr NativeFieldInfoPtr_m_AnchoredPosition;

	// Token: 0x04000733 RID: 1843
	private static readonly IntPtr NativeFieldInfoPtr_m_SizeDelta;

	// Token: 0x04000734 RID: 1844
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0;
}
