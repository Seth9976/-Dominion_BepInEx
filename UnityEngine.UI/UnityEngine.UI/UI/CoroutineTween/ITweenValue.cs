using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000046 RID: 70
	public class ITweenValue : Il2CppObjectBase
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x000273C0 File Offset: 0x000255C0
		// Note: this type is marked as 'beforefieldinit'.
		static ITweenValue()
		{
			Il2CppClassPointerStore<ITweenValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "ITweenValue");
			ITweenValue.NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664512);
			ITweenValue.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664513);
			ITweenValue.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664514);
			ITweenValue.NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664515);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00027438 File Offset: 0x00025638
		[CallerCount(0)]
		public unsafe virtual void TweenValue(float floatPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPercentage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00027484 File Offset: 0x00025684
		public unsafe virtual bool ignoreTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000274CC File Offset: 0x000256CC
		public unsafe virtual float duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00027514 File Offset: 0x00025714
		[CallerCount(0)]
		public unsafe virtual bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00004D94 File Offset: 0x00002F94
		public ITweenValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0;
	}
}
