using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000103 RID: 259
public class SA_Texture : MonoBehaviour
{
	// Token: 0x060011CE RID: 4558 RVA: 0x00054FFC File Offset: 0x000531FC
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Texture()
	{
		Il2CppClassPointerStore<SA_Texture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_Texture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Texture>.NativeClassPtr);
		SA_Texture.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Texture>.NativeClassPtr, 100665455);
		SA_Texture.NativeMethodInfoPtr_get_texture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Texture>.NativeClassPtr, 100665456);
		SA_Texture.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Texture>.NativeClassPtr, 100665457);
		SA_Texture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Texture>.NativeClassPtr, 100665458);
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x0005507C File Offset: 0x0005327C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182160, XrefRangeEnd = 182172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Texture.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x060011D0 RID: 4560 RVA: 0x000550B0 File Offset: 0x000532B0
	// (set) Token: 0x060011D1 RID: 4561 RVA: 0x000550F0 File Offset: 0x000532F0
	public unsafe Texture texture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182172, XrefRangeEnd = 182178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Texture.NativeMethodInfoPtr_get_texture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182178, XrefRangeEnd = 182184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Texture.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00055134 File Offset: 0x00053334
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_Texture()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Texture>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Texture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00008E14 File Offset: 0x00007014
	public SA_Texture(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000DBB RID: 3515
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DBC RID: 3516
	private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture_0;

	// Token: 0x04000DBD RID: 3517
	private static readonly IntPtr NativeMethodInfoPtr_set_texture_Public_set_Void_Texture_0;

	// Token: 0x04000DBE RID: 3518
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
