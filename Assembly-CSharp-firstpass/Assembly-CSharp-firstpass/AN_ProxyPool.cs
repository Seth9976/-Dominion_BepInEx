using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C8 RID: 200
public class AN_ProxyPool : Object
{
	// Token: 0x06000E72 RID: 3698 RVA: 0x0004A6E0 File Offset: 0x000488E0
	// Note: this type is marked as 'beforefieldinit'.
	static AN_ProxyPool()
	{
		Il2CppClassPointerStore<AN_ProxyPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_ProxyPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_ProxyPool>.NativeClassPtr);
		AN_ProxyPool.NativeMethodInfoPtr_CallStatic_Public_Static_Void_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_ProxyPool>.NativeClassPtr, 100665118);
		AN_ProxyPool.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_ProxyPool>.NativeClassPtr, 100665119);
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x0004A738 File Offset: 0x00048938
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallStatic(string className, string methodName, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_ProxyPool.NativeMethodInfoPtr_CallStatic_Public_Static_Void_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x0004A7A0 File Offset: 0x000489A0
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_ProxyPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_ProxyPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_ProxyPool.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x00007776 File Offset: 0x00005976
	public static void CallStatic(string className, string methodName, params Object[] args)
	{
		AN_ProxyPool.CallStatic(className, methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00007785 File Offset: 0x00005985
	public AN_ProxyPool(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000B3A RID: 2874
	private static readonly IntPtr NativeMethodInfoPtr_CallStatic_Public_Static_Void_String_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B3B RID: 2875
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
