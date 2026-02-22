using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000DC RID: 220
	public class Page : Object
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x00032104 File Offset: 0x00030304
		// Note: this type is marked as 'beforefieldinit'.
		static Page()
		{
			Il2CppClassPointerStore<Page>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Page");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Page>.NativeClassPtr);
			Page.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "<disposed>k__BackingField");
			Page.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "vertices");
			Page.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "indices");
			Page.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "next");
			Page.NativeFieldInfoPtr_framesEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "framesEmpty");
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00007CC1 File Offset: 0x00005EC1
		public Page(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00032198 File Offset: 0x00030398
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00007CCA File Offset: 0x00005ECA
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000321C0 File Offset: 0x000303C0
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00007CE5 File Offset: 0x00005EE5
		public unsafe Page.DataSet<Vertex> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page.DataSet<Vertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000321F0 File Offset: 0x000303F0
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00007D04 File Offset: 0x00005F04
		public unsafe Page.DataSet<ushort> indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page.DataSet<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00032220 File Offset: 0x00030420
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00007D23 File Offset: 0x00005F23
		public unsafe Page next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00032250 File Offset: 0x00030450
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00007D42 File Offset: 0x00005F42
		public unsafe int framesEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_framesEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_framesEmpty)) = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00007D5D File Offset: 0x00005F5D
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00007D65 File Offset: 0x00005F65
		public bool disposed
		{
			get
			{
				return this._disposed_k__BackingField;
			}
			set
			{
				this._disposed_k__BackingField = value;
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00007D6E File Offset: 0x00005F6E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00032278 File Offset: 0x00030478
		public virtual void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				if (disposing)
				{
					this.indices.Dispose();
					this.vertices.Dispose();
				}
				this.disposed = true;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x000322BC File Offset: 0x000304BC
		public bool isEmpty
		{
			get
			{
				return this.vertices.allocator.isEmpty && this.indices.allocator.isEmpty;
			}
		}

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr_indices;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_framesEmpty;

		// Token: 0x0200022C RID: 556
		public class DataSet<T> : Object where T : new()
		{
			// Token: 0x060013EA RID: 5098 RVA: 0x0003CDCC File Offset: 0x0003AFCC
			// Note: this type is marked as 'beforefieldinit'.
			static DataSet()
			{
				Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Page>.NativeClassPtr, "DataSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr);
				Page.DataSet<T>.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "<disposed>k__BackingField");
				Page.DataSet<T>.NativeFieldInfoPtr_gpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "gpuData");
				Page.DataSet<T>.NativeFieldInfoPtr_cpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "cpuData");
				Page.DataSet<T>.NativeFieldInfoPtr_updateRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "updateRanges");
				Page.DataSet<T>.NativeFieldInfoPtr_allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "allocator");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangePoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangePoolSize");
				Page.DataSet<T>.NativeFieldInfoPtr_m_ElemStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_ElemStride");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangeMin");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangeMax");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesEnqueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangesEnqueued");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesBatchStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangesBatchStart");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesSaturated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangesSaturated");
			}

			// Token: 0x060013EB RID: 5099 RVA: 0x0000CBE7 File Offset: 0x0000ADE7
			public DataSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x060013EC RID: 5100 RVA: 0x0003CF24 File Offset: 0x0003B124
			// (set) Token: 0x060013ED RID: 5101 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
			public unsafe bool _disposed_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr__disposed_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x060013EE RID: 5102 RVA: 0x0003CF4C File Offset: 0x0003B14C
			// (set) Token: 0x060013EF RID: 5103 RVA: 0x0000CC0B File Offset: 0x0000AE0B
			public unsafe Utility.GPUBuffer<T> gpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_gpuData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Utility.GPUBuffer<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_gpuData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0003CF7C File Offset: 0x0003B17C
			// (set) Token: 0x060013F1 RID: 5105 RVA: 0x0000CC2A File Offset: 0x0000AE2A
			public NativeArray<T> cpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_cpuData);
					return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_cpuData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0003CFAC File Offset: 0x0003B1AC
			// (set) Token: 0x060013F3 RID: 5107 RVA: 0x0000CC58 File Offset: 0x0000AE58
			public NativeArray<GfxUpdateBufferRange> updateRanges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_updateRanges);
					return new NativeArray<GfxUpdateBufferRange>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GfxUpdateBufferRange>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_updateRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GfxUpdateBufferRange>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0003CFDC File Offset: 0x0003B1DC
			// (set) Token: 0x060013F5 RID: 5109 RVA: 0x0000CC86 File Offset: 0x0000AE86
			public unsafe GPUBufferAllocator allocator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_allocator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPUBufferAllocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0003D00C File Offset: 0x0003B20C
			// (set) Token: 0x060013F7 RID: 5111 RVA: 0x0000CCA5 File Offset: 0x0000AEA5
			public unsafe uint m_UpdateRangePoolSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangePoolSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangePoolSize)) = value;
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0003D034 File Offset: 0x0003B234
			// (set) Token: 0x060013F9 RID: 5113 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
			public unsafe uint m_ElemStride
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_ElemStride);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_ElemStride)) = value;
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x060013FA RID: 5114 RVA: 0x0003D05C File Offset: 0x0003B25C
			// (set) Token: 0x060013FB RID: 5115 RVA: 0x0000CCDB File Offset: 0x0000AEDB
			public unsafe uint m_UpdateRangeMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMin)) = value;
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x060013FC RID: 5116 RVA: 0x0003D084 File Offset: 0x0003B284
			// (set) Token: 0x060013FD RID: 5117 RVA: 0x0000CCF6 File Offset: 0x0000AEF6
			public unsafe uint m_UpdateRangeMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMax)) = value;
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x060013FE RID: 5118 RVA: 0x0003D0AC File Offset: 0x0003B2AC
			// (set) Token: 0x060013FF RID: 5119 RVA: 0x0000CD11 File Offset: 0x0000AF11
			public unsafe uint m_UpdateRangesEnqueued
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesEnqueued);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesEnqueued)) = value;
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001400 RID: 5120 RVA: 0x0003D0D4 File Offset: 0x0003B2D4
			// (set) Token: 0x06001401 RID: 5121 RVA: 0x0000CD2C File Offset: 0x0000AF2C
			public unsafe uint m_UpdateRangesBatchStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesBatchStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesBatchStart)) = value;
				}
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06001402 RID: 5122 RVA: 0x0003D0FC File Offset: 0x0003B2FC
			// (set) Token: 0x06001403 RID: 5123 RVA: 0x0000CD47 File Offset: 0x0000AF47
			public unsafe bool m_UpdateRangesSaturated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesSaturated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesSaturated)) = value;
				}
			}

			// Token: 0x040008F8 RID: 2296
			private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

			// Token: 0x040008F9 RID: 2297
			private static readonly IntPtr NativeFieldInfoPtr_gpuData;

			// Token: 0x040008FA RID: 2298
			private static readonly IntPtr NativeFieldInfoPtr_cpuData;

			// Token: 0x040008FB RID: 2299
			private static readonly IntPtr NativeFieldInfoPtr_updateRanges;

			// Token: 0x040008FC RID: 2300
			private static readonly IntPtr NativeFieldInfoPtr_allocator;

			// Token: 0x040008FD RID: 2301
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangePoolSize;

			// Token: 0x040008FE RID: 2302
			private static readonly IntPtr NativeFieldInfoPtr_m_ElemStride;

			// Token: 0x040008FF RID: 2303
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangeMin;

			// Token: 0x04000900 RID: 2304
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangeMax;

			// Token: 0x04000901 RID: 2305
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangesEnqueued;

			// Token: 0x04000902 RID: 2306
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangesBatchStart;

			// Token: 0x04000903 RID: 2307
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangesSaturated;
		}
	}
}
