using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044D RID: 1101
	public sealed class FieldOffsetAttribute : Attribute
	{
		// Token: 0x060042DD RID: 17117 RVA: 0x00132E50 File Offset: 0x00131050
		// Note: this type is marked as 'beforefieldinit'.
		static FieldOffsetAttribute()
		{
			Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "FieldOffsetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr);
			FieldOffsetAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr, "_val");
			FieldOffsetAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr, 100672979);
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x00132EA8 File Offset: 0x001310A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldOffsetAttribute(int offset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldOffsetAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x00019AC8 File Offset: 0x00017CC8
		public FieldOffsetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x00132EF0 File Offset: 0x001310F0
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x00019AD1 File Offset: 0x00017CD1
		public unsafe int _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldOffsetAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldOffsetAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x0400369A RID: 13978
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x0400369B RID: 13979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
