using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x020000FE RID: 254
public class SA_BackButton : DefaultPreviewButton
{
	// Token: 0x06001193 RID: 4499 RVA: 0x00054510 File Offset: 0x00052710
	// Note: this type is marked as 'beforefieldinit'.
	static SA_BackButton()
	{
		Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_BackButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr);
		SA_BackButton.NativeFieldInfoPtr_firstLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr, "firstLevel");
		SA_BackButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr, 100665433);
		SA_BackButton.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr, 100665434);
		SA_BackButton.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr, 100665435);
		SA_BackButton.NativeMethodInfoPtr_GoBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr, 100665436);
		SA_BackButton.NativeMethodInfoPtr_get_LevelName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr, 100665437);
		SA_BackButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr, 100665438);
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x000545CC File Offset: 0x000527CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181767, XrefRangeEnd = 181792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BackButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00054600 File Offset: 0x00052800
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181792, XrefRangeEnd = 181816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BackButton.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00054634 File Offset: 0x00052834
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181816, XrefRangeEnd = 181832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_BackButton.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00054670 File Offset: 0x00052870
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181832, XrefRangeEnd = 181847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BackButton.NativeMethodInfoPtr_GoBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06001198 RID: 4504 RVA: 0x000546A4 File Offset: 0x000528A4
	public unsafe string LevelName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181847, XrefRangeEnd = 181852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BackButton.NativeMethodInfoPtr_get_LevelName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x000546DC File Offset: 0x000528DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181852, XrefRangeEnd = 181853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_BackButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_BackButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_BackButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00008C42 File Offset: 0x00006E42
	public SA_BackButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x0600119B RID: 4507 RVA: 0x00054718 File Offset: 0x00052918
	// (set) Token: 0x0600119C RID: 4508 RVA: 0x00008C4B File Offset: 0x00006E4B
	public unsafe static string firstLevel
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_BackButton.NativeFieldInfoPtr_firstLevel, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_BackButton.NativeFieldInfoPtr_firstLevel, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D98 RID: 3480
	private static readonly IntPtr NativeFieldInfoPtr_firstLevel;

	// Token: 0x04000D99 RID: 3481
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000D9A RID: 3482
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000D9B RID: 3483
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0;

	// Token: 0x04000D9C RID: 3484
	private static readonly IntPtr NativeMethodInfoPtr_GoBack_Private_Void_0;

	// Token: 0x04000D9D RID: 3485
	private static readonly IntPtr NativeMethodInfoPtr_get_LevelName_Public_get_String_0;

	// Token: 0x04000D9E RID: 3486
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
