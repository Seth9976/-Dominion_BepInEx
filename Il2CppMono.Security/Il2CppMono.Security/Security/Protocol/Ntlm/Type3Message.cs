using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000017 RID: 23
	public class Type3Message : MessageBase
	{
		// Token: 0x0600014D RID: 333 RVA: 0x0000853C File Offset: 0x0000673C
		// Note: this type is marked as 'beforefieldinit'.
		static Type3Message()
		{
			Il2CppClassPointerStore<Type3Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "Type3Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Type3Message>.NativeClassPtr);
			Type3Message.NativeFieldInfoPtr__level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_level");
			Type3Message.NativeFieldInfoPtr__challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_challenge");
			Type3Message.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_host");
			Type3Message.NativeFieldInfoPtr__domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_domain");
			Type3Message.NativeFieldInfoPtr__username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_username");
			Type3Message.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_password");
			Type3Message.NativeFieldInfoPtr__type2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_type2");
			Type3Message.NativeFieldInfoPtr__lm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_lm");
			Type3Message.NativeFieldInfoPtr__nt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_nt");
			Type3Message.NativeMethodInfoPtr__ctor_Public_Void_Type2Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663481);
			Type3Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663482);
			Type3Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663483);
			Type3Message.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663484);
			Type3Message.NativeMethodInfoPtr_set_Username_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663485);
			Type3Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663486);
			Type3Message.NativeMethodInfoPtr_DecodeString_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663487);
			Type3Message.NativeMethodInfoPtr_EncodeString_Private_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663488);
			Type3Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663489);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000086D4 File Offset: 0x000068D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8934, RefRangeEnd = 8935, XrefRangeStart = 8907, XrefRangeEnd = 8934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type3Message(Type2Message type2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Type3Message>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr__ctor_Public_Void_Type2Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00008720 File Offset: 0x00006920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8935, XrefRangeEnd = 8941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type3Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700007B RID: 123
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000875C File Offset: 0x0000695C
		public unsafe string Domain
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8944, RefRangeEnd = 8945, XrefRangeStart = 8941, XrefRangeEnd = 8944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000087A0 File Offset: 0x000069A0
		public unsafe string Password
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (set) Token: 0x06000152 RID: 338 RVA: 0x000087E4 File Offset: 0x000069E4
		public unsafe string Username
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_set_Username_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00008828 File Offset: 0x00006A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8945, XrefRangeEnd = 8974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type3Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00008878 File Offset: 0x00006A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8974, XrefRangeEnd = 8978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DecodeString(Il2CppStructArray<byte> buffer, int offset, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_DecodeString_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000088DC File Offset: 0x00006ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8978, XrefRangeEnd = 8985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> EncodeString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_EncodeString_Private_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000892C File Offset: 0x00006B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8985, XrefRangeEnd = 9043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type3Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000290D File Offset: 0x00000B0D
		public Type3Message(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00008978 File Offset: 0x00006B78
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002916 File Offset: 0x00000B16
		public unsafe NtlmAuthLevel _level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__level)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000089A0 File Offset: 0x00006BA0
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002931 File Offset: 0x00000B31
		public unsafe Il2CppStructArray<byte> _challenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__challenge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__challenge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000089D0 File Offset: 0x00006BD0
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002950 File Offset: 0x00000B50
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000089F8 File Offset: 0x00006BF8
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0000296F File Offset: 0x00000B6F
		public unsafe string _domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00008A20 File Offset: 0x00006C20
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000298E File Offset: 0x00000B8E
		public unsafe string _username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00008A48 File Offset: 0x00006C48
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000029AD File Offset: 0x00000BAD
		public unsafe string _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00008A70 File Offset: 0x00006C70
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000029CC File Offset: 0x00000BCC
		public unsafe Type2Message _type2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__type2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type2Message>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__type2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00008AA0 File Offset: 0x00006CA0
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000029EB File Offset: 0x00000BEB
		public unsafe Il2CppStructArray<byte> _lm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__lm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__lm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00008AD0 File Offset: 0x00006CD0
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002A0A File Offset: 0x00000C0A
		public unsafe Il2CppStructArray<byte> _nt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__nt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__nt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr__level;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr__challenge;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr__domain;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr__username;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr__type2;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr__lm;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr__nt;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type2Message_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_set_Username_Public_set_Void_String_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_EncodeString_Private_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
