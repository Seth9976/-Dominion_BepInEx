using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000101 RID: 257
public class SA_PartisipantUI : MonoBehaviour
{
	// Token: 0x060011B3 RID: 4531 RVA: 0x00054B58 File Offset: 0x00052D58
	// Note: this type is marked as 'beforefieldinit'.
	static SA_PartisipantUI()
	{
		Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_PartisipantUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr);
		SA_PartisipantUI.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, "avatar");
		SA_PartisipantUI.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, "id");
		SA_PartisipantUI.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, "status");
		SA_PartisipantUI.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, "playerId");
		SA_PartisipantUI.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, "playerName");
		SA_PartisipantUI.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, "defaulttexture");
		SA_PartisipantUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, 100665448);
		SA_PartisipantUI.NativeMethodInfoPtr_SetParticipant_Public_Void_GP_Participant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, 100665449);
		SA_PartisipantUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr, 100665450);
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00054C3C File Offset: 0x00052E3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181973, XrefRangeEnd = 181978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PartisipantUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00054C70 File Offset: 0x00052E70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182029, RefRangeEnd = 182030, XrefRangeStart = 181978, XrefRangeEnd = 182029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParticipant(GP_Participant p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PartisipantUI.NativeMethodInfoPtr_SetParticipant_Public_Void_GP_Participant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00054CB4 File Offset: 0x00052EB4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_PartisipantUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PartisipantUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PartisipantUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00008D0A File Offset: 0x00006F0A
	public SA_PartisipantUI(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00054CF0 File Offset: 0x00052EF0
	// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00008D13 File Offset: 0x00006F13
	public unsafe GameObject avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x060011BA RID: 4538 RVA: 0x00054D20 File Offset: 0x00052F20
	// (set) Token: 0x060011BB RID: 4539 RVA: 0x00008D32 File Offset: 0x00006F32
	public unsafe SA_Label id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x060011BC RID: 4540 RVA: 0x00054D50 File Offset: 0x00052F50
	// (set) Token: 0x060011BD RID: 4541 RVA: 0x00008D51 File Offset: 0x00006F51
	public unsafe SA_Label status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_status);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x060011BE RID: 4542 RVA: 0x00054D80 File Offset: 0x00052F80
	// (set) Token: 0x060011BF RID: 4543 RVA: 0x00008D70 File Offset: 0x00006F70
	public unsafe SA_Label playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_playerId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_playerId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00054DB0 File Offset: 0x00052FB0
	// (set) Token: 0x060011C1 RID: 4545 RVA: 0x00008D8F File Offset: 0x00006F8F
	public unsafe SA_Label playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_playerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_playerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00054DE0 File Offset: 0x00052FE0
	// (set) Token: 0x060011C3 RID: 4547 RVA: 0x00008DAE File Offset: 0x00006FAE
	public unsafe Texture defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PartisipantUI.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000DAC RID: 3500
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000DAD RID: 3501
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04000DAE RID: 3502
	private static readonly IntPtr NativeFieldInfoPtr_status;

	// Token: 0x04000DAF RID: 3503
	private static readonly IntPtr NativeFieldInfoPtr_playerId;

	// Token: 0x04000DB0 RID: 3504
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04000DB1 RID: 3505
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04000DB2 RID: 3506
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DB3 RID: 3507
	private static readonly IntPtr NativeMethodInfoPtr_SetParticipant_Public_Void_GP_Participant_0;

	// Token: 0x04000DB4 RID: 3508
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
