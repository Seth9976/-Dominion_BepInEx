using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000441 RID: 1089
	public sealed class ComVisibleAttribute : Attribute
	{
		// Token: 0x060042A6 RID: 17062 RVA: 0x0013264C File Offset: 0x0013084C
		// Note: this type is marked as 'beforefieldinit'.
		static ComVisibleAttribute()
		{
			Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComVisibleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr);
			ComVisibleAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr, "_val");
			ComVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr, 100672966);
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x001326A4 File Offset: 0x001308A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComVisibleAttribute(bool visibility)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visibility;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x0001980A File Offset: 0x00017A0A
		public ComVisibleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x001326EC File Offset: 0x001308EC
		// (set) Token: 0x060042AA RID: 17066 RVA: 0x00019813 File Offset: 0x00017A13
		public unsafe bool _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComVisibleAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComVisibleAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x04003625 RID: 13861
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04003626 RID: 13862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
