using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Proxies;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200040B RID: 1035
	public class StackBuilderSink : Object
	{
		// Token: 0x06004153 RID: 16723 RVA: 0x0012E0B4 File Offset: 0x0012C2B4
		// Note: this type is marked as 'beforefieldinit'.
		static StackBuilderSink()
		{
			Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "StackBuilderSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr);
			StackBuilderSink.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, "_target");
			StackBuilderSink.NativeFieldInfoPtr__rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, "_rp");
			StackBuilderSink.NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100672810);
			StackBuilderSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100672811);
			StackBuilderSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100672812);
			StackBuilderSink.NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100672813);
			StackBuilderSink.NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100672814);
			StackBuilderSink.NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100672815);
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x0012E184 File Offset: 0x0012C384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355871, RefRangeEnd = 355872, XrefRangeStart = 355863, XrefRangeEnd = 355871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceInternalExecute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x0012E1E0 File Offset: 0x0012C3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355872, XrefRangeEnd = 355882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x0012E230 File Offset: 0x0012C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355882, XrefRangeEnd = 355894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x0012E294 File Offset: 0x0012C494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355987, RefRangeEnd = 355988, XrefRangeStart = 355894, XrefRangeEnd = 355987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteAsyncMessage(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x0012E2D8 File Offset: 0x0012C4D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356000, RefRangeEnd = 356001, XrefRangeStart = 355988, XrefRangeEnd = 356000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParameters(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x0012E31C File Offset: 0x0012C51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356001, XrefRangeEnd = 356003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AsyncProcessMessage_b__4_0(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00018D3D File Offset: 0x00016F3D
		public StackBuilderSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x0012E360 File Offset: 0x0012C560
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x00018D46 File Offset: 0x00016F46
		public unsafe MarshalByRefObject _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x0012E390 File Offset: 0x0012C590
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x00018D65 File Offset: 0x00016F65
		public unsafe RealProxy _rp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__rp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__rp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003558 RID: 13656
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04003559 RID: 13657
		private static readonly IntPtr NativeFieldInfoPtr__rp;

		// Token: 0x0400355A RID: 13658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0;

		// Token: 0x0400355B RID: 13659
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x0400355C RID: 13660
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x0400355D RID: 13661
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0;

		// Token: 0x0400355E RID: 13662
		private static readonly IntPtr NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0;

		// Token: 0x0400355F RID: 13663
		private static readonly IntPtr NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0;
	}
}
