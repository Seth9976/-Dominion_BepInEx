using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A7 RID: 167
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x06000FF6 RID: 4086 RVA: 0x00041C10 File Offset: 0x0003FE10
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultExecutionOrder()
		{
			Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DefaultExecutionOrder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr);
			DefaultExecutionOrder.NativeFieldInfoPtr_m_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, "m_Order");
			DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100664330);
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00041C68 File Offset: 0x0003FE68
		public unsafe int order
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 68302, RefRangeEnd = 68317, XrefRangeStart = 68302, XrefRangeEnd = 68302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00009F7D File Offset: 0x0000817D
		public DefaultExecutionOrder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00041CA4 File Offset: 0x0003FEA4
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00009F86 File Offset: 0x00008186
		public unsafe int m_Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order)) = value;
			}
		}

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr_m_Order;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_get_order_Public_get_Int32_0;
	}
}
