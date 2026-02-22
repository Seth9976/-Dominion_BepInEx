using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003A9 RID: 937
	public class ProxyAttribute : Attribute
	{
		// Token: 0x06003CDF RID: 15583 RVA: 0x0011E200 File Offset: 0x0011C400
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyAttribute()
		{
			Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "ProxyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr);
			ProxyAttribute.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100672267);
			ProxyAttribute.NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100672268);
			ProxyAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100672269);
			ProxyAttribute.NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100672270);
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x0011E280 File Offset: 0x0011C480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351549, XrefRangeEnd = 351559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MarshalByRefObject CreateInstance(Type serverType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProxyAttribute.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
			}
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x0011E2DC File Offset: 0x0011C4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351559, XrefRangeEnd = 351564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, Object serverObject, Context serverContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProxyAttribute.NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr3) : null;
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x0011E370 File Offset: 0x0011C570
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetPropertiesForNewContext(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x0011E3B4 File Offset: 0x0011C5B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyAttribute.NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00016E7B File Offset: 0x0001507B
		public ProxyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003273 RID: 12915
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0;

		// Token: 0x04003274 RID: 12916
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0;

		// Token: 0x04003275 RID: 12917
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0;

		// Token: 0x04003276 RID: 12918
		private static readonly IntPtr NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0;
	}
}
