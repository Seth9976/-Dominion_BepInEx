using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000145 RID: 325
	public sealed class DefaultProxySectionInternal : Object
	{
		// Token: 0x06001527 RID: 5415 RVA: 0x0005FE10 File Offset: 0x0005E010
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultProxySectionInternal()
		{
			Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "DefaultProxySectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr);
			DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "webProxy");
			DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "classSyncObject");
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666242);
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666243);
			DefaultProxySectionInternal.NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666244);
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666245);
			DefaultProxySectionInternal.NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666246);
			DefaultProxySectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666247);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0005FEE0 File Offset: 0x0005E0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57553, XrefRangeEnd = 57554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0005FF14 File Offset: 0x0005E114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetSystemWebProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0005FF48 File Offset: 0x0005E148
		public unsafe static Object ClassSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57554, XrefRangeEnd = 57563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0005FF7C File Offset: 0x0005E17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57580, RefRangeEnd = 57581, XrefRangeStart = 57563, XrefRangeEnd = 57580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DefaultProxySectionInternal GetSection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultProxySectionInternal>(intPtr3) : null;
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0005FFB0 File Offset: 0x0005E1B0
		public unsafe IWebProxy WebProxy
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0005FFF0 File Offset: 0x0005E1F0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultProxySectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0000AACA File Offset: 0x00008CCA
		public DefaultProxySectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x0006002C File Offset: 0x0005E22C
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000AAD3 File Offset: 0x00008CD3
		public unsafe IWebProxy webProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x0006005C File Offset: 0x0005E25C
		// (set) Token: 0x06001532 RID: 5426 RVA: 0x0000AAF2 File Offset: 0x00008CF2
		public unsafe static Object classSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeFieldInfoPtr_webProxy;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeFieldInfoPtr_classSyncObject;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
