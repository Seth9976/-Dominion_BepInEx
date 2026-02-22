using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200003A RID: 58
	[Serializable]
	[StructLayout(2)]
	public struct TMP_GlyphValueRecord
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x0001CAE0 File Offset: 0x0001ACE0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphValueRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphValueRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr);
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_XPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_XPlacement");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_YPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_YPlacement");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_XAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_XAdvance");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_YAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_YAdvance");
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663845);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663846);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663847);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663848);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663849);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663850);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663851);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663852);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663853);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663854);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663855);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663856);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0001CC50 File Offset: 0x0001AE50
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0001CC80 File Offset: 0x0001AE80
		public unsafe float xPlacement
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 61697, RefRangeEnd = 61704, XrefRangeStart = 61697, XrefRangeEnd = 61704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0001CCE4 File Offset: 0x0001AEE4
		public unsafe float yPlacement
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 61704, RefRangeEnd = 61712, XrefRangeStart = 61704, XrefRangeEnd = 61712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001CD18 File Offset: 0x0001AF18
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0001CD48 File Offset: 0x0001AF48
		public unsafe float xAdvance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 61911, RefRangeEnd = 61923, XrefRangeStart = 61911, XrefRangeEnd = 61923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001CD7C File Offset: 0x0001AF7C
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		public unsafe float yAdvance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62076, RefRangeEnd = 62088, XrefRangeStart = 62076, XrefRangeEnd = 62088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 61474, RefRangeEnd = 61587, XrefRangeStart = 61474, XrefRangeEnd = 61587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xPlacement;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yPlacement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAdvance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAdvance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001CE3C File Offset: 0x0001B03C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61593, RefRangeEnd = 61594, XrefRangeStart = 61593, XrefRangeEnd = 61594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001CE70 File Offset: 0x0001B070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphValueRecord(GlyphValueRecord valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001CEA4 File Offset: 0x0001B0A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140865, RefRangeEnd = 140868, XrefRangeStart = 140865, XrefRangeEnd = 140865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00004E4D File Offset: 0x0000304D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_m_XPlacement;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_m_YPlacement;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_m_XAdvance;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_m_YAdvance;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0;

		// Token: 0x04000443 RID: 1091
		[FieldOffset(0)]
		public float m_XPlacement;

		// Token: 0x04000444 RID: 1092
		[FieldOffset(4)]
		public float m_YPlacement;

		// Token: 0x04000445 RID: 1093
		[FieldOffset(8)]
		public float m_XAdvance;

		// Token: 0x04000446 RID: 1094
		[FieldOffset(12)]
		public float m_YAdvance;
	}
}
