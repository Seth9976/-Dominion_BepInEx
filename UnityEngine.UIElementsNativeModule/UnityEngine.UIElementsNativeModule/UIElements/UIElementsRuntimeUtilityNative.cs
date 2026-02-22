using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000B RID: 11
	public static class UIElementsRuntimeUtilityNative : Object
	{
		// Token: 0x060000FD RID: 253 RVA: 0x000048E4 File Offset: 0x00002AE4
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsRuntimeUtilityNative()
		{
			Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.UIElements", "UIElementsRuntimeUtilityNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr);
			UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, "RepaintOverlayPanelsCallback");
			UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, "UpdateRuntimePanelsCallback");
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100663326);
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100663327);
			UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegateField = IL2CPP.ResolveICall<UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegate>("UnityEngine.UIElements.UIElementsRuntimeUtilityNative::RegisterPlayerloopCallback");
			UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegateField = IL2CPP.ResolveICall<UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegate>("UnityEngine.UIElements.UIElementsRuntimeUtilityNative::UnregisterPlayerloopCallback");
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004984 File Offset: 0x00002B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89449, XrefRangeEnd = 89452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOverlayPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000049AC File Offset: 0x00002BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89452, XrefRangeEnd = 89455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRuntimePanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000293E File Offset: 0x00000B3E
		public UIElementsRuntimeUtilityNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000049D4 File Offset: 0x00002BD4
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002947 File Offset: 0x00000B47
		public unsafe static Action RepaintOverlayPanelsCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000049FC File Offset: 0x00002BFC
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002959 File Offset: 0x00000B59
		public unsafe static Action UpdateRuntimePanelsCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000296B File Offset: 0x00000B6B
		public static void RegisterPlayerloopCallback()
		{
			UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegateField();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002977 File Offset: 0x00000B77
		public static void UnregisterPlayerloopCallback()
		{
			UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegateField();
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_RepaintOverlayPanelsCallback;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_UpdateRuntimePanelsCallback;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0;

		// Token: 0x0400008F RID: 143
		private static readonly UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegate RegisterPlayerloopCallbackDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegate UnregisterPlayerloopCallbackDelegateField;

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate void RegisterPlayerloopCallbackDelegate();

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate void UnregisterPlayerloopCallbackDelegate();
	}
}
