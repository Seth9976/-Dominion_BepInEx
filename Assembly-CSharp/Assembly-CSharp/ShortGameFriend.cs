using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200005F RID: 95
[Serializable]
public sealed class ShortGameFriend : ValueType
{
	// Token: 0x06000DB3 RID: 3507 RVA: 0x00041C64 File Offset: 0x0003FE64
	// Note: this type is marked as 'beforefieldinit'.
	static ShortGameFriend()
	{
		Il2CppClassPointerStore<ShortGameFriend>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShortGameFriend");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortGameFriend>.NativeClassPtr);
		ShortGameFriend.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortGameFriend>.NativeClassPtr, "displayName");
		ShortGameFriend.NativeFieldInfoPtr_avatarIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortGameFriend>.NativeClassPtr, "avatarIndex");
		ShortGameFriend.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortGameFriend>.NativeClassPtr, "userID");
		ShortGameFriend.NativeFieldInfoPtr_userRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortGameFriend>.NativeClassPtr, "userRating");
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x0000A0A5 File Offset: 0x000082A5
	public ShortGameFriend(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x0000A0AE File Offset: 0x000082AE
	public ShortGameFriend()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortGameFriend>.NativeClassPtr))
	{
	}

	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00041CE4 File Offset: 0x0003FEE4
	// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x0000A0C0 File Offset: 0x000082C0
	public unsafe string displayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_displayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00041D0C File Offset: 0x0003FF0C
	// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x0000A0DF File Offset: 0x000082DF
	public unsafe ushort avatarIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_avatarIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_avatarIndex)) = value;
		}
	}

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00041D34 File Offset: 0x0003FF34
	// (set) Token: 0x06000DBB RID: 3515 RVA: 0x0000A0FA File Offset: 0x000082FA
	public unsafe uint userID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_userID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_userID)) = value;
		}
	}

	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00041D5C File Offset: 0x0003FF5C
	// (set) Token: 0x06000DBD RID: 3517 RVA: 0x0000A115 File Offset: 0x00008315
	public unsafe ushort userRating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_userRating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortGameFriend.NativeFieldInfoPtr_userRating)) = value;
		}
	}

	// Token: 0x04000936 RID: 2358
	private static readonly IntPtr NativeFieldInfoPtr_displayName;

	// Token: 0x04000937 RID: 2359
	private static readonly IntPtr NativeFieldInfoPtr_avatarIndex;

	// Token: 0x04000938 RID: 2360
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x04000939 RID: 2361
	private static readonly IntPtr NativeFieldInfoPtr_userRating;
}
