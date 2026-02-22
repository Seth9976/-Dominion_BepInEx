using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000290 RID: 656
	public sealed class RegisteredWaitHandle : MarshalByRefObject
	{
		// Token: 0x06002C6D RID: 11373 RVA: 0x000E2AC4 File Offset: 0x000E0CC4
		// Note: this type is marked as 'beforefieldinit'.
		static RegisteredWaitHandle()
		{
			Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "RegisteredWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr);
			RegisteredWaitHandle.NativeFieldInfoPtr__waitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_waitObject");
			RegisteredWaitHandle.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callback");
			RegisteredWaitHandle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_state");
			RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_finalEvent");
			RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_cancelEvent");
			RegisteredWaitHandle.NativeFieldInfoPtr__timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_timeout");
			RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callsInProcess");
			RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_executeOnlyOnce");
			RegisteredWaitHandle.NativeFieldInfoPtr__unregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_unregistered");
			RegisteredWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100670356);
			RegisteredWaitHandle.NativeMethodInfoPtr_Wait_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100670357);
			RegisteredWaitHandle.NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100670358);
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x000E2BE4 File Offset: 0x000E0DE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333751, RefRangeEnd = 333753, XrefRangeStart = 333746, XrefRangeEnd = 333751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, Object state, TimeSpan timeout, bool executeOnlyOnce)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000E2C70 File Offset: 0x000E0E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333753, XrefRangeEnd = 333787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr_Wait_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000E2CB4 File Offset: 0x000E0EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333787, XrefRangeEnd = 333797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(Object timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timedOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x0000F710 File Offset: 0x0000D910
		public RegisteredWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x000E2CF8 File Offset: 0x000E0EF8
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x0000F719 File Offset: 0x0000D919
		public unsafe WaitHandle _waitObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__waitObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__waitObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x000E2D28 File Offset: 0x000E0F28
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x0000F738 File Offset: 0x0000D938
		public unsafe WaitOrTimerCallback _callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitOrTimerCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x000E2D58 File Offset: 0x000E0F58
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x0000F757 File Offset: 0x0000D957
		public unsafe Object _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000E2D88 File Offset: 0x000E0F88
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x0000F776 File Offset: 0x0000D976
		public unsafe WaitHandle _finalEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000E2DB8 File Offset: 0x000E0FB8
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x0000F795 File Offset: 0x0000D995
		public unsafe ManualResetEvent _cancelEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x000E2DE8 File Offset: 0x000E0FE8
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
		public unsafe TimeSpan _timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__timeout)) = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x000E2E10 File Offset: 0x000E1010
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x0000F7CF File Offset: 0x0000D9CF
		public unsafe int _callsInProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess)) = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000E2E38 File Offset: 0x000E1038
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x0000F7EA File Offset: 0x0000D9EA
		public unsafe bool _executeOnlyOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce)) = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000E2E60 File Offset: 0x000E1060
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x0000F805 File Offset: 0x0000DA05
		public unsafe bool _unregistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__unregistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__unregistered)) = value;
			}
		}

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeFieldInfoPtr__waitObject;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeFieldInfoPtr__finalEvent;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeFieldInfoPtr__cancelEvent;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeFieldInfoPtr__timeout;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeFieldInfoPtr__callsInProcess;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeFieldInfoPtr__executeOnlyOnce;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeFieldInfoPtr__unregistered;

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Internal_Void_Object_0;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0;
	}
}
