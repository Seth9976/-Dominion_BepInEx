using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000038 RID: 56
	public static class StencilMaterial : Object
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x0002304C File Offset: 0x0002124C
		// Note: this type is marked as 'beforefieldinit'.
		static StencilMaterial()
		{
			Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "StencilMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr);
			StencilMaterial.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, "m_List");
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664355);
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664356);
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664357);
			StencilMaterial.NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664358);
			StencilMaterial.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664359);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000230F4 File Offset: 0x000212F4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00023148 File Offset: 0x00021348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118688, RefRangeEnd = 118690, XrefRangeStart = 118684, XrefRangeEnd = 118688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorWriteMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000231C4 File Offset: 0x000213C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 118747, RefRangeEnd = 118753, XrefRangeStart = 118690, XrefRangeEnd = 118747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorWriteMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readMask;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0002325C File Offset: 0x0002145C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 118779, RefRangeEnd = 118789, XrefRangeStart = 118753, XrefRangeEnd = 118779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Remove(Material customMat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customMat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00023294 File Offset: 0x00021494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118789, XrefRangeEnd = 118807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000486A File Offset: 0x00002A6A
		public StencilMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x000232BC File Offset: 0x000214BC
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00004873 File Offset: 0x00002A73
		public unsafe static List<StencilMaterial.MatEntry> m_List
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StencilMaterial.NativeFieldInfoPtr_m_List, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StencilMaterial.MatEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StencilMaterial.NativeFieldInfoPtr_m_List, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_ClearAll_Public_Static_Void_0;

		// Token: 0x020000B1 RID: 177
		public class MatEntry : Object
		{
			// Token: 0x06000C69 RID: 3177 RVA: 0x00035E68 File Offset: 0x00034068
			// Note: this type is marked as 'beforefieldinit'.
			static MatEntry()
			{
				Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, "MatEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr);
				StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "baseMat");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "customMat");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "count");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "stencilId");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "operation");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "compareFunction");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "readMask");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "writeMask");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "useAlphaClip");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "colorMask");
				StencilMaterial.MatEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, 100665045);
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x00035F70 File Offset: 0x00034170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118683, XrefRangeEnd = 118684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.MatEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C6B RID: 3179 RVA: 0x00006A0B File Offset: 0x00004C0B
			public MatEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00035FAC File Offset: 0x000341AC
			// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00006A14 File Offset: 0x00004C14
			public unsafe Material baseMat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00035FDC File Offset: 0x000341DC
			// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00006A33 File Offset: 0x00004C33
			public unsafe Material customMat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0003600C File Offset: 0x0003420C
			// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00006A52 File Offset: 0x00004C52
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00036034 File Offset: 0x00034234
			// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00006A6D File Offset: 0x00004C6D
			public unsafe int stencilId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId)) = value;
				}
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0003605C File Offset: 0x0003425C
			// (set) Token: 0x06000C75 RID: 3189 RVA: 0x00006A88 File Offset: 0x00004C88
			public unsafe StencilOp operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_operation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_operation)) = value;
				}
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00036084 File Offset: 0x00034284
			// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00006AA3 File Offset: 0x00004CA3
			public unsafe CompareFunction compareFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction)) = value;
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000360AC File Offset: 0x000342AC
			// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00006ABE File Offset: 0x00004CBE
			public unsafe int readMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask)) = value;
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06000C7A RID: 3194 RVA: 0x000360D4 File Offset: 0x000342D4
			// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00006AD9 File Offset: 0x00004CD9
			public unsafe int writeMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask)) = value;
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06000C7C RID: 3196 RVA: 0x000360FC File Offset: 0x000342FC
			// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00006AF4 File Offset: 0x00004CF4
			public unsafe bool useAlphaClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip)) = value;
				}
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00036124 File Offset: 0x00034324
			// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00006B0F File Offset: 0x00004D0F
			public unsafe ColorWriteMask colorMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask)) = value;
				}
			}

			// Token: 0x040009C4 RID: 2500
			private static readonly IntPtr NativeFieldInfoPtr_baseMat;

			// Token: 0x040009C5 RID: 2501
			private static readonly IntPtr NativeFieldInfoPtr_customMat;

			// Token: 0x040009C6 RID: 2502
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040009C7 RID: 2503
			private static readonly IntPtr NativeFieldInfoPtr_stencilId;

			// Token: 0x040009C8 RID: 2504
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x040009C9 RID: 2505
			private static readonly IntPtr NativeFieldInfoPtr_compareFunction;

			// Token: 0x040009CA RID: 2506
			private static readonly IntPtr NativeFieldInfoPtr_readMask;

			// Token: 0x040009CB RID: 2507
			private static readonly IntPtr NativeFieldInfoPtr_writeMask;

			// Token: 0x040009CC RID: 2508
			private static readonly IntPtr NativeFieldInfoPtr_useAlphaClip;

			// Token: 0x040009CD RID: 2509
			private static readonly IntPtr NativeFieldInfoPtr_colorMask;

			// Token: 0x040009CE RID: 2510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
