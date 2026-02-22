using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000027 RID: 39
public class AN_PlusButton : global::Il2CppSystem.Object
{
	// Token: 0x0600040E RID: 1038 RVA: 0x00024498 File Offset: 0x00022698
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PlusButton()
	{
		Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PlusButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr);
		AN_PlusButton.NativeFieldInfoPtr__ButtonId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "_ButtonId");
		AN_PlusButton.NativeFieldInfoPtr__anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "_anchor");
		AN_PlusButton.NativeFieldInfoPtr__x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "_x");
		AN_PlusButton.NativeFieldInfoPtr__y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "_y");
		AN_PlusButton.NativeFieldInfoPtr__IsShowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "_IsShowed");
		AN_PlusButton.NativeFieldInfoPtr_ButtonClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "ButtonClicked");
		AN_PlusButton.NativeFieldInfoPtr__nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "_nextId");
		AN_PlusButton.NativeMethodInfoPtr__ctor_Public_Void_String_AN_PlusBtnSize_AN_PlusBtnAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663753);
		AN_PlusButton.NativeMethodInfoPtr_SetGravity_Public_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663754);
		AN_PlusButton.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663755);
		AN_PlusButton.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663756);
		AN_PlusButton.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663757);
		AN_PlusButton.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663758);
		AN_PlusButton.NativeMethodInfoPtr_get_ButtonId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663759);
		AN_PlusButton.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663760);
		AN_PlusButton.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663761);
		AN_PlusButton.NativeMethodInfoPtr_get_IsShowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663762);
		AN_PlusButton.NativeMethodInfoPtr_get_anchor_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663763);
		AN_PlusButton.NativeMethodInfoPtr_get_gravity_Public_get_GoogleGravity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663764);
		AN_PlusButton.NativeMethodInfoPtr_FireClickAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663765);
		AN_PlusButton.NativeMethodInfoPtr_get_nextId_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, 100663766);
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x0002466C File Offset: 0x0002286C
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 163233, RefRangeEnd = 163243, XrefRangeStart = 163199, XrefRangeEnd = 163233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PlusButton(string url, AN_PlusBtnSize btnSize, AN_PlusBtnAnnotation annotation)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref btnSize;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref annotation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr__ctor_Public_Void_String_AN_PlusBtnSize_AN_PlusBtnAnnotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x000246D4 File Offset: 0x000228D4
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 163264, RefRangeEnd = 163272, XrefRangeStart = 163243, XrefRangeEnd = 163264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGravity(TextAnchor btnAnchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref btnAnchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_SetGravity_Public_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00024714 File Offset: 0x00022914
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 163273, RefRangeEnd = 163277, XrefRangeStart = 163272, XrefRangeEnd = 163273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPosition(int btnX, int btnY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref btnX;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref btnY;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00024760 File Offset: 0x00022960
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163286, RefRangeEnd = 163288, XrefRangeStart = 163277, XrefRangeEnd = 163286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00024794 File Offset: 0x00022994
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 163297, RefRangeEnd = 163301, XrefRangeStart = 163288, XrefRangeEnd = 163297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x000247C8 File Offset: 0x000229C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 163310, RefRangeEnd = 163311, XrefRangeStart = 163301, XrefRangeEnd = 163310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000415 RID: 1045 RVA: 0x000247FC File Offset: 0x000229FC
	public unsafe int ButtonId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_get_ButtonId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000416 RID: 1046 RVA: 0x00024838 File Offset: 0x00022A38
	public unsafe int x
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_get_x_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000417 RID: 1047 RVA: 0x00024874 File Offset: 0x00022A74
	public unsafe int y
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_get_y_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000418 RID: 1048 RVA: 0x000248B0 File Offset: 0x00022AB0
	public unsafe bool IsShowed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_get_IsShowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000419 RID: 1049 RVA: 0x000248EC File Offset: 0x00022AEC
	public unsafe TextAnchor anchor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_get_anchor_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x0600041A RID: 1050 RVA: 0x00024928 File Offset: 0x00022B28
	public unsafe GoogleGravity gravity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_get_gravity_Public_get_GoogleGravity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00024964 File Offset: 0x00022B64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FireClickAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_FireClickAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00024998 File Offset: 0x00022B98
	public unsafe static int nextId
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163311, XrefRangeEnd = 163316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.NativeMethodInfoPtr_get_nextId_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00003C86 File Offset: 0x00001E86
	public AN_PlusButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x0600041E RID: 1054 RVA: 0x000249C8 File Offset: 0x00022BC8
	// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003C8F File Offset: 0x00001E8F
	public unsafe int _ButtonId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__ButtonId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__ButtonId)) = value;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000420 RID: 1056 RVA: 0x000249F0 File Offset: 0x00022BF0
	// (set) Token: 0x06000421 RID: 1057 RVA: 0x00003CAA File Offset: 0x00001EAA
	public unsafe TextAnchor _anchor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__anchor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__anchor)) = value;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000422 RID: 1058 RVA: 0x00024A18 File Offset: 0x00022C18
	// (set) Token: 0x06000423 RID: 1059 RVA: 0x00003CC5 File Offset: 0x00001EC5
	public unsafe int _x
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__x);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__x)) = value;
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000424 RID: 1060 RVA: 0x00024A40 File Offset: 0x00022C40
	// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003CE0 File Offset: 0x00001EE0
	public unsafe int _y
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__y);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__y)) = value;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000426 RID: 1062 RVA: 0x00024A68 File Offset: 0x00022C68
	// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003CFB File Offset: 0x00001EFB
	public unsafe bool _IsShowed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__IsShowed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr__IsShowed)) = value;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000428 RID: 1064 RVA: 0x00024A90 File Offset: 0x00022C90
	// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003D16 File Offset: 0x00001F16
	public unsafe Action ButtonClicked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr_ButtonClicked);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusButton.NativeFieldInfoPtr_ButtonClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x00024AC0 File Offset: 0x00022CC0
	// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003D35 File Offset: 0x00001F35
	public unsafe static int _nextId
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AN_PlusButton.NativeFieldInfoPtr__nextId, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_PlusButton.NativeFieldInfoPtr__nextId, (void*)(&value));
		}
	}

	// Token: 0x0400030F RID: 783
	private static readonly IntPtr NativeFieldInfoPtr__ButtonId;

	// Token: 0x04000310 RID: 784
	private static readonly IntPtr NativeFieldInfoPtr__anchor;

	// Token: 0x04000311 RID: 785
	private static readonly IntPtr NativeFieldInfoPtr__x;

	// Token: 0x04000312 RID: 786
	private static readonly IntPtr NativeFieldInfoPtr__y;

	// Token: 0x04000313 RID: 787
	private static readonly IntPtr NativeFieldInfoPtr__IsShowed;

	// Token: 0x04000314 RID: 788
	private static readonly IntPtr NativeFieldInfoPtr_ButtonClicked;

	// Token: 0x04000315 RID: 789
	private static readonly IntPtr NativeFieldInfoPtr__nextId;

	// Token: 0x04000316 RID: 790
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AN_PlusBtnSize_AN_PlusBtnAnnotation_0;

	// Token: 0x04000317 RID: 791
	private static readonly IntPtr NativeMethodInfoPtr_SetGravity_Public_Void_TextAnchor_0;

	// Token: 0x04000318 RID: 792
	private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Int32_0;

	// Token: 0x04000319 RID: 793
	private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

	// Token: 0x0400031A RID: 794
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	// Token: 0x0400031B RID: 795
	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

	// Token: 0x0400031C RID: 796
	private static readonly IntPtr NativeMethodInfoPtr_get_ButtonId_Public_get_Int32_0;

	// Token: 0x0400031D RID: 797
	private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

	// Token: 0x0400031E RID: 798
	private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

	// Token: 0x0400031F RID: 799
	private static readonly IntPtr NativeMethodInfoPtr_get_IsShowed_Public_get_Boolean_0;

	// Token: 0x04000320 RID: 800
	private static readonly IntPtr NativeMethodInfoPtr_get_anchor_Public_get_TextAnchor_0;

	// Token: 0x04000321 RID: 801
	private static readonly IntPtr NativeMethodInfoPtr_get_gravity_Public_get_GoogleGravity_0;

	// Token: 0x04000322 RID: 802
	private static readonly IntPtr NativeMethodInfoPtr_FireClickAction_Public_Void_0;

	// Token: 0x04000323 RID: 803
	private static readonly IntPtr NativeMethodInfoPtr_get_nextId_Private_Static_get_Int32_0;

	// Token: 0x0200036A RID: 874
	[ObfuscatedName("AN_PlusButton+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600347B RID: 13435 RVA: 0x000D9048 File Offset: 0x000D7248
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AN_PlusButton.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AN_PlusButton>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PlusButton.__c>.NativeClassPtr);
			AN_PlusButton.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton.__c>.NativeClassPtr, "<>9");
			AN_PlusButton.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButton.__c>.NativeClassPtr, "<>9__6_0");
			AN_PlusButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton.__c>.NativeClassPtr, 100669973);
			AN_PlusButton.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButton.__c>.NativeClassPtr, 100669974);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x000D90C4 File Offset: 0x000D72C4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusButton.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000D9100 File Offset: 0x000D7300
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButton.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000147D5 File Offset: 0x000129D5
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x000D9134 File Offset: 0x000D7334
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x000147DE File Offset: 0x000129DE
		public unsafe static AN_PlusButton.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_PlusButton.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_PlusButton.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_PlusButton.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06003481 RID: 13441 RVA: 0x000D915C File Offset: 0x000D735C
		// (set) Token: 0x06003482 RID: 13442 RVA: 0x000147F0 File Offset: 0x000129F0
		public unsafe static Action __9__6_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_PlusButton.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_PlusButton.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_0;
	}
}
