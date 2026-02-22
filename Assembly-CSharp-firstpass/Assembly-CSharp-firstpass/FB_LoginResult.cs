using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000099 RID: 153
public class FB_LoginResult : FB_Result
{
	// Token: 0x06000B31 RID: 2865 RVA: 0x0003E50C File Offset: 0x0003C70C
	// Note: this type is marked as 'beforefieldinit'.
	static FB_LoginResult()
	{
		Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_LoginResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr);
		FB_LoginResult.NativeFieldInfoPtr__IsCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, "_IsCanceled");
		FB_LoginResult.NativeFieldInfoPtr__UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, "_UserId");
		FB_LoginResult.NativeFieldInfoPtr__AccessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, "_AccessToken");
		FB_LoginResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, 100664655);
		FB_LoginResult.NativeMethodInfoPtr_SetCredential_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, 100664656);
		FB_LoginResult.NativeMethodInfoPtr_get_UserId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, 100664657);
		FB_LoginResult.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, 100664658);
		FB_LoginResult.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr, 100664659);
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0003E5DC File Offset: 0x0003C7DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174204, XrefRangeEnd = 174205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_LoginResult(string RawData, string Error, bool isCanceled)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_LoginResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(RawData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCanceled;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LoginResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0003E648 File Offset: 0x0003C848
	[CallerCount(0)]
	public unsafe void SetCredential(string userId, string accessToken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LoginResult.NativeMethodInfoPtr_SetCredential_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000394 RID: 916
	// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0003E69C File Offset: 0x0003C89C
	public unsafe string UserId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LoginResult.NativeMethodInfoPtr_get_UserId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000395 RID: 917
	// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0003E6D4 File Offset: 0x0003C8D4
	public unsafe string AccessToken
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LoginResult.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0003E70C File Offset: 0x0003C90C
	public unsafe bool IsCanceled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LoginResult.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x0000672B File Offset: 0x0000492B
	public FB_LoginResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000391 RID: 913
	// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0003E748 File Offset: 0x0003C948
	// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00006734 File Offset: 0x00004934
	public unsafe bool _IsCanceled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LoginResult.NativeFieldInfoPtr__IsCanceled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LoginResult.NativeFieldInfoPtr__IsCanceled)) = value;
		}
	}

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0003E770 File Offset: 0x0003C970
	// (set) Token: 0x06000B3B RID: 2875 RVA: 0x0000674F File Offset: 0x0000494F
	public unsafe string _UserId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LoginResult.NativeFieldInfoPtr__UserId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LoginResult.NativeFieldInfoPtr__UserId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000393 RID: 915
	// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0003E798 File Offset: 0x0003C998
	// (set) Token: 0x06000B3D RID: 2877 RVA: 0x0000676E File Offset: 0x0000496E
	public unsafe string _AccessToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LoginResult.NativeFieldInfoPtr__AccessToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LoginResult.NativeFieldInfoPtr__AccessToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040008E5 RID: 2277
	private static readonly IntPtr NativeFieldInfoPtr__IsCanceled;

	// Token: 0x040008E6 RID: 2278
	private static readonly IntPtr NativeFieldInfoPtr__UserId;

	// Token: 0x040008E7 RID: 2279
	private static readonly IntPtr NativeFieldInfoPtr__AccessToken;

	// Token: 0x040008E8 RID: 2280
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;

	// Token: 0x040008E9 RID: 2281
	private static readonly IntPtr NativeMethodInfoPtr_SetCredential_Public_Void_String_String_0;

	// Token: 0x040008EA RID: 2282
	private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_get_String_0;

	// Token: 0x040008EB RID: 2283
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;

	// Token: 0x040008EC RID: 2284
	private static readonly IntPtr NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0;
}
