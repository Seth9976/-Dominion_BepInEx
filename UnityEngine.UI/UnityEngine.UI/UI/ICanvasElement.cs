using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000005 RID: 5
	public class ICanvasElement : Il2CppObjectBase
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00007A70 File Offset: 0x00005C70
		// Note: this type is marked as 'beforefieldinit'.
		static ICanvasElement()
		{
			Il2CppClassPointerStore<ICanvasElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ICanvasElement");
			ICanvasElement.NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanvasElement>.NativeClassPtr, 100663315);
			ICanvasElement.NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanvasElement>.NativeClassPtr, 100663316);
			ICanvasElement.NativeMethodInfoPtr_LayoutComplete_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanvasElement>.NativeClassPtr, 100663317);
			ICanvasElement.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanvasElement>.NativeClassPtr, 100663318);
			ICanvasElement.NativeMethodInfoPtr_IsDestroyed_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanvasElement>.NativeClassPtr, 100663319);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00007AFC File Offset: 0x00005CFC
		[CallerCount(0)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanvasElement.NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00007B48 File Offset: 0x00005D48
		public unsafe virtual Transform transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanvasElement.NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007B94 File Offset: 0x00005D94
		[CallerCount(0)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanvasElement.NativeMethodInfoPtr_LayoutComplete_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00007BD0 File Offset: 0x00005DD0
		[CallerCount(0)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanvasElement.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00007C0C File Offset: 0x00005E0C
		[CallerCount(0)]
		public unsafe virtual bool IsDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanvasElement.NativeMethodInfoPtr_IsDestroyed_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002176 File Offset: 0x00000376
		public ICanvasElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_IsDestroyed_Public_Abstract_Virtual_New_Boolean_0;
	}
}
