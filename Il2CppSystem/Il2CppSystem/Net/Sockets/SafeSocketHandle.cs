using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200012E RID: 302
	public sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x0005D1B4 File Offset: 0x0005B3B4
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSocketHandle()
		{
			Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SafeSocketHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr);
			SafeSocketHandle.NativeFieldInfoPtr_blocking_threads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "blocking_threads");
			SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "threads_stacktraces");
			SafeSocketHandle.NativeFieldInfoPtr_in_cleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "in_cleanup");
			SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "THROW_ON_ABORT_RETRIES");
			SafeSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666159);
			SafeSocketHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666160);
			SafeSocketHandle.NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666161);
			SafeSocketHandle.NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666162);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0005D284 File Offset: 0x0005B484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 57001, RefRangeEnd = 57004, XrefRangeStart = 56990, XrefRangeEnd = 57001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preexistingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0005D2DC File Offset: 0x0005B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57004, XrefRangeEnd = 57063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0005D318 File Offset: 0x0005B518
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 57093, RefRangeEnd = 57100, XrefRangeStart = 57063, XrefRangeEnd = 57093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterForBlockingSyscall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0005D34C File Offset: 0x0005B54C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 57119, RefRangeEnd = 57133, XrefRangeStart = 57100, XrefRangeEnd = 57119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnRegisterForBlockingSyscall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0000A2F2 File Offset: 0x000084F2
		public SafeSocketHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0005D380 File Offset: 0x0005B580
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x0000A2FB File Offset: 0x000084FB
		public unsafe List<Thread> blocking_threads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_blocking_threads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Thread>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_blocking_threads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0005D3B0 File Offset: 0x0005B5B0
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x0000A31A File Offset: 0x0000851A
		public unsafe Dictionary<Thread, StackTrace> threads_stacktraces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Thread, StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0005D3E0 File Offset: 0x0005B5E0
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0000A339 File Offset: 0x00008539
		public unsafe bool in_cleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_in_cleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_in_cleanup)) = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0005D408 File Offset: 0x0005B608
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x0000A354 File Offset: 0x00008554
		public unsafe static bool THROW_ON_ABORT_RETRIES
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&value));
			}
		}

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeFieldInfoPtr_blocking_threads;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeFieldInfoPtr_threads_stacktraces;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeFieldInfoPtr_in_cleanup;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0;
	}
}
