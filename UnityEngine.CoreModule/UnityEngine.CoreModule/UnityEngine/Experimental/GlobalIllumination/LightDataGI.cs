using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000162 RID: 354
	[StructLayout(2)]
	public struct LightDataGI
	{
		// Token: 0x06001A94 RID: 6804 RVA: 0x0005EDD4 File Offset: 0x0005CFD4
		// Note: this type is marked as 'beforefieldinit'.
		static LightDataGI()
		{
			Il2CppClassPointerStore<LightDataGI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightDataGI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr);
			LightDataGI.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "instanceID");
			LightDataGI.NativeFieldInfoPtr_cookieID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieID");
			LightDataGI.NativeFieldInfoPtr_cookieScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieScale");
			LightDataGI.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "color");
			LightDataGI.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "indirectColor");
			LightDataGI.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "orientation");
			LightDataGI.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "position");
			LightDataGI.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "range");
			LightDataGI.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "coneAngle");
			LightDataGI.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "innerConeAngle");
			LightDataGI.NativeFieldInfoPtr_shape0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape0");
			LightDataGI.NativeFieldInfoPtr_shape1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape1");
			LightDataGI.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "type");
			LightDataGI.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "mode");
			LightDataGI.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shadow");
			LightDataGI.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "falloff");
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100665239);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100665240);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100665241);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100665242);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100665243);
			LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100665244);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0005EFBC File Offset: 0x0005D1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82880, RefRangeEnd = 82881, XrefRangeStart = 82880, XrefRangeEnd = 82880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref DirectionalLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0005EFFC File Offset: 0x0005D1FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82881, RefRangeEnd = 82882, XrefRangeStart = 82881, XrefRangeEnd = 82881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref PointLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0005F03C File Offset: 0x0005D23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82882, RefRangeEnd = 82883, XrefRangeStart = 82882, XrefRangeEnd = 82882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref SpotLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0005F07C File Offset: 0x0005D27C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82883, RefRangeEnd = 82884, XrefRangeStart = 82883, XrefRangeEnd = 82883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref RectangleLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82884, RefRangeEnd = 82885, XrefRangeStart = 82884, XrefRangeEnd = 82884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref DiscLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0005F0FC File Offset: 0x0005D2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82885, RefRangeEnd = 82886, XrefRangeStart = 82885, XrefRangeEnd = 82885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoBake(int lightInstanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightInstanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, ref this));
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0005F130 File Offset: 0x0005D330
		public void Init(ref DirectionalLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0005F150 File Offset: 0x0005D350
		public void Init(ref PointLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0005F170 File Offset: 0x0005D370
		public void Init(ref SpotLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0005F190 File Offset: 0x0005D390
		public void Init(ref RectangleLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0005F1B0 File Offset: 0x0005D3B0
		public void Init(ref DiscLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeFieldInfoPtr_cookieID;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeFieldInfoPtr_cookieScale;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeFieldInfoPtr_shape0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeFieldInfoPtr_shape1;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0;

		// Token: 0x040013FC RID: 5116
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040013FD RID: 5117
		[FieldOffset(4)]
		public int cookieID;

		// Token: 0x040013FE RID: 5118
		[FieldOffset(8)]
		public float cookieScale;

		// Token: 0x040013FF RID: 5119
		[FieldOffset(12)]
		public LinearColor color;

		// Token: 0x04001400 RID: 5120
		[FieldOffset(28)]
		public LinearColor indirectColor;

		// Token: 0x04001401 RID: 5121
		[FieldOffset(44)]
		public Quaternion orientation;

		// Token: 0x04001402 RID: 5122
		[FieldOffset(60)]
		public Vector3 position;

		// Token: 0x04001403 RID: 5123
		[FieldOffset(72)]
		public float range;

		// Token: 0x04001404 RID: 5124
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x04001405 RID: 5125
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x04001406 RID: 5126
		[FieldOffset(84)]
		public float shape0;

		// Token: 0x04001407 RID: 5127
		[FieldOffset(88)]
		public float shape1;

		// Token: 0x04001408 RID: 5128
		[FieldOffset(92)]
		public LightType type;

		// Token: 0x04001409 RID: 5129
		[FieldOffset(93)]
		public LightMode mode;

		// Token: 0x0400140A RID: 5130
		[FieldOffset(94)]
		public byte shadow;

		// Token: 0x0400140B RID: 5131
		[FieldOffset(95)]
		public FalloffType falloff;
	}
}
