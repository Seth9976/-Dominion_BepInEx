using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine.Events;

// Token: 0x0200008B RID: 139
public class GameEventBuffer : Object
{
	// Token: 0x06001147 RID: 4423 RVA: 0x0004D930 File Offset: 0x0004BB30
	// Note: this type is marked as 'beforefieldinit'.
	static GameEventBuffer()
	{
		Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameEventBuffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr);
		GameEventBuffer.NativeFieldInfoPtr_m_EventBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_EventBufferLength");
		GameEventBuffer.NativeFieldInfoPtr_m_EventBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_EventBuffer");
		GameEventBuffer.NativeFieldInfoPtr_m_hGameEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_hGameEvents");
		GameEventBuffer.NativeFieldInfoPtr_m_EventsRemainingToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_EventsRemainingToProcess");
		GameEventBuffer.NativeFieldInfoPtr_m_bBreakFromEventLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_bBreakFromEventLoop");
		GameEventBuffer.NativeFieldInfoPtr_m_EventBufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_EventBufferPtr");
		GameEventBuffer.NativeFieldInfoPtr_m_EventFeedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_EventFeedback");
		GameEventBuffer.NativeFieldInfoPtr_m_UpdateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_UpdateDelegate");
		GameEventBuffer.NativeFieldInfoPtr_m_EventDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "m_EventDictionary");
		GameEventBuffer.NativeMethodInfoPtr_GetEventsRemainingToProcess_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664602);
		GameEventBuffer.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664603);
		GameEventBuffer.NativeMethodInfoPtr_SetUpdateDelegate_Public_Void_GameEventBufferUpdateDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664604);
		GameEventBuffer.NativeMethodInfoPtr_RegisterEventHandler_Public_Void_Int32_UnityAction_2_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664605);
		GameEventBuffer.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664606);
		GameEventBuffer.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664607);
		GameEventBuffer.NativeMethodInfoPtr_HandleEvent_Private_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664608);
		GameEventBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, 100664609);
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x0004DAB4 File Offset: 0x0004BCB4
	[CallerCount(0)]
	public unsafe int GetEventsRemainingToProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr_GetEventsRemainingToProcess_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242326, RefRangeEnd = 242327, XrefRangeStart = 242311, XrefRangeEnd = 242326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x0004DB24 File Offset: 0x0004BD24
	[CallerCount(0)]
	public unsafe void SetUpdateDelegate(GameEventBuffer.GameEventBufferUpdateDelegate update_delegate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(update_delegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr_SetUpdateDelegate_Public_Void_GameEventBufferUpdateDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x0004DB68 File Offset: 0x0004BD68
	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 242342, RefRangeEnd = 242376, XrefRangeStart = 242327, XrefRangeEnd = 242342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterEventHandler(int eventID, UnityAction<IntPtr, GameEventFeedback> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr_RegisterEventHandler_Public_Void_Int32_UnityAction_2_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x0004DBB8 File Offset: 0x0004BDB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242376, XrefRangeEnd = 242377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x0004DBEC File Offset: 0x0004BDEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242380, RefRangeEnd = 242381, XrefRangeStart = 242377, XrefRangeEnd = 242380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x0004DC20 File Offset: 0x0004BE20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242420, RefRangeEnd = 242421, XrefRangeStart = 242381, XrefRangeEnd = 242420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntPtr HandleEvent(IntPtr eventBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr_HandleEvent_Private_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x0004DC6C File Offset: 0x0004BE6C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242423, RefRangeEnd = 242424, XrefRangeStart = 242421, XrefRangeEnd = 242423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventBuffer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x0000BC67 File Offset: 0x00009E67
	public GameEventBuffer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x06001151 RID: 4433 RVA: 0x0004DCA8 File Offset: 0x0004BEA8
	// (set) Token: 0x06001152 RID: 4434 RVA: 0x0000BC70 File Offset: 0x00009E70
	public unsafe static int m_EventBufferLength
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(GameEventBuffer.NativeFieldInfoPtr_m_EventBufferLength, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameEventBuffer.NativeFieldInfoPtr_m_EventBufferLength, (void*)(&value));
		}
	}

	// Token: 0x170005A4 RID: 1444
	// (get) Token: 0x06001153 RID: 4435 RVA: 0x0004DCC4 File Offset: 0x0004BEC4
	// (set) Token: 0x06001154 RID: 4436 RVA: 0x0000BC7E File Offset: 0x00009E7E
	public unsafe Il2CppStructArray<byte> m_EventBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x06001155 RID: 4437 RVA: 0x0004DCF4 File Offset: 0x0004BEF4
	// (set) Token: 0x06001156 RID: 4438 RVA: 0x0000BC9D File Offset: 0x00009E9D
	public unsafe GCHandle m_hGameEvents
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_hGameEvents);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_hGameEvents)) = value;
		}
	}

	// Token: 0x170005A6 RID: 1446
	// (get) Token: 0x06001157 RID: 4439 RVA: 0x0004DD1C File Offset: 0x0004BF1C
	// (set) Token: 0x06001158 RID: 4440 RVA: 0x0000BCB8 File Offset: 0x00009EB8
	public unsafe int m_EventsRemainingToProcess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventsRemainingToProcess);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventsRemainingToProcess)) = value;
		}
	}

	// Token: 0x170005A7 RID: 1447
	// (get) Token: 0x06001159 RID: 4441 RVA: 0x0004DD44 File Offset: 0x0004BF44
	// (set) Token: 0x0600115A RID: 4442 RVA: 0x0000BCD3 File Offset: 0x00009ED3
	public unsafe bool m_bBreakFromEventLoop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_bBreakFromEventLoop);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_bBreakFromEventLoop)) = value;
		}
	}

	// Token: 0x170005A8 RID: 1448
	// (get) Token: 0x0600115B RID: 4443 RVA: 0x0004DD6C File Offset: 0x0004BF6C
	// (set) Token: 0x0600115C RID: 4444 RVA: 0x0000BCEE File Offset: 0x00009EEE
	public unsafe IntPtr m_EventBufferPtr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventBufferPtr);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventBufferPtr)) = value;
		}
	}

	// Token: 0x170005A9 RID: 1449
	// (get) Token: 0x0600115D RID: 4445 RVA: 0x0004DD94 File Offset: 0x0004BF94
	// (set) Token: 0x0600115E RID: 4446 RVA: 0x0000BD09 File Offset: 0x00009F09
	public unsafe GameEventFeedback m_EventFeedback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventFeedback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameEventFeedback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventFeedback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005AA RID: 1450
	// (get) Token: 0x0600115F RID: 4447 RVA: 0x0004DDC4 File Offset: 0x0004BFC4
	// (set) Token: 0x06001160 RID: 4448 RVA: 0x0000BD28 File Offset: 0x00009F28
	public unsafe GameEventBuffer.GameEventBufferUpdateDelegate m_UpdateDelegate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_UpdateDelegate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameEventBuffer.GameEventBufferUpdateDelegate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_UpdateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x06001161 RID: 4449 RVA: 0x0004DDF4 File Offset: 0x0004BFF4
	// (set) Token: 0x06001162 RID: 4450 RVA: 0x0000BD47 File Offset: 0x00009F47
	public unsafe Dictionary<int, GameEventIntPtr> m_EventDictionary
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventDictionary);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GameEventIntPtr>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEventBuffer.NativeFieldInfoPtr_m_EventDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C15 RID: 3093
	private static readonly IntPtr NativeFieldInfoPtr_m_EventBufferLength;

	// Token: 0x04000C16 RID: 3094
	private static readonly IntPtr NativeFieldInfoPtr_m_EventBuffer;

	// Token: 0x04000C17 RID: 3095
	private static readonly IntPtr NativeFieldInfoPtr_m_hGameEvents;

	// Token: 0x04000C18 RID: 3096
	private static readonly IntPtr NativeFieldInfoPtr_m_EventsRemainingToProcess;

	// Token: 0x04000C19 RID: 3097
	private static readonly IntPtr NativeFieldInfoPtr_m_bBreakFromEventLoop;

	// Token: 0x04000C1A RID: 3098
	private static readonly IntPtr NativeFieldInfoPtr_m_EventBufferPtr;

	// Token: 0x04000C1B RID: 3099
	private static readonly IntPtr NativeFieldInfoPtr_m_EventFeedback;

	// Token: 0x04000C1C RID: 3100
	private static readonly IntPtr NativeFieldInfoPtr_m_UpdateDelegate;

	// Token: 0x04000C1D RID: 3101
	private static readonly IntPtr NativeFieldInfoPtr_m_EventDictionary;

	// Token: 0x04000C1E RID: 3102
	private static readonly IntPtr NativeMethodInfoPtr_GetEventsRemainingToProcess_Public_Int32_0;

	// Token: 0x04000C1F RID: 3103
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x04000C20 RID: 3104
	private static readonly IntPtr NativeMethodInfoPtr_SetUpdateDelegate_Public_Void_GameEventBufferUpdateDelegate_0;

	// Token: 0x04000C21 RID: 3105
	private static readonly IntPtr NativeMethodInfoPtr_RegisterEventHandler_Public_Void_Int32_UnityAction_2_IntPtr_GameEventFeedback_0;

	// Token: 0x04000C22 RID: 3106
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	// Token: 0x04000C23 RID: 3107
	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	// Token: 0x04000C24 RID: 3108
	private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Private_IntPtr_IntPtr_0;

	// Token: 0x04000C25 RID: 3109
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000194 RID: 404
	public sealed class GameEventBufferUpdateDelegate : MulticastDelegate
	{
		// Token: 0x0600247F RID: 9343 RVA: 0x00087D24 File Offset: 0x00085F24
		// Note: this type is marked as 'beforefieldinit'.
		static GameEventBufferUpdateDelegate()
		{
			Il2CppClassPointerStore<GameEventBuffer.GameEventBufferUpdateDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameEventBuffer>.NativeClassPtr, "GameEventBufferUpdateDelegate");
			GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer.GameEventBufferUpdateDelegate>.NativeClassPtr, 100666204);
			GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer.GameEventBufferUpdateDelegate>.NativeClassPtr, 100666205);
			GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer.GameEventBufferUpdateDelegate>.NativeClassPtr, 100666206);
			GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventBuffer.GameEventBufferUpdateDelegate>.NativeClassPtr, 100666207);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00087D98 File Offset: 0x00085F98
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameEventBufferUpdateDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventBuffer.GameEventBufferUpdateDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00087DF4 File Offset: 0x00085FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242303, RefRangeEnd = 242304, XrefRangeStart = 242303, XrefRangeEnd = 242303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Invoke(IntPtr pGameEvents, int maxEvents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pGameEvents;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEvents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00087E4C File Offset: 0x0008604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242304, XrefRangeEnd = 242311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(IntPtr pGameEvents, int maxEvents, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pGameEvents;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEvents;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x00087ECC File Offset: 0x000860CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43352, RefRangeEnd = 43355, XrefRangeStart = 43352, XrefRangeEnd = 43355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEventBuffer.GameEventBufferUpdateDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00016AB3 File Offset: 0x00014CB3
		public GameEventBufferUpdateDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00016ABC File Offset: 0x00014CBC
		public static implicit operator GameEventBuffer.GameEventBufferUpdateDelegate(Func<IntPtr, int, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<GameEventBuffer.GameEventBufferUpdateDelegate>(A_0);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00016AC4 File Offset: 0x00014CC4
		public static GameEventBuffer.GameEventBufferUpdateDelegate operator +(GameEventBuffer.GameEventBufferUpdateDelegate A_0, GameEventBuffer.GameEventBufferUpdateDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GameEventBuffer.GameEventBufferUpdateDelegate>();
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00016AD2 File Offset: 0x00014CD2
		public static GameEventBuffer.GameEventBufferUpdateDelegate operator -(GameEventBuffer.GameEventBufferUpdateDelegate A_0, GameEventBuffer.GameEventBufferUpdateDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GameEventBuffer.GameEventBufferUpdateDelegate>();
			}
			return delegate2;
		}

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_0;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_AsyncCallback_Object_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
	}
}
