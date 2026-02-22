using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000E1 RID: 225
	[Serializable]
	public class ReflectionOnlyType : RuntimeType
	{
		// Token: 0x06000F3A RID: 3898 RVA: 0x00067E78 File Offset: 0x00066078
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionOnlyType()
		{
			Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ReflectionOnlyType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr);
			ReflectionOnlyType.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr, 100665879);
			ReflectionOnlyType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr, 100665880);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00067ED0 File Offset: 0x000660D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291816, XrefRangeEnd = 291820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionOnlyType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionOnlyType.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00067F0C File Offset: 0x0006610C
		public unsafe override RuntimeTypeHandle TypeHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291820, XrefRangeEnd = 291827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionOnlyType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00005DC6 File Offset: 0x00003FC6
		public ReflectionOnlyType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0;
	}
}
