using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006F RID: 111
	public class KeyboardEventDispatchingStrategy : Object
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x00020D10 File Offset: 0x0001EF10
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardEventDispatchingStrategy()
		{
			Il2CppClassPointerStore<KeyboardEventDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyboardEventDispatchingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardEventDispatchingStrategy>.NativeClassPtr);
			KeyboardEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventDispatchingStrategy>.NativeClassPtr, 100663873);
			KeyboardEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventDispatchingStrategy>.NativeClassPtr, 100663874);
			KeyboardEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventDispatchingStrategy>.NativeClassPtr, 100663875);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00020D7C File Offset: 0x0001EF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94864, XrefRangeEnd = 94867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00020DCC File Offset: 0x0001EFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94867, XrefRangeEnd = 94886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00020E20 File Offset: 0x0001F020
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardEventDispatchingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardEventDispatchingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00004E4B File Offset: 0x0000304B
		public KeyboardEventDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
