using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x020000FA RID: 250
public class SALoadedSceneOnClick : SAOnClickAction
{
	// Token: 0x0600117A RID: 4474 RVA: 0x00054090 File Offset: 0x00052290
	// Note: this type is marked as 'beforefieldinit'.
	static SALoadedSceneOnClick()
	{
		Il2CppClassPointerStore<SALoadedSceneOnClick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SALoadedSceneOnClick");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SALoadedSceneOnClick>.NativeClassPtr);
		SALoadedSceneOnClick.NativeFieldInfoPtr_levelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SALoadedSceneOnClick>.NativeClassPtr, "levelName");
		SALoadedSceneOnClick.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SALoadedSceneOnClick>.NativeClassPtr, 100665424);
		SALoadedSceneOnClick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SALoadedSceneOnClick>.NativeClassPtr, 100665425);
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x000540FC File Offset: 0x000522FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181741, XrefRangeEnd = 181752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SALoadedSceneOnClick.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x00054138 File Offset: 0x00052338
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SALoadedSceneOnClick()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SALoadedSceneOnClick>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SALoadedSceneOnClick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00008BA2 File Offset: 0x00006DA2
	public SALoadedSceneOnClick(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x0600117E RID: 4478 RVA: 0x00054174 File Offset: 0x00052374
	// (set) Token: 0x0600117F RID: 4479 RVA: 0x00008BAB File Offset: 0x00006DAB
	public unsafe string levelName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SALoadedSceneOnClick.NativeFieldInfoPtr_levelName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SALoadedSceneOnClick.NativeFieldInfoPtr_levelName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D8B RID: 3467
	private static readonly IntPtr NativeFieldInfoPtr_levelName;

	// Token: 0x04000D8C RID: 3468
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0;

	// Token: 0x04000D8D RID: 3469
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
