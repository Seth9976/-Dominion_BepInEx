using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200012F RID: 303
	public class SocketAsyncEventArgs : EventArgs
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x0005D424 File Offset: 0x0005B624
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAsyncEventArgs()
		{
			Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketAsyncEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr);
			SocketAsyncEventArgs.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "disposed");
			SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "in_progress");
			SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "remote_ep");
			SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "current_socket");
			SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<AcceptSocket>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<BytesTransferred>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SocketError>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "Completed");
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666164);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666165);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_BytesTransferred_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666166);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666167);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666168);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666169);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Complete_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666170);
			SocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100666171);
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005D594 File Offset: 0x0005B794
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0005D5D4 File Offset: 0x0005B7D4
		public unsafe Socket AcceptSocket
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000697 RID: 1687
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0005D618 File Offset: 0x0005B818
		public unsafe int BytesTransferred
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_BytesTransferred_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000698 RID: 1688
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0005D658 File Offset: 0x0005B858
		public unsafe SocketError SocketError
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0005D698 File Offset: 0x0005B898
		[CallerCount(0)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0005D6D8 File Offset: 0x0005B8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57133, XrefRangeEnd = 57138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0005D70C File Offset: 0x0005B90C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 57138, RefRangeEnd = 57163, XrefRangeStart = 57138, XrefRangeEnd = 57138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Complete_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0005D740 File Offset: 0x0005B940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57163, XrefRangeEnd = 57166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0000A362 File Offset: 0x00008562
		public SocketAsyncEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0005D790 File Offset: 0x0005B990
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0000A36B File Offset: 0x0000856B
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0005D7B8 File Offset: 0x0005B9B8
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000A386 File Offset: 0x00008586
		public unsafe int in_progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress)) = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0005D7E0 File Offset: 0x0005B9E0
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0000A3A1 File Offset: 0x000085A1
		public unsafe EndPoint remote_ep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0005D810 File Offset: 0x0005BA10
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0000A3C0 File Offset: 0x000085C0
		public unsafe Socket current_socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0005D840 File Offset: 0x0005BA40
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0000A3DF File Offset: 0x000085DF
		public unsafe Socket _AcceptSocket_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0005D870 File Offset: 0x0005BA70
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x0000A3FE File Offset: 0x000085FE
		public unsafe int _BytesTransferred_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField)) = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0005D898 File Offset: 0x0005BA98
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0000A419 File Offset: 0x00008619
		public unsafe SocketError _SocketError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField)) = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0005D8C0 File Offset: 0x0005BAC0
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0000A434 File Offset: 0x00008634
		public unsafe EventHandler<SocketAsyncEventArgs> Completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_Completed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_Completed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeFieldInfoPtr_in_progress;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeFieldInfoPtr_remote_ep;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeFieldInfoPtr_current_socket;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeFieldInfoPtr__AcceptSocket_k__BackingField;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeFieldInfoPtr__BytesTransferred_k__BackingField;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeFieldInfoPtr__SocketError_k__BackingField;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeFieldInfoPtr_Completed;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_set_BytesTransferred_Internal_set_Void_Int32_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0;
	}
}
