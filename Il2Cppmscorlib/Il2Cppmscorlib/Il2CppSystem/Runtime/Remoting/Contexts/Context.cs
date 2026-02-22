using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B4 RID: 948
	public class Context : Object
	{
		// Token: 0x06003D79 RID: 15737 RVA: 0x001204C8 File Offset: 0x0011E6C8
		// Note: this type is marked as 'beforefieldinit'.
		static Context()
		{
			Il2CppClassPointerStore<Context>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "Context");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context>.NativeClassPtr);
			Context.NativeFieldInfoPtr_domain_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "domain_id");
			Context.NativeFieldInfoPtr_context_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_id");
			Context.NativeFieldInfoPtr_static_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "static_data");
			Context.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "data");
			Context.NativeFieldInfoPtr_local_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "local_slots");
			Context.NativeFieldInfoPtr_default_server_context_sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "default_server_context_sink");
			Context.NativeFieldInfoPtr_server_context_sink_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "server_context_sink_chain");
			Context.NativeFieldInfoPtr_client_context_sink_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "client_context_sink_chain");
			Context.NativeFieldInfoPtr_context_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_properties");
			Context.NativeFieldInfoPtr_global_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "global_count");
			Context.NativeFieldInfoPtr__localDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "_localDataStore");
			Context.NativeFieldInfoPtr__localDataStoreMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "_localDataStoreMgr");
			Context.NativeFieldInfoPtr_global_dynamic_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "global_dynamic_properties");
			Context.NativeFieldInfoPtr_context_dynamic_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_dynamic_properties");
			Context.NativeFieldInfoPtr_callback_object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "callback_object");
			Context.NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672343);
			Context.NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672344);
			Context.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672345);
			Context.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672346);
			Context.NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672347);
			Context.NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672348);
			Context.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672349);
			Context.NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672350);
			Context.NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672351);
			Context.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672352);
			Context.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672353);
			Context.NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672354);
			Context.NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672355);
			Context.NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672356);
			Context.NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672357);
			Context.NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672358);
			Context.NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672359);
			Context.NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672360);
			Context.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672361);
			Context.NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672362);
			Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672363);
			Context.NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672364);
			Context.NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672365);
			Context.NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672366);
			Context.NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672367);
			Context.NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672368);
			Context.NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672369);
			Context.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672370);
			Context.NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672371);
			Context.NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672372);
			Context.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672373);
			Context.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672374);
			Context.NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672375);
			Context.NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672376);
			Context.NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672377);
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x001208E0 File Offset: 0x0011EAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterContext(Context ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00120918 File Offset: 0x0011EB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseContext(Context ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00120950 File Offset: 0x0011EB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352257, XrefRangeEnd = 352265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x0012098C File Offset: 0x0011EB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352265, XrefRangeEnd = 352272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06003D7E RID: 15742 RVA: 0x001209C8 File Offset: 0x0011EBC8
		public unsafe static Context DefaultContext
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 332653, RefRangeEnd = 332674, XrefRangeStart = 332653, XrefRangeEnd = 332674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x001209FC File Offset: 0x0011EBFC
		public unsafe virtual int ContextID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x00120A44 File Offset: 0x0011EC44
		public unsafe virtual Il2CppReferenceArray<IContextProperty> ContextProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352272, XrefRangeEnd = 352278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IContextProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x00120A90 File Offset: 0x0011EC90
		public unsafe bool IsDefaultContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x00120ACC File Offset: 0x0011ECCC
		public unsafe bool NeedsContextSink
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352278, XrefRangeEnd = 352285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00120B08 File Offset: 0x0011ED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352285, XrefRangeEnd = 352329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00120B70 File Offset: 0x0011ED70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352329, XrefRangeEnd = 352379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00120BD8 File Offset: 0x0011EDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352379, XrefRangeEnd = 352394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr3) : null;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00120C30 File Offset: 0x0011EE30
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 352405, RefRangeEnd = 352415, XrefRangeStart = 352394, XrefRangeEnd = 352405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00120C90 File Offset: 0x0011EE90
		public unsafe static bool HasGlobalDynamicSinks
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 352419, RefRangeEnd = 352422, XrefRangeStart = 352415, XrefRangeEnd = 352419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00120CC0 File Offset: 0x0011EEC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 352424, RefRangeEnd = 352429, XrefRangeStart = 352422, XrefRangeEnd = 352424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x00120D2C File Offset: 0x0011EF2C
		public unsafe bool HasDynamicSinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x00120D68 File Offset: 0x0011EF68
		public unsafe bool HasExitSinks
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 352437, RefRangeEnd = 352438, XrefRangeStart = 352429, XrefRangeEnd = 352437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00120DA4 File Offset: 0x0011EFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352438, XrefRangeEnd = 352458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IContextProperty GetProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContextProperty>(intPtr3) : null;
			}
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00120E00 File Offset: 0x0011F000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352458, XrefRangeEnd = 352484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProperty(IContextProperty prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x00120E50 File Offset: 0x0011F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352484, XrefRangeEnd = 352502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Freeze()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00120E8C File Offset: 0x0011F08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352502, XrefRangeEnd = 352508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00120ED0 File Offset: 0x0011F0D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352530, RefRangeEnd = 352532, XrefRangeStart = 352508, XrefRangeEnd = 352530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink GetServerContextSinkChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00120F10 File Offset: 0x0011F110
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 352555, RefRangeEnd = 352559, XrefRangeStart = 352532, XrefRangeEnd = 352555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink GetClientContextSinkChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x00120F50 File Offset: 0x0011F150
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 352579, RefRangeEnd = 352585, XrefRangeStart = 352559, XrefRangeEnd = 352579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceInternalExecute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00120FB0 File Offset: 0x0011F1B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352608, RefRangeEnd = 352610, XrefRangeStart = 352585, XrefRangeEnd = 352608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00121000 File Offset: 0x0011F200
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 352611, RefRangeEnd = 352616, XrefRangeStart = 352610, XrefRangeEnd = 352611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context SwitchToContext(Context newContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00121044 File Offset: 0x0011F244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352677, RefRangeEnd = 352678, XrefRangeStart = 352616, XrefRangeEnd = 352677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context CreateNewContext(IConstructionCallMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00121088 File Offset: 0x0011F288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352678, XrefRangeEnd = 352690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(CrossContextDelegate deleg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deleg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06003D96 RID: 15766 RVA: 0x001210CC File Offset: 0x0011F2CC
		public unsafe LocalDataStore MyLocalStore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352705, RefRangeEnd = 352707, XrefRangeStart = 352690, XrefRangeEnd = 352705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStore>(intPtr3) : null;
			}
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x0012110C File Offset: 0x0011F30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352707, XrefRangeEnd = 352713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot AllocateDataSlot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00121140 File Offset: 0x0011F340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352713, XrefRangeEnd = 352719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00121184 File Offset: 0x0011F384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352719, XrefRangeEnd = 352725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x001211BC File Offset: 0x0011F3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352725, XrefRangeEnd = 352731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00121200 File Offset: 0x0011F400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352731, XrefRangeEnd = 352735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetData(LocalDataStoreSlot slot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00121244 File Offset: 0x0011F444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352735, XrefRangeEnd = 352739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetData(LocalDataStoreSlot slot, Object data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x00017255 File Offset: 0x00015455
		public Context(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x0012128C File Offset: 0x0011F48C
		// (set) Token: 0x06003D9F RID: 15775 RVA: 0x0001725E File Offset: 0x0001545E
		public unsafe int domain_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_domain_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_domain_id)) = value;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x001212B4 File Offset: 0x0011F4B4
		// (set) Token: 0x06003DA1 RID: 15777 RVA: 0x00017279 File Offset: 0x00015479
		public unsafe int context_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_id)) = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x001212DC File Offset: 0x0011F4DC
		// (set) Token: 0x06003DA3 RID: 15779 RVA: 0x00017294 File Offset: 0x00015494
		public unsafe UIntPtr static_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_static_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_static_data)) = value;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x00121304 File Offset: 0x0011F504
		// (set) Token: 0x06003DA5 RID: 15781 RVA: 0x000172AF File Offset: 0x000154AF
		public unsafe UIntPtr data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x0012132C File Offset: 0x0011F52C
		// (set) Token: 0x06003DA7 RID: 15783 RVA: 0x000172CA File Offset: 0x000154CA
		public unsafe static Il2CppReferenceArray<Object> local_slots
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_local_slots, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_local_slots, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003DA8 RID: 15784 RVA: 0x00121354 File Offset: 0x0011F554
		// (set) Token: 0x06003DA9 RID: 15785 RVA: 0x000172DC File Offset: 0x000154DC
		public unsafe static IMessageSink default_server_context_sink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_default_server_context_sink, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_default_server_context_sink, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003DAA RID: 15786 RVA: 0x0012137C File Offset: 0x0011F57C
		// (set) Token: 0x06003DAB RID: 15787 RVA: 0x000172EE File Offset: 0x000154EE
		public unsafe IMessageSink server_context_sink_chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_server_context_sink_chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_server_context_sink_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x001213AC File Offset: 0x0011F5AC
		// (set) Token: 0x06003DAD RID: 15789 RVA: 0x0001730D File Offset: 0x0001550D
		public unsafe IMessageSink client_context_sink_chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_client_context_sink_chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_client_context_sink_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x001213DC File Offset: 0x0011F5DC
		// (set) Token: 0x06003DAF RID: 15791 RVA: 0x0001732C File Offset: 0x0001552C
		public unsafe List<IContextProperty> context_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IContextProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x0012140C File Offset: 0x0011F60C
		// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x0001734B File Offset: 0x0001554B
		public unsafe static int global_count
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_global_count, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_global_count, (void*)(&value));
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x00121428 File Offset: 0x0011F628
		// (set) Token: 0x06003DB3 RID: 15795 RVA: 0x00017359 File Offset: 0x00015559
		public unsafe LocalDataStoreHolder _localDataStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr__localDataStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr__localDataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x00121458 File Offset: 0x0011F658
		// (set) Token: 0x06003DB5 RID: 15797 RVA: 0x00017378 File Offset: 0x00015578
		public unsafe static LocalDataStoreMgr _localDataStoreMgr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr__localDataStoreMgr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr__localDataStoreMgr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x00121480 File Offset: 0x0011F680
		// (set) Token: 0x06003DB7 RID: 15799 RVA: 0x0001738A File Offset: 0x0001558A
		public unsafe static DynamicPropertyCollection global_dynamic_properties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_global_dynamic_properties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_global_dynamic_properties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x001214A8 File Offset: 0x0011F6A8
		// (set) Token: 0x06003DB9 RID: 15801 RVA: 0x0001739C File Offset: 0x0001559C
		public unsafe DynamicPropertyCollection context_dynamic_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_dynamic_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_dynamic_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x001214D8 File Offset: 0x0011F6D8
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x000173BB File Offset: 0x000155BB
		public unsafe ContextCallbackObject callback_object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_callback_object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallbackObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_callback_object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeFieldInfoPtr_domain_id;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeFieldInfoPtr_context_id;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeFieldInfoPtr_static_data;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeFieldInfoPtr_local_slots;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeFieldInfoPtr_default_server_context_sink;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeFieldInfoPtr_server_context_sink_chain;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeFieldInfoPtr_client_context_sink_chain;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeFieldInfoPtr_context_properties;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeFieldInfoPtr_global_count;

		// Token: 0x040032E9 RID: 13033
		private static readonly IntPtr NativeFieldInfoPtr__localDataStore;

		// Token: 0x040032EA RID: 13034
		private static readonly IntPtr NativeFieldInfoPtr__localDataStoreMgr;

		// Token: 0x040032EB RID: 13035
		private static readonly IntPtr NativeFieldInfoPtr_global_dynamic_properties;

		// Token: 0x040032EC RID: 13036
		private static readonly IntPtr NativeFieldInfoPtr_context_dynamic_properties;

		// Token: 0x040032ED RID: 13037
		private static readonly IntPtr NativeFieldInfoPtr_callback_object;

		// Token: 0x040032EE RID: 13038
		private static readonly IntPtr NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0;

		// Token: 0x040032EF RID: 13039
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0;

		// Token: 0x040032F0 RID: 13040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040032F1 RID: 13041
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040032F2 RID: 13042
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0;

		// Token: 0x040032F3 RID: 13043
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0;

		// Token: 0x040032F4 RID: 13044
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0;

		// Token: 0x040032F5 RID: 13045
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0;

		// Token: 0x040032F6 RID: 13046
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0;

		// Token: 0x040032F7 RID: 13047
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0;

		// Token: 0x040032F8 RID: 13048
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0;

		// Token: 0x040032F9 RID: 13049
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0;

		// Token: 0x040032FA RID: 13050
		private static readonly IntPtr NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x040032FB RID: 13051
		private static readonly IntPtr NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0;

		// Token: 0x040032FC RID: 13052
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x040032FD RID: 13053
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0;

		// Token: 0x040032FE RID: 13054
		private static readonly IntPtr NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0;

		// Token: 0x040032FF RID: 13055
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0;

		// Token: 0x04003300 RID: 13056
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0;

		// Token: 0x04003301 RID: 13057
		private static readonly IntPtr NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0;

		// Token: 0x04003302 RID: 13058
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003303 RID: 13059
		private static readonly IntPtr NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0;

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0;

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0;

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0;

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0;

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0;

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0;

		// Token: 0x04003310 RID: 13072
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0;
	}
}
