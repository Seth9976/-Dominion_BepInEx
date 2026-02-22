using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000049 RID: 73
public sealed class FriendInfo : ValueType
{
	// Token: 0x06000C8E RID: 3214 RVA: 0x0003F9EC File Offset: 0x0003DBEC
	// Note: this type is marked as 'beforefieldinit'.
	static FriendInfo()
	{
		Il2CppClassPointerStore<FriendInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FriendInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr);
		FriendInfo.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, "userID");
		FriendInfo.NativeFieldInfoPtr_userAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, "userAvatar");
		FriendInfo.NativeFieldInfoPtr_userRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, "userRating");
		FriendInfo.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, "displayName");
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00009690 File Offset: 0x00007890
	public FriendInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x00009699 File Offset: 0x00007899
	public FriendInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr))
	{
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0003FA6C File Offset: 0x0003DC6C
	// (set) Token: 0x06000C92 RID: 3218 RVA: 0x000096AB File Offset: 0x000078AB
	public unsafe uint userID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_userID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_userID)) = value;
		}
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0003FA94 File Offset: 0x0003DC94
	// (set) Token: 0x06000C94 RID: 3220 RVA: 0x000096C6 File Offset: 0x000078C6
	public unsafe ushort userAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_userAvatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_userAvatar)) = value;
		}
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0003FABC File Offset: 0x0003DCBC
	// (set) Token: 0x06000C96 RID: 3222 RVA: 0x000096E1 File Offset: 0x000078E1
	public unsafe ushort userRating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_userRating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_userRating)) = value;
		}
	}

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0003FAE4 File Offset: 0x0003DCE4
	// (set) Token: 0x06000C98 RID: 3224 RVA: 0x000096FC File Offset: 0x000078FC
	public unsafe string displayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_displayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInfo.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040007F3 RID: 2035
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x040007F4 RID: 2036
	private static readonly IntPtr NativeFieldInfoPtr_userAvatar;

	// Token: 0x040007F5 RID: 2037
	private static readonly IntPtr NativeFieldInfoPtr_userRating;

	// Token: 0x040007F6 RID: 2038
	private static readonly IntPtr NativeFieldInfoPtr_displayName;
}
