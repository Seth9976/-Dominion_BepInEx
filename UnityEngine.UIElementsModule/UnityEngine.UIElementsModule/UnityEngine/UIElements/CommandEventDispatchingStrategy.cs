using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000053 RID: 83
	public class CommandEventDispatchingStrategy : Object
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		// Note: this type is marked as 'beforefieldinit'.
		static CommandEventDispatchingStrategy()
		{
			Il2CppClassPointerStore<CommandEventDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CommandEventDispatchingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandEventDispatchingStrategy>.NativeClassPtr);
			CommandEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventDispatchingStrategy>.NativeClassPtr, 100663698);
			CommandEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventDispatchingStrategy>.NativeClassPtr, 100663699);
			CommandEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventDispatchingStrategy>.NativeClassPtr, 100663700);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001C164 File Offset: 0x0001A364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93590, XrefRangeEnd = 93593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93593, XrefRangeEnd = 93608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DispatchEvent(EventBase evt, IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001C208 File Offset: 0x0001A408
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandEventDispatchingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandEventDispatchingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000480E File Offset: 0x00002A0E
		public CommandEventDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
