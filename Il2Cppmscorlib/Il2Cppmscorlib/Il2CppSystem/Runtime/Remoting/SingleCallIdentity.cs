using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039F RID: 927
	public class SingleCallIdentity : ServerIdentity
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x0011CAE8 File Offset: 0x0011ACE8
		// Note: this type is marked as 'beforefieldinit'.
		static SingleCallIdentity()
		{
			Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "SingleCallIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr);
			SingleCallIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr, 100672219);
			SingleCallIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr, 100672220);
			SingleCallIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr, 100672221);
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x0011CB54 File Offset: 0x0011AD54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350983, RefRangeEnd = 350986, XrefRangeStart = 350983, XrefRangeEnd = 350986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleCallIdentity(string objectUri, Context context, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleCallIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x0011CBC4 File Offset: 0x0011ADC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351105, XrefRangeEnd = 351123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingleCallIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x0011CC20 File Offset: 0x0011AE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351123, XrefRangeEnd = 351140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingleCallIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00016C2F File Offset: 0x00014E2F
		public SingleCallIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
