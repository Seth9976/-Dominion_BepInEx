using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200004A RID: 74
	public static class CustomRenderTextureManager : Object
	{
		// Token: 0x060004F1 RID: 1265 RVA: 0x00022344 File Offset: 0x00020544
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTextureManager()
		{
			Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTextureManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr);
			CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureLoaded");
			CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureUnloaded");
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100663581);
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100663582);
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField = IL2CPP.ResolveICall<CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate>("UnityEngine.CustomRenderTextureManager::GetAllCustomRenderTextures");
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000223D4 File Offset: 0x000205D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62489, XrefRangeEnd = 62494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0002240C File Offset: 0x0002060C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62494, XrefRangeEnd = 62499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00004E56 File Offset: 0x00003056
		public CustomRenderTextureManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00022444 File Offset: 0x00020644
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00004E5F File Offset: 0x0000305F
		public unsafe static Action<CustomRenderTexture> textureLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0002246C File Offset: 0x0002066C
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00004E71 File Offset: 0x00003071
		public unsafe static Action<CustomRenderTexture> textureUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004E83 File Offset: 0x00003083
		public static void add_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004E90 File Offset: 0x00003090
		public static void remove_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004E9D File Offset: 0x0000309D
		public static void add_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00004EAA File Offset: 0x000030AA
		public static void remove_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004EB7 File Offset: 0x000030B7
		public static void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures)
		{
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(currentCustomRenderTextures));
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00004EC9 File Offset: 0x000030C9
		public static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00004ED6 File Offset: 0x000030D6
		public static void add_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00004EE3 File Offset: 0x000030E3
		public static void remove_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004EF0 File Offset: 0x000030F0
		public static void InvokeTriggerInitialize(CustomRenderTexture crt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr_textureLoaded;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr_textureUnloaded;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x0400035A RID: 858
		private static readonly CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate GetAllCustomRenderTexturesDelegateField;

		// Token: 0x02000455 RID: 1109
		// (Invoke) Token: 0x06002674 RID: 9844
		private delegate void GetAllCustomRenderTexturesDelegate(IntPtr currentCustomRenderTextures);
	}
}
