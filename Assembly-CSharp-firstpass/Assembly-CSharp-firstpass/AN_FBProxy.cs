using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000BA RID: 186
public class AN_FBProxy : MonoBehaviour
{
	// Token: 0x06000D79 RID: 3449 RVA: 0x000465FC File Offset: 0x000447FC
	// Note: this type is marked as 'beforefieldinit'.
	static AN_FBProxy()
	{
		Il2CppClassPointerStore<AN_FBProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_FBProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_FBProxy>.NativeClassPtr);
		AN_FBProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_FBProxy>.NativeClassPtr, "CLASS_NAME");
		AN_FBProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_FBProxy>.NativeClassPtr, 100664939);
		AN_FBProxy.NativeMethodInfoPtr_SendTrunRequest_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_FBProxy>.NativeClassPtr, 100664940);
		AN_FBProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_FBProxy>.NativeClassPtr, 100664941);
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x0004667C File Offset: 0x0004487C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177336, XrefRangeEnd = 177337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_FBProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x000466D4 File Offset: 0x000448D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177346, RefRangeEnd = 177347, XrefRangeStart = 177337, XrefRangeEnd = 177346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendTrunRequest(string title, string messgae, string data, string to)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messgae);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(to);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_FBProxy.NativeMethodInfoPtr_SendTrunRequest_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00046740 File Offset: 0x00044940
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_FBProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_FBProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_FBProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00007538 File Offset: 0x00005738
	public static void CallActivityFunction(string methodName, params global::Il2CppSystem.Object[] args)
	{
		AN_FBProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x00007546 File Offset: 0x00005746
	public AN_FBProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0004677C File Offset: 0x0004497C
	// (set) Token: 0x06000D80 RID: 3456 RVA: 0x0000754F File Offset: 0x0000574F
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_FBProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_FBProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000A79 RID: 2681
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000A7A RID: 2682
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A7B RID: 2683
	private static readonly IntPtr NativeMethodInfoPtr_SendTrunRequest_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000A7C RID: 2684
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
