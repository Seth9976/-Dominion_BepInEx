using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003AC RID: 940
	public class RemotingProxy : RealProxy
	{
		// Token: 0x06003D17 RID: 15639 RVA: 0x0011F08C File Offset: 0x0011D28C
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingProxy()
		{
			Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "RemotingProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr);
			RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_cache_GetTypeMethod");
			RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_cache_GetHashCodeMethod");
			RemotingProxy.NativeFieldInfoPtr__sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_sink");
			RemotingProxy.NativeFieldInfoPtr__hasEnvoySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_hasEnvoySink");
			RemotingProxy.NativeFieldInfoPtr__ctorCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_ctorCall");
			RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672295);
			RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672296);
			RemotingProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672297);
			RemotingProxy.NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672298);
			RemotingProxy.NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672299);
			RemotingProxy.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672300);
			RemotingProxy.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672301);
			RemotingProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672302);
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x0011F1C0 File Offset: 0x0011D3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351886, XrefRangeEnd = 351889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingProxy(Type type, ClientIdentity identity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x0011F220 File Offset: 0x0011D420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351892, RefRangeEnd = 351894, XrefRangeStart = 351889, XrefRangeEnd = 351892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingProxy(Type type, string activationUrl, Il2CppReferenceArray<Object> activationAttributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x0011F290 File Offset: 0x0011D490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351894, XrefRangeEnd = 351925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage Invoke(IMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x0011F2EC File Offset: 0x0011D4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351940, RefRangeEnd = 351942, XrefRangeStart = 351925, XrefRangeEnd = 351940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachIdentity(Identity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x0011F330 File Offset: 0x0011D530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351942, XrefRangeEnd = 351952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessage ActivateRemoteObject(IMethodMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x0011F380 File Offset: 0x0011D580
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351952, XrefRangeEnd = 351959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x0011F3B8 File Offset: 0x0011D5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351959, XrefRangeEnd = 351972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x0011F418 File Offset: 0x0011D618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351972, XrefRangeEnd = 351981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00016FDF File Offset: 0x000151DF
		public RemotingProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06003D21 RID: 15649 RVA: 0x0011F454 File Offset: 0x0011D654
		// (set) Token: 0x06003D22 RID: 15650 RVA: 0x00016FE8 File Offset: 0x000151E8
		public unsafe static MethodInfo _cache_GetTypeMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06003D23 RID: 15651 RVA: 0x0011F47C File Offset: 0x0011D67C
		// (set) Token: 0x06003D24 RID: 15652 RVA: 0x00016FFA File Offset: 0x000151FA
		public unsafe static MethodInfo _cache_GetHashCodeMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x0011F4A4 File Offset: 0x0011D6A4
		// (set) Token: 0x06003D26 RID: 15654 RVA: 0x0001700C File Offset: 0x0001520C
		public unsafe IMessageSink _sink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__sink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__sink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x0011F4D4 File Offset: 0x0011D6D4
		// (set) Token: 0x06003D28 RID: 15656 RVA: 0x0001702B File Offset: 0x0001522B
		public unsafe bool _hasEnvoySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__hasEnvoySink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__hasEnvoySink)) = value;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x0011F4FC File Offset: 0x0011D6FC
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x00017046 File Offset: 0x00015246
		public unsafe ConstructionCall _ctorCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__ctorCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionCall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__ctorCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400329A RID: 12954
		private static readonly IntPtr NativeFieldInfoPtr__cache_GetTypeMethod;

		// Token: 0x0400329B RID: 12955
		private static readonly IntPtr NativeFieldInfoPtr__cache_GetHashCodeMethod;

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeFieldInfoPtr__sink;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeFieldInfoPtr__hasEnvoySink;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeFieldInfoPtr__ctorCall;

		// Token: 0x0400329F RID: 12959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0;

		// Token: 0x040032A0 RID: 12960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040032A1 RID: 12961
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x040032A2 RID: 12962
		private static readonly IntPtr NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0;

		// Token: 0x040032A3 RID: 12963
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0;

		// Token: 0x040032A4 RID: 12964
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040032A5 RID: 12965
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0;

		// Token: 0x040032A6 RID: 12966
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
