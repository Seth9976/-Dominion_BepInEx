using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.ConstrainedExecution;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000279 RID: 633
	public sealed class Thread : CriticalFinalizerObject
	{
		// Token: 0x06002B4E RID: 11086 RVA: 0x000DE83C File Offset: 0x000DCA3C
		// Note: this type is marked as 'beforefieldinit'.
		static Thread()
		{
			Il2CppClassPointerStore<Thread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Thread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thread>.NativeClassPtr);
			Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStoreMgr");
			Thread.NativeFieldInfoPtr_s_LocalDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStore");
			Thread.NativeFieldInfoPtr_m_CurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentCulture");
			Thread.NativeFieldInfoPtr_m_CurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentUICulture");
			Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentCulture");
			Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentUICulture");
			Thread.NativeFieldInfoPtr_internal_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "internal_thread");
			Thread.NativeFieldInfoPtr_m_ThreadStartArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ThreadStartArg");
			Thread.NativeFieldInfoPtr_pending_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "pending_exception");
			Thread.NativeFieldInfoPtr_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal");
			Thread.NativeFieldInfoPtr_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal_version");
			Thread.NativeFieldInfoPtr_current_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "current_thread");
			Thread.NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_Delegate");
			Thread.NativeFieldInfoPtr_m_ExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContext");
			Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContextBelongsToOuterScope");
			Thread.NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670189);
			Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670190);
			Thread.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670191);
			Thread.NativeMethodInfoPtr_Start_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670192);
			Thread.NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670193);
			Thread.NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670194);
			Thread.NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670195);
			Thread.NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670196);
			Thread.NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670197);
			Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670198);
			Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670199);
			Thread.NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670200);
			Thread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670201);
			Thread.NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670202);
			Thread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670203);
			Thread.NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670204);
			Thread.NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670205);
			Thread.NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670206);
			Thread.NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670207);
			Thread.NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670208);
			Thread.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670209);
			Thread.NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670210);
			Thread.NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670211);
			Thread.NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670212);
			Thread.NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670213);
			Thread.NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670214);
			Thread.NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670215);
			Thread.NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670216);
			Thread.NativeMethodInfoPtr_Thread_internal_Private_IntPtr_MulticastDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670217);
			Thread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670218);
			Thread.NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670219);
			Thread.NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670220);
			Thread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670221);
			Thread.NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670222);
			Thread.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670223);
			Thread.NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670224);
			Thread.NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670225);
			Thread.NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670226);
			Thread.NativeMethodInfoPtr_StartInternal_Private_Void_IPrincipal_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670227);
			Thread.NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670228);
			Thread.NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670229);
			Thread.NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670230);
			Thread.NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670231);
			Thread.NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670232);
			Thread.NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670233);
			Thread.NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670234);
			Thread.NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670235);
			Thread.NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670236);
			Thread.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670237);
			Thread.NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670238);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000DED80 File Offset: 0x000DCF80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 332525, RefRangeEnd = 332529, XrefRangeStart = 332517, XrefRangeEnd = 332525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thread(ThreadStart start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000DEDCC File Offset: 0x000DCFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332529, XrefRangeEnd = 332537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thread(ParameterizedThreadStart start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000DEE18 File Offset: 0x000DD018
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 332538, RefRangeEnd = 332542, XrefRangeStart = 332537, XrefRangeEnd = 332538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000DEE4C File Offset: 0x000DD04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332545, RefRangeEnd = 332546, XrefRangeStart = 332542, XrefRangeEnd = 332545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x000DEE90 File Offset: 0x000DD090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 332555, RefRangeEnd = 332557, XrefRangeStart = 332546, XrefRangeEnd = 332555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000DEED0 File Offset: 0x000DD0D0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext.Reader GetExecutionContextReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ExecutionContext.Reader(intPtr);
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000DEF08 File Offset: 0x000DD108
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x000DEF44 File Offset: 0x000DD144
		public unsafe bool ExecutionContextBelongsToCurrentScope
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 332557, RefRangeEnd = 332561, XrefRangeStart = 332557, XrefRangeEnd = 332557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 332561, RefRangeEnd = 332564, XrefRangeStart = 332561, XrefRangeEnd = 332561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000DEF84 File Offset: 0x000DD184
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 332566, RefRangeEnd = 332573, XrefRangeStart = 332564, XrefRangeEnd = 332566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext GetMutableExecutionContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000DEFC4 File Offset: 0x000DD1C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 332573, RefRangeEnd = 332576, XrefRangeStart = 332573, XrefRangeEnd = 332573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref belongsToCurrentScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000DF014 File Offset: 0x000DD214
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 332573, RefRangeEnd = 332576, XrefRangeStart = 332573, XrefRangeEnd = 332576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref belongsToCurrentScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000DF06C File Offset: 0x000DD26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332576, XrefRangeEnd = 332577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SleepInternal(int millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x000DF0A0 File Offset: 0x000DD2A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 332586, RefRangeEnd = 332593, XrefRangeStart = 332577, XrefRangeEnd = 332586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sleep(int millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000DF0D4 File Offset: 0x000DD2D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 332594, RefRangeEnd = 332600, XrefRangeStart = 332593, XrefRangeEnd = 332594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool YieldInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000DF104 File Offset: 0x000DD304
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 332594, RefRangeEnd = 332600, XrefRangeStart = 332594, XrefRangeEnd = 332600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Yield()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000DF134 File Offset: 0x000DD334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 332619, RefRangeEnd = 332622, XrefRangeStart = 332600, XrefRangeEnd = 332619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStartHelper(Delegate start, int maxStackSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000DF184 File Offset: 0x000DD384
		public unsafe CultureInfo CurrentUICulture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 332628, RefRangeEnd = 332630, XrefRangeStart = 332622, XrefRangeEnd = 332628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000DF1C4 File Offset: 0x000DD3C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 332628, RefRangeEnd = 332630, XrefRangeStart = 332628, XrefRangeEnd = 332630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo GetCurrentUICultureNoAppX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000DF204 File Offset: 0x000DD404
		public unsafe CultureInfo CurrentCulture
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 332636, RefRangeEnd = 332645, XrefRangeStart = 332630, XrefRangeEnd = 332636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000DF244 File Offset: 0x000DD444
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 332636, RefRangeEnd = 332645, XrefRangeStart = 332636, XrefRangeEnd = 332645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo GetCurrentCultureNoAppX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000DF284 File Offset: 0x000DD484
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 332646, RefRangeEnd = 332650, XrefRangeStart = 332645, XrefRangeEnd = 332646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemoryBarrier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000DF2AC File Offset: 0x000DD4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332650, XrefRangeEnd = 332651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstructInternalThread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x000DF2E0 File Offset: 0x000DD4E0
		public unsafe InternalThread Internal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332651, XrefRangeEnd = 332652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InternalThread>(intPtr3) : null;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x000DF320 File Offset: 0x000DD520
		public unsafe static Context CurrentContext
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 332653, RefRangeEnd = 332674, XrefRangeStart = 332652, XrefRangeEnd = 332653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000DF354 File Offset: 0x000DD554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332674, XrefRangeEnd = 332675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Thread GetCurrentThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr3) : null;
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x000DF388 File Offset: 0x000DD588
		public unsafe static Thread CurrentThread
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 332679, RefRangeEnd = 332726, XrefRangeStart = 332675, XrefRangeEnd = 332679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr3) : null;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000DF3BC File Offset: 0x000DD5BC
		public unsafe static int CurrentThreadId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332730, RefRangeEnd = 332731, XrefRangeStart = 332726, XrefRangeEnd = 332730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000DF3EC File Offset: 0x000DD5EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 332732, RefRangeEnd = 332740, XrefRangeStart = 332731, XrefRangeEnd = 332732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDomainID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000DF41C File Offset: 0x000DD61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332740, XrefRangeEnd = 332741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Thread_internal(MulticastDelegate start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Thread_internal_Private_IntPtr_MulticastDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x000DF46C File Offset: 0x000DD66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332741, XrefRangeEnd = 332744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x000DF4A0 File Offset: 0x000DD6A0
		public unsafe bool IsThreadPoolThread
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332745, RefRangeEnd = 332746, XrefRangeStart = 332744, XrefRangeEnd = 332745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000DF4DC File Offset: 0x000DD6DC
		public unsafe bool IsThreadPoolThreadInternal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332745, RefRangeEnd = 332746, XrefRangeStart = 332745, XrefRangeEnd = 332746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x000DF518 File Offset: 0x000DD718
		public unsafe bool IsBackground
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 332758, RefRangeEnd = 332762, XrefRangeStart = 332746, XrefRangeEnd = 332758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000DF558 File Offset: 0x000DD758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332762, XrefRangeEnd = 332763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName_internal(InternalThread thread, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A56 RID: 2646
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x000DF5A0 File Offset: 0x000DD7A0
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332765, RefRangeEnd = 332766, XrefRangeStart = 332763, XrefRangeEnd = 332765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000DF5E4 File Offset: 0x000DD7E4
		public unsafe ThreadState ThreadState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332768, RefRangeEnd = 332769, XrefRangeStart = 332766, XrefRangeEnd = 332768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x000DF620 File Offset: 0x000DD820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283600, RefRangeEnd = 283603, XrefRangeStart = 283600, XrefRangeEnd = 283603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpinWait_nop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000DF648 File Offset: 0x000DD848
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 332770, RefRangeEnd = 332779, XrefRangeStart = 332769, XrefRangeEnd = 332770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpinWait(int iterations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iterations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000DF67C File Offset: 0x000DD87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332779, XrefRangeEnd = 332782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(principal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_StartInternal_Private_Void_IPrincipal_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000DF6CC File Offset: 0x000DD8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332782, XrefRangeEnd = 332783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetState(InternalThread thread, ThreadState set)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref set;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000DF710 File Offset: 0x000DD910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332783, XrefRangeEnd = 332784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClrState(InternalThread thread, ThreadState clr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000DF754 File Offset: 0x000DD954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332784, XrefRangeEnd = 332785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ThreadState GetState(InternalThread thread)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000DF798 File Offset: 0x000DD998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332785, XrefRangeEnd = 332786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SystemMaxStackStize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000DF7C8 File Offset: 0x000DD9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332786, XrefRangeEnd = 332792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessDefaultStackSize(int maxStackSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxStackSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000DF808 File Offset: 0x000DDA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332792, XrefRangeEnd = 332793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStart(MulticastDelegate start, int maxStackSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x000DF858 File Offset: 0x000DDA58
		public unsafe int ManagedThreadId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 332794, RefRangeEnd = 332808, XrefRangeStart = 332793, XrefRangeEnd = 332794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000DF894 File Offset: 0x000DDA94
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 332815, RefRangeEnd = 332826, XrefRangeStart = 332808, XrefRangeEnd = 332815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCriticalRegion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x000DF8BC File Offset: 0x000DDABC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 332833, RefRangeEnd = 332842, XrefRangeStart = 332826, XrefRangeEnd = 332833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndCriticalRegion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000DF8E4 File Offset: 0x000DDAE4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 332794, RefRangeEnd = 332808, XrefRangeStart = 332794, XrefRangeEnd = 332808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000DF920 File Offset: 0x000DDB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332842, XrefRangeEnd = 332844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadState ValidateThreadState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0000F15C File Offset: 0x0000D35C
		public Thread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000DF95C File Offset: 0x000DDB5C
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x0000F165 File Offset: 0x0000D365
		public unsafe static LocalDataStoreMgr s_LocalDataStoreMgr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000DF984 File Offset: 0x000DDB84
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x0000F177 File Offset: 0x0000D377
		public unsafe static LocalDataStoreHolder s_LocalDataStore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_LocalDataStore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_LocalDataStore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000DF9AC File Offset: 0x000DDBAC
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x0000F189 File Offset: 0x0000D389
		public unsafe static CultureInfo m_CurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_m_CurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_m_CurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000DF9D4 File Offset: 0x000DDBD4
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x0000F19B File Offset: 0x0000D39B
		public unsafe static CultureInfo m_CurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_m_CurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_m_CurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000DF9FC File Offset: 0x000DDBFC
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x0000F1AD File Offset: 0x0000D3AD
		public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000DFA24 File Offset: 0x000DDC24
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x0000F1BF File Offset: 0x0000D3BF
		public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000DFA4C File Offset: 0x000DDC4C
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x0000F1D1 File Offset: 0x0000D3D1
		public unsafe InternalThread internal_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_internal_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalThread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_internal_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000DFA7C File Offset: 0x000DDC7C
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x0000F1F0 File Offset: 0x0000D3F0
		public unsafe Object m_ThreadStartArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ThreadStartArg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ThreadStartArg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000DFAAC File Offset: 0x000DDCAC
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x0000F20F File Offset: 0x0000D40F
		public unsafe Object pending_exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_pending_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_pending_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000DFADC File Offset: 0x000DDCDC
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x0000F22E File Offset: 0x0000D42E
		public unsafe IPrincipal principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000DFB0C File Offset: 0x000DDD0C
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x0000F24D File Offset: 0x0000D44D
		public unsafe int principal_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal_version)) = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x000DFB34 File Offset: 0x000DDD34
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x0000F268 File Offset: 0x0000D468
		public unsafe static Thread current_thread
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_current_thread, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_current_thread, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000DFB5C File Offset: 0x000DDD5C
		// (set) Token: 0x06002B9B RID: 11163 RVA: 0x0000F27A File Offset: 0x0000D47A
		public unsafe MulticastDelegate m_Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MulticastDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x000DFB8C File Offset: 0x000DDD8C
		// (set) Token: 0x06002B9D RID: 11165 RVA: 0x0000F299 File Offset: 0x0000D499
		public unsafe ExecutionContext m_ExecutionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000DFBBC File Offset: 0x000DDDBC
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		public unsafe bool m_ExecutionContextBelongsToOuterScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope)) = value;
			}
		}

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeFieldInfoPtr_s_LocalDataStoreMgr;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeFieldInfoPtr_s_LocalDataStore;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCulture;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentUICulture;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentCulture;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentUICulture;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeFieldInfoPtr_internal_thread;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeFieldInfoPtr_m_ThreadStartArg;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeFieldInfoPtr_pending_exception;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeFieldInfoPtr_principal;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeFieldInfoPtr_principal_version;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeFieldInfoPtr_current_thread;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeFieldInfoPtr_m_Delegate;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionContext;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Object_0;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0;

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0;

		// Token: 0x040025E2 RID: 9698
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0;

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeMethodInfoPtr_Yield_Public_Static_Boolean_0;

		// Token: 0x040025E7 RID: 9703
		private static readonly IntPtr NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0;

		// Token: 0x040025E8 RID: 9704
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0;

		// Token: 0x040025E9 RID: 9705
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0;

		// Token: 0x040025EA RID: 9706
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0;

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeMethodInfoPtr_Thread_internal_Private_IntPtr_MulticastDelegate_0;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_StartInternal_Private_Void_IPrincipal_byref_StackCrawlMark_0;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0;
	}
}
