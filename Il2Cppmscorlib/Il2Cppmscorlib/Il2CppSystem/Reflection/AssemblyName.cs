using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Configuration.Assemblies;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C0 RID: 448
	[Serializable]
	public sealed class AssemblyName : Object
	{
		// Token: 0x06001CA9 RID: 7337 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyName()
		{
			Il2CppClassPointerStore<AssemblyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr);
			AssemblyName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "name");
			AssemblyName.NativeFieldInfoPtr_codebase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "codebase");
			AssemblyName.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "major");
			AssemblyName.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "minor");
			AssemblyName.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "build");
			AssemblyName.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "revision");
			AssemblyName.NativeFieldInfoPtr_cultureinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "cultureinfo");
			AssemblyName.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "flags");
			AssemblyName.NativeFieldInfoPtr_hashalg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "hashalg");
			AssemblyName.NativeFieldInfoPtr_keypair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "keypair");
			AssemblyName.NativeFieldInfoPtr_publicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "publicKey");
			AssemblyName.NativeFieldInfoPtr_keyToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "keyToken");
			AssemblyName.NativeFieldInfoPtr_versioncompat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "versioncompat");
			AssemblyName.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "version");
			AssemblyName.NativeFieldInfoPtr_processor_architecture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "processor_architecture");
			AssemblyName.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "contentType");
			AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668080);
			AssemblyName.NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668081);
			AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668082);
			AssemblyName.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668083);
			AssemblyName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668084);
			AssemblyName.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668085);
			AssemblyName.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668086);
			AssemblyName.NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668087);
			AssemblyName.NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668088);
			AssemblyName.NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668089);
			AssemblyName.NativeMethodInfoPtr_get_FullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668090);
			AssemblyName.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668091);
			AssemblyName.NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668092);
			AssemblyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668093);
			AssemblyName.NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668094);
			AssemblyName.NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668095);
			AssemblyName.NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668096);
			AssemblyName.NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668097);
			AssemblyName.NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668098);
			AssemblyName.NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668099);
			AssemblyName.NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668100);
			AssemblyName.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668101);
			AssemblyName.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668102);
			AssemblyName.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668103);
			AssemblyName.NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668104);
			AssemblyName.NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668105);
			AssemblyName.NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668106);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000A325C File Offset: 0x000A145C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317627, RefRangeEnd = 317628, XrefRangeStart = 317626, XrefRangeEnd = 317627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x000A3298 File Offset: 0x000A1498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317628, XrefRangeEnd = 317629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &aname;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &is_version_definited;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &is_token_defined;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000A3300 File Offset: 0x000A1500
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 317639, RefRangeEnd = 317646, XrefRangeStart = 317629, XrefRangeEnd = 317639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName(string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x000A334C File Offset: 0x000A154C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317646, XrefRangeEnd = 317724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName(SerializationInfo si, StreamingContext sc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x000A33B0 File Offset: 0x000A15B0
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x000A33E8 File Offset: 0x000A15E8
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x000A342C File Offset: 0x000A162C
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x000A346C File Offset: 0x000A166C
		public unsafe CultureInfo CultureInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000A34B0 File Offset: 0x000A16B0
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x000A34EC File Offset: 0x000A16EC
		public unsafe AssemblyNameFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x000A352C File Offset: 0x000A172C
		public unsafe string FullName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 317780, RefRangeEnd = 317783, XrefRangeStart = 317724, XrefRangeEnd = 317780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_FullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x000A3564 File Offset: 0x000A1764
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x000A35A4 File Offset: 0x000A17A4
		public unsafe Version Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317783, XrefRangeEnd = 317787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000A35E8 File Offset: 0x000A17E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317787, XrefRangeEnd = 317789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000A3620 File Offset: 0x000A1820
		[CallerCount(0)]
		public unsafe Il2CppStructArray<byte> GetPublicKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000A3660 File Offset: 0x000A1860
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 317792, RefRangeEnd = 317797, XrefRangeStart = 317789, XrefRangeEnd = 317792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x000A36A0 File Offset: 0x000A18A0
		public unsafe bool IsPublicKeyValid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 317800, RefRangeEnd = 317803, XrefRangeStart = 317797, XrefRangeEnd = 317800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000A36DC File Offset: 0x000A18DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317803, XrefRangeEnd = 317809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> InternalGetPublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000A371C File Offset: 0x000A191C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317809, XrefRangeEnd = 317810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_public_token(byte* token, byte* pubkey, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pubkey;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000A3768 File Offset: 0x000A1968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317815, RefRangeEnd = 317818, XrefRangeStart = 317810, XrefRangeEnd = 317815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ComputePublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000A37A8 File Offset: 0x000A19A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317818, RefRangeEnd = 317819, XrefRangeStart = 317818, XrefRangeEnd = 317818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPublicKey(Il2CppStructArray<byte> publicKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(publicKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000A37EC File Offset: 0x000A19EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317819, XrefRangeEnd = 317867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000A3848 File Offset: 0x000A1A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317867, XrefRangeEnd = 317871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000A3888 File Offset: 0x000A1A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317871, XrefRangeEnd = 317875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x000A38CC File Offset: 0x000A1ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317875, XrefRangeEnd = 317876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assembly_ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000A3900 File Offset: 0x000A1B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317899, RefRangeEnd = 317901, XrefRangeStart = 317876, XrefRangeEnd = 317899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = native;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeBase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addVersion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addPublickey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultToken;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemblyRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000A3988 File Offset: 0x000A1B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317908, RefRangeEnd = 317909, XrefRangeStart = 317901, XrefRangeEnd = 317908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillCodebase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00009D7D File Offset: 0x00007F7D
		public AssemblyName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000A39DC File Offset: 0x000A1BDC
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00009D86 File Offset: 0x00007F86
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000A3A04 File Offset: 0x000A1C04
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00009DA5 File Offset: 0x00007FA5
		public unsafe string codebase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_codebase);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_codebase), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x000A3A2C File Offset: 0x000A1C2C
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00009DC4 File Offset: 0x00007FC4
		public unsafe int major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_major)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000A3A54 File Offset: 0x000A1C54
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x00009DDF File Offset: 0x00007FDF
		public unsafe int minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_minor)) = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x000A3A7C File Offset: 0x000A1C7C
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x00009DFA File Offset: 0x00007FFA
		public unsafe int build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_build)) = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000A3AA4 File Offset: 0x000A1CA4
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x00009E15 File Offset: 0x00008015
		public unsafe int revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_revision)) = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000A3ACC File Offset: 0x000A1CCC
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x00009E30 File Offset: 0x00008030
		public unsafe CultureInfo cultureinfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_cultureinfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_cultureinfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000A3AFC File Offset: 0x000A1CFC
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x00009E4F File Offset: 0x0000804F
		public unsafe AssemblyNameFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000A3B24 File Offset: 0x000A1D24
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00009E6A File Offset: 0x0000806A
		public unsafe AssemblyHashAlgorithm hashalg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_hashalg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_hashalg)) = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000A3B4C File Offset: 0x000A1D4C
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x00009E85 File Offset: 0x00008085
		public unsafe StrongNameKeyPair keypair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keypair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StrongNameKeyPair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keypair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000A3B7C File Offset: 0x000A1D7C
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x00009EA4 File Offset: 0x000080A4
		public unsafe Il2CppStructArray<byte> publicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_publicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_publicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000A3BAC File Offset: 0x000A1DAC
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00009EC3 File Offset: 0x000080C3
		public unsafe Il2CppStructArray<byte> keyToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keyToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keyToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000A3BDC File Offset: 0x000A1DDC
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00009EE2 File Offset: 0x000080E2
		public unsafe AssemblyVersionCompatibility versioncompat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_versioncompat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_versioncompat)) = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000A3C04 File Offset: 0x000A1E04
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00009EFD File Offset: 0x000080FD
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x000A3C34 File Offset: 0x000A1E34
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x00009F1C File Offset: 0x0000811C
		public unsafe ProcessorArchitecture processor_architecture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_processor_architecture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_processor_architecture)) = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000A3C5C File Offset: 0x000A1E5C
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00009F37 File Offset: 0x00008137
		public unsafe AssemblyContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeFieldInfoPtr_codebase;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr_revision;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr_cultureinfo;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr_hashalg;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr_keypair;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeFieldInfoPtr_publicKey;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr_keyToken;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr_versioncompat;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeFieldInfoPtr_processor_architecture;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_get_String_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0;
	}
}
