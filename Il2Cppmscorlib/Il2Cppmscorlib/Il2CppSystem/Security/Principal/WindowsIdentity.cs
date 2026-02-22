using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Claims;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x020002D0 RID: 720
	[Serializable]
	public class WindowsIdentity : ClaimsIdentity
	{
		// Token: 0x06002FB3 RID: 12211 RVA: 0x000EF494 File Offset: 0x000ED694
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsIdentity()
		{
			Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "WindowsIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr);
			WindowsIdentity.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_token");
			WindowsIdentity.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_type");
			WindowsIdentity.NativeFieldInfoPtr__account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_account");
			WindowsIdentity.NativeFieldInfoPtr__authenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_authenticated");
			WindowsIdentity.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_name");
			WindowsIdentity.NativeFieldInfoPtr__info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_info");
			WindowsIdentity.NativeFieldInfoPtr_invalidWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "invalidWindows");
			WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670831);
			WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670832);
			WindowsIdentity.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670833);
			WindowsIdentity.NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670834);
			WindowsIdentity.NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670835);
			WindowsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670836);
			WindowsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670837);
			WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670838);
			WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670839);
			WindowsIdentity.NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670840);
			WindowsIdentity.NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670841);
			WindowsIdentity.NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670842);
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x000EF640 File Offset: 0x000ED840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338147, XrefRangeEnd = 338161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userToken;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acctType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAuthenticated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x000EF6B8 File Offset: 0x000ED8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338161, XrefRangeEnd = 338162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x000EF71C File Offset: 0x000ED91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338162, XrefRangeEnd = 338163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x000EF750 File Offset: 0x000ED950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338180, RefRangeEnd = 338182, XrefRangeStart = 338163, XrefRangeEnd = 338180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WindowsIdentity GetCurrent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr3) : null;
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x000EF784 File Offset: 0x000ED984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338182, XrefRangeEnd = 338188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WindowsImpersonationContext Impersonate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WindowsIdentity.NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsImpersonationContext>(intPtr3) : null;
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x000EF7D0 File Offset: 0x000ED9D0
		public unsafe override string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x000EF808 File Offset: 0x000EDA08
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338188, XrefRangeEnd = 338192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WindowsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x000EF84C File Offset: 0x000EDA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338192, XrefRangeEnd = 338232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x000EF890 File Offset: 0x000EDA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338232, XrefRangeEnd = 338253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000EF8EC File Offset: 0x000EDAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338253, XrefRangeEnd = 338263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToken(IntPtr token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x000EF92C File Offset: 0x000EDB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317376, RefRangeEnd = 317377, XrefRangeStart = 317376, XrefRangeEnd = 317377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetCurrentToken()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x000EF95C File Offset: 0x000EDB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317376, RefRangeEnd = 317377, XrefRangeStart = 317376, XrefRangeEnd = 317377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTokenName(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00010C3B File Offset: 0x0000EE3B
		public WindowsIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000EF994 File Offset: 0x000EDB94
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x00010C44 File Offset: 0x0000EE44
		public unsafe IntPtr _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x000EF9BC File Offset: 0x000EDBBC
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x00010C5F File Offset: 0x0000EE5F
		public unsafe string _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000EF9E4 File Offset: 0x000EDBE4
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x00010C7E File Offset: 0x0000EE7E
		public unsafe WindowsAccountType _account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__account);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__account)) = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x000EFA0C File Offset: 0x000EDC0C
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x00010C99 File Offset: 0x0000EE99
		public unsafe bool _authenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__authenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__authenticated)) = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x000EFA34 File Offset: 0x000EDC34
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x000EFA5C File Offset: 0x000EDC5C
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x00010CD3 File Offset: 0x0000EED3
		public unsafe SerializationInfo _info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x000EFA8C File Offset: 0x000EDC8C
		// (set) Token: 0x06002FCE RID: 12238 RVA: 0x00010CF2 File Offset: 0x0000EEF2
		public unsafe static IntPtr invalidWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WindowsIdentity.NativeFieldInfoPtr_invalidWindows, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowsIdentity.NativeFieldInfoPtr_invalidWindows, (void*)(&value));
			}
		}

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeFieldInfoPtr__account;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeFieldInfoPtr__authenticated;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeFieldInfoPtr__info;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeFieldInfoPtr_invalidWindows;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0;
	}
}
