using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000391 RID: 913
	public class Identity : Object
	{
		// Token: 0x06003B42 RID: 15170 RVA: 0x00117F18 File Offset: 0x00116118
		// Note: this type is marked as 'beforefieldinit'.
		static Identity()
		{
			Il2CppClassPointerStore<Identity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "Identity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Identity>.NativeClassPtr);
			Identity.NativeFieldInfoPtr__objectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_objectUri");
			Identity.NativeFieldInfoPtr__channelSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_channelSink");
			Identity.NativeFieldInfoPtr__envoySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_envoySink");
			Identity.NativeFieldInfoPtr__clientDynamicProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_clientDynamicProperties");
			Identity.NativeFieldInfoPtr__serverDynamicProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_serverDynamicProperties");
			Identity.NativeFieldInfoPtr__objRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_objRef");
			Identity.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_disposed");
			Identity.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672059);
			Identity.NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672060);
			Identity.NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672061);
			Identity.NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672062);
			Identity.NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672063);
			Identity.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672064);
			Identity.NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672065);
			Identity.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672066);
			Identity.NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672067);
			Identity.NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672068);
			Identity.NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672069);
			Identity.NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672070);
			Identity.NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672071);
			Identity.NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672072);
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x001180EC File Offset: 0x001162EC
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Identity(string objectUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Identity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00118138 File Offset: 0x00116338
		[CallerCount(0)]
		public unsafe virtual ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Identity.NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x00118194 File Offset: 0x00116394
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x001181D4 File Offset: 0x001163D4
		public unsafe IMessageSink ChannelSink
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06003B47 RID: 15175 RVA: 0x00118218 File Offset: 0x00116418
		public unsafe IMessageSink EnvoySink
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00118258 File Offset: 0x00116458
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x00118290 File Offset: 0x00116490
		public unsafe string ObjectUri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x001182D4 File Offset: 0x001164D4
		public unsafe bool IsConnected
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348766, RefRangeEnd = 348768, XrefRangeStart = 348766, XrefRangeEnd = 348766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x00118310 File Offset: 0x00116510
		// (set) Token: 0x06003B4C RID: 15180 RVA: 0x0011834C File Offset: 0x0011654C
		public unsafe bool Disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x0011838C File Offset: 0x0011658C
		public unsafe DynamicPropertyCollection ClientDynamicProperties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348772, RefRangeEnd = 348774, XrefRangeStart = 348768, XrefRangeEnd = 348772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x001183CC File Offset: 0x001165CC
		public unsafe bool HasServerDynamicSinks
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348774, RefRangeEnd = 348775, XrefRangeStart = 348774, XrefRangeEnd = 348774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00118408 File Offset: 0x00116608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348775, XrefRangeEnd = 348777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00118474 File Offset: 0x00116674
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 348779, RefRangeEnd = 348784, XrefRangeStart = 348777, XrefRangeEnd = 348779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00016501 File Offset: 0x00014701
		public Identity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x001184E0 File Offset: 0x001166E0
		// (set) Token: 0x06003B53 RID: 15187 RVA: 0x0001650A File Offset: 0x0001470A
		public unsafe string _objectUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objectUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objectUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x00118508 File Offset: 0x00116708
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x00016529 File Offset: 0x00014729
		public unsafe IMessageSink _channelSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__channelSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__channelSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x00118538 File Offset: 0x00116738
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x00016548 File Offset: 0x00014748
		public unsafe IMessageSink _envoySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__envoySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__envoySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x00118568 File Offset: 0x00116768
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x00016567 File Offset: 0x00014767
		public unsafe DynamicPropertyCollection _clientDynamicProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__clientDynamicProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__clientDynamicProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x00118598 File Offset: 0x00116798
		// (set) Token: 0x06003B5B RID: 15195 RVA: 0x00016586 File Offset: 0x00014786
		public unsafe DynamicPropertyCollection _serverDynamicProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__serverDynamicProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__serverDynamicProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x001185C8 File Offset: 0x001167C8
		// (set) Token: 0x06003B5D RID: 15197 RVA: 0x000165A5 File Offset: 0x000147A5
		public unsafe ObjRef _objRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x001185F8 File Offset: 0x001167F8
		// (set) Token: 0x06003B5F RID: 15199 RVA: 0x000165C4 File Offset: 0x000147C4
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeFieldInfoPtr__objectUri;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeFieldInfoPtr__channelSink;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeFieldInfoPtr__envoySink;

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeFieldInfoPtr__clientDynamicProperties;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeFieldInfoPtr__serverDynamicProperties;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeFieldInfoPtr__objRef;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0;

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0;

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0;

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0;
	}
}
