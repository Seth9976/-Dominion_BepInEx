using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008E RID: 142
	public class PlayerPrefs : Object
	{
		// Token: 0x06000F0D RID: 3853 RVA: 0x0003EFC4 File Offset: 0x0003D1C4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPrefs()
		{
			Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr);
			PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664242);
			PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664243);
			PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664244);
			PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664245);
			PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664246);
			PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664247);
			PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664248);
			PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664249);
			PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664250);
			PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664251);
			PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664252);
			PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664253);
			PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664254);
			PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100664255);
			PlayerPrefs.DeleteAllDelegateField = IL2CPP.ResolveICall<PlayerPrefs.DeleteAllDelegate>("UnityEngine.PlayerPrefs::DeleteAll");
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0003F11C File Offset: 0x0003D31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetInt(string key, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0003F16C File Offset: 0x0003D36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67578, XrefRangeEnd = 67580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetFloat(string key, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0003F1BC File Offset: 0x0003D3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67580, XrefRangeEnd = 67582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetSetString(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0003F210 File Offset: 0x0003D410
		[CallerCount(87)]
		[CachedScanResults(RefRangeStart = 67584, RefRangeEnd = 67671, XrefRangeStart = 67582, XrefRangeEnd = 67584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInt(string key, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0003F254 File Offset: 0x0003D454
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 67673, RefRangeEnd = 67771, XrefRangeStart = 67671, XrefRangeEnd = 67673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key, int defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0003F2A4 File Offset: 0x0003D4A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 67773, RefRangeEnd = 67780, XrefRangeStart = 67771, XrefRangeEnd = 67773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0003F2E8 File Offset: 0x0003D4E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 67782, RefRangeEnd = 67794, XrefRangeStart = 67780, XrefRangeEnd = 67782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFloat(string key, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0003F32C File Offset: 0x0003D52C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 67796, RefRangeEnd = 67812, XrefRangeStart = 67794, XrefRangeEnd = 67796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloat(string key, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0003F37C File Offset: 0x0003D57C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 67814, RefRangeEnd = 67837, XrefRangeStart = 67812, XrefRangeEnd = 67814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetString(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003F3C4 File Offset: 0x0003D5C4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 67839, RefRangeEnd = 67852, XrefRangeStart = 67837, XrefRangeEnd = 67839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key, string defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0003F414 File Offset: 0x0003D614
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 67856, RefRangeEnd = 67862, XrefRangeStart = 67852, XrefRangeEnd = 67856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0003F450 File Offset: 0x0003D650
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 67864, RefRangeEnd = 67886, XrefRangeStart = 67862, XrefRangeEnd = 67864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0003F494 File Offset: 0x0003D694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67888, RefRangeEnd = 67889, XrefRangeStart = 67886, XrefRangeEnd = 67888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0003F4CC File Offset: 0x0003D6CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 67891, RefRangeEnd = 67894, XrefRangeStart = 67889, XrefRangeEnd = 67891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000099A4 File Offset: 0x00007BA4
		public PlayerPrefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0003F4F4 File Offset: 0x0003D6F4
		public static float GetFloat(string key)
		{
			return PlayerPrefs.GetFloat(key, 0f);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000099AD File Offset: 0x00007BAD
		public static void DeleteAll()
		{
			PlayerPrefs.DeleteAllDelegateField();
		}

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly PlayerPrefs.DeleteAllDelegate DeleteAllDelegateField;

		// Token: 0x0200075A RID: 1882
		// (Invoke) Token: 0x06002C75 RID: 11381
		private delegate void DeleteAllDelegate();
	}
}
