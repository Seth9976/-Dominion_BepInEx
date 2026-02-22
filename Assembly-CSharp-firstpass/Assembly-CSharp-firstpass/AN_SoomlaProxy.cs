using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000006 RID: 6
public class AN_SoomlaProxy : Object
{
	// Token: 0x06000034 RID: 52 RVA: 0x00017778 File Offset: 0x00015978
	// Note: this type is marked as 'beforefieldinit'.
	static AN_SoomlaProxy()
	{
		Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_SoomlaProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr);
		AN_SoomlaProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, "CLASS_NAME");
		AN_SoomlaProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663336);
		AN_SoomlaProxy.NativeMethodInfoPtr_Initalize_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663337);
		AN_SoomlaProxy.NativeMethodInfoPtr_SetBillingState_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663338);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseStarted_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663339);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseFinished_Public_Static_Void_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663340);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseFailed_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663341);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseCancelled_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663342);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialLogin_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663343);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialLoginFinished_Public_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663344);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialLogout_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663345);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialShare_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663346);
		AN_SoomlaProxy.NativeMethodInfoPtr_OnFriendsRequest_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663347);
		AN_SoomlaProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr, 100663348);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000178C0 File Offset: 0x00015AC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159637, XrefRangeEnd = 159638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00017918 File Offset: 0x00015B18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159638, XrefRangeEnd = 159645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initalize(string gameKey, string envtKey)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(gameKey);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(envtKey);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_Initalize_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00017960 File Offset: 0x00015B60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159645, XrefRangeEnd = 159654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBillingState(bool state)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_SetBillingState_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00017994 File Offset: 0x00015B94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159654, XrefRangeEnd = 159660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnMarketPurchaseStarted(string productId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseStarted_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000179CC File Offset: 0x00015BCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159660, XrefRangeEnd = 159671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnMarketPurchaseFinished(string marketProductId, long marketPriceMicros, string marketCurrencyCode)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(marketProductId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref marketPriceMicros;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(marketCurrencyCode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseFinished_Public_Static_Void_String_Int64_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00017A24 File Offset: 0x00015C24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159671, XrefRangeEnd = 159676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnMarketPurchaseFailed()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseFailed_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00017A4C File Offset: 0x00015C4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159676, XrefRangeEnd = 159682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnMarketPurchaseCancelled(string productId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnMarketPurchaseCancelled_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00017A84 File Offset: 0x00015C84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159682, XrefRangeEnd = 159694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSocialLogin(int eventType, int providerId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref providerId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialLogin_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00017AC4 File Offset: 0x00015CC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159694, XrefRangeEnd = 159704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSocialLoginFinished(int providerId, string profileId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref providerId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(profileId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialLoginFinished_Public_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00017B08 File Offset: 0x00015D08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159704, XrefRangeEnd = 159716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSocialLogout(int eventType, int providerId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref providerId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialLogout_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00017B48 File Offset: 0x00015D48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159716, XrefRangeEnd = 159728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSocialShare(int eventType, int providerId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref providerId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnSocialShare_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00017B88 File Offset: 0x00015D88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159728, XrefRangeEnd = 159740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnFriendsRequest(int eventType, int providerId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref providerId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr_OnFriendsRequest_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00017BC8 File Offset: 0x00015DC8
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_SoomlaProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_SoomlaProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000020B8 File Offset: 0x000002B8
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_SoomlaProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000020C6 File Offset: 0x000002C6
	public AN_SoomlaProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000044 RID: 68 RVA: 0x00017C04 File Offset: 0x00015E04
	// (set) Token: 0x06000045 RID: 69 RVA: 0x000020CF File Offset: 0x000002CF
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SoomlaProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SoomlaProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeMethodInfoPtr_Initalize_Public_Static_Void_String_String_0;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeMethodInfoPtr_SetBillingState_Public_Static_Void_Boolean_0;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeMethodInfoPtr_OnMarketPurchaseStarted_Public_Static_Void_String_0;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeMethodInfoPtr_OnMarketPurchaseFinished_Public_Static_Void_String_Int64_String_0;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeMethodInfoPtr_OnMarketPurchaseFailed_Public_Static_Void_0;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeMethodInfoPtr_OnMarketPurchaseCancelled_Public_Static_Void_String_0;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeMethodInfoPtr_OnSocialLogin_Public_Static_Void_Int32_Int32_0;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr_OnSocialLoginFinished_Public_Static_Void_Int32_String_0;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_OnSocialLogout_Public_Static_Void_Int32_Int32_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_OnSocialShare_Public_Static_Void_Int32_Int32_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_OnFriendsRequest_Public_Static_Void_Int32_Int32_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
