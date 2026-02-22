using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000D2 RID: 210
public static class AN_PermissionMethods : Object
{
	// Token: 0x06000EA6 RID: 3750 RVA: 0x0004B4A0 File Offset: 0x000496A0
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PermissionMethods()
	{
		Il2CppClassPointerStore<AN_PermissionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PermissionMethods");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PermissionMethods>.NativeClassPtr);
		AN_PermissionMethods.NativeMethodInfoPtr_GetFullName_Public_Static_String_AN_Permission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PermissionMethods>.NativeClassPtr, 100665148);
		AN_PermissionMethods.NativeMethodInfoPtr_IsNormalPermission_Public_Static_Boolean_AN_Permission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PermissionMethods>.NativeClassPtr, 100665149);
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x0004B4F8 File Offset: 0x000496F8
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 179034, RefRangeEnd = 179040, XrefRangeStart = 179019, XrefRangeEnd = 179034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFullName(this AN_Permission permission)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref permission;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PermissionMethods.NativeMethodInfoPtr_GetFullName_Public_Static_String_AN_Permission_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x0004B530 File Offset: 0x00049730
	[CallerCount(0)]
	public unsafe static bool IsNormalPermission(this AN_Permission permission)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref permission;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PermissionMethods.NativeMethodInfoPtr_IsNormalPermission_Public_Static_Boolean_AN_Permission_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x0000783A File Offset: 0x00005A3A
	public AN_PermissionMethods(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000BB7 RID: 2999
	private static readonly IntPtr NativeMethodInfoPtr_GetFullName_Public_Static_String_AN_Permission_0;

	// Token: 0x04000BB8 RID: 3000
	private static readonly IntPtr NativeMethodInfoPtr_IsNormalPermission_Public_Static_Boolean_AN_Permission_0;
}
