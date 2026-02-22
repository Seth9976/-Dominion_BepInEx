using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000079 RID: 121
[Serializable]
public sealed class AchievementData : ValueType
{
	// Token: 0x06000F28 RID: 3880 RVA: 0x00046540 File Offset: 0x00044740
	// Note: this type is marked as 'beforefieldinit'.
	static AchievementData()
	{
		Il2CppClassPointerStore<AchievementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AchievementData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementData>.NativeClassPtr);
		AchievementData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "id");
		AchievementData.NativeFieldInfoPtr_achievedAtValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "achievedAtValue");
		AchievementData.NativeFieldInfoPtr_isBitField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "isBitField");
		AchievementData.NativeFieldInfoPtr_steamStatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "steamStatName");
		AchievementData.NativeFieldInfoPtr_idNameSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "idNameSteam");
		AchievementData.NativeFieldInfoPtr_idNameIOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "idNameIOS");
		AchievementData.NativeFieldInfoPtr_idNameAndroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "idNameAndroid");
		AchievementData.NativeFieldInfoPtr_lockedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "lockedSprite");
		AchievementData.NativeFieldInfoPtr_unlockedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "unlockedSprite");
		AchievementData.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "displayName");
		AchievementData.NativeFieldInfoPtr_displayDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "displayDescription");
		AchievementData.NativeFieldInfoPtr_pointValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "pointValue");
		AchievementData.NativeFieldInfoPtr_isHiddenAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "isHiddenAchievement");
		AchievementData.NativeFieldInfoPtr_dontShowAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "dontShowAchievement");
		AchievementData.NativeFieldInfoPtr_setIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "setIndex");
		AchievementData.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "currentValue");
		AchievementData.NativeFieldInfoPtr_bHasAchieved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "bHasAchieved");
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0000ABE6 File Offset: 0x00008DE6
	public AchievementData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0000ABEF File Offset: 0x00008DEF
	public AchievementData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementData>.NativeClassPtr))
	{
	}

	// Token: 0x17000513 RID: 1299
	// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000466C4 File Offset: 0x000448C4
	// (set) Token: 0x06000F2C RID: 3884 RVA: 0x0000AC01 File Offset: 0x00008E01
	public unsafe EAchievements id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_id)) = value;
		}
	}

	// Token: 0x17000514 RID: 1300
	// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000466EC File Offset: 0x000448EC
	// (set) Token: 0x06000F2E RID: 3886 RVA: 0x0000AC1C File Offset: 0x00008E1C
	public unsafe int achievedAtValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_achievedAtValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_achievedAtValue)) = value;
		}
	}

	// Token: 0x17000515 RID: 1301
	// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00046714 File Offset: 0x00044914
	// (set) Token: 0x06000F30 RID: 3888 RVA: 0x0000AC37 File Offset: 0x00008E37
	public unsafe bool isBitField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_isBitField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_isBitField)) = value;
		}
	}

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x06000F31 RID: 3889 RVA: 0x0004673C File Offset: 0x0004493C
	// (set) Token: 0x06000F32 RID: 3890 RVA: 0x0000AC52 File Offset: 0x00008E52
	public unsafe string steamStatName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_steamStatName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_steamStatName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00046764 File Offset: 0x00044964
	// (set) Token: 0x06000F34 RID: 3892 RVA: 0x0000AC71 File Offset: 0x00008E71
	public unsafe string idNameSteam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_idNameSteam);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_idNameSteam), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0004678C File Offset: 0x0004498C
	// (set) Token: 0x06000F36 RID: 3894 RVA: 0x0000AC90 File Offset: 0x00008E90
	public unsafe string idNameIOS
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_idNameIOS);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_idNameIOS), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000467B4 File Offset: 0x000449B4
	// (set) Token: 0x06000F38 RID: 3896 RVA: 0x0000ACAF File Offset: 0x00008EAF
	public unsafe string idNameAndroid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_idNameAndroid);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_idNameAndroid), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000467DC File Offset: 0x000449DC
	// (set) Token: 0x06000F3A RID: 3898 RVA: 0x0000ACCE File Offset: 0x00008ECE
	public unsafe Sprite lockedSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_lockedSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_lockedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700051B RID: 1307
	// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0004680C File Offset: 0x00044A0C
	// (set) Token: 0x06000F3C RID: 3900 RVA: 0x0000ACED File Offset: 0x00008EED
	public unsafe Sprite unlockedSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_unlockedSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_unlockedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700051C RID: 1308
	// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0004683C File Offset: 0x00044A3C
	// (set) Token: 0x06000F3E RID: 3902 RVA: 0x0000AD0C File Offset: 0x00008F0C
	public unsafe string displayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_displayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00046864 File Offset: 0x00044A64
	// (set) Token: 0x06000F40 RID: 3904 RVA: 0x0000AD2B File Offset: 0x00008F2B
	public unsafe string displayDescription
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_displayDescription);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_displayDescription), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0004688C File Offset: 0x00044A8C
	// (set) Token: 0x06000F42 RID: 3906 RVA: 0x0000AD4A File Offset: 0x00008F4A
	public unsafe int pointValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_pointValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_pointValue)) = value;
		}
	}

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000468B4 File Offset: 0x00044AB4
	// (set) Token: 0x06000F44 RID: 3908 RVA: 0x0000AD65 File Offset: 0x00008F65
	public unsafe bool isHiddenAchievement
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_isHiddenAchievement);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_isHiddenAchievement)) = value;
		}
	}

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000468DC File Offset: 0x00044ADC
	// (set) Token: 0x06000F46 RID: 3910 RVA: 0x0000AD80 File Offset: 0x00008F80
	public unsafe bool dontShowAchievement
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_dontShowAchievement);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_dontShowAchievement)) = value;
		}
	}

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00046904 File Offset: 0x00044B04
	// (set) Token: 0x06000F48 RID: 3912 RVA: 0x0000AD9B File Offset: 0x00008F9B
	public unsafe uint setIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_setIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_setIndex)) = value;
		}
	}

	// Token: 0x17000522 RID: 1314
	// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0004692C File Offset: 0x00044B2C
	// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0000ADB6 File Offset: 0x00008FB6
	public unsafe long currentValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_currentValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_currentValue)) = value;
		}
	}

	// Token: 0x17000523 RID: 1315
	// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00046954 File Offset: 0x00044B54
	// (set) Token: 0x06000F4C RID: 3916 RVA: 0x0000ADD1 File Offset: 0x00008FD1
	public unsafe bool bHasAchieved
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_bHasAchieved);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_bHasAchieved)) = value;
		}
	}

	// Token: 0x04000AAA RID: 2730
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04000AAB RID: 2731
	private static readonly IntPtr NativeFieldInfoPtr_achievedAtValue;

	// Token: 0x04000AAC RID: 2732
	private static readonly IntPtr NativeFieldInfoPtr_isBitField;

	// Token: 0x04000AAD RID: 2733
	private static readonly IntPtr NativeFieldInfoPtr_steamStatName;

	// Token: 0x04000AAE RID: 2734
	private static readonly IntPtr NativeFieldInfoPtr_idNameSteam;

	// Token: 0x04000AAF RID: 2735
	private static readonly IntPtr NativeFieldInfoPtr_idNameIOS;

	// Token: 0x04000AB0 RID: 2736
	private static readonly IntPtr NativeFieldInfoPtr_idNameAndroid;

	// Token: 0x04000AB1 RID: 2737
	private static readonly IntPtr NativeFieldInfoPtr_lockedSprite;

	// Token: 0x04000AB2 RID: 2738
	private static readonly IntPtr NativeFieldInfoPtr_unlockedSprite;

	// Token: 0x04000AB3 RID: 2739
	private static readonly IntPtr NativeFieldInfoPtr_displayName;

	// Token: 0x04000AB4 RID: 2740
	private static readonly IntPtr NativeFieldInfoPtr_displayDescription;

	// Token: 0x04000AB5 RID: 2741
	private static readonly IntPtr NativeFieldInfoPtr_pointValue;

	// Token: 0x04000AB6 RID: 2742
	private static readonly IntPtr NativeFieldInfoPtr_isHiddenAchievement;

	// Token: 0x04000AB7 RID: 2743
	private static readonly IntPtr NativeFieldInfoPtr_dontShowAchievement;

	// Token: 0x04000AB8 RID: 2744
	private static readonly IntPtr NativeFieldInfoPtr_setIndex;

	// Token: 0x04000AB9 RID: 2745
	private static readonly IntPtr NativeFieldInfoPtr_currentValue;

	// Token: 0x04000ABA RID: 2746
	private static readonly IntPtr NativeFieldInfoPtr_bHasAchieved;
}
