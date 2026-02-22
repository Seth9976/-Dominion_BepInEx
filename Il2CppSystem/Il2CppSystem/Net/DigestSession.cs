using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppSystem.Net
{
	// Token: 0x02000103 RID: 259
	public class DigestSession : Object
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x00049008 File Offset: 0x00047208
		// Note: this type is marked as 'beforefieldinit'.
		static DigestSession()
		{
			Il2CppClassPointerStore<DigestSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "DigestSession");
			DigestSession.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "rng");
			DigestSession.NativeFieldInfoPtr_lastUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "lastUse");
			DigestSession.NativeFieldInfoPtr__nc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "_nc");
			DigestSession.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "hash");
			DigestSession.NativeFieldInfoPtr_parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "parser");
			DigestSession.NativeFieldInfoPtr__cnonce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "_cnonce");
			DigestSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665401);
			DigestSession.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665402);
			DigestSession.NativeMethodInfoPtr_get_Realm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665403);
			DigestSession.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665404);
			DigestSession.NativeMethodInfoPtr_get_Opaque_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665405);
			DigestSession.NativeMethodInfoPtr_get_QOP_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665406);
			DigestSession.NativeMethodInfoPtr_get_CNonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665407);
			DigestSession.NativeMethodInfoPtr_Parse_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665408);
			DigestSession.NativeMethodInfoPtr_HashToHexString_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665409);
			DigestSession.NativeMethodInfoPtr_HA1_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665410);
			DigestSession.NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665411);
			DigestSession.NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665412);
			DigestSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665413);
			DigestSession.NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665414);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000491C0 File Offset: 0x000473C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49799, XrefRangeEnd = 49804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigestSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigestSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x000491FC File Offset: 0x000473FC
		public unsafe string Algorithm
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 49804, RefRangeEnd = 49806, XrefRangeStart = 49804, XrefRangeEnd = 49804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00049234 File Offset: 0x00047434
		public unsafe string Realm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49806, RefRangeEnd = 49807, XrefRangeStart = 49806, XrefRangeEnd = 49806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Realm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0004926C File Offset: 0x0004746C
		public unsafe string Nonce
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 49807, RefRangeEnd = 49809, XrefRangeStart = 49807, XrefRangeEnd = 49807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000492A4 File Offset: 0x000474A4
		public unsafe string Opaque
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 49809, RefRangeEnd = 49811, XrefRangeStart = 49809, XrefRangeEnd = 49809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Opaque_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x000492DC File Offset: 0x000474DC
		public unsafe string QOP
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49811, RefRangeEnd = 49814, XrefRangeStart = 49811, XrefRangeEnd = 49811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_QOP_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00049314 File Offset: 0x00047514
		public unsafe string CNonce
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 49826, RefRangeEnd = 49831, XrefRangeStart = 49814, XrefRangeEnd = 49826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_CNonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0004934C File Offset: 0x0004754C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49849, RefRangeEnd = 49851, XrefRangeStart = 49831, XrefRangeEnd = 49849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse(string challenge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Parse_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0004939C File Offset: 0x0004759C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 49862, RefRangeEnd = 49869, XrefRangeStart = 49851, XrefRangeEnd = 49862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HashToHexString(string toBeHashed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(toBeHashed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HashToHexString_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x000493E4 File Offset: 0x000475E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49869, XrefRangeEnd = 49888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HA1(string username, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HA1_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00049440 File Offset: 0x00047640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49888, XrefRangeEnd = 49899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HA2(HttpWebRequest webRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00049488 File Offset: 0x00047688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49950, RefRangeEnd = 49951, XrefRangeStart = 49899, XrefRangeEnd = 49950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Response(string username, string password, HttpWebRequest webRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000494F4 File Offset: 0x000476F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50026, RefRangeEnd = 50027, XrefRangeStart = 49951, XrefRangeEnd = 50026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00049558 File Offset: 0x00047758
		public unsafe DateTime LastUse
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00007F78 File Offset: 0x00006178
		public DigestSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00049594 File Offset: 0x00047794
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x00007F81 File Offset: 0x00006181
		public unsafe static RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DigestSession.NativeFieldInfoPtr_rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigestSession.NativeFieldInfoPtr_rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000495BC File Offset: 0x000477BC
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x00007F93 File Offset: 0x00006193
		public unsafe DateTime lastUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_lastUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_lastUse)) = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000495E4 File Offset: 0x000477E4
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00007FAE File Offset: 0x000061AE
		public unsafe int _nc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__nc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__nc)) = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0004960C File Offset: 0x0004780C
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00007FC9 File Offset: 0x000061C9
		public unsafe HashAlgorithm hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_hash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_hash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0004963C File Offset: 0x0004783C
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00007FE8 File Offset: 0x000061E8
		public unsafe DigestHeaderParser parser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_parser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DigestHeaderParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_parser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0004966C File Offset: 0x0004786C
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00008007 File Offset: 0x00006207
		public unsafe string _cnonce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__cnonce);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__cnonce), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr_lastUse;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeFieldInfoPtr__nc;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_hash;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_parser;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr__cnonce;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_get_Realm_Public_get_String_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_get_Opaque_Public_get_String_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_get_QOP_Public_get_String_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_get_CNonce_Public_get_String_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_String_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_HashToHexString_Private_String_String_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_HA1_Private_String_String_String_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0;
	}
}
