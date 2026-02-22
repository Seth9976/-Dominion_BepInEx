using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000042 RID: 66
public class GP_MatchesSortOrder : MonoBehaviour
{
	// Token: 0x06000574 RID: 1396 RVA: 0x00029AA0 File Offset: 0x00027CA0
	// Note: this type is marked as 'beforefieldinit'.
	static GP_MatchesSortOrder()
	{
		Il2CppClassPointerStore<GP_MatchesSortOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_MatchesSortOrder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_MatchesSortOrder>.NativeClassPtr);
		GP_MatchesSortOrder.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_MatchesSortOrder>.NativeClassPtr, 100663972);
		GP_MatchesSortOrder.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_MatchesSortOrder>.NativeClassPtr, 100663973);
		GP_MatchesSortOrder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_MatchesSortOrder>.NativeClassPtr, 100663974);
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00029B0C File Offset: 0x00027D0C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_MatchesSortOrder.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00029B40 File Offset: 0x00027D40
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_MatchesSortOrder.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00029B74 File Offset: 0x00027D74
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_MatchesSortOrder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_MatchesSortOrder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_MatchesSortOrder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00004262 File Offset: 0x00002462
	public GP_MatchesSortOrder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000495 RID: 1173
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000496 RID: 1174
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000497 RID: 1175
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
