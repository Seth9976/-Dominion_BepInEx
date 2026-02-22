using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000015 RID: 21
	public class TailoringInfo : Object
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00025080 File Offset: 0x00023280
		// Note: this type is marked as 'beforefieldinit'.
		static TailoringInfo()
		{
			Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "TailoringInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr);
			TailoringInfo.NativeFieldInfoPtr_LCID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "LCID");
			TailoringInfo.NativeFieldInfoPtr_TailoringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "TailoringIndex");
			TailoringInfo.NativeFieldInfoPtr_TailoringCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "TailoringCount");
			TailoringInfo.NativeFieldInfoPtr_FrenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "FrenchSort");
			TailoringInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, 100663413);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00025114 File Offset: 0x00023314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258830, XrefRangeEnd = 258831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailoringIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailoringCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frenchSort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailoringInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002429 File Offset: 0x00000629
		public TailoringInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00025188 File Offset: 0x00023388
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002432 File Offset: 0x00000632
		public unsafe int LCID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_LCID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_LCID)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000251B0 File Offset: 0x000233B0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000244D File Offset: 0x0000064D
		public unsafe int TailoringIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringIndex)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000251D8 File Offset: 0x000233D8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002468 File Offset: 0x00000668
		public unsafe int TailoringCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringCount)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00025200 File Offset: 0x00023400
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002483 File Offset: 0x00000683
		public unsafe bool FrenchSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_FrenchSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_FrenchSort)) = value;
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_LCID;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_TailoringIndex;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_TailoringCount;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_FrenchSort;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0;
	}
}
