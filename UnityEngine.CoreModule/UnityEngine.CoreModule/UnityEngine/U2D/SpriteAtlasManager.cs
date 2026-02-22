using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x020000E6 RID: 230
	public class SpriteAtlasManager : Object
	{
		// Token: 0x06001436 RID: 5174 RVA: 0x0004E144 File Offset: 0x0004C344
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlasManager()
		{
			Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlasManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr);
			SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRequested");
			SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRegistered");
			SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100664751);
			SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100664752);
			SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100664753);
			SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100664754);
			SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100664755);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0004E200 File Offset: 0x0004C400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79509, XrefRangeEnd = 79517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestAtlas(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0004E244 File Offset: 0x0004C444
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79528, RefRangeEnd = 79531, XrefRangeStart = 79517, XrefRangeEnd = 79528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_atlasRegistered(Action<SpriteAtlas> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0004E27C File Offset: 0x0004C47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79542, RefRangeEnd = 79543, XrefRangeStart = 79531, XrefRangeEnd = 79542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_atlasRegistered(Action<SpriteAtlas> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0004E2B4 File Offset: 0x0004C4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79543, XrefRangeEnd = 79550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0004E2EC File Offset: 0x0004C4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79550, XrefRangeEnd = 79552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(SpriteAtlas spriteAtlas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0000BA71 File Offset: 0x00009C71
		public SpriteAtlasManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0004E324 File Offset: 0x0004C524
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0000BA7A File Offset: 0x00009C7A
		public unsafe static Action<string, Action<SpriteAtlas>> atlasRequested
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Action<SpriteAtlas>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0004E34C File Offset: 0x0004C54C
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0000BA8C File Offset: 0x00009C8C
		public unsafe static Action<SpriteAtlas> atlasRegistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteAtlas>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_atlasRequested;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr_atlasRegistered;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0;
	}
}
