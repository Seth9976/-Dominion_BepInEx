using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E0 RID: 992
	[Serializable]
	public sealed class LogicalCallContext : Object
	{
		// Token: 0x06003EF1 RID: 16113 RVA: 0x0012552C File Offset: 0x0012372C
		// Note: this type is marked as 'beforefieldinit'.
		static LogicalCallContext()
		{
			Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "LogicalCallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr);
			LogicalCallContext.NativeFieldInfoPtr_s_callContextType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "s_callContextType");
			LogicalCallContext.NativeFieldInfoPtr_m_Datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_Datastore");
			LogicalCallContext.NativeFieldInfoPtr_m_RemotingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_RemotingData");
			LogicalCallContext.NativeFieldInfoPtr_m_SecurityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_SecurityData");
			LogicalCallContext.NativeFieldInfoPtr_m_HostContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_HostContext");
			LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_IsCorrelationMgr");
			LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672520);
			LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672521);
			LogicalCallContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672522);
			LogicalCallContext.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672523);
			LogicalCallContext.NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672524);
			LogicalCallContext.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672525);
			LogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672526);
			LogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100672527);
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00125674 File Offset: 0x00123874
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x001256B0 File Offset: 0x001238B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354059, XrefRangeEnd = 354099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x00125714 File Offset: 0x00123914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354099, XrefRangeEnd = 354131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00125770 File Offset: 0x00123970
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354187, RefRangeEnd = 354190, XrefRangeStart = 354131, XrefRangeEnd = 354187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x001257B0 File Offset: 0x001239B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354209, RefRangeEnd = 354211, XrefRangeStart = 354190, XrefRangeEnd = 354209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(LogicalCallContext lc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x001257F4 File Offset: 0x001239F4
		public unsafe bool HasInfo
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 354213, RefRangeEnd = 354219, XrefRangeStart = 354211, XrefRangeEnd = 354213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x00125830 File Offset: 0x00123A30
		public unsafe bool HasUserData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 354030, RefRangeEnd = 354032, XrefRangeStart = 354030, XrefRangeEnd = 354032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06003EF9 RID: 16121 RVA: 0x0012586C File Offset: 0x00123A6C
		public unsafe Hashtable Datastore
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 354223, RefRangeEnd = 354227, XrefRangeStart = 354219, XrefRangeEnd = 354223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x00017C69 File Offset: 0x00015E69
		public LogicalCallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06003EFB RID: 16123 RVA: 0x001258AC File Offset: 0x00123AAC
		// (set) Token: 0x06003EFC RID: 16124 RVA: 0x00017C72 File Offset: 0x00015E72
		public unsafe static Type s_callContextType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LogicalCallContext.NativeFieldInfoPtr_s_callContextType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogicalCallContext.NativeFieldInfoPtr_s_callContextType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x001258D4 File Offset: 0x00123AD4
		// (set) Token: 0x06003EFE RID: 16126 RVA: 0x00017C84 File Offset: 0x00015E84
		public unsafe Hashtable m_Datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_Datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_Datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x00125904 File Offset: 0x00123B04
		// (set) Token: 0x06003F00 RID: 16128 RVA: 0x00017CA3 File Offset: 0x00015EA3
		public unsafe CallContextRemotingData m_RemotingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_RemotingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallContextRemotingData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_RemotingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06003F01 RID: 16129 RVA: 0x00125934 File Offset: 0x00123B34
		// (set) Token: 0x06003F02 RID: 16130 RVA: 0x00017CC2 File Offset: 0x00015EC2
		public unsafe CallContextSecurityData m_SecurityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_SecurityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallContextSecurityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_SecurityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x00125964 File Offset: 0x00123B64
		// (set) Token: 0x06003F04 RID: 16132 RVA: 0x00017CE1 File Offset: 0x00015EE1
		public unsafe Object m_HostContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_HostContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_HostContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x00125994 File Offset: 0x00123B94
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x00017D00 File Offset: 0x00015F00
		public unsafe bool m_IsCorrelationMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr)) = value;
			}
		}

		// Token: 0x040033C2 RID: 13250
		private static readonly IntPtr NativeFieldInfoPtr_s_callContextType;

		// Token: 0x040033C3 RID: 13251
		private static readonly IntPtr NativeFieldInfoPtr_m_Datastore;

		// Token: 0x040033C4 RID: 13252
		private static readonly IntPtr NativeFieldInfoPtr_m_RemotingData;

		// Token: 0x040033C5 RID: 13253
		private static readonly IntPtr NativeFieldInfoPtr_m_SecurityData;

		// Token: 0x040033C6 RID: 13254
		private static readonly IntPtr NativeFieldInfoPtr_m_HostContext;

		// Token: 0x040033C7 RID: 13255
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCorrelationMgr;

		// Token: 0x040033C8 RID: 13256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040033C9 RID: 13257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040033CA RID: 13258
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040033CB RID: 13259
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040033CC RID: 13260
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0;

		// Token: 0x040033CD RID: 13261
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0;

		// Token: 0x040033CE RID: 13262
		private static readonly IntPtr NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0;

		// Token: 0x040033CF RID: 13263
		private static readonly IntPtr NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0;

		// Token: 0x0200062F RID: 1583
		public sealed class Reader : ValueType
		{
			// Token: 0x0600545B RID: 21595 RVA: 0x00175528 File Offset: 0x00173728
			// Note: this type is marked as 'beforefieldinit'.
			static Reader()
			{
				Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "Reader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr);
				LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, "m_ctx");
				LogicalCallContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672529);
				LogicalCallContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672530);
				LogicalCallContext.Reader.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672531);
				LogicalCallContext.Reader.NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100672532);
			}

			// Token: 0x0600545C RID: 21596 RVA: 0x001755B8 File Offset: 0x001737B8
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(LogicalCallContext ctx)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700159B RID: 5531
			// (get) Token: 0x0600545D RID: 21597 RVA: 0x00175608 File Offset: 0x00173808
			public unsafe bool IsNull
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 305860, RefRangeEnd = 305866, XrefRangeStart = 305860, XrefRangeEnd = 305866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700159C RID: 5532
			// (get) Token: 0x0600545E RID: 21598 RVA: 0x0017564C File Offset: 0x0017384C
			public unsafe bool HasInfo
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600545F RID: 21599 RVA: 0x00175690 File Offset: 0x00173890
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 354058, RefRangeEnd = 354059, XrefRangeStart = 354055, XrefRangeEnd = 354058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogicalCallContext Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}

			// Token: 0x06005460 RID: 21600 RVA: 0x000208DD File Offset: 0x0001EADD
			public Reader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005461 RID: 21601 RVA: 0x000208E6 File Offset: 0x0001EAE6
			public Reader()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr))
			{
			}

			// Token: 0x1700159A RID: 5530
			// (get) Token: 0x06005462 RID: 21602 RVA: 0x001756D4 File Offset: 0x001738D4
			// (set) Token: 0x06005463 RID: 21603 RVA: 0x000208F8 File Offset: 0x0001EAF8
			public unsafe LogicalCallContext m_ctx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043EB RID: 17387
			private static readonly IntPtr NativeFieldInfoPtr_m_ctx;

			// Token: 0x040043EC RID: 17388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0;

			// Token: 0x040043ED RID: 17389
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

			// Token: 0x040043EE RID: 17390
			private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0;

			// Token: 0x040043EF RID: 17391
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0;
		}
	}
}
