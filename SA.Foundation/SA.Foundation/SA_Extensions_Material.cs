using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000006 RID: 6
public static class SA_Extensions_Material : global::Il2CppSystem.Object
{
	// Token: 0x06000028 RID: 40 RVA: 0x00002094 File Offset: 0x00000294
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Material()
	{
		Il2CppClassPointerStore<SA_Extensions_Material>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Material");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Material>.NativeClassPtr);
		SA_Extensions_Material.NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Material>.NativeClassPtr, 100663326);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00004418 File Offset: 0x00002618
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98294, XrefRangeEnd = 98299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAlpha(this Material material, float value)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Material.NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Material_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000020CD File Offset: 0x000002CD
	public SA_Extensions_Material(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Material_Single_0;
}
