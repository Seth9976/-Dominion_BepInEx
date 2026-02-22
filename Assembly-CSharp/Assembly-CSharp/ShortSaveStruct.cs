using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000048 RID: 72
[Serializable]
public sealed class ShortSaveStruct : ValueType
{
	// Token: 0x06000C3B RID: 3131 RVA: 0x0003F05C File Offset: 0x0003D25C
	// Note: this type is marked as 'beforefieldinit'.
	static ShortSaveStruct()
	{
		Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShortSaveStruct");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr);
		ShortSaveStruct.NativeFieldInfoPtr_playdekHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "playdekHeader");
		ShortSaveStruct.NativeFieldInfoPtr_saveFileVersionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "saveFileVersionNumber");
		ShortSaveStruct.NativeFieldInfoPtr_player1Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player1Name");
		ShortSaveStruct.NativeFieldInfoPtr_player2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player2Name");
		ShortSaveStruct.NativeFieldInfoPtr_player3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player3Name");
		ShortSaveStruct.NativeFieldInfoPtr_player4Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player4Name");
		ShortSaveStruct.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "gameID");
		ShortSaveStruct.NativeFieldInfoPtr_setFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "setFlags");
		ShortSaveStruct.NativeFieldInfoPtr_promoFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "promoFlags");
		ShortSaveStruct.NativeFieldInfoPtr_honorRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "honorRemaining");
		ShortSaveStruct.NativeFieldInfoPtr_startingHonorAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "startingHonorAdjustment");
		ShortSaveStruct.NativeFieldInfoPtr_roundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "roundNumber");
		ShortSaveStruct.NativeFieldInfoPtr_decisionPlayerFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "decisionPlayerFlags");
		ShortSaveStruct.NativeFieldInfoPtr_currentTurnPlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "currentTurnPlayerIndex");
		ShortSaveStruct.NativeFieldInfoPtr_worldDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "worldDataVersion");
		ShortSaveStruct.NativeFieldInfoPtr_savedDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "savedDataSize");
		ShortSaveStruct.NativeFieldInfoPtr_gameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "gameState");
		ShortSaveStruct.NativeFieldInfoPtr_player1State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player1State");
		ShortSaveStruct.NativeFieldInfoPtr_player2State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player2State");
		ShortSaveStruct.NativeFieldInfoPtr_player3State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player3State");
		ShortSaveStruct.NativeFieldInfoPtr_player4State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player4State");
		ShortSaveStruct.NativeFieldInfoPtr_player1Rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player1Rating");
		ShortSaveStruct.NativeFieldInfoPtr_player2Rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player2Rating");
		ShortSaveStruct.NativeFieldInfoPtr_player3Rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player3Rating");
		ShortSaveStruct.NativeFieldInfoPtr_player4Rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player4Rating");
		ShortSaveStruct.NativeFieldInfoPtr_player1Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player1Timer");
		ShortSaveStruct.NativeFieldInfoPtr_player2Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player2Timer");
		ShortSaveStruct.NativeFieldInfoPtr_player3Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player3Timer");
		ShortSaveStruct.NativeFieldInfoPtr_player4Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player4Timer");
		ShortSaveStruct.NativeFieldInfoPtr_updateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "updateTime");
		ShortSaveStruct.NativeFieldInfoPtr_player1ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player1ID");
		ShortSaveStruct.NativeFieldInfoPtr_player2ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player2ID");
		ShortSaveStruct.NativeFieldInfoPtr_player3ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player3ID");
		ShortSaveStruct.NativeFieldInfoPtr_player4ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player4ID");
		ShortSaveStruct.NativeFieldInfoPtr_player1Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player1Avatar");
		ShortSaveStruct.NativeFieldInfoPtr_player2Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player2Avatar");
		ShortSaveStruct.NativeFieldInfoPtr_player3Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player3Avatar");
		ShortSaveStruct.NativeFieldInfoPtr_player4Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "player4Avatar");
		ShortSaveStruct.NativeFieldInfoPtr_packedPlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "packedPlayerCount");
		ShortSaveStruct.NativeFieldInfoPtr_playdekFooter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, "playdekFooter");
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00009225 File Offset: 0x00007425
	public ShortSaveStruct(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x0000922E File Offset: 0x0000742E
	public ShortSaveStruct()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr))
	{
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0003F3AC File Offset: 0x0003D5AC
	// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00009240 File Offset: 0x00007440
	public unsafe string playdekHeader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_playdekHeader);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_playdekHeader), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0003F3D4 File Offset: 0x0003D5D4
	// (set) Token: 0x06000C41 RID: 3137 RVA: 0x0000925F File Offset: 0x0000745F
	public unsafe uint saveFileVersionNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_saveFileVersionNumber);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_saveFileVersionNumber)) = value;
		}
	}

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0003F3FC File Offset: 0x0003D5FC
	// (set) Token: 0x06000C43 RID: 3139 RVA: 0x0000927A File Offset: 0x0000747A
	public unsafe string player1Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0003F424 File Offset: 0x0003D624
	// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00009299 File Offset: 0x00007499
	public unsafe string player2Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0003F44C File Offset: 0x0003D64C
	// (set) Token: 0x06000C47 RID: 3143 RVA: 0x000092B8 File Offset: 0x000074B8
	public unsafe string player3Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0003F474 File Offset: 0x0003D674
	// (set) Token: 0x06000C49 RID: 3145 RVA: 0x000092D7 File Offset: 0x000074D7
	public unsafe string player4Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0003F49C File Offset: 0x0003D69C
	// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000092F6 File Offset: 0x000074F6
	public unsafe int gameID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_gameID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_gameID)) = value;
		}
	}

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0003F4C4 File Offset: 0x0003D6C4
	// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00009311 File Offset: 0x00007511
	public unsafe uint setFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_setFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_setFlags)) = value;
		}
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0003F4EC File Offset: 0x0003D6EC
	// (set) Token: 0x06000C4F RID: 3151 RVA: 0x0000932C File Offset: 0x0000752C
	public unsafe uint promoFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_promoFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_promoFlags)) = value;
		}
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0003F514 File Offset: 0x0003D714
	// (set) Token: 0x06000C51 RID: 3153 RVA: 0x00009347 File Offset: 0x00007547
	public unsafe uint honorRemaining
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_honorRemaining);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_honorRemaining)) = value;
		}
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0003F53C File Offset: 0x0003D73C
	// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00009362 File Offset: 0x00007562
	public unsafe uint startingHonorAdjustment
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_startingHonorAdjustment);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_startingHonorAdjustment)) = value;
		}
	}

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0003F564 File Offset: 0x0003D764
	// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0000937D File Offset: 0x0000757D
	public unsafe int roundNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_roundNumber);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_roundNumber)) = value;
		}
	}

	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0003F58C File Offset: 0x0003D78C
	// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00009398 File Offset: 0x00007598
	public unsafe int decisionPlayerFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_decisionPlayerFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_decisionPlayerFlags)) = value;
		}
	}

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003F5B4 File Offset: 0x0003D7B4
	// (set) Token: 0x06000C59 RID: 3161 RVA: 0x000093B3 File Offset: 0x000075B3
	public unsafe int currentTurnPlayerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_currentTurnPlayerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_currentTurnPlayerIndex)) = value;
		}
	}

	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0003F5DC File Offset: 0x0003D7DC
	// (set) Token: 0x06000C5B RID: 3163 RVA: 0x000093CE File Offset: 0x000075CE
	public unsafe int worldDataVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_worldDataVersion);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_worldDataVersion)) = value;
		}
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0003F604 File Offset: 0x0003D804
	// (set) Token: 0x06000C5D RID: 3165 RVA: 0x000093E9 File Offset: 0x000075E9
	public unsafe int savedDataSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_savedDataSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_savedDataSize)) = value;
		}
	}

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0003F62C File Offset: 0x0003D82C
	// (set) Token: 0x06000C5F RID: 3167 RVA: 0x00009404 File Offset: 0x00007604
	public unsafe uint gameState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_gameState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_gameState)) = value;
		}
	}

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003F654 File Offset: 0x0003D854
	// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0000941F File Offset: 0x0000761F
	public unsafe ushort player1State
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1State);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1State)) = value;
		}
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0003F67C File Offset: 0x0003D87C
	// (set) Token: 0x06000C63 RID: 3171 RVA: 0x0000943A File Offset: 0x0000763A
	public unsafe ushort player2State
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2State);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2State)) = value;
		}
	}

	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0003F6A4 File Offset: 0x0003D8A4
	// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00009455 File Offset: 0x00007655
	public unsafe ushort player3State
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3State);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3State)) = value;
		}
	}

	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0003F6CC File Offset: 0x0003D8CC
	// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00009470 File Offset: 0x00007670
	public unsafe ushort player4State
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4State);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4State)) = value;
		}
	}

	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
	// (set) Token: 0x06000C69 RID: 3177 RVA: 0x0000948B File Offset: 0x0000768B
	public unsafe ushort player1Rating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Rating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Rating)) = value;
		}
	}

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0003F71C File Offset: 0x0003D91C
	// (set) Token: 0x06000C6B RID: 3179 RVA: 0x000094A6 File Offset: 0x000076A6
	public unsafe ushort player2Rating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Rating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Rating)) = value;
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0003F744 File Offset: 0x0003D944
	// (set) Token: 0x06000C6D RID: 3181 RVA: 0x000094C1 File Offset: 0x000076C1
	public unsafe ushort player3Rating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Rating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Rating)) = value;
		}
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x06000C6E RID: 3182 RVA: 0x0003F76C File Offset: 0x0003D96C
	// (set) Token: 0x06000C6F RID: 3183 RVA: 0x000094DC File Offset: 0x000076DC
	public unsafe ushort player4Rating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Rating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Rating)) = value;
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0003F794 File Offset: 0x0003D994
	// (set) Token: 0x06000C71 RID: 3185 RVA: 0x000094F7 File Offset: 0x000076F7
	public unsafe uint player1Timer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Timer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Timer)) = value;
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0003F7BC File Offset: 0x0003D9BC
	// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00009512 File Offset: 0x00007712
	public unsafe uint player2Timer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Timer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Timer)) = value;
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0003F7E4 File Offset: 0x0003D9E4
	// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0000952D File Offset: 0x0000772D
	public unsafe uint player3Timer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Timer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Timer)) = value;
		}
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0003F80C File Offset: 0x0003DA0C
	// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00009548 File Offset: 0x00007748
	public unsafe uint player4Timer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Timer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Timer)) = value;
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0003F834 File Offset: 0x0003DA34
	// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00009563 File Offset: 0x00007763
	public unsafe uint updateTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_updateTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_updateTime)) = value;
		}
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0003F85C File Offset: 0x0003DA5C
	// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0000957E File Offset: 0x0000777E
	public unsafe int player1ID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1ID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1ID)) = value;
		}
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0003F884 File Offset: 0x0003DA84
	// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00009599 File Offset: 0x00007799
	public unsafe int player2ID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2ID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2ID)) = value;
		}
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0003F8AC File Offset: 0x0003DAAC
	// (set) Token: 0x06000C7F RID: 3199 RVA: 0x000095B4 File Offset: 0x000077B4
	public unsafe int player3ID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3ID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3ID)) = value;
		}
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0003F8D4 File Offset: 0x0003DAD4
	// (set) Token: 0x06000C81 RID: 3201 RVA: 0x000095CF File Offset: 0x000077CF
	public unsafe int player4ID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4ID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4ID)) = value;
		}
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0003F8FC File Offset: 0x0003DAFC
	// (set) Token: 0x06000C83 RID: 3203 RVA: 0x000095EA File Offset: 0x000077EA
	public unsafe int player1Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Avatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player1Avatar)) = value;
		}
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0003F924 File Offset: 0x0003DB24
	// (set) Token: 0x06000C85 RID: 3205 RVA: 0x00009605 File Offset: 0x00007805
	public unsafe int player2Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Avatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player2Avatar)) = value;
		}
	}

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0003F94C File Offset: 0x0003DB4C
	// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00009620 File Offset: 0x00007820
	public unsafe int player3Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Avatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player3Avatar)) = value;
		}
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0003F974 File Offset: 0x0003DB74
	// (set) Token: 0x06000C89 RID: 3209 RVA: 0x0000963B File Offset: 0x0000783B
	public unsafe int player4Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Avatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_player4Avatar)) = value;
		}
	}

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0003F99C File Offset: 0x0003DB9C
	// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00009656 File Offset: 0x00007856
	public unsafe uint packedPlayerCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_packedPlayerCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_packedPlayerCount)) = value;
		}
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x06000C8C RID: 3212 RVA: 0x0003F9C4 File Offset: 0x0003DBC4
	// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00009671 File Offset: 0x00007871
	public unsafe string playdekFooter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_playdekFooter);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortSaveStruct.NativeFieldInfoPtr_playdekFooter), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040007CB RID: 1995
	private static readonly IntPtr NativeFieldInfoPtr_playdekHeader;

	// Token: 0x040007CC RID: 1996
	private static readonly IntPtr NativeFieldInfoPtr_saveFileVersionNumber;

	// Token: 0x040007CD RID: 1997
	private static readonly IntPtr NativeFieldInfoPtr_player1Name;

	// Token: 0x040007CE RID: 1998
	private static readonly IntPtr NativeFieldInfoPtr_player2Name;

	// Token: 0x040007CF RID: 1999
	private static readonly IntPtr NativeFieldInfoPtr_player3Name;

	// Token: 0x040007D0 RID: 2000
	private static readonly IntPtr NativeFieldInfoPtr_player4Name;

	// Token: 0x040007D1 RID: 2001
	private static readonly IntPtr NativeFieldInfoPtr_gameID;

	// Token: 0x040007D2 RID: 2002
	private static readonly IntPtr NativeFieldInfoPtr_setFlags;

	// Token: 0x040007D3 RID: 2003
	private static readonly IntPtr NativeFieldInfoPtr_promoFlags;

	// Token: 0x040007D4 RID: 2004
	private static readonly IntPtr NativeFieldInfoPtr_honorRemaining;

	// Token: 0x040007D5 RID: 2005
	private static readonly IntPtr NativeFieldInfoPtr_startingHonorAdjustment;

	// Token: 0x040007D6 RID: 2006
	private static readonly IntPtr NativeFieldInfoPtr_roundNumber;

	// Token: 0x040007D7 RID: 2007
	private static readonly IntPtr NativeFieldInfoPtr_decisionPlayerFlags;

	// Token: 0x040007D8 RID: 2008
	private static readonly IntPtr NativeFieldInfoPtr_currentTurnPlayerIndex;

	// Token: 0x040007D9 RID: 2009
	private static readonly IntPtr NativeFieldInfoPtr_worldDataVersion;

	// Token: 0x040007DA RID: 2010
	private static readonly IntPtr NativeFieldInfoPtr_savedDataSize;

	// Token: 0x040007DB RID: 2011
	private static readonly IntPtr NativeFieldInfoPtr_gameState;

	// Token: 0x040007DC RID: 2012
	private static readonly IntPtr NativeFieldInfoPtr_player1State;

	// Token: 0x040007DD RID: 2013
	private static readonly IntPtr NativeFieldInfoPtr_player2State;

	// Token: 0x040007DE RID: 2014
	private static readonly IntPtr NativeFieldInfoPtr_player3State;

	// Token: 0x040007DF RID: 2015
	private static readonly IntPtr NativeFieldInfoPtr_player4State;

	// Token: 0x040007E0 RID: 2016
	private static readonly IntPtr NativeFieldInfoPtr_player1Rating;

	// Token: 0x040007E1 RID: 2017
	private static readonly IntPtr NativeFieldInfoPtr_player2Rating;

	// Token: 0x040007E2 RID: 2018
	private static readonly IntPtr NativeFieldInfoPtr_player3Rating;

	// Token: 0x040007E3 RID: 2019
	private static readonly IntPtr NativeFieldInfoPtr_player4Rating;

	// Token: 0x040007E4 RID: 2020
	private static readonly IntPtr NativeFieldInfoPtr_player1Timer;

	// Token: 0x040007E5 RID: 2021
	private static readonly IntPtr NativeFieldInfoPtr_player2Timer;

	// Token: 0x040007E6 RID: 2022
	private static readonly IntPtr NativeFieldInfoPtr_player3Timer;

	// Token: 0x040007E7 RID: 2023
	private static readonly IntPtr NativeFieldInfoPtr_player4Timer;

	// Token: 0x040007E8 RID: 2024
	private static readonly IntPtr NativeFieldInfoPtr_updateTime;

	// Token: 0x040007E9 RID: 2025
	private static readonly IntPtr NativeFieldInfoPtr_player1ID;

	// Token: 0x040007EA RID: 2026
	private static readonly IntPtr NativeFieldInfoPtr_player2ID;

	// Token: 0x040007EB RID: 2027
	private static readonly IntPtr NativeFieldInfoPtr_player3ID;

	// Token: 0x040007EC RID: 2028
	private static readonly IntPtr NativeFieldInfoPtr_player4ID;

	// Token: 0x040007ED RID: 2029
	private static readonly IntPtr NativeFieldInfoPtr_player1Avatar;

	// Token: 0x040007EE RID: 2030
	private static readonly IntPtr NativeFieldInfoPtr_player2Avatar;

	// Token: 0x040007EF RID: 2031
	private static readonly IntPtr NativeFieldInfoPtr_player3Avatar;

	// Token: 0x040007F0 RID: 2032
	private static readonly IntPtr NativeFieldInfoPtr_player4Avatar;

	// Token: 0x040007F1 RID: 2033
	private static readonly IntPtr NativeFieldInfoPtr_packedPlayerCount;

	// Token: 0x040007F2 RID: 2034
	private static readonly IntPtr NativeFieldInfoPtr_playdekFooter;
}
