using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x02000299 RID: 665
	public static class AsyncCausalityTracer : Object
	{
		// Token: 0x06002CFC RID: 11516 RVA: 0x000E4118 File Offset: 0x000E2318
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncCausalityTracer()
		{
			Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AsyncCausalityTracer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr);
			AsyncCausalityTracer.NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670390);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670391);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670392);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationRelation_Internal_Static_Void_CausalityTraceLevel_Int32_CausalityRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670393);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670394);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670395);
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000E41C0 File Offset: 0x000E23C0
		public unsafe static bool LoggingOn
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x000E41F0 File Offset: 0x000E23F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(operationName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relatedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000E4250 File Offset: 0x000E2450
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000E42A0 File Offset: 0x000E24A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationRelation_Internal_Static_Void_CausalityTraceLevel_Int32_CausalityRelation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000E42F0 File Offset: 0x000E24F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000E4340 File Offset: 0x000E2540
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x0000FD54 File Offset: 0x0000DF54
		public AsyncCausalityTracer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002700 RID: 9984
		private static readonly IntPtr NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0;

		// Token: 0x04002701 RID: 9985
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0;

		// Token: 0x04002702 RID: 9986
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0;

		// Token: 0x04002703 RID: 9987
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationRelation_Internal_Static_Void_CausalityTraceLevel_Int32_CausalityRelation_0;

		// Token: 0x04002704 RID: 9988
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0;

		// Token: 0x04002705 RID: 9989
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0;
	}
}
