using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000091 RID: 145
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x0003F61C File Offset: 0x0003D81C
		// Note: this type is marked as 'beforefieldinit'.
		static SpaceAttribute()
		{
			Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr);
			SpaceAttribute.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, "height");
			SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100664258);
			SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100664259);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0003F688 File Offset: 0x0003D888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67895, XrefRangeEnd = 67896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpaceAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0003F6C4 File Offset: 0x0003D8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67896, XrefRangeEnd = 67897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpaceAttribute(float height)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00009A3D File Offset: 0x00007C3D
		public SpaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0003F70C File Offset: 0x0003D90C
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00009A46 File Offset: 0x00007C46
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
