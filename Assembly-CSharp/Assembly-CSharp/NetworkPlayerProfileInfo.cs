using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004B RID: 75
public sealed class NetworkPlayerProfileInfo : ValueType
{
	// Token: 0x06000CA6 RID: 3238 RVA: 0x0003FC78 File Offset: 0x0003DE78
	// Note: this type is marked as 'beforefieldinit'.
	static NetworkPlayerProfileInfo()
	{
		Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkPlayerProfileInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr);
		NetworkPlayerProfileInfo.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr, "userID");
		NetworkPlayerProfileInfo.NativeFieldInfoPtr_inProgressGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr, "inProgressGames");
		NetworkPlayerProfileInfo.NativeFieldInfoPtr_userGameStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr, "userGameStats");
		NetworkPlayerProfileInfo.NativeFieldInfoPtr_userAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr, "userAvatar");
		NetworkPlayerProfileInfo.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr, "displayName");
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x000097C5 File Offset: 0x000079C5
	public NetworkPlayerProfileInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x000097CE File Offset: 0x000079CE
	public NetworkPlayerProfileInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr))
	{
	}

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0003FD0C File Offset: 0x0003DF0C
	// (set) Token: 0x06000CAA RID: 3242 RVA: 0x000097E0 File Offset: 0x000079E0
	public unsafe uint userID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_userID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_userID)) = value;
		}
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0003FD34 File Offset: 0x0003DF34
	// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000097FB File Offset: 0x000079FB
	public unsafe uint inProgressGames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_inProgressGames);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_inProgressGames)) = value;
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0003FD5C File Offset: 0x0003DF5C
	// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00009816 File Offset: 0x00007A16
	public NetworkPlayerGameTypeInfo userGameStats
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_userGameStats);
			return new NetworkPlayerGameTypeInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_userGameStats), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0003FD8C File Offset: 0x0003DF8C
	// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00009844 File Offset: 0x00007A44
	public unsafe ushort userAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_userAvatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_userAvatar)) = value;
		}
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0003FDB4 File Offset: 0x0003DFB4
	// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x0000985F File Offset: 0x00007A5F
	public unsafe string displayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_displayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerProfileInfo.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040007FC RID: 2044
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x040007FD RID: 2045
	private static readonly IntPtr NativeFieldInfoPtr_inProgressGames;

	// Token: 0x040007FE RID: 2046
	private static readonly IntPtr NativeFieldInfoPtr_userGameStats;

	// Token: 0x040007FF RID: 2047
	private static readonly IntPtr NativeFieldInfoPtr_userAvatar;

	// Token: 0x04000800 RID: 2048
	private static readonly IntPtr NativeFieldInfoPtr_displayName;
}
