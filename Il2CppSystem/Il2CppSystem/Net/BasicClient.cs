using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FE RID: 254
	public class BasicClient : Object
	{
		// Token: 0x06000EF1 RID: 3825 RVA: 0x000487B0 File Offset: 0x000469B0
		// Note: this type is marked as 'beforefieldinit'.
		static BasicClient()
		{
			Il2CppClassPointerStore<BasicClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "BasicClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicClient>.NativeClassPtr);
			BasicClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicClient>.NativeClassPtr, 100665381);
			BasicClient.NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicClient>.NativeClassPtr, 100665382);
			BasicClient.NativeMethodInfoPtr_InternalAuthenticate_Private_Static_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicClient>.NativeClassPtr, 100665383);
			BasicClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicClient>.NativeClassPtr, 100665384);
			BasicClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicClient>.NativeClassPtr, 100665385);
			BasicClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicClient>.NativeClassPtr, 100665386);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00048858 File Offset: 0x00046A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49686, XrefRangeEnd = 49692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000488CC File Offset: 0x00046ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49696, RefRangeEnd = 49697, XrefRangeStart = 49692, XrefRangeEnd = 49696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicClient.NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00048910 File Offset: 0x00046B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49745, RefRangeEnd = 49747, XrefRangeStart = 49697, XrefRangeEnd = 49745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicClient.NativeMethodInfoPtr_InternalAuthenticate_Private_Static_Authorization_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00048968 File Offset: 0x00046B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49747, XrefRangeEnd = 49748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000489CC File Offset: 0x00046BCC
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49748, XrefRangeEnd = 49750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00048A04 File Offset: 0x00046C04
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00007E82 File Offset: 0x00006082
		public BasicClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_InternalAuthenticate_Private_Static_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
