using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Remoting.Proxies;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D0 RID: 976
	public class ActivationServices : Object
	{
		// Token: 0x06003E62 RID: 15970 RVA: 0x00123784 File Offset: 0x00121984
		// Note: this type is marked as 'beforefieldinit'.
		static ActivationServices()
		{
			Il2CppClassPointerStore<ActivationServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ActivationServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr);
			ActivationServices.NativeFieldInfoPtr__constructionActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, "_constructionActivator");
			ActivationServices.NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672459);
			ActivationServices.NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672460);
			ActivationServices.NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672461);
			ActivationServices.NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672462);
			ActivationServices.NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672463);
			ActivationServices.NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672464);
			ActivationServices.NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672465);
			ActivationServices.NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672466);
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x00123868 File Offset: 0x00121A68
		public unsafe static IActivator ConstructionActivator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 353627, RefRangeEnd = 353628, XrefRangeStart = 353619, XrefRangeEnd = 353627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x0012389C File Offset: 0x00121A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353652, RefRangeEnd = 353654, XrefRangeStart = 353628, XrefRangeEnd = 353652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x001238F4 File Offset: 0x00121AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353664, RefRangeEnd = 353666, XrefRangeStart = 353654, XrefRangeEnd = 353664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00123938 File Offset: 0x00121B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353742, RefRangeEnd = 353743, XrefRangeStart = 353666, XrefRangeEnd = 353742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Il2CppReferenceArray<Object> activationAttributes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructionCall>(intPtr3) : null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x001239A0 File Offset: 0x00121BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353782, RefRangeEnd = 353784, XrefRangeStart = 353743, XrefRangeEnd = 353782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x001239E4 File Offset: 0x00121BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353784, XrefRangeEnd = 353793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateProxyForType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00123A28 File Offset: 0x00121C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353794, RefRangeEnd = 353796, XrefRangeStart = 353793, XrefRangeEnd = 353794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object AllocateUninitializedClassInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x00123A6C File Offset: 0x00121C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353797, RefRangeEnd = 353799, XrefRangeStart = 353796, XrefRangeEnd = 353797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableProxyActivation(Type type, bool enable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x000178A3 File Offset: 0x00015AA3
		public ActivationServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x00123AB0 File Offset: 0x00121CB0
		// (set) Token: 0x06003E6D RID: 15981 RVA: 0x000178AC File Offset: 0x00015AAC
		public unsafe static IActivator _constructionActivator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActivationServices.NativeFieldInfoPtr__constructionActivator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivationServices.NativeFieldInfoPtr__constructionActivator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400336C RID: 13164
		private static readonly IntPtr NativeFieldInfoPtr__constructionActivator;

		// Token: 0x0400336D RID: 13165
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0;

		// Token: 0x0400336E RID: 13166
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0;

		// Token: 0x0400336F RID: 13167
		private static readonly IntPtr NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0;

		// Token: 0x04003370 RID: 13168
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003371 RID: 13169
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0;

		// Token: 0x04003372 RID: 13170
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0;

		// Token: 0x04003373 RID: 13171
		private static readonly IntPtr NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0;

		// Token: 0x04003374 RID: 13172
		private static readonly IntPtr NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0;
	}
}
