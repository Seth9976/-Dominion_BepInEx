using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000013 RID: 19
	public static class MouseCaptureController : Object
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0001022C File Offset: 0x0000E42C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureController()
		{
			Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr);
			MouseCaptureController.NativeFieldInfoPtr_m_IsMouseCapturedWarningEmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, "m_IsMouseCapturedWarningEmitted");
			MouseCaptureController.NativeFieldInfoPtr_m_ReleaseMouseWarningEmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, "m_ReleaseMouseWarningEmitted");
			MouseCaptureController.NativeMethodInfoPtr_HasMouseCapture_Public_Static_Boolean_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, 100663391);
			MouseCaptureController.NativeMethodInfoPtr_CaptureMouse_Public_Static_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, 100663392);
			MouseCaptureController.NativeMethodInfoPtr_ReleaseMouse_Public_Static_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, 100663393);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91808, XrefRangeEnd = 91823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasMouseCapture(this IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureController.NativeMethodInfoPtr_HasMouseCapture_Public_Static_Boolean_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00010304 File Offset: 0x0000E504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91823, XrefRangeEnd = 91855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CaptureMouse(this IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureController.NativeMethodInfoPtr_CaptureMouse_Public_Static_Void_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001033C File Offset: 0x0000E53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91855, XrefRangeEnd = 91874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseMouse(this IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureController.NativeMethodInfoPtr_ReleaseMouse_Public_Static_Void_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000028EB File Offset: 0x00000AEB
		public MouseCaptureController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00010374 File Offset: 0x0000E574
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000028F4 File Offset: 0x00000AF4
		public unsafe static bool m_IsMouseCapturedWarningEmitted
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MouseCaptureController.NativeFieldInfoPtr_m_IsMouseCapturedWarningEmitted, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseCaptureController.NativeFieldInfoPtr_m_IsMouseCapturedWarningEmitted, (void*)(&value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00010390 File Offset: 0x0000E590
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002902 File Offset: 0x00000B02
		public unsafe static bool m_ReleaseMouseWarningEmitted
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MouseCaptureController.NativeFieldInfoPtr_m_ReleaseMouseWarningEmitted, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseCaptureController.NativeFieldInfoPtr_m_ReleaseMouseWarningEmitted, (void*)(&value));
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000103AC File Offset: 0x0000E5AC
		public static bool IsMouseCaptured()
		{
			bool flag = !MouseCaptureController.m_IsMouseCapturedWarningEmitted;
			if (flag)
			{
				Debug.LogError("MouseCaptureController.IsMouseCaptured() can not be used in playmode. Please use PointerCaptureHelper.GetCapturingElement() instead.");
				MouseCaptureController.m_IsMouseCapturedWarningEmitted = true;
			}
			return false;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000103E0 File Offset: 0x0000E5E0
		public static void ReleaseMouse()
		{
			bool flag = !MouseCaptureController.m_ReleaseMouseWarningEmitted;
			if (flag)
			{
				Debug.LogError("MouseCaptureController.ReleaseMouse() can not be used in playmode. Please use PointerCaptureHelper.GetCapturingElement() instead.");
				MouseCaptureController.m_ReleaseMouseWarningEmitted = true;
			}
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMouseCapturedWarningEmitted;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseMouseWarningEmitted;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_HasMouseCapture_Public_Static_Boolean_IEventHandler_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CaptureMouse_Public_Static_Void_IEventHandler_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMouse_Public_Static_Void_IEventHandler_0;
	}
}
