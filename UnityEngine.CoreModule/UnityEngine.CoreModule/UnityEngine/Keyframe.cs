using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000034 RID: 52
	[StructLayout(2)]
	public struct Keyframe
	{
		// Token: 0x0600015F RID: 351 RVA: 0x0001A058 File Offset: 0x00018258
		// Note: this type is marked as 'beforefieldinit'.
		static Keyframe()
		{
			Il2CppClassPointerStore<Keyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Keyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyframe>.NativeClassPtr);
			Keyframe.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Time");
			Keyframe.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Value");
			Keyframe.NativeFieldInfoPtr_m_InTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InTangent");
			Keyframe.NativeFieldInfoPtr_m_OutTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutTangent");
			Keyframe.NativeFieldInfoPtr_m_WeightedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_WeightedMode");
			Keyframe.NativeFieldInfoPtr_m_InWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InWeight");
			Keyframe.NativeFieldInfoPtr_m_OutWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutWeight");
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663356);
			Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663357);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0001A13C File Offset: 0x0001833C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 59132, RefRangeEnd = 59142, XrefRangeStart = 59132, XrefRangeEnd = 59132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe(float time, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0001A17C File Offset: 0x0001837C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002F47 File Offset: 0x00001147
		public unsafe float value
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 59142, RefRangeEnd = 59224, XrefRangeStart = 59142, XrefRangeEnd = 59142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002F2B File Offset: 0x0000112B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, ref this));
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0001A1AC File Offset: 0x000183AC
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002F3D File Offset: 0x0000113D
		public float time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0001A1C4 File Offset: 0x000183C4
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002F51 File Offset: 0x00001151
		public float inTangent
		{
			get
			{
				return this.m_InTangent;
			}
			set
			{
				this.m_InTangent = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0001A1DC File Offset: 0x000183DC
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002F5B File Offset: 0x0000115B
		public float outTangent
		{
			get
			{
				return this.m_OutTangent;
			}
			set
			{
				this.m_OutTangent = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0001A1F4 File Offset: 0x000183F4
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002F65 File Offset: 0x00001165
		public float inWeight
		{
			get
			{
				return this.m_InWeight;
			}
			set
			{
				this.m_InWeight = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0001A20C File Offset: 0x0001840C
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002F6F File Offset: 0x0000116F
		public float outWeight
		{
			get
			{
				return this.m_OutWeight;
			}
			set
			{
				this.m_OutWeight = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001A224 File Offset: 0x00018424
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002F79 File Offset: 0x00001179
		public WeightedMode weightedMode
		{
			get
			{
				return (WeightedMode)this.m_WeightedMode;
			}
			set
			{
				this.m_WeightedMode = (int)value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0001A23C File Offset: 0x0001843C
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002F83 File Offset: 0x00001183
		public int tangentMode
		{
			get
			{
				return this.tangentModeInternal;
			}
			set
			{
				this.tangentModeInternal = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0001A254 File Offset: 0x00018454
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002F8E File Offset: 0x0000118E
		public int tangentModeInternal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_m_InTangent;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_m_OutTangent;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_m_WeightedMode;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_m_InWeight;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_m_OutWeight;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x0400010A RID: 266
		[FieldOffset(0)]
		public float m_Time;

		// Token: 0x0400010B RID: 267
		[FieldOffset(4)]
		public float m_Value;

		// Token: 0x0400010C RID: 268
		[FieldOffset(8)]
		public float m_InTangent;

		// Token: 0x0400010D RID: 269
		[FieldOffset(12)]
		public float m_OutTangent;

		// Token: 0x0400010E RID: 270
		[FieldOffset(16)]
		public int m_WeightedMode;

		// Token: 0x0400010F RID: 271
		[FieldOffset(20)]
		public float m_InWeight;

		// Token: 0x04000110 RID: 272
		[FieldOffset(24)]
		public float m_OutWeight;
	}
}
