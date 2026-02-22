using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002BC RID: 700
	public sealed class CallResult<T> : CallResult
	{
		// Token: 0x06002829 RID: 10281 RVA: 0x000AE578 File Offset: 0x000AC778
		// Note: this type is marked as 'beforefieldinit'.
		static CallResult()
		{
			Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallResult`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr);
			CallResult<T>.NativeFieldInfoPtr_m_Func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, "m_Func");
			CallResult<T>.NativeFieldInfoPtr_m_hAPICall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, "m_hAPICall");
			CallResult<T>.NativeFieldInfoPtr_m_bDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, "m_bDisposed");
			CallResult<T>.NativeMethodInfoPtr_add_m_Func_Private_add_Void_APIDispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668431);
			CallResult<T>.NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_APIDispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668432);
			CallResult<T>.NativeMethodInfoPtr_get_Handle_Public_get_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668433);
			CallResult<T>.NativeMethodInfoPtr_Create_Public_Static_CallResult_1_T_APIDispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668434);
			CallResult<T>.NativeMethodInfoPtr__ctor_Public_Void_APIDispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668435);
			CallResult<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668436);
			CallResult<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668437);
			CallResult<T>.NativeMethodInfoPtr_Set_Public_Void_SteamAPICall_t_APIDispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668438);
			CallResult<T>.NativeMethodInfoPtr_IsActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668439);
			CallResult<T>.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668440);
			CallResult<T>.NativeMethodInfoPtr_GetCallbackType_Internal_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668441);
			CallResult<T>.NativeMethodInfoPtr_OnRunCallResult_Internal_Virtual_Void_IntPtr_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668442);
			CallResult<T>.NativeMethodInfoPtr_SetUnregistered_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100668443);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x000AE724 File Offset: 0x000AC924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_m_Func(CallResult<T>.APIDispatchDelegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_add_m_Func_Private_add_Void_APIDispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000AE768 File Offset: 0x000AC968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_m_Func(CallResult<T>.APIDispatchDelegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_APIDispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x000AE7AC File Offset: 0x000AC9AC
		public unsafe SteamAPICall_t Handle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_get_Handle_Public_get_SteamAPICall_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x000AE7E8 File Offset: 0x000AC9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207439, XrefRangeEnd = 207445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallResult<T> Create(CallResult<T>.APIDispatchDelegate func = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_Create_Public_Static_CallResult_1_T_APIDispatchDelegate_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallResult<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x000AE82C File Offset: 0x000ACA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207445, XrefRangeEnd = 207450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult(CallResult<T>.APIDispatchDelegate func = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr__ctor_Public_Void_APIDispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x000AE878 File Offset: 0x000ACA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207450, XrefRangeEnd = 207453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000AE8AC File Offset: 0x000ACAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207453, XrefRangeEnd = 207457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000AE8E0 File Offset: 0x000ACAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207457, XrefRangeEnd = 207474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(SteamAPICall_t hAPICall, CallResult<T>.APIDispatchDelegate func = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hAPICall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_Set_Public_Void_SteamAPICall_t_APIDispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x000AE930 File Offset: 0x000ACB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207474, XrefRangeEnd = 207479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_IsActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000AE96C File Offset: 0x000ACB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207479, XrefRangeEnd = 207483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000AE9A0 File Offset: 0x000ACBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207483, XrefRangeEnd = 207487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetCallbackType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_GetCallbackType_Internal_Virtual_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x000AE9E0 File Offset: 0x000ACBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207487, XrefRangeEnd = 207509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pvParam;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFailed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall_;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_OnRunCallResult_Internal_Virtual_Void_IntPtr_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x000AEA3C File Offset: 0x000ACC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207509, XrefRangeEnd = 207513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetUnregistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_SetUnregistered_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000103FA File Offset: 0x0000E5FA
		public CallResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002838 RID: 10296 RVA: 0x000AEA70 File Offset: 0x000ACC70
		// (set) Token: 0x06002839 RID: 10297 RVA: 0x00010403 File Offset: 0x0000E603
		public unsafe CallResult<T>.APIDispatchDelegate m_Func
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_m_Func);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallResult<T>.APIDispatchDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_m_Func), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x000AEAA0 File Offset: 0x000ACCA0
		// (set) Token: 0x0600283B RID: 10299 RVA: 0x00010422 File Offset: 0x0000E622
		public unsafe SteamAPICall_t m_hAPICall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_m_hAPICall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_m_hAPICall)) = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x000AEAC8 File Offset: 0x000ACCC8
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x0001043D File Offset: 0x0000E63D
		public unsafe bool m_bDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_m_bDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_m_bDisposed)) = value;
			}
		}

		// Token: 0x0400272C RID: 10028
		private static readonly IntPtr NativeFieldInfoPtr_m_Func;

		// Token: 0x0400272D RID: 10029
		private static readonly IntPtr NativeFieldInfoPtr_m_hAPICall;

		// Token: 0x0400272E RID: 10030
		private static readonly IntPtr NativeFieldInfoPtr_m_bDisposed;

		// Token: 0x0400272F RID: 10031
		private static readonly IntPtr NativeMethodInfoPtr_add_m_Func_Private_add_Void_APIDispatchDelegate_T_0;

		// Token: 0x04002730 RID: 10032
		private static readonly IntPtr NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_APIDispatchDelegate_T_0;

		// Token: 0x04002731 RID: 10033
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_SteamAPICall_t_0;

		// Token: 0x04002732 RID: 10034
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CallResult_1_T_APIDispatchDelegate_T_0;

		// Token: 0x04002733 RID: 10035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_APIDispatchDelegate_T_0;

		// Token: 0x04002734 RID: 10036
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002735 RID: 10037
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_SteamAPICall_t_APIDispatchDelegate_T_0;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Boolean_0;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackType_Internal_Virtual_Type_0;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallResult_Internal_Virtual_Void_IntPtr_Boolean_UInt64_0;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeMethodInfoPtr_SetUnregistered_Internal_Virtual_Void_0;

		// Token: 0x020003A8 RID: 936
		public sealed class APIDispatchDelegate : MulticastDelegate
		{
			// Token: 0x0600373B RID: 14139 RVA: 0x000E1E44 File Offset: 0x000E0044
			// Note: this type is marked as 'beforefieldinit'.
			static APIDispatchDelegate()
			{
				Il2CppClassPointerStore<CallResult<T>.APIDispatchDelegate>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, "APIDispatchDelegate"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>.APIDispatchDelegate>.NativeClassPtr, 100670315);
				CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>.APIDispatchDelegate>.NativeClassPtr, 100670316);
				CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>.APIDispatchDelegate>.NativeClassPtr, 100670317);
				CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>.APIDispatchDelegate>.NativeClassPtr, 100670318);
			}

			// Token: 0x0600373C RID: 14140 RVA: 0x000E1EF0 File Offset: 0x000E00F0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe APIDispatchDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallResult<T>.APIDispatchDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600373D RID: 14141 RVA: 0x000E1F4C File Offset: 0x000E014C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 207434, RefRangeEnd = 207435, XrefRangeStart = 207418, XrefRangeEnd = 207434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(T param, bool bIOFailure)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = param;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref param;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIOFailure;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600373E RID: 14142 RVA: 0x000E1FD4 File Offset: 0x000E01D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207435, XrefRangeEnd = 207439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T param, bool bIOFailure, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = param;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref param;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIOFailure;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600373F RID: 14143 RVA: 0x000E2090 File Offset: 0x000E0290
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.APIDispatchDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003740 RID: 14144 RVA: 0x0001562F File Offset: 0x0001382F
			public APIDispatchDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003741 RID: 14145 RVA: 0x00015638 File Offset: 0x00013838
			public static implicit operator CallResult<T>.APIDispatchDelegate(Action<T, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<CallResult<T>.APIDispatchDelegate>(A_0);
			}

			// Token: 0x06003742 RID: 14146 RVA: 0x00015640 File Offset: 0x00013840
			public static CallResult<T>.APIDispatchDelegate operator +(CallResult<T>.APIDispatchDelegate A_0, CallResult<T>.APIDispatchDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CallResult<T>.APIDispatchDelegate>();
			}

			// Token: 0x06003743 RID: 14147 RVA: 0x0001564E File Offset: 0x0001384E
			public static CallResult<T>.APIDispatchDelegate operator -(CallResult<T>.APIDispatchDelegate A_0, CallResult<T>.APIDispatchDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CallResult<T>.APIDispatchDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04003246 RID: 12870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003247 RID: 12871
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_Boolean_0;

			// Token: 0x04003248 RID: 12872
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_Boolean_AsyncCallback_Object_0;

			// Token: 0x04003249 RID: 12873
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
