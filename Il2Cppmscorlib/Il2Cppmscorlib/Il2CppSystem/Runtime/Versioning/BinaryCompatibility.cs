using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Versioning
{
	// Token: 0x02000325 RID: 805
	public static class BinaryCompatibility : Object
	{
		// Token: 0x06003435 RID: 13365 RVA: 0x000FFE28 File Offset: 0x000FE028
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCompatibility()
		{
			Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Versioning", "BinaryCompatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
			BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5");
			BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5_1");
			BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100671399);
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x000FFE94 File Offset: 0x000FE094
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_2
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x000129F3 File Offset: 0x00010BF3
		public BinaryCompatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x000FFEC4 File Offset: 0x000FE0C4
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x000129FC File Offset: 0x00010BFC
		public unsafe static bool TargetsAtLeast_Desktop_V4_5
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x000FFEE0 File Offset: 0x000FE0E0
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x00012A0A File Offset: 0x00010C0A
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_1
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&value));
			}
		}

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0;
	}
}
