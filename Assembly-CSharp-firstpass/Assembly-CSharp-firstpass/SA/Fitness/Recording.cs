using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

namespace SA.Fitness
{
	// Token: 0x0200032A RID: 810
	public sealed class Recording : Singleton<Recording>
	{
		// Token: 0x06002FB8 RID: 12216 RVA: 0x000CBA78 File Offset: 0x000C9C78
		// Note: this type is marked as 'beforefieldinit'.
		static Recording()
		{
			Il2CppClassPointerStore<Recording>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Recording");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recording>.NativeClassPtr);
			Recording.NativeFieldInfoPtr_subscriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recording>.NativeClassPtr, "subscriptions");
			Recording.NativeFieldInfoPtr_unsubs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recording>.NativeClassPtr, "unsubs");
			Recording.NativeFieldInfoPtr_subsRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recording>.NativeClassPtr, "subsRequests");
			Recording.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669616);
			Recording.NativeMethodInfoPtr_Subscribe_Public_Void_SubscribeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669617);
			Recording.NativeMethodInfoPtr_ListSubscriptions_Public_Void_SubscriptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669618);
			Recording.NativeMethodInfoPtr_Unsubscribe_Public_Void_UnsubscribeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669619);
			Recording.NativeMethodInfoPtr_SubscribeResultListener_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669620);
			Recording.NativeMethodInfoPtr_ListSubsResultListener_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669621);
			Recording.NativeMethodInfoPtr_UnsubResultListener_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669622);
			Recording.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recording>.NativeClassPtr, 100669623);
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x000CBB84 File Offset: 0x000C9D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220843, XrefRangeEnd = 220848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x000CBBB8 File Offset: 0x000C9DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220874, RefRangeEnd = 220875, XrefRangeStart = 220848, XrefRangeEnd = 220874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe(SubscribeRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr_Subscribe_Public_Void_SubscribeRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x000CBBFC File Offset: 0x000C9DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220904, RefRangeEnd = 220905, XrefRangeStart = 220875, XrefRangeEnd = 220904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListSubscriptions(SubscriptionsRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr_ListSubscriptions_Public_Void_SubscriptionsRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x000CBC40 File Offset: 0x000C9E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220931, RefRangeEnd = 220932, XrefRangeStart = 220905, XrefRangeEnd = 220931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unsubscribe(UnsubscribeRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr_Unsubscribe_Public_Void_UnsubscribeRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000CBC84 File Offset: 0x000C9E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220932, XrefRangeEnd = 220972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeResultListener(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr_SubscribeResultListener_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x000CBCC8 File Offset: 0x000C9EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220972, XrefRangeEnd = 220995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListSubsResultListener(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr_ListSubsResultListener_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x000CBD0C File Offset: 0x000C9F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220995, XrefRangeEnd = 221035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubResultListener(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr_UnsubResultListener_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x000CBD50 File Offset: 0x000C9F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221035, XrefRangeEnd = 221059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recording()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recording>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recording.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00012360 File Offset: 0x00010560
		public Recording(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002FC2 RID: 12226 RVA: 0x000CBD8C File Offset: 0x000C9F8C
		// (set) Token: 0x06002FC3 RID: 12227 RVA: 0x00012369 File Offset: 0x00010569
		public unsafe Dictionary<int, SubscribeRequest> subscriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recording.NativeFieldInfoPtr_subscriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SubscribeRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recording.NativeFieldInfoPtr_subscriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002FC4 RID: 12228 RVA: 0x000CBDBC File Offset: 0x000C9FBC
		// (set) Token: 0x06002FC5 RID: 12229 RVA: 0x00012388 File Offset: 0x00010588
		public unsafe Dictionary<int, UnsubscribeRequest> unsubs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recording.NativeFieldInfoPtr_unsubs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, UnsubscribeRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recording.NativeFieldInfoPtr_unsubs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x000CBDEC File Offset: 0x000C9FEC
		// (set) Token: 0x06002FC7 RID: 12231 RVA: 0x000123A7 File Offset: 0x000105A7
		public unsafe Dictionary<int, SubscriptionsRequest> subsRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recording.NativeFieldInfoPtr_subsRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SubscriptionsRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recording.NativeFieldInfoPtr_subsRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeFieldInfoPtr_subscriptions;

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeFieldInfoPtr_unsubs;

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeFieldInfoPtr_subsRequests;

		// Token: 0x04002D95 RID: 11669
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002D96 RID: 11670
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Void_SubscribeRequest_0;

		// Token: 0x04002D97 RID: 11671
		private static readonly IntPtr NativeMethodInfoPtr_ListSubscriptions_Public_Void_SubscriptionsRequest_0;

		// Token: 0x04002D98 RID: 11672
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Void_UnsubscribeRequest_0;

		// Token: 0x04002D99 RID: 11673
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeResultListener_Private_Void_String_0;

		// Token: 0x04002D9A RID: 11674
		private static readonly IntPtr NativeMethodInfoPtr_ListSubsResultListener_Private_Void_String_0;

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeMethodInfoPtr_UnsubResultListener_Private_Void_String_0;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
