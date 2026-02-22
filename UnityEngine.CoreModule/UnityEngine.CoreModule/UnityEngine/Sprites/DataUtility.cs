using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Sprites
{
	// Token: 0x020000E4 RID: 228
	public sealed class DataUtility : Object
	{
		// Token: 0x06001411 RID: 5137 RVA: 0x0004DD38 File Offset: 0x0004BF38
		// Note: this type is marked as 'beforefieldinit'.
		static DataUtility()
		{
			Il2CppClassPointerStore<DataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Sprites", "DataUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataUtility>.NativeClassPtr);
			DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100664747);
			DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100664748);
			DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100664749);
			DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100664750);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0004DDB8 File Offset: 0x0004BFB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79493, RefRangeEnd = 79495, XrefRangeStart = 79492, XrefRangeEnd = 79493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetInnerUV(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0004DDFC File Offset: 0x0004BFFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 79496, RefRangeEnd = 79501, XrefRangeStart = 79495, XrefRangeEnd = 79496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetOuterUV(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0004DE40 File Offset: 0x0004C040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79502, RefRangeEnd = 79504, XrefRangeStart = 79501, XrefRangeEnd = 79502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetPadding(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0004DE84 File Offset: 0x0004C084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79508, RefRangeEnd = 79509, XrefRangeStart = 79504, XrefRangeEnd = 79508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetMinSize(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0000B942 File Offset: 0x00009B42
		public DataUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0;
	}
}
