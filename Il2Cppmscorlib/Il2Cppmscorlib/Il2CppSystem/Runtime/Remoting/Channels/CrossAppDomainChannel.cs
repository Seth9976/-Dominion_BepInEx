using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public class CrossAppDomainChannel : Object
	{
		// Token: 0x06003E18 RID: 15896 RVA: 0x0012282C File Offset: 0x00120A2C
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainChannel()
		{
			Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr);
			CrossAppDomainChannel.NativeFieldInfoPtr_s_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, "s_lock");
			CrossAppDomainChannel.NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672425);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672426);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672427);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672428);
			CrossAppDomainChannel.NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672429);
			CrossAppDomainChannel.NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672430);
			CrossAppDomainChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672431);
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x001228FC File Offset: 0x00120AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353409, RefRangeEnd = 353410, XrefRangeStart = 353395, XrefRangeEnd = 353409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCrossAppDomainChannel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainChannel.NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00122924 File Offset: 0x00120B24
		public unsafe virtual string ChannelName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353410, XrefRangeEnd = 353412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x00122968 File Offset: 0x00120B68
		public unsafe virtual int ChannelPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x001229B0 File Offset: 0x00120BB0
		public unsafe virtual Object ChannelData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353412, XrefRangeEnd = 353424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x001229FC File Offset: 0x00120BFC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartListening(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x00122A4C File Offset: 0x00120C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353424, XrefRangeEnd = 353438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageSink CreateMessageSink(string url, Object data, out string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			uri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x00122AD4 File Offset: 0x00120CD4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainChannel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x00017674 File Offset: 0x00015874
		public CrossAppDomainChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x00122B10 File Offset: 0x00120D10
		// (set) Token: 0x06003E22 RID: 15906 RVA: 0x0001767D File Offset: 0x0001587D
		public unsafe static Object s_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainChannel.NativeFieldInfoPtr_s_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainChannel.NativeFieldInfoPtr_s_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003343 RID: 13123
		private static readonly IntPtr NativeFieldInfoPtr_s_lock;

		// Token: 0x04003344 RID: 13124
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0;

		// Token: 0x04003345 RID: 13125
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0;

		// Token: 0x04003346 RID: 13126
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003347 RID: 13127
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0;

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
