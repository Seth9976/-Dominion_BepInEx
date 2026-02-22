using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200015B RID: 347
	[StructLayout(2)]
	public struct LinearColor
	{
		// Token: 0x06001A7B RID: 6779 RVA: 0x0005E4F4 File Offset: 0x0005C6F4
		// Note: this type is marked as 'beforefieldinit'.
		static LinearColor()
		{
			Il2CppClassPointerStore<LinearColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LinearColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearColor>.NativeClassPtr);
			LinearColor.NativeFieldInfoPtr_m_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_red");
			LinearColor.NativeFieldInfoPtr_m_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_green");
			LinearColor.NativeFieldInfoPtr_m_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_blue");
			LinearColor.NativeFieldInfoPtr_m_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_intensity");
			LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665231);
			LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665232);
			LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665233);
			LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665234);
			LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665235);
			LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665236);
			LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665237);
			LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100665238);
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0005E614 File Offset: 0x0005C814
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0005E644 File Offset: 0x0005C844
		public unsafe float red
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 61619, RefRangeEnd = 61697, XrefRangeStart = 61619, XrefRangeEnd = 61697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 82823, RefRangeEnd = 82834, XrefRangeStart = 82823, XrefRangeEnd = 82823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0005E678 File Offset: 0x0005C878
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0005E6A8 File Offset: 0x0005C8A8
		public unsafe float green
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 59142, RefRangeEnd = 59224, XrefRangeStart = 59142, XrefRangeEnd = 59224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 82834, RefRangeEnd = 82845, XrefRangeStart = 82834, XrefRangeEnd = 82834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0005E6DC File Offset: 0x0005C8DC
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0005E70C File Offset: 0x0005C90C
		public unsafe float blue
		{
			[CallerCount(139)]
			[CachedScanResults(RefRangeStart = 61772, RefRangeEnd = 61911, XrefRangeStart = 61772, XrefRangeEnd = 61911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 82845, RefRangeEnd = 82856, XrefRangeStart = 82845, XrefRangeEnd = 82845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0005E740 File Offset: 0x0005C940
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 82869, RefRangeEnd = 82880, XrefRangeStart = 82856, XrefRangeEnd = 82869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor Convert(Color color, float intensity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0005E78C File Offset: 0x0005C98C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 61594, RefRangeEnd = 61618, XrefRangeStart = 61594, XrefRangeEnd = 61618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor Black()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0000EB4E File Offset: 0x0000CD4E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, ref this));
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x0005E7BC File Offset: 0x0005C9BC
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x0005E7D4 File Offset: 0x0005C9D4
		public float intensity
		{
			get
			{
				return this.m_intensity;
			}
			set
			{
				bool flag = value < 0f;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Concat("Intensity (", value.ToString(), ") must be positive."));
				}
				this.m_intensity = value;
			}
		}

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeFieldInfoPtr_m_red;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeFieldInfoPtr_m_green;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr_m_blue;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_m_intensity;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_get_red_Public_get_Single_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_set_red_Public_set_Void_Single_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_get_green_Public_get_Single_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_set_green_Public_set_Void_Single_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_get_blue_Public_get_Single_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_Black_Public_Static_LinearColor_0;

		// Token: 0x04001372 RID: 4978
		[FieldOffset(0)]
		public float m_red;

		// Token: 0x04001373 RID: 4979
		[FieldOffset(4)]
		public float m_green;

		// Token: 0x04001374 RID: 4980
		[FieldOffset(8)]
		public float m_blue;

		// Token: 0x04001375 RID: 4981
		[FieldOffset(12)]
		public float m_intensity;
	}
}
