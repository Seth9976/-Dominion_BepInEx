using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Security.Claims
{
	// Token: 0x020002D3 RID: 723
	[Serializable]
	public class ClaimsIdentity : Object
	{
		// Token: 0x06002FFA RID: 12282 RVA: 0x000F045C File Offset: 0x000EE65C
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimsIdentity()
		{
			Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Claims", "ClaimsIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr);
			ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_userSerializationData");
			ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_instanceClaims");
			ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_externalClaims");
			ClaimsIdentity.NativeFieldInfoPtr_m_nameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_nameType");
			ClaimsIdentity.NativeFieldInfoPtr_m_roleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_roleType");
			ClaimsIdentity.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_version");
			ClaimsIdentity.NativeFieldInfoPtr_m_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_actor");
			ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_authenticationType");
			ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_bootstrapContext");
			ClaimsIdentity.NativeFieldInfoPtr_m_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_label");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedNameType");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedRoleType");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedClaims");
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670862);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670863);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670864);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670865);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670866);
			ClaimsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670867);
			ClaimsIdentity.NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670868);
			ClaimsIdentity.NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670869);
			ClaimsIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670870);
			ClaimsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670871);
			ClaimsIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670872);
			ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670873);
			ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670874);
			ClaimsIdentity.NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670875);
			ClaimsIdentity.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670876);
			ClaimsIdentity.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670877);
			ClaimsIdentity.NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670878);
			ClaimsIdentity.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670879);
			ClaimsIdentity.NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670880);
			ClaimsIdentity.NativeMethodInfoPtr_SerializeClaims_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670881);
			ClaimsIdentity.NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670882);
			ClaimsIdentity.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100670883);
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x000F0748 File Offset: 0x000EE948
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338432, RefRangeEnd = 338435, XrefRangeStart = 338431, XrefRangeEnd = 338432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x000F0784 File Offset: 0x000EE984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338435, XrefRangeEnd = 338436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IEnumerable<Claim> claims)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000F07D0 File Offset: 0x000EE9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338436, XrefRangeEnd = 338437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(claims);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authenticationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(roleType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x000F0868 File Offset: 0x000EEA68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 338512, RefRangeEnd = 338516, XrefRangeStart = 338437, XrefRangeEnd = 338512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(claims);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authenticationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(roleType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAuthType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x000F090C File Offset: 0x000EEB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338516, XrefRangeEnd = 338536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x000F0970 File Offset: 0x000EEB70
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x000F09B4 File Offset: 0x000EEBB4
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x000F09F4 File Offset: 0x000EEBF4
		public unsafe ClaimsIdentity Actor
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338537, RefRangeEnd = 338538, XrefRangeStart = 338536, XrefRangeEnd = 338537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x000F0A38 File Offset: 0x000EEC38
		public unsafe virtual IEnumerable<Claim> Claims
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338538, XrefRangeEnd = 338542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Claim>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000F0A84 File Offset: 0x000EEC84
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x000F0AC8 File Offset: 0x000EECC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338542, XrefRangeEnd = 338550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ClaimsIdentity Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x000F0B14 File Offset: 0x000EED14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338571, RefRangeEnd = 338573, XrefRangeStart = 338550, XrefRangeEnd = 338571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeAddClaims(IEnumerable<Claim> claims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000F0B58 File Offset: 0x000EED58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338573, XrefRangeEnd = 338579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeAddClaim(Claim claim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000F0B9C File Offset: 0x000EED9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338579, XrefRangeEnd = 338594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Claim FindFirst(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
			}
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000F0BF8 File Offset: 0x000EEDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338594, XrefRangeEnd = 338598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializingMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000F0C40 File Offset: 0x000EEE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338598, XrefRangeEnd = 338609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializedMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000F0C88 File Offset: 0x000EEE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338609, XrefRangeEnd = 338624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializingMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000F0CD0 File Offset: 0x000EEED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338624, XrefRangeEnd = 338678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000F0D34 File Offset: 0x000EEF34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338712, RefRangeEnd = 338714, XrefRangeStart = 338678, XrefRangeEnd = 338712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeClaims(string serializedClaims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serializedClaims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x000F0D78 File Offset: 0x000EEF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338735, RefRangeEnd = 338737, XrefRangeStart = 338714, XrefRangeEnd = 338735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SerializeClaims()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SerializeClaims_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x000F0DB0 File Offset: 0x000EEFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338737, XrefRangeEnd = 338738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCircular(ClaimsIdentity subject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x000F0E00 File Offset: 0x000EF000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338823, RefRangeEnd = 338824, XrefRangeStart = 338738, XrefRangeEnd = 338823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x00010E5F File Offset: 0x0000F05F
		public ClaimsIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x000F0E68 File Offset: 0x000EF068
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x00010E68 File Offset: 0x0000F068
		public unsafe Il2CppStructArray<byte> m_userSerializationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x000F0E98 File Offset: 0x000EF098
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x00010E87 File Offset: 0x0000F087
		public unsafe List<Claim> m_instanceClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Claim>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x000F0EC8 File Offset: 0x000EF0C8
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x00010EA6 File Offset: 0x0000F0A6
		public unsafe Collection<IEnumerable<Claim>> m_externalClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collection<IEnumerable<Claim>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x000F0EF8 File Offset: 0x000EF0F8
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00010EC5 File Offset: 0x0000F0C5
		public unsafe string m_nameType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_nameType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_nameType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x000F0F20 File Offset: 0x000EF120
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x00010EE4 File Offset: 0x0000F0E4
		public unsafe string m_roleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_roleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_roleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000F0F48 File Offset: 0x000EF148
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x00010F03 File Offset: 0x0000F103
		public unsafe string m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x000F0F70 File Offset: 0x000EF170
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x00010F22 File Offset: 0x0000F122
		public unsafe ClaimsIdentity m_actor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_actor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_actor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x000F0FA0 File Offset: 0x000EF1A0
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x00010F41 File Offset: 0x0000F141
		public unsafe string m_authenticationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x000F0FC8 File Offset: 0x000EF1C8
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x00010F60 File Offset: 0x0000F160
		public unsafe Object m_bootstrapContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x000F0FF8 File Offset: 0x000EF1F8
		// (set) Token: 0x06003025 RID: 12325 RVA: 0x00010F7F File Offset: 0x0000F17F
		public unsafe string m_label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x000F1020 File Offset: 0x000EF220
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x00010F9E File Offset: 0x0000F19E
		public unsafe string m_serializedNameType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x000F1048 File Offset: 0x000EF248
		// (set) Token: 0x06003029 RID: 12329 RVA: 0x00010FBD File Offset: 0x0000F1BD
		public unsafe string m_serializedRoleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x000F1070 File Offset: 0x000EF270
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x00010FDC File Offset: 0x0000F1DC
		public unsafe string m_serializedClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeFieldInfoPtr_m_userSerializationData;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeFieldInfoPtr_m_instanceClaims;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeFieldInfoPtr_m_externalClaims;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeFieldInfoPtr_m_nameType;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeFieldInfoPtr_m_roleType;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeFieldInfoPtr_m_actor;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeFieldInfoPtr_m_authenticationType;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeFieldInfoPtr_m_bootstrapContext;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeFieldInfoPtr_m_label;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedNameType;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedRoleType;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedClaims;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400297C RID: 10620
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0;

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeMethodInfoPtr_SerializeClaims_Private_String_0;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0;

		// Token: 0x02000622 RID: 1570
		[ObfuscatedName("System.Security.Claims.ClaimsIdentity+<get_Claims>d__51")]
		public sealed class _get_Claims_d__51 : Object
		{
			// Token: 0x060053B6 RID: 21430 RVA: 0x00173B18 File Offset: 0x00171D18
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Claims_d__51()
			{
				Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "<get_Claims>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr);
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>1__state");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>2__current");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>l__initialThreadId");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>4__this");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<i>5__1");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__j_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<j>5__2");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>7__wrap1");
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670884);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670885);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670886);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670887);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670888);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670889);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670890);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670891);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100670892);
			}

			// Token: 0x060053B7 RID: 21431 RVA: 0x00173C84 File Offset: 0x00171E84
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 254576, RefRangeEnd = 254582, XrefRangeStart = 254576, XrefRangeEnd = 254582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Claims_d__51(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053B8 RID: 21432 RVA: 0x00173CCC File Offset: 0x00171ECC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338388, RefRangeEnd = 338389, XrefRangeStart = 338384, XrefRangeEnd = 338388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B9 RID: 21433 RVA: 0x00173D00 File Offset: 0x00171F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338389, XrefRangeEnd = 338421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053BA RID: 21434 RVA: 0x00173D3C File Offset: 0x00171F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338421, XrefRangeEnd = 338424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700156C RID: 5484
			// (get) Token: 0x060053BB RID: 21435 RVA: 0x00173D70 File Offset: 0x00171F70
			public unsafe Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
				}
			}

			// Token: 0x060053BC RID: 21436 RVA: 0x00173DB0 File Offset: 0x00171FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338424, XrefRangeEnd = 338429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700156D RID: 5485
			// (get) Token: 0x060053BD RID: 21437 RVA: 0x00173DE4 File Offset: 0x00171FE4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053BE RID: 21438 RVA: 0x00173E24 File Offset: 0x00172024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338429, XrefRangeEnd = 338431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Claim> System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Claim>>(intPtr3) : null;
			}

			// Token: 0x060053BF RID: 21439 RVA: 0x00173E64 File Offset: 0x00172064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060053C0 RID: 21440 RVA: 0x000201C5 File Offset: 0x0001E3C5
			public _get_Claims_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001565 RID: 5477
			// (get) Token: 0x060053C1 RID: 21441 RVA: 0x00173EA4 File Offset: 0x001720A4
			// (set) Token: 0x060053C2 RID: 21442 RVA: 0x000201CE File Offset: 0x0001E3CE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001566 RID: 5478
			// (get) Token: 0x060053C3 RID: 21443 RVA: 0x00173ECC File Offset: 0x001720CC
			// (set) Token: 0x060053C4 RID: 21444 RVA: 0x000201E9 File Offset: 0x0001E3E9
			public unsafe Claim __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001567 RID: 5479
			// (get) Token: 0x060053C5 RID: 21445 RVA: 0x00173EFC File Offset: 0x001720FC
			// (set) Token: 0x060053C6 RID: 21446 RVA: 0x00020208 File Offset: 0x0001E408
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001568 RID: 5480
			// (get) Token: 0x060053C7 RID: 21447 RVA: 0x00173F24 File Offset: 0x00172124
			// (set) Token: 0x060053C8 RID: 21448 RVA: 0x00020223 File Offset: 0x0001E423
			public unsafe ClaimsIdentity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001569 RID: 5481
			// (get) Token: 0x060053C9 RID: 21449 RVA: 0x00173F54 File Offset: 0x00172154
			// (set) Token: 0x060053CA RID: 21450 RVA: 0x00020242 File Offset: 0x0001E442
			public unsafe int _i_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__1)) = value;
				}
			}

			// Token: 0x1700156A RID: 5482
			// (get) Token: 0x060053CB RID: 21451 RVA: 0x00173F7C File Offset: 0x0017217C
			// (set) Token: 0x060053CC RID: 21452 RVA: 0x0002025D File Offset: 0x0001E45D
			public unsafe int _j_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__j_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__j_5__2)) = value;
				}
			}

			// Token: 0x1700156B RID: 5483
			// (get) Token: 0x060053CD RID: 21453 RVA: 0x00173FA4 File Offset: 0x001721A4
			// (set) Token: 0x060053CE RID: 21454 RVA: 0x00020278 File Offset: 0x0001E478
			public unsafe IEnumerator<Claim> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Claim>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004399 RID: 17305
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400439A RID: 17306
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400439B RID: 17307
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400439C RID: 17308
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400439D RID: 17309
			private static readonly IntPtr NativeFieldInfoPtr__i_5__1;

			// Token: 0x0400439E RID: 17310
			private static readonly IntPtr NativeFieldInfoPtr__j_5__2;

			// Token: 0x0400439F RID: 17311
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040043A0 RID: 17312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040043A1 RID: 17313
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043A2 RID: 17314
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040043A3 RID: 17315
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040043A4 RID: 17316
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0;

			// Token: 0x040043A5 RID: 17317
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043A6 RID: 17318
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040043A7 RID: 17319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0;

			// Token: 0x040043A8 RID: 17320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
