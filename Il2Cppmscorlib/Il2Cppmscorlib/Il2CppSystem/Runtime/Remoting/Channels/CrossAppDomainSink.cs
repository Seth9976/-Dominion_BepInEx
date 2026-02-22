using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C5 RID: 965
	public class CrossAppDomainSink : Object
	{
		// Token: 0x06003E23 RID: 15907 RVA: 0x00122B38 File Offset: 0x00120D38
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainSink()
		{
			Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr);
			CrossAppDomainSink.NativeFieldInfoPtr_s_sinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "s_sinks");
			CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "processMessageMethod");
			CrossAppDomainSink.NativeFieldInfoPtr__domainID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "_domainID");
			CrossAppDomainSink.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672433);
			CrossAppDomainSink.NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672434);
			CrossAppDomainSink.NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672435);
			CrossAppDomainSink.NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672436);
			CrossAppDomainSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672437);
			CrossAppDomainSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672438);
			CrossAppDomainSink.NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672439);
			CrossAppDomainSink.NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100672441);
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00122C44 File Offset: 0x00120E44
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainSink(int domainID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00122C8C File Offset: 0x00120E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353467, RefRangeEnd = 353468, XrefRangeStart = 353438, XrefRangeEnd = 353467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CrossAppDomainSink GetSink(int domainID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CrossAppDomainSink>(intPtr3) : null;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x00122CCC File Offset: 0x00120ECC
		public unsafe int TargetDomainId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00122D08 File Offset: 0x00120F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353468, XrefRangeEnd = 353478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(Il2CppStructArray<byte> arrRequest, CADMethodCallMessage cadMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cadMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CrossAppDomainSink.ProcessMessageRes(intPtr);
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00122D58 File Offset: 0x00120F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353478, XrefRangeEnd = 353518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msgRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msgRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00122DB4 File Offset: 0x00120FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353518, XrefRangeEnd = 353529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00122E24 File Offset: 0x00121024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353529, XrefRangeEnd = 353536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAsyncMessage(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00122E68 File Offset: 0x00121068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353536, XrefRangeEnd = 353542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AsyncProcessMessage_b__10_0(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x0001768F File Offset: 0x0001588F
		public CrossAppDomainSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x00122EAC File Offset: 0x001210AC
		// (set) Token: 0x06003E2E RID: 15918 RVA: 0x00017698 File Offset: 0x00015898
		public unsafe static Hashtable s_sinks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainSink.NativeFieldInfoPtr_s_sinks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainSink.NativeFieldInfoPtr_s_sinks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06003E2F RID: 15919 RVA: 0x00122ED4 File Offset: 0x001210D4
		// (set) Token: 0x06003E30 RID: 15920 RVA: 0x000176AA File Offset: 0x000158AA
		public unsafe static MethodInfo processMessageMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x00122EFC File Offset: 0x001210FC
		// (set) Token: 0x06003E32 RID: 15922 RVA: 0x000176BC File Offset: 0x000158BC
		public unsafe int _domainID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.NativeFieldInfoPtr__domainID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.NativeFieldInfoPtr__domainID)) = value;
			}
		}

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeFieldInfoPtr_s_sinks;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeFieldInfoPtr_processMessageMethod;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeFieldInfoPtr__domainID;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0;

		// Token: 0x0200062E RID: 1582
		public sealed class ProcessMessageRes : ValueType
		{
			// Token: 0x06005454 RID: 21588 RVA: 0x00175474 File Offset: 0x00173674
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessMessageRes()
			{
				Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "ProcessMessageRes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr);
				CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr, "arrResponse");
				CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr, "cadMrm");
			}

			// Token: 0x06005455 RID: 21589 RVA: 0x00020884 File Offset: 0x0001EA84
			public ProcessMessageRes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005456 RID: 21590 RVA: 0x0002088D File Offset: 0x0001EA8D
			public ProcessMessageRes()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr))
			{
			}

			// Token: 0x17001598 RID: 5528
			// (get) Token: 0x06005457 RID: 21591 RVA: 0x001754C8 File Offset: 0x001736C8
			// (set) Token: 0x06005458 RID: 21592 RVA: 0x0002089F File Offset: 0x0001EA9F
			public unsafe Il2CppStructArray<byte> arrResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001599 RID: 5529
			// (get) Token: 0x06005459 RID: 21593 RVA: 0x001754F8 File Offset: 0x001736F8
			// (set) Token: 0x0600545A RID: 21594 RVA: 0x000208BE File Offset: 0x0001EABE
			public unsafe CADMethodReturnMessage cadMrm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADMethodReturnMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043E9 RID: 17385
			private static readonly IntPtr NativeFieldInfoPtr_arrResponse;

			// Token: 0x040043EA RID: 17386
			private static readonly IntPtr NativeFieldInfoPtr_cadMrm;
		}
	}
}
