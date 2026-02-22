using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200001C RID: 28
	public class GridLayoutGroup : LayoutGroup
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x00015D2C File Offset: 0x00013F2C
		// Note: this type is marked as 'beforefieldinit'.
		static GridLayoutGroup()
		{
			Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GridLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr);
			GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_StartCorner");
			GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_StartAxis");
			GridLayoutGroup.NativeFieldInfoPtr_m_CellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_CellSize");
			GridLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_Spacing");
			GridLayoutGroup.NativeFieldInfoPtr_m_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_Constraint");
			GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_ConstraintCount");
			GridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663860);
			GridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663861);
			GridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663862);
			GridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663863);
			GridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663864);
			GridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663865);
			GridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663866);
			GridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663867);
			GridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663868);
			GridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663869);
			GridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663870);
			GridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663871);
			GridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663872);
			GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663873);
			GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663874);
			GridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663875);
			GridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663876);
			GridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663877);
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00015F3C File Offset: 0x0001413C
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00015F78 File Offset: 0x00014178
		public unsafe GridLayoutGroup.Corner startCorner
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24292, RefRangeEnd = 24293, XrefRangeStart = 24292, XrefRangeEnd = 24293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114549, XrefRangeEnd = 114561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00015FB8 File Offset: 0x000141B8
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00015FF4 File Offset: 0x000141F4
		public unsafe GridLayoutGroup.Axis startAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114561, XrefRangeEnd = 114564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00016034 File Offset: 0x00014234
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00016070 File Offset: 0x00014270
		public unsafe Vector2 cellSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114564, XrefRangeEnd = 114567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000160B0 File Offset: 0x000142B0
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000160EC File Offset: 0x000142EC
		public unsafe Vector2 spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114567, XrefRangeEnd = 114570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0001612C File Offset: 0x0001432C
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00016168 File Offset: 0x00014368
		public unsafe GridLayoutGroup.Constraint constraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114570, XrefRangeEnd = 114573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x000161A8 File Offset: 0x000143A8
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x000161E4 File Offset: 0x000143E4
		public unsafe int constraintCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114573, XrefRangeEnd = 114577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00016224 File Offset: 0x00014424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114577, XrefRangeEnd = 114579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00016260 File Offset: 0x00014460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114579, XrefRangeEnd = 114591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001629C File Offset: 0x0001449C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114591, XrefRangeEnd = 114603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000162D8 File Offset: 0x000144D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114603, XrefRangeEnd = 114604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00016314 File Offset: 0x00014514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114604, XrefRangeEnd = 114605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00016350 File Offset: 0x00014550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114643, RefRangeEnd = 114645, XrefRangeStart = 114605, XrefRangeEnd = 114643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCellsAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000035B8 File Offset: 0x000017B8
		public GridLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00016390 File Offset: 0x00014590
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x000035C1 File Offset: 0x000017C1
		public unsafe GridLayoutGroup.Corner m_StartCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000163B8 File Offset: 0x000145B8
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000035DC File Offset: 0x000017DC
		public unsafe GridLayoutGroup.Axis m_StartAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000163E0 File Offset: 0x000145E0
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x000035F7 File Offset: 0x000017F7
		public unsafe Vector2 m_CellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_CellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_CellSize)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00016408 File Offset: 0x00014608
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003612 File Offset: 0x00001812
		public unsafe Vector2 m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00016430 File Offset: 0x00014630
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0000362D File Offset: 0x0000182D
		public unsafe GridLayoutGroup.Constraint m_Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Constraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Constraint)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00016458 File Offset: 0x00014658
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00003648 File Offset: 0x00001848
		public unsafe int m_ConstraintCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount)) = value;
			}
		}

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_m_StartCorner;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAxis;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_m_CellSize;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_m_Constraint;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_m_ConstraintCount;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0;

		// Token: 0x0200009A RID: 154
		public enum Corner
		{
			// Token: 0x04000955 RID: 2389
			UpperLeft,
			// Token: 0x04000956 RID: 2390
			UpperRight,
			// Token: 0x04000957 RID: 2391
			LowerLeft,
			// Token: 0x04000958 RID: 2392
			LowerRight
		}

		// Token: 0x0200009B RID: 155
		public enum Axis
		{
			// Token: 0x0400095A RID: 2394
			Horizontal,
			// Token: 0x0400095B RID: 2395
			Vertical
		}

		// Token: 0x0200009C RID: 156
		public enum Constraint
		{
			// Token: 0x0400095D RID: 2397
			Flexible,
			// Token: 0x0400095E RID: 2398
			FixedColumnCount,
			// Token: 0x0400095F RID: 2399
			FixedRowCount
		}
	}
}
