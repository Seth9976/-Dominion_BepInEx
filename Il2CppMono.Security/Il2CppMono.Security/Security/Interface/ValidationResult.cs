using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200001B RID: 27
	public class ValidationResult : Object
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00008D44 File Offset: 0x00006F44
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationResult()
		{
			Il2CppClassPointerStore<ValidationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "ValidationResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr);
			ValidationResult.NativeFieldInfoPtr_trusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "trusted");
			ValidationResult.NativeFieldInfoPtr_user_denied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "user_denied");
			ValidationResult.NativeFieldInfoPtr_error_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "error_code");
			ValidationResult.NativeFieldInfoPtr_policy_errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "policy_errors");
			ValidationResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663495);
			ValidationResult.NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663496);
			ValidationResult.NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663497);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008E00 File Offset: 0x00007000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 9054, RefRangeEnd = 9055, XrefRangeStart = 9053, XrefRangeEnd = 9054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationResult(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trusted;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref user_denied;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error_code;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(policy_errors));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00008E7C File Offset: 0x0000707C
		public unsafe bool Trusted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationResult.NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00008EB8 File Offset: 0x000070B8
		public unsafe bool UserDenied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationResult.NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002A68 File Offset: 0x00000C68
		public ValidationResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00008EF4 File Offset: 0x000070F4
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002A71 File Offset: 0x00000C71
		public unsafe bool trusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_trusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_trusted)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00008F1C File Offset: 0x0000711C
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002A8C File Offset: 0x00000C8C
		public unsafe bool user_denied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_user_denied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_user_denied)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00008F44 File Offset: 0x00007144
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public unsafe int error_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_error_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_error_code)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00008F6C File Offset: 0x0000716C
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002AC2 File Offset: 0x00000CC2
		public Nullable<MonoSslPolicyErrors> policy_errors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_policy_errors);
				return new Nullable<MonoSslPolicyErrors>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MonoSslPolicyErrors>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_policy_errors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MonoSslPolicyErrors>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_trusted;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_user_denied;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_error_code;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_policy_errors;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0;
	}
}
