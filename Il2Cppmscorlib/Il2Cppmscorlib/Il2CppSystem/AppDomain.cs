using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Security.Policy;

namespace Il2CppSystem
{
	// Token: 0x02000103 RID: 259
	public sealed class AppDomain : MarshalByRefObject
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x0007A51C File Offset: 0x0007871C
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomain()
		{
			Il2CppClassPointerStore<AppDomain>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomain>.NativeClassPtr);
			AppDomain.NativeFieldInfoPtr__mono_app_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_mono_app_domain");
			AppDomain.NativeFieldInfoPtr__process_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_process_guid");
			AppDomain.NativeFieldInfoPtr_type_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "type_resolve_in_progress");
			AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress");
			AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress_refonly");
			AppDomain.NativeFieldInfoPtr__evidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_evidence");
			AppDomain.NativeFieldInfoPtr__granted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_granted");
			AppDomain.NativeFieldInfoPtr__principalPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_principalPolicy");
			AppDomain.NativeFieldInfoPtr__principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_principal");
			AppDomain.NativeFieldInfoPtr_default_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "default_domain");
			AppDomain.NativeFieldInfoPtr_AssemblyLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyLoad");
			AppDomain.NativeFieldInfoPtr_AssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyResolve");
			AppDomain.NativeFieldInfoPtr_DomainUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "DomainUnload");
			AppDomain.NativeFieldInfoPtr_ProcessExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ProcessExit");
			AppDomain.NativeFieldInfoPtr_ResourceResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ResourceResolve");
			AppDomain.NativeFieldInfoPtr_TypeResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "TypeResolve");
			AppDomain.NativeFieldInfoPtr_UnhandledException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "UnhandledException");
			AppDomain.NativeFieldInfoPtr_FirstChanceException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "FirstChanceException");
			AppDomain.NativeFieldInfoPtr__domain_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_domain_manager");
			AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ReflectionOnlyAssemblyResolve");
			AppDomain.NativeFieldInfoPtr__activation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_activation");
			AppDomain.NativeFieldInfoPtr__applicationIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_applicationIdentity");
			AppDomain.NativeFieldInfoPtr_compatibility_switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "compatibility_switch");
			AppDomain.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666611);
			AppDomain.NativeMethodInfoPtr_getFriendlyName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666612);
			AppDomain.NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666613);
			AppDomain.NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666614);
			AppDomain.NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666615);
			AppDomain.NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666616);
			AppDomain.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666617);
			AppDomain.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666618);
			AppDomain.NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666619);
			AppDomain.NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666620);
			AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666621);
			AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666622);
			AppDomain.NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666623);
			AppDomain.NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666624);
			AppDomain.NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666625);
			AppDomain.NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666626);
			AppDomain.NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666627);
			AppDomain.NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666628);
			AppDomain.NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666629);
			AppDomain.NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666630);
			AppDomain.NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666631);
			AppDomain.NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666632);
			AppDomain.NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666633);
			AppDomain.NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666634);
			AppDomain.NativeMethodInfoPtr_getDomainID_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666635);
			AppDomain.NativeMethodInfoPtr_GetCurrentThreadId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666636);
			AppDomain.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666637);
			AppDomain.NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666638);
			AppDomain.NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666639);
			AppDomain.NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666640);
			AppDomain.NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666641);
			AppDomain.NativeMethodInfoPtr_DoDomainUnload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666642);
			AppDomain.NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666643);
			AppDomain.NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666644);
			AppDomain.NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666645);
			AppDomain.NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666646);
			AppDomain.NativeMethodInfoPtr_add_ProcessExit_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666647);
			AppDomain.NativeMethodInfoPtr_remove_ProcessExit_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666648);
			AppDomain.NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666649);
			AppDomain.NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666650);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0007AA38 File Offset: 0x00078C38
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0007AA74 File Offset: 0x00078C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303625, XrefRangeEnd = 303626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getFriendlyName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getFriendlyName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0007AAAC File Offset: 0x00078CAC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 303627, RefRangeEnd = 303643, XrefRangeStart = 303626, XrefRangeEnd = 303627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain getCurDomain()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0007AAE0 File Offset: 0x00078CE0
		public unsafe static AppDomain CurrentDomain
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 303627, RefRangeEnd = 303643, XrefRangeStart = 303627, XrefRangeEnd = 303643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0007AB14 File Offset: 0x00078D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303643, XrefRangeEnd = 303644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Assembly> GetAssemblies(bool refOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr3) : null;
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0007AB60 File Offset: 0x00078D60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 303645, RefRangeEnd = 303650, XrefRangeStart = 303644, XrefRangeEnd = 303645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Assembly> GetAssemblies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr3) : null;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0007ABA0 File Offset: 0x00078DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303651, RefRangeEnd = 303652, XrefRangeStart = 303650, XrefRangeEnd = 303651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0007ABF0 File Offset: 0x00078DF0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object InitializeLifetimeService()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0007AC30 File Offset: 0x00078E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303652, XrefRangeEnd = 303653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0007ACA0 File Offset: 0x00078EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303653, XrefRangeEnd = 303655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0007AD00 File Offset: 0x00078F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303655, XrefRangeEnd = 303656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(string assemblyString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0007AD50 File Offset: 0x00078F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303656, XrefRangeEnd = 303657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblySecurity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0007ADC0 File Offset: 0x00078FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303657, XrefRangeEnd = 303658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain InternalSetDomainByID(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0007AE00 File Offset: 0x00079000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303658, XrefRangeEnd = 303659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain InternalSetDomain(AppDomain context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0007AE44 File Offset: 0x00079044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303659, XrefRangeEnd = 303660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalPushDomainRefByID(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0007AE78 File Offset: 0x00079078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303660, XrefRangeEnd = 303661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalPopDomainRef()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0007AEA0 File Offset: 0x000790A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 303662, RefRangeEnd = 303668, XrefRangeStart = 303661, XrefRangeEnd = 303662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalSetContext(Context context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0007AEE4 File Offset: 0x000790E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303669, RefRangeEnd = 303672, XrefRangeStart = 303668, XrefRangeEnd = 303669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalGetContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0007AF18 File Offset: 0x00079118
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303669, RefRangeEnd = 303672, XrefRangeStart = 303669, XrefRangeEnd = 303672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalGetDefaultContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0007AF4C File Offset: 0x0007914C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303672, XrefRangeEnd = 303673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalGetProcessGuid(string newguid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newguid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0007AF88 File Offset: 0x00079188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303683, RefRangeEnd = 303684, XrefRangeStart = 303673, XrefRangeEnd = 303683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeInDomainByID(int domain_id, MethodInfo method, Object obj, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0007B000 File Offset: 0x00079200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303694, RefRangeEnd = 303695, XrefRangeStart = 303684, XrefRangeEnd = 303694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetProcessGuid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0007B02C File Offset: 0x0007922C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsFinalizingForUnload(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0007B06C File Offset: 0x0007926C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303697, RefRangeEnd = 303699, XrefRangeStart = 303695, XrefRangeEnd = 303697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFinalizingForUnload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0007B0A8 File Offset: 0x000792A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303699, XrefRangeEnd = 303700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int getDomainID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getDomainID_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0007B0E4 File Offset: 0x000792E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303701, RefRangeEnd = 303702, XrefRangeStart = 303700, XrefRangeEnd = 303701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCurrentThreadId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetCurrentThreadId_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0007B114 File Offset: 0x00079314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0007B14C File Offset: 0x0007934C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303702, XrefRangeEnd = 303710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoAssemblyLoad(Assembly assembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0007B190 File Offset: 0x00079390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303710, XrefRangeEnd = 303748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestingAssembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0007B200 File Offset: 0x00079400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303748, XrefRangeEnd = 303781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoTypeResolve(Object name_or_tb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name_or_tb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0007B250 File Offset: 0x00079450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303781, XrefRangeEnd = 303789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoResourceResolve(string name, Assembly requesting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requesting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0007B2B4 File Offset: 0x000794B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303789, XrefRangeEnd = 303790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDomainUnload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoDomainUnload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0007B2E8 File Offset: 0x000794E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303790, XrefRangeEnd = 303803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetMarshalledDomainObjRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0007B328 File Offset: 0x00079528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303818, RefRangeEnd = 303819, XrefRangeStart = 303803, XrefRangeEnd = 303818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMessageInDomain(Il2CppStructArray<byte> arrRequest, CADMethodCallMessage cadMsg, out Il2CppStructArray<byte> arrResponse, out CADMethodReturnMessage cadMrm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cadMsg);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arrResponse = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			cadMrm = ((intPtr6 == 0) ? null : new CADMethodReturnMessage(intPtr6));
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0007B3C4 File Offset: 0x000795C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 303823, RefRangeEnd = 303828, XrefRangeStart = 303819, XrefRangeEnd = 303823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_DomainUnload(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0007B408 File Offset: 0x00079608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303828, XrefRangeEnd = 303832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_DomainUnload(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0007B44C File Offset: 0x0007964C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303836, RefRangeEnd = 303837, XrefRangeStart = 303832, XrefRangeEnd = 303836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ProcessExit(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_ProcessExit_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0007B490 File Offset: 0x00079690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303837, XrefRangeEnd = 303841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ProcessExit(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_ProcessExit_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0007B4D4 File Offset: 0x000796D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303845, RefRangeEnd = 303846, XrefRangeStart = 303841, XrefRangeEnd = 303845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_UnhandledException(UnhandledExceptionEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0007B518 File Offset: 0x00079718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303846, XrefRangeEnd = 303850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_UnhandledException(UnhandledExceptionEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00006884 File Offset: 0x00004A84
		public AppDomain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0007B55C File Offset: 0x0007975C
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x0000688D File Offset: 0x00004A8D
		public unsafe IntPtr _mono_app_domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__mono_app_domain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__mono_app_domain)) = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0007B584 File Offset: 0x00079784
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x000068A8 File Offset: 0x00004AA8
		public unsafe static string _process_guid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr__process_guid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr__process_guid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0007B5A4 File Offset: 0x000797A4
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000068BA File Offset: 0x00004ABA
		public unsafe static Dictionary<string, Object> type_resolve_in_progress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_type_resolve_in_progress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_type_resolve_in_progress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0007B5CC File Offset: 0x000797CC
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000068CC File Offset: 0x00004ACC
		public unsafe static Dictionary<string, Object> assembly_resolve_in_progress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x0007B5F4 File Offset: 0x000797F4
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x000068DE File Offset: 0x00004ADE
		public unsafe static Dictionary<string, Object> assembly_resolve_in_progress_refonly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0007B61C File Offset: 0x0007981C
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x000068F0 File Offset: 0x00004AF0
		public unsafe Object _evidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__evidence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__evidence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0007B64C File Offset: 0x0007984C
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x0000690F File Offset: 0x00004B0F
		public unsafe Object _granted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__granted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__granted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0007B67C File Offset: 0x0007987C
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x0000692E File Offset: 0x00004B2E
		public unsafe int _principalPolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__principalPolicy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__principalPolicy)) = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0007B6A4 File Offset: 0x000798A4
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00006949 File Offset: 0x00004B49
		public unsafe static Object _principal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr__principal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr__principal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0007B6CC File Offset: 0x000798CC
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x0000695B File Offset: 0x00004B5B
		public unsafe static AppDomain default_domain
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_default_domain, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_default_domain, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x0007B6F4 File Offset: 0x000798F4
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x0000696D File Offset: 0x00004B6D
		public unsafe AssemblyLoadEventHandler AssemblyLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssemblyLoadEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x0007B724 File Offset: 0x00079924
		// (set) Token: 0x06001342 RID: 4930 RVA: 0x0000698C File Offset: 0x00004B8C
		public unsafe ResolveEventHandler AssemblyResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x0007B754 File Offset: 0x00079954
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x000069AB File Offset: 0x00004BAB
		public unsafe EventHandler DomainUnload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_DomainUnload);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_DomainUnload), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x0007B784 File Offset: 0x00079984
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x000069CA File Offset: 0x00004BCA
		public unsafe EventHandler ProcessExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ProcessExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ProcessExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x0007B7B4 File Offset: 0x000799B4
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x000069E9 File Offset: 0x00004BE9
		public unsafe ResolveEventHandler ResourceResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ResourceResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ResourceResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0007B7E4 File Offset: 0x000799E4
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00006A08 File Offset: 0x00004C08
		public unsafe ResolveEventHandler TypeResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_TypeResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_TypeResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x0007B814 File Offset: 0x00079A14
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x00006A27 File Offset: 0x00004C27
		public unsafe UnhandledExceptionEventHandler UnhandledException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_UnhandledException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_UnhandledException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x0007B844 File Offset: 0x00079A44
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x00006A46 File Offset: 0x00004C46
		public unsafe EventHandler<FirstChanceExceptionEventArgs> FirstChanceException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_FirstChanceException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<FirstChanceExceptionEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_FirstChanceException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0007B874 File Offset: 0x00079A74
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x00006A65 File Offset: 0x00004C65
		public unsafe Object _domain_manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__domain_manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__domain_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x0007B8A4 File Offset: 0x00079AA4
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x00006A84 File Offset: 0x00004C84
		public unsafe ResolveEventHandler ReflectionOnlyAssemblyResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x0007B8D4 File Offset: 0x00079AD4
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00006AA3 File Offset: 0x00004CA3
		public unsafe Object _activation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__activation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__activation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x0007B904 File Offset: 0x00079B04
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00006AC2 File Offset: 0x00004CC2
		public unsafe Object _applicationIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__applicationIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__applicationIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0007B934 File Offset: 0x00079B34
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00006AE1 File Offset: 0x00004CE1
		public unsafe List<string> compatibility_switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_compatibility_switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_compatibility_switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeFieldInfoPtr__mono_app_domain;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeFieldInfoPtr__process_guid;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeFieldInfoPtr_type_resolve_in_progress;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress_refonly;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeFieldInfoPtr__evidence;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeFieldInfoPtr__granted;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeFieldInfoPtr__principalPolicy;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeFieldInfoPtr__principal;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeFieldInfoPtr_default_domain;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyLoad;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyResolve;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_DomainUnload;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_ProcessExit;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr_ResourceResolve;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_TypeResolve;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_UnhandledException;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_FirstChanceException;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeFieldInfoPtr__domain_manager;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr__activation;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr__applicationIdentity;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr_compatibility_switch;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_getFriendlyName_Private_String_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_getDomainID_Private_Int32_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentThreadId_Public_Static_Int32_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_Object_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_DoDomainUnload_Private_Void_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_add_ProcessExit_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_remove_ProcessExit_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0;
	}
}
