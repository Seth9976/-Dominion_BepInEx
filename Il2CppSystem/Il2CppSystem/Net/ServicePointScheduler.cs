using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000115 RID: 277
	public class ServicePointScheduler : Object
	{
		// Token: 0x060011BB RID: 4539 RVA: 0x0005280C File Offset: 0x00050A0C
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointScheduler()
		{
			Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePointScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr);
			ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "<ServicePoint>k__BackingField");
			ServicePointScheduler.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "running");
			ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "maxIdleTime");
			ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "schedulerEvent");
			ServicePointScheduler.NativeFieldInfoPtr_defaultGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "defaultGroup");
			ServicePointScheduler.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "groups");
			ServicePointScheduler.NativeFieldInfoPtr_operations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "operations");
			ServicePointScheduler.NativeFieldInfoPtr_idleConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "idleConnections");
			ServicePointScheduler.NativeFieldInfoPtr_currentConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "currentConnections");
			ServicePointScheduler.NativeFieldInfoPtr_connectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "connectionLimit");
			ServicePointScheduler.NativeFieldInfoPtr_idleSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "idleSince");
			ServicePointScheduler.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "nextId");
			ServicePointScheduler.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "ID");
			ServicePointScheduler.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665729);
			ServicePointScheduler.NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665730);
			ServicePointScheduler.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665731);
			ServicePointScheduler.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665732);
			ServicePointScheduler.NativeMethodInfoPtr_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665733);
			ServicePointScheduler.NativeMethodInfoPtr_StartScheduler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665734);
			ServicePointScheduler.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665735);
			ServicePointScheduler.NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665736);
			ServicePointScheduler.NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_Task_1_ValueTuple_2_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665737);
			ServicePointScheduler.NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665738);
			ServicePointScheduler.NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665739);
			ServicePointScheduler.NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665740);
			ServicePointScheduler.NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665741);
			ServicePointScheduler.NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665742);
			ServicePointScheduler.NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665743);
			ServicePointScheduler.NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665744);
			ServicePointScheduler.NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665745);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00052A94 File Offset: 0x00050C94
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00052AD4 File Offset: 0x00050CD4
		public unsafe int MaxIdleTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00052B10 File Offset: 0x00050D10
		public unsafe int ConnectionLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00052B4C File Offset: 0x00050D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53389, XrefRangeEnd = 53418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionLimit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIdleTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00052BB4 File Offset: 0x00050DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53427, RefRangeEnd = 53428, XrefRangeStart = 53418, XrefRangeEnd = 53427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00052BE8 File Offset: 0x00050DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53428, XrefRangeEnd = 53432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartScheduler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_StartScheduler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00052C1C File Offset: 0x00050E1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53457, RefRangeEnd = 53458, XrefRangeStart = 53432, XrefRangeEnd = 53457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00052C50 File Offset: 0x00050E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53458, XrefRangeEnd = 53474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunSchedulerIteration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00052C84 File Offset: 0x00050E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53474, XrefRangeEnd = 53496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation, Task<ValueTuple<bool, WebOperation>> task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_Task_1_ValueTuple_2_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00052CF8 File Offset: 0x00050EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53496, XrefRangeEnd = 53499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00052D4C File Offset: 0x00050F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53509, RefRangeEnd = 53511, XrefRangeStart = 53499, XrefRangeEnd = 53509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00052D9C File Offset: 0x00050F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53519, RefRangeEnd = 53520, XrefRangeStart = 53511, XrefRangeEnd = 53519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOperation(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00052DE0 File Offset: 0x00050FE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 53528, RefRangeEnd = 53531, XrefRangeStart = 53520, XrefRangeEnd = 53528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveIdleConnection(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00052E24 File Offset: 0x00051024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53537, RefRangeEnd = 53538, XrefRangeStart = 53531, XrefRangeEnd = 53537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequest(WebOperation operation, string groupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00052E78 File Offset: 0x00051078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53560, RefRangeEnd = 53561, XrefRangeStart = 53538, XrefRangeEnd = 53560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.ConnectionGroup>(intPtr3) : null;
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00052EC8 File Offset: 0x000510C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53561, XrefRangeEnd = 53562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConnectionCreated(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00052F0C File Offset: 0x0005110C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53564, RefRangeEnd = 53566, XrefRangeStart = 53562, XrefRangeEnd = 53564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConnectionClosed(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0000933E File Offset: 0x0000753E
		public ServicePointScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00052F50 File Offset: 0x00051150
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x00009347 File Offset: 0x00007547
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00052F80 File Offset: 0x00051180
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00009366 File Offset: 0x00007566
		public unsafe int running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00052FA8 File Offset: 0x000511A8
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x00009381 File Offset: 0x00007581
		public unsafe int maxIdleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00052FD0 File Offset: 0x000511D0
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0000939C File Offset: 0x0000759C
		public unsafe ServicePointScheduler.AsyncManualResetEvent schedulerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00053000 File Offset: 0x00051200
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x000093BB File Offset: 0x000075BB
		public unsafe ServicePointScheduler.ConnectionGroup defaultGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_defaultGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.ConnectionGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_defaultGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00053030 File Offset: 0x00051230
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x000093DA File Offset: 0x000075DA
		public unsafe Dictionary<string, ServicePointScheduler.ConnectionGroup> groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ServicePointScheduler.ConnectionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00053060 File Offset: 0x00051260
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x000093F9 File Offset: 0x000075F9
		public unsafe LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_operations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_operations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00053090 File Offset: 0x00051290
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x00009418 File Offset: 0x00007618
		public unsafe LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x000530C0 File Offset: 0x000512C0
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x00009437 File Offset: 0x00007637
		public unsafe int currentConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_currentConnections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_currentConnections)) = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x000530E8 File Offset: 0x000512E8
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00009452 File Offset: 0x00007652
		public unsafe int connectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_connectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_connectionLimit)) = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00053110 File Offset: 0x00051310
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0000946D File Offset: 0x0000766D
		public unsafe DateTime idleSince
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleSince);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleSince)) = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00053138 File Offset: 0x00051338
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x00009488 File Offset: 0x00007688
		public unsafe static int nextId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.NativeFieldInfoPtr_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.NativeFieldInfoPtr_nextId, (void*)(&value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00053154 File Offset: 0x00051354
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x00009496 File Offset: 0x00007696
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeFieldInfoPtr_maxIdleTime;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeFieldInfoPtr_schedulerEvent;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeFieldInfoPtr_defaultGroup;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr_operations;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_idleConnections;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr_currentConnections;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr_connectionLimit;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr_idleSince;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_nextId;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_StartScheduler_Private_Void_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_Task_1_ValueTuple_2_Boolean_WebOperation_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0;

		// Token: 0x020001CD RID: 461
		public class ConnectionGroup : Object
		{
			// Token: 0x06001999 RID: 6553 RVA: 0x0006C4C0 File Offset: 0x0006A6C0
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionGroup()
			{
				Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "ConnectionGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr);
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "<Scheduler>k__BackingField");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "<Name>k__BackingField");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "nextId");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "ID");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "connections");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "queue");
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665746);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665747);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665748);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665749);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665750);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665751);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665752);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665753);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665754);
			}

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x0600199A RID: 6554 RVA: 0x0006C618 File Offset: 0x0006A818
			public unsafe ServicePointScheduler Scheduler
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr3) : null;
				}
			}

			// Token: 0x0600199B RID: 6555 RVA: 0x0006C658 File Offset: 0x0006A858
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 53106, RefRangeEnd = 53109, XrefRangeStart = 53091, XrefRangeEnd = 53106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionGroup(ServicePointScheduler scheduler, string name)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600199C RID: 6556 RVA: 0x0006C6B8 File Offset: 0x0006A8B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53111, RefRangeEnd = 53112, XrefRangeStart = 53109, XrefRangeEnd = 53111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEmpty()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600199D RID: 6557 RVA: 0x0006C6F4 File Offset: 0x0006A8F4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 53118, RefRangeEnd = 53120, XrefRangeStart = 53112, XrefRangeEnd = 53118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveConnection(WebConnection connection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600199E RID: 6558 RVA: 0x0006C738 File Offset: 0x0006A938
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 53130, RefRangeEnd = 53132, XrefRangeStart = 53120, XrefRangeEnd = 53130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Cleanup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600199F RID: 6559 RVA: 0x0006C76C File Offset: 0x0006A96C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53136, RefRangeEnd = 53137, XrefRangeStart = 53132, XrefRangeEnd = 53136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EnqueueOperation(WebOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019A0 RID: 6560 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53147, RefRangeEnd = 53148, XrefRangeStart = 53137, XrefRangeEnd = 53147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebOperation GetNextOperation()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr3) : null;
			}

			// Token: 0x060019A1 RID: 6561 RVA: 0x0006C7F0 File Offset: 0x0006A9F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53171, RefRangeEnd = 53172, XrefRangeStart = 53148, XrefRangeEnd = 53171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebConnection FindIdleConnection(WebOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr3) : null;
				}
			}

			// Token: 0x060019A2 RID: 6562 RVA: 0x0006C840 File Offset: 0x0006AA40
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 53181, RefRangeEnd = 53183, XrefRangeStart = 53172, XrefRangeEnd = 53181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<WebConnection, bool>(intPtr);
			}

			// Token: 0x060019A3 RID: 6563 RVA: 0x0000D96F File Offset: 0x0000BB6F
			public ConnectionGroup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0006C898 File Offset: 0x0006AA98
			// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0000D978 File Offset: 0x0000BB78
			public unsafe ServicePointScheduler _Scheduler_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0006C8C8 File Offset: 0x0006AAC8
			// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0000D997 File Offset: 0x0000BB97
			public unsafe string _Name_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0006C8F0 File Offset: 0x0006AAF0
			// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0000D9B6 File Offset: 0x0000BBB6
			public unsafe static int nextId
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId, (void*)(&value));
				}
			}

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x060019AA RID: 6570 RVA: 0x0006C90C File Offset: 0x0006AB0C
			// (set) Token: 0x060019AB RID: 6571 RVA: 0x0000D9C4 File Offset: 0x0000BBC4
			public unsafe int ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID)) = value;
				}
			}

			// Token: 0x17000833 RID: 2099
			// (get) Token: 0x060019AC RID: 6572 RVA: 0x0006C934 File Offset: 0x0006AB34
			// (set) Token: 0x060019AD RID: 6573 RVA: 0x0000D9DF File Offset: 0x0000BBDF
			public unsafe LinkedList<WebConnection> connections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WebConnection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x060019AE RID: 6574 RVA: 0x0006C964 File Offset: 0x0006AB64
			// (set) Token: 0x060019AF RID: 6575 RVA: 0x0000D9FE File Offset: 0x0000BBFE
			public unsafe LinkedList<WebOperation> queue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WebOperation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400140D RID: 5133
			private static readonly IntPtr NativeFieldInfoPtr__Scheduler_k__BackingField;

			// Token: 0x0400140E RID: 5134
			private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

			// Token: 0x0400140F RID: 5135
			private static readonly IntPtr NativeFieldInfoPtr_nextId;

			// Token: 0x04001410 RID: 5136
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x04001411 RID: 5137
			private static readonly IntPtr NativeFieldInfoPtr_connections;

			// Token: 0x04001412 RID: 5138
			private static readonly IntPtr NativeFieldInfoPtr_queue;

			// Token: 0x04001413 RID: 5139
			private static readonly IntPtr NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0;

			// Token: 0x04001414 RID: 5140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0;

			// Token: 0x04001415 RID: 5141
			private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

			// Token: 0x04001416 RID: 5142
			private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0;

			// Token: 0x04001417 RID: 5143
			private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

			// Token: 0x04001418 RID: 5144
			private static readonly IntPtr NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0;

			// Token: 0x04001419 RID: 5145
			private static readonly IntPtr NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0;

			// Token: 0x0400141A RID: 5146
			private static readonly IntPtr NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0;

			// Token: 0x0400141B RID: 5147
			private static readonly IntPtr NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0;
		}

		// Token: 0x020001CE RID: 462
		public class AsyncManualResetEvent : Object
		{
			// Token: 0x060019B0 RID: 6576 RVA: 0x0006C994 File Offset: 0x0006AB94
			// Note: this type is marked as 'beforefieldinit'.
			static AsyncManualResetEvent()
			{
				Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "AsyncManualResetEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr);
				ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "m_tcs");
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665755);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665756);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665757);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665758);
			}

			// Token: 0x060019B1 RID: 6577 RVA: 0x0006CA24 File Offset: 0x0006AC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53225, XrefRangeEnd = 53237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<bool> WaitAsync(int millisecondTimeout)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref millisecondTimeout;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x060019B2 RID: 6578 RVA: 0x0006CA70 File Offset: 0x0006AC70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 53279, RefRangeEnd = 53281, XrefRangeStart = 53237, XrefRangeEnd = 53279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019B3 RID: 6579 RVA: 0x0006CAA4 File Offset: 0x0006ACA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53292, RefRangeEnd = 53293, XrefRangeStart = 53281, XrefRangeEnd = 53292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019B4 RID: 6580 RVA: 0x0006CAD8 File Offset: 0x0006ACD8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 53302, RefRangeEnd = 53304, XrefRangeStart = 53293, XrefRangeEnd = 53302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncManualResetEvent(bool state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B5 RID: 6581 RVA: 0x0000DA1D File Offset: 0x0000BC1D
			public AsyncManualResetEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0006CB20 File Offset: 0x0006AD20
			// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0000DA26 File Offset: 0x0000BC26
			public unsafe TaskCompletionSource<bool> m_tcs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400141C RID: 5148
			private static readonly IntPtr NativeFieldInfoPtr_m_tcs;

			// Token: 0x0400141D RID: 5149
			private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0;

			// Token: 0x0400141E RID: 5150
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

			// Token: 0x0400141F RID: 5151
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x04001420 RID: 5152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

			// Token: 0x02000220 RID: 544
			[ObfuscatedName("System.Net.ServicePointScheduler+AsyncManualResetEvent+<WaitAsync>d__3")]
			public sealed class _WaitAsync_d__3 : ValueType
			{
				// Token: 0x06001CDF RID: 7391 RVA: 0x000745B4 File Offset: 0x000727B4
				// Note: this type is marked as 'beforefieldinit'.
				static _WaitAsync_d__3()
				{
					Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "<WaitAsync>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr);
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>1__state");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>t__builder");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr_millisecondTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "millisecondTimeout");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>4__this");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr__timeoutTask_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<timeoutTask>5__1");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>u__1");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, 100665759);
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, 100665760);
				}

				// Token: 0x06001CE0 RID: 7392 RVA: 0x00074680 File Offset: 0x00072880
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53183, XrefRangeEnd = 53210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CE1 RID: 7393 RVA: 0x000746B8 File Offset: 0x000728B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53210, XrefRangeEnd = 53213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001CE2 RID: 7394 RVA: 0x000106BD File Offset: 0x0000E8BD
				public _WaitAsync_d__3(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001CE3 RID: 7395 RVA: 0x000106C6 File Offset: 0x0000E8C6
				public _WaitAsync_d__3()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr))
				{
				}

				// Token: 0x17000924 RID: 2340
				// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00074700 File Offset: 0x00072900
				// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x000106D8 File Offset: 0x0000E8D8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000925 RID: 2341
				// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00074728 File Offset: 0x00072928
				// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x000106F3 File Offset: 0x0000E8F3
				public AsyncTaskMethodBuilder<bool> __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000926 RID: 2342
				// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00074758 File Offset: 0x00072958
				// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x00010721 File Offset: 0x0000E921
				public unsafe int millisecondTimeout
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr_millisecondTimeout);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr_millisecondTimeout)) = value;
					}
				}

				// Token: 0x17000927 RID: 2343
				// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00074780 File Offset: 0x00072980
				// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0001073C File Offset: 0x0000E93C
				public unsafe ServicePointScheduler.AsyncManualResetEvent __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000928 RID: 2344
				// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000747B0 File Offset: 0x000729B0
				// (set) Token: 0x06001CED RID: 7405 RVA: 0x0001075B File Offset: 0x0000E95B
				public unsafe Task _timeoutTask_5__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr__timeoutTask_5__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr__timeoutTask_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000929 RID: 2345
				// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000747E0 File Offset: 0x000729E0
				// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0001077A File Offset: 0x0000E97A
				public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x040015B9 RID: 5561
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040015BA RID: 5562
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x040015BB RID: 5563
				private static readonly IntPtr NativeFieldInfoPtr_millisecondTimeout;

				// Token: 0x040015BC RID: 5564
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040015BD RID: 5565
				private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__1;

				// Token: 0x040015BE RID: 5566
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x040015BF RID: 5567
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x040015C0 RID: 5568
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x02000221 RID: 545
			[ObfuscatedName("System.Net.ServicePointScheduler+AsyncManualResetEvent+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001CF0 RID: 7408 RVA: 0x00074810 File Offset: 0x00072A10
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr);
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, "<>9");
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, "<>9__4_0");
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, 100665762);
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, 100665763);
				}

				// Token: 0x06001CF1 RID: 7409 RVA: 0x0007488C File Offset: 0x00072A8C
				[CallerCount(817)]
				[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CF2 RID: 7410 RVA: 0x000748C8 File Offset: 0x00072AC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53213, XrefRangeEnd = 53225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Set_b__4_0(Object s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001CF3 RID: 7411 RVA: 0x000107A8 File Offset: 0x0000E9A8
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700092A RID: 2346
				// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00074918 File Offset: 0x00072B18
				// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x000107B1 File Offset: 0x0000E9B1
				public unsafe static ServicePointScheduler.AsyncManualResetEvent.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700092B RID: 2347
				// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00074940 File Offset: 0x00072B40
				// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x000107C3 File Offset: 0x0000E9C3
				public unsafe static Func<Object, bool> __9__4_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040015C1 RID: 5569
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040015C2 RID: 5570
				private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

				// Token: 0x040015C3 RID: 5571
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040015C4 RID: 5572
				private static readonly IntPtr NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0;
			}
		}

		// Token: 0x020001CF RID: 463
		[ObfuscatedName("System.Net.ServicePointScheduler+<StartScheduler>d__32")]
		public sealed class _StartScheduler_d__32 : ValueType
		{
			// Token: 0x060019B8 RID: 6584 RVA: 0x0006CB50 File Offset: 0x0006AD50
			// Note: this type is marked as 'beforefieldinit'.
			static _StartScheduler_d__32()
			{
				Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "<StartScheduler>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr);
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>1__state");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>t__builder");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>4__this");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__taskList_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<taskList>5__1");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<operationArray>5__2");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<idleArray>5__3");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>u__1");
				ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, 100665764);
				ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, 100665765);
			}

			// Token: 0x060019B9 RID: 6585 RVA: 0x0006CC30 File Offset: 0x0006AE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53304, XrefRangeEnd = 53388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019BA RID: 6586 RVA: 0x0006CC68 File Offset: 0x0006AE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53388, XrefRangeEnd = 53389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019BB RID: 6587 RVA: 0x0000DA45 File Offset: 0x0000BC45
			public _StartScheduler_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019BC RID: 6588 RVA: 0x0000DA4E File Offset: 0x0000BC4E
			public _StartScheduler_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x060019BD RID: 6589 RVA: 0x0006CCB0 File Offset: 0x0006AEB0
			// (set) Token: 0x060019BE RID: 6590 RVA: 0x0000DA60 File Offset: 0x0000BC60
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x060019BF RID: 6591 RVA: 0x0006CCD8 File Offset: 0x0006AED8
			// (set) Token: 0x060019C0 RID: 6592 RVA: 0x0000DA7B File Offset: 0x0000BC7B
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0006CD08 File Offset: 0x0006AF08
			// (set) Token: 0x060019C2 RID: 6594 RVA: 0x0000DAA9 File Offset: 0x0000BCA9
			public unsafe ServicePointScheduler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0006CD38 File Offset: 0x0006AF38
			// (set) Token: 0x060019C4 RID: 6596 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
			public unsafe List<Task> _taskList_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__taskList_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__taskList_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0006CD68 File Offset: 0x0006AF68
			// (set) Token: 0x060019C6 RID: 6598 RVA: 0x0000DAE7 File Offset: 0x0000BCE7
			public unsafe Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> _operationArray_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0006CD98 File Offset: 0x0006AF98
			// (set) Token: 0x060019C8 RID: 6600 RVA: 0x0000DB06 File Offset: 0x0000BD06
			public unsafe Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> _idleArray_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083D RID: 2109
			// (get) Token: 0x060019C9 RID: 6601 RVA: 0x0006CDC8 File Offset: 0x0006AFC8
			// (set) Token: 0x060019CA RID: 6602 RVA: 0x0000DB25 File Offset: 0x0000BD25
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001421 RID: 5153
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001422 RID: 5154
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001423 RID: 5155
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001424 RID: 5156
			private static readonly IntPtr NativeFieldInfoPtr__taskList_5__1;

			// Token: 0x04001425 RID: 5157
			private static readonly IntPtr NativeFieldInfoPtr__operationArray_5__2;

			// Token: 0x04001426 RID: 5158
			private static readonly IntPtr NativeFieldInfoPtr__idleArray_5__3;

			// Token: 0x04001427 RID: 5159
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001428 RID: 5160
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001429 RID: 5161
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
