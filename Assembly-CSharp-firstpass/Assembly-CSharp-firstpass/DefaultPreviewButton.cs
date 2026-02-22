using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000F8 RID: 248
public class DefaultPreviewButton : MonoBehaviour
{
	// Token: 0x06001151 RID: 4433 RVA: 0x0005386C File Offset: 0x00051A6C
	// Note: this type is marked as 'beforefieldinit'.
	static DefaultPreviewButton()
	{
		Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DefaultPreviewButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr);
		DefaultPreviewButton.NativeFieldInfoPtr_ActionClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "ActionClick");
		DefaultPreviewButton.NativeFieldInfoPtr_normalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "normalTexture");
		DefaultPreviewButton.NativeFieldInfoPtr_pressedTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "pressedTexture");
		DefaultPreviewButton.NativeFieldInfoPtr_disabledTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "disabledTexture");
		DefaultPreviewButton.NativeFieldInfoPtr_selectedTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "selectedTexture");
		DefaultPreviewButton.NativeFieldInfoPtr_normalTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "normalTex");
		DefaultPreviewButton.NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "sound");
		DefaultPreviewButton.NativeFieldInfoPtr_disabledsound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "disabledsound");
		DefaultPreviewButton.NativeFieldInfoPtr_IsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "IsDisabled");
		DefaultPreviewButton.NativeMethodInfoPtr_add_ActionClick_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665407);
		DefaultPreviewButton.NativeMethodInfoPtr_remove_ActionClick_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665408);
		DefaultPreviewButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665409);
		DefaultPreviewButton.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665410);
		DefaultPreviewButton.NativeMethodInfoPtr_Unselect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665411);
		DefaultPreviewButton.NativeMethodInfoPtr_DisabledButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665412);
		DefaultPreviewButton.NativeMethodInfoPtr_EnabledButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665413);
		DefaultPreviewButton.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665414);
		DefaultPreviewButton.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665415);
		DefaultPreviewButton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665416);
		DefaultPreviewButton.NativeMethodInfoPtr_OnClick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665417);
		DefaultPreviewButton.NativeMethodInfoPtr_OnTimeoutPress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665418);
		DefaultPreviewButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, 100665419);
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00053A54 File Offset: 0x00051C54
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181577, RefRangeEnd = 181578, XrefRangeStart = 181573, XrefRangeEnd = 181577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionClick(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_add_ActionClick_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00053A98 File Offset: 0x00051C98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181578, XrefRangeEnd = 181582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionClick(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_remove_ActionClick_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00053ADC File Offset: 0x00051CDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181582, XrefRangeEnd = 181610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00053B10 File Offset: 0x00051D10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181610, XrefRangeEnd = 181616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00053B44 File Offset: 0x00051D44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181616, XrefRangeEnd = 181622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_Unselect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00053B78 File Offset: 0x00051D78
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 181631, RefRangeEnd = 181637, XrefRangeStart = 181622, XrefRangeEnd = 181631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisabledButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_DisabledButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00053BAC File Offset: 0x00051DAC
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 181646, RefRangeEnd = 181652, XrefRangeStart = 181637, XrefRangeEnd = 181646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnabledButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_EnabledButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x06001159 RID: 4441 RVA: 0x00053BE0 File Offset: 0x00051DE0
	// (set) Token: 0x0600115A RID: 4442 RVA: 0x00053C18 File Offset: 0x00051E18
	public unsafe string text
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181652, XrefRangeEnd = 181658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181664, RefRangeEnd = 181667, XrefRangeStart = 181658, XrefRangeEnd = 181664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00053C5C File Offset: 0x00051E5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181667, XrefRangeEnd = 181679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00053C90 File Offset: 0x00051E90
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181697, RefRangeEnd = 181698, XrefRangeStart = 181679, XrefRangeEnd = 181697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultPreviewButton.NativeMethodInfoPtr_OnClick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00053CCC File Offset: 0x00051ECC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181698, XrefRangeEnd = 181704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTimeoutPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr_OnTimeoutPress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00053D00 File Offset: 0x00051F00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181719, RefRangeEnd = 181720, XrefRangeStart = 181704, XrefRangeEnd = 181719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultPreviewButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00008A5E File Offset: 0x00006C5E
	public DefaultPreviewButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x06001160 RID: 4448 RVA: 0x00053D3C File Offset: 0x00051F3C
	// (set) Token: 0x06001161 RID: 4449 RVA: 0x00008A67 File Offset: 0x00006C67
	public unsafe Action ActionClick
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_ActionClick);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_ActionClick), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06001162 RID: 4450 RVA: 0x00053D6C File Offset: 0x00051F6C
	// (set) Token: 0x06001163 RID: 4451 RVA: 0x00008A86 File Offset: 0x00006C86
	public unsafe Texture normalTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_normalTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_normalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x00053D9C File Offset: 0x00051F9C
	// (set) Token: 0x06001165 RID: 4453 RVA: 0x00008AA5 File Offset: 0x00006CA5
	public unsafe Texture pressedTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_pressedTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_pressedTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x06001166 RID: 4454 RVA: 0x00053DCC File Offset: 0x00051FCC
	// (set) Token: 0x06001167 RID: 4455 RVA: 0x00008AC4 File Offset: 0x00006CC4
	public unsafe Texture disabledTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_disabledTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_disabledTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06001168 RID: 4456 RVA: 0x00053DFC File Offset: 0x00051FFC
	// (set) Token: 0x06001169 RID: 4457 RVA: 0x00008AE3 File Offset: 0x00006CE3
	public unsafe Texture selectedTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_selectedTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_selectedTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x0600116A RID: 4458 RVA: 0x00053E2C File Offset: 0x0005202C
	// (set) Token: 0x0600116B RID: 4459 RVA: 0x00008B02 File Offset: 0x00006D02
	public unsafe Texture normalTex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_normalTex);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_normalTex), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x0600116C RID: 4460 RVA: 0x00053E5C File Offset: 0x0005205C
	// (set) Token: 0x0600116D RID: 4461 RVA: 0x00008B21 File Offset: 0x00006D21
	public unsafe AudioClip sound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_sound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_sound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x0600116E RID: 4462 RVA: 0x00053E8C File Offset: 0x0005208C
	// (set) Token: 0x0600116F RID: 4463 RVA: 0x00008B40 File Offset: 0x00006D40
	public unsafe AudioClip disabledsound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_disabledsound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_disabledsound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06001170 RID: 4464 RVA: 0x00053EBC File Offset: 0x000520BC
	// (set) Token: 0x06001171 RID: 4465 RVA: 0x00008B5F File Offset: 0x00006D5F
	public unsafe bool IsDisabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_IsDisabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPreviewButton.NativeFieldInfoPtr_IsDisabled)) = value;
		}
	}

	// Token: 0x04000D70 RID: 3440
	private static readonly IntPtr NativeFieldInfoPtr_ActionClick;

	// Token: 0x04000D71 RID: 3441
	private static readonly IntPtr NativeFieldInfoPtr_normalTexture;

	// Token: 0x04000D72 RID: 3442
	private static readonly IntPtr NativeFieldInfoPtr_pressedTexture;

	// Token: 0x04000D73 RID: 3443
	private static readonly IntPtr NativeFieldInfoPtr_disabledTexture;

	// Token: 0x04000D74 RID: 3444
	private static readonly IntPtr NativeFieldInfoPtr_selectedTexture;

	// Token: 0x04000D75 RID: 3445
	private static readonly IntPtr NativeFieldInfoPtr_normalTex;

	// Token: 0x04000D76 RID: 3446
	private static readonly IntPtr NativeFieldInfoPtr_sound;

	// Token: 0x04000D77 RID: 3447
	private static readonly IntPtr NativeFieldInfoPtr_disabledsound;

	// Token: 0x04000D78 RID: 3448
	private static readonly IntPtr NativeFieldInfoPtr_IsDisabled;

	// Token: 0x04000D79 RID: 3449
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionClick_Public_add_Void_Action_0;

	// Token: 0x04000D7A RID: 3450
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionClick_Public_rem_Void_Action_0;

	// Token: 0x04000D7B RID: 3451
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D7C RID: 3452
	private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;

	// Token: 0x04000D7D RID: 3453
	private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Void_0;

	// Token: 0x04000D7E RID: 3454
	private static readonly IntPtr NativeMethodInfoPtr_DisabledButton_Public_Void_0;

	// Token: 0x04000D7F RID: 3455
	private static readonly IntPtr NativeMethodInfoPtr_EnabledButton_Public_Void_0;

	// Token: 0x04000D80 RID: 3456
	private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

	// Token: 0x04000D81 RID: 3457
	private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

	// Token: 0x04000D82 RID: 3458
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000D83 RID: 3459
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_New_Void_0;

	// Token: 0x04000D84 RID: 3460
	private static readonly IntPtr NativeMethodInfoPtr_OnTimeoutPress_Private_Void_0;

	// Token: 0x04000D85 RID: 3461
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200039A RID: 922
	[ObfuscatedName("DefaultPreviewButton+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600369C RID: 13980 RVA: 0x000DFDD4 File Offset: 0x000DDFD4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<DefaultPreviewButton.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultPreviewButton>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultPreviewButton.__c>.NativeClassPtr);
			DefaultPreviewButton.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton.__c>.NativeClassPtr, "<>9");
			DefaultPreviewButton.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPreviewButton.__c>.NativeClassPtr, "<>9__22_0");
			DefaultPreviewButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton.__c>.NativeClassPtr, 100670241);
			DefaultPreviewButton.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPreviewButton.__c>.NativeClassPtr, 100670242);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x000DFE50 File Offset: 0x000DE050
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultPreviewButton.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x000DFE8C File Offset: 0x000DE08C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPreviewButton.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x000152C3 File Offset: 0x000134C3
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060036A0 RID: 13984 RVA: 0x000DFEC0 File Offset: 0x000DE0C0
		// (set) Token: 0x060036A1 RID: 13985 RVA: 0x000152CC File Offset: 0x000134CC
		public unsafe static DefaultPreviewButton.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultPreviewButton.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultPreviewButton.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x000DFEE8 File Offset: 0x000DE0E8
		// (set) Token: 0x060036A3 RID: 13987 RVA: 0x000152DE File Offset: 0x000134DE
		public unsafe static Action __9__22_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultPreviewButton.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultPreviewButton.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_0;
	}
}
