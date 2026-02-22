using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000098 RID: 152
	public sealed class PointerStationaryEvent : PointerEventBase<PointerStationaryEvent>
	{
		// Token: 0x06000846 RID: 2118 RVA: 0x00027650 File Offset: 0x00025850
		// Note: this type is marked as 'beforefieldinit'.
		static PointerStationaryEvent()
		{
			Il2CppClassPointerStore<PointerStationaryEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerStationaryEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerStationaryEvent>.NativeClassPtr);
			PointerStationaryEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerStationaryEvent>.NativeClassPtr, 100664105);
			PointerStationaryEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerStationaryEvent>.NativeClassPtr, 100664106);
			PointerStationaryEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerStationaryEvent>.NativeClassPtr, 100664107);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000276BC File Offset: 0x000258BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96367, XrefRangeEnd = 96373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerStationaryEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000276F0 File Offset: 0x000258F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96373, XrefRangeEnd = 96376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerStationaryEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00027724 File Offset: 0x00025924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96376, XrefRangeEnd = 96382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerStationaryEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerStationaryEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerStationaryEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00005784 File Offset: 0x00003984
		public PointerStationaryEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
