using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009D RID: 157
	public sealed class PointerLeaveEvent : PointerEventBase<PointerLeaveEvent>
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x00027C28 File Offset: 0x00025E28
		// Note: this type is marked as 'beforefieldinit'.
		static PointerLeaveEvent()
		{
			Il2CppClassPointerStore<PointerLeaveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerLeaveEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerLeaveEvent>.NativeClassPtr);
			PointerLeaveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerLeaveEvent>.NativeClassPtr, 100664121);
			PointerLeaveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerLeaveEvent>.NativeClassPtr, 100664122);
			PointerLeaveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerLeaveEvent>.NativeClassPtr, 100664123);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00027C94 File Offset: 0x00025E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96490, XrefRangeEnd = 96493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerLeaveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00027CC8 File Offset: 0x00025EC8
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerLeaveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00027CFC File Offset: 0x00025EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96493, XrefRangeEnd = 96496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerLeaveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerLeaveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerLeaveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000057B1 File Offset: 0x000039B1
		public PointerLeaveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
