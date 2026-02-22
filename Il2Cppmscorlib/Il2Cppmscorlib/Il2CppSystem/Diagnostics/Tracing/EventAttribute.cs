using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000519 RID: 1305
	public sealed class EventAttribute : Attribute
	{
		// Token: 0x06004B6F RID: 19311 RVA: 0x00158B48 File Offset: 0x00156D48
		// Note: this type is marked as 'beforefieldinit'.
		static EventAttribute()
		{
			Il2CppClassPointerStore<EventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr);
			EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<EventId>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Level_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Level>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Keywords>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Task_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Task>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Version>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Message>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Tags>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__ActivityOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<ActivityOptions>k__BackingField");
			EventAttribute.NativeFieldInfoPtr_m_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "m_opcode");
			EventAttribute.NativeFieldInfoPtr_m_opcodeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "m_opcodeSet");
			EventAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674449);
			EventAttribute.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674450);
			EventAttribute.NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674451);
			EventAttribute.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674452);
			EventAttribute.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674453);
			EventAttribute.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674454);
			EventAttribute.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674455);
			EventAttribute.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674456);
			EventAttribute.NativeMethodInfoPtr_get_IsOpcodeSet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674457);
			EventAttribute.NativeMethodInfoPtr_get_Task_Public_get_EventTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674458);
			EventAttribute.NativeMethodInfoPtr_set_Task_Public_set_Void_EventTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674459);
			EventAttribute.NativeMethodInfoPtr_get_Version_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674460);
			EventAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674461);
			EventAttribute.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674462);
			EventAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674463);
			EventAttribute.NativeMethodInfoPtr_get_ActivityOptions_Public_get_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674464);
			EventAttribute.NativeMethodInfoPtr_set_ActivityOptions_Public_set_Void_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674465);
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00158D94 File Offset: 0x00156F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373463, XrefRangeEnd = 373464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventAttribute(int eventId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x00158DDC File Offset: 0x00156FDC
		// (set) Token: 0x06004B72 RID: 19314 RVA: 0x00158E18 File Offset: 0x00157018
		public unsafe int EventId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x00158E58 File Offset: 0x00157058
		// (set) Token: 0x06004B74 RID: 19316 RVA: 0x00158E94 File Offset: 0x00157094
		public unsafe EventLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06004B75 RID: 19317 RVA: 0x00158ED4 File Offset: 0x001570D4
		public unsafe EventKeywords Keywords
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x00158F10 File Offset: 0x00157110
		// (set) Token: 0x06004B77 RID: 19319 RVA: 0x00158F4C File Offset: 0x0015714C
		public unsafe EventOpcode Opcode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x00158F8C File Offset: 0x0015718C
		public unsafe bool IsOpcodeSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_IsOpcodeSet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06004B79 RID: 19321 RVA: 0x00158FC8 File Offset: 0x001571C8
		// (set) Token: 0x06004B7A RID: 19322 RVA: 0x00159004 File Offset: 0x00157204
		public unsafe EventTask Task
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Task_Public_get_EventTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Task_Public_set_Void_EventTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x00159044 File Offset: 0x00157244
		public unsafe byte Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Version_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x00159080 File Offset: 0x00157280
		// (set) Token: 0x06004B7D RID: 19325 RVA: 0x001590B8 File Offset: 0x001572B8
		public unsafe string Message
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x001590FC File Offset: 0x001572FC
		public unsafe EventTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06004B7F RID: 19327 RVA: 0x00159138 File Offset: 0x00157338
		// (set) Token: 0x06004B80 RID: 19328 RVA: 0x00159174 File Offset: 0x00157374
		public unsafe EventActivityOptions ActivityOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_ActivityOptions_Public_get_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_ActivityOptions_Public_set_Void_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x0001C5EE File Offset: 0x0001A7EE
		public EventAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x001591B4 File Offset: 0x001573B4
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x0001C5F7 File Offset: 0x0001A7F7
		public unsafe int _EventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06004B84 RID: 19332 RVA: 0x001591DC File Offset: 0x001573DC
		// (set) Token: 0x06004B85 RID: 19333 RVA: 0x0001C612 File Offset: 0x0001A812
		public unsafe EventLevel _Level_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Level_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Level_k__BackingField)) = value;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004B86 RID: 19334 RVA: 0x00159204 File Offset: 0x00157404
		// (set) Token: 0x06004B87 RID: 19335 RVA: 0x0001C62D File Offset: 0x0001A82D
		public unsafe EventKeywords _Keywords_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField)) = value;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004B88 RID: 19336 RVA: 0x0015922C File Offset: 0x0015742C
		// (set) Token: 0x06004B89 RID: 19337 RVA: 0x0001C648 File Offset: 0x0001A848
		public unsafe EventTask _Task_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Task_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Task_k__BackingField)) = value;
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06004B8A RID: 19338 RVA: 0x00159254 File Offset: 0x00157454
		// (set) Token: 0x06004B8B RID: 19339 RVA: 0x0001C663 File Offset: 0x0001A863
		public unsafe byte _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06004B8C RID: 19340 RVA: 0x0015927C File Offset: 0x0015747C
		// (set) Token: 0x06004B8D RID: 19341 RVA: 0x0001C67E File Offset: 0x0001A87E
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x001592A4 File Offset: 0x001574A4
		// (set) Token: 0x06004B8F RID: 19343 RVA: 0x0001C69D File Offset: 0x0001A89D
		public unsafe EventTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06004B90 RID: 19344 RVA: 0x001592CC File Offset: 0x001574CC
		// (set) Token: 0x06004B91 RID: 19345 RVA: 0x0001C6B8 File Offset: 0x0001A8B8
		public unsafe EventActivityOptions _ActivityOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__ActivityOptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__ActivityOptions_k__BackingField)) = value;
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06004B92 RID: 19346 RVA: 0x001592F4 File Offset: 0x001574F4
		// (set) Token: 0x06004B93 RID: 19347 RVA: 0x0001C6D3 File Offset: 0x0001A8D3
		public unsafe EventOpcode m_opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcode)) = value;
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x0015931C File Offset: 0x0015751C
		// (set) Token: 0x06004B95 RID: 19349 RVA: 0x0001C6EE File Offset: 0x0001A8EE
		public unsafe bool m_opcodeSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcodeSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcodeSet)) = value;
			}
		}

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeFieldInfoPtr__EventId_k__BackingField;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeFieldInfoPtr__Level_k__BackingField;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeFieldInfoPtr__Keywords_k__BackingField;

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeFieldInfoPtr__Task_k__BackingField;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeFieldInfoPtr__ActivityOptions_k__BackingField;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeFieldInfoPtr_m_opcode;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeFieldInfoPtr_m_opcodeSet;

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003CEF RID: 15599
		private static readonly IntPtr NativeMethodInfoPtr_get_EventId_Public_get_Int32_0;

		// Token: 0x04003CF0 RID: 15600
		private static readonly IntPtr NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0;

		// Token: 0x04003CF1 RID: 15601
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0;

		// Token: 0x04003CF2 RID: 15602
		private static readonly IntPtr NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0;

		// Token: 0x04003CF3 RID: 15603
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0;

		// Token: 0x04003CF4 RID: 15604
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0;

		// Token: 0x04003CF5 RID: 15605
		private static readonly IntPtr NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0;

		// Token: 0x04003CF6 RID: 15606
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpcodeSet_Internal_get_Boolean_0;

		// Token: 0x04003CF7 RID: 15607
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_EventTask_0;

		// Token: 0x04003CF8 RID: 15608
		private static readonly IntPtr NativeMethodInfoPtr_set_Task_Public_set_Void_EventTask_0;

		// Token: 0x04003CF9 RID: 15609
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Byte_0;

		// Token: 0x04003CFA RID: 15610
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x04003CFB RID: 15611
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_String_0;

		// Token: 0x04003CFC RID: 15612
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0;

		// Token: 0x04003CFD RID: 15613
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivityOptions_Public_get_EventActivityOptions_0;

		// Token: 0x04003CFE RID: 15614
		private static readonly IntPtr NativeMethodInfoPtr_set_ActivityOptions_Public_set_Void_EventActivityOptions_0;
	}
}
