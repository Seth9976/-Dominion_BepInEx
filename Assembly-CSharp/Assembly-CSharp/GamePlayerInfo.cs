using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004C RID: 76
public sealed class GamePlayerInfo : ValueType
{
	// Token: 0x06000CB3 RID: 3251 RVA: 0x0003FDDC File Offset: 0x0003DFDC
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerInfo()
	{
		Il2CppClassPointerStore<GamePlayerInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerInfo>.NativeClassPtr);
		GamePlayerInfo.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerInfo>.NativeClassPtr, "userID");
		GamePlayerInfo.NativeFieldInfoPtr_forfeit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerInfo>.NativeClassPtr, "forfeit");
		GamePlayerInfo.NativeFieldInfoPtr_avatarIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerInfo>.NativeClassPtr, "avatarIndex");
		GamePlayerInfo.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerInfo>.NativeClassPtr, "displayName");
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x0000987E File Offset: 0x00007A7E
	public GamePlayerInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00009887 File Offset: 0x00007A87
	public GamePlayerInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamePlayerInfo>.NativeClassPtr))
	{
	}

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0003FE5C File Offset: 0x0003E05C
	// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00009899 File Offset: 0x00007A99
	public unsafe uint userID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_userID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_userID)) = value;
		}
	}

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0003FE84 File Offset: 0x0003E084
	// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x000098B4 File Offset: 0x00007AB4
	public unsafe uint forfeit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_forfeit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_forfeit)) = value;
		}
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0003FEAC File Offset: 0x0003E0AC
	// (set) Token: 0x06000CBB RID: 3259 RVA: 0x000098CF File Offset: 0x00007ACF
	public unsafe ushort avatarIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_avatarIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_avatarIndex)) = value;
		}
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0003FED4 File Offset: 0x0003E0D4
	// (set) Token: 0x06000CBD RID: 3261 RVA: 0x000098EA File Offset: 0x00007AEA
	public unsafe string displayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_displayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePlayerInfo.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000801 RID: 2049
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x04000802 RID: 2050
	private static readonly IntPtr NativeFieldInfoPtr_forfeit;

	// Token: 0x04000803 RID: 2051
	private static readonly IntPtr NativeFieldInfoPtr_avatarIndex;

	// Token: 0x04000804 RID: 2052
	private static readonly IntPtr NativeFieldInfoPtr_displayName;
}
