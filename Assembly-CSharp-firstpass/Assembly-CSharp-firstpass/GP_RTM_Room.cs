using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200006A RID: 106
public class GP_RTM_Room : Object
{
	// Token: 0x0600080B RID: 2059 RVA: 0x00032904 File Offset: 0x00030B04
	// Note: this type is marked as 'beforefieldinit'.
	static GP_RTM_Room()
	{
		Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_RTM_Room");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr);
		GP_RTM_Room.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, "id");
		GP_RTM_Room.NativeFieldInfoPtr_creatorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, "creatorId");
		GP_RTM_Room.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, "status");
		GP_RTM_Room.NativeFieldInfoPtr_creationTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, "creationTimestamp");
		GP_RTM_Room.NativeFieldInfoPtr_participants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, "participants");
		GP_RTM_Room.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, 100664268);
		GP_RTM_Room.NativeMethodInfoPtr_AddParticipant_Public_Void_GP_Participant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, 100664269);
		GP_RTM_Room.NativeMethodInfoPtr_GetParticipantById_Public_GP_Participant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr, 100664270);
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x000329D4 File Offset: 0x00030BD4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 168691, RefRangeEnd = 168695, XrefRangeStart = 168677, XrefRangeEnd = 168691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RTM_Room()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RTM_Room>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Room.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00032A10 File Offset: 0x00030C10
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168699, RefRangeEnd = 168700, XrefRangeStart = 168695, XrefRangeEnd = 168699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddParticipant(GP_Participant p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Room.NativeMethodInfoPtr_AddParticipant_Public_Void_GP_Participant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00032A54 File Offset: 0x00030C54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168700, XrefRangeEnd = 168717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Participant GetParticipantById(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Room.NativeMethodInfoPtr_GetParticipantById_Public_GP_Participant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Participant>(intPtr3) : null;
		}
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x000053E6 File Offset: 0x000035E6
	public GP_RTM_Room(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06000810 RID: 2064 RVA: 0x00032AA4 File Offset: 0x00030CA4
	// (set) Token: 0x06000811 RID: 2065 RVA: 0x000053EF File Offset: 0x000035EF
	public unsafe string id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06000812 RID: 2066 RVA: 0x00032ACC File Offset: 0x00030CCC
	// (set) Token: 0x06000813 RID: 2067 RVA: 0x0000540E File Offset: 0x0000360E
	public unsafe string creatorId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_creatorId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_creatorId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x06000814 RID: 2068 RVA: 0x00032AF4 File Offset: 0x00030CF4
	// (set) Token: 0x06000815 RID: 2069 RVA: 0x0000542D File Offset: 0x0000362D
	public unsafe GP_RTM_RoomStatus status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_status);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_status)) = value;
		}
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06000816 RID: 2070 RVA: 0x00032B1C File Offset: 0x00030D1C
	// (set) Token: 0x06000817 RID: 2071 RVA: 0x00005448 File Offset: 0x00003648
	public unsafe long creationTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_creationTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_creationTimestamp)) = value;
		}
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x06000818 RID: 2072 RVA: 0x00032B44 File Offset: 0x00030D44
	// (set) Token: 0x06000819 RID: 2073 RVA: 0x00005463 File Offset: 0x00003663
	public unsafe List<GP_Participant> participants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_participants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GP_Participant>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Room.NativeFieldInfoPtr_participants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400067F RID: 1663
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04000680 RID: 1664
	private static readonly IntPtr NativeFieldInfoPtr_creatorId;

	// Token: 0x04000681 RID: 1665
	private static readonly IntPtr NativeFieldInfoPtr_status;

	// Token: 0x04000682 RID: 1666
	private static readonly IntPtr NativeFieldInfoPtr_creationTimestamp;

	// Token: 0x04000683 RID: 1667
	private static readonly IntPtr NativeFieldInfoPtr_participants;

	// Token: 0x04000684 RID: 1668
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000685 RID: 1669
	private static readonly IntPtr NativeMethodInfoPtr_AddParticipant_Public_Void_GP_Participant_0;

	// Token: 0x04000686 RID: 1670
	private static readonly IntPtr NativeMethodInfoPtr_GetParticipantById_Public_GP_Participant_String_0;
}
