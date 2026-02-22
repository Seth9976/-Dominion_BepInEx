using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Unity
{
	// Token: 0x02000006 RID: 6
	public static class UnityTls : Object
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00010C74 File Offset: 0x0000EE74
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTls()
		{
			Il2CppClassPointerStore<UnityTls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls>.NativeClassPtr);
			UnityTls.NativeFieldInfoPtr_marshalledInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "marshalledInterface");
			UnityTls.NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663307);
			UnityTls.NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663308);
			UnityTls.NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663309);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31734, XrefRangeEnd = 31735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetUnityTlsInterface()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00010D24 File Offset: 0x0000EF24
		public unsafe static bool IsSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31736, RefRangeEnd = 31737, XrefRangeStart = 31735, XrefRangeEnd = 31736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00010D54 File Offset: 0x0000EF54
		public unsafe static UnityTls.unitytls_interface_struct NativeInterface
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 31750, RefRangeEnd = 31808, XrefRangeStart = 31737, XrefRangeEnd = 31750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct>(intPtr3) : null;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020CA File Offset: 0x000002CA
		public UnityTls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00010D88 File Offset: 0x0000EF88
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020D3 File Offset: 0x000002D3
		public unsafe static UnityTls.unitytls_interface_struct marshalledInterface
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityTls.NativeFieldInfoPtr_marshalledInterface, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityTls.NativeFieldInfoPtr_marshalledInterface, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_marshalledInterface;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0;

		// Token: 0x02000163 RID: 355
		public enum unitytls_error_code : uint
		{
			// Token: 0x04001155 RID: 4437
			UNITYTLS_SUCCESS,
			// Token: 0x04001156 RID: 4438
			UNITYTLS_INVALID_ARGUMENT,
			// Token: 0x04001157 RID: 4439
			UNITYTLS_INVALID_FORMAT,
			// Token: 0x04001158 RID: 4440
			UNITYTLS_INVALID_PASSWORD,
			// Token: 0x04001159 RID: 4441
			UNITYTLS_INVALID_STATE,
			// Token: 0x0400115A RID: 4442
			UNITYTLS_BUFFER_OVERFLOW,
			// Token: 0x0400115B RID: 4443
			UNITYTLS_OUT_OF_MEMORY,
			// Token: 0x0400115C RID: 4444
			UNITYTLS_INTERNAL_ERROR,
			// Token: 0x0400115D RID: 4445
			UNITYTLS_NOT_SUPPORTED,
			// Token: 0x0400115E RID: 4446
			UNITYTLS_ENTROPY_SOURCE_FAILED,
			// Token: 0x0400115F RID: 4447
			UNITYTLS_STREAM_CLOSED,
			// Token: 0x04001160 RID: 4448
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576U,
			// Token: 0x04001161 RID: 4449
			UNITYTLS_USER_WOULD_BLOCK,
			// Token: 0x04001162 RID: 4450
			UNITYTLS_USER_READ_FAILED,
			// Token: 0x04001163 RID: 4451
			UNITYTLS_USER_WRITE_FAILED,
			// Token: 0x04001164 RID: 4452
			UNITYTLS_USER_UNKNOWN_ERROR,
			// Token: 0x04001165 RID: 4453
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152U
		}

		// Token: 0x02000164 RID: 356
		[StructLayout(2)]
		public struct unitytls_errorstate
		{
			// Token: 0x060015C0 RID: 5568 RVA: 0x0006145C File Offset: 0x0005F65C
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_errorstate()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_errorstate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr);
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "magic");
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "code");
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "reserved");
			}

			// Token: 0x060015C1 RID: 5569 RVA: 0x0000AFDB File Offset: 0x000091DB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, ref this));
			}

			// Token: 0x04001166 RID: 4454
			private static readonly IntPtr NativeFieldInfoPtr_magic;

			// Token: 0x04001167 RID: 4455
			private static readonly IntPtr NativeFieldInfoPtr_code;

			// Token: 0x04001168 RID: 4456
			private static readonly IntPtr NativeFieldInfoPtr_reserved;

			// Token: 0x04001169 RID: 4457
			[FieldOffset(0)]
			public uint magic;

			// Token: 0x0400116A RID: 4458
			[FieldOffset(4)]
			public UnityTls.unitytls_error_code code;

			// Token: 0x0400116B RID: 4459
			[FieldOffset(8)]
			public ulong reserved;
		}

		// Token: 0x02000165 RID: 357
		[StructLayout(2)]
		public struct unitytls_key
		{
			// Token: 0x060015C2 RID: 5570 RVA: 0x0000AFED File Offset: 0x000091ED
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_key()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr);
			}

			// Token: 0x060015C3 RID: 5571 RVA: 0x0000B00D File Offset: 0x0000920D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000166 RID: 358
		[StructLayout(2)]
		public struct unitytls_key_ref
		{
			// Token: 0x060015C4 RID: 5572 RVA: 0x0000B01F File Offset: 0x0000921F
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_key_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr);
				UnityTls.unitytls_key_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x060015C5 RID: 5573 RVA: 0x0000B053 File Offset: 0x00009253
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x0400116C RID: 4460
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x0400116D RID: 4461
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x02000167 RID: 359
		[StructLayout(2)]
		public struct unitytls_x509_ref
		{
			// Token: 0x060015C6 RID: 5574 RVA: 0x0000B065 File Offset: 0x00009265
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr);
				UnityTls.unitytls_x509_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x060015C7 RID: 5575 RVA: 0x0000B099 File Offset: 0x00009299
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x0400116E RID: 4462
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x0400116F RID: 4463
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x02000168 RID: 360
		[StructLayout(2)]
		public struct unitytls_x509list
		{
			// Token: 0x060015C8 RID: 5576 RVA: 0x0000B0AB File Offset: 0x000092AB
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509list()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr);
			}

			// Token: 0x060015C9 RID: 5577 RVA: 0x0000B0CB File Offset: 0x000092CB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000169 RID: 361
		[StructLayout(2)]
		public struct unitytls_x509list_ref
		{
			// Token: 0x060015CA RID: 5578 RVA: 0x0000B0DD File Offset: 0x000092DD
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509list_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr);
				UnityTls.unitytls_x509list_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x060015CB RID: 5579 RVA: 0x0000B111 File Offset: 0x00009311
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x04001170 RID: 4464
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04001171 RID: 4465
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x0200016A RID: 362
		[Flags]
		public enum unitytls_x509verify_result : uint
		{
			// Token: 0x04001173 RID: 4467
			UNITYTLS_X509VERIFY_SUCCESS = 0U,
			// Token: 0x04001174 RID: 4468
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648U,
			// Token: 0x04001175 RID: 4469
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295U,
			// Token: 0x04001176 RID: 4470
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1U,
			// Token: 0x04001177 RID: 4471
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2U,
			// Token: 0x04001178 RID: 4472
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4U,
			// Token: 0x04001179 RID: 4473
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8U,
			// Token: 0x0400117A RID: 4474
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536U,
			// Token: 0x0400117B RID: 4475
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072U,
			// Token: 0x0400117C RID: 4476
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144U,
			// Token: 0x0400117D RID: 4477
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288U,
			// Token: 0x0400117E RID: 4478
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576U,
			// Token: 0x0400117F RID: 4479
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152U,
			// Token: 0x04001180 RID: 4480
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304U,
			// Token: 0x04001181 RID: 4481
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608U,
			// Token: 0x04001182 RID: 4482
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728U
		}

		// Token: 0x0200016B RID: 363
		public sealed class unitytls_x509verify_callback : MulticastDelegate
		{
			// Token: 0x060015CC RID: 5580 RVA: 0x0000B123 File Offset: 0x00009323
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509verify_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509verify_callback");
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663310);
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663311);
			}

			// Token: 0x060015CD RID: 5581 RVA: 0x000614C4 File Offset: 0x0005F6C4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509verify_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015CE RID: 5582 RVA: 0x00061520 File Offset: 0x0005F720
			[CallerCount(0)]
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060015CF RID: 5583 RVA: 0x0000B161 File Offset: 0x00009361
			public unitytls_x509verify_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001183 RID: 4483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001184 RID: 4484
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0;
		}

		// Token: 0x0200016C RID: 364
		[StructLayout(2)]
		public struct unitytls_tlsctx
		{
			// Token: 0x060015D0 RID: 5584 RVA: 0x0000B16A File Offset: 0x0000936A
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr);
			}

			// Token: 0x060015D1 RID: 5585 RVA: 0x0000B18A File Offset: 0x0000938A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200016D RID: 365
		[StructLayout(2)]
		public struct unitytls_x509name
		{
			// Token: 0x060015D2 RID: 5586 RVA: 0x0000B19C File Offset: 0x0000939C
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509name()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509name");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr);
			}

			// Token: 0x060015D3 RID: 5587 RVA: 0x0000B1BC File Offset: 0x000093BC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200016E RID: 366
		public enum unitytls_ciphersuite : uint
		{
			// Token: 0x04001186 RID: 4486
			UNITYTLS_CIPHERSUITE_INVALID = 16777215U
		}

		// Token: 0x0200016F RID: 367
		public enum unitytls_protocol : uint
		{
			// Token: 0x04001188 RID: 4488
			UNITYTLS_PROTOCOL_TLS_1_0,
			// Token: 0x04001189 RID: 4489
			UNITYTLS_PROTOCOL_TLS_1_1,
			// Token: 0x0400118A RID: 4490
			UNITYTLS_PROTOCOL_TLS_1_2,
			// Token: 0x0400118B RID: 4491
			UNITYTLS_PROTOCOL_INVALID
		}

		// Token: 0x02000170 RID: 368
		[StructLayout(2)]
		public struct unitytls_tlsctx_protocolrange
		{
			// Token: 0x060015D4 RID: 5588 RVA: 0x00061594 File Offset: 0x0005F794
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_protocolrange()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_protocolrange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr);
				UnityTls.unitytls_tlsctx_protocolrange.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, "min");
				UnityTls.unitytls_tlsctx_protocolrange.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, "max");
			}

			// Token: 0x060015D5 RID: 5589 RVA: 0x0000B1CE File Offset: 0x000093CE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, ref this));
			}

			// Token: 0x0400118C RID: 4492
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x0400118D RID: 4493
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x0400118E RID: 4494
			[FieldOffset(0)]
			public UnityTls.unitytls_protocol min;

			// Token: 0x0400118F RID: 4495
			[FieldOffset(4)]
			public UnityTls.unitytls_protocol max;
		}

		// Token: 0x02000171 RID: 369
		public sealed class unitytls_tlsctx_write_callback : MulticastDelegate
		{
			// Token: 0x060015D6 RID: 5590 RVA: 0x0000B1E0 File Offset: 0x000093E0
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_write_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_write_callback");
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663312);
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663313);
			}

			// Token: 0x060015D7 RID: 5591 RVA: 0x000615E8 File Offset: 0x0005F7E8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_write_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015D8 RID: 5592 RVA: 0x00061644 File Offset: 0x0005F844
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31656, RefRangeEnd = 31658, XrefRangeStart = 31656, XrefRangeEnd = 31656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060015D9 RID: 5593 RVA: 0x0000B21E File Offset: 0x0000941E
			public unitytls_tlsctx_write_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001190 RID: 4496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001191 RID: 4497
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000172 RID: 370
		public sealed class unitytls_tlsctx_read_callback : MulticastDelegate
		{
			// Token: 0x060015DA RID: 5594 RVA: 0x0000B227 File Offset: 0x00009427
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_read_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_read_callback");
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663314);
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663315);
			}

			// Token: 0x060015DB RID: 5595 RVA: 0x000616B8 File Offset: 0x0005F8B8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_read_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015DC RID: 5596 RVA: 0x00061714 File Offset: 0x0005F914
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31656, RefRangeEnd = 31658, XrefRangeStart = 31656, XrefRangeEnd = 31658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntPtr Invoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060015DD RID: 5597 RVA: 0x0000B265 File Offset: 0x00009465
			public unitytls_tlsctx_read_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001192 RID: 4498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001193 RID: 4499
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000173 RID: 371
		public sealed class unitytls_tlsctx_trace_callback : MulticastDelegate
		{
			// Token: 0x060015DE RID: 5598 RVA: 0x0000B26E File Offset: 0x0000946E
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_trace_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_trace_callback");
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663316);
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663317);
			}

			// Token: 0x060015DF RID: 5599 RVA: 0x00061788 File Offset: 0x0005F988
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_trace_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015E0 RID: 5600 RVA: 0x000617E4 File Offset: 0x0005F9E4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31662, RefRangeEnd = 31666, XrefRangeStart = 31658, XrefRangeEnd = 31662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = traceMessage;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref traceMessageLen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015E1 RID: 5601 RVA: 0x0000B2AC File Offset: 0x000094AC
			public unitytls_tlsctx_trace_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001194 RID: 4500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001195 RID: 4501
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0;
		}

		// Token: 0x02000174 RID: 372
		public sealed class unitytls_tlsctx_certificate_callback : MulticastDelegate
		{
			// Token: 0x060015E2 RID: 5602 RVA: 0x0000B2B5 File Offset: 0x000094B5
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_certificate_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_certificate_callback");
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663318);
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663319);
			}

			// Token: 0x060015E3 RID: 5603 RVA: 0x0006184C File Offset: 0x0005FA4C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_certificate_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015E4 RID: 5604 RVA: 0x000618A8 File Offset: 0x0005FAA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31666, XrefRangeEnd = 31670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015E5 RID: 5605 RVA: 0x0000B2F3 File Offset: 0x000094F3
			public unitytls_tlsctx_certificate_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001196 RID: 4502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001197 RID: 4503
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000175 RID: 373
		public sealed class unitytls_tlsctx_x509verify_callback : MulticastDelegate
		{
			// Token: 0x060015E6 RID: 5606 RVA: 0x0000B2FC File Offset: 0x000094FC
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_x509verify_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_x509verify_callback");
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663320);
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663321);
			}

			// Token: 0x060015E7 RID: 5607 RVA: 0x00061954 File Offset: 0x0005FB54
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_x509verify_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015E8 RID: 5608 RVA: 0x000619B0 File Offset: 0x0005FBB0
			[CallerCount(0)]
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chain;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060015E9 RID: 5609 RVA: 0x0000B33A File Offset: 0x0000953A
			public unitytls_tlsctx_x509verify_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001198 RID: 4504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001199 RID: 4505
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000176 RID: 374
		public sealed class unitytls_tlsctx_callbacks : ValueType
		{
			// Token: 0x060015EA RID: 5610 RVA: 0x00061A14 File Offset: 0x0005FC14
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_callbacks()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_callbacks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr);
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "read");
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "write");
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "data");
			}

			// Token: 0x060015EB RID: 5611 RVA: 0x0000B343 File Offset: 0x00009543
			public unitytls_tlsctx_callbacks(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060015EC RID: 5612 RVA: 0x0000B34C File Offset: 0x0000954C
			public unitytls_tlsctx_callbacks()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr))
			{
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x060015ED RID: 5613 RVA: 0x00061A7C File Offset: 0x0005FC7C
			// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000B35E File Offset: 0x0000955E
			public unsafe UnityTls.unitytls_tlsctx_read_callback read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_read_callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x060015EF RID: 5615 RVA: 0x00061AAC File Offset: 0x0005FCAC
			// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000B37D File Offset: 0x0000957D
			public unsafe UnityTls.unitytls_tlsctx_write_callback write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_write_callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00061ADC File Offset: 0x0005FCDC
			// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000B39C File Offset: 0x0000959C
			public unsafe void* data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data)) = value;
				}
			}

			// Token: 0x0400119A RID: 4506
			private static readonly IntPtr NativeFieldInfoPtr_read;

			// Token: 0x0400119B RID: 4507
			private static readonly IntPtr NativeFieldInfoPtr_write;

			// Token: 0x0400119C RID: 4508
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x02000177 RID: 375
		public class unitytls_interface_struct : Object
		{
			// Token: 0x060015F3 RID: 5619 RVA: 0x00061B00 File Offset: 0x0005FD00
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_interface_struct()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_interface_struct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr);
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_INVALID_HANDLE");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_pem");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes");
				UnityTls.unitytls_interface_struct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, 100663322);
			}

			// Token: 0x060015F4 RID: 5620 RVA: 0x00061DD4 File Offset: 0x0005FFD4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_interface_struct()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015F5 RID: 5621 RVA: 0x0000B3B7 File Offset: 0x000095B7
			public unitytls_interface_struct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00061E10 File Offset: 0x00060010
			// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0000B3C0 File Offset: 0x000095C0
			public unsafe ulong UNITYTLS_INVALID_HANDLE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE)) = value;
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00061E38 File Offset: 0x00060038
			// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0000B3DB File Offset: 0x000095DB
			public unsafe UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT)) = value;
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x060015FA RID: 5626 RVA: 0x00061E60 File Offset: 0x00060060
			// (set) Token: 0x060015FB RID: 5627 RVA: 0x0000B3F6 File Offset: 0x000095F6
			public unsafe UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x060015FC RID: 5628 RVA: 0x00061E90 File Offset: 0x00060090
			// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000B415 File Offset: 0x00009615
			public unsafe UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x060015FE RID: 5630 RVA: 0x00061EC0 File Offset: 0x000600C0
			// (set) Token: 0x060015FF RID: 5631 RVA: 0x0000B434 File Offset: 0x00009634
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06001600 RID: 5632 RVA: 0x00061EF0 File Offset: 0x000600F0
			// (set) Token: 0x06001601 RID: 5633 RVA: 0x0000B453 File Offset: 0x00009653
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06001602 RID: 5634 RVA: 0x00061F20 File Offset: 0x00060120
			// (set) Token: 0x06001603 RID: 5635 RVA: 0x0000B472 File Offset: 0x00009672
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06001604 RID: 5636 RVA: 0x00061F50 File Offset: 0x00060150
			// (set) Token: 0x06001605 RID: 5637 RVA: 0x0000B491 File Offset: 0x00009691
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06001606 RID: 5638 RVA: 0x00061F80 File Offset: 0x00060180
			// (set) Token: 0x06001607 RID: 5639 RVA: 0x0000B4B0 File Offset: 0x000096B0
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06001608 RID: 5640 RVA: 0x00061FB0 File Offset: 0x000601B0
			// (set) Token: 0x06001609 RID: 5641 RVA: 0x0000B4CF File Offset: 0x000096CF
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x0600160A RID: 5642 RVA: 0x00061FE0 File Offset: 0x000601E0
			// (set) Token: 0x0600160B RID: 5643 RVA: 0x0000B4EE File Offset: 0x000096EE
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x0600160C RID: 5644 RVA: 0x00062010 File Offset: 0x00060210
			// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000B50D File Offset: 0x0000970D
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x0600160E RID: 5646 RVA: 0x00062040 File Offset: 0x00060240
			// (set) Token: 0x0600160F RID: 5647 RVA: 0x0000B52C File Offset: 0x0000972C
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001610 RID: 5648 RVA: 0x00062070 File Offset: 0x00060270
			// (set) Token: 0x06001611 RID: 5649 RVA: 0x0000B54B File Offset: 0x0000974B
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06001612 RID: 5650 RVA: 0x000620A0 File Offset: 0x000602A0
			// (set) Token: 0x06001613 RID: 5651 RVA: 0x0000B56A File Offset: 0x0000976A
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06001614 RID: 5652 RVA: 0x000620D0 File Offset: 0x000602D0
			// (set) Token: 0x06001615 RID: 5653 RVA: 0x0000B589 File Offset: 0x00009789
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001616 RID: 5654 RVA: 0x00062100 File Offset: 0x00060300
			// (set) Token: 0x06001617 RID: 5655 RVA: 0x0000B5A8 File Offset: 0x000097A8
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06001618 RID: 5656 RVA: 0x00062130 File Offset: 0x00060330
			// (set) Token: 0x06001619 RID: 5657 RVA: 0x0000B5C7 File Offset: 0x000097C7
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x0600161A RID: 5658 RVA: 0x00062160 File Offset: 0x00060360
			// (set) Token: 0x0600161B RID: 5659 RVA: 0x0000B5E6 File Offset: 0x000097E6
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x0600161C RID: 5660 RVA: 0x00062190 File Offset: 0x00060390
			// (set) Token: 0x0600161D RID: 5661 RVA: 0x0000B605 File Offset: 0x00009805
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x0600161E RID: 5662 RVA: 0x000621C0 File Offset: 0x000603C0
			// (set) Token: 0x0600161F RID: 5663 RVA: 0x0000B624 File Offset: 0x00009824
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06001620 RID: 5664 RVA: 0x000621F0 File Offset: 0x000603F0
			// (set) Token: 0x06001621 RID: 5665 RVA: 0x0000B643 File Offset: 0x00009843
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06001622 RID: 5666 RVA: 0x00062220 File Offset: 0x00060420
			// (set) Token: 0x06001623 RID: 5667 RVA: 0x0000B662 File Offset: 0x00009862
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06001624 RID: 5668 RVA: 0x00062250 File Offset: 0x00060450
			// (set) Token: 0x06001625 RID: 5669 RVA: 0x0000B681 File Offset: 0x00009881
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06001626 RID: 5670 RVA: 0x00062280 File Offset: 0x00060480
			// (set) Token: 0x06001627 RID: 5671 RVA: 0x0000B6A0 File Offset: 0x000098A0
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06001628 RID: 5672 RVA: 0x000622B0 File Offset: 0x000604B0
			// (set) Token: 0x06001629 RID: 5673 RVA: 0x0000B6BF File Offset: 0x000098BF
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x0600162A RID: 5674 RVA: 0x000622E0 File Offset: 0x000604E0
			// (set) Token: 0x0600162B RID: 5675 RVA: 0x0000B6DE File Offset: 0x000098DE
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x0600162C RID: 5676 RVA: 0x00062310 File Offset: 0x00060510
			// (set) Token: 0x0600162D RID: 5677 RVA: 0x0000B6FD File Offset: 0x000098FD
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x0600162E RID: 5678 RVA: 0x00062340 File Offset: 0x00060540
			// (set) Token: 0x0600162F RID: 5679 RVA: 0x0000B71C File Offset: 0x0000991C
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06001630 RID: 5680 RVA: 0x00062370 File Offset: 0x00060570
			// (set) Token: 0x06001631 RID: 5681 RVA: 0x0000B73B File Offset: 0x0000993B
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06001632 RID: 5682 RVA: 0x000623A0 File Offset: 0x000605A0
			// (set) Token: 0x06001633 RID: 5683 RVA: 0x0000B75A File Offset: 0x0000995A
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06001634 RID: 5684 RVA: 0x000623D0 File Offset: 0x000605D0
			// (set) Token: 0x06001635 RID: 5685 RVA: 0x0000B779 File Offset: 0x00009979
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06001636 RID: 5686 RVA: 0x00062400 File Offset: 0x00060600
			// (set) Token: 0x06001637 RID: 5687 RVA: 0x0000B798 File Offset: 0x00009998
			public unsafe UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400119D RID: 4509
			private static readonly IntPtr NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE;

			// Token: 0x0400119E RID: 4510
			private static readonly IntPtr NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

			// Token: 0x0400119F RID: 4511
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_errorstate_create;

			// Token: 0x040011A0 RID: 4512
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_errorstate_raise_error;

			// Token: 0x040011A1 RID: 4513
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_get_ref;

			// Token: 0x040011A2 RID: 4514
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_parse_der;

			// Token: 0x040011A3 RID: 4515
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_parse_pem;

			// Token: 0x040011A4 RID: 4516
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_free;

			// Token: 0x040011A5 RID: 4517
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509_export_der;

			// Token: 0x040011A6 RID: 4518
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_get_ref;

			// Token: 0x040011A7 RID: 4519
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_get_x509;

			// Token: 0x040011A8 RID: 4520
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_create;

			// Token: 0x040011A9 RID: 4521
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append;

			// Token: 0x040011AA RID: 4522
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append_der;

			// Token: 0x040011AB RID: 4523
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append_pem;

			// Token: 0x040011AC RID: 4524
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_free;

			// Token: 0x040011AD RID: 4525
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509verify_default_ca;

			// Token: 0x040011AE RID: 4526
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509verify_explicit_ca;

			// Token: 0x040011AF RID: 4527
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_server;

			// Token: 0x040011B0 RID: 4528
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_client;

			// Token: 0x040011B1 RID: 4529
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication;

			// Token: 0x040011B2 RID: 4530
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback;

			// Token: 0x040011B3 RID: 4531
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback;

			// Token: 0x040011B4 RID: 4532
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback;

			// Token: 0x040011B5 RID: 4533
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites;

			// Token: 0x040011B6 RID: 4534
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite;

			// Token: 0x040011B7 RID: 4535
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_protocol;

			// Token: 0x040011B8 RID: 4536
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_process_handshake;

			// Token: 0x040011B9 RID: 4537
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_read;

			// Token: 0x040011BA RID: 4538
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_write;

			// Token: 0x040011BB RID: 4539
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_notify_close;

			// Token: 0x040011BC RID: 4540
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_free;

			// Token: 0x040011BD RID: 4541
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_random_generate_bytes;

			// Token: 0x040011BE RID: 4542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x020001FB RID: 507
			public sealed class unitytls_errorstate_create_t : MulticastDelegate
			{
				// Token: 0x06001C2F RID: 7215 RVA: 0x0000FC9A File Offset: 0x0000DE9A
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_errorstate_create_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create_t");
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663323);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663324);
				}

				// Token: 0x06001C30 RID: 7216 RVA: 0x000724CC File Offset: 0x000706CC
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_errorstate_create_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C31 RID: 7217 RVA: 0x00072528 File Offset: 0x00070728
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 31670, RefRangeEnd = 31679, XrefRangeStart = 31670, XrefRangeEnd = 31670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_errorstate Invoke()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C32 RID: 7218 RVA: 0x0000FCD8 File Offset: 0x0000DED8
				public unitytls_errorstate_create_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001C33 RID: 7219 RVA: 0x0000FCE1 File Offset: 0x0000DEE1
				public static implicit operator UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t(Func<UnityTls.unitytls_errorstate> A_0)
				{
					return DelegateSupport.ConvertDelegate<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>(A_0);
				}

				// Token: 0x06001C34 RID: 7220 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
				public static UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t operator +(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_0, UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>();
				}

				// Token: 0x06001C35 RID: 7221 RVA: 0x0000FCF7 File Offset: 0x0000DEF7
				public static UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t operator -(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_0, UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>();
					}
					return delegate2;
				}

				// Token: 0x0400155C RID: 5468
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400155D RID: 5469
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0;
			}

			// Token: 0x020001FC RID: 508
			public sealed class unitytls_errorstate_raise_error_t : MulticastDelegate
			{
				// Token: 0x06001C36 RID: 7222 RVA: 0x0000FD08 File Offset: 0x0000DF08
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_errorstate_raise_error_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error_t");
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663325);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663326);
				}

				// Token: 0x06001C37 RID: 7223 RVA: 0x00072564 File Offset: 0x00070764
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_errorstate_raise_error_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C38 RID: 7224 RVA: 0x000725C0 File Offset: 0x000707C0
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 31683, RefRangeEnd = 31690, XrefRangeStart = 31679, XrefRangeEnd = 31683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C39 RID: 7225 RVA: 0x0000FD46 File Offset: 0x0000DF46
				public unitytls_errorstate_raise_error_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400155E RID: 5470
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400155F RID: 5471
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0;
			}

			// Token: 0x020001FD RID: 509
			public sealed class unitytls_key_get_ref_t : MulticastDelegate
			{
				// Token: 0x06001C3A RID: 7226 RVA: 0x0000FD4F File Offset: 0x0000DF4F
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_get_ref_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref_t");
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663327);
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663328);
				}

				// Token: 0x06001C3B RID: 7227 RVA: 0x0007260C File Offset: 0x0007080C
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_get_ref_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C3C RID: 7228 RVA: 0x00072668 File Offset: 0x00070868
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31690, RefRangeEnd = 31698, XrefRangeStart = 31690, XrefRangeEnd = 31690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key_ref Invoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C3D RID: 7229 RVA: 0x0000FD8D File Offset: 0x0000DF8D
				public unitytls_key_get_ref_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001560 RID: 5472
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001561 RID: 5473
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020001FE RID: 510
			public sealed class unitytls_key_parse_der_t : MulticastDelegate
			{
				// Token: 0x06001C3E RID: 7230 RVA: 0x0000FD96 File Offset: 0x0000DF96
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_parse_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der_t");
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663329);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663330);
				}

				// Token: 0x06001C3F RID: 7231 RVA: 0x000726C0 File Offset: 0x000708C0
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_parse_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C40 RID: 7232 RVA: 0x0007271C File Offset: 0x0007091C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 31698, RefRangeEnd = 31699, XrefRangeStart = 31698, XrefRangeEnd = 31698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001C41 RID: 7233 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
				public unitytls_key_parse_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001562 RID: 5474
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001563 RID: 5475
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020001FF RID: 511
			public sealed class unitytls_key_parse_pem_t : MulticastDelegate
			{
				// Token: 0x06001C42 RID: 7234 RVA: 0x0000FDDD File Offset: 0x0000DFDD
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_parse_pem_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem_t");
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663331);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663332);
				}

				// Token: 0x06001C43 RID: 7235 RVA: 0x00072794 File Offset: 0x00070994
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_parse_pem_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C44 RID: 7236 RVA: 0x000727F0 File Offset: 0x000709F0
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 31698, RefRangeEnd = 31699, XrefRangeStart = 31698, XrefRangeEnd = 31699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001C45 RID: 7237 RVA: 0x0000FE1B File Offset: 0x0000E01B
				public unitytls_key_parse_pem_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001564 RID: 5476
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001565 RID: 5477
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000200 RID: 512
			public sealed class unitytls_key_free_t : MulticastDelegate
			{
				// Token: 0x06001C46 RID: 7238 RVA: 0x0000FE24 File Offset: 0x0000E024
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free_t");
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663333);
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663334);
				}

				// Token: 0x06001C47 RID: 7239 RVA: 0x00072868 File Offset: 0x00070A68
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C48 RID: 7240 RVA: 0x000728C4 File Offset: 0x00070AC4
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31703, RefRangeEnd = 31711, XrefRangeStart = 31699, XrefRangeEnd = 31703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_key* key)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C49 RID: 7241 RVA: 0x0000FE62 File Offset: 0x0000E062
				public unitytls_key_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001566 RID: 5478
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001567 RID: 5479
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0;
			}

			// Token: 0x02000201 RID: 513
			public sealed class unitytls_x509_export_der_t : MulticastDelegate
			{
				// Token: 0x06001C4A RID: 7242 RVA: 0x0000FE6B File Offset: 0x0000E06B
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509_export_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der_t");
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663335);
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663336);
				}

				// Token: 0x06001C4B RID: 7243 RVA: 0x00072904 File Offset: 0x00070B04
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509_export_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C4C RID: 7244 RVA: 0x00072960 File Offset: 0x00070B60
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 31711, RefRangeEnd = 31713, XrefRangeStart = 31711, XrefRangeEnd = 31711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref cert;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C4D RID: 7245 RVA: 0x0000FEA9 File Offset: 0x0000E0A9
				public unitytls_x509_export_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001568 RID: 5480
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001569 RID: 5481
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000202 RID: 514
			public sealed class unitytls_x509list_get_ref_t : MulticastDelegate
			{
				// Token: 0x06001C4E RID: 7246 RVA: 0x0000FEB2 File Offset: 0x0000E0B2
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_get_ref_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663337);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663338);
				}

				// Token: 0x06001C4F RID: 7247 RVA: 0x000729D4 File Offset: 0x00070BD4
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_get_ref_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C50 RID: 7248 RVA: 0x00072A30 File Offset: 0x00070C30
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31690, RefRangeEnd = 31698, XrefRangeStart = 31690, XrefRangeEnd = 31698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509list_ref Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C51 RID: 7249 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
				public unitytls_x509list_get_ref_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400156A RID: 5482
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400156B RID: 5483
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000203 RID: 515
			public sealed class unitytls_x509list_get_x509_t : MulticastDelegate
			{
				// Token: 0x06001C52 RID: 7250 RVA: 0x0000FEF9 File Offset: 0x0000E0F9
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_get_x509_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663339);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663340);
				}

				// Token: 0x06001C53 RID: 7251 RVA: 0x00072A88 File Offset: 0x00070C88
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_get_x509_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C54 RID: 7252 RVA: 0x00072AE4 File Offset: 0x00070CE4
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 31713, RefRangeEnd = 31716, XrefRangeStart = 31713, XrefRangeEnd = 31713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509_ref Invoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C55 RID: 7253 RVA: 0x0000FF37 File Offset: 0x0000E137
				public unitytls_x509list_get_x509_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400156C RID: 5484
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400156D RID: 5485
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000204 RID: 516
			public sealed class unitytls_x509list_create_t : MulticastDelegate
			{
				// Token: 0x06001C56 RID: 7254 RVA: 0x0000FF40 File Offset: 0x0000E140
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_create_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663341);
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663342);
				}

				// Token: 0x06001C57 RID: 7255 RVA: 0x00072B48 File Offset: 0x00070D48
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_create_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C58 RID: 7256 RVA: 0x00072BA4 File Offset: 0x00070DA4
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 31716, RefRangeEnd = 31718, XrefRangeStart = 31716, XrefRangeEnd = 31716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509list* Invoke(UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001C59 RID: 7257 RVA: 0x0000FF7E File Offset: 0x0000E17E
				public unitytls_x509list_create_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400156E RID: 5486
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400156F RID: 5487
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000205 RID: 517
			public sealed class unitytls_x509list_append_t : MulticastDelegate
			{
				// Token: 0x06001C5A RID: 7258 RVA: 0x0000FF87 File Offset: 0x0000E187
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_append_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663343);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663344);
				}

				// Token: 0x06001C5B RID: 7259 RVA: 0x00072BE4 File Offset: 0x00070DE4
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_append_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C5C RID: 7260 RVA: 0x00072C40 File Offset: 0x00070E40
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 31722, RefRangeEnd = 31723, XrefRangeStart = 31718, XrefRangeEnd = 31722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C5D RID: 7261 RVA: 0x0000FFC5 File Offset: 0x0000E1C5
				public unitytls_x509list_append_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001570 RID: 5488
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001571 RID: 5489
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000206 RID: 518
			public sealed class unitytls_x509list_append_der_t : MulticastDelegate
			{
				// Token: 0x06001C5E RID: 7262 RVA: 0x0000FFCE File Offset: 0x0000E1CE
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_append_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663345);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663346);
				}

				// Token: 0x06001C5F RID: 7263 RVA: 0x00072C98 File Offset: 0x00070E98
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_append_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C60 RID: 7264 RVA: 0x00072CF4 File Offset: 0x00070EF4
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31662, RefRangeEnd = 31666, XrefRangeStart = 31662, XrefRangeEnd = 31666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C61 RID: 7265 RVA: 0x0001000C File Offset: 0x0000E20C
				public unitytls_x509list_append_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001572 RID: 5490
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001573 RID: 5491
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000207 RID: 519
			public sealed class unitytls_x509list_free_t : MulticastDelegate
			{
				// Token: 0x06001C62 RID: 7266 RVA: 0x00010015 File Offset: 0x0000E215
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663347);
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663348);
				}

				// Token: 0x06001C63 RID: 7267 RVA: 0x00072D5C File Offset: 0x00070F5C
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C64 RID: 7268 RVA: 0x00072DB8 File Offset: 0x00070FB8
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31703, RefRangeEnd = 31711, XrefRangeStart = 31703, XrefRangeEnd = 31711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C65 RID: 7269 RVA: 0x00010053 File Offset: 0x0000E253
				public unitytls_x509list_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001574 RID: 5492
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001575 RID: 5493
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0;
			}

			// Token: 0x02000208 RID: 520
			public sealed class unitytls_x509verify_default_ca_t : MulticastDelegate
			{
				// Token: 0x06001C66 RID: 7270 RVA: 0x0001005C File Offset: 0x0000E25C
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509verify_default_ca_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca_t");
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663349);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663350);
				}

				// Token: 0x06001C67 RID: 7271 RVA: 0x00072DF8 File Offset: 0x00070FF8
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509verify_default_ca_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C68 RID: 7272 RVA: 0x00072E54 File Offset: 0x00071054
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C69 RID: 7273 RVA: 0x0001009A File Offset: 0x0000E29A
				public unitytls_x509verify_default_ca_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001576 RID: 5494
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001577 RID: 5495
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000209 RID: 521
			public sealed class unitytls_x509verify_explicit_ca_t : MulticastDelegate
			{
				// Token: 0x06001C6A RID: 7274 RVA: 0x000100A3 File Offset: 0x0000E2A3
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509verify_explicit_ca_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca_t");
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663351);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663352);
				}

				// Token: 0x06001C6B RID: 7275 RVA: 0x00072EE8 File Offset: 0x000710E8
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509verify_explicit_ca_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C6C RID: 7276 RVA: 0x00072F44 File Offset: 0x00071144
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trustCA;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C6D RID: 7277 RVA: 0x000100E1 File Offset: 0x0000E2E1
				public unitytls_x509verify_explicit_ca_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001578 RID: 5496
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001579 RID: 5497
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200020A RID: 522
			public sealed class unitytls_tlsctx_create_server_t : MulticastDelegate
			{
				// Token: 0x06001C6E RID: 7278 RVA: 0x000100EA File Offset: 0x0000E2EA
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_create_server_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663353);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663354);
				}

				// Token: 0x06001C6F RID: 7279 RVA: 0x00072FE8 File Offset: 0x000711E8
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_create_server_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C70 RID: 7280 RVA: 0x00073044 File Offset: 0x00071244
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 31723, RefRangeEnd = 31725, XrefRangeStart = 31723, XrefRangeEnd = 31723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref certChain;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leafCertificateKey;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001C71 RID: 7281 RVA: 0x00010128 File Offset: 0x0000E328
				public unitytls_tlsctx_create_server_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400157A RID: 5498
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400157B RID: 5499
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200020B RID: 523
			public sealed class unitytls_tlsctx_create_client_t : MulticastDelegate
			{
				// Token: 0x06001C72 RID: 7282 RVA: 0x00010131 File Offset: 0x0000E331
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_create_client_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663355);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663356);
				}

				// Token: 0x06001C73 RID: 7283 RVA: 0x000730C4 File Offset: 0x000712C4
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_create_client_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C74 RID: 7284 RVA: 0x00073120 File Offset: 0x00071320
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 31723, RefRangeEnd = 31725, XrefRangeStart = 31723, XrefRangeEnd = 31725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06001C75 RID: 7285 RVA: 0x0001016F File Offset: 0x0000E36F
				public unitytls_tlsctx_create_client_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400157C RID: 5500
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400157D RID: 5501
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200020C RID: 524
			public sealed class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
			{
				// Token: 0x06001C76 RID: 7286 RVA: 0x00010178 File Offset: 0x0000E378
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_server_require_client_authentication_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663357);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663358);
				}

				// Token: 0x06001C77 RID: 7287 RVA: 0x000731A0 File Offset: 0x000713A0
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_server_require_client_authentication_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C78 RID: 7288 RVA: 0x000731FC File Offset: 0x000713FC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 31722, RefRangeEnd = 31723, XrefRangeStart = 31722, XrefRangeEnd = 31723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientAuthCAList;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C79 RID: 7289 RVA: 0x000101B6 File Offset: 0x0000E3B6
				public unitytls_tlsctx_server_require_client_authentication_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400157E RID: 5502
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400157F RID: 5503
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200020D RID: 525
			public sealed class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
			{
				// Token: 0x06001C7A RID: 7290 RVA: 0x000101BF File Offset: 0x0000E3BF
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_certificate_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663359);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663360);
				}

				// Token: 0x06001C7B RID: 7291 RVA: 0x00073254 File Offset: 0x00071454
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_certificate_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C7C RID: 7292 RVA: 0x000732B0 File Offset: 0x000714B0
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31662, RefRangeEnd = 31666, XrefRangeStart = 31662, XrefRangeEnd = 31666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C7D RID: 7293 RVA: 0x000101FD File Offset: 0x0000E3FD
				public unitytls_tlsctx_set_certificate_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001580 RID: 5504
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001581 RID: 5505
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200020E RID: 526
			public sealed class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
			{
				// Token: 0x06001C7E RID: 7294 RVA: 0x00010206 File Offset: 0x0000E406
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_trace_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663361);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663362);
				}

				// Token: 0x06001C7F RID: 7295 RVA: 0x0007331C File Offset: 0x0007151C
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_trace_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C80 RID: 7296 RVA: 0x00073378 File Offset: 0x00071578
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31662, RefRangeEnd = 31666, XrefRangeStart = 31662, XrefRangeEnd = 31666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C81 RID: 7297 RVA: 0x00010244 File Offset: 0x0000E444
				public unitytls_tlsctx_set_trace_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001582 RID: 5506
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001583 RID: 5507
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200020F RID: 527
			public sealed class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
			{
				// Token: 0x06001C82 RID: 7298 RVA: 0x0001024D File Offset: 0x0000E44D
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_x509verify_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663363);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663364);
				}

				// Token: 0x06001C83 RID: 7299 RVA: 0x000733E4 File Offset: 0x000715E4
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_x509verify_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C84 RID: 7300 RVA: 0x00073440 File Offset: 0x00071640
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31662, RefRangeEnd = 31666, XrefRangeStart = 31662, XrefRangeEnd = 31666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C85 RID: 7301 RVA: 0x0001028B File Offset: 0x0000E48B
				public unitytls_tlsctx_set_x509verify_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001584 RID: 5508
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001585 RID: 5509
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000210 RID: 528
			public sealed class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
			{
				// Token: 0x06001C86 RID: 7302 RVA: 0x00010294 File Offset: 0x0000E494
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_supported_ciphersuites_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663365);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663366);
				}

				// Token: 0x06001C87 RID: 7303 RVA: 0x000734AC File Offset: 0x000716AC
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_supported_ciphersuites_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C88 RID: 7304 RVA: 0x00073508 File Offset: 0x00071708
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31662, RefRangeEnd = 31666, XrefRangeStart = 31662, XrefRangeEnd = 31666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = supportedCiphersuites;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref supportedCiphersuitesLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C89 RID: 7305 RVA: 0x000102D2 File Offset: 0x0000E4D2
				public unitytls_tlsctx_set_supported_ciphersuites_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001586 RID: 5510
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001587 RID: 5511
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000211 RID: 529
			public sealed class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
			{
				// Token: 0x06001C8A RID: 7306 RVA: 0x000102DB File Offset: 0x0000E4DB
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_get_ciphersuite_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663367);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663368);
				}

				// Token: 0x06001C8B RID: 7307 RVA: 0x00073570 File Offset: 0x00071770
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_get_ciphersuite_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C8C RID: 7308 RVA: 0x000735CC File Offset: 0x000717CC
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31690, RefRangeEnd = 31698, XrefRangeStart = 31690, XrefRangeEnd = 31698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_ciphersuite Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C8D RID: 7309 RVA: 0x00010319 File Offset: 0x0000E519
				public unitytls_tlsctx_get_ciphersuite_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001588 RID: 5512
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001589 RID: 5513
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000212 RID: 530
			public sealed class unitytls_tlsctx_get_protocol_t : MulticastDelegate
			{
				// Token: 0x06001C8E RID: 7310 RVA: 0x00010322 File Offset: 0x0000E522
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_get_protocol_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663369);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663370);
				}

				// Token: 0x06001C8F RID: 7311 RVA: 0x00073624 File Offset: 0x00071824
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_get_protocol_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C90 RID: 7312 RVA: 0x00073680 File Offset: 0x00071880
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31690, RefRangeEnd = 31698, XrefRangeStart = 31690, XrefRangeEnd = 31698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_protocol Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C91 RID: 7313 RVA: 0x00010360 File Offset: 0x0000E560
				public unitytls_tlsctx_get_protocol_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400158A RID: 5514
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400158B RID: 5515
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000213 RID: 531
			public sealed class unitytls_tlsctx_process_handshake_t : MulticastDelegate
			{
				// Token: 0x06001C92 RID: 7314 RVA: 0x00010369 File Offset: 0x0000E569
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_process_handshake_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663371);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663372);
				}

				// Token: 0x06001C93 RID: 7315 RVA: 0x000736D8 File Offset: 0x000718D8
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_process_handshake_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C94 RID: 7316 RVA: 0x00073734 File Offset: 0x00071934
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31690, RefRangeEnd = 31698, XrefRangeStart = 31690, XrefRangeEnd = 31698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C95 RID: 7317 RVA: 0x000103A7 File Offset: 0x0000E5A7
				public unitytls_tlsctx_process_handshake_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400158C RID: 5516
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400158D RID: 5517
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000214 RID: 532
			public sealed class unitytls_tlsctx_read_t : MulticastDelegate
			{
				// Token: 0x06001C96 RID: 7318 RVA: 0x000103B0 File Offset: 0x0000E5B0
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_read_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663373);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663374);
				}

				// Token: 0x06001C97 RID: 7319 RVA: 0x0007378C File Offset: 0x0007198C
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_read_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C98 RID: 7320 RVA: 0x000737E8 File Offset: 0x000719E8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 31656, RefRangeEnd = 31658, XrefRangeStart = 31656, XrefRangeEnd = 31658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C99 RID: 7321 RVA: 0x000103EE File Offset: 0x0000E5EE
				public unitytls_tlsctx_read_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400158E RID: 5518
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400158F RID: 5519
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000215 RID: 533
			public sealed class unitytls_tlsctx_write_t : MulticastDelegate
			{
				// Token: 0x06001C9A RID: 7322 RVA: 0x000103F7 File Offset: 0x0000E5F7
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_write_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663375);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663376);
				}

				// Token: 0x06001C9B RID: 7323 RVA: 0x0007385C File Offset: 0x00071A5C
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_write_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C9C RID: 7324 RVA: 0x000738B8 File Offset: 0x00071AB8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 31656, RefRangeEnd = 31658, XrefRangeStart = 31656, XrefRangeEnd = 31658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001C9D RID: 7325 RVA: 0x00010435 File Offset: 0x0000E635
				public unitytls_tlsctx_write_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001590 RID: 5520
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001591 RID: 5521
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000216 RID: 534
			public sealed class unitytls_tlsctx_notify_close_t : MulticastDelegate
			{
				// Token: 0x06001C9E RID: 7326 RVA: 0x0001043E File Offset: 0x0000E63E
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_notify_close_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663377);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663378);
				}

				// Token: 0x06001C9F RID: 7327 RVA: 0x0007392C File Offset: 0x00071B2C
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_notify_close_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CA0 RID: 7328 RVA: 0x00073988 File Offset: 0x00071B88
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 31729, RefRangeEnd = 31730, XrefRangeStart = 31725, XrefRangeEnd = 31729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CA1 RID: 7329 RVA: 0x0001047C File Offset: 0x0000E67C
				public unitytls_tlsctx_notify_close_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001592 RID: 5522
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001593 RID: 5523
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x02000217 RID: 535
			public sealed class unitytls_tlsctx_free_t : MulticastDelegate
			{
				// Token: 0x06001CA2 RID: 7330 RVA: 0x00010485 File Offset: 0x0000E685
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663379);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663380);
				}

				// Token: 0x06001CA3 RID: 7331 RVA: 0x000739D4 File Offset: 0x00071BD4
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CA4 RID: 7332 RVA: 0x00073A30 File Offset: 0x00071C30
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 31703, RefRangeEnd = 31711, XrefRangeStart = 31703, XrefRangeEnd = 31711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001CA5 RID: 7333 RVA: 0x000104C3 File Offset: 0x0000E6C3
				public unitytls_tlsctx_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001594 RID: 5524
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001595 RID: 5525
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0;
			}

			// Token: 0x02000218 RID: 536
			public sealed class unitytls_random_generate_bytes_t : MulticastDelegate
			{
				// Token: 0x06001CA6 RID: 7334 RVA: 0x000104CC File Offset: 0x0000E6CC
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_random_generate_bytes_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes_t");
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663381);
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663382);
				}

				// Token: 0x06001CA7 RID: 7335 RVA: 0x00073A70 File Offset: 0x00071C70
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_random_generate_bytes_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CA8 RID: 7336 RVA: 0x00073ACC File Offset: 0x00071CCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31730, XrefRangeEnd = 31734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CA9 RID: 7337 RVA: 0x0001050A File Offset: 0x0000E70A
				public unitytls_random_generate_bytes_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001596 RID: 5526
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001597 RID: 5527
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}
		}
	}
}
