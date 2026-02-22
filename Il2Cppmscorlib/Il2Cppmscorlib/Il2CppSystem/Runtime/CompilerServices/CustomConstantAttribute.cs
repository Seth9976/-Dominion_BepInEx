using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042B RID: 1067
	[Serializable]
	public class CustomConstantAttribute : Attribute
	{
		// Token: 0x0600422B RID: 16939 RVA: 0x00130F00 File Offset: 0x0012F100
		// Note: this type is marked as 'beforefieldinit'.
		static CustomConstantAttribute()
		{
			Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CustomConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr);
			CustomConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr, 100672924);
			CustomConstantAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr, 100672925);
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x00130F58 File Offset: 0x0012F158
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00130FA4 File Offset: 0x0012F1A4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomConstantAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConstantAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x000193E4 File Offset: 0x000175E4
		public CustomConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035DF RID: 13791
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040035E0 RID: 13792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
