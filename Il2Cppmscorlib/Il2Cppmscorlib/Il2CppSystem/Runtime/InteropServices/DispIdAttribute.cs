using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200043B RID: 1083
	public sealed class DispIdAttribute : Attribute
	{
		// Token: 0x06004292 RID: 17042 RVA: 0x00132320 File Offset: 0x00130520
		// Note: this type is marked as 'beforefieldinit'.
		static DispIdAttribute()
		{
			Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DispIdAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr);
			DispIdAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr, "_val");
			DispIdAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr, 100672962);
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x00132378 File Offset: 0x00130578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DispIdAttribute(int dispId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispIdAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dispId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispIdAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x00019776 File Offset: 0x00017976
		public DispIdAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x001323C0 File Offset: 0x001305C0
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x0001977F File Offset: 0x0001797F
		public unsafe int _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispIdAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispIdAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x04003614 RID: 13844
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04003615 RID: 13845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
