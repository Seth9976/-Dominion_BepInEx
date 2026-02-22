using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Claims
{
	// Token: 0x020002D2 RID: 722
	[Serializable]
	public class Claim : Object
	{
		// Token: 0x06002FDB RID: 12251 RVA: 0x000EFD20 File Offset: 0x000EDF20
		// Note: this type is marked as 'beforefieldinit'.
		static Claim()
		{
			Il2CppClassPointerStore<Claim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Claims", "Claim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Claim>.NativeClassPtr);
			Claim.NativeFieldInfoPtr_m_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_issuer");
			Claim.NativeFieldInfoPtr_m_originalIssuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_originalIssuer");
			Claim.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_type");
			Claim.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_value");
			Claim.NativeFieldInfoPtr_m_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_valueType");
			Claim.NativeFieldInfoPtr_m_userSerializationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_userSerializationData");
			Claim.NativeFieldInfoPtr_m_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_properties");
			Claim.NativeFieldInfoPtr_m_propertyLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_propertyLock");
			Claim.NativeFieldInfoPtr_m_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_subject");
			Claim.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670851);
			Claim.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670852);
			Claim.NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670853);
			Claim.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670854);
			Claim.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670855);
			Claim.NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670856);
			Claim.NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670857);
			Claim.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670858);
			Claim.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670859);
			Claim.NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670860);
			Claim.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100670861);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x000EFEE0 File Offset: 0x000EE0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338291, XrefRangeEnd = 338304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(issuer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalIssuer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000EFF88 File Offset: 0x000EE188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338304, XrefRangeEnd = 338320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(issuer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalIssuer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x000F0058 File Offset: 0x000EE258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338358, RefRangeEnd = 338359, XrefRangeStart = 338320, XrefRangeEnd = 338358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(Claim other, ClaimsIdentity subject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x000F00B8 File Offset: 0x000EE2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338359, XrefRangeEnd = 338363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializedMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x000F0100 File Offset: 0x000EE300
		public unsafe IDictionary<string, string> Properties
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338372, RefRangeEnd = 338373, XrefRangeStart = 338363, XrefRangeEnd = 338372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x000F0140 File Offset: 0x000EE340
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x000F0180 File Offset: 0x000EE380
		public unsafe ClaimsIdentity Subject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x000F01C4 File Offset: 0x000EE3C4
		public unsafe string Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Type_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x000F01FC File Offset: 0x000EE3FC
		public unsafe string Value
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x000F0234 File Offset: 0x000EE434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338373, XrefRangeEnd = 338377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Claim Clone(ClaimsIdentity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Claim.NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
			}
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x000F0290 File Offset: 0x000EE490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338377, XrefRangeEnd = 338384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Claim.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00010D3F File Offset: 0x0000EF3F
		public Claim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x000F02D4 File Offset: 0x000EE4D4
		// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00010D48 File Offset: 0x0000EF48
		public unsafe string m_issuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_issuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_issuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x000F02FC File Offset: 0x000EE4FC
		// (set) Token: 0x06002FEB RID: 12267 RVA: 0x00010D67 File Offset: 0x0000EF67
		public unsafe string m_originalIssuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_originalIssuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_originalIssuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000F0324 File Offset: 0x000EE524
		// (set) Token: 0x06002FED RID: 12269 RVA: 0x00010D86 File Offset: 0x0000EF86
		public unsafe string m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000F034C File Offset: 0x000EE54C
		// (set) Token: 0x06002FEF RID: 12271 RVA: 0x00010DA5 File Offset: 0x0000EFA5
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000F0374 File Offset: 0x000EE574
		// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		public unsafe string m_valueType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_valueType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_valueType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x000F039C File Offset: 0x000EE59C
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x00010DE3 File Offset: 0x0000EFE3
		public unsafe Il2CppStructArray<byte> m_userSerializationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_userSerializationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_userSerializationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x000F03CC File Offset: 0x000EE5CC
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x00010E02 File Offset: 0x0000F002
		public unsafe Dictionary<string, string> m_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000F03FC File Offset: 0x000EE5FC
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x00010E21 File Offset: 0x0000F021
		public unsafe Object m_propertyLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_propertyLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_propertyLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000F042C File Offset: 0x000EE62C
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x00010E40 File Offset: 0x0000F040
		public unsafe ClaimsIdentity m_subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_subject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_subject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeFieldInfoPtr_m_issuer;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeFieldInfoPtr_m_originalIssuer;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeFieldInfoPtr_m_valueType;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeFieldInfoPtr_m_userSerializationData;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeFieldInfoPtr_m_properties;

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeFieldInfoPtr_m_propertyLock;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeFieldInfoPtr_m_subject;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
