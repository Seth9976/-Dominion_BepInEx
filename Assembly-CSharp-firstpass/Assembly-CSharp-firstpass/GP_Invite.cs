using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200004A RID: 74
public class GP_Invite : Object
{
	// Token: 0x0600062F RID: 1583 RVA: 0x0002C384 File Offset: 0x0002A584
	// Note: this type is marked as 'beforefieldinit'.
	static GP_Invite()
	{
		Il2CppClassPointerStore<GP_Invite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_Invite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr);
		GP_Invite.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr, "Id");
		GP_Invite.NativeFieldInfoPtr_CreationTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr, "CreationTimestamp");
		GP_Invite.NativeFieldInfoPtr_InvitationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr, "InvitationType");
		GP_Invite.NativeFieldInfoPtr_Variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr, "Variant");
		GP_Invite.NativeFieldInfoPtr_Participant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr, "Participant");
		GP_Invite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr, 100664055);
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0002C42C File Offset: 0x0002A62C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Invite()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_Invite>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Invite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x000047D4 File Offset: 0x000029D4
	public GP_Invite(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06000632 RID: 1586 RVA: 0x0002C468 File Offset: 0x0002A668
	// (set) Token: 0x06000633 RID: 1587 RVA: 0x000047DD File Offset: 0x000029DD
	public unsafe string Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06000634 RID: 1588 RVA: 0x0002C490 File Offset: 0x0002A690
	// (set) Token: 0x06000635 RID: 1589 RVA: 0x000047FC File Offset: 0x000029FC
	public unsafe long CreationTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_CreationTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_CreationTimestamp)) = value;
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06000636 RID: 1590 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
	// (set) Token: 0x06000637 RID: 1591 RVA: 0x00004817 File Offset: 0x00002A17
	public unsafe GP_InvitationType InvitationType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_InvitationType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_InvitationType)) = value;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06000638 RID: 1592 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
	// (set) Token: 0x06000639 RID: 1593 RVA: 0x00004832 File Offset: 0x00002A32
	public unsafe int Variant
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_Variant);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_Variant)) = value;
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x0600063A RID: 1594 RVA: 0x0002C508 File Offset: 0x0002A708
	// (set) Token: 0x0600063B RID: 1595 RVA: 0x0000484D File Offset: 0x00002A4D
	public unsafe GP_Participant Participant
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_Participant);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_Participant>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Invite.NativeFieldInfoPtr_Participant), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400051C RID: 1308
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x0400051D RID: 1309
	private static readonly IntPtr NativeFieldInfoPtr_CreationTimestamp;

	// Token: 0x0400051E RID: 1310
	private static readonly IntPtr NativeFieldInfoPtr_InvitationType;

	// Token: 0x0400051F RID: 1311
	private static readonly IntPtr NativeFieldInfoPtr_Variant;

	// Token: 0x04000520 RID: 1312
	private static readonly IntPtr NativeFieldInfoPtr_Participant;

	// Token: 0x04000521 RID: 1313
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
