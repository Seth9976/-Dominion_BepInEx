using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000DC RID: 220
	[Serializable]
	public class Random : Object
	{
		// Token: 0x06000E6F RID: 3695 RVA: 0x00063B2C File Offset: 0x00061D2C
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeFieldInfoPtr_MBIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MBIG");
			Random.NativeFieldInfoPtr_MSEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MSEED");
			Random.NativeFieldInfoPtr_MZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MZ");
			Random.NativeFieldInfoPtr_inext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "inext");
			Random.NativeFieldInfoPtr_inextp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "inextp");
			Random.NativeFieldInfoPtr_SeedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "SeedArray");
			Random.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665726);
			Random.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665727);
			Random.NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665728);
			Random.NativeMethodInfoPtr_InternalSample_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665729);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665730);
			Random.NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665731);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665732);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665733);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00063C74 File Offset: 0x00061E74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290421, RefRangeEnd = 290425, XrefRangeStart = 290419, XrefRangeEnd = 290421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Random()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00063CB0 File Offset: 0x00061EB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290433, RefRangeEnd = 290437, XrefRangeStart = 290425, XrefRangeEnd = 290433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Random(int Seed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00063CF8 File Offset: 0x00061EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290437, XrefRangeEnd = 290438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double Sample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00063D40 File Offset: 0x00061F40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 290438, RefRangeEnd = 290444, XrefRangeStart = 290438, XrefRangeEnd = 290438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalSample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_InternalSample_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00063D7C File Offset: 0x00061F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290444, XrefRangeEnd = 290445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00063DC4 File Offset: 0x00061FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290445, XrefRangeEnd = 290447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetSampleForLargeRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00063E00 File Offset: 0x00062000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290447, XrefRangeEnd = 290449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Next(int minValue, int maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00063E64 File Offset: 0x00062064
		[CallerCount(0)]
		public unsafe virtual int Next(int maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00005BC5 File Offset: 0x00003DC5
		public Random(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00063EB8 File Offset: 0x000620B8
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x00005BCE File Offset: 0x00003DCE
		public unsafe static int MBIG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MBIG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MBIG, (void*)(&value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00063ED4 File Offset: 0x000620D4
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x00005BDC File Offset: 0x00003DDC
		public unsafe static int MSEED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MSEED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MSEED, (void*)(&value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00063EF0 File Offset: 0x000620F0
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x00005BEA File Offset: 0x00003DEA
		public unsafe static int MZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MZ, (void*)(&value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00063F0C File Offset: 0x0006210C
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x00005BF8 File Offset: 0x00003DF8
		public unsafe int inext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inext)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00063F34 File Offset: 0x00062134
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x00005C13 File Offset: 0x00003E13
		public unsafe int inextp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inextp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inextp)) = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00063F5C File Offset: 0x0006215C
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00005C2E File Offset: 0x00003E2E
		public unsafe Il2CppStructArray<int> SeedArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_SeedArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_SeedArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeFieldInfoPtr_MBIG;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr_MSEED;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr_MZ;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_inext;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeFieldInfoPtr_inextp;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_SeedArray;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_InternalSample_Private_Int32_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0;
	}
}
