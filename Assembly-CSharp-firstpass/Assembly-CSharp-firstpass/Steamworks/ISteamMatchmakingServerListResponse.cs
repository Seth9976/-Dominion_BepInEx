using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020002C2 RID: 706
	public class ISteamMatchmakingServerListResponse : Object
	{
		// Token: 0x0600285F RID: 10335 RVA: 0x000AF1E4 File Offset: 0x000AD3E4
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingServerListResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingServerListResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr);
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_ServerResponded");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_ServerFailedToRespond");
			ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_RefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "m_RefreshComplete");
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_RefreshComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100668461);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100668462);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100668463);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100668464);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnRefreshComplete_Private_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100668465);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100668466);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000AF304 File Offset: 0x000AD504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209405, XrefRangeEnd = 209446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingServerListResponse(ISteamMatchmakingServerListResponse.ServerResponded onServerResponded, ISteamMatchmakingServerListResponse.ServerFailedToRespond onServerFailedToRespond, ISteamMatchmakingServerListResponse.RefreshComplete onRefreshComplete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onServerResponded);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onServerFailedToRespond);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRefreshComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_RefreshComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000AF374 File Offset: 0x000AD574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209446, XrefRangeEnd = 209457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000AF3B0 File Offset: 0x000AD5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209457, XrefRangeEnd = 209464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000AF40C File Offset: 0x000AD60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209464, XrefRangeEnd = 209471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000AF468 File Offset: 0x000AD668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209471, XrefRangeEnd = 209478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_InternalOnRefreshComplete_Private_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000AF4C4 File Offset: 0x000AD6C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209480, RefRangeEnd = 209489, XrefRangeStart = 209478, XrefRangeEnd = 209480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000104D6 File Offset: 0x0000E6D6
		public ISteamMatchmakingServerListResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x000AF508 File Offset: 0x000AD708
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x000104DF File Offset: 0x0000E6DF
		public unsafe ISteamMatchmakingServerListResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000AF538 File Offset: 0x000AD738
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x000104FE File Offset: 0x0000E6FE
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x000AF560 File Offset: 0x000AD760
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x00010519 File Offset: 0x0000E719
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x000AF588 File Offset: 0x000AD788
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x00010534 File Offset: 0x0000E734
		public unsafe ISteamMatchmakingServerListResponse.ServerResponded m_ServerResponded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerResponded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.ServerResponded>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x000AF5B8 File Offset: 0x000AD7B8
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x00010553 File Offset: 0x0000E753
		public unsafe ISteamMatchmakingServerListResponse.ServerFailedToRespond m_ServerFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.ServerFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_ServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x000AF5E8 File Offset: 0x000AD7E8
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x00010572 File Offset: 0x0000E772
		public unsafe ISteamMatchmakingServerListResponse.RefreshComplete m_RefreshComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_RefreshComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.RefreshComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.NativeFieldInfoPtr_m_RefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerResponded;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerFailedToRespond;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshComplete;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerResponded_ServerFailedToRespond_RefreshComplete_0;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerResponded_Private_Void_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnServerFailedToRespond_Private_Void_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRefreshComplete_Private_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingServerListResponse_0;

		// Token: 0x020003AB RID: 939
		public sealed class ServerResponded : MulticastDelegate
		{
			// Token: 0x06003753 RID: 14163 RVA: 0x000E23AC File Offset: 0x000E05AC
			// Note: this type is marked as 'beforefieldinit'.
			static ServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "ServerResponded");
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100670324);
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100670325);
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100670326);
				ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr, 100670327);
			}

			// Token: 0x06003754 RID: 14164 RVA: 0x000E2420 File Offset: 0x000E0620
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003755 RID: 14165 RVA: 0x000E247C File Offset: 0x000E067C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209347, RefRangeEnd = 209350, XrefRangeStart = 209342, XrefRangeEnd = 209347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003756 RID: 14166 RVA: 0x000E24C8 File Offset: 0x000E06C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209350, XrefRangeEnd = 209357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003757 RID: 14167 RVA: 0x000E2548 File Offset: 0x000E0748
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003758 RID: 14168 RVA: 0x000156C6 File Offset: 0x000138C6
			public ServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003759 RID: 14169 RVA: 0x000156CF File Offset: 0x000138CF
			public static implicit operator ISteamMatchmakingServerListResponse.ServerResponded(Action<HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.ServerResponded>(A_0);
			}

			// Token: 0x0600375A RID: 14170 RVA: 0x000156D7 File Offset: 0x000138D7
			public static ISteamMatchmakingServerListResponse.ServerResponded operator +(ISteamMatchmakingServerListResponse.ServerResponded A_0, ISteamMatchmakingServerListResponse.ServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.ServerResponded>();
			}

			// Token: 0x0600375B RID: 14171 RVA: 0x000156E5 File Offset: 0x000138E5
			public static ISteamMatchmakingServerListResponse.ServerResponded operator -(ISteamMatchmakingServerListResponse.ServerResponded A_0, ISteamMatchmakingServerListResponse.ServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.ServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x04003252 RID: 12882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003253 RID: 12883
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0;

			// Token: 0x04003254 RID: 12884
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04003255 RID: 12885
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003AC RID: 940
		public sealed class ServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x0600375C RID: 14172 RVA: 0x000E258C File Offset: 0x000E078C
			// Note: this type is marked as 'beforefieldinit'.
			static ServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "ServerFailedToRespond");
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100670328);
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100670329);
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100670330);
				ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr, 100670331);
			}

			// Token: 0x0600375D RID: 14173 RVA: 0x000E2600 File Offset: 0x000E0800
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.ServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600375E RID: 14174 RVA: 0x000E265C File Offset: 0x000E085C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209347, RefRangeEnd = 209350, XrefRangeStart = 209347, XrefRangeEnd = 209350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600375F RID: 14175 RVA: 0x000E26A8 File Offset: 0x000E08A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209357, XrefRangeEnd = 209364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003760 RID: 14176 RVA: 0x000E2728 File Offset: 0x000E0928
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.ServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003761 RID: 14177 RVA: 0x000156F6 File Offset: 0x000138F6
			public ServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003762 RID: 14178 RVA: 0x000156FF File Offset: 0x000138FF
			public static implicit operator ISteamMatchmakingServerListResponse.ServerFailedToRespond(Action<HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.ServerFailedToRespond>(A_0);
			}

			// Token: 0x06003763 RID: 14179 RVA: 0x00015707 File Offset: 0x00013907
			public static ISteamMatchmakingServerListResponse.ServerFailedToRespond operator +(ISteamMatchmakingServerListResponse.ServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.ServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.ServerFailedToRespond>();
			}

			// Token: 0x06003764 RID: 14180 RVA: 0x00015715 File Offset: 0x00013915
			public static ISteamMatchmakingServerListResponse.ServerFailedToRespond operator -(ISteamMatchmakingServerListResponse.ServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.ServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.ServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04003256 RID: 12886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003257 RID: 12887
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_Int32_0;

			// Token: 0x04003258 RID: 12888
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04003259 RID: 12889
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003AD RID: 941
		public sealed class RefreshComplete : MulticastDelegate
		{
			// Token: 0x06003765 RID: 14181 RVA: 0x000E276C File Offset: 0x000E096C
			// Note: this type is marked as 'beforefieldinit'.
			static RefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "RefreshComplete");
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100670332);
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100670333);
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100670334);
				ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr, 100670335);
			}

			// Token: 0x06003766 RID: 14182 RVA: 0x000E27E0 File Offset: 0x000E09E0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.RefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003767 RID: 14183 RVA: 0x000E283C File Offset: 0x000E0A3C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209347, RefRangeEnd = 209350, XrefRangeStart = 209347, XrefRangeEnd = 209350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(HServerListRequest hRequest, EMatchMakingServerResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003768 RID: 14184 RVA: 0x000E2888 File Offset: 0x000E0A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209364, XrefRangeEnd = 209371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hRequest;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003769 RID: 14185 RVA: 0x000E2908 File Offset: 0x000E0B08
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.RefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600376A RID: 14186 RVA: 0x00015726 File Offset: 0x00013926
			public RefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600376B RID: 14187 RVA: 0x0001572F File Offset: 0x0001392F
			public static implicit operator ISteamMatchmakingServerListResponse.RefreshComplete(Action<HServerListRequest, EMatchMakingServerResponse> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.RefreshComplete>(A_0);
			}

			// Token: 0x0600376C RID: 14188 RVA: 0x00015737 File Offset: 0x00013937
			public static ISteamMatchmakingServerListResponse.RefreshComplete operator +(ISteamMatchmakingServerListResponse.RefreshComplete A_0, ISteamMatchmakingServerListResponse.RefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.RefreshComplete>();
			}

			// Token: 0x0600376D RID: 14189 RVA: 0x00015745 File Offset: 0x00013945
			public static ISteamMatchmakingServerListResponse.RefreshComplete operator -(ISteamMatchmakingServerListResponse.RefreshComplete A_0, ISteamMatchmakingServerListResponse.RefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.RefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x0400325A RID: 12890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400325B RID: 12891
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HServerListRequest_EMatchMakingServerResponse_0;

			// Token: 0x0400325C RID: 12892
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0;

			// Token: 0x0400325D RID: 12893
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003AE RID: 942
		public sealed class InternalServerResponded : MulticastDelegate
		{
			// Token: 0x0600376E RID: 14190 RVA: 0x000E294C File Offset: 0x000E0B4C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "InternalServerResponded");
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100670336);
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100670337);
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100670338);
				ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr, 100670339);
			}

			// Token: 0x0600376F RID: 14191 RVA: 0x000E29C0 File Offset: 0x000E0BC0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003770 RID: 14192 RVA: 0x000E2A1C File Offset: 0x000E0C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209371, XrefRangeEnd = 209375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003771 RID: 14193 RVA: 0x000E2A78 File Offset: 0x000E0C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209375, XrefRangeEnd = 209385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003772 RID: 14194 RVA: 0x000E2B08 File Offset: 0x000E0D08
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003773 RID: 14195 RVA: 0x00015756 File Offset: 0x00013956
			public InternalServerResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003774 RID: 14196 RVA: 0x0001575F File Offset: 0x0001395F
			public static implicit operator ISteamMatchmakingServerListResponse.InternalServerResponded(Action<IntPtr, HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.InternalServerResponded>(A_0);
			}

			// Token: 0x06003775 RID: 14197 RVA: 0x00015767 File Offset: 0x00013967
			public static ISteamMatchmakingServerListResponse.InternalServerResponded operator +(ISteamMatchmakingServerListResponse.InternalServerResponded A_0, ISteamMatchmakingServerListResponse.InternalServerResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.InternalServerResponded>();
			}

			// Token: 0x06003776 RID: 14198 RVA: 0x00015775 File Offset: 0x00013975
			public static ISteamMatchmakingServerListResponse.InternalServerResponded operator -(ISteamMatchmakingServerListResponse.InternalServerResponded A_0, ISteamMatchmakingServerListResponse.InternalServerResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.InternalServerResponded>();
				}
				return delegate2;
			}

			// Token: 0x0400325E RID: 12894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400325F RID: 12895
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0;

			// Token: 0x04003260 RID: 12896
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04003261 RID: 12897
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003AF RID: 943
		public sealed class InternalServerFailedToRespond : MulticastDelegate
		{
			// Token: 0x06003777 RID: 14199 RVA: 0x000E2B4C File Offset: 0x000E0D4C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalServerFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "InternalServerFailedToRespond");
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670340);
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670341);
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670342);
				ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr, 100670343);
			}

			// Token: 0x06003778 RID: 14200 RVA: 0x000E2BC0 File Offset: 0x000E0DC0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalServerFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003779 RID: 14201 RVA: 0x000E2C1C File Offset: 0x000E0E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600377A RID: 14202 RVA: 0x000E2C78 File Offset: 0x000E0E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209385, XrefRangeEnd = 209395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600377B RID: 14203 RVA: 0x000E2D08 File Offset: 0x000E0F08
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600377C RID: 14204 RVA: 0x00015786 File Offset: 0x00013986
			public InternalServerFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600377D RID: 14205 RVA: 0x0001578F File Offset: 0x0001398F
			public static implicit operator ISteamMatchmakingServerListResponse.InternalServerFailedToRespond(Action<IntPtr, HServerListRequest, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>(A_0);
			}

			// Token: 0x0600377E RID: 14206 RVA: 0x00015797 File Offset: 0x00013997
			public static ISteamMatchmakingServerListResponse.InternalServerFailedToRespond operator +(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>();
			}

			// Token: 0x0600377F RID: 14207 RVA: 0x000157A5 File Offset: 0x000139A5
			public static ISteamMatchmakingServerListResponse.InternalServerFailedToRespond operator -(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_0, ISteamMatchmakingServerListResponse.InternalServerFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04003262 RID: 12898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003263 RID: 12899
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_Int32_0;

			// Token: 0x04003264 RID: 12900
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_Int32_AsyncCallback_Object_0;

			// Token: 0x04003265 RID: 12901
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B0 RID: 944
		public sealed class InternalRefreshComplete : MulticastDelegate
		{
			// Token: 0x06003780 RID: 14208 RVA: 0x000E2D4C File Offset: 0x000E0F4C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "InternalRefreshComplete");
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100670344);
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100670345);
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100670346);
				ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr, 100670347);
			}

			// Token: 0x06003781 RID: 14209 RVA: 0x000E2DC0 File Offset: 0x000E0FC0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.InternalRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003782 RID: 14210 RVA: 0x000E2E1C File Offset: 0x000E101C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003783 RID: 14211 RVA: 0x000E2E78 File Offset: 0x000E1078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209395, XrefRangeEnd = 209405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003784 RID: 14212 RVA: 0x000E2F08 File Offset: 0x000E1108
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.InternalRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003785 RID: 14213 RVA: 0x000157B6 File Offset: 0x000139B6
			public InternalRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003786 RID: 14214 RVA: 0x000157BF File Offset: 0x000139BF
			public static implicit operator ISteamMatchmakingServerListResponse.InternalRefreshComplete(Action<IntPtr, HServerListRequest, EMatchMakingServerResponse> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingServerListResponse.InternalRefreshComplete>(A_0);
			}

			// Token: 0x06003787 RID: 14215 RVA: 0x000157C7 File Offset: 0x000139C7
			public static ISteamMatchmakingServerListResponse.InternalRefreshComplete operator +(ISteamMatchmakingServerListResponse.InternalRefreshComplete A_0, ISteamMatchmakingServerListResponse.InternalRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingServerListResponse.InternalRefreshComplete>();
			}

			// Token: 0x06003788 RID: 14216 RVA: 0x000157D5 File Offset: 0x000139D5
			public static ISteamMatchmakingServerListResponse.InternalRefreshComplete operator -(ISteamMatchmakingServerListResponse.InternalRefreshComplete A_0, ISteamMatchmakingServerListResponse.InternalRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingServerListResponse.InternalRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04003266 RID: 12902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003267 RID: 12903
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_HServerListRequest_EMatchMakingServerResponse_0;

			// Token: 0x04003268 RID: 12904
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_HServerListRequest_EMatchMakingServerResponse_AsyncCallback_Object_0;

			// Token: 0x04003269 RID: 12905
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003B1 RID: 945
		public class VTable : Object
		{
			// Token: 0x06003789 RID: 14217 RVA: 0x000E2F4C File Offset: 0x000E114C
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, "m_VTServerResponded");
				ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, "m_VTServerFailedToRespond");
				ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, "m_VTRefreshComplete");
				ISteamMatchmakingServerListResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr, 100670348);
			}

			// Token: 0x0600378A RID: 14218 RVA: 0x000E2FC8 File Offset: 0x000E11C8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600378B RID: 14219 RVA: 0x000157E6 File Offset: 0x000139E6
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D3C RID: 3388
			// (get) Token: 0x0600378C RID: 14220 RVA: 0x000E3004 File Offset: 0x000E1204
			// (set) Token: 0x0600378D RID: 14221 RVA: 0x000157EF File Offset: 0x000139EF
			public unsafe ISteamMatchmakingServerListResponse.InternalServerResponded m_VTServerResponded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.InternalServerResponded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3D RID: 3389
			// (get) Token: 0x0600378E RID: 14222 RVA: 0x000E3034 File Offset: 0x000E1234
			// (set) Token: 0x0600378F RID: 14223 RVA: 0x0001580E File Offset: 0x00013A0E
			public unsafe ISteamMatchmakingServerListResponse.InternalServerFailedToRespond m_VTServerFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.InternalServerFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTServerFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3E RID: 3390
			// (get) Token: 0x06003790 RID: 14224 RVA: 0x000E3064 File Offset: 0x000E1264
			// (set) Token: 0x06003791 RID: 14225 RVA: 0x0001582D File Offset: 0x00013A2D
			public unsafe ISteamMatchmakingServerListResponse.InternalRefreshComplete m_VTRefreshComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTRefreshComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServerListResponse.InternalRefreshComplete>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingServerListResponse.VTable.NativeFieldInfoPtr_m_VTRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400326A RID: 12906
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerResponded;

			// Token: 0x0400326B RID: 12907
			private static readonly IntPtr NativeFieldInfoPtr_m_VTServerFailedToRespond;

			// Token: 0x0400326C RID: 12908
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRefreshComplete;

			// Token: 0x0400326D RID: 12909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
