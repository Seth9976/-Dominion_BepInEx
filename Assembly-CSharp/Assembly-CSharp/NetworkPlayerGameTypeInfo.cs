using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200004A RID: 74
public sealed class NetworkPlayerGameTypeInfo : ValueType
{
	// Token: 0x06000C99 RID: 3225 RVA: 0x0003FB0C File Offset: 0x0003DD0C
	// Note: this type is marked as 'beforefieldinit'.
	static NetworkPlayerGameTypeInfo()
	{
		Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkPlayerGameTypeInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr);
		NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_userRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr, "userRating");
		NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_completedGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr, "completedGames");
		NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_forfeits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr, "forfeits");
		NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_wins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr, "wins");
		NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_losses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr, "losses");
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x0000971B File Offset: 0x0000791B
	public NetworkPlayerGameTypeInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00009724 File Offset: 0x00007924
	public NetworkPlayerGameTypeInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkPlayerGameTypeInfo>.NativeClassPtr))
	{
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0003FBA0 File Offset: 0x0003DDA0
	// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00009736 File Offset: 0x00007936
	public unsafe ushort userRating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_userRating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_userRating)) = value;
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0003FBC8 File Offset: 0x0003DDC8
	// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00009751 File Offset: 0x00007951
	public unsafe uint completedGames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_completedGames);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_completedGames)) = value;
		}
	}

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0003FBF0 File Offset: 0x0003DDF0
	// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x0000976C File Offset: 0x0000796C
	public unsafe uint forfeits
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_forfeits);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_forfeits)) = value;
		}
	}

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x0003FC18 File Offset: 0x0003DE18
	// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00009787 File Offset: 0x00007987
	public unsafe Il2CppStructArray<uint> wins
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_wins);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_wins), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0003FC48 File Offset: 0x0003DE48
	// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x000097A6 File Offset: 0x000079A6
	public unsafe Il2CppStructArray<uint> losses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_losses);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkPlayerGameTypeInfo.NativeFieldInfoPtr_losses), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040007F7 RID: 2039
	private static readonly IntPtr NativeFieldInfoPtr_userRating;

	// Token: 0x040007F8 RID: 2040
	private static readonly IntPtr NativeFieldInfoPtr_completedGames;

	// Token: 0x040007F9 RID: 2041
	private static readonly IntPtr NativeFieldInfoPtr_forfeits;

	// Token: 0x040007FA RID: 2042
	private static readonly IntPtr NativeFieldInfoPtr_wins;

	// Token: 0x040007FB RID: 2043
	private static readonly IntPtr NativeFieldInfoPtr_losses;
}
