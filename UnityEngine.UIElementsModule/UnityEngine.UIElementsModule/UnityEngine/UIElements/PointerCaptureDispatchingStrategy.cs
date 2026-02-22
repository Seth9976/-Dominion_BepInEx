using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008E RID: 142
	public class PointerCaptureDispatchingStrategy : Object
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x00024544 File Offset: 0x00022744
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureDispatchingStrategy()
		{
			Il2CppClassPointerStore<PointerCaptureDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureDispatchingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureDispatchingStrategy>.NativeClassPtr);
			PointerCaptureDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureDispatchingStrategy>.NativeClassPtr, 100664002);
			PointerCaptureDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureDispatchingStrategy>.NativeClassPtr, 100664003);
			PointerCaptureDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureDispatchingStrategy>.NativeClassPtr, 100664004);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000245B0 File Offset: 0x000227B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95766, XrefRangeEnd = 95769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00024600 File Offset: 0x00022800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95769, XrefRangeEnd = 95793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00024654 File Offset: 0x00022854
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCaptureDispatchingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureDispatchingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureDispatchingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000053DB File Offset: 0x000035DB
		public PointerCaptureDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Virtual_Final_New_Boolean_EventBase_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Virtual_Final_New_Void_EventBase_IPanel_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
