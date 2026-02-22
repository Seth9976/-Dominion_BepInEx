using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000058 RID: 88
	public class DefaultDispatchingStrategy : Object
	{
		// Token: 0x06000556 RID: 1366 RVA: 0x0001C560 File Offset: 0x0001A760
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDispatchingStrategy()
		{
			Il2CppClassPointerStore<DefaultDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DefaultDispatchingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDispatchingStrategy>.NativeClassPtr);
			DefaultDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDispatchingStrategy>.NativeClassPtr, 100663708);
			DefaultDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDispatchingStrategy>.NativeClassPtr, 100663709);
			DefaultDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDispatchingStrategy>.NativeClassPtr, 100663710);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001C5CC File Offset: 0x0001A7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93681, XrefRangeEnd = 93682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001C61C File Offset: 0x0001A81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93682, XrefRangeEnd = 93703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0001C670 File Offset: 0x0001A870
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDispatchingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDispatchingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000048E7 File Offset: 0x00002AE7
		public DefaultDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
