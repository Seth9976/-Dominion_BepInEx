using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000094 RID: 148
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x0003F914 File Offset: 0x0003DB14
		// Note: this type is marked as 'beforefieldinit'.
		static MultilineAttribute()
		{
			Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MultilineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr);
			MultilineAttribute.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, "lines");
			MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, 100664262);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0003F96C File Offset: 0x0003DB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67898, XrefRangeEnd = 67899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultilineAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00009AC8 File Offset: 0x00007CC8
		public MultilineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0003F9A8 File Offset: 0x0003DBA8
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x00009AD1 File Offset: 0x00007CD1
		public unsafe int lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines)) = value;
			}
		}

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeFieldInfoPtr_lines;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
