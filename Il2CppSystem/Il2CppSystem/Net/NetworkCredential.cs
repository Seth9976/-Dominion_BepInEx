using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security;

namespace Il2CppSystem.Net
{
	// Token: 0x020000D2 RID: 210
	public class NetworkCredential : Object
	{
		// Token: 0x06000C17 RID: 3095 RVA: 0x0003DBEC File Offset: 0x0003BDEC
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkCredential()
		{
			Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetworkCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr);
			NetworkCredential.NativeFieldInfoPtr_m_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, "m_domain");
			NetworkCredential.NativeFieldInfoPtr_m_userName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, "m_userName");
			NetworkCredential.NativeFieldInfoPtr_m_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, "m_password");
			NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100664995);
			NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100664996);
			NetworkCredential.NativeMethodInfoPtr_get_UserName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100664997);
			NetworkCredential.NativeMethodInfoPtr_set_UserName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100664998);
			NetworkCredential.NativeMethodInfoPtr_get_Password_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100664999);
			NetworkCredential.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100665000);
			NetworkCredential.NativeMethodInfoPtr_get_Domain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100665001);
			NetworkCredential.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100665002);
			NetworkCredential.NativeMethodInfoPtr_InternalGetUserName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100665003);
			NetworkCredential.NativeMethodInfoPtr_InternalGetPassword_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100665004);
			NetworkCredential.NativeMethodInfoPtr_InternalGetDomain_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100665005);
			NetworkCredential.NativeMethodInfoPtr_GetCredential_Public_Virtual_Final_New_NetworkCredential_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100665006);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0003DD48 File Offset: 0x0003BF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46365, RefRangeEnd = 46366, XrefRangeStart = 46356, XrefRangeEnd = 46365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkCredential(string userName, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0003DDA8 File Offset: 0x0003BFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46373, RefRangeEnd = 46374, XrefRangeStart = 46366, XrefRangeEnd = 46373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkCredential(string userName, string password, string domain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(domain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0003DE18 File Offset: 0x0003C018
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x0003DE50 File Offset: 0x0003C050
		public unsafe string UserName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_get_UserName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46374, XrefRangeEnd = 46375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_set_UserName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0003DE94 File Offset: 0x0003C094
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0003DECC File Offset: 0x0003C0CC
		public unsafe string Password
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 46376, RefRangeEnd = 46383, XrefRangeStart = 46375, XrefRangeEnd = 46376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_get_Password_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46383, XrefRangeEnd = 46384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0003DF10 File Offset: 0x0003C110
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x0003DF48 File Offset: 0x0003C148
		public unsafe string Domain
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_get_Domain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46384, XrefRangeEnd = 46385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0003DF8C File Offset: 0x0003C18C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetUserName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_InternalGetUserName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003DFC4 File Offset: 0x0003C1C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 46376, RefRangeEnd = 46383, XrefRangeStart = 46376, XrefRangeEnd = 46383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetPassword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_InternalGetPassword_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0003DFFC File Offset: 0x0003C1FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetDomain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_InternalGetDomain_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0003E034 File Offset: 0x0003C234
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual NetworkCredential GetCredential(Uri uri, string authType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_GetCredential_Public_Virtual_Final_New_NetworkCredential_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00006C52 File Offset: 0x00004E52
		public NetworkCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0003E098 File Offset: 0x0003C298
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00006C5B File Offset: 0x00004E5B
		public unsafe string m_domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0003E0C0 File Offset: 0x0003C2C0
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00006C7A File Offset: 0x00004E7A
		public unsafe string m_userName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_userName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_userName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0003E0E8 File Offset: 0x0003C2E8
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00006C99 File Offset: 0x00004E99
		public unsafe SecureString m_password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeFieldInfoPtr_m_domain;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_m_userName;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr_m_password;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_get_String_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_set_UserName_Public_set_Void_String_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_get_Password_Public_get_String_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_get_String_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUserName_Internal_String_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPassword_Internal_String_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDomain_Internal_String_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_GetCredential_Public_Virtual_Final_New_NetworkCredential_Uri_String_0;
	}
}
