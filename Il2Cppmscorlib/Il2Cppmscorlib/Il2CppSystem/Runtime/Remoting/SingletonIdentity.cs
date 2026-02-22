using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039E RID: 926
	public class SingletonIdentity : ServerIdentity
	{
		// Token: 0x06003C74 RID: 15476 RVA: 0x0011C8EC File Offset: 0x0011AAEC
		// Note: this type is marked as 'beforefieldinit'.
		static SingletonIdentity()
		{
			Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "SingletonIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr);
			SingletonIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100672215);
			SingletonIdentity.NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100672216);
			SingletonIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100672217);
			SingletonIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100672218);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x0011C96C File Offset: 0x0011AB6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350983, RefRangeEnd = 350986, XrefRangeStart = 350983, XrefRangeEnd = 350986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingletonIdentity(string objectUri, Context context, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x0011C9DC File Offset: 0x0011ABDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351092, RefRangeEnd = 351094, XrefRangeStart = 351051, XrefRangeEnd = 351092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalByRefObject GetServerObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonIdentity.NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x0011CA1C File Offset: 0x0011AC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351094, XrefRangeEnd = 351100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0011CA78 File Offset: 0x0011AC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351100, XrefRangeEnd = 351105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x00016C26 File Offset: 0x00014E26
		public SingletonIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400322C RID: 12844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0;

		// Token: 0x0400322D RID: 12845
		private static readonly IntPtr NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0;

		// Token: 0x0400322E RID: 12846
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x0400322F RID: 12847
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
