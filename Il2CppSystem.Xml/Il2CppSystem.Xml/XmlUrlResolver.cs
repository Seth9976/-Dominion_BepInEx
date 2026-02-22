using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000067 RID: 103
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x0002C614 File Offset: 0x0002A814
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUrlResolver()
		{
			Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlUrlResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr);
			XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "s_DownloadManager");
			XmlUrlResolver.NativeFieldInfoPtr__credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_credentials");
			XmlUrlResolver.NativeFieldInfoPtr__proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_proxy");
			XmlUrlResolver.NativeFieldInfoPtr__cachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_cachePolicy");
			XmlUrlResolver.NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100664638);
			XmlUrlResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100664639);
			XmlUrlResolver.NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100664640);
			XmlUrlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100664641);
			XmlUrlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100664642);
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
		public unsafe static XmlDownloadManager DownloadManager
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21169, RefRangeEnd = 21171, XrefRangeStart = 21159, XrefRangeEnd = 21169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver.NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDownloadManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0002C72C File Offset: 0x0002A92C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUrlResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0002C768 File Offset: 0x0002A968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21171, XrefRangeEnd = 21189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21189, XrefRangeEnd = 21190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0002C858 File Offset: 0x0002AA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21190, XrefRangeEnd = 21202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0000496E File Offset: 0x00002B6E
		public XmlUrlResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00004977 File Offset: 0x00002B77
		public unsafe static Object s_DownloadManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0002C900 File Offset: 0x0002AB00
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00004989 File Offset: 0x00002B89
		public unsafe ICredentials _credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0002C930 File Offset: 0x0002AB30
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x000049A8 File Offset: 0x00002BA8
		public unsafe IWebProxy _proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0002C960 File Offset: 0x0002AB60
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x000049C7 File Offset: 0x00002BC7
		public unsafe RequestCachePolicy _cachePolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__cachePolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__cachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_s_DownloadManager;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr__credentials;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeFieldInfoPtr__proxy;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr__cachePolicy;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0;

		// Token: 0x0200012D RID: 301
		[ObfuscatedName("System.Xml.XmlUrlResolver+<GetEntityAsync>d__15")]
		public sealed class _GetEntityAsync_d__15 : ValueType
		{
			// Token: 0x06001298 RID: 4760 RVA: 0x000552FC File Offset: 0x000534FC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEntityAsync_d__15()
			{
				Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "<GetEntityAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr);
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>1__state");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>t__builder");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "ofObjectToReturn");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "absoluteUri");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>4__this");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>u__1");
				XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, 100664643);
				XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, 100664644);
			}

			// Token: 0x06001299 RID: 4761 RVA: 0x000553C8 File Offset: 0x000535C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21123, XrefRangeEnd = 21156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600129A RID: 4762 RVA: 0x00055400 File Offset: 0x00053600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21156, XrefRangeEnd = 21159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600129B RID: 4763 RVA: 0x000084B8 File Offset: 0x000066B8
			public _GetEntityAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600129C RID: 4764 RVA: 0x000084C1 File Offset: 0x000066C1
			public _GetEntityAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x0600129D RID: 4765 RVA: 0x00055448 File Offset: 0x00053648
			// (set) Token: 0x0600129E RID: 4766 RVA: 0x000084D3 File Offset: 0x000066D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x0600129F RID: 4767 RVA: 0x00055470 File Offset: 0x00053670
			// (set) Token: 0x060012A0 RID: 4768 RVA: 0x000084EE File Offset: 0x000066EE
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000554A0 File Offset: 0x000536A0
			// (set) Token: 0x060012A2 RID: 4770 RVA: 0x0000851C File Offset: 0x0000671C
			public unsafe Type ofObjectToReturn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x060012A3 RID: 4771 RVA: 0x000554D0 File Offset: 0x000536D0
			// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0000853B File Offset: 0x0000673B
			public unsafe Uri absoluteUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00055500 File Offset: 0x00053700
			// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0000855A File Offset: 0x0000675A
			public unsafe XmlUrlResolver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlUrlResolver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00055530 File Offset: 0x00053730
			// (set) Token: 0x060012A8 RID: 4776 RVA: 0x00008579 File Offset: 0x00006779
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000EA3 RID: 3747
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EA4 RID: 3748
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000EA5 RID: 3749
			private static readonly IntPtr NativeFieldInfoPtr_ofObjectToReturn;

			// Token: 0x04000EA6 RID: 3750
			private static readonly IntPtr NativeFieldInfoPtr_absoluteUri;

			// Token: 0x04000EA7 RID: 3751
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000EA8 RID: 3752
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000EA9 RID: 3753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EAA RID: 3754
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
