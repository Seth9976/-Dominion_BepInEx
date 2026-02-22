using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting;

namespace Il2CppSystem
{
	// Token: 0x0200011F RID: 287
	[Serializable]
	public class MarshalByRefObject : Object
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x0007FC8C File Offset: 0x0007DE8C
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalByRefObject()
		{
			Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MarshalByRefObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr);
			MarshalByRefObject.NativeFieldInfoPtr__identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, "_identity");
			MarshalByRefObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666807);
			MarshalByRefObject.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666808);
			MarshalByRefObject.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666809);
			MarshalByRefObject.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666810);
			MarshalByRefObject.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100666811);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0007FD34 File Offset: 0x0007DF34
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalByRefObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0007FD70 File Offset: 0x0007DF70
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x0007FDB0 File Offset: 0x0007DFB0
		public unsafe ServerIdentity ObjectIdentity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 305892, RefRangeEnd = 305893, XrefRangeStart = 305887, XrefRangeEnd = 305892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 305898, RefRangeEnd = 305902, XrefRangeStart = 305893, XrefRangeEnd = 305898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0007FDF4 File Offset: 0x0007DFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305902, XrefRangeEnd = 305907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByRefObject.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0007FE50 File Offset: 0x0007E050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305907, XrefRangeEnd = 305912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object InitializeLifetimeService()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByRefObject.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00007279 File Offset: 0x00005479
		public MarshalByRefObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0007FE9C File Offset: 0x0007E09C
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x00007282 File Offset: 0x00005482
		public unsafe Object _identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByRefObject.NativeFieldInfoPtr__identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByRefObject.NativeFieldInfoPtr__identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr__identity;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0;
	}
}
