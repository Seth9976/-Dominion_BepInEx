using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C2 RID: 962
	public sealed class ChannelServices : Object
	{
		// Token: 0x06003DF5 RID: 15861 RVA: 0x00122088 File Offset: 0x00120288
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelServices()
		{
			Il2CppClassPointerStore<ChannelServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "ChannelServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr);
			ChannelServices.NativeFieldInfoPtr_registeredChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "registeredChannels");
			ChannelServices.NativeFieldInfoPtr_delayedClientChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "delayedClientChannels");
			ChannelServices.NativeFieldInfoPtr__crossContextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "_crossContextSink");
			ChannelServices.NativeFieldInfoPtr_CrossContextUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "CrossContextUrl");
			ChannelServices.NativeFieldInfoPtr_oldStartModeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "oldStartModeTypes");
			ChannelServices.NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672409);
			ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672410);
			ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672411);
			ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672412);
			ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672413);
			ChannelServices.NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672414);
			ChannelServices.NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672415);
			ChannelServices.NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672416);
			ChannelServices.NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672417);
			ChannelServices.NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672418);
			ChannelServices.NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672419);
			ChannelServices.NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672420);
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x0012220C File Offset: 0x0012040C
		public unsafe static CrossContextChannel CrossContextChannel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352926, XrefRangeEnd = 352930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr3) : null;
			}
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00122240 File Offset: 0x00120440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 353017, RefRangeEnd = 353020, XrefRangeStart = 352930, XrefRangeEnd = 353017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink CreateClientChannelSinkChain(string url, Object remoteChannelData, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x001222B4 File Offset: 0x001204B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353020, XrefRangeEnd = 353028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, Il2CppReferenceArray<Object> channelDataArray, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelDataArray);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00122338 File Offset: 0x00120538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 353032, RefRangeEnd = 353035, XrefRangeStart = 353028, XrefRangeEnd = 353032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannel(IChannel chnl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chnl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00122370 File Offset: 0x00120570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353090, RefRangeEnd = 353091, XrefRangeStart = 353035, XrefRangeEnd = 353090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chnl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ensureSecurity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x001223B4 File Offset: 0x001205B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353237, RefRangeEnd = 353238, XrefRangeStart = 353091, XrefRangeEnd = 353237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannelConfig(ChannelData channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x001223EC File Offset: 0x001205EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353253, RefRangeEnd = 353255, XrefRangeStart = 353238, XrefRangeEnd = 353253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateProvider(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00122430 File Offset: 0x00120630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353298, RefRangeEnd = 353299, XrefRangeStart = 353255, XrefRangeEnd = 353298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage SyncDispatchMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x00122474 File Offset: 0x00120674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353317, RefRangeEnd = 353318, XrefRangeStart = 353299, XrefRangeEnd = 353317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReturnMessage CheckIncomingMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x001224B8 File Offset: 0x001206B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353343, RefRangeEnd = 353344, XrefRangeStart = 353318, XrefRangeEnd = 353343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00122510 File Offset: 0x00120710
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLocalCall(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00122554 File Offset: 0x00120754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353385, RefRangeEnd = 353386, XrefRangeStart = 353344, XrefRangeEnd = 353385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCurrentChannelInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x000175AF File Offset: 0x000157AF
		public ChannelServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x00122588 File Offset: 0x00120788
		// (set) Token: 0x06003E04 RID: 15876 RVA: 0x000175B8 File Offset: 0x000157B8
		public unsafe static ArrayList registeredChannels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_registeredChannels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_registeredChannels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x001225B0 File Offset: 0x001207B0
		// (set) Token: 0x06003E06 RID: 15878 RVA: 0x000175CA File Offset: 0x000157CA
		public unsafe static ArrayList delayedClientChannels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_delayedClientChannels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_delayedClientChannels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003E07 RID: 15879 RVA: 0x001225D8 File Offset: 0x001207D8
		// (set) Token: 0x06003E08 RID: 15880 RVA: 0x000175DC File Offset: 0x000157DC
		public unsafe static CrossContextChannel _crossContextSink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr__crossContextSink, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr__crossContextSink, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06003E09 RID: 15881 RVA: 0x00122600 File Offset: 0x00120800
		// (set) Token: 0x06003E0A RID: 15882 RVA: 0x000175EE File Offset: 0x000157EE
		public unsafe static string CrossContextUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_CrossContextUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_CrossContextUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06003E0B RID: 15883 RVA: 0x00122620 File Offset: 0x00120820
		// (set) Token: 0x06003E0C RID: 15884 RVA: 0x00017600 File Offset: 0x00015800
		public unsafe static IList oldStartModeTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_oldStartModeTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_oldStartModeTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400332C RID: 13100
		private static readonly IntPtr NativeFieldInfoPtr_registeredChannels;

		// Token: 0x0400332D RID: 13101
		private static readonly IntPtr NativeFieldInfoPtr_delayedClientChannels;

		// Token: 0x0400332E RID: 13102
		private static readonly IntPtr NativeFieldInfoPtr__crossContextSink;

		// Token: 0x0400332F RID: 13103
		private static readonly IntPtr NativeFieldInfoPtr_CrossContextUrl;

		// Token: 0x04003330 RID: 13104
		private static readonly IntPtr NativeFieldInfoPtr_oldStartModeTypes;

		// Token: 0x04003331 RID: 13105
		private static readonly IntPtr NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0;

		// Token: 0x04003332 RID: 13106
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0;

		// Token: 0x04003333 RID: 13107
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0;

		// Token: 0x04003334 RID: 13108
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0;

		// Token: 0x04003335 RID: 13109
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0;

		// Token: 0x04003336 RID: 13110
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0;

		// Token: 0x04003337 RID: 13111
		private static readonly IntPtr NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0;

		// Token: 0x04003338 RID: 13112
		private static readonly IntPtr NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0;

		// Token: 0x04003339 RID: 13113
		private static readonly IntPtr NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0;

		// Token: 0x0400333A RID: 13114
		private static readonly IntPtr NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0;

		// Token: 0x0400333B RID: 13115
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0;

		// Token: 0x0400333C RID: 13116
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0;
	}
}
