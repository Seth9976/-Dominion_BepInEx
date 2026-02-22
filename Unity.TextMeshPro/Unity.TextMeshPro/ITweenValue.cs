using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace TMPro
{
	// Token: 0x02000027 RID: 39
	public class ITweenValue : Il2CppObjectBase
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00015020 File Offset: 0x00013220
		// Note: this type is marked as 'beforefieldinit'.
		static ITweenValue()
		{
			Il2CppClassPointerStore<ITweenValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ITweenValue");
			ITweenValue.NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100663610);
			ITweenValue.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100663611);
			ITweenValue.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100663612);
			ITweenValue.NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100663613);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00015098 File Offset: 0x00013298
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000150E4 File Offset: 0x000132E4
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0001512C File Offset: 0x0001332C
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

		// Token: 0x06000397 RID: 919 RVA: 0x00015174 File Offset: 0x00013374
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

		// Token: 0x06000398 RID: 920 RVA: 0x00003D9F File Offset: 0x00001F9F
		public ITweenValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0;
	}
}
