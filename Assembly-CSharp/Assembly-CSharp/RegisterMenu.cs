using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020000A8 RID: 168
public class RegisterMenu : MonoBehaviour
{
	// Token: 0x060013AE RID: 5038 RVA: 0x00055908 File Offset: 0x00053B08
	// Note: this type is marked as 'beforefieldinit'.
	static RegisterMenu()
	{
		Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RegisterMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr);
		RegisterMenu.NativeFieldInfoPtr_menuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "menuName");
		RegisterMenu.NativeFieldInfoPtr_isWaitForAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "isWaitForAnimation");
		RegisterMenu.NativeFieldInfoPtr_isPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "isPopup");
		RegisterMenu.NativeFieldInfoPtr_isBuiltInPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "isBuiltInPopup");
		RegisterMenu.NativeFieldInfoPtr_m_OnEnterMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "m_OnEnterMenu");
		RegisterMenu.NativeFieldInfoPtr_m_OnExitMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "m_OnExitMenu");
		RegisterMenu.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "animator");
		RegisterMenu.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "canvasGroup");
		RegisterMenu.NativeFieldInfoPtr_sceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "sceneName");
		RegisterMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664863);
		RegisterMenu.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664864);
		RegisterMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664865);
		RegisterMenu.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664866);
		RegisterMenu.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664867);
		RegisterMenu.NativeMethodInfoPtr_SetAnimation_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664868);
		RegisterMenu.NativeMethodInfoPtr_HasAnimation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664869);
		RegisterMenu.NativeMethodInfoPtr_GetAnimation_Public_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664870);
		RegisterMenu.NativeMethodInfoPtr_GetName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664871);
		RegisterMenu.NativeMethodInfoPtr_OnMenuStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664872);
		RegisterMenu.NativeMethodInfoPtr_OnMenuEnd_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664873);
		RegisterMenu.NativeMethodInfoPtr_DisconnectFromNetwork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664874);
		RegisterMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, 100664875);
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00055AF0 File Offset: 0x00053CF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244802, XrefRangeEnd = 244847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x00055B2C File Offset: 0x00053D2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244847, XrefRangeEnd = 244865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x00055B60 File Offset: 0x00053D60
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x00055B94 File Offset: 0x00053D94
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244871, RefRangeEnd = 244873, XrefRangeStart = 244865, XrefRangeEnd = 244871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInteractable(bool bActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x00055BD4 File Offset: 0x00053DD4
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 235352, RefRangeEnd = 235360, XrefRangeStart = 235352, XrefRangeEnd = 235360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnabled(bool bOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00055C14 File Offset: 0x00053E14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244873, XrefRangeEnd = 244878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimation(int triggerId, bool bOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref triggerId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bOn;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_SetAnimation_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x00055C60 File Offset: 0x00053E60
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244882, RefRangeEnd = 244883, XrefRangeStart = 244878, XrefRangeEnd = 244882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_HasAnimation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x00055C9C File Offset: 0x00053E9C
	[CallerCount(0)]
	public unsafe Animator GetAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_GetAnimation_Public_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x00055CDC File Offset: 0x00053EDC
	[CallerCount(0)]
	public unsafe string GetName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_GetName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00055D14 File Offset: 0x00053F14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244883, XrefRangeEnd = 244885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnMenuStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterMenu.NativeMethodInfoPtr_OnMenuStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x00055D50 File Offset: 0x00053F50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244885, XrefRangeEnd = 244889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnMenuEnd(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterMenu.NativeMethodInfoPtr_OnMenuEnd_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x00055D9C File Offset: 0x00053F9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisconnectFromNetwork()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr_DisconnectFromNetwork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x00055DD0 File Offset: 0x00053FD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244889, XrefRangeEnd = 244898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegisterMenu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x0000CE3C File Offset: 0x0000B03C
	public RegisterMenu(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x060013BD RID: 5053 RVA: 0x00055E0C File Offset: 0x0005400C
	// (set) Token: 0x060013BE RID: 5054 RVA: 0x0000CE45 File Offset: 0x0000B045
	public unsafe string menuName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_menuName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_menuName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x060013BF RID: 5055 RVA: 0x00055E34 File Offset: 0x00054034
	// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0000CE64 File Offset: 0x0000B064
	public unsafe bool isWaitForAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_isWaitForAnimation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_isWaitForAnimation)) = value;
		}
	}

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00055E5C File Offset: 0x0005405C
	// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000CE7F File Offset: 0x0000B07F
	public unsafe bool isPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_isPopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_isPopup)) = value;
		}
	}

	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00055E84 File Offset: 0x00054084
	// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000CE9A File Offset: 0x0000B09A
	public unsafe bool isBuiltInPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_isBuiltInPopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_isBuiltInPopup)) = value;
		}
	}

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00055EAC File Offset: 0x000540AC
	// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000CEB5 File Offset: 0x0000B0B5
	public unsafe RegisterMenu.EnterMenuEvent m_OnEnterMenu
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_m_OnEnterMenu);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterMenu.EnterMenuEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_m_OnEnterMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000646 RID: 1606
	// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00055EDC File Offset: 0x000540DC
	// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0000CED4 File Offset: 0x0000B0D4
	public unsafe RegisterMenu.ExitMenuEvent m_OnExitMenu
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_m_OnExitMenu);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterMenu.ExitMenuEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_m_OnExitMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000647 RID: 1607
	// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00055F0C File Offset: 0x0005410C
	// (set) Token: 0x060013CA RID: 5066 RVA: 0x0000CEF3 File Offset: 0x0000B0F3
	public unsafe Animator animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000648 RID: 1608
	// (get) Token: 0x060013CB RID: 5067 RVA: 0x00055F3C File Offset: 0x0005413C
	// (set) Token: 0x060013CC RID: 5068 RVA: 0x0000CF12 File Offset: 0x0000B112
	public unsafe CanvasGroup canvasGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_canvasGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000649 RID: 1609
	// (get) Token: 0x060013CD RID: 5069 RVA: 0x00055F6C File Offset: 0x0005416C
	// (set) Token: 0x060013CE RID: 5070 RVA: 0x0000CF31 File Offset: 0x0000B131
	public unsafe string sceneName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_sceneName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenu.NativeFieldInfoPtr_sceneName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000DBC RID: 3516
	private static readonly IntPtr NativeFieldInfoPtr_menuName;

	// Token: 0x04000DBD RID: 3517
	private static readonly IntPtr NativeFieldInfoPtr_isWaitForAnimation;

	// Token: 0x04000DBE RID: 3518
	private static readonly IntPtr NativeFieldInfoPtr_isPopup;

	// Token: 0x04000DBF RID: 3519
	private static readonly IntPtr NativeFieldInfoPtr_isBuiltInPopup;

	// Token: 0x04000DC0 RID: 3520
	private static readonly IntPtr NativeFieldInfoPtr_m_OnEnterMenu;

	// Token: 0x04000DC1 RID: 3521
	private static readonly IntPtr NativeFieldInfoPtr_m_OnExitMenu;

	// Token: 0x04000DC2 RID: 3522
	private static readonly IntPtr NativeFieldInfoPtr_animator;

	// Token: 0x04000DC3 RID: 3523
	private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

	// Token: 0x04000DC4 RID: 3524
	private static readonly IntPtr NativeFieldInfoPtr_sceneName;

	// Token: 0x04000DC5 RID: 3525
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

	// Token: 0x04000DC6 RID: 3526
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000DC7 RID: 3527
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000DC8 RID: 3528
	private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

	// Token: 0x04000DC9 RID: 3529
	private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

	// Token: 0x04000DCA RID: 3530
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimation_Public_Void_Int32_Boolean_0;

	// Token: 0x04000DCB RID: 3531
	private static readonly IntPtr NativeMethodInfoPtr_HasAnimation_Public_Boolean_0;

	// Token: 0x04000DCC RID: 3532
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimation_Public_Animator_0;

	// Token: 0x04000DCD RID: 3533
	private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_String_0;

	// Token: 0x04000DCE RID: 3534
	private static readonly IntPtr NativeMethodInfoPtr_OnMenuStart_Public_Virtual_New_Void_0;

	// Token: 0x04000DCF RID: 3535
	private static readonly IntPtr NativeMethodInfoPtr_OnMenuEnd_Public_Virtual_New_Void_Boolean_0;

	// Token: 0x04000DD0 RID: 3536
	private static readonly IntPtr NativeMethodInfoPtr_DisconnectFromNetwork_Private_Void_0;

	// Token: 0x04000DD1 RID: 3537
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001AC RID: 428
	[Serializable]
	public class EnterMenuEvent : UnityEvent
	{
		// Token: 0x06002552 RID: 9554 RVA: 0x000172D7 File Offset: 0x000154D7
		// Note: this type is marked as 'beforefieldinit'.
		static EnterMenuEvent()
		{
			Il2CppClassPointerStore<RegisterMenu.EnterMenuEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "EnterMenuEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterMenu.EnterMenuEvent>.NativeClassPtr);
			RegisterMenu.EnterMenuEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu.EnterMenuEvent>.NativeClassPtr, 100666244);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00089DD0 File Offset: 0x00087FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108007, RefRangeEnd = 108010, XrefRangeStart = 108007, XrefRangeEnd = 108010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterMenuEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterMenu.EnterMenuEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.EnterMenuEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x0001730B File Offset: 0x0001550B
		public EnterMenuEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001AD RID: 429
	[Serializable]
	public class ExitMenuEvent : UnityEvent<bool>
	{
		// Token: 0x06002555 RID: 9557 RVA: 0x00017314 File Offset: 0x00015514
		// Note: this type is marked as 'beforefieldinit'.
		static ExitMenuEvent()
		{
			Il2CppClassPointerStore<RegisterMenu.ExitMenuEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterMenu>.NativeClassPtr, "ExitMenuEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterMenu.ExitMenuEvent>.NativeClassPtr);
			RegisterMenu.ExitMenuEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenu.ExitMenuEvent>.NativeClassPtr, 100666245);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00089E0C File Offset: 0x0008800C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244800, RefRangeEnd = 244802, XrefRangeStart = 244797, XrefRangeEnd = 244800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitMenuEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterMenu.ExitMenuEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenu.ExitMenuEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00017348 File Offset: 0x00015548
		public ExitMenuEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
