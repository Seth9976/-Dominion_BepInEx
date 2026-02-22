using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x020000F9 RID: 249
public class SALevelLoader : Singleton<SALevelLoader>
{
	// Token: 0x06001172 RID: 4466 RVA: 0x00053EE4 File Offset: 0x000520E4
	// Note: this type is marked as 'beforefieldinit'.
	static SALevelLoader()
	{
		Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SALevelLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr);
		SALevelLoader.NativeFieldInfoPtr_bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr, "bg");
		SALevelLoader.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr, 100665420);
		SALevelLoader.NativeMethodInfoPtr_LoadLevel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr, 100665421);
		SALevelLoader.NativeMethodInfoPtr_Restart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr, 100665422);
		SALevelLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr, 100665423);
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00053F78 File Offset: 0x00052178
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181720, XrefRangeEnd = 181725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SALevelLoader.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00053FAC File Offset: 0x000521AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181725, XrefRangeEnd = 181729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLevel(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SALevelLoader.NativeMethodInfoPtr_LoadLevel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00053FF0 File Offset: 0x000521F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181729, XrefRangeEnd = 181735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Restart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SALevelLoader.NativeMethodInfoPtr_Restart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00054024 File Offset: 0x00052224
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181735, XrefRangeEnd = 181741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SALevelLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SALevelLoader>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SALevelLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00008B7A File Offset: 0x00006D7A
	public SALevelLoader(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x06001178 RID: 4472 RVA: 0x00054060 File Offset: 0x00052260
	// (set) Token: 0x06001179 RID: 4473 RVA: 0x00008B83 File Offset: 0x00006D83
	public unsafe Texture2D bg
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SALevelLoader.NativeFieldInfoPtr_bg);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SALevelLoader.NativeFieldInfoPtr_bg), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D86 RID: 3462
	private static readonly IntPtr NativeFieldInfoPtr_bg;

	// Token: 0x04000D87 RID: 3463
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D88 RID: 3464
	private static readonly IntPtr NativeMethodInfoPtr_LoadLevel_Public_Void_String_0;

	// Token: 0x04000D89 RID: 3465
	private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Void_0;

	// Token: 0x04000D8A RID: 3466
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
