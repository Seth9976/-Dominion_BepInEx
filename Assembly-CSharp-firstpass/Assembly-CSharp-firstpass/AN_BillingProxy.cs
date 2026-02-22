using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000B8 RID: 184
public class AN_BillingProxy : Object
{
	// Token: 0x06000D61 RID: 3425 RVA: 0x00046074 File Offset: 0x00044274
	// Note: this type is marked as 'beforefieldinit'.
	static AN_BillingProxy()
	{
		Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_BillingProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr);
		AN_BillingProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, "CLASS_NAME");
		AN_BillingProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, 100664925);
		AN_BillingProxy.NativeMethodInfoPtr_Connect_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, 100664926);
		AN_BillingProxy.NativeMethodInfoPtr_RetrieveProducDetails_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, 100664927);
		AN_BillingProxy.NativeMethodInfoPtr_Consume_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, 100664928);
		AN_BillingProxy.NativeMethodInfoPtr_Purchase_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, 100664929);
		AN_BillingProxy.NativeMethodInfoPtr_Subscribe_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, 100664930);
		AN_BillingProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr, 100664931);
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00046144 File Offset: 0x00044344
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177256, XrefRangeEnd = 177257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_BillingProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x0004619C File Offset: 0x0004439C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177257, XrefRangeEnd = 177264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Connect(string ids, string base64EncodedPublicKey)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ids);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(base64EncodedPublicKey);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_BillingProxy.NativeMethodInfoPtr_Connect_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x000461E4 File Offset: 0x000443E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177264, XrefRangeEnd = 177269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RetrieveProducDetails()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_BillingProxy.NativeMethodInfoPtr_RetrieveProducDetails_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x0004620C File Offset: 0x0004440C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177269, XrefRangeEnd = 177275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Consume(string SKU)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_BillingProxy.NativeMethodInfoPtr_Consume_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00046244 File Offset: 0x00044444
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177275, XrefRangeEnd = 177282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Purchase(string SKU, string developerPayload)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_BillingProxy.NativeMethodInfoPtr_Purchase_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x0004628C File Offset: 0x0004448C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 177289, RefRangeEnd = 177293, XrefRangeStart = 177282, XrefRangeEnd = 177289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Subscribe(string SKU, string developerPayload)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_BillingProxy.NativeMethodInfoPtr_Subscribe_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x000462D4 File Offset: 0x000444D4
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_BillingProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_BillingProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_BillingProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x000074E6 File Offset: 0x000056E6
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_BillingProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x000074F4 File Offset: 0x000056F4
	public AN_BillingProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00046310 File Offset: 0x00044510
	// (set) Token: 0x06000D6C RID: 3436 RVA: 0x000074FD File Offset: 0x000056FD
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_BillingProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_BillingProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000A69 RID: 2665
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000A6A RID: 2666
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A6B RID: 2667
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Void_String_String_0;

	// Token: 0x04000A6C RID: 2668
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducDetails_Public_Static_Void_0;

	// Token: 0x04000A6D RID: 2669
	private static readonly IntPtr NativeMethodInfoPtr_Consume_Public_Static_Void_String_0;

	// Token: 0x04000A6E RID: 2670
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Static_Void_String_String_0;

	// Token: 0x04000A6F RID: 2671
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Static_Void_String_String_0;

	// Token: 0x04000A70 RID: 2672
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
