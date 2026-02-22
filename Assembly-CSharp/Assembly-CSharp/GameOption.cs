using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000031 RID: 49
public sealed class GameOption : ValueType
{
	// Token: 0x06000935 RID: 2357 RVA: 0x00034F90 File Offset: 0x00033190
	// Note: this type is marked as 'beforefieldinit'.
	static GameOption()
	{
		Il2CppClassPointerStore<GameOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameOption");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOption>.NativeClassPtr);
		GameOption.NativeFieldInfoPtr_optionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOption>.NativeClassPtr, "optionIndex");
		GameOption.NativeFieldInfoPtr_selectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOption>.NativeClassPtr, "selectionID");
		GameOption.NativeFieldInfoPtr_selectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOption>.NativeClassPtr, "selectionHint");
		GameOption.NativeFieldInfoPtr_isHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOption>.NativeClassPtr, "isHidden");
		GameOption.NativeFieldInfoPtr_optionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOption>.NativeClassPtr, "optionText");
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00007B90 File Offset: 0x00005D90
	public GameOption(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00007B99 File Offset: 0x00005D99
	public GameOption()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOption>.NativeClassPtr))
	{
	}

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x06000938 RID: 2360 RVA: 0x00035024 File Offset: 0x00033224
	// (set) Token: 0x06000939 RID: 2361 RVA: 0x00007BAB File Offset: 0x00005DAB
	public unsafe int optionIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_optionIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_optionIndex)) = value;
		}
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x0600093A RID: 2362 RVA: 0x0003504C File Offset: 0x0003324C
	// (set) Token: 0x0600093B RID: 2363 RVA: 0x00007BC6 File Offset: 0x00005DC6
	public unsafe ushort selectionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_selectionID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_selectionID)) = value;
		}
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x0600093C RID: 2364 RVA: 0x00035074 File Offset: 0x00033274
	// (set) Token: 0x0600093D RID: 2365 RVA: 0x00007BE1 File Offset: 0x00005DE1
	public unsafe ushort selectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_selectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_selectionHint)) = value;
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x0600093E RID: 2366 RVA: 0x0003509C File Offset: 0x0003329C
	// (set) Token: 0x0600093F RID: 2367 RVA: 0x00007BFC File Offset: 0x00005DFC
	public unsafe byte isHidden
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_isHidden);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_isHidden)) = value;
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06000940 RID: 2368 RVA: 0x000350C4 File Offset: 0x000332C4
	// (set) Token: 0x06000941 RID: 2369 RVA: 0x00007C17 File Offset: 0x00005E17
	public unsafe string optionText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_optionText);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOption.NativeFieldInfoPtr_optionText), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040005B5 RID: 1461
	private static readonly IntPtr NativeFieldInfoPtr_optionIndex;

	// Token: 0x040005B6 RID: 1462
	private static readonly IntPtr NativeFieldInfoPtr_selectionID;

	// Token: 0x040005B7 RID: 1463
	private static readonly IntPtr NativeFieldInfoPtr_selectionHint;

	// Token: 0x040005B8 RID: 1464
	private static readonly IntPtr NativeFieldInfoPtr_isHidden;

	// Token: 0x040005B9 RID: 1465
	private static readonly IntPtr NativeFieldInfoPtr_optionText;
}
