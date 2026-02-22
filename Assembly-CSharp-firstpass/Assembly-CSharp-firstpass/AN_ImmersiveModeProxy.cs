using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C3 RID: 195
public class AN_ImmersiveModeProxy : Object
{
	// Token: 0x06000E39 RID: 3641 RVA: 0x00049998 File Offset: 0x00047B98
	// Note: this type is marked as 'beforefieldinit'.
	static AN_ImmersiveModeProxy()
	{
		Il2CppClassPointerStore<AN_ImmersiveModeProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_ImmersiveModeProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_ImmersiveModeProxy>.NativeClassPtr);
		AN_ImmersiveModeProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_ImmersiveModeProxy>.NativeClassPtr, "CLASS_NAME");
		AN_ImmersiveModeProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_ImmersiveModeProxy>.NativeClassPtr, 100665086);
		AN_ImmersiveModeProxy.NativeMethodInfoPtr_enableImmersiveMode_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_ImmersiveModeProxy>.NativeClassPtr, 100665087);
		AN_ImmersiveModeProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_ImmersiveModeProxy>.NativeClassPtr, 100665088);
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00049A18 File Offset: 0x00047C18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178398, XrefRangeEnd = 178399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_ImmersiveModeProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00049A70 File Offset: 0x00047C70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178404, RefRangeEnd = 178405, XrefRangeStart = 178399, XrefRangeEnd = 178404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void enableImmersiveMode()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_ImmersiveModeProxy.NativeMethodInfoPtr_enableImmersiveMode_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00049A98 File Offset: 0x00047C98
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_ImmersiveModeProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_ImmersiveModeProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_ImmersiveModeProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x000076A9 File Offset: 0x000058A9
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_ImmersiveModeProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x000076B7 File Offset: 0x000058B7
	public AN_ImmersiveModeProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00049AD4 File Offset: 0x00047CD4
	// (set) Token: 0x06000E40 RID: 3648 RVA: 0x000076C0 File Offset: 0x000058C0
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_ImmersiveModeProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_ImmersiveModeProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B15 RID: 2837
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B16 RID: 2838
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B17 RID: 2839
	private static readonly IntPtr NativeMethodInfoPtr_enableImmersiveMode_Public_Static_Void_0;

	// Token: 0x04000B18 RID: 2840
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
