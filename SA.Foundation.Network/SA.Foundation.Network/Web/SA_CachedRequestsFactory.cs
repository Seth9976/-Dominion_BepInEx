using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace SA.Foundation.Network.Web
{
	// Token: 0x02000002 RID: 2
	public static class SA_CachedRequestsFactory : global::Il2CppSystem.Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000021A0 File Offset: 0x000003A0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_CachedRequestsFactory()
		{
			Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Network.dll", "SA.Foundation.Network.Web", "SA_CachedRequestsFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr);
			SA_CachedRequestsFactory.NativeFieldInfoPtr_m_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, "m_cache");
			SA_CachedRequestsFactory.NativeFieldInfoPtr_m_thumbnailLoadQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, "m_thumbnailLoadQueue");
			SA_CachedRequestsFactory.NativeMethodInfoPtr_Get_Public_Static_Void_String_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, 100663297);
			SA_CachedRequestsFactory.NativeMethodInfoPtr_GetTexture2D_Public_Static_Void_String_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, 100663298);
			SA_CachedRequestsFactory.NativeMethodInfoPtr_GetAudioClip_Public_Static_Void_String_Action_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, 100663299);
			SA_CachedRequestsFactory.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, 100663300);
			SA_CachedRequestsFactory.NativeMethodInfoPtr_SendRequest_Private_Static_Void_UnityWebRequest_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, 100663301);
			SA_CachedRequestsFactory.NativeMethodInfoPtr_SendRequestCorutine_Private_Static_IEnumerator_UnityWebRequest_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002270 File Offset: 0x00000470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158501, RefRangeEnd = 158503, XrefRangeStart = 158462, XrefRangeEnd = 158501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Get(string uri, Action<UnityWebRequest> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.NativeMethodInfoPtr_Get_Public_Static_Void_String_Action_1_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000022B8 File Offset: 0x000004B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158503, XrefRangeEnd = 158520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTexture2D(string uri, Action<Texture2D> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.NativeMethodInfoPtr_GetTexture2D_Public_Static_Void_String_Action_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002300 File Offset: 0x00000500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158520, XrefRangeEnd = 158537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAudioClip(string uri, Action<AudioClip> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.NativeMethodInfoPtr_GetAudioClip_Public_Static_Void_String_Action_1_AudioClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002348 File Offset: 0x00000548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158537, XrefRangeEnd = 158545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002370 File Offset: 0x00000570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158598, RefRangeEnd = 158599, XrefRangeStart = 158545, XrefRangeEnd = 158598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendRequest(UnityWebRequest request, Action<UnityWebRequest> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.NativeMethodInfoPtr_SendRequest_Private_Static_Void_UnityWebRequest_Action_1_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023B8 File Offset: 0x000005B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158599, XrefRangeEnd = 158603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator SendRequestCorutine(UnityWebRequest request, Action<UnityWebRequest> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.NativeMethodInfoPtr_SendRequestCorutine_Private_Static_IEnumerator_UnityWebRequest_Action_1_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		public SA_CachedRequestsFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002410 File Offset: 0x00000610
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static Dictionary<string, UnityWebRequest> m_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_CachedRequestsFactory.NativeFieldInfoPtr_m_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UnityWebRequest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_CachedRequestsFactory.NativeFieldInfoPtr_m_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002438 File Offset: 0x00000638
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static Dictionary<string, List<Action<UnityWebRequest>>> m_thumbnailLoadQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_CachedRequestsFactory.NativeFieldInfoPtr_m_thumbnailLoadQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<Action<UnityWebRequest>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_CachedRequestsFactory.NativeFieldInfoPtr_m_thumbnailLoadQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_cache;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_thumbnailLoadQueue;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Void_String_Action_1_UnityWebRequest_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture2D_Public_Static_Void_String_Action_1_Texture2D_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_GetAudioClip_Public_Static_Void_String_Action_1_AudioClip_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Private_Static_Void_UnityWebRequest_Action_1_UnityWebRequest_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_SendRequestCorutine_Private_Static_IEnumerator_UnityWebRequest_Action_1_UnityWebRequest_0;

		// Token: 0x02000003 RID: 3
		[ObfuscatedName("SA.Foundation.Network.Web.SA_CachedRequestsFactory+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600000D RID: 13 RVA: 0x00002460 File Offset: 0x00000660
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass2_0>.NativeClassPtr);
				SA_CachedRequestsFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass2_0>.NativeClassPtr, "request");
				SA_CachedRequestsFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass2_0>.NativeClassPtr, 100663304);
				SA_CachedRequestsFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass2_0>.NativeClassPtr, 100663305);
			}

			// Token: 0x0600000E RID: 14 RVA: 0x000024C8 File Offset: 0x000006C8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002504 File Offset: 0x00000704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158395, XrefRangeEnd = 158425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Get_b__0(UnityWebRequest requestResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000011 RID: 17 RVA: 0x00002548 File Offset: 0x00000748
			// (set) Token: 0x06000012 RID: 18 RVA: 0x00002086 File Offset: 0x00000286
			public unsafe UnityWebRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000009 RID: 9
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x0400000A RID: 10
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400000B RID: 11
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000004 RID: 4
		[ObfuscatedName("SA.Foundation.Network.Web.SA_CachedRequestsFactory+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000013 RID: 19 RVA: 0x00002578 File Offset: 0x00000778
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass3_0>.NativeClassPtr);
				SA_CachedRequestsFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass3_0>.NativeClassPtr, "callback");
				SA_CachedRequestsFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass3_0>.NativeClassPtr, 100663306);
				SA_CachedRequestsFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__GetTexture2D_b__0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass3_0>.NativeClassPtr, 100663307);
			}

			// Token: 0x06000014 RID: 20 RVA: 0x000025E0 File Offset: 0x000007E0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000015 RID: 21 RVA: 0x0000261C File Offset: 0x0000081C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158425, XrefRangeEnd = 158438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetTexture2D_b__0(UnityWebRequest unityWebRequest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityWebRequest);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__GetTexture2D_b__0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000016 RID: 22 RVA: 0x000020A5 File Offset: 0x000002A5
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000017 RID: 23 RVA: 0x00002660 File Offset: 0x00000860
			// (set) Token: 0x06000018 RID: 24 RVA: 0x000020AE File Offset: 0x000002AE
			public unsafe Action<Texture2D> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400000C RID: 12
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400000D RID: 13
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400000E RID: 14
			private static readonly IntPtr NativeMethodInfoPtr__GetTexture2D_b__0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000005 RID: 5
		[ObfuscatedName("SA.Foundation.Network.Web.SA_CachedRequestsFactory+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000019 RID: 25 RVA: 0x00002690 File Offset: 0x00000890
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass4_0>.NativeClassPtr);
				SA_CachedRequestsFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass4_0>.NativeClassPtr, "callback");
				SA_CachedRequestsFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass4_0>.NativeClassPtr, 100663308);
				SA_CachedRequestsFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__GetAudioClip_b__0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass4_0>.NativeClassPtr, 100663309);
			}

			// Token: 0x0600001A RID: 26 RVA: 0x000026F8 File Offset: 0x000008F8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00002734 File Offset: 0x00000934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158438, XrefRangeEnd = 158443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAudioClip_b__0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__GetAudioClip_b__0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600001C RID: 28 RVA: 0x000020CD File Offset: 0x000002CD
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600001D RID: 29 RVA: 0x00002778 File Offset: 0x00000978
			// (set) Token: 0x0600001E RID: 30 RVA: 0x000020D6 File Offset: 0x000002D6
			public unsafe Action<AudioClip> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400000F RID: 15
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000010 RID: 16
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000011 RID: 17
			private static readonly IntPtr NativeMethodInfoPtr__GetAudioClip_b__0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000006 RID: 6
		[ObfuscatedName("SA.Foundation.Network.Web.SA_CachedRequestsFactory+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600001F RID: 31 RVA: 0x000027A8 File Offset: 0x000009A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass6_0>.NativeClassPtr);
				SA_CachedRequestsFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass6_0>.NativeClassPtr, "callback");
				SA_CachedRequestsFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass6_0>.NativeClassPtr, 100663310);
				SA_CachedRequestsFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__SendRequest_b__0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass6_0>.NativeClassPtr, 100663311);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00002810 File Offset: 0x00000A10
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_CachedRequestsFactory.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000021 RID: 33 RVA: 0x0000284C File Offset: 0x00000A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158443, XrefRangeEnd = 158455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendRequest_b__0(UnityWebRequest result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__SendRequest_b__0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000022 RID: 34 RVA: 0x000020F5 File Offset: 0x000002F5
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000023 RID: 35 RVA: 0x00002890 File Offset: 0x00000A90
			// (set) Token: 0x06000024 RID: 36 RVA: 0x000020FE File Offset: 0x000002FE
			public unsafe Action<UnityWebRequest> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000012 RID: 18
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000013 RID: 19
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000014 RID: 20
			private static readonly IntPtr NativeMethodInfoPtr__SendRequest_b__0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000007 RID: 7
		[ObfuscatedName("SA.Foundation.Network.Web.SA_CachedRequestsFactory+<SendRequestCorutine>d__7")]
		public sealed class _SendRequestCorutine_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06000025 RID: 37 RVA: 0x000028C0 File Offset: 0x00000AC0
			// Note: this type is marked as 'beforefieldinit'.
			static _SendRequestCorutine_d__7()
			{
				Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_CachedRequestsFactory>.NativeClassPtr, "<SendRequestCorutine>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr);
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, "<>1__state");
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, "<>2__current");
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, "request");
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, "callback");
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, 100663312);
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, 100663313);
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, 100663314);
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, 100663315);
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, 100663316);
				SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr, 100663317);
			}

			// Token: 0x06000026 RID: 38 RVA: 0x000029B4 File Offset: 0x00000BB4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendRequestCorutine_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_CachedRequestsFactory._SendRequestCorutine_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000027 RID: 39 RVA: 0x000029FC File Offset: 0x00000BFC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002A30 File Offset: 0x00000C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158455, XrefRangeEnd = 158457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000029 RID: 41 RVA: 0x00002A6C File Offset: 0x00000C6C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00002AAC File Offset: 0x00000CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158457, XrefRangeEnd = 158462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600002B RID: 43 RVA: 0x00002AE0 File Offset: 0x00000CE0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x0000211D File Offset: 0x0000031D
			public _SendRequestCorutine_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00002B20 File Offset: 0x00000D20
			// (set) Token: 0x0600002E RID: 46 RVA: 0x00002126 File Offset: 0x00000326
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600002F RID: 47 RVA: 0x00002B48 File Offset: 0x00000D48
			// (set) Token: 0x06000030 RID: 48 RVA: 0x00002141 File Offset: 0x00000341
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00002B78 File Offset: 0x00000D78
			// (set) Token: 0x06000032 RID: 50 RVA: 0x00002160 File Offset: 0x00000360
			public unsafe UnityWebRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00002BA8 File Offset: 0x00000DA8
			// (set) Token: 0x06000034 RID: 52 RVA: 0x0000217F File Offset: 0x0000037F
			public unsafe Action<UnityWebRequest> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_CachedRequestsFactory._SendRequestCorutine_d__7.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000015 RID: 21
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000016 RID: 22
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000017 RID: 23
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000018 RID: 24
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000019 RID: 25
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400001A RID: 26
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400001B RID: 27
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400001C RID: 28
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400001D RID: 29
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400001E RID: 30
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
