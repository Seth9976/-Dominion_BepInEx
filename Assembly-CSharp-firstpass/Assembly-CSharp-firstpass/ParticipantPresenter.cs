using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200012D RID: 301
public class ParticipantPresenter : MonoBehaviour
{
	// Token: 0x06001590 RID: 5520 RVA: 0x000613A8 File Offset: 0x0005F5A8
	// Note: this type is marked as 'beforefieldinit'.
	static ParticipantPresenter()
	{
		Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ParticipantPresenter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr);
		ParticipantPresenter.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "avatar");
		ParticipantPresenter.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "id");
		ParticipantPresenter.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "status");
		ParticipantPresenter.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "playerId");
		ParticipantPresenter.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "playerName");
		ParticipantPresenter.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "_id");
		ParticipantPresenter.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "defaulttexture");
		ParticipantPresenter.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, "icon");
		ParticipantPresenter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, 100665891);
		ParticipantPresenter.NativeMethodInfoPtr_SetParticipant_Public_Void_GP_Participant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, 100665892);
		ParticipantPresenter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr, 100665893);
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x000614B4 File Offset: 0x0005F6B4
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticipantPresenter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x000614E8 File Offset: 0x0005F6E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 190324, RefRangeEnd = 190325, XrefRangeStart = 190294, XrefRangeEnd = 190324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParticipant(GP_Participant p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticipantPresenter.NativeMethodInfoPtr_SetParticipant_Public_Void_GP_Participant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x0006152C File Offset: 0x0005F72C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190325, XrefRangeEnd = 190328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticipantPresenter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticipantPresenter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticipantPresenter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x0000A934 File Offset: 0x00008B34
	public ParticipantPresenter(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x06001595 RID: 5525 RVA: 0x00061568 File Offset: 0x0005F768
	// (set) Token: 0x06001596 RID: 5526 RVA: 0x0000A93D File Offset: 0x00008B3D
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x06001597 RID: 5527 RVA: 0x00061598 File Offset: 0x0005F798
	// (set) Token: 0x06001598 RID: 5528 RVA: 0x0000A95C File Offset: 0x00008B5C
	public unsafe Text id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x06001599 RID: 5529 RVA: 0x000615C8 File Offset: 0x0005F7C8
	// (set) Token: 0x0600159A RID: 5530 RVA: 0x0000A97B File Offset: 0x00008B7B
	public unsafe Text status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_status);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x0600159B RID: 5531 RVA: 0x000615F8 File Offset: 0x0005F7F8
	// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000A99A File Offset: 0x00008B9A
	public unsafe Text playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_playerId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_playerId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x0600159D RID: 5533 RVA: 0x00061628 File Offset: 0x0005F828
	// (set) Token: 0x0600159E RID: 5534 RVA: 0x0000A9B9 File Offset: 0x00008BB9
	public unsafe Text playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_playerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_playerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x0600159F RID: 5535 RVA: 0x00061658 File Offset: 0x0005F858
	// (set) Token: 0x060015A0 RID: 5536 RVA: 0x0000A9D8 File Offset: 0x00008BD8
	public unsafe string _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00061680 File Offset: 0x0005F880
	// (set) Token: 0x060015A2 RID: 5538 RVA: 0x0000A9F7 File Offset: 0x00008BF7
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000636 RID: 1590
	// (get) Token: 0x060015A3 RID: 5539 RVA: 0x000616B0 File Offset: 0x0005F8B0
	// (set) Token: 0x060015A4 RID: 5540 RVA: 0x0000AA16 File Offset: 0x00008C16
	public unsafe Sprite icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticipantPresenter.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001055 RID: 4181
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04001056 RID: 4182
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04001057 RID: 4183
	private static readonly IntPtr NativeFieldInfoPtr_status;

	// Token: 0x04001058 RID: 4184
	private static readonly IntPtr NativeFieldInfoPtr_playerId;

	// Token: 0x04001059 RID: 4185
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x0400105A RID: 4186
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x0400105B RID: 4187
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x0400105C RID: 4188
	private static readonly IntPtr NativeFieldInfoPtr_icon;

	// Token: 0x0400105D RID: 4189
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400105E RID: 4190
	private static readonly IntPtr NativeMethodInfoPtr_SetParticipant_Public_Void_GP_Participant_0;

	// Token: 0x0400105F RID: 4191
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
