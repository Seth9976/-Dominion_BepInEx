using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000093 RID: 147
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x06000F34 RID: 3892 RVA: 0x0003F800 File Offset: 0x0003DA00
		// Note: this type is marked as 'beforefieldinit'.
		static RangeAttribute()
		{
			Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr);
			RangeAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "min");
			RangeAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "max");
			RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, 100664261);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0003F86C File Offset: 0x0003DA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67897, XrefRangeEnd = 67898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeAttribute(float min, float max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00009A89 File Offset: 0x00007C89
		public RangeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0003F8C4 File Offset: 0x0003DAC4
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00009A92 File Offset: 0x00007C92
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0003F8EC File Offset: 0x0003DAEC
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00009AAD File Offset: 0x00007CAD
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
	}
}
