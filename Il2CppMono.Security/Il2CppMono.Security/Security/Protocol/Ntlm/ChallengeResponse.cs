using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x0200000F RID: 15
	public class ChallengeResponse : Object
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00006FF4 File Offset: 0x000051F4
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeResponse()
		{
			Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "ChallengeResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr);
			ChallengeResponse.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "magic");
			ChallengeResponse.NativeFieldInfoPtr_nullEncMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "nullEncMagic");
			ChallengeResponse.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_disposed");
			ChallengeResponse.NativeFieldInfoPtr__challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_challenge");
			ChallengeResponse.NativeFieldInfoPtr__lmpwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_lmpwd");
			ChallengeResponse.NativeFieldInfoPtr__ntpwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_ntpwd");
			ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663435);
			ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663436);
			ChallengeResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663437);
			ChallengeResponse.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663438);
			ChallengeResponse.NativeMethodInfoPtr_set_Challenge_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663439);
			ChallengeResponse.NativeMethodInfoPtr_get_LM_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663440);
			ChallengeResponse.NativeMethodInfoPtr_get_NT_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663441);
			ChallengeResponse.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663442);
			ChallengeResponse.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663443);
			ChallengeResponse.NativeMethodInfoPtr_GetResponse_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663444);
			ChallengeResponse.NativeMethodInfoPtr_PrepareDESKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663445);
			ChallengeResponse.NativeMethodInfoPtr_PasswordToKey_Private_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663446);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000718C File Offset: 0x0000538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8238, XrefRangeEnd = 8244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000071C8 File Offset: 0x000053C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8244, XrefRangeEnd = 8255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeResponse(string password, Il2CppStructArray<byte> challenge)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007228 File Offset: 0x00005428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8255, XrefRangeEnd = 8265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005B RID: 91
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00007264 File Offset: 0x00005464
		public unsafe string Password
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8311, RefRangeEnd = 8313, XrefRangeStart = 8265, XrefRangeEnd = 8311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000072A8 File Offset: 0x000054A8
		public unsafe Il2CppStructArray<byte> Challenge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8313, XrefRangeEnd = 8317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_set_Challenge_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000072EC File Offset: 0x000054EC
		public unsafe Il2CppStructArray<byte> LM
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8317, XrefRangeEnd = 8324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_get_LM_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000732C File Offset: 0x0000552C
		public unsafe Il2CppStructArray<byte> NT
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8324, XrefRangeEnd = 8331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_get_NT_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000736C File Offset: 0x0000556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8331, XrefRangeEnd = 8339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000073A0 File Offset: 0x000055A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8339, XrefRangeEnd = 8342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000073E0 File Offset: 0x000055E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 8359, RefRangeEnd = 8363, XrefRangeStart = 8342, XrefRangeEnd = 8359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetResponse(Il2CppStructArray<byte> pwd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pwd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_GetResponse_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007430 File Offset: 0x00005630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 8366, RefRangeEnd = 8370, XrefRangeStart = 8363, XrefRangeEnd = 8366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> PrepareDESKey(Il2CppStructArray<byte> key56bits, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key56bits);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_PrepareDESKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007490 File Offset: 0x00005690
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8385, RefRangeEnd = 8387, XrefRangeStart = 8370, XrefRangeEnd = 8385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> PasswordToKey(string password, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_PasswordToKey_Private_Il2CppStructArray_1_Byte_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002726 File Offset: 0x00000926
		public ChallengeResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000074F0 File Offset: 0x000056F0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000272F File Offset: 0x0000092F
		public unsafe static Il2CppStructArray<byte> magic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse.NativeFieldInfoPtr_magic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse.NativeFieldInfoPtr_magic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00007518 File Offset: 0x00005718
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002741 File Offset: 0x00000941
		public unsafe static Il2CppStructArray<byte> nullEncMagic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse.NativeFieldInfoPtr_nullEncMagic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse.NativeFieldInfoPtr_nullEncMagic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00007540 File Offset: 0x00005740
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002753 File Offset: 0x00000953
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00007568 File Offset: 0x00005768
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000276E File Offset: 0x0000096E
		public unsafe Il2CppStructArray<byte> _challenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__challenge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__challenge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00007598 File Offset: 0x00005798
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000278D File Offset: 0x0000098D
		public unsafe Il2CppStructArray<byte> _lmpwd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__lmpwd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__lmpwd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000075C8 File Offset: 0x000057C8
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000027AC File Offset: 0x000009AC
		public unsafe Il2CppStructArray<byte> _ntpwd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__ntpwd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__ntpwd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_magic;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_nullEncMagic;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr__challenge;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr__lmpwd;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr__ntpwd;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_set_Challenge_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_LM_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_NT_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDESKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_PasswordToKey_Private_Il2CppStructArray_1_Byte_String_Int32_0;
	}
}
