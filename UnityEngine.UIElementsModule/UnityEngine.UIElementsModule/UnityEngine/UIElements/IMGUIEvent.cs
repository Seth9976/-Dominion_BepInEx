using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A1 RID: 161
	public class IMGUIEvent : EventBase<IMGUIEvent>
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x000280A0 File Offset: 0x000262A0
		// Note: this type is marked as 'beforefieldinit'.
		static IMGUIEvent()
		{
			Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMGUIEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr);
			IMGUIEvent.NativeMethodInfoPtr_GetPooled_Public_Static_IMGUIEvent_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100664131);
			IMGUIEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100664132);
			IMGUIEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100664133);
			IMGUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr, 100664134);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00028120 File Offset: 0x00026320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96581, XrefRangeEnd = 96591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMGUIEvent GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.NativeMethodInfoPtr_GetPooled_Public_Static_IMGUIEvent_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMGUIEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00028164 File Offset: 0x00026364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96591, XrefRangeEnd = 96594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMGUIEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000281A0 File Offset: 0x000263A0
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000281D4 File Offset: 0x000263D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96594, XrefRangeEnd = 96600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMGUIEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUIEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000058D2 File Offset: 0x00003AD2
		public IMGUIEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_IMGUIEvent_Event_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
