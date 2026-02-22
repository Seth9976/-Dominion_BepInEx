using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x02000104 RID: 260
	public class DigestClient : Object
	{
		// Token: 0x06000F34 RID: 3892 RVA: 0x00049694 File Offset: 0x00047894
		// Note: this type is marked as 'beforefieldinit'.
		static DigestClient()
		{
			Il2CppClassPointerStore<DigestClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "DigestClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigestClient>.NativeClassPtr);
			DigestClient.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestClient>.NativeClassPtr, "cache");
			DigestClient.NativeMethodInfoPtr_get_Cache_Private_Static_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestClient>.NativeClassPtr, 100665415);
			DigestClient.NativeMethodInfoPtr_CheckExpired_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestClient>.NativeClassPtr, 100665416);
			DigestClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestClient>.NativeClassPtr, 100665417);
			DigestClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestClient>.NativeClassPtr, 100665418);
			DigestClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestClient>.NativeClassPtr, 100665419);
			DigestClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestClient>.NativeClassPtr, 100665420);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00049750 File Offset: 0x00047950
		public unsafe static Hashtable Cache
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 50041, RefRangeEnd = 50043, XrefRangeStart = 50027, XrefRangeEnd = 50041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestClient.NativeMethodInfoPtr_get_Cache_Private_Static_get_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00049784 File Offset: 0x00047984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50107, RefRangeEnd = 50108, XrefRangeStart = 50043, XrefRangeEnd = 50107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckExpired(int count)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestClient.NativeMethodInfoPtr_CheckExpired_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000497B8 File Offset: 0x000479B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50108, XrefRangeEnd = 50134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0004982C File Offset: 0x00047A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50134, XrefRangeEnd = 50146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00049890 File Offset: 0x00047A90
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50146, XrefRangeEnd = 50148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x000498C8 File Offset: 0x00047AC8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigestClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigestClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00008026 File Offset: 0x00006226
		public DigestClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00049904 File Offset: 0x00047B04
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x0000802F File Offset: 0x0000622F
		public unsafe static Hashtable cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DigestClient.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigestClient.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Private_Static_get_Hashtable_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_CheckExpired_Private_Static_Void_Int32_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
