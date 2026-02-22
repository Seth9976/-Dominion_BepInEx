using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003AA RID: 938
	public class TransparentProxy : Object
	{
		// Token: 0x06003CE5 RID: 15589 RVA: 0x0011E414 File Offset: 0x0011C614
		// Note: this type is marked as 'beforefieldinit'.
		static TransparentProxy()
		{
			Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "TransparentProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr);
			TransparentProxy.NativeFieldInfoPtr__rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_rp");
			TransparentProxy.NativeFieldInfoPtr__class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_class");
			TransparentProxy.NativeFieldInfoPtr__custom_type_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_custom_type_info");
			TransparentProxy.NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672271);
			TransparentProxy.NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672272);
			TransparentProxy.NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672273);
			TransparentProxy.NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672274);
			TransparentProxy.NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672275);
			TransparentProxy.NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672276);
			TransparentProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672277);
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x0011E50C File Offset: 0x0011C70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351564, XrefRangeEnd = 351572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetProxyType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x0011E54C File Offset: 0x0011C74C
		public unsafe bool IsContextBoundObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351572, XrefRangeEnd = 351580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x0011E588 File Offset: 0x0011C788
		public unsafe Context TargetContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x0011E5C8 File Offset: 0x0011C7C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351588, RefRangeEnd = 351590, XrefRangeStart = 351580, XrefRangeEnd = 351588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InCurrentContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x0011E604 File Offset: 0x0011C804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351590, XrefRangeEnd = 351616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x0011E660 File Offset: 0x0011C860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351616, XrefRangeEnd = 351643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x0011E6C0 File Offset: 0x0011C8C0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransparentProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00016E84 File Offset: 0x00015084
		public TransparentProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x0011E6FC File Offset: 0x0011C8FC
		// (set) Token: 0x06003CEF RID: 15599 RVA: 0x00016E8D File Offset: 0x0001508D
		public unsafe RealProxy _rp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__rp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__rp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x0011E72C File Offset: 0x0011C92C
		// (set) Token: 0x06003CF1 RID: 15601 RVA: 0x00016EAC File Offset: 0x000150AC
		public unsafe RuntimeRemoteClassHandle _class
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__class);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__class)) = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x0011E754 File Offset: 0x0011C954
		// (set) Token: 0x06003CF3 RID: 15603 RVA: 0x00016EC7 File Offset: 0x000150C7
		public unsafe bool _custom_type_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__custom_type_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__custom_type_info)) = value;
			}
		}

		// Token: 0x04003277 RID: 12919
		private static readonly IntPtr NativeFieldInfoPtr__rp;

		// Token: 0x04003278 RID: 12920
		private static readonly IntPtr NativeFieldInfoPtr__class;

		// Token: 0x04003279 RID: 12921
		private static readonly IntPtr NativeFieldInfoPtr__custom_type_info;

		// Token: 0x0400327A RID: 12922
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0;

		// Token: 0x0400327B RID: 12923
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0;

		// Token: 0x0400327C RID: 12924
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0;

		// Token: 0x0400327D RID: 12925
		private static readonly IntPtr NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0;

		// Token: 0x0400327E RID: 12926
		private static readonly IntPtr NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0;

		// Token: 0x0400327F RID: 12927
		private static readonly IntPtr NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0;

		// Token: 0x04003280 RID: 12928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
