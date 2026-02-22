using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Animation;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000140 RID: 320
public class SA_InApps_EditorUIController : MonoBehaviour
{
	// Token: 0x060017AC RID: 6060 RVA: 0x0006892C File Offset: 0x00066B2C
	// Note: this type is marked as 'beforefieldinit'.
	static SA_InApps_EditorUIController()
	{
		Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_InApps_EditorUIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr);
		SA_InApps_EditorUIController.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "Title");
		SA_InApps_EditorUIController.NativeFieldInfoPtr_Describtion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "Describtion");
		SA_InApps_EditorUIController.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "Price");
		SA_InApps_EditorUIController.NativeFieldInfoPtr_IsSuccsesPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "IsSuccsesPurchase");
		SA_InApps_EditorUIController.NativeFieldInfoPtr_Fader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "Fader");
		SA_InApps_EditorUIController.NativeFieldInfoPtr_HightDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "HightDependence");
		SA_InApps_EditorUIController.NativeFieldInfoPtr__CurrentTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "_CurrentTween");
		SA_InApps_EditorUIController.NativeFieldInfoPtr__FaderTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "_FaderTween");
		SA_InApps_EditorUIController.NativeFieldInfoPtr__OnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, "_OnComplete");
		SA_InApps_EditorUIController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666173);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_ShowInAppPopup_Public_Void_String_String_String_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666174);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666175);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnInTweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666176);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnOutTweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666177);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666178);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnFadeValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666179);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleFadeComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666180);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_FadeIn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666181);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_FadeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666182);
		SA_InApps_EditorUIController.NativeMethodInfoPtr_Animate_Private_Void_Single_Single_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666183);
		SA_InApps_EditorUIController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr, 100666184);
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x00068B00 File Offset: 0x00066D00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194472, XrefRangeEnd = 194482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00068B34 File Offset: 0x00066D34
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194512, RefRangeEnd = 194514, XrefRangeStart = 194482, XrefRangeEnd = 194512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInAppPopup(string title, string describtion, string price, Action<bool> OnComplete = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(describtion);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(price);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnComplete);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_ShowInAppPopup_Public_Void_String_String_String_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x00068BB0 File Offset: 0x00066DB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194514, XrefRangeEnd = 194552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00068BE4 File Offset: 0x00066DE4
	[CallerCount(0)]
	public unsafe void HandleOnInTweenComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnInTweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00068C18 File Offset: 0x00066E18
	[CallerCount(0)]
	public unsafe void HandleOnOutTweenComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnOutTweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00068C4C File Offset: 0x00066E4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194552, XrefRangeEnd = 194554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnValueChanged(float pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00068C8C File Offset: 0x00066E8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194554, XrefRangeEnd = 194555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnFadeValueChanged(float a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleOnFadeValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00068CCC File Offset: 0x00066ECC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194555, XrefRangeEnd = 194557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleFadeComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_HandleFadeComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x00068D00 File Offset: 0x00066F00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194557, XrefRangeEnd = 194569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeIn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_FadeIn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00068D34 File Offset: 0x00066F34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194569, XrefRangeEnd = 194587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_FadeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00068D68 File Offset: 0x00066F68
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194598, RefRangeEnd = 194600, XrefRangeStart = 194587, XrefRangeEnd = 194598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Animate(float from, float to, EaseType easeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref from;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr_Animate_Private_Void_Single_Single_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00068DC4 File Offset: 0x00066FC4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_InApps_EditorUIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_InApps_EditorUIController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_InApps_EditorUIController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x0000B683 File Offset: 0x00009883
	public SA_InApps_EditorUIController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x060017BA RID: 6074 RVA: 0x00068E00 File Offset: 0x00067000
	// (set) Token: 0x060017BB RID: 6075 RVA: 0x0000B68C File Offset: 0x0000988C
	public unsafe Text Title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Title);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x060017BC RID: 6076 RVA: 0x00068E30 File Offset: 0x00067030
	// (set) Token: 0x060017BD RID: 6077 RVA: 0x0000B6AB File Offset: 0x000098AB
	public unsafe Text Describtion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Describtion);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Describtion), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x060017BE RID: 6078 RVA: 0x00068E60 File Offset: 0x00067060
	// (set) Token: 0x060017BF RID: 6079 RVA: 0x0000B6CA File Offset: 0x000098CA
	public unsafe Text Price
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Price);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Price), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00068E90 File Offset: 0x00067090
	// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0000B6E9 File Offset: 0x000098E9
	public unsafe Toggle IsSuccsesPurchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_IsSuccsesPurchase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_IsSuccsesPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00068EC0 File Offset: 0x000670C0
	// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0000B708 File Offset: 0x00009908
	public unsafe Image Fader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Fader);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_Fader), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00068EF0 File Offset: 0x000670F0
	// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000B727 File Offset: 0x00009927
	public unsafe SA_UIHightDependence HightDependence
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_HightDependence);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_UIHightDependence>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr_HightDependence), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00068F20 File Offset: 0x00067120
	// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000B746 File Offset: 0x00009946
	public unsafe ValuesTween _CurrentTween
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr__CurrentTween);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValuesTween>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr__CurrentTween), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00068F50 File Offset: 0x00067150
	// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000B765 File Offset: 0x00009965
	public unsafe ValuesTween _FaderTween
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr__FaderTween);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValuesTween>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr__FaderTween), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x060017CA RID: 6090 RVA: 0x00068F80 File Offset: 0x00067180
	// (set) Token: 0x060017CB RID: 6091 RVA: 0x0000B784 File Offset: 0x00009984
	public unsafe Action<bool> _OnComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr__OnComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_InApps_EditorUIController.NativeFieldInfoPtr__OnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040011E9 RID: 4585
	private static readonly IntPtr NativeFieldInfoPtr_Title;

	// Token: 0x040011EA RID: 4586
	private static readonly IntPtr NativeFieldInfoPtr_Describtion;

	// Token: 0x040011EB RID: 4587
	private static readonly IntPtr NativeFieldInfoPtr_Price;

	// Token: 0x040011EC RID: 4588
	private static readonly IntPtr NativeFieldInfoPtr_IsSuccsesPurchase;

	// Token: 0x040011ED RID: 4589
	private static readonly IntPtr NativeFieldInfoPtr_Fader;

	// Token: 0x040011EE RID: 4590
	private static readonly IntPtr NativeFieldInfoPtr_HightDependence;

	// Token: 0x040011EF RID: 4591
	private static readonly IntPtr NativeFieldInfoPtr__CurrentTween;

	// Token: 0x040011F0 RID: 4592
	private static readonly IntPtr NativeFieldInfoPtr__FaderTween;

	// Token: 0x040011F1 RID: 4593
	private static readonly IntPtr NativeFieldInfoPtr__OnComplete;

	// Token: 0x040011F2 RID: 4594
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040011F3 RID: 4595
	private static readonly IntPtr NativeMethodInfoPtr_ShowInAppPopup_Public_Void_String_String_String_Action_1_Boolean_0;

	// Token: 0x040011F4 RID: 4596
	private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

	// Token: 0x040011F5 RID: 4597
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnInTweenComplete_Private_Void_0;

	// Token: 0x040011F6 RID: 4598
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnOutTweenComplete_Private_Void_0;

	// Token: 0x040011F7 RID: 4599
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnValueChanged_Private_Void_Single_0;

	// Token: 0x040011F8 RID: 4600
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnFadeValueChanged_Private_Void_Single_0;

	// Token: 0x040011F9 RID: 4601
	private static readonly IntPtr NativeMethodInfoPtr_HandleFadeComplete_Private_Void_0;

	// Token: 0x040011FA RID: 4602
	private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Private_Void_0;

	// Token: 0x040011FB RID: 4603
	private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Private_Void_0;

	// Token: 0x040011FC RID: 4604
	private static readonly IntPtr NativeMethodInfoPtr_Animate_Private_Void_Single_Single_EaseType_0;

	// Token: 0x040011FD RID: 4605
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
