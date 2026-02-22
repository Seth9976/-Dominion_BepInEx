using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200000B RID: 11
	public class IClippable : Il2CppObjectBase
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00008D70 File Offset: 0x00006F70
		// Note: this type is marked as 'beforefieldinit'.
		static IClippable()
		{
			Il2CppClassPointerStore<IClippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IClippable");
			IClippable.NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClippable>.NativeClassPtr, 100663366);
			IClippable.NativeMethodInfoPtr_RecalculateClipping_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClippable>.NativeClassPtr, 100663367);
			IClippable.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClippable>.NativeClassPtr, 100663368);
			IClippable.NativeMethodInfoPtr_Cull_Public_Abstract_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClippable>.NativeClassPtr, 100663369);
			IClippable.NativeMethodInfoPtr_SetClipRect_Public_Abstract_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClippable>.NativeClassPtr, 100663370);
			IClippable.NativeMethodInfoPtr_SetClipSoftness_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClippable>.NativeClassPtr, 100663371);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00008E10 File Offset: 0x00007010
		public unsafe virtual GameObject gameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClippable.NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008E5C File Offset: 0x0000705C
		[CallerCount(0)]
		public unsafe virtual void RecalculateClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClippable.NativeMethodInfoPtr_RecalculateClipping_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00008E98 File Offset: 0x00007098
		public unsafe virtual RectTransform rectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClippable.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008EE4 File Offset: 0x000070E4
		[CallerCount(0)]
		public unsafe virtual void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClippable.NativeMethodInfoPtr_Cull_Public_Abstract_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008F3C File Offset: 0x0000713C
		[CallerCount(0)]
		public unsafe virtual void SetClipRect(Rect value, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClippable.NativeMethodInfoPtr_SetClipRect_Public_Abstract_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00008F94 File Offset: 0x00007194
		[CallerCount(0)]
		public unsafe virtual void SetClipSoftness(Vector2 clipSoftness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipSoftness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClippable.NativeMethodInfoPtr_SetClipSoftness_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002325 File Offset: 0x00000525
		public IClippable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateClipping_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Abstract_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_SetClipRect_Public_Abstract_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_SetClipSoftness_Public_Abstract_Virtual_New_Void_Vector2_0;
	}
}
