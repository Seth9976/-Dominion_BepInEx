using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000051 RID: 81
	public class XmlDownloadManager : Object
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x00027E8C File Offset: 0x0002608C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDownloadManager()
		{
			Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDownloadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr);
			XmlDownloadManager.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "connections");
			XmlDownloadManager.NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100664494);
			XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100664495);
			XmlDownloadManager.NativeMethodInfoPtr_Remove_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100664496);
			XmlDownloadManager.NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100664497);
			XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100664498);
			XmlDownloadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100664499);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00027F48 File Offset: 0x00026148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20372, RefRangeEnd = 20373, XrefRangeStart = 20366, XrefRangeEnd = 20372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00027FD0 File Offset: 0x000261D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20405, RefRangeEnd = 20406, XrefRangeStart = 20373, XrefRangeEnd = 20405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00028058 File Offset: 0x00026258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20411, RefRangeEnd = 20413, XrefRangeStart = 20406, XrefRangeEnd = 20411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_Remove_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0002809C File Offset: 0x0002629C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20438, RefRangeEnd = 20439, XrefRangeStart = 20413, XrefRangeEnd = 20438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00028124 File Offset: 0x00026324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20439, XrefRangeEnd = 20451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000281AC File Offset: 0x000263AC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDownloadManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00004551 File Offset: 0x00002751
		public XmlDownloadManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000281E8 File Offset: 0x000263E8
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0000455A File Offset: 0x0000275A
		public unsafe Hashtable connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_String_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000129 RID: 297
		[ObfuscatedName("System.Xml.XmlDownloadManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001268 RID: 4712 RVA: 0x00054C48 File Offset: 0x00052E48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr);
				XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, "uri");
				XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, 100664500);
				XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, 100664501);
			}

			// Token: 0x06001269 RID: 4713 RVA: 0x00054CB0 File Offset: 0x00052EB0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600126A RID: 4714 RVA: 0x00054CEC File Offset: 0x00052EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20281, XrefRangeEnd = 20286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stream _GetStreamAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}

			// Token: 0x0600126B RID: 4715 RVA: 0x00008247 File Offset: 0x00006447
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x0600126C RID: 4716 RVA: 0x00054D2C File Offset: 0x00052F2C
			// (set) Token: 0x0600126D RID: 4717 RVA: 0x00008250 File Offset: 0x00006450
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E8E RID: 3726
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x04000E8F RID: 3727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E90 RID: 3728
			private static readonly IntPtr NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0;
		}

		// Token: 0x0200012A RID: 298
		[ObfuscatedName("System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5")]
		public sealed class _GetNonFileStreamAsync_d__5 : ValueType
		{
			// Token: 0x0600126E RID: 4718 RVA: 0x00054D5C File Offset: 0x00052F5C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetNonFileStreamAsync_d__5()
			{
				Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "<GetNonFileStreamAsync>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr);
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>1__state");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>t__builder");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "uri");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "credentials");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "proxy");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "cachePolicy");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<req>5__1");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>4__this");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>u__1");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, 100664502);
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, 100664503);
			}

			// Token: 0x0600126F RID: 4719 RVA: 0x00054E64 File Offset: 0x00053064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20286, XrefRangeEnd = 20363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001270 RID: 4720 RVA: 0x00054E9C File Offset: 0x0005309C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20363, XrefRangeEnd = 20366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001271 RID: 4721 RVA: 0x0000826F File Offset: 0x0000646F
			public _GetNonFileStreamAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001272 RID: 4722 RVA: 0x00008278 File Offset: 0x00006478
			public _GetNonFileStreamAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x06001273 RID: 4723 RVA: 0x00054EE4 File Offset: 0x000530E4
			// (set) Token: 0x06001274 RID: 4724 RVA: 0x0000828A File Offset: 0x0000648A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x06001275 RID: 4725 RVA: 0x00054F0C File Offset: 0x0005310C
			// (set) Token: 0x06001276 RID: 4726 RVA: 0x000082A5 File Offset: 0x000064A5
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x06001277 RID: 4727 RVA: 0x00054F3C File Offset: 0x0005313C
			// (set) Token: 0x06001278 RID: 4728 RVA: 0x000082D3 File Offset: 0x000064D3
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x06001279 RID: 4729 RVA: 0x00054F6C File Offset: 0x0005316C
			// (set) Token: 0x0600127A RID: 4730 RVA: 0x000082F2 File Offset: 0x000064F2
			public unsafe ICredentials credentials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x0600127B RID: 4731 RVA: 0x00054F9C File Offset: 0x0005319C
			// (set) Token: 0x0600127C RID: 4732 RVA: 0x00008311 File Offset: 0x00006511
			public unsafe IWebProxy proxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x0600127D RID: 4733 RVA: 0x00054FCC File Offset: 0x000531CC
			// (set) Token: 0x0600127E RID: 4734 RVA: 0x00008330 File Offset: 0x00006530
			public unsafe RequestCachePolicy cachePolicy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x0600127F RID: 4735 RVA: 0x00054FFC File Offset: 0x000531FC
			// (set) Token: 0x06001280 RID: 4736 RVA: 0x0000834F File Offset: 0x0000654F
			public unsafe WebRequest _req_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x06001281 RID: 4737 RVA: 0x0005502C File Offset: 0x0005322C
			// (set) Token: 0x06001282 RID: 4738 RVA: 0x0000836E File Offset: 0x0000656E
			public unsafe XmlDownloadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDownloadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x06001283 RID: 4739 RVA: 0x0005505C File Offset: 0x0005325C
			// (set) Token: 0x06001284 RID: 4740 RVA: 0x0000838D File Offset: 0x0000658D
			public ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000E91 RID: 3729
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E92 RID: 3730
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000E93 RID: 3731
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x04000E94 RID: 3732
			private static readonly IntPtr NativeFieldInfoPtr_credentials;

			// Token: 0x04000E95 RID: 3733
			private static readonly IntPtr NativeFieldInfoPtr_proxy;

			// Token: 0x04000E96 RID: 3734
			private static readonly IntPtr NativeFieldInfoPtr_cachePolicy;

			// Token: 0x04000E97 RID: 3735
			private static readonly IntPtr NativeFieldInfoPtr__req_5__1;

			// Token: 0x04000E98 RID: 3736
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000E99 RID: 3737
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000E9A RID: 3738
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E9B RID: 3739
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
