using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000092 RID: 146
public class KeybindManager : MonoBehaviour
{
	// Token: 0x060011BD RID: 4541 RVA: 0x0004F244 File Offset: 0x0004D444
	// Note: this type is marked as 'beforefieldinit'.
	static KeybindManager()
	{
		Il2CppClassPointerStore<KeybindManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "KeybindManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr);
		KeybindManager.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, "_instance");
		KeybindManager.NativeFieldInfoPtr_m_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, "m_inputs");
		KeybindManager.NativeFieldInfoPtr_m_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, "m_dict");
		KeybindManager.NativeFieldInfoPtr_m_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, "m_events");
		KeybindManager.NativeMethodInfoPtr_get_instance_Public_Static_get_KeybindManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664653);
		KeybindManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664654);
		KeybindManager.NativeMethodInfoPtr_AddEvent_Public_Void_KeyEvent_String_KeybindEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664655);
		KeybindManager.NativeMethodInfoPtr_RemoveEvent_Public_Void_KeyEvent_String_KeybindEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664656);
		KeybindManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664657);
		KeybindManager.NativeMethodInfoPtr_RebuildDictionary_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664658);
		KeybindManager.NativeMethodInfoPtr_UpdateInput_Private_Void_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664659);
		KeybindManager.NativeMethodInfoPtr_GetKey_Private_KeyCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664660);
		KeybindManager.NativeMethodInfoPtr_GetInputCount_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664661);
		KeybindManager.NativeMethodInfoPtr_GetShouldDisplayKeybind_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664662);
		KeybindManager.NativeMethodInfoPtr_GetShouldAllowRemapOfKeybind_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664663);
		KeybindManager.NativeMethodInfoPtr_GetDisplayLine_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664664);
		KeybindManager.NativeMethodInfoPtr_GetKey_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664665);
		KeybindManager.NativeMethodInfoPtr_SetKey_Public_Void_UInt32_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664666);
		KeybindManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, 100664667);
	}

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x060011BE RID: 4542 RVA: 0x0004F3F0 File Offset: 0x0004D5F0
	public unsafe static KeybindManager instance
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 242744, RefRangeEnd = 242770, XrefRangeStart = 242710, XrefRangeEnd = 242744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_get_instance_Public_Static_get_KeybindManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeybindManager>(intPtr3) : null;
		}
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x0004F424 File Offset: 0x0004D624
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242770, XrefRangeEnd = 242788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x0004F458 File Offset: 0x0004D658
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 242804, RefRangeEnd = 242818, XrefRangeStart = 242788, XrefRangeEnd = 242804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEvent(KeybindManager.KeyEvent callback, string key, KeybindManager.KeybindEvents trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trigger;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_AddEvent_Public_Void_KeyEvent_String_KeybindEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x0004F4BC File Offset: 0x0004D6BC
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 242829, RefRangeEnd = 242843, XrefRangeStart = 242818, XrefRangeEnd = 242829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEvent(KeybindManager.KeyEvent callback, string key, KeybindManager.KeybindEvents trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trigger;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_RemoveEvent_Public_Void_KeyEvent_String_KeybindEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x0004F520 File Offset: 0x0004D720
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242843, XrefRangeEnd = 242870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x0004F554 File Offset: 0x0004D754
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242904, RefRangeEnd = 242905, XrefRangeStart = 242870, XrefRangeEnd = 242904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildDictionary(bool bUseDefaults)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUseDefaults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_RebuildDictionary_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x0004F594 File Offset: 0x0004D794
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242905, XrefRangeEnd = 242919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInput(string commandName, KeyCode newInputKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(commandName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInputKey;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_UpdateInput_Private_Void_String_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x0004F5E4 File Offset: 0x0004D7E4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242925, RefRangeEnd = 242927, XrefRangeStart = 242919, XrefRangeEnd = 242925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyCode GetKey(string commandName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(commandName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_GetKey_Private_KeyCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x0004F634 File Offset: 0x0004D834
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242927, RefRangeEnd = 242928, XrefRangeStart = 242927, XrefRangeEnd = 242927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetInputCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_GetInputCount_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x0004F670 File Offset: 0x0004D870
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242928, RefRangeEnd = 242929, XrefRangeStart = 242928, XrefRangeEnd = 242928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetShouldDisplayKeybind(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_GetShouldDisplayKeybind_Public_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x0004F6BC File Offset: 0x0004D8BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242929, RefRangeEnd = 242930, XrefRangeStart = 242929, XrefRangeEnd = 242929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetShouldAllowRemapOfKeybind(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_GetShouldAllowRemapOfKeybind_Public_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x0004F708 File Offset: 0x0004D908
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242931, RefRangeEnd = 242933, XrefRangeStart = 242930, XrefRangeEnd = 242931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDisplayLine(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_GetDisplayLine_Public_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x0004F74C File Offset: 0x0004D94C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242939, RefRangeEnd = 242941, XrefRangeStart = 242933, XrefRangeEnd = 242939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetKey(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_GetKey_Public_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x0004F790 File Offset: 0x0004D990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242941, XrefRangeEnd = 242955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetKey(uint index, KeyCode newInputKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInputKey;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr_SetKey_Public_Void_UInt32_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x0004F7DC File Offset: 0x0004D9DC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeybindManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x0000BF86 File Offset: 0x0000A186
	public KeybindManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x060011CE RID: 4558 RVA: 0x0004F818 File Offset: 0x0004DA18
	// (set) Token: 0x060011CF RID: 4559 RVA: 0x0000BF8F File Offset: 0x0000A18F
	public unsafe static KeybindManager _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(KeybindManager.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeybindManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(KeybindManager.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0004F840 File Offset: 0x0004DA40
	// (set) Token: 0x060011D1 RID: 4561 RVA: 0x0000BFA1 File Offset: 0x0000A1A1
	public unsafe Il2CppReferenceArray<KeybindManager.KeybindingInspector> m_inputs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.NativeFieldInfoPtr_m_inputs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeybindManager.KeybindingInspector>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.NativeFieldInfoPtr_m_inputs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C2 RID: 1474
	// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0004F870 File Offset: 0x0004DA70
	// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
	public unsafe Dictionary<string, KeyCode> m_dict
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.NativeFieldInfoPtr_m_dict);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KeyCode>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.NativeFieldInfoPtr_m_dict), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0004F8A0 File Offset: 0x0004DAA0
	// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0000BFDF File Offset: 0x0000A1DF
	public unsafe List<KeybindManager.KeyCallback> m_events
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.NativeFieldInfoPtr_m_events);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeybindManager.KeyCallback>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.NativeFieldInfoPtr_m_events), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C6D RID: 3181
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x04000C6E RID: 3182
	private static readonly IntPtr NativeFieldInfoPtr_m_inputs;

	// Token: 0x04000C6F RID: 3183
	private static readonly IntPtr NativeFieldInfoPtr_m_dict;

	// Token: 0x04000C70 RID: 3184
	private static readonly IntPtr NativeFieldInfoPtr_m_events;

	// Token: 0x04000C71 RID: 3185
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_KeybindManager_0;

	// Token: 0x04000C72 RID: 3186
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C73 RID: 3187
	private static readonly IntPtr NativeMethodInfoPtr_AddEvent_Public_Void_KeyEvent_String_KeybindEvents_0;

	// Token: 0x04000C74 RID: 3188
	private static readonly IntPtr NativeMethodInfoPtr_RemoveEvent_Public_Void_KeyEvent_String_KeybindEvents_0;

	// Token: 0x04000C75 RID: 3189
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000C76 RID: 3190
	private static readonly IntPtr NativeMethodInfoPtr_RebuildDictionary_Public_Void_Boolean_0;

	// Token: 0x04000C77 RID: 3191
	private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_String_KeyCode_0;

	// Token: 0x04000C78 RID: 3192
	private static readonly IntPtr NativeMethodInfoPtr_GetKey_Private_KeyCode_String_0;

	// Token: 0x04000C79 RID: 3193
	private static readonly IntPtr NativeMethodInfoPtr_GetInputCount_Public_UInt32_0;

	// Token: 0x04000C7A RID: 3194
	private static readonly IntPtr NativeMethodInfoPtr_GetShouldDisplayKeybind_Public_Boolean_UInt32_0;

	// Token: 0x04000C7B RID: 3195
	private static readonly IntPtr NativeMethodInfoPtr_GetShouldAllowRemapOfKeybind_Public_Boolean_UInt32_0;

	// Token: 0x04000C7C RID: 3196
	private static readonly IntPtr NativeMethodInfoPtr_GetDisplayLine_Public_String_UInt32_0;

	// Token: 0x04000C7D RID: 3197
	private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_String_UInt32_0;

	// Token: 0x04000C7E RID: 3198
	private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Void_UInt32_KeyCode_0;

	// Token: 0x04000C7F RID: 3199
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000195 RID: 405
	[Serializable]
	public sealed class KeybindingInspector : ValueType
	{
		// Token: 0x06002488 RID: 9352 RVA: 0x00087F1C File Offset: 0x0008611C
		// Note: this type is marked as 'beforefieldinit'.
		static KeybindingInspector()
		{
			Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, "KeybindingInspector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr);
			KeybindManager.KeybindingInspector.NativeFieldInfoPtr_commandName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr, "commandName");
			KeybindManager.KeybindingInspector.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr, "displayName");
			KeybindManager.KeybindingInspector.NativeFieldInfoPtr_defaultInputKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr, "defaultInputKey");
			KeybindManager.KeybindingInspector.NativeFieldInfoPtr_remappable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr, "remappable");
			KeybindManager.KeybindingInspector.NativeFieldInfoPtr_showInOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr, "showInOptions");
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00016AE3 File Offset: 0x00014CE3
		public KeybindingInspector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00016AEC File Offset: 0x00014CEC
		public KeybindingInspector()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeybindManager.KeybindingInspector>.NativeClassPtr))
		{
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x00087FAC File Offset: 0x000861AC
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x00016AFE File Offset: 0x00014CFE
		public unsafe string commandName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_commandName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_commandName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x00087FD4 File Offset: 0x000861D4
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x00016B1D File Offset: 0x00014D1D
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x00087FFC File Offset: 0x000861FC
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x00016B3C File Offset: 0x00014D3C
		public unsafe KeyCode defaultInputKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_defaultInputKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_defaultInputKey)) = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x00088024 File Offset: 0x00086224
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x00016B57 File Offset: 0x00014D57
		public unsafe bool remappable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_remappable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_remappable)) = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0008804C File Offset: 0x0008624C
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x00016B72 File Offset: 0x00014D72
		public unsafe bool showInOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_showInOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeybindingInspector.NativeFieldInfoPtr_showInOptions)) = value;
			}
		}

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeFieldInfoPtr_commandName;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputKey;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeFieldInfoPtr_remappable;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeFieldInfoPtr_showInOptions;
	}

	// Token: 0x02000196 RID: 406
	public enum KeybindEvents
	{
		// Token: 0x0400195B RID: 6491
		KeyDownTrigger,
		// Token: 0x0400195C RID: 6492
		KeyDown,
		// Token: 0x0400195D RID: 6493
		KeyUpTrigger,
		// Token: 0x0400195E RID: 6494
		KeyUp
	}

	// Token: 0x02000197 RID: 407
	public sealed class KeyCallback : ValueType
	{
		// Token: 0x06002495 RID: 9365 RVA: 0x00088074 File Offset: 0x00086274
		// Note: this type is marked as 'beforefieldinit'.
		static KeyCallback()
		{
			Il2CppClassPointerStore<KeybindManager.KeyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, "KeyCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeybindManager.KeyCallback>.NativeClassPtr);
			KeybindManager.KeyCallback.NativeFieldInfoPtr_m_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeyCallback>.NativeClassPtr, "m_event");
			KeybindManager.KeyCallback.NativeFieldInfoPtr_m_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeyCallback>.NativeClassPtr, "m_key");
			KeybindManager.KeyCallback.NativeFieldInfoPtr_m_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeybindManager.KeyCallback>.NativeClassPtr, "m_trigger");
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00016B8D File Offset: 0x00014D8D
		public KeyCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00016B96 File Offset: 0x00014D96
		public KeyCallback()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeybindManager.KeyCallback>.NativeClassPtr))
		{
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x000880DC File Offset: 0x000862DC
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x00016BA8 File Offset: 0x00014DA8
		public unsafe KeybindManager.KeyEvent m_event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeyCallback.NativeFieldInfoPtr_m_event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeybindManager.KeyEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeyCallback.NativeFieldInfoPtr_m_event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x0008810C File Offset: 0x0008630C
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x00016BC7 File Offset: 0x00014DC7
		public unsafe string m_key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeyCallback.NativeFieldInfoPtr_m_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeyCallback.NativeFieldInfoPtr_m_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x00088134 File Offset: 0x00086334
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x00016BE6 File Offset: 0x00014DE6
		public unsafe KeybindManager.KeybindEvents m_trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeyCallback.NativeFieldInfoPtr_m_trigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeybindManager.KeyCallback.NativeFieldInfoPtr_m_trigger)) = value;
			}
		}

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_m_event;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr_m_key;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeFieldInfoPtr_m_trigger;
	}

	// Token: 0x02000198 RID: 408
	public sealed class KeyEvent : MulticastDelegate
	{
		// Token: 0x0600249E RID: 9374 RVA: 0x0008815C File Offset: 0x0008635C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyEvent()
		{
			Il2CppClassPointerStore<KeybindManager.KeyEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeybindManager>.NativeClassPtr, "KeyEvent");
			KeybindManager.KeyEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager.KeyEvent>.NativeClassPtr, 100666208);
			KeybindManager.KeyEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager.KeyEvent>.NativeClassPtr, 100666209);
			KeybindManager.KeyEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager.KeyEvent>.NativeClassPtr, 100666210);
			KeybindManager.KeyEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeybindManager.KeyEvent>.NativeClassPtr, 100666211);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x000881D0 File Offset: 0x000863D0
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyEvent(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeybindManager.KeyEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.KeyEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0008822C File Offset: 0x0008642C
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.KeyEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00088260 File Offset: 0x00086460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.KeyEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x000882C4 File Offset: 0x000864C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeybindManager.KeyEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00016C01 File Offset: 0x00014E01
		public KeyEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00016C0A File Offset: 0x00014E0A
		public static implicit operator KeybindManager.KeyEvent(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<KeybindManager.KeyEvent>(A_0);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00016C12 File Offset: 0x00014E12
		public static KeybindManager.KeyEvent operator +(KeybindManager.KeyEvent A_0, KeybindManager.KeyEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<KeybindManager.KeyEvent>();
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00016C20 File Offset: 0x00014E20
		public static KeybindManager.KeyEvent operator -(KeybindManager.KeyEvent A_0, KeybindManager.KeyEvent A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<KeybindManager.KeyEvent>();
			}
			return delegate2;
		}

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
