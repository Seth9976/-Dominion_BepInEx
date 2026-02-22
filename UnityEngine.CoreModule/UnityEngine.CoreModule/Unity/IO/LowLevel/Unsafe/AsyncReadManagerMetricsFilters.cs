using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000014 RID: 20
	public class AsyncReadManagerMetricsFilters : Object
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000186D0 File Offset: 0x000168D0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerMetricsFilters()
		{
			Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerMetricsFilters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr);
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "TypeIDs");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "States");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "ReadTypes");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "PriorityLevels");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "Subsystems");
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000263A File Offset: 0x0000083A
		public AsyncReadManagerMetricsFilters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00018764 File Offset: 0x00016964
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe Il2CppStructArray<ulong> TypeIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00018794 File Offset: 0x00016994
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002662 File Offset: 0x00000862
		public unsafe Il2CppStructArray<ProcessingState> States
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ProcessingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000187C4 File Offset: 0x000169C4
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002681 File Offset: 0x00000881
		public unsafe Il2CppStructArray<FileReadType> ReadTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FileReadType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000187F4 File Offset: 0x000169F4
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000026A0 File Offset: 0x000008A0
		public unsafe Il2CppStructArray<Priority> PriorityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Priority>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00018824 File Offset: 0x00016A24
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000026BF File Offset: 0x000008BF
		public unsafe Il2CppStructArray<AssetLoadingSubsystem> Subsystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AssetLoadingSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000026DE File Offset: 0x000008DE
		public void SetTypeIDFilter(Il2CppStructArray<ulong> _typeIDs)
		{
			this.TypeIDs = _typeIDs;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000026E8 File Offset: 0x000008E8
		public void SetStateFilter(Il2CppStructArray<ProcessingState> _states)
		{
			this.States = _states;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000026F2 File Offset: 0x000008F2
		public void SetReadTypeFilter(Il2CppStructArray<FileReadType> _readTypes)
		{
			this.ReadTypes = _readTypes;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000026FC File Offset: 0x000008FC
		public void SetPriorityFilter(Il2CppStructArray<Priority> _priorityLevels)
		{
			this.PriorityLevels = _priorityLevels;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002706 File Offset: 0x00000906
		public void SetSubsystemFilter(Il2CppStructArray<AssetLoadingSubsystem> _subsystems)
		{
			this.Subsystems = _subsystems;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002710 File Offset: 0x00000910
		public void SetTypeIDFilter(ulong _typeID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000271D File Offset: 0x0000091D
		public void SetStateFilter(ProcessingState _state)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000272A File Offset: 0x0000092A
		public void SetReadTypeFilter(FileReadType _readType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002737 File Offset: 0x00000937
		public void SetPriorityFilter(Priority _priorityLevel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002744 File Offset: 0x00000944
		public void SetSubsystemFilter(AssetLoadingSubsystem _subsystem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002751 File Offset: 0x00000951
		public void RemoveTypeIDFilter()
		{
			this.TypeIDs = null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000275B File Offset: 0x0000095B
		public void RemoveStateFilter()
		{
			this.States = null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002765 File Offset: 0x00000965
		public void RemoveReadTypeFilter()
		{
			this.ReadTypes = null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000276F File Offset: 0x0000096F
		public void RemovePriorityFilter()
		{
			this.PriorityLevels = null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002779 File Offset: 0x00000979
		public void RemoveSubsystemFilter()
		{
			this.Subsystems = null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002783 File Offset: 0x00000983
		public void ClearFilters()
		{
			this.RemoveTypeIDFilter();
			this.RemoveStateFilter();
			this.RemoveReadTypeFilter();
			this.RemovePriorityFilter();
			this.RemoveSubsystemFilter();
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_TypeIDs;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_States;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_ReadTypes;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_PriorityLevels;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_Subsystems;
	}
}
