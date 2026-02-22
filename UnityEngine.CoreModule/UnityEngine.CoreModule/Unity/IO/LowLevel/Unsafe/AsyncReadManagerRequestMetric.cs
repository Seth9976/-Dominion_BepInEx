using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000013 RID: 19
	public sealed class AsyncReadManagerRequestMetric : ValueType
	{
		// Token: 0x0600005B RID: 91 RVA: 0x0001831C File Offset: 0x0001651C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerRequestMetric()
		{
			Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerRequestMetric");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr);
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<FileName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<OffsetBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<SizeBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetTypeId>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<CurrentBytesRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<BatchReadCount>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<IsBatchRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<State>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<ReadType>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<PriorityLevel>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<Subsystem>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<RequestTimeMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TimeInQueueMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TotalTimeMicroseconds>k__BackingField");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000240A File Offset: 0x0000060A
		public AsyncReadManagerRequestMetric(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002413 File Offset: 0x00000613
		public AsyncReadManagerRequestMetric()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr))
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00018478 File Offset: 0x00016678
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002425 File Offset: 0x00000625
		public unsafe string _AssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000184A0 File Offset: 0x000166A0
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002444 File Offset: 0x00000644
		public unsafe string _FileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000184C8 File Offset: 0x000166C8
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002463 File Offset: 0x00000663
		public unsafe ulong _OffsetBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000184F0 File Offset: 0x000166F0
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000247E File Offset: 0x0000067E
		public unsafe ulong _SizeBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00018518 File Offset: 0x00016718
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002499 File Offset: 0x00000699
		public unsafe ulong _AssetTypeId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00018540 File Offset: 0x00016740
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000024B4 File Offset: 0x000006B4
		public unsafe ulong _CurrentBytesRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00018568 File Offset: 0x00016768
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000024CF File Offset: 0x000006CF
		public unsafe uint _BatchReadCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00018590 File Offset: 0x00016790
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000024EA File Offset: 0x000006EA
		public unsafe bool _IsBatchRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000185B8 File Offset: 0x000167B8
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002505 File Offset: 0x00000705
		public unsafe ProcessingState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000185E0 File Offset: 0x000167E0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002520 File Offset: 0x00000720
		public unsafe FileReadType _ReadType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00018608 File Offset: 0x00016808
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000253B File Offset: 0x0000073B
		public unsafe Priority _PriorityLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00018630 File Offset: 0x00016830
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe AssetLoadingSubsystem _Subsystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00018658 File Offset: 0x00016858
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002571 File Offset: 0x00000771
		public unsafe double _RequestTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00018680 File Offset: 0x00016880
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000258C File Offset: 0x0000078C
		public unsafe double _TimeInQueueMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000186A8 File Offset: 0x000168A8
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000025A7 File Offset: 0x000007A7
		public unsafe double _TotalTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000025C2 File Offset: 0x000007C2
		public string AssetName
		{
			get
			{
				return this._AssetName_k__BackingField;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000025CA File Offset: 0x000007CA
		public string FileName
		{
			get
			{
				return this._FileName_k__BackingField;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000025D2 File Offset: 0x000007D2
		public ulong OffsetBytes
		{
			get
			{
				return this._OffsetBytes_k__BackingField;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000025DA File Offset: 0x000007DA
		public ulong SizeBytes
		{
			get
			{
				return this._SizeBytes_k__BackingField;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000025E2 File Offset: 0x000007E2
		public ulong AssetTypeId
		{
			get
			{
				return this._AssetTypeId_k__BackingField;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000025EA File Offset: 0x000007EA
		public ulong CurrentBytesRead
		{
			get
			{
				return this._CurrentBytesRead_k__BackingField;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000025F2 File Offset: 0x000007F2
		public uint BatchReadCount
		{
			get
			{
				return this._BatchReadCount_k__BackingField;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000025FA File Offset: 0x000007FA
		public bool IsBatchRead
		{
			get
			{
				return this._IsBatchRead_k__BackingField;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002602 File Offset: 0x00000802
		public ProcessingState State
		{
			get
			{
				return this._State_k__BackingField;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000260A File Offset: 0x0000080A
		public FileReadType ReadType
		{
			get
			{
				return this._ReadType_k__BackingField;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002612 File Offset: 0x00000812
		public Priority PriorityLevel
		{
			get
			{
				return this._PriorityLevel_k__BackingField;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000261A File Offset: 0x0000081A
		public AssetLoadingSubsystem Subsystem
		{
			get
			{
				return this._Subsystem_k__BackingField;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002622 File Offset: 0x00000822
		public double RequestTimeMicroseconds
		{
			get
			{
				return this._RequestTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000262A File Offset: 0x0000082A
		public double TimeInQueueMicroseconds
		{
			get
			{
				return this._TimeInQueueMicroseconds_k__BackingField;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002632 File Offset: 0x00000832
		public double TotalTimeMicroseconds
		{
			get
			{
				return this._TotalTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr__AssetName_k__BackingField;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr__OffsetBytes_k__BackingField;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr__SizeBytes_k__BackingField;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__AssetTypeId_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBytesRead_k__BackingField;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr__BatchReadCount_k__BackingField;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr__IsBatchRead_k__BackingField;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr__ReadType_k__BackingField;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr__PriorityLevel_k__BackingField;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr__Subsystem_k__BackingField;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField;
	}
}
