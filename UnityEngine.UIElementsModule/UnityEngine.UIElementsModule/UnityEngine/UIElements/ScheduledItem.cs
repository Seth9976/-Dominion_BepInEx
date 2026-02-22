using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000027 RID: 39
	public class ScheduledItem : Object
	{
		// Token: 0x0600028E RID: 654 RVA: 0x00014398 File Offset: 0x00012598
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduledItem()
		{
			Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ScheduledItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr);
			ScheduledItem.NativeFieldInfoPtr_timerUpdateStopCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "timerUpdateStopCondition");
			ScheduledItem.NativeFieldInfoPtr_OnceCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "OnceCondition");
			ScheduledItem.NativeFieldInfoPtr_ForeverCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "ForeverCondition");
			ScheduledItem.NativeFieldInfoPtr__startMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<startMs>k__BackingField");
			ScheduledItem.NativeFieldInfoPtr__delayMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<delayMs>k__BackingField");
			ScheduledItem.NativeFieldInfoPtr__intervalMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<intervalMs>k__BackingField");
			ScheduledItem.NativeFieldInfoPtr__endTimeMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<endTimeMs>k__BackingField");
			ScheduledItem.NativeMethodInfoPtr_set_startMs_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100663508);
			ScheduledItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100663509);
			ScheduledItem.NativeMethodInfoPtr_ResetStartTime_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100663510);
			ScheduledItem.NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100663511);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000352C File Offset: 0x0000172C
		// (set) Token: 0x0600028F RID: 655 RVA: 0x000144A4 File Offset: 0x000126A4
		public unsafe long startMs
		{
			get
			{
				return this._startMs_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_set_startMs_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000144E4 File Offset: 0x000126E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92275, XrefRangeEnd = 92284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduledItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00014520 File Offset: 0x00012720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92284, XrefRangeEnd = 92288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStartTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_ResetStartTime_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00014554 File Offset: 0x00012754
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnItemUnscheduled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledItem.NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003474 File Offset: 0x00001674
		public ScheduledItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00014590 File Offset: 0x00012790
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000347D File Offset: 0x0000167D
		public unsafe Func<bool> timerUpdateStopCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr_timerUpdateStopCondition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr_timerUpdateStopCondition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000145C0 File Offset: 0x000127C0
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000349C File Offset: 0x0000169C
		public unsafe static Func<bool> OnceCondition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScheduledItem.NativeFieldInfoPtr_OnceCondition, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScheduledItem.NativeFieldInfoPtr_OnceCondition, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000145E8 File Offset: 0x000127E8
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000034AE File Offset: 0x000016AE
		public unsafe static Func<bool> ForeverCondition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScheduledItem.NativeFieldInfoPtr_ForeverCondition, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScheduledItem.NativeFieldInfoPtr_ForeverCondition, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00014610 File Offset: 0x00012810
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000034C0 File Offset: 0x000016C0
		public unsafe long _startMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__startMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__startMs_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00014638 File Offset: 0x00012838
		// (set) Token: 0x0600029D RID: 669 RVA: 0x000034DB File Offset: 0x000016DB
		public unsafe long _delayMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__delayMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__delayMs_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00014660 File Offset: 0x00012860
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000034F6 File Offset: 0x000016F6
		public unsafe long _intervalMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__intervalMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__intervalMs_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00014688 File Offset: 0x00012888
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00003511 File Offset: 0x00001711
		public unsafe long _endTimeMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__endTimeMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__endTimeMs_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00003534 File Offset: 0x00001734
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000353C File Offset: 0x0000173C
		public long delayMs
		{
			get
			{
				return this._delayMs_k__BackingField;
			}
			set
			{
				this._delayMs_k__BackingField = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00003545 File Offset: 0x00001745
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000354D File Offset: 0x0000174D
		public long intervalMs
		{
			get
			{
				return this._intervalMs_k__BackingField;
			}
			set
			{
				this._intervalMs_k__BackingField = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00003556 File Offset: 0x00001756
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000355E File Offset: 0x0000175E
		public long endTimeMs
		{
			get
			{
				return this._endTimeMs_k__BackingField;
			}
			set
			{
				this._endTimeMs_k__BackingField = value;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003567 File Offset: 0x00001767
		public void SetDuration(long durationMs)
		{
			this.endTimeMs = this.startMs + durationMs;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003579 File Offset: 0x00001779
		public virtual bool ShouldUnschedule()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_timerUpdateStopCondition;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_OnceCondition;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_ForeverCondition;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr__startMs_k__BackingField;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr__delayMs_k__BackingField;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr__intervalMs_k__BackingField;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr__endTimeMs_k__BackingField;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_set_startMs_Public_set_Void_Int64_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ResetStartTime_Protected_Void_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_New_Void_0;

		// Token: 0x020001F1 RID: 497
		[ObfuscatedName("UnityEngine.UIElements.ScheduledItem+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001355 RID: 4949 RVA: 0x0003B1CC File Offset: 0x000393CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr);
				ScheduledItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, "<>9");
				ScheduledItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, 100663514);
				ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, 100663515);
				ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, 100663516);
			}

			// Token: 0x06001356 RID: 4950 RVA: 0x0003B248 File Offset: 0x00039448
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001357 RID: 4951 RVA: 0x0003B284 File Offset: 0x00039484
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__25_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001358 RID: 4952 RVA: 0x0003B2C0 File Offset: 0x000394C0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__25_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001359 RID: 4953 RVA: 0x0000C768 File Offset: 0x0000A968
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x0600135A RID: 4954 RVA: 0x0003B2FC File Offset: 0x000394FC
			// (set) Token: 0x0600135B RID: 4955 RVA: 0x0000C771 File Offset: 0x0000A971
			public unsafe static ScheduledItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScheduledItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScheduledItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScheduledItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400086B RID: 2155
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400086C RID: 2156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400086D RID: 2157
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__25_0_Internal_Boolean_0;

			// Token: 0x0400086E RID: 2158
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__25_1_Internal_Boolean_0;
		}

		// Token: 0x020001F2 RID: 498
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
