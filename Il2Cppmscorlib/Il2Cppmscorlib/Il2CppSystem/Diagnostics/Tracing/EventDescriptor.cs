using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000510 RID: 1296
	[StructLayout(2)]
	public struct EventDescriptor
	{
		// Token: 0x06004AC6 RID: 19142 RVA: 0x001565F4 File Offset: 0x001547F4
		// Note: this type is marked as 'beforefieldinit'.
		static EventDescriptor()
		{
			Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr);
			EventDescriptor.NativeFieldInfoPtr_m_traceloggingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_traceloggingId");
			EventDescriptor.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_id");
			EventDescriptor.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_version");
			EventDescriptor.NativeFieldInfoPtr_m_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_channel");
			EventDescriptor.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_level");
			EventDescriptor.NativeFieldInfoPtr_m_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_opcode");
			EventDescriptor.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_task");
			EventDescriptor.NativeFieldInfoPtr_m_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, "m_keywords");
			EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674377);
			EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Byte_Byte_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674378);
			EventDescriptor.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674379);
			EventDescriptor.NativeMethodInfoPtr_get_Version_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674380);
			EventDescriptor.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674381);
			EventDescriptor.NativeMethodInfoPtr_get_Level_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674382);
			EventDescriptor.NativeMethodInfoPtr_get_Opcode_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674383);
			EventDescriptor.NativeMethodInfoPtr_get_Task_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674384);
			EventDescriptor.NativeMethodInfoPtr_get_Keywords_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674385);
			EventDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674386);
			EventDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674387);
			EventDescriptor.NativeMethodInfoPtr_Equals_Public_Boolean_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100674388);
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x001567B4 File Offset: 0x001549B4
		[CallerCount(0)]
		public unsafe EventDescriptor(int traceloggingId, byte level, byte opcode, long keywords)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceloggingId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00156810 File Offset: 0x00154A10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372799, RefRangeEnd = 372802, XrefRangeStart = 372799, XrefRangeEnd = 372799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Byte_Byte_Int32_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x00156898 File Offset: 0x00154A98
		public unsafe int EventId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 210360, RefRangeEnd = 210362, XrefRangeStart = 210360, XrefRangeEnd = 210362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x001568C8 File Offset: 0x00154AC8
		public unsafe byte Version
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Version_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x001568F8 File Offset: 0x00154AF8
		public unsafe byte Channel
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x00156928 File Offset: 0x00154B28
		public unsafe byte Level
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Level_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x00156958 File Offset: 0x00154B58
		public unsafe byte Opcode
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Opcode_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x00156988 File Offset: 0x00154B88
		public unsafe int Task
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Task_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06004ACF RID: 19151 RVA: 0x001569B8 File Offset: 0x00154BB8
		public unsafe long Keywords
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_get_Keywords_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x001569E8 File Offset: 0x00154BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372802, XrefRangeEnd = 372805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00156A2C File Offset: 0x00154C2C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x00156A5C File Offset: 0x00154C5C
		[CallerCount(0)]
		public unsafe bool Equals(EventDescriptor other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr_Equals_Public_Boolean_EventDescriptor_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x04003C5C RID: 15452
		private static readonly IntPtr NativeFieldInfoPtr_m_traceloggingId;

		// Token: 0x04003C5D RID: 15453
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04003C5E RID: 15454
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04003C5F RID: 15455
		private static readonly IntPtr NativeFieldInfoPtr_m_channel;

		// Token: 0x04003C60 RID: 15456
		private static readonly IntPtr NativeFieldInfoPtr_m_level;

		// Token: 0x04003C61 RID: 15457
		private static readonly IntPtr NativeFieldInfoPtr_m_opcode;

		// Token: 0x04003C62 RID: 15458
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04003C63 RID: 15459
		private static readonly IntPtr NativeFieldInfoPtr_m_keywords;

		// Token: 0x04003C64 RID: 15460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Int64_0;

		// Token: 0x04003C65 RID: 15461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Byte_Byte_Byte_Byte_Int32_Int64_0;

		// Token: 0x04003C66 RID: 15462
		private static readonly IntPtr NativeMethodInfoPtr_get_EventId_Public_get_Int32_0;

		// Token: 0x04003C67 RID: 15463
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Byte_0;

		// Token: 0x04003C68 RID: 15464
		private static readonly IntPtr NativeMethodInfoPtr_get_Channel_Public_get_Byte_0;

		// Token: 0x04003C69 RID: 15465
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_Byte_0;

		// Token: 0x04003C6A RID: 15466
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Public_get_Byte_0;

		// Token: 0x04003C6B RID: 15467
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Int32_0;

		// Token: 0x04003C6C RID: 15468
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Public_get_Int64_0;

		// Token: 0x04003C6D RID: 15469
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003C6E RID: 15470
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003C6F RID: 15471
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_EventDescriptor_0;

		// Token: 0x04003C70 RID: 15472
		[FieldOffset(0)]
		public int m_traceloggingId;

		// Token: 0x04003C71 RID: 15473
		[FieldOffset(0)]
		public ushort m_id;

		// Token: 0x04003C72 RID: 15474
		[FieldOffset(2)]
		public byte m_version;

		// Token: 0x04003C73 RID: 15475
		[FieldOffset(3)]
		public byte m_channel;

		// Token: 0x04003C74 RID: 15476
		[FieldOffset(4)]
		public byte m_level;

		// Token: 0x04003C75 RID: 15477
		[FieldOffset(5)]
		public byte m_opcode;

		// Token: 0x04003C76 RID: 15478
		[FieldOffset(6)]
		public ushort m_task;

		// Token: 0x04003C77 RID: 15479
		[FieldOffset(8)]
		public long m_keywords;
	}
}
