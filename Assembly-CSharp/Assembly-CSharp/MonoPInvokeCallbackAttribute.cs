using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000020 RID: 32
public class MonoPInvokeCallbackAttribute : Attribute
{
	// Token: 0x060005C6 RID: 1478 RVA: 0x00005709 File Offset: 0x00003909
	// Note: this type is marked as 'beforefieldinit'.
	static MonoPInvokeCallbackAttribute()
	{
		Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MonoPInvokeCallbackAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr);
		MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr, 100663689);
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0002B424 File Offset: 0x00029624
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoPInvokeCallbackAttribute(Type t)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00005742 File Offset: 0x00003942
	public MonoPInvokeCallbackAttribute(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000398 RID: 920
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
}
