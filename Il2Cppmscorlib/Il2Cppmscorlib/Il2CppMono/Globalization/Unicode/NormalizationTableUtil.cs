using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x0200001B RID: 27
	public class NormalizationTableUtil : Object
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00026524 File Offset: 0x00024724
		// Note: this type is marked as 'beforefieldinit'.
		static NormalizationTableUtil()
		{
			Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "NormalizationTableUtil");
			NormalizationTableUtil.NativeFieldInfoPtr_Prop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Prop");
			NormalizationTableUtil.NativeFieldInfoPtr_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Map");
			NormalizationTableUtil.NativeFieldInfoPtr_Combining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Combining");
			NormalizationTableUtil.NativeFieldInfoPtr_Composite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Composite");
			NormalizationTableUtil.NativeFieldInfoPtr_Helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Helper");
			NormalizationTableUtil.NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, 100663445);
			NormalizationTableUtil.NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, 100663446);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000265D8 File Offset: 0x000247D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259188, XrefRangeEnd = 259267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PropIdx(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalizationTableUtil.NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00026618 File Offset: 0x00024818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259267, XrefRangeEnd = 259273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MapIdx(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalizationTableUtil.NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002711 File Offset: 0x00000911
		public NormalizationTableUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00026658 File Offset: 0x00024858
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000271A File Offset: 0x0000091A
		public unsafe static CodePointIndexer Prop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Prop, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Prop, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00026680 File Offset: 0x00024880
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe static CodePointIndexer Map
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Map, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Map, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000266A8 File Offset: 0x000248A8
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000273E File Offset: 0x0000093E
		public unsafe static CodePointIndexer Combining
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Combining, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Combining, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000266D0 File Offset: 0x000248D0
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002750 File Offset: 0x00000950
		public unsafe static CodePointIndexer Composite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Composite, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Composite, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000266F8 File Offset: 0x000248F8
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002762 File Offset: 0x00000962
		public unsafe static CodePointIndexer Helper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Helper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Helper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_Prop;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_Map;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_Combining;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_Composite;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_Helper;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0;
	}
}
