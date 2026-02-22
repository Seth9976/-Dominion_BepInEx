using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000110 RID: 272
public class GameDataExample : Object
{
	// Token: 0x060012B8 RID: 4792 RVA: 0x00057E04 File Offset: 0x00056004
	// Note: this type is marked as 'beforefieldinit'.
	static GameDataExample()
	{
		Il2CppClassPointerStore<GameDataExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GameDataExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataExample>.NativeClassPtr);
		GameDataExample.NativeMethodInfoPtr_get_coins_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataExample>.NativeClassPtr, 100665556);
		GameDataExample.NativeMethodInfoPtr_AddCoins_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataExample>.NativeClassPtr, 100665557);
		GameDataExample.NativeMethodInfoPtr_EnableCoinsBoost_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataExample>.NativeClassPtr, 100665558);
		GameDataExample.NativeMethodInfoPtr_get_IsBoostPurchased_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataExample>.NativeClassPtr, 100665559);
		GameDataExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataExample>.NativeClassPtr, 100665560);
	}

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00057E98 File Offset: 0x00056098
	public unsafe static int coins
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183363, RefRangeEnd = 183364, XrefRangeStart = 183360, XrefRangeEnd = 183363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataExample.NativeMethodInfoPtr_get_coins_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x00057EC8 File Offset: 0x000560C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183364, XrefRangeEnd = 183377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCoins(int amount)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataExample.NativeMethodInfoPtr_AddCoins_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x00057EFC File Offset: 0x000560FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183377, XrefRangeEnd = 183380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableCoinsBoost()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataExample.NativeMethodInfoPtr_EnableCoinsBoost_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x060012BC RID: 4796 RVA: 0x00057F24 File Offset: 0x00056124
	public unsafe static bool IsBoostPurchased
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183383, RefRangeEnd = 183384, XrefRangeStart = 183380, XrefRangeEnd = 183383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataExample.NativeMethodInfoPtr_get_IsBoostPurchased_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x00057F54 File Offset: 0x00056154
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameDataExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0000948E File Offset: 0x0000768E
	public GameDataExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000E5F RID: 3679
	private static readonly IntPtr NativeMethodInfoPtr_get_coins_Public_Static_get_Int32_0;

	// Token: 0x04000E60 RID: 3680
	private static readonly IntPtr NativeMethodInfoPtr_AddCoins_Public_Static_Void_Int32_0;

	// Token: 0x04000E61 RID: 3681
	private static readonly IntPtr NativeMethodInfoPtr_EnableCoinsBoost_Public_Static_Void_0;

	// Token: 0x04000E62 RID: 3682
	private static readonly IntPtr NativeMethodInfoPtr_get_IsBoostPurchased_Public_Static_get_Boolean_0;

	// Token: 0x04000E63 RID: 3683
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
