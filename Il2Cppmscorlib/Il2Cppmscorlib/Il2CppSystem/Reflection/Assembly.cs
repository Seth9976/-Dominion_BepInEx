using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Policy;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BF RID: 447
	[Serializable]
	public class Assembly : Object
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x000A175C File Offset: 0x0009F95C
		// Note: this type is marked as 'beforefieldinit'.
		static Assembly()
		{
			Il2CppClassPointerStore<Assembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Assembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assembly>.NativeClassPtr);
			Assembly.NativeFieldInfoPtr__mono_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "_mono_assembly");
			Assembly.NativeFieldInfoPtr_resolve_event_holder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "resolve_event_holder");
			Assembly.NativeFieldInfoPtr__evidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "_evidence");
			Assembly.NativeFieldInfoPtr__minimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "_minimum");
			Assembly.NativeFieldInfoPtr__optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "_optional");
			Assembly.NativeFieldInfoPtr__refuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "_refuse");
			Assembly.NativeFieldInfoPtr__granted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "_granted");
			Assembly.NativeFieldInfoPtr__denied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "_denied");
			Assembly.NativeFieldInfoPtr_fromByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "fromByteArray");
			Assembly.NativeFieldInfoPtr_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "assemblyName");
			Assembly.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668025);
			Assembly.NativeMethodInfoPtr_get_code_base_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668026);
			Assembly.NativeMethodInfoPtr_get_fullname_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668027);
			Assembly.NativeMethodInfoPtr_get_location_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668028);
			Assembly.NativeMethodInfoPtr_GetAotId_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668029);
			Assembly.NativeMethodInfoPtr_GetCodeBase_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668030);
			Assembly.NativeMethodInfoPtr_get_CodeBase_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668031);
			Assembly.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668032);
			Assembly.NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668033);
			Assembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668034);
			Assembly.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668035);
			Assembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668036);
			Assembly.NativeMethodInfoPtr_GetManifestResourceInternal_Internal_IntPtr_String_byref_Int32_byref_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668037);
			Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_New_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668038);
			Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_Type_String_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668039);
			Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_String_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668040);
			Assembly.NativeMethodInfoPtr_GetSimpleName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668041);
			Assembly.NativeMethodInfoPtr_GetPublicKey_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668042);
			Assembly.NativeMethodInfoPtr_GetVersion_Internal_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668043);
			Assembly.NativeMethodInfoPtr_GetFlags_Private_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668044);
			Assembly.NativeMethodInfoPtr_GetTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668045);
			Assembly.NativeMethodInfoPtr_GetTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668046);
			Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668047);
			Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668048);
			Assembly.NativeMethodInfoPtr_InternalGetType_Internal_Type_Module_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668049);
			Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668050);
			Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668051);
			Assembly.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668052);
			Assembly.NativeMethodInfoPtr_GetAssembly_Public_Static_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668053);
			Assembly.NativeMethodInfoPtr_InternalGetSatelliteAssembly_Internal_RuntimeAssembly_String_CultureInfo_Version_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668054);
			Assembly.NativeMethodInfoPtr_LoadFrom_Private_Static_Assembly_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668055);
			Assembly.NativeMethodInfoPtr_LoadFrom_Public_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668056);
			Assembly.NativeMethodInfoPtr_Load_Public_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668057);
			Assembly.NativeMethodInfoPtr_load_with_partial_name_Private_Static_Assembly_String_Evidence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668058);
			Assembly.NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_Evidence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668059);
			Assembly.NativeMethodInfoPtr_LoadWithPartialName_Internal_Static_Assembly_String_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668060);
			Assembly.NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_New_Il2CppReferenceArray_1_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668061);
			Assembly.NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668062);
			Assembly.NativeMethodInfoPtr_GetExecutingAssembly_Public_Static_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668063);
			Assembly.NativeMethodInfoPtr_GetCallingAssembly_Public_Static_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668064);
			Assembly.NativeMethodInfoPtr_GetManifestResourceInfoInternal_Private_Boolean_String_ManifestResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668065);
			Assembly.NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_New_ManifestResourceInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668066);
			Assembly.NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668067);
			Assembly.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668068);
			Assembly.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668069);
			Assembly.NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668070);
			Assembly.NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668071);
			Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668072);
			Assembly.NativeMethodInfoPtr_GetModule_Public_Virtual_New_Module_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668073);
			Assembly.NativeMethodInfoPtr_GetModules_Public_Virtual_New_Il2CppReferenceArray_1_Module_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668074);
			Assembly.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Assembly_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668075);
			Assembly.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Assembly_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100668076);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x000A1C64 File Offset: 0x0009FE64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317371, RefRangeEnd = 317372, XrefRangeStart = 317366, XrefRangeEnd = 317371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000A1CA0 File Offset: 0x0009FEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317372, XrefRangeEnd = 317373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string get_code_base(bool escaped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref escaped;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_get_code_base_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000A1CE4 File Offset: 0x0009FEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317373, XrefRangeEnd = 317374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string get_fullname()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_get_fullname_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000A1D1C File Offset: 0x0009FF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317374, XrefRangeEnd = 317375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string get_location()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_get_location_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000A1D54 File Offset: 0x0009FF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317376, RefRangeEnd = 317377, XrefRangeStart = 317375, XrefRangeEnd = 317376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAotId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetAotId_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000A1D80 File Offset: 0x0009FF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCodeBase(bool escaped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref escaped;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetCodeBase_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000A1DC4 File Offset: 0x0009FFC4
		public unsafe virtual string CodeBase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317377, XrefRangeEnd = 317378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_CodeBase_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x000A1E08 File Offset: 0x000A0008
		public unsafe virtual string FullName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282571, RefRangeEnd = 282572, XrefRangeStart = 282571, XrefRangeEnd = 282572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x000A1E4C File Offset: 0x000A004C
		public unsafe virtual string Location
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317378, XrefRangeEnd = 317381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x000A1E90 File Offset: 0x000A0090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317381, XrefRangeEnd = 317386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x000A1EF4 File Offset: 0x000A00F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317386, XrefRangeEnd = 317390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000A1F5C File Offset: 0x000A015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317390, XrefRangeEnd = 317394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x000A1FC8 File Offset: 0x000A01C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317395, RefRangeEnd = 317396, XrefRangeStart = 317394, XrefRangeEnd = 317395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetManifestResourceInternal(string name, out int size, out Module module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetManifestResourceInternal_Internal_IntPtr_String_byref_Int32_byref_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			module = ((intPtr4 == 0) ? null : new Module(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000A2048 File Offset: 0x000A0248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317396, XrefRangeEnd = 317399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Stream GetManifestResourceStream(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_New_Stream_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000A20A4 File Offset: 0x000A02A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317422, RefRangeEnd = 317425, XrefRangeStart = 317399, XrefRangeEnd = 317422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSecurityCheck;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_Type_String_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000A2124 File Offset: 0x000A0324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317426, RefRangeEnd = 317427, XrefRangeStart = 317425, XrefRangeEnd = 317426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSecurityCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_String_byref_StackCrawlMark_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000A2190 File Offset: 0x000A0390
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317427, RefRangeEnd = 317431, XrefRangeStart = 317427, XrefRangeEnd = 317427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSimpleName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetSimpleName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000A21C8 File Offset: 0x000A03C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317431, RefRangeEnd = 317432, XrefRangeStart = 317431, XrefRangeEnd = 317431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPublicKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetPublicKey_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x000A2208 File Offset: 0x000A0408
		[CallerCount(0)]
		public unsafe Version GetVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetVersion_Internal_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x000A2248 File Offset: 0x000A0448
		[CallerCount(0)]
		public unsafe AssemblyNameFlags GetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetFlags_Private_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000A2284 File Offset: 0x000A0484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317432, XrefRangeEnd = 317433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetTypes(bool exportedOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exportedOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x000A22DC File Offset: 0x000A04DC
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x000A2328 File Offset: 0x000A0528
		[CallerCount(0)]
		public unsafe virtual Type GetType(string name, bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000A2394 File Offset: 0x000A0594
		[CallerCount(0)]
		public unsafe virtual Type GetType(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x000A23F0 File Offset: 0x000A05F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317434, RefRangeEnd = 317435, XrefRangeStart = 317433, XrefRangeEnd = 317434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_InternalGetType_Internal_Type_Module_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x000A2470 File Offset: 0x000A0670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317435, XrefRangeEnd = 317440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AssemblyName GetName(bool copiedName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref copiedName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x000A24C8 File Offset: 0x000A06C8
		[CallerCount(0)]
		public unsafe virtual AssemblyName GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x000A2514 File Offset: 0x000A0714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317440, XrefRangeEnd = 317441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000A2558 File Offset: 0x000A0758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317441, XrefRangeEnd = 317452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly GetAssembly(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetAssembly_Public_Static_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000A259C File Offset: 0x000A079C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317487, RefRangeEnd = 317488, XrefRangeStart = 317452, XrefRangeEnd = 317487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(version);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnFileNotFound;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_InternalGetSatelliteAssembly_Internal_RuntimeAssembly_String_CultureInfo_Version_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x000A2630 File Offset: 0x000A0830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317488, XrefRangeEnd = 317489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadFrom(string assemblyFile, bool refonly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadFrom_Private_Static_Assembly_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000A2684 File Offset: 0x000A0884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317489, XrefRangeEnd = 317490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadFrom(string assemblyFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadFrom_Public_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000A26C8 File Offset: 0x000A08C8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 317492, RefRangeEnd = 317504, XrefRangeStart = 317490, XrefRangeEnd = 317492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly Load(string assemblyString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_Load_Public_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000A270C File Offset: 0x000A090C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317504, XrefRangeEnd = 317505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly load_with_partial_name(string name, Evidence e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_load_with_partial_name_Private_Static_Assembly_String_Evidence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000A2764 File Offset: 0x000A0964
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317511, RefRangeEnd = 317513, XrefRangeStart = 317505, XrefRangeEnd = 317511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(partialName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_Evidence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000A27BC File Offset: 0x000A09BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317513, XrefRangeEnd = 317524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(partialName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadWithPartialName_Internal_Static_Assembly_String_Evidence_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x000A2820 File Offset: 0x000A0A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317524, XrefRangeEnd = 317525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Module> GetModulesInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_New_Il2CppReferenceArray_1_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Module>>(intPtr3) : null;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x000A286C File Offset: 0x000A0A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317525, XrefRangeEnd = 317526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetManifestResourceNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_New_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x000A28B8 File Offset: 0x000A0AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317526, XrefRangeEnd = 317529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly GetExecutingAssembly()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetExecutingAssembly_Public_Static_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x000A28EC File Offset: 0x000A0AEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317530, RefRangeEnd = 317532, XrefRangeStart = 317529, XrefRangeEnd = 317530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly GetCallingAssembly()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetCallingAssembly_Public_Static_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x000A2920 File Offset: 0x000A0B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317532, XrefRangeEnd = 317533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetManifestResourceInfoInternal_Private_Boolean_String_ManifestResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000A2980 File Offset: 0x000A0B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317533, XrefRangeEnd = 317538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_New_ManifestResourceInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManifestResourceInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000A29DC File Offset: 0x000A0BDC
		public unsafe virtual bool ReflectionOnly
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x000A2A24 File Offset: 0x000A0C24
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000A2A6C File Offset: 0x000A0C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317538, XrefRangeEnd = 317541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000A2AC4 File Offset: 0x000A0CC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317547, RefRangeEnd = 317550, XrefRangeStart = 317541, XrefRangeEnd = 317547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateNIE()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x000A2AF8 File Offset: 0x000A0CF8
		public unsafe bool IsFullyTrusted
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x000A2B34 File Offset: 0x000A0D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317550, XrefRangeEnd = 317553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x000A2BAC File Offset: 0x000A0DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317553, XrefRangeEnd = 317556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Module GetModule(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetModule_Public_Virtual_New_Module_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000A2C08 File Offset: 0x000A0E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317556, XrefRangeEnd = 317559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Module> GetModules(bool getResourceModules)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref getResourceModules;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetModules_Public_Virtual_New_Il2CppReferenceArray_1_Module_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Module>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000A2C60 File Offset: 0x000A0E60
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 317559, RefRangeEnd = 317601, XrefRangeStart = 317559, XrefRangeEnd = 317559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Assembly left, Assembly right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Assembly_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000A2CB4 File Offset: 0x000A0EB4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 317601, RefRangeEnd = 317626, XrefRangeStart = 317601, XrefRangeEnd = 317601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Assembly left, Assembly right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Assembly_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00009C46 File Offset: 0x00007E46
		public Assembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000A2D08 File Offset: 0x000A0F08
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00009C4F File Offset: 0x00007E4F
		public unsafe IntPtr _mono_assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__mono_assembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__mono_assembly)) = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x000A2D30 File Offset: 0x000A0F30
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x00009C6A File Offset: 0x00007E6A
		public unsafe Assembly.ResolveEventHolder resolve_event_holder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr_resolve_event_holder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly.ResolveEventHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr_resolve_event_holder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x000A2D60 File Offset: 0x000A0F60
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x00009C89 File Offset: 0x00007E89
		public unsafe Object _evidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__evidence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__evidence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000A2D90 File Offset: 0x000A0F90
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x00009CA8 File Offset: 0x00007EA8
		public unsafe Object _minimum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__minimum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__minimum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x000A2DC0 File Offset: 0x000A0FC0
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x00009CC7 File Offset: 0x00007EC7
		public unsafe Object _optional
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__optional);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__optional), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x000A2DF0 File Offset: 0x000A0FF0
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x00009CE6 File Offset: 0x00007EE6
		public unsafe Object _refuse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__refuse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__refuse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x000A2E20 File Offset: 0x000A1020
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x00009D05 File Offset: 0x00007F05
		public unsafe Object _granted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__granted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__granted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x000A2E50 File Offset: 0x000A1050
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x00009D24 File Offset: 0x00007F24
		public unsafe Object _denied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__denied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr__denied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000A2E80 File Offset: 0x000A1080
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x00009D43 File Offset: 0x00007F43
		public unsafe bool fromByteArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr_fromByteArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr_fromByteArray)) = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000A2EA8 File Offset: 0x000A10A8
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x00009D5E File Offset: 0x00007F5E
		public unsafe string assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr_assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.NativeFieldInfoPtr_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeFieldInfoPtr__mono_assembly;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeFieldInfoPtr_resolve_event_holder;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeFieldInfoPtr__evidence;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeFieldInfoPtr__minimum;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeFieldInfoPtr__optional;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeFieldInfoPtr__refuse;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr__granted;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeFieldInfoPtr__denied;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeFieldInfoPtr_fromByteArray;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeFieldInfoPtr_assemblyName;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr_get_code_base_Private_String_Boolean_0;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeMethodInfoPtr_get_fullname_Private_String_0;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_get_location_Private_String_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr_GetAotId_Internal_Static_String_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_GetCodeBase_Private_String_Boolean_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_get_CodeBase_Public_Virtual_New_get_String_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_String_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceInternal_Internal_IntPtr_String_byref_Int32_byref_Module_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_New_Stream_String_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_Type_String_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_String_byref_StackCrawlMark_Boolean_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleName_Internal_String_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKey_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_GetVersion_Internal_Version_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_GetFlags_Private_AssemblyNameFlags_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetType_Internal_Type_Module_String_Boolean_Boolean_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_Boolean_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Public_Static_Assembly_Type_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSatelliteAssembly_Internal_RuntimeAssembly_String_CultureInfo_Version_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_LoadFrom_Private_Static_Assembly_String_Boolean_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_LoadFrom_Public_Static_Assembly_String_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Assembly_String_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_load_with_partial_name_Private_Static_Assembly_String_Evidence_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_Evidence_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialName_Internal_Static_Assembly_String_Evidence_Boolean_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_New_Il2CppReferenceArray_1_Module_0;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_New_Il2CppStringArray_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_GetExecutingAssembly_Public_Static_Assembly_0;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr_GetCallingAssembly_Public_Static_Assembly_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceInfoInternal_Private_Boolean_String_ManifestResourceInfo_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_New_ManifestResourceInfo_String_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_Boolean_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_Virtual_New_Module_String_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_GetModules_Public_Virtual_New_Il2CppReferenceArray_1_Module_Boolean_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Assembly_Assembly_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Assembly_Assembly_0;

		// Token: 0x020005C3 RID: 1475
		public class ResolveEventHolder : Object
		{
			// Token: 0x06005107 RID: 20743 RVA: 0x0001ED94 File Offset: 0x0001CF94
			// Note: this type is marked as 'beforefieldinit'.
			static ResolveEventHolder()
			{
				Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "ResolveEventHolder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr);
				Assembly.ResolveEventHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr, 100668077);
			}

			// Token: 0x06005108 RID: 20744 RVA: 0x0016ABBC File Offset: 0x00168DBC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResolveEventHolder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.ResolveEventHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005109 RID: 20745 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
			public ResolveEventHolder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040041C0 RID: 16832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005C4 RID: 1476
		public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
		{
			// Token: 0x0600510A RID: 20746 RVA: 0x0016ABF8 File Offset: 0x00168DF8
			// Note: this type is marked as 'beforefieldinit'.
			static UnmanagedMemoryStreamForModule()
			{
				Il2CppClassPointerStore<Assembly.UnmanagedMemoryStreamForModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "UnmanagedMemoryStreamForModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assembly.UnmanagedMemoryStreamForModule>.NativeClassPtr);
				Assembly.UnmanagedMemoryStreamForModule.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assembly.UnmanagedMemoryStreamForModule>.NativeClassPtr, "module");
				Assembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly.UnmanagedMemoryStreamForModule>.NativeClassPtr, 100668078);
				Assembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly.UnmanagedMemoryStreamForModule>.NativeClassPtr, 100668079);
			}

			// Token: 0x0600510B RID: 20747 RVA: 0x0016AC60 File Offset: 0x00168E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317364, XrefRangeEnd = 317365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnmanagedMemoryStreamForModule(byte* pointer, long length, Module module)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assembly.UnmanagedMemoryStreamForModule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = pointer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600510C RID: 20748 RVA: 0x0016ACC8 File Offset: 0x00168EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317365, XrefRangeEnd = 317366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600510D RID: 20749 RVA: 0x0001EDD1 File Offset: 0x0001CFD1
			public UnmanagedMemoryStreamForModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014BC RID: 5308
			// (get) Token: 0x0600510E RID: 20750 RVA: 0x0016AD14 File Offset: 0x00168F14
			// (set) Token: 0x0600510F RID: 20751 RVA: 0x0001EDDA File Offset: 0x0001CFDA
			public unsafe Module module
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.UnmanagedMemoryStreamForModule.NativeFieldInfoPtr_module);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Module>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assembly.UnmanagedMemoryStreamForModule.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041C1 RID: 16833
			private static readonly IntPtr NativeFieldInfoPtr_module;

			// Token: 0x040041C2 RID: 16834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Module_0;

			// Token: 0x040041C3 RID: 16835
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
		}
	}
}
