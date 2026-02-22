using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003DF RID: 991
	public class IllogicalCallContext : Object
	{
		// Token: 0x06003EE5 RID: 16101 RVA: 0x00125280 File Offset: 0x00123480
		// Note: this type is marked as 'beforefieldinit'.
		static IllogicalCallContext()
		{
			Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IllogicalCallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr);
			IllogicalCallContext.NativeFieldInfoPtr_m_Datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, "m_Datastore");
			IllogicalCallContext.NativeFieldInfoPtr_m_HostContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, "m_HostContext");
			IllogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672514);
			IllogicalCallContext.NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672515);
			IllogicalCallContext.NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672516);
			IllogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672517);
			IllogicalCallContext.NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672518);
			IllogicalCallContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672519);
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x00125350 File Offset: 0x00123550
		public unsafe Hashtable Datastore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354026, XrefRangeEnd = 354030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x00125390 File Offset: 0x00123590
		// (set) Token: 0x06003EE8 RID: 16104 RVA: 0x001253D0 File Offset: 0x001235D0
		public unsafe Object HostContext
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x00125414 File Offset: 0x00123614
		public unsafe bool HasUserData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 354030, RefRangeEnd = 354032, XrefRangeStart = 354030, XrefRangeEnd = 354030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00125450 File Offset: 0x00123650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354054, RefRangeEnd = 354055, XrefRangeStart = 354032, XrefRangeEnd = 354054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IllogicalCallContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr3) : null;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00125490 File Offset: 0x00123690
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IllogicalCallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00017C22 File Offset: 0x00015E22
		public IllogicalCallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06003EED RID: 16109 RVA: 0x001254CC File Offset: 0x001236CC
		// (set) Token: 0x06003EEE RID: 16110 RVA: 0x00017C2B File Offset: 0x00015E2B
		public unsafe Hashtable m_Datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_Datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_Datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x001254FC File Offset: 0x001236FC
		// (set) Token: 0x06003EF0 RID: 16112 RVA: 0x00017C4A File Offset: 0x00015E4A
		public unsafe Object m_HostContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_HostContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_HostContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033BA RID: 13242
		private static readonly IntPtr NativeFieldInfoPtr_m_Datastore;

		// Token: 0x040033BB RID: 13243
		private static readonly IntPtr NativeFieldInfoPtr_m_HostContext;

		// Token: 0x040033BC RID: 13244
		private static readonly IntPtr NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0;

		// Token: 0x040033BD RID: 13245
		private static readonly IntPtr NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0;

		// Token: 0x040033BE RID: 13246
		private static readonly IntPtr NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0;

		// Token: 0x040033BF RID: 13247
		private static readonly IntPtr NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0;

		// Token: 0x040033C0 RID: 13248
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0;

		// Token: 0x040033C1 RID: 13249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
