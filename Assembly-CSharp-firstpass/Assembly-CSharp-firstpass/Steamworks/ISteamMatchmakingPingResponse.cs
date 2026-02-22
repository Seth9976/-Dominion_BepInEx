using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020002C3 RID: 707
	public class ISteamMatchmakingPingResponse : Object
	{
		// Token: 0x06002873 RID: 10355 RVA: 0x000AF618 File Offset: 0x000AD818
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingPingResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingPingResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr);
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_ServerResponded");
			ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "m_ServerFailedToRespond");
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100668467);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100668468);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100668469);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100668470);
			ISteamMatchmakingPingResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPingResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, 100668471);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000AF710 File Offset: 0x000AD910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209508, XrefRangeEnd = 209543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingPingResponse(ISteamMatchmakingPingResponse.ServerResponded onServerResponded, ISteamMatchmakingPingResponse.ServerFailedToRespond onServerFailedToRespond)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onServerResponded);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onServerFailedToRespond);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000AF770 File Offset: 0x000AD970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209543, XrefRangeEnd = 209554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingPingResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000AF7AC File Offset: 0x000AD9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209554, XrefRangeEnd = 209556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(server);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000AF7FC File Offset: 0x000AD9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209556, XrefRangeEnd = 209558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000AF83C File Offset: 0x000ADA3C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209480, RefRangeEnd = 209489, XrefRangeStart = 209480, XrefRangeEnd = 209489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPingResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00010591 File Offset: 0x0000E791
		public ISteamMatchmakingPingResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x000AF880 File Offset: 0x000ADA80
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x0001059A File Offset: 0x0000E79A
		public unsafe ISteamMatchmakingPingResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000AF8B0 File Offset: 0x000ADAB0
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x000105B9 File Offset: 0x0000E7B9
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x000AF8D8 File Offset: 0x000ADAD8
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x000105D4 File Offset: 0x0000E7D4
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000AF900 File Offset: 0x000ADB00
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x000105EF File Offset: 0x0000E7EF
		public unsafe ISteamMatchmakingPingResponse.ServerResponded m_ServerResponded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerResponded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.ServerResponded>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x000AF930 File Offset: 0x000ADB30
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x0001060E File Offset: 0x0000E80E
		public unsafe ISteamMatchmakingPingResponse.ServerFailedToRespond m_ServerFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.ServerFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.NativeFieldInfoPtr_m_ServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerResponded;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerFailedToRespond;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_0;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_gameserveritem_t_0;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_0;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingPingResponse_0;

		// Token: 0x020003B2 RID: 946
		public sealed class ServerResponded : MulticastDelegate
		{
			// Token: 0x06003792 RID: 14226 RVA: 0x000E3094 File Offset: 0x000E1294
			// Note: this type is marked as 'beforefieldinit'.
			static ServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "ServerResponded");
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100670349);
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100670350);
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_gameserveritem_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100670351);
				ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr, 100670352);
			}

			// Token: 0x06003793 RID: 14227 RVA: 0x000E3108 File Offset: 0x000E1308
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003794 RID: 14228 RVA: 0x000E3164 File Offset: 0x000E1364
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(gameserveritem_t server)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(server);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003795 RID: 14229 RVA: 0x000E31A8 File Offset: 0x000E13A8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(gameserveritem_t server, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(server);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_gameserveritem_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003796 RID: 14230 RVA: 0x000E321C File Offset: 0x000E141C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003797 RID: 14231 RVA: 0x0001584C File Offset: 0x00013A4C
			public ServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003798 RID: 14232 RVA: 0x00015855 File Offset: 0x00013A55
			public static implicit operator ISteamMatchmakingPingResponse.ServerResponded(Action<gameserveritem_t> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.ServerResponded>(A_0);
			}

			// Token: 0x06003799 RID: 14233 RVA: 0x0001585D File Offset: 0x00013A5D
			public static ISteamMatchmakingPingResponse.ServerResponded operator +(ISteamMatchmakingPingResponse.ServerResponded A_0, ISteamMatchmakingPingResponse.ServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.ServerResponded>();
			}

			// Token: 0x0600379A RID: 14234 RVA: 0x0001586B File Offset: 0x00013A6B
			public static ISteamMatchmakingPingResponse.ServerResponded operator -(ISteamMatchmakingPingResponse.ServerResponded A_0, ISteamMatchmakingPingResponse.ServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.ServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x0400326E RID: 12910
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400326F RID: 12911
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_gameserveritem_t_0;

			// Token: 0x04003270 RID: 12912
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_gameserveritem_t_AsyncCallback_Object_0;

			// Token: 0x04003271 RID: 12913
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B3 RID: 947
		public sealed class ServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x0600379B RID: 14235 RVA: 0x000E3260 File Offset: 0x000E1460
			// Note: this type is marked as 'beforefieldinit'.
			static ServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "ServerFailedToRespond");
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100670353);
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100670354);
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100670355);
				ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr, 100670356);
			}

			// Token: 0x0600379C RID: 14236 RVA: 0x000E32D4 File Offset: 0x000E14D4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.ServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600379D RID: 14237 RVA: 0x000E3330 File Offset: 0x000E1530
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600379E RID: 14238 RVA: 0x000E3364 File Offset: 0x000E1564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600379F RID: 14239 RVA: 0x000E33C8 File Offset: 0x000E15C8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037A0 RID: 14240 RVA: 0x0001587C File Offset: 0x00013A7C
			public ServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037A1 RID: 14241 RVA: 0x00015885 File Offset: 0x00013A85
			public static implicit operator ISteamMatchmakingPingResponse.ServerFailedToRespond(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.ServerFailedToRespond>(A_0);
			}

			// Token: 0x060037A2 RID: 14242 RVA: 0x0001588D File Offset: 0x00013A8D
			public static ISteamMatchmakingPingResponse.ServerFailedToRespond operator +(ISteamMatchmakingPingResponse.ServerFailedToRespond A_0, ISteamMatchmakingPingResponse.ServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.ServerFailedToRespond>();
			}

			// Token: 0x060037A3 RID: 14243 RVA: 0x0001589B File Offset: 0x00013A9B
			public static ISteamMatchmakingPingResponse.ServerFailedToRespond operator -(ISteamMatchmakingPingResponse.ServerFailedToRespond A_0, ISteamMatchmakingPingResponse.ServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.ServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04003272 RID: 12914
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003273 RID: 12915
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04003274 RID: 12916
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04003275 RID: 12917
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B4 RID: 948
		public sealed class InternalServerResponded : MulticastDelegate
		{
			// Token: 0x060037A4 RID: 14244 RVA: 0x000E340C File Offset: 0x000E160C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "InternalServerResponded");
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100670357);
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_gameserveritem_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100670358);
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_gameserveritem_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100670359);
				ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr, 100670360);
			}

			// Token: 0x060037A5 RID: 14245 RVA: 0x000E3480 File Offset: 0x000E1680
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037A6 RID: 14246 RVA: 0x000E34DC File Offset: 0x000E16DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209489, XrefRangeEnd = 209493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr, gameserveritem_t server)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(server);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_gameserveritem_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037A7 RID: 14247 RVA: 0x000E352C File Offset: 0x000E172C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209493, XrefRangeEnd = 209497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, gameserveritem_t server, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(server);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_gameserveritem_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037A8 RID: 14248 RVA: 0x000E35B0 File Offset: 0x000E17B0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037A9 RID: 14249 RVA: 0x000158AC File Offset: 0x00013AAC
			public InternalServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037AA RID: 14250 RVA: 0x000158B5 File Offset: 0x00013AB5
			public static implicit operator ISteamMatchmakingPingResponse.InternalServerResponded(Action<IntPtr, gameserveritem_t> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.InternalServerResponded>(A_0);
			}

			// Token: 0x060037AB RID: 14251 RVA: 0x000158BD File Offset: 0x00013ABD
			public static ISteamMatchmakingPingResponse.InternalServerResponded operator +(ISteamMatchmakingPingResponse.InternalServerResponded A_0, ISteamMatchmakingPingResponse.InternalServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.InternalServerResponded>();
			}

			// Token: 0x060037AC RID: 14252 RVA: 0x000158CB File Offset: 0x00013ACB
			public static ISteamMatchmakingPingResponse.InternalServerResponded operator -(ISteamMatchmakingPingResponse.InternalServerResponded A_0, ISteamMatchmakingPingResponse.InternalServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.InternalServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x04003276 RID: 12918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003277 RID: 12919
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_gameserveritem_t_0;

			// Token: 0x04003278 RID: 12920
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_gameserveritem_t_AsyncCallback_Object_0;

			// Token: 0x04003279 RID: 12921
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B5 RID: 949
		public sealed class InternalServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x060037AD RID: 14253 RVA: 0x000E35F4 File Offset: 0x000E17F4
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "InternalServerFailedToRespond");
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670361);
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670362);
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670363);
				ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670364);
			}

			// Token: 0x060037AE RID: 14254 RVA: 0x000E3668 File Offset: 0x000E1868
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037AF RID: 14255 RVA: 0x000E36C4 File Offset: 0x000E18C4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209501, RefRangeEnd = 209504, XrefRangeStart = 209497, XrefRangeEnd = 209501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037B0 RID: 14256 RVA: 0x000E3704 File Offset: 0x000E1904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209504, XrefRangeEnd = 209508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060037B1 RID: 14257 RVA: 0x000E3774 File Offset: 0x000E1974
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037B2 RID: 14258 RVA: 0x000158DC File Offset: 0x00013ADC
			public InternalServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037B3 RID: 14259 RVA: 0x000158E5 File Offset: 0x00013AE5
			public static implicit operator ISteamMatchmakingPingResponse.InternalServerFailedToRespond(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>(A_0);
			}

			// Token: 0x060037B4 RID: 14260 RVA: 0x000158ED File Offset: 0x00013AED
			public static ISteamMatchmakingPingResponse.InternalServerFailedToRespond operator +(ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>();
			}

			// Token: 0x060037B5 RID: 14261 RVA: 0x000158FB File Offset: 0x00013AFB
			public static ISteamMatchmakingPingResponse.InternalServerFailedToRespond operator -(ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingPingResponse.InternalServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x0400327A RID: 12922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400327B RID: 12923
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x0400327C RID: 12924
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x0400327D RID: 12925
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B6 RID: 950
		public class VTable : Object
		{
			// Token: 0x060037B6 RID: 14262 RVA: 0x000E37B8 File Offset: 0x000E19B8
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingPingResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr, "m_VTServerResponded");
				ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr, "m_VTServerFailedToRespond");
				ISteamMatchmakingPingResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr, 100670365);
			}

			// Token: 0x060037B7 RID: 14263 RVA: 0x000E3820 File Offset: 0x000E1A20
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPingResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPingResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037B8 RID: 14264 RVA: 0x0001590C File Offset: 0x00013B0C
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D3F RID: 3391
			// (get) Token: 0x060037B9 RID: 14265 RVA: 0x000E385C File Offset: 0x000E1A5C
			// (set) Token: 0x060037BA RID: 14266 RVA: 0x00015915 File Offset: 0x00013B15
			public unsafe ISteamMatchmakingPingResponse.InternalServerResponded m_VTServerResponded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.InternalServerResponded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D40 RID: 3392
			// (get) Token: 0x060037BB RID: 14267 RVA: 0x000E388C File Offset: 0x000E1A8C
			// (set) Token: 0x060037BC RID: 14268 RVA: 0x00015934 File Offset: 0x00013B34
			public unsafe ISteamMatchmakingPingResponse.InternalServerFailedToRespond m_VTServerFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingPingResponse.InternalServerFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingPingResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400327E RID: 12926
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerResponded;

			// Token: 0x0400327F RID: 12927
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerFailedToRespond;

			// Token: 0x04003280 RID: 12928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
