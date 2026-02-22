using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CD RID: 1229
	[StructLayout(2)]
	public struct EventSourceOptions
	{
		// Token: 0x06004815 RID: 18453 RVA: 0x0014A95C File Offset: 0x00148B5C
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceOptions()
		{
			Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr);
			EventSourceOptions.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "keywords");
			EventSourceOptions.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "tags");
			EventSourceOptions.NativeFieldInfoPtr_activityOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "activityOptions");
			EventSourceOptions.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "level");
			EventSourceOptions.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "opcode");
			EventSourceOptions.NativeFieldInfoPtr_valuesSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "valuesSet");
			EventSourceOptions.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, 100673967);
			EventSourceOptions.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, 100673968);
			EventSourceOptions.NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, 100673969);
		}

		// Token: 0x17001232 RID: 4658
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x0014AA40 File Offset: 0x00148C40
		public unsafe EventLevel Level
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366225, RefRangeEnd = 366227, XrefRangeStart = 366224, XrefRangeEnd = 366225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceOptions.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001233 RID: 4659
		// (set) Token: 0x06004817 RID: 18455 RVA: 0x0014AA74 File Offset: 0x00148C74
		public unsafe EventOpcode Opcode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366228, RefRangeEnd = 366230, XrefRangeStart = 366227, XrefRangeEnd = 366228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceOptions.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001234 RID: 4660
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x0014AAA8 File Offset: 0x00148CA8
		public unsafe EventKeywords Keywords
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366230, RefRangeEnd = 366232, XrefRangeStart = 366230, XrefRangeEnd = 366230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceOptions.NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x0001B489 File Offset: 0x00019689
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04003A54 RID: 14932
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003A55 RID: 14933
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003A56 RID: 14934
		private static readonly IntPtr NativeFieldInfoPtr_activityOptions;

		// Token: 0x04003A57 RID: 14935
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003A58 RID: 14936
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003A59 RID: 14937
		private static readonly IntPtr NativeFieldInfoPtr_valuesSet;

		// Token: 0x04003A5A RID: 14938
		private static readonly IntPtr NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0;

		// Token: 0x04003A5B RID: 14939
		private static readonly IntPtr NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0;

		// Token: 0x04003A5C RID: 14940
		private static readonly IntPtr NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0;

		// Token: 0x04003A5D RID: 14941
		[FieldOffset(0)]
		public EventKeywords keywords;

		// Token: 0x04003A5E RID: 14942
		[FieldOffset(8)]
		public EventTags tags;

		// Token: 0x04003A5F RID: 14943
		[FieldOffset(12)]
		public EventActivityOptions activityOptions;

		// Token: 0x04003A60 RID: 14944
		[FieldOffset(16)]
		public byte level;

		// Token: 0x04003A61 RID: 14945
		[FieldOffset(17)]
		public byte opcode;

		// Token: 0x04003A62 RID: 14946
		[FieldOffset(18)]
		public byte valuesSet;
	}
}
