using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class AN_DeepLinkingManager : MonoBehaviour
{
	// Token: 0x06000435 RID: 1077 RVA: 0x00024CEC File Offset: 0x00022EEC
	// Note: this type is marked as 'beforefieldinit'.
	static AN_DeepLinkingManager()
	{
		Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_DeepLinkingManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr);
		AN_DeepLinkingManager.NativeFieldInfoPtr_OnDeepLinkReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr, "OnDeepLinkReceived");
		AN_DeepLinkingManager.NativeMethodInfoPtr_add_OnDeepLinkReceived_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr, 100663773);
		AN_DeepLinkingManager.NativeMethodInfoPtr_remove_OnDeepLinkReceived_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr, 100663774);
		AN_DeepLinkingManager.NativeMethodInfoPtr_GetLaunchDeepLinkId_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr, 100663775);
		AN_DeepLinkingManager.NativeMethodInfoPtr_DeepLinkReceived_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr, 100663776);
		AN_DeepLinkingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr, 100663777);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00024D94 File Offset: 0x00022F94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163384, XrefRangeEnd = 163391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnDeepLinkReceived(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeepLinkingManager.NativeMethodInfoPtr_add_OnDeepLinkReceived_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00024DCC File Offset: 0x00022FCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163391, XrefRangeEnd = 163398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnDeepLinkReceived(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeepLinkingManager.NativeMethodInfoPtr_remove_OnDeepLinkReceived_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00024E04 File Offset: 0x00023004
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163398, XrefRangeEnd = 163403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLaunchDeepLinkId()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeepLinkingManager.NativeMethodInfoPtr_GetLaunchDeepLinkId_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00024E2C File Offset: 0x0002302C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163403, XrefRangeEnd = 163409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeepLinkReceived(string linkId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(linkId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeepLinkingManager.NativeMethodInfoPtr_DeepLinkReceived_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00024E70 File Offset: 0x00023070
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_DeepLinkingManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_DeepLinkingManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeepLinkingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00003D6B File Offset: 0x00001F6B
	public AN_DeepLinkingManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x0600043C RID: 1084 RVA: 0x00024EAC File Offset: 0x000230AC
	// (set) Token: 0x0600043D RID: 1085 RVA: 0x00003D74 File Offset: 0x00001F74
	public unsafe static Action<string> OnDeepLinkReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_DeepLinkingManager.NativeFieldInfoPtr_OnDeepLinkReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_DeepLinkingManager.NativeFieldInfoPtr_OnDeepLinkReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400032A RID: 810
	private static readonly IntPtr NativeFieldInfoPtr_OnDeepLinkReceived;

	// Token: 0x0400032B RID: 811
	private static readonly IntPtr NativeMethodInfoPtr_add_OnDeepLinkReceived_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x0400032C RID: 812
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeepLinkReceived_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x0400032D RID: 813
	private static readonly IntPtr NativeMethodInfoPtr_GetLaunchDeepLinkId_Public_Static_Void_0;

	// Token: 0x0400032E RID: 814
	private static readonly IntPtr NativeMethodInfoPtr_DeepLinkReceived_Private_Void_String_0;

	// Token: 0x0400032F RID: 815
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
