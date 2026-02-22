using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000256 RID: 598
	public sealed class CancellationToken : ValueType
	{
		// Token: 0x0600297D RID: 10621 RVA: 0x000D78D8 File Offset: 0x000D5AD8
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationToken()
		{
			Il2CppClassPointerStore<CancellationToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr);
			CancellationToken.NativeFieldInfoPtr_m_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, "m_source");
			CancellationToken.NativeFieldInfoPtr_s_ActionToActionObjShunt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, "s_ActionToActionObjShunt");
			CancellationToken.NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669921);
			CancellationToken.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669922);
			CancellationToken.NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669923);
			CancellationToken.NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669924);
			CancellationToken.NativeMethodInfoPtr_ActionToActionObjShunt_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669925);
			CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669926);
			CancellationToken.NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669927);
			CancellationToken.NativeMethodInfoPtr_Register_Private_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669928);
			CancellationToken.NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669929);
			CancellationToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669930);
			CancellationToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669931);
			CancellationToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669932);
			CancellationToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669933);
			CancellationToken.NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669934);
			CancellationToken.NativeMethodInfoPtr_ThrowIfSourceDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669935);
			CancellationToken.NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669936);
			CancellationToken.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100669937);
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x000D7A84 File Offset: 0x000D5C84
		public unsafe static CancellationToken None
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000D7AB0 File Offset: 0x000D5CB0
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 330053, RefRangeEnd = 330080, XrefRangeStart = 330053, XrefRangeEnd = 330053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x000D7AF4 File Offset: 0x000D5CF4
		public unsafe bool CanBeCanceled
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 330080, RefRangeEnd = 330086, XrefRangeStart = 330080, XrefRangeEnd = 330080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000D7B38 File Offset: 0x000D5D38
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationToken(CancellationTokenSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000D7B88 File Offset: 0x000D5D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330086, XrefRangeEnd = 330090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActionToActionObjShunt(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ActionToActionObjShunt_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000D7BC0 File Offset: 0x000D5DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330095, RefRangeEnd = 330096, XrefRangeStart = 330090, XrefRangeEnd = 330095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration Register(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationTokenRegistration(intPtr);
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000D7C10 File Offset: 0x000D5E10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 330097, RefRangeEnd = 330102, XrefRangeStart = 330096, XrefRangeEnd = 330097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration InternalRegisterWithoutEC(Action<Object> callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000D7C70 File Offset: 0x000D5E70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 330110, RefRangeEnd = 330115, XrefRangeStart = 330102, XrefRangeEnd = 330110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration Register(Action<Object> callback, Object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSynchronizationContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Register_Private_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000D7CEC File Offset: 0x000D5EEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330123, RefRangeEnd = 330126, XrefRangeStart = 330115, XrefRangeEnd = 330123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CancellationToken other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000D7D44 File Offset: 0x000D5F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330126, XrefRangeEnd = 330130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000D7D98 File Offset: 0x000D5F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330130, XrefRangeEnd = 330139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000D7DDC File Offset: 0x000D5FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330140, RefRangeEnd = 330141, XrefRangeStart = 330139, XrefRangeEnd = 330140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CancellationToken left, CancellationToken right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000D7E3C File Offset: 0x000D603C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330142, RefRangeEnd = 330144, XrefRangeStart = 330141, XrefRangeEnd = 330142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CancellationToken left, CancellationToken right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000D7E9C File Offset: 0x000D609C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 330145, RefRangeEnd = 330163, XrefRangeStart = 330144, XrefRangeEnd = 330145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfCancellationRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x000D7ED4 File Offset: 0x000D60D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330164, RefRangeEnd = 330166, XrefRangeStart = 330163, XrefRangeEnd = 330164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfSourceDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowIfSourceDisposed_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000D7F0C File Offset: 0x000D610C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330166, XrefRangeEnd = 330183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOperationCanceledException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000D7F44 File Offset: 0x000D6144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330183, XrefRangeEnd = 330190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowObjectDisposedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0000E709 File Offset: 0x0000C909
		public CancellationToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x0000E712 File Offset: 0x0000C912
		public CancellationToken()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr))
		{
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x000D7F6C File Offset: 0x000D616C
		// (set) Token: 0x06002992 RID: 10642 RVA: 0x0000E724 File Offset: 0x0000C924
		public unsafe CancellationTokenSource m_source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationToken.NativeFieldInfoPtr_m_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationToken.NativeFieldInfoPtr_m_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x000D7F9C File Offset: 0x000D619C
		// (set) Token: 0x06002994 RID: 10644 RVA: 0x0000E743 File Offset: 0x0000C943
		public unsafe static Action<Object> s_ActionToActionObjShunt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationToken.NativeFieldInfoPtr_s_ActionToActionObjShunt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationToken.NativeFieldInfoPtr_s_ActionToActionObjShunt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeFieldInfoPtr_m_source;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeFieldInfoPtr_s_ActionToActionObjShunt;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeMethodInfoPtr_ActionToActionObjShunt_Private_Static_Void_Object_0;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeMethodInfoPtr_Register_Private_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfSourceDisposed_Internal_Void_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0;
	}
}
