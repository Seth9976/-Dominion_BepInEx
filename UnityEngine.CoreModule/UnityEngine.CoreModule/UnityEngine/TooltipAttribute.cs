using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000090 RID: 144
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x06000F24 RID: 3876 RVA: 0x0003F550 File Offset: 0x0003D750
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipAttribute()
		{
			Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TooltipAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr);
			TooltipAttribute.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, "tooltip");
			TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, 100664257);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0003F5A8 File Offset: 0x0003D7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67894, XrefRangeEnd = 67895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipAttribute(string tooltip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00009A15 File Offset: 0x00007C15
		public TooltipAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0003F5F4 File Offset: 0x0003D7F4
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00009A1E File Offset: 0x00007C1E
		public unsafe string tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
