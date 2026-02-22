using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025F RID: 607
	public class ManualResetEventSlim : Object
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x000D9CB0 File Offset: 0x000D7EB0
		// Note: this type is marked as 'beforefieldinit'.
		static ManualResetEventSlim()
		{
			Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ManualResetEventSlim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr);
			ManualResetEventSlim.NativeFieldInfoPtr_m_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_lock");
			ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_eventObj");
			ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_combinedState");
			ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "s_cancellationTokenCallback");
			ManualResetEventSlim.NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669992);
			ManualResetEventSlim.NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669993);
			ManualResetEventSlim.NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669994);
			ManualResetEventSlim.NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669995);
			ManualResetEventSlim.NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669996);
			ManualResetEventSlim.NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669997);
			ManualResetEventSlim.NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669998);
			ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100669999);
			ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670000);
			ManualResetEventSlim.NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670001);
			ManualResetEventSlim.NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670002);
			ManualResetEventSlim.NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670003);
			ManualResetEventSlim.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670004);
			ManualResetEventSlim.NativeMethodInfoPtr_Set_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670005);
			ManualResetEventSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670006);
			ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670007);
			ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670008);
			ManualResetEventSlim.NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670009);
			ManualResetEventSlim.NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670010);
			ManualResetEventSlim.NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670011);
			ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670012);
			ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670013);
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000D9EE8 File Offset: 0x000D80E8
		public unsafe WaitHandle WaitHandle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 330585, RefRangeEnd = 330586, XrefRangeStart = 330581, XrefRangeEnd = 330585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000D9F28 File Offset: 0x000D8128
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x000D9F64 File Offset: 0x000D8164
		public unsafe bool IsSet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 330590, RefRangeEnd = 330592, XrefRangeStart = 330586, XrefRangeEnd = 330590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330592, XrefRangeEnd = 330594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000D9FA4 File Offset: 0x000D81A4
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x000D9FE0 File Offset: 0x000D81E0
		public unsafe int SpinCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330594, XrefRangeEnd = 330598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330598, XrefRangeEnd = 330600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000DA020 File Offset: 0x000D8220
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x000DA05C File Offset: 0x000D825C
		public unsafe int Waiters
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 330604, RefRangeEnd = 330607, XrefRangeStart = 330600, XrefRangeEnd = 330604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 330618, RefRangeEnd = 330621, XrefRangeStart = 330607, XrefRangeEnd = 330618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000DA09C File Offset: 0x000D829C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330626, RefRangeEnd = 330628, XrefRangeStart = 330621, XrefRangeEnd = 330626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEventSlim(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000DA0E4 File Offset: 0x000D82E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330633, RefRangeEnd = 330634, XrefRangeStart = 330628, XrefRangeEnd = 330633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEventSlim(bool initialState, int spinCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000DA13C File Offset: 0x000D833C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330634, XrefRangeEnd = 330638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(bool initialState, int spinCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000DA188 File Offset: 0x000D8388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330638, XrefRangeEnd = 330645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLockObjectCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000DA1BC File Offset: 0x000D83BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330664, RefRangeEnd = 330665, XrefRangeStart = 330645, XrefRangeEnd = 330664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LazyInitializeEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000DA1F8 File Offset: 0x000D83F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 330666, RefRangeEnd = 330671, XrefRangeStart = 330665, XrefRangeEnd = 330666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000DA22C File Offset: 0x000D842C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330689, RefRangeEnd = 330690, XrefRangeStart = 330671, XrefRangeEnd = 330689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool duringCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duringCancellation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Set_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x000DA26C File Offset: 0x000D846C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330758, RefRangeEnd = 330760, XrefRangeStart = 330690, XrefRangeEnd = 330758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x000DA2CC File Offset: 0x000D84CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330764, RefRangeEnd = 330767, XrefRangeStart = 330760, XrefRangeEnd = 330764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000DA300 File Offset: 0x000D8500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330767, XrefRangeEnd = 330775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000DA34C File Offset: 0x000D854C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330776, RefRangeEnd = 330778, XrefRangeStart = 330775, XrefRangeEnd = 330776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000DA380 File Offset: 0x000D8580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330778, XrefRangeEnd = 330786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancellationTokenCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000DA3B8 File Offset: 0x000D85B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330793, RefRangeEnd = 330796, XrefRangeStart = 330786, XrefRangeEnd = 330793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateBitsMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000DA404 File Offset: 0x000D8604
		[CallerCount(0)]
		public unsafe static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightBitShiftCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000DA460 File Offset: 0x000D8660
		[CallerCount(0)]
		public unsafe static int ExtractStatePortion(int state, int mask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0000EB27 File Offset: 0x0000CD27
		public ManualResetEventSlim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000DA4AC File Offset: 0x000D86AC
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x0000EB30 File Offset: 0x0000CD30
		public unsafe Object m_lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x000DA4DC File Offset: 0x000D86DC
		// (set) Token: 0x06002A34 RID: 10804 RVA: 0x0000EB4F File Offset: 0x0000CD4F
		public unsafe ManualResetEvent m_eventObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x000DA50C File Offset: 0x000D870C
		// (set) Token: 0x06002A36 RID: 10806 RVA: 0x0000EB6E File Offset: 0x0000CD6E
		public unsafe int m_combinedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState)) = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x000DA534 File Offset: 0x000D8734
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x0000EB89 File Offset: 0x0000CD89
		public unsafe static Action<Object> s_cancellationTokenCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeFieldInfoPtr_m_lock;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeFieldInfoPtr_m_eventObj;

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeFieldInfoPtr_m_combinedState;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeFieldInfoPtr_s_cancellationTokenCallback;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Boolean_0;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0;
	}
}
