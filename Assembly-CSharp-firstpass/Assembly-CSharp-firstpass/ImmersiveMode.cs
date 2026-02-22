using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Pattern;

// Token: 0x020000DC RID: 220
public class ImmersiveMode : Singleton<ImmersiveMode>
{
	// Token: 0x06000FDA RID: 4058 RVA: 0x0004F158 File Offset: 0x0004D358
	// Note: this type is marked as 'beforefieldinit'.
	static ImmersiveMode()
	{
		Il2CppClassPointerStore<ImmersiveMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ImmersiveMode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmersiveMode>.NativeClassPtr);
		ImmersiveMode.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmersiveMode>.NativeClassPtr, 100665273);
		ImmersiveMode.NativeMethodInfoPtr_EnableImmersiveMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmersiveMode>.NativeClassPtr, 100665274);
		ImmersiveMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmersiveMode>.NativeClassPtr, 100665275);
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x0004F1C4 File Offset: 0x0004D3C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180844, XrefRangeEnd = 180849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmersiveMode.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x0004F1F8 File Offset: 0x0004D3F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180850, RefRangeEnd = 180852, XrefRangeStart = 180849, XrefRangeEnd = 180850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableImmersiveMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmersiveMode.NativeMethodInfoPtr_EnableImmersiveMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x0004F22C File Offset: 0x0004D42C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180852, XrefRangeEnd = 180858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImmersiveMode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImmersiveMode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmersiveMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00007F04 File Offset: 0x00006104
	public ImmersiveMode(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000C90 RID: 3216
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C91 RID: 3217
	private static readonly IntPtr NativeMethodInfoPtr_EnableImmersiveMode_Public_Void_0;

	// Token: 0x04000C92 RID: 3218
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
