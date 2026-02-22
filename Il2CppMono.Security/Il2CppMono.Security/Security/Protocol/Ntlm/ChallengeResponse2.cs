using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000010 RID: 16
	public static class ChallengeResponse2 : Object
	{
		// Token: 0x0600010F RID: 271 RVA: 0x000075F8 File Offset: 0x000057F8
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeResponse2()
		{
			Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "ChallengeResponse2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr);
			ChallengeResponse2.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, "magic");
			ChallengeResponse2.NativeFieldInfoPtr_nullEncMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, "nullEncMagic");
			ChallengeResponse2.NativeMethodInfoPtr_Compute_LM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663448);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Password_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663449);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663450);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Session_Private_Static_Void_String_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663451);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Private_Static_Il2CppStructArray_1_Byte_Type2Message_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663452);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_Public_Static_Void_Type2Message_NtlmAuthLevel_String_String_String_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663453);
			ChallengeResponse2.NativeMethodInfoPtr_GetResponse_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663454);
			ChallengeResponse2.NativeMethodInfoPtr_PrepareDESKey_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663455);
			ChallengeResponse2.NativeMethodInfoPtr_PasswordToKey_Private_Static_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663456);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00007704 File Offset: 0x00005904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8387, XrefRangeEnd = 8423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_LM(string password, Il2CppStructArray<byte> challenge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_LM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000775C File Offset: 0x0000595C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 8435, RefRangeEnd = 8438, XrefRangeStart = 8423, XrefRangeEnd = 8435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_NTLM_Password(string password)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Password_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000077A0 File Offset: 0x000059A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8443, RefRangeEnd = 8444, XrefRangeStart = 8438, XrefRangeEnd = 8443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_NTLM(string password, Il2CppStructArray<byte> challenge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000077F8 File Offset: 0x000059F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8444, XrefRangeEnd = 8474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Compute_NTLMv2_Session(string password, Il2CppStructArray<byte> challenge, out Il2CppStructArray<byte> lm, out Il2CppStructArray<byte> ntlm)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Session_Private_Static_Void_String_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			lm = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ntlm = ((intPtr6 == 0) ? null : new Il2CppStructArray<byte>(intPtr6));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007884 File Offset: 0x00005A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8529, RefRangeEnd = 8530, XrefRangeStart = 8474, XrefRangeEnd = 8529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_NTLMv2(Type2Message type2, string username, string password, string domain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type2);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(domain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Private_Static_Il2CppStructArray_1_Byte_Type2Message_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00007900 File Offset: 0x00005B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8539, RefRangeEnd = 8540, XrefRangeStart = 8530, XrefRangeEnd = 8539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out Il2CppStructArray<byte> lm, out Il2CppStructArray<byte> ntlm)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type2);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(domain);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_Public_Static_Void_Type2Message_NtlmAuthLevel_String_String_String_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			lm = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ntlm = ((intPtr6 == 0) ? null : new Il2CppStructArray<byte>(intPtr6));
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000079C4 File Offset: 0x00005BC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 8560, RefRangeEnd = 8563, XrefRangeStart = 8540, XrefRangeEnd = 8560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetResponse(Il2CppStructArray<byte> challenge, Il2CppStructArray<byte> pwd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pwd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_GetResponse_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007A1C File Offset: 0x00005C1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 8566, RefRangeEnd = 8570, XrefRangeStart = 8563, XrefRangeEnd = 8566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PrepareDESKey(Il2CppStructArray<byte> key56bits, int position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key56bits);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_PrepareDESKey_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00007A70 File Offset: 0x00005C70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8588, RefRangeEnd = 8590, XrefRangeStart = 8570, XrefRangeEnd = 8588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PasswordToKey(string password, int position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_PasswordToKey_Private_Static_Il2CppStructArray_1_Byte_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000027CB File Offset: 0x000009CB
		public ChallengeResponse2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00007AC4 File Offset: 0x00005CC4
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000027D4 File Offset: 0x000009D4
		public unsafe static Il2CppStructArray<byte> magic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse2.NativeFieldInfoPtr_magic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse2.NativeFieldInfoPtr_magic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00007AEC File Offset: 0x00005CEC
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000027E6 File Offset: 0x000009E6
		public unsafe static Il2CppStructArray<byte> nullEncMagic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse2.NativeFieldInfoPtr_nullEncMagic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse2.NativeFieldInfoPtr_nullEncMagic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_magic;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_nullEncMagic;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Compute_LM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLM_Password_Private_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLMv2_Session_Private_Static_Void_String_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLMv2_Private_Static_Il2CppStructArray_1_Byte_Type2Message_String_String_String_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Static_Void_Type2Message_NtlmAuthLevel_String_String_String_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDESKey_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_PasswordToKey_Private_Static_Il2CppStructArray_1_Byte_String_Int32_0;
	}
}
