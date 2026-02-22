using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000163 RID: 355
	public static class LightmapperUtils : Object
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapperUtils()
		{
			Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightmapperUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665245);
			LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665246);
			LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665247);
			LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665248);
			LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665249);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665250);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665251);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665252);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665253);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665254);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100665255);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0005F2DC File Offset: 0x0005D4DC
		[CallerCount(0)]
		public unsafe static LightMode Extract(LightmapBakeType baketype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baketype;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0005F31C File Offset: 0x0005D51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82886, XrefRangeEnd = 82893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor ExtractIndirect(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0005F360 File Offset: 0x0005D560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82893, XrefRangeEnd = 82897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ExtractInnerCone(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0005F3A4 File Offset: 0x0005D5A4
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 64993, RefRangeEnd = 65022, XrefRangeStart = 64993, XrefRangeEnd = 65022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ExtractColorTemperature(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0005F3E8 File Offset: 0x0005D5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82897, XrefRangeEnd = 82900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cct;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0005F428 File Offset: 0x0005D628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82929, RefRangeEnd = 82930, XrefRangeStart = 82900, XrefRangeEnd = 82929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DirectionalLight dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0005F46C File Offset: 0x0005D66C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82961, RefRangeEnd = 82963, XrefRangeStart = 82930, XrefRangeEnd = 82961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref PointLight point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0005F4B0 File Offset: 0x0005D6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83000, RefRangeEnd = 83001, XrefRangeStart = 82963, XrefRangeEnd = 83000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref SpotLight spot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0005F4F4 File Offset: 0x0005D6F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83032, RefRangeEnd = 83033, XrefRangeStart = 83001, XrefRangeEnd = 83032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref RectangleLight rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0005F538 File Offset: 0x0005D738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82961, RefRangeEnd = 82963, XrefRangeStart = 82961, XrefRangeEnd = 82963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DiscLight disc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &disc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0005F57C File Offset: 0x0005D77C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 83055, RefRangeEnd = 83060, XrefRangeStart = 83033, XrefRangeEnd = 83055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, out Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0000EBDE File Offset: 0x0000CDDE
		public LightmapperUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0;
	}
}
